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
    public partial class pantallaDetalleReporte : UserControl
    {
        #region instancia
        private static pantallaDetalleReporte _instancia;
        public static pantallaDetalleReporte Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaDetalleReporte();
                return _instancia;
            }
        }
        #endregion instancia

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
            frmResumenReporte frmResumen = new frmResumenReporte();
            frmResumen.Show();
        }

    }
}
