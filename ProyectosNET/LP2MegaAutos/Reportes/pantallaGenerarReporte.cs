﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace LP2MegaAutos
{
    public partial class pantallaGenerarReporte : MetroForm
    {
        private string _btnSeleccionado;

        #region title_bar

        #region botones
        private void boton_cerrar_MouseClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void boton_minimizar_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Minimized;
        }
        #endregion botones

        #region movement
        // Llama a la clase estatica TitleBar
        private void title_bar_MouseUp(object sender, MouseEventArgs e)
        {
            TitleBar.mouse_Up();
        }

        private void title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            TitleBar.mouse_Down(MousePosition, Bounds);
        }

        private void title_bar_MouseMove(object sender, MouseEventArgs e)
        {
            TitleBar.mouse_Move(MousePosition, this);
        }

        #endregion movement

        #endregion title_bar

        public pantallaGenerarReporte(string seleccion)
        {
            InitializeComponent();
            
            this._btnSeleccionado = seleccion;
            inicialTxtInputBuscar();
            
            txt_InputBuscar.AutoSize = false;
            txtSede.AutoSize = false;
            txt_InputBuscar.Size = new Size(315,30);
            txtSede.Size = new Size(143, 30);
            //DarkMode.agregarExcepcion("rpBtnGenerarReporte");
            DarkMode.agregarExcepcion("btnGenerarReporte");
        }

        private void suscribirEventos()
        {
            btnPorAreaTrabajo.Click += cambiarTxtInputBuscar;
            btnPorVehiculo.Click += cambiarTxtInputBuscar;
            btnPorCliente.Click += cambiarTxtInputBuscar;

        }

        #region Botones Click
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
        #endregion Botones Click
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

        private void txt_InputBuscar_Enter(object sender, EventArgs e)
        {
            if (txt_InputBuscar.Text == "Placa"
                || txt_InputBuscar.Text == "Area"
                || txt_InputBuscar.Text == "Dni o Nombre"
                || txt_InputBuscar.Text == "Filtro  tipo de reporte")
                txt_InputBuscar.Text = string.Empty;
        }

        private void txt_InputBuscar_Leave(object sender, EventArgs e)
        {
            if (txt_InputBuscar.Text == string.Empty)
                cambiarTxtInputBuscar(sender, e);
        }
        #endregion Tipo Reporte

        private void inicialTxtInputBuscar()
        {
            switch (_btnSeleccionado)
            {
                case "AreaTrabajo":
                    txt_InputBuscar.Text = "Area";
                    this.txt_InputBuscar.AutoCompleteCustomSource.AddRange(new string[] {
                    "Planchado",
                    "Pintura",
                    "Administración"});
                    btnPorAreaTrabajo_Click(this, new EventArgs());
                    break;
                case "Vehiculo":
                    txt_InputBuscar.Text = "Placa";
                    this.txt_InputBuscar.AutoCompleteCustomSource.AddRange(new string[] {
                    "ABC-123",
                    "AAA-222",
                    "LWYRUP"});
                    btnPorVehiculo_Click(this, new EventArgs());
                    break;
                case "Cliente":
                    txt_InputBuscar.Text = "Dni o Nombre";
                    this.txt_InputBuscar.AutoCompleteCustomSource.AddRange(new string[] {
                    "70359516",
                    "DR. PROF. FREDDY PAZ",
                    "CARLOMAGNO VESPUCIO IV"});
                    btnPorCliente_Click(this, new EventArgs());
                    break;
                case "Todos":
                    txt_InputBuscar.Text = "Filtro  tipo de reporte";
                    break;
            }
        }

        private void cambiarTxtInputBuscar(object sender, EventArgs e)
        {
            switch (_btnSeleccionado)
            {
                case "AreaTrabajo":
                    txt_InputBuscar.Text = "Area";
                    this.txt_InputBuscar.AutoCompleteCustomSource.AddRange(new string[] {
                    "Planchado",
                    "Pintura",
                    "Administración"});
                    break;
                case "Vehiculo":
                    txt_InputBuscar.Text = "Placa";
                    this.txt_InputBuscar.AutoCompleteCustomSource.AddRange(new string[] {
                    "ABC-123",
                    "AAA-222",
                    "LWYRUP"});
                    break;
                case "Cliente":
                    txt_InputBuscar.Text = "Dni o Nombre";
                    this.txt_InputBuscar.AutoCompleteCustomSource.AddRange(new string[] {
                    "70359516",
                    "DR. PROF. FREDDY PAZ",
                    "CARLOMAGNO VESPUCIO IV"});
                    break;
                case "Todos":
                    txt_InputBuscar.Text = "Filtro  tipo de reporte";
                    break;
            }

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            // TODO Abrir Reporte Creado 
        }

        private void txtSede_Enter(object sender, EventArgs e)
        {
            txtSede.Text = string.Empty;
        }

        private void txtSede_Leave(object sender, EventArgs e)
        {
            if (txtSede.Text == string.Empty)
                txtSede.Text = "Sede";
        }
    }
}