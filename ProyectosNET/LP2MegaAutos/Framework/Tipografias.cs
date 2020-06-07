using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections;
using System.Resources;
using System.Globalization;

// http://archives.miloush.net/michkap/archive/2005/11/20/494829.html
// https://docs.microsoft.com/en-us/windows/win32/api/wingdi/nf-wingdi-addfontmemresourceex
// https://docs.microsoft.com/en-us/windows/win32/api/wingdi/nf-wingdi-removefontmemresourceex
// Agradecido con el de arriba

// Los fonts que en Properties.Resources hasta ahora son:
/* Lato
 * Lato Black
 * Lato Light
 * Lato Medium
 * Lato Semibold
 * Lato Thin
 * Montserrat
 * Montserrat Black
 * Montserrat ExtraBold
 * Montserrat Medium
 * Montserrat SemiBold
 *========== Si se agregan mas, agregarlos a FontsDisponibles.cs como variables estaticas
*/

public enum fontsD
{
    // Los fonts que en Properties.Resources hasta ahora son:
     Ninguno, // Default
     Lato,
     Lato_Black,
     Lato_Light,
     Lato_Medium,
     Lato_Semibold,
     Lato_Thin,
     Montserrat,
     Montserrat_Black,
     Montserrat_ExtraBold,
     Montserrat_Medium,
     Montserrat_SemiBold
     // Si se agregan mas, agregarlos aca, y a la funcion switchFontsD
}

// Es decir, solo esos se pueden usar
// Para llamar a un font, por ejemplo para el objeto titulo_login se realiza:
// this.titulo_login.Font = Tipografias.GetFromHash("Montserrat", 10 ,FontStyle.Bold);

// Para agregar un font se tiene que embeddear el archivo .otf, .ttf, etc y 
// ponerle al comienzo del nombre del recurso "font"
// de manera: fontMontserrat, o fontLato
// Los recursos se pueden encontrar en Resources.resx en la solucion de Visual Studio

namespace LP2MegaAutos
{
    static class Tipografias
    {
        /* ====================================
         *              Variables
         * ====================================*/
        // Almacenara todos los fonts
        private static PrivateFontCollection fonts = new PrivateFontCollection();
        
        // Mapeara los fonts para poder llamarlos por nombre
        private static Hashtable fontsHash = new Hashtable();

        /* ====================================
         *        Funciones de gdi32.dll
         *   Enlaces a Documentacion al inicio
         * ====================================*/

        // Agregar un font incrustado
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);


        #region funciones
        /* ====================================
         *              Funciones
         * ====================================*/

        // Agregar todos los Fonts a una tabla hash que los guardara
        // Segun nombre
        public static void inicializarFonts()
        {
            byte[] fontData;
            string nombre;
            uint dummy = 0;
            IntPtr fontPtr = IntPtr.Zero;
            ResourceSet resourceSet = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

            // Iterar por todo Properties.Resources
            foreach (DictionaryEntry entry in resourceSet)
            {
                //object resource = entry.Value;
                nombre = entry.Key.ToString();

                if (nombre.StartsWith("font")) {
                    // Inicializar el font
                    fontData = (byte[])entry.Value;
                    //fontData = LP2MegaAutos.Properties.Resources.fontLato_Bold;
                    // Apuntar fontPtr al inicio
                    fontPtr = Marshal.AllocCoTaskMem(fontData.Length);

                    // Copiar los datos a fontData
                    Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                    
                    // Agregar font a lista de fonts
                    fonts.AddMemoryFont(fontPtr, fontData.Length);
                    
                    // Unmanaged font 
                    // Porque GDI+ creara un objeto font para controles como RichTextBox
                    // Y este unmanaged font asegurara que GDI reconozca el nombre del font
                    AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);

                    // Libera el IntPtr, en ambos casos
                    Marshal.FreeCoTaskMem(fontPtr);
                }
            }

            // Agregar a tabla hash
            for (int i = 0; i < fonts.Families.Length;i++)
            {
                nombre = fonts.Families[i].Name;
                fontsHash.Add(nombre, i);
                Console.WriteLine("Agregado font: " + nombre);
            }

        }

        // Devuelve el Font requerido desde la tabla Hash
        public static Font GetFromHash(String nombre, float size, FontStyle fs)
        {
            if (!fontsHash.ContainsKey(nombre))
            {
                Console.WriteLine("No se hallo el font: " + nombre +" en la tabla hash.");
                return null;
            }
            int key = (int)fontsHash[nombre];
            Font font = new Font(fonts.Families[key], size, fs);
            return font;
        }
       
        // Itera por el control (usualmente se le pasa el form entero y el TagsExtender del form) 
        // y sus hijos mediante recursion para agregar los fonts correspondientes a cada control
        public static void crearFonts(Control parent, TagsExtender tags)
        {;
            String nombre;
            float size;
            FontStyle fs;
            

            // Usar recursion para recorrer todos los controles
            foreach (Control c in parent.Controls)
            {
                Console.WriteLine("Agregando el font a " + c.Name);
                if (parent.Controls != null) 
                    crearFonts(c, tags);
                //if (tags.GetTagFontName(c) == null) continue;
                
                nombre = switchFontsD(tags.GetTagFontName(c));
                
                if (nombre == "") continue; // No usa embedded font
                
                if (!fontsHash.ContainsKey(nombre))
                {
                    Console.WriteLine(nombre +" no esta en Tabla Hash. Devolviendo font sin incrustar");
                    return;
                }
                size = tags.GetTagFontSize(c);
                fs = tags.GetTagFontStyle(c);
                c.Font = GetFromHash(nombre, size, fs);
            }
        }

        private static String switchFontsD(fontsD fName)
        {
            switch (fName)
            {
                case fontsD.Lato:
                    return "Lato";
                case fontsD.Lato_Black:
                    return "Lato Black";
                case fontsD.Lato_Light:
                    return "Lato Light";
                case fontsD.Lato_Medium:
                    return "Lato Medium";
                case fontsD.Lato_Semibold:
                    return "Lato Semibold";
                case fontsD.Lato_Thin:
                    return "Lato Thin";
                case fontsD.Montserrat:
                    return "Montserrat";
                case fontsD.Montserrat_Black:
                    return "Montserrat Black";
                case fontsD.Montserrat_ExtraBold:
                    return "Montserrat ExtraBold";
                case fontsD.Montserrat_Medium:
                    return "Montserrat Medium";
                case fontsD.Montserrat_SemiBold:
                    return "Montserrat SemiBold";
                default:
                    return "";
            }
        }

        #endregion funciones

    }
}
