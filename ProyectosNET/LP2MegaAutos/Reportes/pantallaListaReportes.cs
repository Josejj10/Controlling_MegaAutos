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

namespace LP2MegaAutos
{
    public partial class pantallaListaReportes : Pantalla
    {
        private string _btnSeleccionado="Todos";
        public pantallaListaReportes()
        {
            InitializeComponent();
            flpReportes.AutoScroll = true;
            this.btnAZ_Click(btnAZ,new EventArgs());
            this.btn_todos_Click(btn_todos,new EventArgs());
        }
        public pantallaListaReportes(string agregando)
        {
            InitializeComponent();
            flpReportes.AutoScroll = true;
            this.btnAZ_Click(btnAZ,new EventArgs());
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
        }



        private void itemListaReporte_Click(object sender, EventArgs e)
        {
            frmResumenReporte frmReporte = new frmResumenReporte();
            if (frmReporte.ShowDialog() == DialogResult.OK)
            {
                // TODO dao
            }
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            frmGenerarReporte pgr = new frmGenerarReporte(this._btnSeleccionado);
            if (pgr.ShowDialog() == DialogResult.OK)
            {
                // TODO daoReporte llamar a procesar

                // Mostrar reporte generado
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
        
        #region Botones Filtro
        private void btnAZ_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndAZ, rndZA, rndAntiguo, rndReciente);
        }
        private void btnZA_Click(object sender, EventArgs e)
        {

            pantallaListasHelper.cambiarCuatroPaneles(
                rndZA, rndAZ, rndAntiguo, rndReciente);
        }
        private void btnAntiguo_Click(object sender, EventArgs e)
        {

            pantallaListasHelper.cambiarCuatroPaneles(
                rndAntiguo,rndAZ, rndZA, rndReciente);
        }
        private void btnReciente_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndReciente,rndAZ, rndZA, rndAntiguo);
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
            // TODO
        }
    }
}
