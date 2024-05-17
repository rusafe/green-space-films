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

        public static void LanguageSpanish()
        {
            string culture = "ES-ES";
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
        }

        public static void LanguageBritish()
        {
            string culture = "EN-GB";
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
        }
    }
}