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
    public partial class pantallaActualizarSedes : Pantalla
    {
        public pantallaActualizarSedes()
        {
            InitializeComponent();
            il_Sedes1.EditarClick += btnEditarClick;
            il_Sedes2.EditarClick += btnEditarClick;
            this.btn_Agregar.Click += btnAgregarClick;
            flowLayoutPanel1.AutoScroll = true;
        }

        private void btnEditarClick(Object sender, EventArgs e)
        {
            pantallaEditarSede pes = new pantallaEditarSede();
            if (pes.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
            //MessageBox.Show("NO AUN");
            //if (!this.Controls.Contains(pantallaEditarSede.Instancia))
            //{
            //    this.Controls.Add(pantallaEditarSede.Instancia);
            //    pantallaEditarSede.Instancia.Dock = DockStyle.Fill;
            //    if (DarkMode.is_dark_mode_active())
            //        DarkMode.iniciarSinTimer(pantallaEditarSede.Instancia.Parent);
            //}
            //pantallaEditarSede.Instancia.BringToFront();
        }

        private void btnAgregarClick(Object sender, EventArgs e)
        {
            pantallaAgregarSede pes = new pantallaAgregarSede();
            if (pes.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
            //MessageBox.Show("NO AUN");
            //if (!this.Controls.Contains(pantallaAgregarSede.Instancia))
            //{
            //    this.Controls.Add(pantallaAgregarSede.Instancia);
            //    pantallaAgregarSede.Instancia.Dock = DockStyle.Fill;
            //    if (DarkMode.is_dark_mode_active())
            //        DarkMode.iniciarSinTimer(pantallaAgregarSede.Instancia.Parent);
            //}
            //pantallaAgregarSede.Instancia.BringToFront();
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
            this.rndZA.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rndAZ.ColorPanel = Color.Transparent;
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
            this.rndAntiguo.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rndZA.ColorPanel = Color.Transparent;
            this.rndAZ.ColorPanel = Color.Transparent;
            this.rndReciente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnZA.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btnReciente.BackColor = Color.Transparent;
            this.btnAZ.BackColor = Color.Transparent;
        }

        private void btn_Reciente_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndReciente.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rndZA.ColorPanel = Color.Transparent;
            this.rndAntiguo.ColorPanel = Color.Transparent;
            this.rndAZ.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnZA.BackColor = Color.Transparent;
            this.btnReciente.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btnAZ.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Color.Transparent;
        }
    }
}
