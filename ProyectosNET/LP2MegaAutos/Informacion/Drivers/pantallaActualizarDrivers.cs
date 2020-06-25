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

namespace LP2MegaAutos
{
    public partial class pantallaActualizarDrivers : Pantalla
    {
        ServicioDriver.DriverWSClient daoDriver;
        List<driver> drivers;
        public pantallaActualizarDrivers()
        {
            InitializeComponent();
            this.btn_Agregar.Click += btnAgregarClick;
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
            foreach (Control d in flpDrivers.Controls)
                d.Parent.Controls.Remove(d);
        }

        private void organizarAZ()
        {
            drivers.OrderBy(d => d.formula);
            quitarItemsLista();
            crearItemLista();
        }

        private void organizarZA()
        {
            drivers.OrderByDescending(d => d.formula);
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
                MessageBox.Show("OK");
            else if (d == DialogResult.Retry)
            {
                // Eliminar
                daoDriver.eliminarDriver(driver.id);
                flpDrivers.Controls.RemoveByKey("il" + driver.id);
                //ordenarItemsLista();
                inicializarItemsLista();
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
            // Cambiar color rounded panels de atras
            this.rndAZ.ColorPanel = Colores.ChooseAmarillo;
            this.rndZA.ColorPanel = Color.Transparent;
            this.rndAntiguo.ColorPanel = Color.Transparent;
            this.rndReciente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnZA.BackColor = Color.Transparent;
            this.btnAZ.BackColor = Colores.ChooseAmarillo;
            this.btnReciente.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Color.Transparent;
        }

        private void btnZA_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndAZ.ColorPanel = Color.Transparent;
            this.rndZA.ColorPanel = Colores.ChooseAmarillo;
            this.rndAntiguo.ColorPanel = Color.Transparent;
            this.rndReciente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnAZ.BackColor = Color.Transparent;
            this.btnZA.BackColor = Colores.ChooseAmarillo;
            this.btnReciente.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Color.Transparent;
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
    }
}
