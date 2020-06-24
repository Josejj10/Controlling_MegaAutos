using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2MegaAutos.Framework
{
    public static class OtrosHelper
    {
        public static string tipoOracion(string str)
        {
            string devolver = "";
            foreach (string s in str.ToLower().Split())
                devolver += tipoOracionPalabra(s)+" ";
            return devolver;
        }

        public static string tipoOracionPalabra(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            // Todo cambiar las demas palabras no solo la primera
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}
