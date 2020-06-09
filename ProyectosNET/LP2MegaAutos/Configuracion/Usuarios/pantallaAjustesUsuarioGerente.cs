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

namespace LP2MegaAutos
{
    public partial class pantallaAjustesUsuarioGerente : Pantalla
    {

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pantallaEditarInformacionPropia pnt = new pantallaEditarInformacionPropia();
            if (pnt.ShowDialog() == DialogResult.OK)
            {
                // Actualizar info
            }
            // Sino, nada
        }
        public pantallaAjustesUsuarioGerente()
        {
            InitializeComponent();
            this.btnEditar.Click += btnEditarUsu_Click;
        }

        private void btnEditarUsu_Click(Object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void btn_AgregarPermiso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agregar");
        }

        private void pantallaAjustesUsuarioGerente_Load(object sender, EventArgs e)
        {

        }
    }
}
