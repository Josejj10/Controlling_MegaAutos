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

namespace LP2MegaAutos
{
    public partial class pantallaListaReportes : Pantalla
    {

        public pantallaListaReportes()
        {
            InitializeComponent();
            flpReportes.AutoScroll = true;
        }


        private void btn_todos_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rnd_todos.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rnd_vehiculo.ColorPanel = Color.Transparent;
            this.rnd_AreaTrabajo.ColorPanel = Color.Transparent;
            this.rnd_cliente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btn_todos.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btn_vehiculo.BackColor = Color.Transparent;
            this.btn_AreaTrabajo.BackColor = Color.Transparent;
            this.btn_cliente.BackColor = Color.Transparent;
        }

        private void btn_vehiculo_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rnd_todos.ColorPanel = Color.Transparent;
            this.rnd_vehiculo.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rnd_AreaTrabajo.ColorPanel = Color.Transparent;
            this.rnd_cliente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btn_todos.BackColor = Color.Transparent;
            this.btn_vehiculo.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btn_AreaTrabajo.BackColor = Color.Transparent;
            this.btn_cliente.BackColor = Color.Transparent;
        }

        private void btn_AreaTrabajo_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rnd_todos.ColorPanel = Color.Transparent;
            this.rnd_vehiculo.ColorPanel = Color.Transparent;
            this.rnd_AreaTrabajo.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rnd_cliente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btn_todos.BackColor = Color.Transparent;
            this.btn_vehiculo.BackColor = Color.Transparent;
            this.btn_AreaTrabajo.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btn_cliente.BackColor = Color.Transparent;
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rnd_todos.ColorPanel = Color.Transparent;
            this.rnd_vehiculo.ColorPanel = Color.Transparent;
            this.rnd_AreaTrabajo.ColorPanel = Color.Transparent;
            this.rnd_cliente.ColorPanel = Colores.AmarilloInteractivoMenos1;

            // Cambiar color botones de al frente
            this.btn_todos.BackColor = Color.Transparent;
            this.btn_vehiculo.BackColor = Color.Transparent;
            this.btn_AreaTrabajo.BackColor = Color.Transparent;
            this.btn_cliente.BackColor = Colores.AmarilloInteractivoMenos1;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            pantallaGenerarReporte pgr = new pantallaGenerarReporte();
            if (pgr.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
            //if (!this.Parent.Controls.Contains(pantallaGenerarReporte.Instancia))
            //    this.Parent.Controls.Add(pantallaGenerarReporte.Instancia);
            //pantallaGenerarReporte.Instancia.BringToFront();
        }


        //TODO CAMBIAR BOTONES
        // TODO COLORES 250,220,123

        private void btn_todos_MouseDown(object sender, MouseEventArgs e)
        {
            this.rnd_todos.ColorPanel = Colores.AmarilloHover;

            this.btn_todos.BackColor = Colores.AmarilloHover;
        
        }

        private void btn_todos_MouseUp(object sender, MouseEventArgs e)
        {
            this.rnd_todos.ColorPanel = Colores.AmarilloInteractivo;
            this.btn_todos.BackColor = Colores.AmarilloInteractivo;
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
    }
}
