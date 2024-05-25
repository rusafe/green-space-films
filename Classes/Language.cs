using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProyectoGreenSpace.Classes
{
    class Language
    {
        /// <summary>
        /// Establece el idioma de la aplicacion al español
        /// </summary>
        public static void LanguageSpanish()
        {
            string culture = "ES-ES";
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
        }

        /// <summary>
        /// Establece el idioma dela aplicacion al ingles
        /// </summary>
        public static void LanguageBritish()
        {
            string culture = "EN-GB";
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
        }
    }
}