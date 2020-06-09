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
    public partial class pantallaEditarInformacionPropia : MetroForm
    {
        // Singleton instance para poder crearlo en la pantalla menu
        #region instancia
        private static pantallaEditarInformacionPropia _instancia;
        public static pantallaEditarInformacionPropia Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaEditarInformacionPropia();
                return _instancia;
            }
        }
        #endregion instancia
        public pantallaEditarInformacionPropia()
        {
            InitializeComponent();
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
        #region Ver Password
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
        #endregion Ver Password

        private void btn_GuardarCambios_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void pantallaEditarInformacionPropia_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
