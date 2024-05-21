using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGreenSpace.Classes
{
    internal static class ExtensionMethods
    {
        /// <summary>
        /// Extension method to add the functionalty of retrieving images from the database in a safe way
        /// to the already existing class MySqlDataReader
        /// </summary>
        /// <param name="reader">The reader object with the retrieved data</param>
        /// <param name="index">The index of the column where the image is stored</param>
        /// <returns>If the cell is null returns null, returns an image otherwise</returns>
        public static Image GetSafeImage(this MySqlDataReader reader, int index)
        {
            if (reader.IsDBNull(index))
            {
                return null;
            }
            else
            {
                return ImagesDB.BytesToImage((byte[])reader.GetValue(index));
            }
        }
    }
}
