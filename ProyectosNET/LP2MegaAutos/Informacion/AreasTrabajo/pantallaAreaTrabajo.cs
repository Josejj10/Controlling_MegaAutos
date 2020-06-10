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
using LP2MegaAutos.Informacion.AreasTrabajo;

namespace LP2MegaAutos
{
    public partial class pantallaAreaTrabajo : Pantalla
    {        
        public pantallaAreaTrabajo()
        {
            InitializeComponent();
            il_AreaTrabajo1.EditarClick += btnEditarClick;
            il_AreaTrabajo2.EditarClick += btnEditarClick;
            il_AreaTrabajo3.EditarClick += btnEditarClick;
            this.btn_Agregar.Click += btnAgregarClick;
            flowLayoutPanel1.AutoScroll = true;
        }

        private void btnEditarClick(Object sender, EventArgs e)
        {
            pantallaEditarAreaTrabajo pas = new pantallaEditarAreaTrabajo();

            if (pas.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
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

        private void btnAgregarClick(object sender, EventArgs e)
        {
            pantallaAgregarAreaTrabajo pas = new pantallaAgregarAreaTrabajo();

            if (pas.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
            //MessageBox.Show("NO AUN");
            //if (!this.Controls.Contains(pantallaAgregarAreaTrabajo.Instancia))
            //{
            //    this.Controls.Add(pantallaAgregarAreaTrabajo.Instancia);
            //    pantallaAgregarAreaTrabajo.Instancia.Dock = DockStyle.Fill;
            //    pantallaAgregarAreaTrabajo.Instancia.BringToFront();
            //}
            //else
            //    pantallaAgregarAreaTrabajo.Instancia.BringToFront();
        }

        private void il_AreaTrabajo1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("NO AUN");
            if (!this.Controls.Contains(pantallaAreaTrabajoxCC.Instancia))
            {
                this.Controls.Add(pantallaAreaTrabajoxCC.Instancia);
                pantallaAreaTrabajoxCC.Instancia.Dock = DockStyle.Fill;
                pantallaAreaTrabajoxCC.Instancia.BringToFront();
            }
            else
                pantallaAreaTrabajoxCC.Instancia.BringToFront();
        }
    }
}
