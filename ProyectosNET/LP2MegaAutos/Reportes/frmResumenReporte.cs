using LP2MegaAutos.ServicioComprobantePago;
using LP2MegaAutos.ServicioExcel;
using LP2MegaAutos.ServicioReporte;
using LP2MegaAutos.VentanasPrincipales;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2MegaAutos
{
    public partial class frmResumenReporte : MetroForm
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
        private int nItems = 0;
        private ServicioExcel.reporte _reporte;
        public ServicioExcel.reporte Reporte { get { return this._reporte; } }

        public frmResumenReporte()
        {
            InitializeComponent();
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
        }

        public frmResumenReporte(ServicioExcel.reporte r)
        {
            InitializeComponent();
            _reporte = r;
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

        #region inicializarLista
        private void inicializarItemsLista()
        {
            BindingList<detalleReporte> lista = new BindingList<detalleReporte>(_reporte.detalle);
            foreach(detalleReporte dr in lista)
            {
                itemListaResumen il = crearItemLista(dr);
                flpReporteResumen.Controls.Add(il);
            }
        }
        private itemListaResumen crearItemLista(detalleReporte detalleReporte)
        {
            itemListaResumen item = new itemListaResumen();
            if((double)detalleReporte.montos.GetValue(2)>0)
                item.ColorPanelSubrayado  = item.ColorBordeSubrayado = Colores.VerdeSuccess;
            else
                item.ColorPanelSubrayado = item.ColorBordeSubrayado = Colores.Rosa;
            item.CuentasContables = "Detalle";
            item.Margin = new Padding(4, 4, 25, 4);
            item.TabIndex = 2 + nItems;
            item.Name = "itemListaResumen"+ ++nItems;

            // Personalizados
            item.TextoPrincipal = detalleReporte.cuenta;
            item.MontoIngresos = ((double)detalleReporte.montos.GetValue(0)).ToString("n2");
            item.MontoEgresos = ((double)detalleReporte.montos.GetValue(1)).ToString("n2");
            item.MontoTotal= ((double)detalleReporte.montos.GetValue(2)).ToString("n2");

            // Agregar las areas de trabajo
            foreach(ServicioExcel.ordenTrabajo ot in detalleReporte.ordenes){
                item.addCuentaContable(ot, _reporte.sede.distrito);
            }

            return item;   
        }


        #endregion inicializarLista

        #endregion inicializar

        #region botones
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

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry; // TODO cuando reciba retry abrir Detalle
        }
        #endregion botones
    }
}
