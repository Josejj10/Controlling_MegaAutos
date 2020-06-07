using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace LP2MegaAutos
{
    public partial class frmFiltrarReportes : MetroForm
    {
        public frmFiltrarReportes()
        {
            InitializeComponent();
        }

        private string _btnSeleccionado = "AreaTrabajo";

        private void btnDiario_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rpDiario.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rndAnual.ColorPanel = Color.Transparent;
            this.rndMensual.ColorPanel = Color.Transparent;
            this.rndOtro.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnAnual.BackColor = Color.Transparent;
            this.btnDiario.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btnMensual.BackColor = Color.Transparent;
            this.btnOtro.BackColor = Color.Transparent;

            // TODO Cambiar el tiempo reporte
            //this._btnSeleccionado = "Vehiculo";
        }

        private void btnMensual_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndMensual.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rpDiario.ColorPanel = Color.Transparent;
            this.rndAnual.ColorPanel = Color.Transparent;
            this.rndOtro.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnDiario.BackColor = Color.Transparent;
            this.btnMensual.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btnAnual.BackColor = Color.Transparent;
            this.btnOtro.BackColor = Color.Transparent;

        }

        private void btnAnual_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndAnual.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rpDiario.ColorPanel = Color.Transparent;
            this.rndMensual.ColorPanel = Color.Transparent;
            this.rndOtro.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnDiario.BackColor = Color.Transparent;
            this.btnAnual.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btnMensual.BackColor = Color.Transparent;
            this.btnOtro.BackColor = Color.Transparent;

        }

        private void btnOtro_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndOtro.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rpDiario.ColorPanel = Color.Transparent;
            this.rndMensual.ColorPanel = Color.Transparent;
            this.rndAnual.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnDiario.BackColor = Color.Transparent;
            this.btnOtro.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btnMensual.BackColor = Color.Transparent;
            this.btnAnual.BackColor = Color.Transparent;

        }

        #region Tipo Reporte
        private void btnPorVehiculo_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rpPorVehiculo.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rpPorAreaTrabajo.ColorPanel = Color.Transparent;
            this.rpPorCliente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnPorCliente.BackColor = Color.Transparent;
            this.btnPorVehiculo.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btnPorAreaTrabajo.BackColor = Color.Transparent;

            this._btnSeleccionado = "Vehiculo";
        }

        private void btnPorAreaTrabajo_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rpPorVehiculo.ColorPanel = Color.Transparent;
            this.rpPorAreaTrabajo.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rpPorCliente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnPorCliente.BackColor = Color.Transparent;
            this.btnPorVehiculo.BackColor = Color.Transparent;
            this.btnPorAreaTrabajo.BackColor = Colores.AmarilloInteractivoMenos1;
            this._btnSeleccionado = "AreaTrabajo";
        }

        private void btnPorCliente_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rpPorVehiculo.ColorPanel = Color.Transparent;
            this.rpPorAreaTrabajo.ColorPanel = Color.Transparent;
            this.rpPorCliente.ColorPanel = Colores.AmarilloInteractivoMenos1;

            // Cambiar color botones de al frente
            this.btnPorCliente.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btnPorVehiculo.BackColor = Color.Transparent;
            this.btnPorAreaTrabajo.BackColor = Color.Transparent;
            this._btnSeleccionado = "Cliente";

        }
        #endregion Tipo Reporte


    }
}
