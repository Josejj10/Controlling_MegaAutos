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
    public partial class pantallaActualizarServicios : Pantalla
    {
        public pantallaActualizarServicios()
        {
            InitializeComponent();
            il_Servicios1.ItemListaClick += btnEditarClick;
            il_Servicios2.ItemListaClick += btnEditarClick;
            il_Servicios3.ItemListaClick += btnEditarClick;
            this.btn_Agregar.Click += btnAgregarClick;
            this.flowLayoutPanel1.AutoScroll = true;
        }

        private void btnEditarClick(Object sender, EventArgs e)
        {
            pantallaEditarServicio pes = new pantallaEditarServicio();
            if (pes.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
        }

        private void btnAgregarClick(Object sender, EventArgs e)
        {
            pantallaAgregarServicio pas = new pantallaAgregarServicio();
            
            if (pas.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
        }

        private void txt_Buscar_Enter(object sender, EventArgs e)
        {
            txt_Buscar.Text = string.Empty;
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

        private void pantallaActualizarServicios_Load(object sender, EventArgs e)
        {

        }

        private void txt_Buscar_Leave(object sender, EventArgs e)
        {
            if (txt_Buscar.Text == string.Empty)
                txt_Buscar.Text = "Buscar";
        }

        //private void rndAZ_MouseDown(object sender, MouseEventArgs e)
        //{
        //    this.rndAZ.ColorPanel = Colores.AmarilloHover;
        //    this.btnAZ.BackColor = Colores.AmarilloHover;
        //}

        //private void rndZA_MouseDown(object sender, MouseEventArgs e)
        //{
        //    this.rndZA.ColorPanel = Colores.AmarilloHover;
        //    this.btnZA.BackColor = Colores.AmarilloHover;
        //}

        //private void rndAntiguo_MouseDown(object sender, MouseEventArgs e)
        //{
        //    this.rndAntiguo.ColorPanel = Colores.AmarilloHover;
        //    this.btnAntiguo.BackColor = Colores.AmarilloHover;
        //}

        //private void rndReciente_MouseDown(object sender, MouseEventArgs e)
        //{
        //    this.rndReciente.ColorPanel = Colores.AmarilloHover;
        //    this.btnReciente.BackColor = Colores.AmarilloHover;
        //}

        //private void rndAZ_MouseUp(object sender, MouseEventArgs e)
        //{
        //    this.rndAZ.ColorPanel = Colores.AmarilloInteractivo;
        //    this.btnAZ.BackColor = Colores.AmarilloInteractivo;
        //}

        //private void rndZA_MouseUp(object sender, MouseEventArgs e)
        //{
        //    this.rndZA.ColorPanel = Colores.AmarilloInteractivo;
        //    this.btnZA.BackColor = Colores.AmarilloInteractivo;
        //}

        //private void rndAntiguo_MouseUp(object sender, MouseEventArgs e)
        //{
        //    this.rndAntiguo.ColorPanel = Colores.AmarilloInteractivo;
        //    this.btnAntiguo.BackColor = Colores.AmarilloInteractivo;
        //}

        //private void rndReciente_MouseUp(object sender, MouseEventArgs e)
        //{
        //    this.rndReciente.ColorPanel = Colores.AmarilloInteractivo;
        //    this.btnReciente.BackColor = Colores.AmarilloInteractivo;
        //}

    }
}
