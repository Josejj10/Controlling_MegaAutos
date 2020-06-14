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
        }
        private void itemListaReporte_Click(object sender, EventArgs e)
        {
            frmResumenReporte frmReporte = new frmResumenReporte();
            if (frmReporte.ShowDialog() == DialogResult.OK)
            {
                // Hacer algo
            }
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            pantallaGenerarReporte pgr = new pantallaGenerarReporte(this._btnSeleccionado);
            if (pgr.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
            //if (!this.Parent.Controls.Contains(pantallaGenerarReporte.Instancia))
            //    this.Parent.Controls.Add(pantallaGenerarReporte.Instancia);
            //pantallaGenerarReporte.Instancia.BringToFront();
        }

        #region Botones Tipo Reporte
        private void btn_todos_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndTodos, rndVehiculo, rndAreaTrabajo, rndCliente);
            this._btnSeleccionado = "Todos";
        }
        private void btn_vehiculo_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndVehiculo, rndTodos, rndAreaTrabajo, rndCliente);
            this._btnSeleccionado = "Vehiculo";
        }
        private void btn_AreaTrabajo_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndAreaTrabajo,rndVehiculo, rndTodos, rndCliente);
            this._btnSeleccionado = "AreaTrabajo";
        }
        private void btn_cliente_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndCliente,rndAreaTrabajo, rndVehiculo, rndTodos);
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

        private void txt_Buscar_MouseEnter(object sender, EventArgs e)
        {
            pantallaListasHelper.buscarEnter(txt_Buscar);
        }

        private void txt_Buscar_MouseLeave(object sender, EventArgs e)
        {
            pantallaListasHelper.buscarLeave(txt_Buscar);
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


        //TODO CAMBIAR BOTONES
        // TODO COLORES 250,220,123

    }
}
