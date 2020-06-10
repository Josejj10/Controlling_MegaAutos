using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2MegaAutos.VentanasPrincipales;
using LP2MegaAutos.Configuracion.Empresa;

namespace LP2MegaAutos
{
    public partial class pantallaInformacionEmpresa : Pantalla
    {
        public pantallaInformacionEmpresa()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarNombEmpresa pas = new frmEditarNombEmpresa();
            if (pas.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
        }
    }
}
