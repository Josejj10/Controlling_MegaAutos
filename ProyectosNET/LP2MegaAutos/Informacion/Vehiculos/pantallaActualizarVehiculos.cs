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
using LP2MegaAutos.ServicioVehiculo;

namespace LP2MegaAutos.Informacion.Vehiculos
{
    public partial class pantallaActualizarVehiculos : Pantalla
    {
        ServicioVehiculo.VehiculoWSClient daoVehiculo;
        public pantallaActualizarVehiculos()
        {
            InitializeComponent();
            this.btn_Agregar.Click += btnAgregarClick;
            flpVehiculos.AutoScroll = true;
            daoVehiculo = new ServicioVehiculo.VehiculoWSClient();
            inicializarItemsLista();
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

        private void inicializarItemsLista()
        {
            List<vehiculo> vehiculos = daoVehiculo.listarVehiculos().ToList();
            if (vehiculos == null) return;
            foreach (vehiculo v in vehiculos)
            {
                createItemListaVehiculo(v, "Carter Kane", DateTime.Now);
            }
        }

        private itemLista createItemListaVehiculo(ServicioVehiculo.vehiculo vehiculo, string agregadoPor, DateTime fechaAgregado)
        {
            itemLista il = new itemLista();
            BotonesDinamicosHelper.personalizarItemLista(il);
            il.Name = "il" + vehiculo.id;
            il.TextoAgregadoPor = agregadoPor;
            il.TextoFecha = fechaAgregado.ToString("dd/MM/yyyy");
            il.TextoPrincipal = vehiculo.placa;
            il.Textosecundario = vehiculo.propietario.nombre;
            il.TextoTercero = vehiculo.tipoVehiculo;
            il.ItemListaClick += (sender, e) => { verDatosVehiculo(sender, e, vehiculo); };
            il.EditarClick += (sender, e) => { btnEditarClick(sender, e, vehiculo); };
            flpVehiculos.Controls.Add(il);
            return il;
        }
        private void verDatosVehiculo(object sender, EventArgs e, ServicioVehiculo.vehiculo vehiculo)
        {
            frmEditarVehiculo pes = new frmEditarVehiculo(vehiculo);
            if (pes.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
        }
        private void btnAgregarClick(object sender, EventArgs e)
        {
            frmAgregarVehiculo pas = new frmAgregarVehiculo();

            if (pas.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
        }
        private void btnEditarClick(Object sender, EventArgs e, ServicioVehiculo.vehiculo vehiculo)
        {
            frmEditarVehiculo pas = new frmEditarVehiculo(vehiculo);

            if (pas.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
        }
    }
}
