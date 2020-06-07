using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LP2MegaAutos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Tipografias.inicializarFonts();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Agregar excpciones del Modo Oscuro
            DarkMode.agregarExcepcion("title_bar");
            DarkMode.agregarExcepcion("title_bar_2");
            DarkMode.agregarExcepcion("panelMenu");

            while (true)
            {
                Login_Screen login = new Login_Screen();
                // Application.Run(login);
                if (login.ShowDialog() == DialogResult.OK)
                {
                    frmPrincipal frm = new frmPrincipal(login.Usuario);
                    if (frm.ShowDialog() == DialogResult.OK)
                        continue;
                    else
                        break;
                }
                else
                    break;
            }
        }

    }
}

