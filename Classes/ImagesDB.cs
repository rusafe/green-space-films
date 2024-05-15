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
    }
}
