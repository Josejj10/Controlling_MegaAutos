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


namespace LP2MegaAutos
{
    static class Tipografias
    {
        /* ====================================
         *              Variables
         * ====================================*/
        // Almacenara todos los fonts
        private static PrivateFontCollection fonts = new PrivateFontCollection();

        // Almacenara todos los handlers
        private static IntPtr[] handlers;
        private static Hashtable fontsHash = new Hashtable();

        /* ====================================
         *        Funciones de gdi32.dll
         *   Enlaces a Documentacion al inicio
         * ====================================*/

        // Agregar un font incrustado
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [In] ref uint pcFonts);

        // Para cleanup de los fonts agregados por este metodo
        [DllImport("gdi32.dll")]
        internal static extern bool RemoveFontMemResourceEx(IntPtr fh);

        #region funciones
        /* ====================================
         *              Funciones
         * ====================================*/

        // Agregar todos los Fonts a una tabla hash que los guardara
        // Segun nombre
        public static void inicializarFonts()
        {
            /////  TODO Idea: ITERAR POR TODOS LOS RESOURCES QUE ACABAN EN TTF Y OTF PARA AGREGARLOS AL PRIVATE FONT COLLECTION
            ///     Y USAR UNA TABLA HASH (?) PARA LA FUNCION GETFONT
            Font font;
            byte[] fontData;
            string nombre;
            uint dummy = 0;
            int numeroFont; // Para agregarlo a la tabla hash
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
                    
                    // Apuntar fontPtr al inicio
                    fontPtr = Marshal.AllocCoTaskMem(fontData.Length);

                    // Unmanaged font 
                    // Porque GDI+ creara un objeto font para controles como RichTextBox
                    // Y este unmanaged font asegurara que GDI reconozca el nombre del font
                    IntPtr handle = AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
                    // El handle se guarda en una lista de handles para luego poder 
                    // Llamar a la funcion RemoveFontMemResourceEx(handle)
                    // TODO almacenar Handle en lista de handles

                    // Copiar los datos a fontData
                    Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                    
                    // Agregar font a lista de fonts
                    fonts.AddMemoryFont(fontPtr, fontData.Length);

                    // Libera el IntPtr, en ambos casos
                    Marshal.FreeCoTaskMem(fontPtr);

                    // Recibir el numeroFont para agregar a la tabla hash
                    numeroFont = fonts.Families.Length;

                    fontsHash.Add(nombre.Remove(0,4), numeroFont);
                    Console.WriteLine("Agregado font: " + nombre.Remove(0, 4));
                }
            }
            // Buscar archivos que acaben en .otf o .ttf 
        }

        public static Font GetFromHash(String nombre, float size)
        {
            if (!fontsHash.ContainsKey(nombre))
            {
                Console.WriteLine("No se hallo el font: " + nombre +" en la tabla hash.");
                return null;
            }
            int key = (int)fontsHash[nombre];
            Font mb = new Font(fonts.Families[key], size, FontStyle.Bold);
            return mb;
        }

        public static Font GetSpecialFont(float size)
        {
            // Inicializar el font y recibir la data de Resources
            Font mb;
            byte[] fontData = Properties.Resources.fontMontserrat_Bold;

            
            // A pointer to a variable that specifies the number of fonts installed.
            uint dummy = 0;
            
            //A pointer to a font resource.
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);

            // Unmanaged font 
            // Porque GDI+ creara un objeto font para controles como RichTextBox
            // Y este unmanaged font asegurara que GDI reconozca el nombre del font
            IntPtr handle = AddFontMemResourceEx(fontPtr, (uint) fontData.Length, IntPtr.Zero, ref dummy);
            // TODO almacenar handle en lista de handles
            // El handle se guarda en una lista de handles para luego poder 
            // Llamar a la funcion RemoveFontMemResourceEx(handle)

            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            
            fonts.AddMemoryFont(fontPtr, fontData.Length);
            
            /////// AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Montserrat_Bold.Length,
            ////////IntPtr.Zero, ref dummy);
            // En el otro no llama a esta funcion

            Marshal.FreeCoTaskMem(fontPtr);
            // Libera el IntPtr, en ambos casos

            
            mb = new Font(fonts.Families[0], size, FontStyle.Bold);
            // En el otro hace lo mismo, pero revisa si font.Families.Length > 0

            return mb;
        }
        #endregion funciones
    }
}
