using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2MegaAutos.ServicioReporte;

namespace LP2MegaAutos
{
    public partial class pantallaDetalleReporte : UserControl
    {
        private reporte _reporte;
        public pantallaDetalleReporte()
        {
            InitializeComponent();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pantallaListarReportes_Load(object sender, EventArgs e)
        {

        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            // Abrir Form Resumen
            frmResumenReporte frmResumen = new frmResumenReporte(_reporte);
            frmResumen.Show();
        }

    }
}
