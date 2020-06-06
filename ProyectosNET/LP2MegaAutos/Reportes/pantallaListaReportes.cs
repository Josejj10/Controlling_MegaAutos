using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2MegaAutos
{
    public partial class pantallaListaReportes : UserControl
    {
        // Singleton instance para poder crearlo en la pantalla menu
        #region instancia
        private static pantallaListaReportes _instancia;
        public static pantallaListaReportes Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaListaReportes();
                return _instancia;
            }
        }
        #endregion instancia

        public pantallaListaReportes()
        {
            InitializeComponent();
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
            if (!this.Parent.Controls.Contains(pantallaGenerarReporte.Instancia))
                this.Parent.Controls.Add(pantallaGenerarReporte.Instancia);
            pantallaGenerarReporte.Instancia.BringToFront();
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
    }
}
