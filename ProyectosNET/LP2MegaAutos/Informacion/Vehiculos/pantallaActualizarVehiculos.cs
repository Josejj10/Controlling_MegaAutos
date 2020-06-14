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
using LP2MegaAutos.Framework;

namespace LP2MegaAutos.Informacion.Vehiculos
{
    public partial class pantallaActualizarVehiculos : Pantalla
    {
        public pantallaActualizarVehiculos()
        {
            InitializeComponent();
            il_Vehiculo1.ItemListaClick += btnEditarClick;
            il_Vehiculo2.ItemListaClick += btnEditarClick;
            il_Vehiculo3.ItemListaClick += btnEditarClick;
            this.btn_Agregar.Click += btnAgregarClick;
            flowLayoutPanel1.AutoScroll = true;
        }
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
                rndAntiguo, rndAZ, rndZA, rndReciente);
        }
        private void btnReciente_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndReciente, rndAZ, rndZA, rndAntiguo);
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

        private void btnAgregarClick(object sender, EventArgs e)
        {
            frmAgregarVehiculo pas = new frmAgregarVehiculo();

            if (pas.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
        }
        private void btnEditarClick(Object sender, EventArgs e)
        {
            frmEditarVehiculo pas = new frmEditarVehiculo();

            if (pas.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
        }
    }
}
