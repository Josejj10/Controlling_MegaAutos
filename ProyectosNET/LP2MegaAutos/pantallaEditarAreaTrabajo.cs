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
    public partial class pantallaEditarAreaTrabajo : UserControl
    {
        // Singleton instance para poder crearlo en la pantalla menu
        #region instancia
        private static pantallaEditarAreaTrabajo _instancia;
        public static pantallaEditarAreaTrabajo Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaEditarAreaTrabajo();
                return _instancia;
            }
        }
        #endregion instancia
        public pantallaEditarAreaTrabajo()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
