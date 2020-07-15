using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using LP2MegaAutos.ServicioUsuario;
using LP2MegaAutos.VentanasPrincipales;
using LP2MegaAutos.Framework;
using LP2MegaAutos.Properties;
using LP2MegaAutos.ServicioExcel;

namespace LP2MegaAutos.Reportes
{
    public partial class frmOrdenTrabajo : MetroForm
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


        ServicioExcel.ordenTrabajo _ot;
        public frmOrdenTrabajo()
        {
            InitializeComponent();
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
        }
        public frmOrdenTrabajo(ServicioExcel.ordenTrabajo ot)
        {
            InitializeComponent();
            _ot = ot;
            inicializarOrden();
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
        }
        public frmOrdenTrabajo(ServicioExcel.ordenTrabajo ot, string distrito)
        {
            InitializeComponent();
            _ot = ot;
            inicializarOrden();
            lbl_SedeEscrito.Text = distrito;
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
        }

        private void inicializarOrden()
        {
            lbl_OrdenTrabajo.Text = _ot.numeroOrden;
            lbl_SedeEscrito.Text = _ot.sede.distrito;
            lbl_ClienteEscrito.Text = _ot.cliente.nombre;
            lbl_PlacaEscrito.Text = _ot.vehiculo.placa;
            lbl_TotalIngresosEscrito.Text = _ot.totalIngresos.ToString("n2");
            lbl_TotalEgresosEscrito.Text = _ot.totalEgresos.ToString("n2");
            lbl_Fecha.Text = _ot.fecha.ToString("dd/MM/yyyy");
            if (_ot.servicios == null) return;
            foreach(servicio s in _ot.servicios)
            {
                crearItemListaCuadrado(s);
            }
        }

        private void crearItemListaCuadrado(servicio s)
        {
            itemListaCuadrado item = new itemListaCuadrado();
            item.BackColor = Color.Transparent;
            item.imgFondo = Resources.Servicio;
            item.Margin = new Padding(4);
            item.Name = "itemListaCuadrado"+s.id;
            item.Seleccionado = false;
            item.TextoPrincipal = s.nombre;
            flpServicios.Controls.Add(item);
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        // TODO

    }
}
