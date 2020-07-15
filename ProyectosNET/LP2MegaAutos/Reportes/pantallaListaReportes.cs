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
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using LP2MegaAutos.Framework;
using LP2MegaAutos.ServicioReporte;
using LP2MegaAutos.ServicioUsuario;
using LP2MegaAutos.ServicioExcel;

namespace LP2MegaAutos
{
    public partial class pantallaListaReportes : Pantalla
    {

        private ServicioReporte.ReporteWSClient daoReportes;
        private List<ServicioReporte.reporte> _reportes;
        private List<ServicioReporte.reporte> _reportesB;
        private string textoBuscar; // TODO

        private string _btnSeleccionado="Todos";
        
        public pantallaListaReportes()
        {
            InitializeComponent();
            flpReportes.AutoScroll = true;
            daoReportes = new ReporteWSClient();
            txt_Buscar.Text += textoBuscar; 
        }
        
        public void inicializarItemsLista()
        {
            _reportes  = _reportesB = daoReportes.listarReportes().ToList();
            if (_reportes == null) return;
            this.btnAZ_Click(btnAZ, new EventArgs());
            this.btn_todos_Click(btn_todos, new EventArgs());
        }

        public pantallaListaReportes(string agregando)
        {
            InitializeComponent();
            flpReportes.AutoScroll = true;
            daoReportes = new ReporteWSClient();
            txt_Buscar.Text += textoBuscar;
            switch (agregando) {
                case "AT":
                    this.btn_AreaTrabajo_Click(btn_AreaTrabajo,new EventArgs());
                    this.btn_Agregar_Click(btnGenerar, new EventArgs());
                    break;
                case "Siniestro":
                    this.btn_Siniestro_Click(btnTipoSiniestro,new EventArgs());
                    this.btn_Agregar_Click(btnGenerar, new EventArgs());
                    break;
                case "Cliente":
                    this.btn_cliente_Click(btn_cliente,new EventArgs());
                    this.btn_Agregar_Click(btnGenerar, new EventArgs());
                    break;
                default:
                    this.btn_todos_Click(btn_todos, new EventArgs());
                    break;
            }
            daoReportes = new ReporteWSClient();
        }

        private void itemListaReporte_Click(object sender, EventArgs e, ServicioReporte.reporte r)
        {
            ExcelWSClient daoExcel = new ExcelWSClient();
            string fechaInicio = r.fechaInicio.ToString("dd-MM-yyyy");
            string fechaFin = r.fechaFin.ToString("dd-MM-yyyy");

            LoadingHelper.loadingStart();
            ServicioExcel.reporte rep = daoExcel.generarReporte(fechaInicio, fechaFin, r.tipoReporte, 
                r.sede.id, r.idUsuario, r.titulo, r.idReporte);
            LoadingHelper.stopLoading();
            abrirResumen(rep);
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            frmGenerarReporte pgr = new frmGenerarReporte(this._btnSeleccionado);
            if(pgr.ShowDialog() == DialogResult.OK)
            {
                frmResumenReporte frm = new frmResumenReporte(pgr.Reporte);
                frm.ShowDialog();
            }
        }

        private void abrirResumen(ServicioExcel.reporte r)
        {
            frmResumenReporte frm = new frmResumenReporte(r);
            if(frm.ShowDialog() == DialogResult.Retry)
            {
                abrirDetalle(r);
            }
        }

        private void abrirDetalle(ServicioExcel.reporte r)
        {
            frmDetalleReporte frm = new frmDetalleReporte(r);
            if (frm.ShowDialog() == DialogResult.Retry)
            {
                abrirResumen(r);
            }


        }


        #region Botones Tipo Reporte
        private void btn_todos_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndTodos, rndSiniestro, rndAreaTrabajo, rndCliente);
            this._btnSeleccionado = "Todos";
        }
        private void btn_Siniestro_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndSiniestro, rndTodos, rndAreaTrabajo, rndCliente);
            this._btnSeleccionado = "Siniestro";
        }
        private void btn_AreaTrabajo_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndAreaTrabajo,rndSiniestro, rndTodos, rndCliente);
            this._btnSeleccionado = "AT";
        }
        private void btn_cliente_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndCliente,rndAreaTrabajo, rndSiniestro, rndTodos);
            this._btnSeleccionado = "Cliente";
        }
        #endregion Botones Tipo Reporte


        private void personalizarItemListaReporte(itemListaReporte item)
        {
            item.Anchor = AnchorStyles.None;
            item.BackColor = Color.Transparent;
            item.ColorBack = Color.Transparent;
            item.ColorBorde = Colores.PrincipalAzulMetalico;
            item.ColorPanel = Colores.BackBackground;
            item.Margin = new Padding(5);
            item.TabIndex = 0;
        }

        private void createItemListaReporte(ServicioReporte.reporte r)
        {
            itemListaReporte item = new itemListaReporte();
            personalizarItemListaReporte(item);
            item.TextoPrincipal = r.titulo;
            switch (r.tipoReporte)
            {
                case "tipoCliente":
                    item.Tipo = "Tipo Cliente";
                    break;
                case "tipoSiniestro":
                    item.Tipo = "Tipo Siniestro";
                    break;
                case "areaTrabajo":
                    item.Tipo = "Area Trabajo";
                    break;
                default:
                    item.Tipo = r.tipoReporte;
                    break;
            }
            item.MontoEgresos = r.ingresos.ToString("n2");
            item.MontoIngresos = r.egresos.ToString("n2");
            item.MontoTotal = (r.ingresos-r.egresos).ToString("n2");
            item.Name = "itemListaReporte"+r.idReporte;
            item.QuienGenero = r.nombreUsuario;
            item.Sede = r.sede.distrito; 
            item.FechaGenerado = r.fechaCreacion.ToString("dd/MM/yyyy");
            item.ItemListaClick += (sender, e) => { itemListaReporte_Click(sender, e, r); };
            flpReportes.Controls.Add(item);
        }

        #region Organizar
        private void crearItemsLista()
        {
            if (_reportes == null) return;
            foreach (ServicioReporte.reporte r in _reportes)
            {
                createItemListaReporte(r);
            }
        }
        private void crearItemsListaReportes()
        {
            quitarItemsLista();
            if (_reportes == null) return;
            foreach (ServicioReporte.reporte r in _reportesB)
            {
                createItemListaReporte(r);
            }
        }
        

        private void quitarItemsLista()
        {
            for (int i = 0; i < flpReportes.Controls.Count;)
                flpReportes.Controls.RemoveAt(i);
        }

        private void organizarAZ()
        {
            _reportes = _reportes.OrderBy(r => r.tipoReporte).ToList();
            quitarItemsLista();
            crearItemsLista();
        }

        private void organizarZA()
        {
            _reportes = _reportes.OrderByDescending(r => r.tipoReporte).ToList();
            quitarItemsLista();
            crearItemsLista();
        }

        private void organizarAntiguo()
        {
            _reportes = _reportes.OrderBy(r => r.fechaCreacion).ToList();
            quitarItemsLista();
            crearItemsLista();
        }

        private void organizarReciente()
        {
            _reportes = _reportes.OrderByDescending(r => r.fechaCreacion).ToList();
            quitarItemsLista();
            crearItemsLista();
        }
        #endregion Organizar

        #region Botones Filtro
        private void btnAZ_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndAZ, rndZA, rndAntiguo, rndReciente);
            organizarAZ();
        }
        private void btnZA_Click(object sender, EventArgs e)
        {

            pantallaListasHelper.cambiarCuatroPaneles(
                rndZA, rndAZ, rndAntiguo, rndReciente);
            organizarZA();
        }
        private void btnAntiguo_Click(object sender, EventArgs e)
        {

            pantallaListasHelper.cambiarCuatroPaneles(
                rndAntiguo,rndAZ, rndZA, rndReciente);
            organizarAntiguo();
        }
        private void btnReciente_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndReciente,rndAZ, rndZA, rndAntiguo);
            organizarReciente();
        }
        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button)
                pantallaListasHelper.btn_MouseDown((Button)sender);
        }
        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Button)
                pantallaListasHelper.btn_MouseUp((Button)sender);
        }
        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Button)
                pantallaListasHelper.btn_MouseMove((Button)sender);
        }
        private void txt_Buscar_Enter(object sender, EventArgs e)
        {
            pantallaListasHelper.buscarEnter(txt_Buscar);
        }
        private void txt_Buscar_Leave(object sender, EventArgs e)
        {
            pantallaListasHelper.buscarLeave(txt_Buscar);
        }
        #endregion Botones Filtro

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Se tiene la lista _usuarios localmente
            List<ServicioReporte.reporte> _reportesBuscados = new List<ServicioReporte.reporte>();
            foreach (ServicioReporte.reporte r in _reportes)
                if (r.titulo.Contains(txt_Buscar.Text.ToUpper()))
                    _reportesBuscados.Add(r); 

            quitarItemsLista();
            if (_reportesBuscados.Count == 0)
            {
                frmMessageBox frm = new frmMessageBox("No se hallaron resultados para la búsqueda.", MessageBoxButtons.OK);
                frm.ShowDialog();
                _reportesBuscados= _reportes;
                txt_Buscar.Text = string.Empty;
            }
            crearItemsListaBuscar(_reportesBuscados);
            pantallaListasHelper.buscarLeave(txt_Buscar, textoBuscar);
        }

        private void crearItemsListaBuscar(List<ServicioReporte.reporte> reportesBuscados)
        {
            _reportesB = reportesBuscados;
            if (_reportesB== null) return;
            crearItemsListaReportes();
        }

        private void txt_Buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            // buscar
            btnBuscar_Click(btnBuscar, e);
        }
    }
}
