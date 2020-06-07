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
    public partial class pantallaAgregarUsuario : UserControl
    {
        // Singleton instance para poder crearlo en la pantalla menu
        #region instancia
        private static pantallaAgregarUsuario _instancia;
        public static pantallaAgregarUsuario Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaAgregarUsuario();
                return _instancia;
            }
        }
        #endregion instancia
        public pantallaAgregarUsuario()
        {
            InitializeComponent();
        }

        private void btn_AgregarPermiso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agregar");
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
