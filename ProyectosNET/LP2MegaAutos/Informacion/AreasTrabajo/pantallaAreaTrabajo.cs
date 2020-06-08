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
    public partial class pantallaAreaTrabajo : Pantalla
    {
        // Singleton instance para poder crearlo en la pantalla menu
        #region instancia
        private static pantallaAreaTrabajo _instancia;
        public static pantallaAreaTrabajo Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaAreaTrabajo();
                return _instancia;
            }
        }
        #endregion instancia
        
        public pantallaAreaTrabajo()
        {
            InitializeComponent();
            il_AreaTrabajo2.EditarClick += btnEditarClick;
            il_AreaTrabajo1.EditarClick += btnEditarClick;
            il_AreaTrabajo3.EditarClick += btnEditarClick;
        }

        private void btnEditarClick(Object sender, EventArgs e)
        {
            //MessageBox.Show("NO AUN");
            if (!this.Controls.Contains(pantallaEditarAreaTrabajo.Instancia))
            {
                this.Controls.Add(pantallaEditarAreaTrabajo.Instancia);
                pantallaEditarAreaTrabajo.Instancia.Dock = DockStyle.Fill;
                pantallaEditarAreaTrabajo.Instancia.BringToFront();
            }
            else
                pantallaEditarAreaTrabajo.Instancia.BringToFront();
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
            txt_Buscar.Text = string.Empty;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("NO AUN");
            if (!this.Controls.Contains(pantallaAgregarAreaTrabajo.Instancia))
            {
                this.Controls.Add(pantallaAgregarAreaTrabajo.Instancia);
                pantallaAgregarAreaTrabajo.Instancia.Dock = DockStyle.Fill;
                pantallaAgregarAreaTrabajo.Instancia.BringToFront();
            }
            else
                pantallaAgregarAreaTrabajo.Instancia.BringToFront();
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
