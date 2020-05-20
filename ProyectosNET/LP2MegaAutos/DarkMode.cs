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
        
        // Para el reloj
        private static int contador = 0;
        const int MAX_TICKS = 7;
        
        /* ====================================
         *              Funciones
         * ====================================*/

        public static bool is_dark_mode_active()
        {
            return dark_mode == true;
        }

        public static bool is_white_mode_active()
        {
            return dark_mode == false;
        }

        public static void cambiarDarkMode(Panel panel_toggle_nocturno, Button boton_toggle_nocturno, Timer reloj_dark, Control parent, Label label_Modo_Oscuro)
        {
            // Cambiar graficos a nocturnos
            cambiar_color_mode(parent);

            if (dark_mode)
            {
                // Desactivar Modo Nocturno
                label_Modo_Oscuro.Text = "Modo Oscuro\nDesactivado";
                // Y se bloquea para que no se active antes de que llegue al otro lado
                // El boton del toggle se mueve activando el reloj
                boton_toggle_nocturno.Enabled = false;
                reloj_dark.Enabled = true;
                reloj_dark.Start();

                // Cambiar grafico del boton a desactivado
                boton_toggle_nocturno.BackgroundImage =
                    global::LP2MegaAutos.Properties.Resources.toggle_modo_nocturno_desactivado;
                panel_toggle_nocturno.BackgroundImage = global::LP2MegaAutos.Properties.Resources.toggle_white;
            }
            else
            {

                // Activar Modo Oscuro
                label_Modo_Oscuro.Text = "Modo Oscuro\nActivado";
                // El boton del toggle se mueve activando el reloj
                // Y se bloquea para que no se active antes de que llegue al otro lado
                boton_toggle_nocturno.Enabled = false;
                reloj_dark.Enabled = true;
                reloj_dark.Start();

                // Cambiar grafico del boton a activado
                boton_toggle_nocturno.BackgroundImage =
                    global::LP2MegaAutos.Properties.Resources.toggle_modo_nocturno_activado;
                // Cambiar el panel
                panel_toggle_nocturno.BackgroundImage = global::LP2MegaAutos.Properties.Resources.toggle_black;
            }
            // Si esta en dark mode, pasar a white mode y viceversa
            dark_mode = !dark_mode;

        }


        public static void cambiarDarkMode(Panel panel_toggle_nocturno, Button boton_toggle_nocturno, Timer reloj_dark, Control parent)
        {
            // Si esta en dark mode, pasar a white mode y viceversa
            dark_mode = !dark_mode;
            // Cambiar graficos a nocturnos
            cambiar_color_mode(parent);

            if (dark_mode)
            {
                // Activar Modo Nocturno
                // El boton del toggle se mueve activando el reloj
                // Y se bloquea para que no se active antes de que llegue al otro lado
                boton_toggle_nocturno.Enabled = false;
                reloj_dark.Enabled = true;
                reloj_dark.Start();

                // Cambiar grafico del boton a activado
                boton_toggle_nocturno.BackgroundImage =
                    global::LP2MegaAutos.Properties.Resources.toggle_modo_nocturno_activado;

                boton_toggle_nocturno.BackColor = Dark_Mode.LowContrast;
                boton_toggle_nocturno.FlatAppearance.BorderColor = Dark_Mode.LowContrast;
                boton_toggle_nocturno.FlatAppearance.MouseDownBackColor = Dark_Mode.LowContrast;
                boton_toggle_nocturno.FlatAppearance.MouseOverBackColor = Dark_Mode.LowContrast;

                // Cambiar el panel
                panel_toggle_nocturno.BackgroundImage = global::LP2MegaAutos.Properties.Resources.toggle_black;
            }

            else
            {
                // Desactivar Modo Nocturno
                // El boton del toggle se mueve activando el reloj
                boton_toggle_nocturno.Enabled = false;
                reloj_dark.Enabled = true;
                reloj_dark.Start();

                // Cambiar grafico del boton a desactivado
                boton_toggle_nocturno.BackgroundImage =
                    global::LP2MegaAutos.Properties.Resources.toggle_modo_nocturno_desactivado;
                panel_toggle_nocturno.BackgroundImage = global::LP2MegaAutos.Properties.Resources.toggle_white;

                boton_toggle_nocturno.BackColor = White_Mode.LowContrast;
                boton_toggle_nocturno.FlatAppearance.BorderColor = White_Mode.LowContrast;
                boton_toggle_nocturno.FlatAppearance.MouseDownBackColor = White_Mode.LowContrast;
                boton_toggle_nocturno.FlatAppearance.MouseOverBackColor = White_Mode.LowContrast;
            }
        }

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
                // Se mueve hacia la izquierda de 48,9 a 13,9
                boton_toggle_nocturno.Location =
                    new Point(boton_toggle_nocturno.Location.X - 5, boton_toggle_nocturno.Location.Y);
            }
            else
            {   
                // Se mueve hacia la derecha de 12,9 a 43,9
                boton_toggle_nocturno.Location =
                    new Point(boton_toggle_nocturno.Location.X + 5, boton_toggle_nocturno.Location.Y);
            }
        }

        private static void cambiar_color_mode(Control parent)
        {
            // Usar recursion para recorrer todos los controles
            foreach (Control c in parent.Controls)
            {
                if (parent.Controls != null) cambiar_color_mode(c);
                
                // Pasa al siguiente loop si no tiene tag
                if (c.Tag == null) continue;
                // Llamar a funcion cambiarModoControl
                cambiar_modo_control(c);
            }
        }

        private static void cambiar_modo_control(Control c)
        {
            // Ignorar segun tag
            string tag = c.Tag.ToString();
            switch (tag)
            {
                case "titlebar":
                    break;
                case "toggle_oscuro":
                    Colores.cambiarToggle((Button)c);
                    break;
                default:
                    Colores.cambiarColor(c);
                    break;
            };
        }

    }
}
