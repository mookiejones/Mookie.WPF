using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Remoting;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Windows.Threading;
#if NET462_OR_GREATER
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;

namespace Mookie.WPF
{
    public static class SingleInstance<TApplication> where TApplication : Application, ISingleInstanceApp
    {
        private const string Delimiter = ":";
        private const string ChannelNameSuffix = "SingeInstanceIPCChannel";
        private const string RemoteServiceName = "SingleInstanceApplicationService";
        private const string IpcProtocol = "ipc://";
        private static Mutex _singleInstanceMutex;

        // ReSharper disable once StaticFieldInGenericType
 
        private static IpcServerChannel _channel; 

        public static IList<string> CommandLineArgs { get; private set; }

        public static bool InitializeAsFirstInstance(string uniqueName)
        {
            CommandLineArgs = GetCommandLineArgs(uniqueName);
            string text = uniqueName + Environment.UserName;
            string channelName = $"{text}:{ChannelNameSuffix}";
            _singleInstanceMutex = new Mutex(true, text, out bool flag);
            if (flag)
            {
                CreateRemoteService(channelName);
            }
            else
            {
                SignalFirstInstance(channelName, CommandLineArgs);
            }
            return flag;
        }

        public static void Cleanup()
        {
            if (_singleInstanceMutex != null)
            {
                _singleInstanceMutex.Close();
                _singleInstanceMutex = null;
            }
            if (_channel != null)
            {
                ChannelServices.UnregisterChannel(_channel);
                _channel = null;
            }

        }

        private static IList<string> GetCommandLineArgs(string uniqueApplicationName)
        {
            string[] array = null;
            if (AppDomain.CurrentDomain.ActivationContext == null)
            {
                array = Environment.GetCommandLineArgs();
            }
            else
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    uniqueApplicationName);
                string path2 = Path.Combine(path, "cmdline.txt");
                if (File.Exists(path2))
                {
                    try
                    {
                        using (TextReader textReader = new StreamReader(path2, Encoding.Unicode))
                        {
                            array = NativeMethods.CommandLineToArgvW(textReader.ReadToEnd());
                        }
                        File.Delete(path2);
                    }
                    catch (IOException)
                    {
                    }
                }
            }
            if (array == null)
            {
                array = new string[0];
            }
            return new List<string>(array);
        }

        [Localizable(false)]
        private static void CreateRemoteService(string channelName)
        {
            BinaryServerFormatterSinkProvider sinkProvider = new BinaryServerFormatterSinkProvider
            {
                TypeFilterLevel = TypeFilterLevel.Full
            };
            IDictionary dictionary = new Dictionary<string, string>
            {
                ["name"] = channelName,
                ["portName"] = channelName,
                ["exclusiveAddressUse"] = "false"
            };
            _channel = new IpcServerChannel(dictionary, sinkProvider);
            ChannelServices.RegisterChannel(_channel, true);
            IpcRemoteService obj = new IpcRemoteService();
            _ = RemotingServices.Marshal(obj, RemoteServiceName);
        }

        [Localizable(false)]
        private static void SignalFirstInstance(string channelName, IList<string> args)
        {
            IpcClientChannel chnl = new IpcClientChannel();
            ChannelServices.RegisterChannel(chnl, true);
            string url = "ipc://" + channelName + "/SingleInstanceApplicationService";
            IpcRemoteService ipcRemoteService = (IpcRemoteService)RemotingServices.Connect(typeof(IpcRemoteService), url);
            if (ipcRemoteService != null)
            {
                try
                {
                    ipcRemoteService.InvokeFirstInstance(args);
                }
                catch (RemotingException)
                {
                }
            }
        }

        private static object ActivateFirstInstanceCallback(object arg)
        {
            IList<string> args = arg as IList<string>;
            ActivateFirstInstance(args);
            return null;
        }

        private static void ActivateFirstInstance(IList<string> args)
        {
            if (Application.Current != null)
            {
                TApplication tApplication = (TApplication)Application.Current;
                _ = tApplication.SignalExternalCommandLineArgs(args);
            }
        }

        private class IpcRemoteService : MarshalByRefObject
        {
            public void InvokeFirstInstance(IList<string> args)
            {
                _ = (Application.Current?.Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                        new DispatcherOperationCallback(ActivateFirstInstanceCallback), args));
            }

            public override object InitializeLifetimeService()
            {
                return null;
            }
        }
    }
}
#endif