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
using MetroFramework;

namespace LP2MegaAutos
{
    public partial class Login_Screen : MetroFramework.Forms.MetroForm
    {
       
        public Login_Screen()
        {
            InitializeComponent();
            Tipografias.crearFonts(this,tags);// Inicializa los fonts de este form
            textBox_correo.Select();// Para que le panel lateral aparezca
            DarkMode.agregarExcepcion("boton_acceder");
        }


        #region title_bar

        #region botones
        private void boton_cerrar_MouseClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void boton_minimizar_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Minimized;
        }
        #endregion botones

        #region movement
        // Llama a la clase estatica TitleBar
        private void title_bar_MouseUp(object sender, MouseEventArgs e)
        {
            TitleBar.mouse_Up();
        }

        private void title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            TitleBar.mouse_Down(MousePosition, Bounds);
        }

        private void title_bar_MouseMove(object sender, MouseEventArgs e)
        {
            TitleBar.mouse_Move(MousePosition, this);
        }

        #endregion movement

        #endregion title_bar

        #region inputs


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
            
            MetroMessageBox.Show(this,"Puedes recuperarla enviando un mensaje a IT.", "¿Olvidaste tu Contraseña?");
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
            if(verificarUsuario())
                this.DialogResult = DialogResult.OK;
        }

        private bool verificarUsuario()
        {
            return true;
        }

        #endregion botones
        #endregion inputs

        #region Dark Mode
        // Usa la clase DarkMode para cambiar los colores iterando
        // Y mover el toggle mediante ticks del timer reloj_dark
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
