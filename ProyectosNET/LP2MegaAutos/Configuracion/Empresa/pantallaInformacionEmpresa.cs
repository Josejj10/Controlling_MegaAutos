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

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fld = new FolderBrowserDialog();
            if (fld.ShowDialog() == DialogResult.OK)
            {
                txtArchivo1.Text = fld.SelectedPath;
            }
        }

        private void btnExaminar2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fld = new FolderBrowserDialog();
            fld.ShowDialog();
            if (fld.ShowDialog() == DialogResult.OK)
            {
                txtArchivo2.Text = fld.SelectedPath;                    
            }
        }

        private void btnEditarRutas_Click(object sender, EventArgs e)
        {
            txtArchivo1.Enabled = txtArchivo2.Enabled =
            btnExaminar.Enabled = btnExaminar2.Enabled = !btnExaminar2.Enabled;
            btnDefault.Visible = btnGuardar.Visible = !btnGuardar.Visible;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Almacenar los string en el back
            // WebService.GuardarArchivo(txtArchivo1.Text);
            // WebService.GuardarArchivo(txtArchivo2.Text);

        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            // Poner las rutas por default
        }
    }
}
