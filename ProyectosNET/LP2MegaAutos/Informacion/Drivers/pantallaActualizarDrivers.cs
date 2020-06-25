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
using LP2MegaAutos.ServicioDriver;
using LP2MegaAutos.ServicioCliente;
using LP2MegaAutos.Framework;

namespace LP2MegaAutos
{
    public partial class pantallaActualizarDrivers : Pantalla
    {
        ServicioDriver.DriverWSClient daoDriver;
        List<driver> drivers;
        public pantallaActualizarDrivers()
        {
            InitializeComponent();
            flpDrivers.AutoScroll = true;
            daoDriver = new ServicioDriver.DriverWSClient();
            inicializarItemsLista();
        }
        private void inicializarItemsLista()
        {
            drivers = daoDriver.listarDrivers().ToList();
            crearItemLista();
        }

        private void crearItemLista()
        {
            if (drivers == null) return;
            foreach(driver d in drivers)
            {
                createItemListaDriver(d, "Carter Kane", DateTime.Now);
            }
        }

        private void quitarItemsLista()
        {
            for(int i = 0; i < flpDrivers.Controls.Count;)
                flpDrivers.Controls.RemoveAt(i);
        }

        private void organizarAZ()
        {
            drivers.OrderBy(d => d.formula).ToList();
            quitarItemsLista();
            crearItemLista();
        }

        private void organizarZA()
        {
            drivers.OrderByDescending(d => d.formula).ToList();
            quitarItemsLista();
            crearItemLista();
        }

        private itemLista createItemListaDriver(ServicioDriver.driver driver, string agregadoPor, DateTime fechaAgregado)
        {
            itemLista il = new itemLista();
            BotonesDinamicosHelper.personalizarItemLista(il);
            il.Name = "il" + driver.id;
            il.TextoAgregadoPor = agregadoPor;
            il.TextoFecha = fechaAgregado.ToString("dd/MM/yyyy");
            il.TextoPrincipal = driver.formula.ToString();
            il.Textosecundario = "Mecánica TBD";
            il.TextoTercero = "Luz TBD";
            il.ItemListaClick += (sender, e) => { verDatosDriver(sender, e, driver); };
            il.esconderBotonEditar();
            flpDrivers.Controls.Add(il);
            return il;
        }

        private void verDatosDriver(object sender, EventArgs e, ServicioDriver.driver driver)
        {
            pantallaEditarDriver pes = new pantallaEditarDriver(driver);
            DialogResult d = pes.ShowDialog();
            if (d == DialogResult.OK)
            {
                driver _driver = pes.Driver;
                daoDriver.actualizarDriver(_driver);
                createItemListaDriver(_driver, "Carter Kane", DateTime.Now);
                drivers.Remove(driver);
                drivers.Add(_driver);
                btnAZ_Click(btnAZ, new EventArgs());
            }
                
            else if (d == DialogResult.Retry)
            {
                // Eliminar
                daoDriver.eliminarDriver(driver.id);
                organizarAZ();
                drivers.Remove(driver);
                //ordenarItemsLista();
                btnAZ_Click(btnAZ, e);
            }
        }


        private void btnEditarClick(Object sender, EventArgs e, driver driver)
        {
            pantallaEditarDriver pes = new pantallaEditarDriver();
            if (pes.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
        }

        private void btnAgregarClick(Object sender, EventArgs e)
        {
            pantallaAgregarDriver pas = new pantallaAgregarDriver();

            if (pas.ShowDialog() == DialogResult.OK)
            {

            }
                MessageBox.Show("OK");

            ////MessageBox.Show("NO AUN");
            //if (!this.Controls.Contains(pantallaAgregarDriver.Instancia))
            //{
            //    this.Controls.Add(pantallaAgregarDriver.Instancia);
            //    pantallaAgregarDriver.Instancia.Dock = DockStyle.Fill;
            //    if (DarkMode.is_dark_mode_active())
            //        DarkMode.iniciarSinTimer(pantallaAgregarDriver.Instancia.Parent);
            //}
            //pantallaAgregarDriver.Instancia.BringToFront();
        }

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
            // Cambiar color rounded panels de atras
            this.rndAZ.ColorPanel = Color.Transparent;
            this.rndZA.ColorPanel = Color.Transparent;
            this.rndAntiguo.ColorPanel = Colores.ChooseAmarillo;
            this.rndReciente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnAZ.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Colores.ChooseAmarillo;
            this.btnReciente.BackColor = Color.Transparent;
            this.btnZA.BackColor = Color.Transparent;
        }

        private void btnReciente_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndAZ.ColorPanel = Color.Transparent;
            this.rndReciente.ColorPanel = Colores.ChooseAmarillo;
            this.rndZA.ColorPanel = Color.Transparent;
            this.rndAntiguo.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnAZ.BackColor = Color.Transparent;
            this.btnReciente.BackColor = Colores.ChooseAmarillo;
            this.btnZA.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Color.Transparent;
        }

        private void pantallaActualizarDrivers_Load(object sender, EventArgs e)
        {

        }


        private void txt_Buscar_Enter(object sender, EventArgs e)
        {
            if (txt_Buscar.Text == "Buscar")
                txt_Buscar.Text = string.Empty;
        }

        private void txt_Buscar_Leave(object sender, EventArgs e)
        {
            if (txt_Buscar.Text == string.Empty)
                txt_Buscar.Text = "Buscar";
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            pantallaEditarDriver dr = new pantallaEditarDriver();
            if(dr.ShowDialog() == DialogResult.OK)
            {
                driver _driver = dr.Driver;
                drivers.Add(_driver);
                frmMessageBox frm;
                if(daoDriver.insertarDriver(_driver) == 0)
                    frm = new frmMessageBox("No se pudo insertar.");
                else
                    frm = new frmMessageBox("Se inserto correctamente la sede en " + _driver.formula);
                frm.ShowDialog();
            }
        }
    }
}
