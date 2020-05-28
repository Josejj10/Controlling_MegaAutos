using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2MegaAutos
{
    public partial class pantallaEditarInformacionPropia : UserControl
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
    }
}
