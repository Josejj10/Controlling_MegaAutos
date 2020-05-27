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
        public pantallaServicios()
        {
            InitializeComponent();
            il_Drivers1.EditarClick += btnEditarClick;
            il_Drivers2.EditarClick += btnEditarClick;
            il_Drivers3.EditarClick += btnEditarClick;
        }

        private void btnEditarClick(Object sender, EventArgs e)
        {
            MessageBox.Show("NO AUN");
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
