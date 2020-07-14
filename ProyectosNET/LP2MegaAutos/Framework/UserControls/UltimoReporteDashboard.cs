using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using LP2MegaAutos.Properties;

namespace LP2MegaAutos.Framework.UserControls
{
    public partial class UltimoReporteDashboard : UserControl
    {
        public UltimoReporteDashboard()
        {
            InitializeComponent();
            pnlReloj.BackgroundImage = ResizeImageHelper.ResizeImage(Resources.Reloj, 28, 28);
            DarkMode.agregarExcepcion("btnVerReporte");
            DarkMode.agregarExcepcion("lblUltimoReporte");
        }

        #region Propiedades

        [Description("Titulo"), Category("Ultimo Reporte")]
        public string TextoPrincipal
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }


        [Description("Monto Total"), Category("Ultimo Reporte")]
        public string MontoTotal
        {
            get { return lblTotal.Text; }
            set { lblTotal.Text = value; }
        }

        [Description("Monto Ingresos"), Category("Ultimo Reporte")]
        public string MontoIngresos
        {
            get { return lblIngresos.Text; }
            set { lblIngresos.Text = value; }
        }

        [Description("Monto Egresos"), Category("Ultimo Reporte")]
        public string MontoEgresos
        {
            get { return lblEgresos.Text; }
            set { lblEgresos.Text = value; }
        }
        
        [Description("Rango Fechas Reporte (ej. 24/05/19 - 24/06/19)"), Category("Ultimo Reporte")]
        public string RangoFechasReporte
        {
            get { return lblFechasReporte.Text; }
            set { lblFechasReporte.Text = value; }
        }

        [Description("Primer nombre y apellido del Usuario que generó el último reporte."), Category("Ultimo Reporte")]
        public string UsuarioGenerador
        {
            get { return lblGeneradoPor.Text; }
            set { lblGeneradoPor.Text = value; }
        }

        [Description("Periodo Reporte: Mensual, Anual, Diario, u Otro."), Category("Ultimo Reporte")]
        public string PeriodoReporte
        {
            get { return lblPeriodoReporte.Text; }
            set { lblPeriodoReporte.Text = value; }
        }

        [Description("Sede"), Category("Ultimo Reporte")]
        public string SedeReporte
        {
            get { return lblSede.Text; }
            set { lblGeneradoPor.Text = value; }
        }

        [Description("Area Trabajo, Cliente, Vehiculo"), Category("Ultimo Reporte")]
        public string TipoReporte
        {
            get { return lblTipoReporte.Text; }
            set { lblTipoReporte.Text = value; }
        }

        #endregion Propiedades


        // Delegar click Ver Reporte
        public delegate void ButtonClickEventHandler(object sender, EventArgs e);
        public event ButtonClickEventHandler VerReporteClick;

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = VerReporteClick;
            if (h != null) h(this, e);
        }
    }
}
