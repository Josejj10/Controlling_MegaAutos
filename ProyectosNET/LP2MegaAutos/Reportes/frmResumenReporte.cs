using LP2MegaAutos.ServicioComprobantePago;
using LP2MegaAutos.ServicioReporte;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private int nItems = 0;
        private ServicioReporte.reporte _reporte;

        public frmResumenReporte()
        {
            InitializeComponent();
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
        }

        public frmResumenReporte(reporte r)
        {
            InitializeComponent();
            inicializarItemsLista();
            _reporte = r;
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
        }
        private void inicializarItemsLista()
        {

            for(int i = 0; i < _reporte.mapaDetalle.Length; i++)
            {
                crearItemLista(_reporte.mapaDetalle[i], _reporte.mapaDetalleMontos[i]);
            }
        }

        private itemListaResumen crearItemLista(reporteEntry mapaDetalle, reporteEntry1 mapaCostos)
        {
            itemListaResumen item = new itemListaResumen();
            item.ColorPanelSubrayado  = item.ColorBordeSubrayado = Colores.VerdeSuccess;
            item.CuentasContables = "Detalle";
            item.Margin = new Padding(4, 4, 25, 4);
            item.TabIndex = 2 + nItems;
            item.Name = "itemListaResumen"+ ++nItems;

            // Personalizados
            item.TextoPrincipal = mapaDetalle.key; // Tipo de Siniestro
            //item.MontoEgresos = mapaCostos.value;
            //item.MontoIngresos = "9,999,999.00";
            //item.MontoTotal = "9,999,999.00";

            // Agregar las areas de trabajo
            // foreach(ordenTrabajo ot in mapaDetalle.value){
            //item.addCuentaContable(concepto,monto, ot);
            //}

            return item;   
        }


        private void btnDetalle_Click(object sender, EventArgs e)
        {
            // Deberia mandar un msgbox de si quieres salir
            this.Close();
        }

    }
}
