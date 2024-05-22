using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGreenSpace.Classes
{
    internal static class ImagesDB
    {
        public static Byte[] ImageToBytes(Image image)
        {
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Jpeg);

            return memoryStream.ToArray();
        }

        public static Image BytesToImage(byte[] bytes)
        {
            MemoryStream memoryStream = new MemoryStream(bytes);

            return Image.FromStream(memoryStream);
        }

        public static Byte[] BitmapToBytes(Bitmap bitmap)
        {
            MemoryStream memoryStream = new MemoryStream();
            bitmap.Save(memoryStream, ImageFormat.Png);

            return memoryStream.ToArray();
        }

        public static Bitmap BytesToBitmap(byte[] bytes)
        {
            MemoryStream memoryStream = new MemoryStream(bytes);

            return new Bitmap(memoryStream);
        }
    }
}
