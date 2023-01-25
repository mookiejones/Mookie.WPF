using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Text;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace Mookie.WPF.Utilities
{
    public static class ImageHelper
    {
#if NET462_OR_GREATER
        private static BitmapImage LoadBitmap(Bitmap img)
        {
            BitmapImage bitmapImage = new BitmapImage();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                img.Save(memoryStream, ImageFormat.Jpeg);
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = new MemoryStream(memoryStream.ToArray());
                bitmapImage.EndInit();
            }
            return bitmapImage;
        }
#endif

        public static ImageSource GetIcon(string fileName)
        {
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(fileName);
            bitmapImage.EndInit();
            return bitmapImage;



        }

        public static BitmapImage LoadBitmap(string fileName)
        {
            BitmapImage result;

#if DEBUG
            FileInfo file = new System.IO.FileInfo(fileName);
            if (!file.Exists)
            {
                Console.WriteLine(file);
            }
#endif
            try
            {
                if (File.Exists(fileName))
                {
                    FileInfo fileInfo = new System.IO.FileInfo(fileName);
                    BitmapImage bitmapImage = new BitmapImage(new Uri(fileInfo.FullName));
                    bitmapImage.Freeze();
                    result = bitmapImage;
                    return result;
                }
            }
            catch (ArgumentException)
            {
            }
            catch (IOException)
            {
            }
            result = null;
            return result;
        }

    }
    }
