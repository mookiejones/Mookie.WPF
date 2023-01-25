using System;
using System.Collections.Generic;
using System.Text;

namespace Mookie.WPF
{
    public interface ISingleInstanceApp
    {
        bool SignalExternalCommandLineArgs(IEnumerable<string> args);
    }
}
