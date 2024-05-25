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
        /// <summary>
        /// Transforma una imagen a su array de bytes
        /// </summary>
        /// <param name="image">La imagen a transformar</param>
        /// <returns>Array de bytes con los datos de la imagen</returns>
        public static Byte[] ImageToBytes(Image image)
        {
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Jpeg);

            return memoryStream.ToArray();
        }

        /// <summary>
        /// Transforma un array de bytes en su imagen
        /// </summary>
        /// <param name="bytes">El array de bytes a transformar</param>
        /// <returns>Imagen construida del array de bytes</returns>
        public static Image BytesToImage(byte[] bytes)
        {
            MemoryStream memoryStream = new MemoryStream(bytes);

            return Image.FromStream(memoryStream);
        }

        /// <summary>
        /// Transforma un bitmap a su array de bytes
        /// </summary>
        /// <param name="bitmap">El bitmap a transformar</param>
        /// <returns>Array de bytes con los datos del bitmap</returns>
        public static Byte[] BitmapToBytes(Bitmap bitmap)
        {
            MemoryStream memoryStream = new MemoryStream();
            bitmap.Save(memoryStream, ImageFormat.Png);

            return memoryStream.ToArray();
        }

        /// <summary>
        /// Transforma un array de bytes en su bitmap
        /// </summary>
        /// <param name="bytes">El array de bytes a transformar</param>
        /// <returns>Bitmap construido del array de bytes</returns>
        public static Bitmap BytesToBitmap(byte[] bytes)
        {
            MemoryStream memoryStream = new MemoryStream(bytes);

            return new Bitmap(memoryStream);
        }
    }
}
