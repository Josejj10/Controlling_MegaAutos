using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShadowPanel;
using System.Drawing.Text;
using System.Reflection;
using System.IO;
using System.Runtime.InteropServices;


namespace LP2MegaAutos
{
    public partial class Login_Screen : MetroFramework.Forms.MetroForm
    {
       
        public Login_Screen()
        {
            InitializeComponent();
            Tipografias.crearFonts(this);
            textBox_correo.Select();
        }

        private void inicializarFonts()
        {
            //this.titulo_login.Font = Tipografias.GetFromHash("Montserrat", 22, FontStyle.Bold);
            //this.subtitulo_login.Font = Tipografias.GetFromHash("Montserrat", 15, FontStyle.Bold);
            //this.label_texto_amarillo.Font = Tipografias.GetFromHash("Montserrat", 10, FontStyle.Bold);
            //this.label_texto_gris.Font = Tipografias.GetFromHash("Montserrat", 10, FontStyle.Bold);
            //this.label_correo.Font = Tipografias.GetFromHash("Montserrat Semibold", 11, FontStyle.Bold);
            //this.label_password.Font = Tipografias.GetFromHash("Montserrat Semibold", 11, FontStyle.Bold);
            //this.textBox_correo.Font = Tipografias.GetFromHash("Montserrat", 11.25f, FontStyle.Regular);
            //this.textBox_password.Font = Tipografias.GetFromHash("Montserrat", 11.25f, FontStyle.Regular);
            //this.boton_acceder.Font = Tipografias.GetFromHash("Montserrat", 12, FontStyle.Bold);
            //this.label_Modo_Oscuro.Font = Tipografias.GetFromHash("Montserrat", 10, FontStyle.Bold);
            //// Los fonts de los controladores ClickableText ya estan inicializados en sus constructores
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
        private void textBox_correo_Focus(object sender, EventArgs e)
        {
            panel_seleccionado_correo.Visible = true;
            panel_seleccionado_password.Visible = false;
        }

        private void textBox_password_Focus(object sender, EventArgs e)
        {
            panel_seleccionado_correo.Visible = false;
            panel_seleccionado_password.Visible = true;
        }

        #endregion seleccion_textbox

        #region Clickable Text

        #region olvido_password
        
        void boton_olvido_password_Click(object sender, EventArgs e)
        {
            // TODO funcion de olvido Password
            MessageBox.Show("¿Olvidaste tu Contraseña?");
        }
        #endregion olvido_password

        #endregion Clickable Text

        #region botones

        #region see_password
        // Variables a usar
        private bool password_seen = false;


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

        private void boton_acceder_Click(object sender, EventArgs e)
        {
            // TODO boton acceder click
        }

        #endregion botones
        #endregion inputs

        #region Dark Mode

        private void boton_toggle_nocturno_Click(object sender, EventArgs e)
        {
            DarkMode.cambiarDarkMode(panel_toggle_nocturno, boton_toggle_nocturno, reloj_dark, this,label_Modo_Oscuro);
        }

        private void reloj_dark_Tick(object sender, EventArgs e)
        {
            DarkMode.reloj_dark_Tick(reloj_dark, boton_toggle_nocturno);
        }

        #endregion Dark Mode
    }
}
