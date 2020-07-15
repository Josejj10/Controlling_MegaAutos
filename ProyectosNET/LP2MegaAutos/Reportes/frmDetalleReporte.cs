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
using MetroFramework.Forms;
using LP2MegaAutos.ServicioExcel;
using LP2MegaAutos.VentanasPrincipales;
using System.IO;
using LP2MegaAutos.Reportes;

namespace LP2MegaAutos
{
    public partial class frmDetalleReporte : MetroForm
    {

        #region title_bar

        #region botones
        private void boton_cerrar_MouseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void boton_minimizar_MouseClick(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Minimized;
        }
        #endregion botones

        #region movement
        // Llama a la clase estatica TitleBar
        private void title_bar_MouseUp(object sender, MouseEventArgs e)
        {
            TitleBar.mouse_Up();
        }

        private void title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            TitleBar.mouse_Down(MousePosition, Bounds);
        }

        private void title_bar_MouseMove(object sender, MouseEventArgs e)
        {
            TitleBar.mouse_Move(MousePosition, this);
        }

        #endregion movement

        #endregion title_bar
        #region inicializar
        private ServicioExcel.reporte _reporte;
        public frmDetalleReporte(ServicioExcel.reporte reporte)
        {
            InitializeComponent();
            _reporte = reporte;
            inicializarDatos();
            inicializarItemsLista();
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
        }

        private void inicializarDatos()
        {
            this.lblTitulo.Text = _reporte.titulo;
            this.lblFechaGenerado.Text = _reporte.fechaCreacion.ToString("dd/MM/yyyy");
            this.lblQuienGenero.Text = _reporte.nombreUsuario;
            this.lblSede.Text = _reporte.sede.distrito;
            this.lblFecha.Text = _reporte.fechaInicio.ToString("dd/MM/yyyy") + " - " + _reporte.fechaFin.ToString("dd/MM/yyyy");
            switch (_reporte.tipoReporte)
            {
                case "tipoCliente":
                    this.lblTipoReporte.Text = "Tipo Cliente";
                    break;
                case "tipoSiniestro":
                    this.lblTipoReporte.Text = "Tipo Siniestro";
                    break;
                case "areaTrabajo":
                    this.lblTipoReporte.Text = "Area Trabajo";
                    break;
            }
        }

        #region inicializarItems
        private void inicializarItemsLista()
        {
            BindingList<detalleReporte> lista = new BindingList<detalleReporte>(_reporte.detalle);
            foreach (detalleReporte dr in lista)
            {
                crearItemLista(dr);
            }
        }

        private string switchTipoReporte()
        {
            switch (_reporte.tipoReporte)
            {
                case "tipoCliente":
                    return "Tipo Cliente";
                case "tipoSiniestro":
                    return "Tipo Siniestro";
                default:
                    return "Area Trabajo";
            }
        }

        private void crearItemLista(detalleReporte detalleReporte)
        {
            itemDetalleGrandeReporte item = new itemDetalleGrandeReporte();
            item.Margin = new Padding(4, 4, 25, 4);
            item.CuentaGrande = detalleReporte.cuenta;
            item.TipoCuenta = switchTipoReporte();
            item.Ingreso = ((double)detalleReporte.montos.GetValue(0)).ToString("n2");
            item.Egreso = ((double)detalleReporte.montos.GetValue(1)).ToString("n2");
            item.MontoTotal = ((double)detalleReporte.montos.GetValue(2)).ToString("n2");
            item.RightToLeft = RightToLeft.Yes;
            flpReportes.Controls.Add(item);
            // Agregar las areas de trabajo
            foreach (ServicioExcel.ordenTrabajo ot in detalleReporte.ordenes)
            {
                crearItemDetalle(ot);
            }
        }

        private void crearItemDetalle(ordenTrabajo ot)
        {
            itemDetalleReporte item = new itemDetalleReporte();
            item.Margin = new Padding(4);
            item.CuentaGrande = ot.numeroOrden;
            item.Egreso = (ot.totalEgresos).ToString("n2"); 
            item.Ingreso = (ot.totalIngresos).ToString("n2");
            item.TipoCuenta = ot.vehiculo.placa;
            item.Total = (ot.totalIngresos - ot.totalEgresos).ToString("n2");
            item.RightToLeft = RightToLeft.Yes;
            item.Cursor = Cursors.Hand;
            // Suscribir click
            item.ItemListaClick+= (sender, e) => { abrirOrdenTrabajo(sender, e, ot); };
            flpReportes.Controls.Add(item);
        }

        private void abrirOrdenTrabajo(Object sender, EventArgs e, ordenTrabajo ot)
        {
            frmOrdenTrabajo frm = new frmOrdenTrabajo(ot, _reporte.sede.distrito);
            frm.ShowDialog();
        }

        #endregion inicializarItems
        #endregion inicializar

        #region botones
        private void btnResumen_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (sfdArchivoReporte.ShowDialog() == DialogResult.OK)
            {
                ExcelWSClient daoExcel = new ExcelWSClient();
                ServicioExcel.excel _excelRecibido;
                // Poner las rutas por default
                frmMessageBox f;
                String archivoEntrada = sfdArchivoReporte.FileName + ".xlsx";
                LoadingHelper.loadingStart();
                _excelRecibido = daoExcel.buscarPorId(_reporte.idExcelSalida);
                LoadingHelper.stopLoading();
                if (_excelRecibido.archivo == null)
                {
                    f = new frmMessageBox("No se recibió ningún dato. El archivo insertado probablemente sea incorrecto", MessageBoxButtons.OK, "ERROR", true);
                    f.ShowDialog();
                    return;
                }
                File.WriteAllBytes(archivoEntrada, _excelRecibido.archivo);
                frmMessageBox frm = new frmMessageBox("Se ha guardado el Archivo", MessageBoxButtons.OK, "Mensaje de Confirmación");
                frm.ShowDialog();
            }
        }

        #endregion botones
    }
}
