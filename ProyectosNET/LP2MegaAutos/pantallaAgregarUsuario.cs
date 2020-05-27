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
        public pantallaAgregarUsuario()
        {
            InitializeComponent();
        }

        private void btn_AgregarPermiso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agregar");
        }
    }
}
