using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using ShadowPanel;

namespace LP2MegaAutos
{
    public partial class Login_Screen : MetroFramework.Forms.MetroForm
    {
        public Login_Screen()
        {
            InitializeComponent();
            textBox_correo.Select();
        }

        #region title_bar

        #region botones
        private void boton_cerrar_MouseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void boton_minimizar_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Minimized;
        }
        #endregion botones

        #region movement

        private int mouseX = 0, mouseY = 0, mouseInX, mouseInY;
        private bool mouseDown;



        private void title_bar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseInX = MousePosition.X - Bounds.X;
            mouseInY = MousePosition.Y - Bounds.Y;
            mouseDown = true;
        }

        private void title_bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseInX;
                mouseY = MousePosition.Y - mouseInY;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        #endregion movement

        #endregion title_bar

        //#region sombra texto
        //private PointF SOMBRA_POINTF = new PointF(0, 2);

        //private void titulo_login_Paint(object sender, PaintEventArgs e)
        //{
        //    TextShadow(e.Graphics, titulo_login.Text.ToString(), titulo_login.Font,
        //      SOMBRA_POINTF, titulo_login.ForeColor);
        //}


        ////Agregar sombras al texto, con valores por default
        //protected void TextShadow(Graphics graphics, string text, Font font,
        //PointF mover, Color? shadow = null,
        //int shadowAlpha = 16, int blurX = 2, int blurY = 6) // color opcional, 
        //                                                    //cambiar pointF por 0,3 y default pointF
        //{

        //    const int DIST = 2;
        //    for (int offset = 1; 0 <= offset; offset--)
        //    {

        //        var point = new PointF()
        //        {
        //            X = mover.X + (offset * DIST),
        //            Y = mover.Y + (offset * DIST)
        //        }; // Punto donde comenzar


        ////Blur
        //        if (offset > 0)
        //        {

        //            using (var blurBrush = new SolidBrush(Color.FromArgb((shadowAlpha / 2), shadow ?? Color.Black)))
        //            {
        //                for (int i = 1; i <= blurX; i++)
        //                {
        //                    graphics.DrawString(text, font, blurBrush, (point.X + i), point.Y);
        //                    graphics.DrawString(text, font, blurBrush, (point.X - i), point.Y);
        //                }
        //                for (int j = 1; j <= blurY; j++)
        //                    graphics.DrawString(text, font, blurBrush, (point.X), point.Y + j);

        //            }
        //        }
        //    }

        //}

        //#endregion sombra


        #region inputs

        #region bordes
        // Pone borde gris tipo sombra al rectangulo que muestra seleccion de input Correo o Contraseña
        private void panel_input_Paint(object sender, PaintEventArgs e)
        {
            Color col = Color.FromArgb(119, 119, 119);
            ButtonBorderStyle bbs = ButtonBorderStyle.Solid;
            int grosor = 1;
            ControlPaint.DrawBorder(e.Graphics, this.panel_seleccionado_correo.ClientRectangle,
                col, grosor, bbs, col, grosor, bbs, col, grosor, bbs, col, grosor, bbs);
        }

        #endregion bordes

        #region seleccion_textbox
        // Muestra un rectangulo en la seleccion de Correo o Contraseña
        private void textBox_correo_Click(object sender, EventArgs e)
        {
            panel_seleccionado_correo.Visible = true;
            panel_seleccionado_password.Visible = false;
        }

        private void textBox_password_Click(object sender, EventArgs e)
        {
            panel_seleccionado_correo.Visible = false;
            panel_seleccionado_password.Visible = true;
        }

        #endregion seleccion_textbox

        #region botones

        #region see_password
        // Variables a usar
        private bool mouseDownB, password_seen = false;


        // Ver password
        private void boton_ver_password_Click(object sender, EventArgs e)
        {
            panel_seleccionado_correo.Visible = false;
            panel_seleccionado_password.Visible = true;
            // Cambiar variable 
            password_seen = !password_seen;
            if (password_seen)
            {
                textBox_password.PasswordChar = '\0';
                boton_ver_password.BackgroundImage = global::LP2MegaAutos.Properties.Resources.boton_unsee_password;
            }
            else
            {
                textBox_password.PasswordChar = '•';
                boton_ver_password.BackgroundImage = global::LP2MegaAutos.Properties.Resources.boton_see_password;
            }
        }
        #endregion see_password

        #region olvido_password

        // Maneja el click de Olvido password 
        // TODO GENERALIZARLO EN UN PAQUETE PARA TODOS LOS BOTONES
        // RECIBIENDO PARAMETROS DE COLORES
        // Y DE LA FUNCION QUE SE QUIERA CREAR CUANDO SE DA CLICK
        private void boton_olvido_password_MouseEnter(object sender, EventArgs e)
        {

            boton_olvido_password.ForeColor = Color.FromArgb(191, 90, 108);
        }

        private void boton_olvido_password_MouseLeave(object sender, EventArgs e)
        {
            if (!mouseDownB)
            {
                boton_olvido_password.ForeColor = Color.FromArgb(227, 65, 94);
            }
        }

        private void boton_olvido_password_MouseDown(object sender, MouseEventArgs e)
        {
            boton_olvido_password.ForeColor = Color.FromArgb(181, 51, 74);
            mouseDownB = true;
        }

        private void boton_olvido_password_MouseUp(object sender, MouseEventArgs e)
        {
            boton_olvido_password.ForeColor = Color.FromArgb(227, 65, 94);
            // TODO Ir a pagina de recuperacion de password
            label_correo.Text = "Click";
            mouseDownB = false;
        }

        #endregion olvido_password


        private void boton_acceder_Click(object sender, EventArgs e)
        {

        }

        #endregion botones
        #endregion inputs

        #region dark_mode

        // Variables a usar
        private bool dark_mode = false; // false = Modo Nocturno desactivado por default
        private int contador = 0;
        const int MAX_TICKS = 7;

        private void boton_toggle_nocturno_Click(object sender, EventArgs e)
        {
            dark_mode = !dark_mode;

            if (dark_mode)
            {
                // Activar Modo Nocturno
                // El boton del toggle se mueve activando el reloj
                boton_toggle_nocturno.Enabled = false;
                reloj_dark.Enabled = true;
                reloj_dark.Start();
                // Cambiar graficos a nocturnos

                // Cambiar grafico del boton a activado
                boton_toggle_nocturno.BackgroundImage =
                    global::LP2MegaAutos.Properties.Resources.toggle_modo_nocturno_activado;

                boton_toggle_nocturno.BackColor = Color.FromArgb(67, 71, 76);
                boton_toggle_nocturno.FlatAppearance.BorderColor = Color.FromArgb(67, 71, 76);
                boton_toggle_nocturno.FlatAppearance.MouseDownBackColor = Color.FromArgb(67, 71, 76);
                boton_toggle_nocturno.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 71, 76);
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

                boton_toggle_nocturno.BackColor = Color.FromArgb(245, 245, 246);
                boton_toggle_nocturno.FlatAppearance.BorderColor = Color.FromArgb(245, 245, 246);
                boton_toggle_nocturno.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 245, 246);
                boton_toggle_nocturno.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 246);
            }
        }

        private void reloj_dark_Tick(object sender, EventArgs e)
        {
            contador++;
            if (contador == MAX_TICKS)
            {   // Reiniciar contador
                contador = 0;
                reloj_dark.Stop();
                reloj_dark.Enabled = false;
                boton_toggle_nocturno.Enabled = true;
                // Activar modo Nocturno en todo
                activar_dark_mode();

            }
            if (dark_mode)
            {   // Activar

                // Se mueve hacia la izquierda de 48,9 a 13,9
                boton_toggle_nocturno.Location =
                    new Point(boton_toggle_nocturno.Location.X - 5, boton_toggle_nocturno.Location.Y);
            }
            else
            {   // Desactivar

                // Se mueve hacia la derecha de 12,9 a 43,9
                boton_toggle_nocturno.Location =
                    new Point(boton_toggle_nocturno.Location.X + 5, boton_toggle_nocturno.Location.Y);
                desactivar_dark_mode();
            }
        }

        private void activar_dark_mode()
        {
            // Casos particulares
            panel_background.BackgroundImage = global::LP2MegaAutos.Properties.Resources.background_nocturno;
            boton_ver_password.FlatAppearance.BorderColor = boton_ver_password.FlatAppearance.MouseDownBackColor
                = boton_ver_password.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 71, 76);
            panel_correo.PanelColor = Color.FromArgb(67, 71, 76);
            panel_password.PanelColor = Color.FromArgb(67, 71, 76);
            // Demas
            iterar_activar_dark(this);
        }

        private void iterar_activar_dark(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (parent.Controls != null)
                {
                    iterar_activar_dark(c);
                }
                if (c.BackColor.Equals(Color.FromArgb(245, 245, 246)))
                    c.BackColor = Color.FromArgb(37, 40, 42);


                if (c.Tag == null) continue;
                switch (c.Tag.ToString())
                {
                    case "titulo":
                        c.ForeColor = Color.FromArgb(245, 245, 246);

                        break;
                    case "subtitulo":
                        c.ForeColor = Color.FromArgb(217, 217, 217);
                        break;
                    case "form":
                        c.ForeColor = Color.FromArgb(172, 173, 173);
                        if (c.GetType() != typeof(ShadowPanelRight))
                            c.BackColor = Color.FromArgb(67, 71, 76);
                        if (c.GetType() == typeof(TextBox))
                            c.Font = new System.Drawing.Font("Montserrat", 10.5F);
                        else
                            c.Font = new System.Drawing.Font("Montserrat Semibold", 11F);

                        break;
                    default:
                        break;
                }
            }
        }

        private void desactivar_dark_mode()
        {
            // Casos particulares
            panel_background.BackgroundImage = global::LP2MegaAutos.Properties.Resources.background_login;
            boton_ver_password.FlatAppearance.BorderColor = boton_ver_password.FlatAppearance.MouseDownBackColor
                = boton_ver_password.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 255);
            panel_correo.PanelColor = Color.FromArgb(255, 255, 255);
            panel_password.PanelColor = Color.FromArgb(255, 255, 255);
            // Demas
            iterar_desactivar_dark(this);
        }

        private void iterar_desactivar_dark(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (parent.Controls != null)
                {
                    iterar_desactivar_dark(c);
                }

                if (c.Tag != null && c.Tag.ToString() == "titlebar") continue;

                if (c.BackColor.Equals(Color.FromArgb(37, 40, 42)))
                    c.BackColor = Color.FromArgb(245, 245, 246);


                if (c.Tag == null) continue;
                switch (c.Tag.ToString())
                {
                    case "titulo":
                        c.ForeColor = Color.FromArgb(37, 40, 42);

                        break;
                    case "subtitulo":
                        c.ForeColor = Color.FromArgb(67, 71, 76);
                        break;
                    case "form":
                        c.ForeColor = Color.FromArgb(67, 71, 76);
                        if (c.GetType() != typeof(ShadowPanelRight))
                            c.BackColor = Color.FromArgb(255, 255, 255);
                        if (c.GetType() == typeof(TextBox))
                            c.Font = new System.Drawing.Font("Montserrat", 10.5F);
                        else
                            c.Font = new System.Drawing.Font("Montserrat Semibold", 11F);

                        break;
                    default:
                        break;
                }
            }
        }

        #endregion dark_mode
    }
}
