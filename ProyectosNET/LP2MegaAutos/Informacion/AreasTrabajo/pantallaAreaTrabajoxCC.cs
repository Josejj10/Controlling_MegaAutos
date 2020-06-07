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
    public partial class pantallaAreaTrabajoxCC : UserControl
    {

        #region instancia
        private static pantallaAreaTrabajoxCC _instancia;
        public static pantallaAreaTrabajoxCC Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaAreaTrabajoxCC();
                return _instancia;
            }
        }
        #endregion instancia

        public pantallaAreaTrabajoxCC()
        {
            InitializeComponent();
        }

        private void btn_AgregarCuentaContable_Click(object sender, EventArgs e)
        {
            frmCuentaContable formCC = new frmCuentaContable();
            formCC.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
