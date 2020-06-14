using ShadowPanel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Dark Mode 
// Cambia de color a todo lo que tiene tag
// Invocar a cambiarDarkMode desde un click al boton toggle
// Y tambien invocar reloj_dark_Tick desde el tick de un Timer

namespace LP2MegaAutos
{
    class DarkMode
    {
        /* ====================================
         *              Variables
         * ====================================*/
        private static bool dark_mode = false; // false = Modo Nocturno desactivado por default
        private static List<string> excepciones = new List<string>();
        // Para el reloj
        private static int contador = 0;
        const int MAX_TICKS = 7;

        /* ====================================
         *              Funciones
         * ====================================*/

        #region De Apoyo
        public static void agregarExcepcion(string e)
        {
            excepciones.Add(e);
        }

        public static bool esExcepcion(string e)
        {
            return excepciones.Contains(e);
        }

        public static void quitarExcepcion(string e)
        {
            excepciones.Remove(e);
        }

        public static bool is_dark_mode_active()
        {
            return dark_mode == true;
        }

        public static bool is_white_mode_active()
        {
            return dark_mode == false;
        }
        #endregion De Apoyo

        #region Cambiar DM
        public static void cambiarDarkMode(Panel panel_toggle_nocturno, Button boton_toggle_nocturno, Timer reloj_dark, Control parent, Label label_Modo_Oscuro)
        {
            // Implementar en cambiarDM y en IniciarDM
            if (dark_mode)
            {
                // Desactivar Modo Nocturno
                label_Modo_Oscuro.Text = "Modo Oscuro\nDesactivado";
            }
            else
            {
                // Activar Modo Oscuro
                label_Modo_Oscuro.Text = "Modo Oscuro\nActivado";
            }
            cambiarDarkMode(panel_toggle_nocturno, boton_toggle_nocturno, reloj_dark, parent);
        }

        public static void cambiarDarkMode(Panel panel_toggle_nocturno, Button boton_toggle_nocturno, Timer reloj_dark, Control parent)
        {
            // Cambiar graficos a nocturnos
            cambiar_color_mode(parent);

            // El boton del toggle se mueve activando el reloj
            // Y se bloquea para que no se active antes de que llegue al otro lado
            boton_toggle_nocturno.Enabled = false;
            reloj_dark.Enabled = true;
            reloj_dark.Start();

            if (dark_mode)
            {
                // Desactivar Modo Oscuro
                // Cambiar grafico del boton a desactivado
                boton_toggle_nocturno.BackgroundImage =
                    global::LP2MegaAutos.Properties.Resources.toggle_modo_nocturno_desactivado;
                panel_toggle_nocturno.BackgroundImage = global::LP2MegaAutos.Properties.Resources.toggle_white;
            }
            else
            {
                // Activar Modo Oscuro
                // Cambiar grafico del boton a activado
                boton_toggle_nocturno.BackgroundImage =
                    global::LP2MegaAutos.Properties.Resources.toggle_modo_nocturno_activado;
                // Cambiar el panel
                panel_toggle_nocturno.BackgroundImage = global::LP2MegaAutos.Properties.Resources.toggle_black;
            }
            // Si esta en dark mode, pasar a white mode y viceversa
            Colores.invertirColores();
            dark_mode = !dark_mode;
        }
        #endregion Cambiar DM

        #region Iniciar DM 
        // Se debe de llamar cuando ya esta activado el dark mode
        // Para inicializar los otros paneles
        public static void iniciarDarkMode(Panel panel_toggle_nocturno, Button boton_toggle_nocturno, Timer reloj_dark, Control parent, Label label_Modo_Oscuro)
        {
            iniciarDarkMode(panel_toggle_nocturno, boton_toggle_nocturno, reloj_dark, parent);
            label_Modo_Oscuro.Text = "Modo Oscuro\nActivado";
        }

        // Inicializa el dark mode en un form
        // Se debe de llamar cuando ya esta activado el dark mode
        // Para inicializar los otros paneles
        public static void iniciarDarkMode(Panel panel_toggle_nocturno, Button boton_toggle_nocturno, Timer reloj_dark, Control parent)
        {
            // Cambiar graficos a nocturnos
            cambiar_color_mode(parent);

            // El boton del toggle se mueve activando el reloj
            // Y se bloquea para que no se active antes de que llegue al otro lado
            boton_toggle_nocturno.Enabled = false;
            reloj_dark.Enabled = true;
            reloj_dark.Start();

            // Activar Modo Oscuro
            // Cambiar grafico del boton a activado
            boton_toggle_nocturno.BackgroundImage =
                global::LP2MegaAutos.Properties.Resources.toggle_modo_nocturno_activado;
            // Cambiar el panel
            panel_toggle_nocturno.BackgroundImage = global::LP2MegaAutos.Properties.Resources.toggle_black;
        }

        #endregion Iniciar DM

        #region Iniciar Sin Timer

        // Inicializa el dark mode en un form
        // Se debe de llamar cuando ya esta activado el dark mode
        // Para inicializar los otros paneles
        public static void iniciarSinTimer(Control parent)
        {
            // Cambiar graficos a nocturnos
            dark_mode = false;
            cambiar_color_mode(parent);
            dark_mode = true;
        }

        #endregion Iniciar Sin Timer

        // Inicializa el dark mode en un form
        // Se tiene que llamar desde el tick de un timer 
        // de la funcino de la funcion de la que lo quieres llamar reloj_dark_Tick()
        public static void reloj_dark_Tick(Timer reloj_dark, Button boton_toggle_nocturno)
        {
            contador++;
            if (contador == MAX_TICKS)
            {   // Reiniciar contador
                contador = 0;
                reloj_dark.Stop();
                reloj_dark.Enabled = false;
                boton_toggle_nocturno.Enabled = true;
            }
            if (dark_mode)
            {
                // Se mueve hacia la izquierda
                boton_toggle_nocturno.Location =
                    new Point(boton_toggle_nocturno.Location.X - 5, boton_toggle_nocturno.Location.Y);
            }
            else
            {
                // Se mueve hacia la derecha
                
                boton_toggle_nocturno.Location =
                    new Point(boton_toggle_nocturno.Location.X + 5, boton_toggle_nocturno.Location.Y);
            }
        }

        private static void cambiar_color_mode(Control parent)
        {
            // Usar recursion para recorrer todos los controles
            foreach (Control c in parent.Controls)
            {
                if (c.Controls.Count != 0) cambiar_color_mode(c);
                // Llamar a funcion cambiarModoControl
                cambiar_modo_control(c);
            }
        }

        private static void cambiar_modo_control(Control c)
        {
            // Ignorar segun tag
            string nom = c.Name.ToString();
           
            if (excepciones.Contains(nom)) return;


            // Si es un roundedPanel
            if (c.GetType() == typeof(RoundedPanel))
            {
                Colores.cambiarRoundedPanelColor((RoundedPanel)c);
                if (nom.Contains("Menu")) // No cambia BackColor
                    return;
            }
            
            switch (nom)
            {
                case "boton_toggle_nocturno":
                    // El toggle necesita otros colores
                    Colores.cambiarToggle((Button)c);
                    break;
                default:
                    Colores.cambiarColor(c);
                    break;
            };
        }

    }
}
