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
    public partial class pantallaActualizarClientes : Pantalla
    {
        public pantallaActualizarClientes()
        {
            InitializeComponent();
            il_Clientes1.EditarClick += btnEditarClick;
            il_Clientes2.EditarClick += btnEditarClick;
            il_Clientes3.EditarClick += btnEditarClick;
            this.btn_Agregar.Click += btnAgregarClick;
            flpClientes.AutoScroll = true;
        }
        private void btnEditarClick(Object sender, EventArgs e)
        {
            pantallaEditarCliente pes = new pantallaEditarCliente();
            if (pes.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");

            ////MessageBox.Show("NO AUN");
            //if (!this.Controls.Contains(pantallaEditarCliente.Instancia))
            //{
            //    this.Controls.Add(pantallaEditarCliente.Instancia);
            //    pantallaEditarCliente.Instancia.Dock = DockStyle.Fill;
            //    if (DarkMode.is_dark_mode_active())
            //        DarkMode.iniciarSinTimer(pantallaEditarCliente.Instancia.Parent);
            //}
            //pantallaEditarCliente.Instancia.BringToFront();
        }

        private void btnAgregarClick(Object sender, EventArgs e)
        {
            pantallaAgregarCliente pas = new pantallaAgregarCliente();

            if (pas.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");

            ////MessageBox.Show("NO AUN");
            //if (!this.Controls.Contains(pantallaAgregarCliente.Instancia))
            //{
            //    this.Controls.Add(pantallaAgregarCliente.Instancia);
            //    pantallaAgregarCliente.Instancia.Dock = DockStyle.Fill;
            //    if (DarkMode.is_dark_mode_active())
            //        DarkMode.iniciarSinTimer(pantallaAgregarCliente.Instancia.Parent);
            //}
            //pantallaAgregarCliente.Instancia.BringToFront();
        }

        private void btnAZ_Click(object sender, EventArgs e)
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

        private void btnZA_Click(object sender, EventArgs e)
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

        private void btnAntiguo_Click(object sender, EventArgs e)
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

        private void btnReciente_Click(object sender, EventArgs e)
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

        private void pantallaActualizarClientes_Load(object sender, EventArgs e)
        {

        }

        private void il_Clientes1_Load(object sender, EventArgs e)
        {

        }
        private void txt_Buscar_Enter(object sender, EventArgs e)
        {
            txt_Buscar.Text = string.Empty;
        }

    }
}
