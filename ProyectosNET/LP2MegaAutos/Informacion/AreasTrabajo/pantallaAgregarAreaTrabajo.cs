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
    public partial class pantallaAgregarAreaTrabajo : UserControl
    {
        #region instancia
        private static pantallaAgregarAreaTrabajo _instancia;
        public static pantallaAgregarAreaTrabajo Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaAgregarAreaTrabajo();
                return _instancia;
            }
        }
        #endregion instancia

        public pantallaAgregarAreaTrabajo()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }
    }
}
