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

namespace LP2MegaAutos
{
    public partial class pantallaActualizarDrivers : Pantalla
    {
        // Singleton instance para poder crearlo en la pantalla menu
        #region instancia
        private static pantallaActualizarDrivers _instancia;
        public static pantallaActualizarDrivers Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaActualizarDrivers();
                return _instancia;
            }
        }
        #endregion instancia

        public pantallaActualizarDrivers()
        {

            InitializeComponent();
            il_Drivers1.EditarClick += btnEditarClick;
            il_Drivers2.EditarClick += btnEditarClick;
            il_Drivers3.EditarClick += btnEditarClick;
            this.btn_Agregar.Click += btnAgregarClick;
        }

        private void btnEditarClick(Object sender, EventArgs e)
        {
            pantallaEditarDriver pes = new pantallaEditarDriver();
            if (pes.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");

            ////MessageBox.Show("NO AUN");
            //if (!this.Controls.Contains(pantallaEditarDriver.Instancia))
            //{
            //    this.Controls.Add(pantallaEditarDriver.Instancia);
            //    pantallaEditarDriver.Instancia.Dock = DockStyle.Fill;
            //    if (DarkMode.is_dark_mode_active())
            //        DarkMode.iniciarSinTimer(pantallaEditarDriver.Instancia.Parent);
            //}
            //pantallaEditarDriver.Instancia.BringToFront();
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

        private void btn_AZ_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndAZ.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rndZA.ColorPanel = Color.Transparent;
            this.rndAntiguo.ColorPanel = Color.Transparent;
            this.rndReciente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnZA.BackColor = Color.Transparent;
            this.btnAZ.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btnReciente.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Color.Transparent;
        }

        private void btn_ZA_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndAZ.ColorPanel = Color.Transparent;
            this.rndZA.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rndAntiguo.ColorPanel = Color.Transparent;
            this.rndReciente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnAZ.BackColor = Color.Transparent;
            this.btnZA.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btnReciente.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Color.Transparent;
        }

        private void btn_Antiguo_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndAZ.ColorPanel = Color.Transparent;
            this.rndZA.ColorPanel = Color.Transparent;
            this.rndAntiguo.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rndReciente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnAZ.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btnReciente.BackColor = Color.Transparent;
            this.btnZA.BackColor = Color.Transparent;
        }

        private void btn_Reciente_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndAZ.ColorPanel = Color.Transparent;
            this.rndReciente.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rndZA.ColorPanel = Color.Transparent;
            this.rndAntiguo.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnAZ.BackColor = Color.Transparent;
            this.btnReciente.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btnZA.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Color.Transparent;
        }

        private void pantallaActualizarDrivers_Load(object sender, EventArgs e)
        {

        }
    }
}
