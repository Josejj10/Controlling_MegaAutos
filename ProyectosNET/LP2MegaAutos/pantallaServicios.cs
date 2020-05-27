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
    public partial class pantallaServicios : UserControl
    {
        // Singleton instance para poder crearlo en la pantalla menu
        #region instancia
        private static pantallaServicios _instancia;
        public static pantallaServicios Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaServicios();
                return _instancia;
            }
        }
        #endregion instancia

        public pantallaServicios()
        {
            InitializeComponent();
            il_Drivers1.EditarClick += btnEditarClick;
            il_Drivers2.EditarClick += btnEditarClick;
            il_Drivers3.EditarClick += btnEditarClick;
        }

        private void btnEditarClick(Object sender, EventArgs e)
        {
            //MessageBox.Show("NO AUN");
            if (!this.Controls.Contains(pantallaInicioGerente.Instancia))
            {
                this.Controls.Add(pantallaInicioGerente.Instancia);
                pantallaInicioGerente.Instancia.Dock = DockStyle.Fill;
                pantallaInicioGerente.Instancia.BringToFront();
            }
            else
                pantallaInicioGerente.Instancia.BringToFront();
        }

        private void btn_AZ_Drivers_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.roundedPanel1.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.roundedPanel2.ColorPanel = Color.Transparent;
            this.roundedPanel3.ColorPanel = Color.Transparent;
            this.roundedPanel3.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btn_ZA_Drivers.BackColor = Color.Transparent;
            this.btn_AZ_Drivers.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btn_Reciente_Drivers.BackColor = Color.Transparent;
            this.btn_Antiguo_Drivers.BackColor = Color.Transparent;
        }

        private void btn_ZA_Drivers_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.roundedPanel1.ColorPanel = Color.Transparent;
            this.roundedPanel2.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.roundedPanel3.ColorPanel = Color.Transparent;
            this.roundedPanel3.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btn_AZ_Drivers.BackColor = Color.Transparent;
            this.btn_ZA_Drivers.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btn_Reciente_Drivers.BackColor = Color.Transparent;
            this.btn_Antiguo_Drivers.BackColor = Color.Transparent;
        }

    }
}
