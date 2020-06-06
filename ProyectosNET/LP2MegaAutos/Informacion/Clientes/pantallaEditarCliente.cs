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
    public partial class pantallaEditarCliente : UserControl
    {
        // Singleton instance para poder crearlo en la pantalla menu
        #region instancia
        private static pantallaEditarCliente _instancia;
        public static pantallaEditarCliente Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaEditarCliente();
                return _instancia;
            }
        }
        #endregion instancia
        public pantallaEditarCliente()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
