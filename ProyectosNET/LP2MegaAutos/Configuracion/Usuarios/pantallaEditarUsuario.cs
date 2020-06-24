using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace LP2MegaAutos
{
    public partial class pantallaEditarUsuario : MetroForm
    {
        public pantallaEditarUsuario()
        {
            InitializeComponent();

        }

        public pantallaEditarUsuario(ServicioUsuario.usuario usuario)
        {
            InitializeComponent();
            this.txt_NombreUsuario.Text = usuario.nombre;
            this.txt_Correo.Text = usuario.correo;
            this.lblRol.Text = usuario.tipoUsuario;
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pantallaEditarUsuario_Load(object sender, EventArgs e)
        {

        }

        private bool password_seen = false;
        private void boton_ver_password_Click(object sender, EventArgs e)
        {
            // Cambiar variable 
            password_seen = !password_seen;
            if (password_seen)
            {
                txt_NuevaCont.PasswordChar = '\0';
                boton_ver_password.BackgroundImage = global::LP2MegaAutos.Properties.Resources.boton_unsee_password;
            }
            else
            {
                txt_NuevaCont.PasswordChar = '•';
                boton_ver_password.BackgroundImage = global::LP2MegaAutos.Properties.Resources.boton_see_password;
            }
        }
    }
}
