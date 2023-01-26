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
#if NET46_OR_GREATER
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static BitmapImage LoadBitmap(string fileName)
        {
             

            try
            {
                if (File.Exists(fileName))
                {
                    FileInfo fileInfo = new System.IO.FileInfo(fileName);
                    BitmapImage bitmapImage = new BitmapImage(new Uri(fileInfo.FullName));
                    bitmapImage.Freeze();
                     
                    return bitmapImage;
                }
            }
            catch (ArgumentException)
            {
            }
            catch (IOException)
            {
            }
            
            return null;
        }

    }
    }
