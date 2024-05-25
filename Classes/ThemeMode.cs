using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGreenSpace
{
    class ThemeMode
    {
        private static bool light = true;
        
        public static bool Light { get { return light; } set { light = value; } }

        /// <summary>
        /// Establece el tema de la aplicacion al modo claro
        /// </summary>
        public static void UseThemeLight()
        {
            light = true;
        }

        /// <summary>
        /// Establece el tema de la aplicacion al modo oscuro
        /// </summary>
        public static void UseThemeDark()
        {
            light = false;
        }
    }
}