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

        public static void UseThemeLight()
        {
            light = true;
        }

        public static void UseThemeDark()
        {
            light = false;
        }
    }
}