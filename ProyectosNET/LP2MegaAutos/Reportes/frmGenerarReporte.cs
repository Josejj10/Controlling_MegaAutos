using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using LP2MegaAutos.Framework;
using LP2MegaAutos.VentanasPrincipales;

namespace LP2MegaAutos
{
    public partial class frmGenerarReporte : MetroForm
    {
        private string _tipoReporte;
        private string _periodoReporte = "Diario";

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

        public frmGenerarReporte(string seleccion)
        {
            InitializeComponent();
            if(DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
            btnDiario_Click(btnDiario, new EventArgs());
            seleccionar(seleccion);
            ServicioSede.SedeWSClient daoSede = new ServicioSede.SedeWSClient();
            cboSede.DisplayMember = "distrito";
            cboSede.DataSource = daoSede.listarSedes();
        }

        private void seleccionar(string seleccion)
        {
            _tipoReporte = seleccion == "Todos" ? "AT" : seleccion;
            switch (seleccion)
            {
                case "Siniestro":
                    btnPorSiniestro_Click(btnPorSiniestro, new EventArgs());
                    break;
                case "Cliente":
                    btnPorCliente_Click(btnPorCliente, new EventArgs());
                    break;
                default:
                    btnPorAT_Click(btnPorAT, new EventArgs());
                    break;
            }
        }

        #region Botones Click
        private void btnDiario_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(rpDiario, rndAnual, rndMensual, rndOtro);
            pnlImgFechaFin.Visible = dtpFechaFin.Visible = rpFechaFin.Visible = false;
            rpFechaIni.Left = 157;
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.CustomFormat = "dd/MM/yyyy";
            _periodoReporte = "Diario";
        }

        private void btnMensual_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(rndMensual, rndAnual, rpDiario, rndOtro);
            pnlImgFechaFin.Visible = dtpFechaFin.Visible = rpFechaFin.Visible = false;
            rpFechaIni.Left = 157;
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.CustomFormat = "MM/yyyy";
            _periodoReporte = "Mensual";
        }

        private void btnAnual_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(rndAnual, rndMensual, rpDiario, rndOtro);
            pnlImgFechaFin.Visible = dtpFechaFin.Visible = rpFechaFin.Visible = false;
            rpFechaIni.Left = 157;
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.CustomFormat = "yyyy";
            _periodoReporte = "Anual";
        }

        private void btnOtro_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(rndOtro, rndMensual, rpDiario, rndAnual);
            pnlImgFechaFin.Visible = dtpFechaFin.Visible = rpFechaFin.Visible = true;
            rpFechaIni.Left = 51;
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.CustomFormat = "dd/MM/yyyy";
            _periodoReporte = "Otro";
        }
        #endregion Botones Click
        #region Tipo Reporte
        private void btnPorAT_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarTresPaneles(rpPorAT, rpPorSiniestro, rpPorCliente);
            this._tipoReporte = "AT";
        }

        private void btnPorSiniestro_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarTresPaneles(rpPorSiniestro, rpPorAT, rpPorCliente);
            this._tipoReporte = "Siniestro";
        }

        private void btnPorCliente_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarTresPaneles(rpPorCliente, rpPorSiniestro, rpPorAT);
            this._tipoReporte = "Cliente";

        }
        #endregion Tipo Reporte

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            // TODO Abrir Reporte Creado 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMessageBox frm = new frmMessageBox("¿Desea cancelar la generación de reporte?");
            if (frm.ShowDialog() != DialogResult.OK) return;
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmGenerarReporte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape) return;
            btnCancelar_Click(sender, e);
        }

    }
}
