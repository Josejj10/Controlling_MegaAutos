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
    public partial class pantallaActualizarServicios : UserControl
    {
        // Singleton instance para poder crearlo en la pantalla menu
        #region instancia
        private static pantallaActualizarServicios _instancia;
        public static pantallaActualizarServicios Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaActualizarServicios();
                return _instancia;
            }
        }
        #endregion instancia

        public pantallaActualizarServicios()
        {
            InitializeComponent();
            il_Servicios1.EditarClick += btnEditarClick;
            il_Servicios2.EditarClick += btnEditarClick;
            il_Servicios3.EditarClick += btnEditarClick;
            this.btn_Agregar.Click += btnAgregarClick;
        }

        private void btnEditarClick(Object sender, EventArgs e)
        {
            //MessageBox.Show("NO AUN");
            if (!this.Controls.Contains(pantallaEditarServicio.Instancia))
            {
                this.Controls.Add(pantallaEditarServicio.Instancia);
                pantallaEditarServicio.Instancia.Dock = DockStyle.Fill;
                if (DarkMode.is_dark_mode_active())
                    DarkMode.iniciarSinTimer(pantallaEditarServicio.Instancia.Parent);
            }
            pantallaEditarServicio.Instancia.BringToFront();
        }

        private void btnAgregarClick(Object sender, EventArgs e)
        {
            pantallaAgregarServicio pas = new pantallaAgregarServicio();
            
            if (pas.ShowDialog() == DialogResult.OK)
                MessageBox.Show("GAA");
            //MessageBox.Show("NO AUN");
            //if (!this.Controls.Contains(pantallaAgregarServicio.Instancia))
            //{
            //    this.Controls.Add(pantallaAgregarServicio.Instancia);
            //    pantallaAgregarServicio.Instancia.Dock = DockStyle.Fill;
            //    if (DarkMode.is_dark_mode_active())
            //        DarkMode.iniciarSinTimer(pantallaAgregarServicio.Instancia.Parent);
            //}
            //pantallaAgregarServicio.Instancia.BringToFront();
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

    }
}
