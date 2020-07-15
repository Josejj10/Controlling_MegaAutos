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
using LP2MegaAutos.ServicioExcel;
using LP2MegaAutos.ServicioSede;
using System.Text.RegularExpressions;

namespace LP2MegaAutos
{
    public partial class frmGenerarReporte : MetroForm
    {
        private string _tipoReporte;
        private string _periodoReporte = "Diario";
        private reporte _reporte;
        public reporte Reporte { get { return _reporte; } }

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

        private void getFirstDayMonth(ref string fdm, ref string ldm)
        {
            var firstDayOfMonth = new DateTime(dtpInicio.Value.Year, dtpInicio.Value.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            fdm = firstDayOfMonth.ToString("dd-MM-yyyy");
            ldm = lastDayOfMonth.ToString("dd-MM-yyyy");
        }
        
        private void getFirstDayYear(ref string fdm, ref string ldm)
        {
            var firstDay = new DateTime(dtpInicio.Value.Year, dtpInicio.Value.Month, 1);
            var lastDay  = firstDay.AddYears(1).AddDays(-1);
            fdm = firstDay.ToString("dd-MM-yyyy");
            ldm = lastDay.ToString("dd-MM-yyyy");
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            // Preprocesar los datos
            ServicioSede.sede sede = (ServicioSede.sede)cboSede.SelectedItem;
            int idUsuario = frmPrincipal.Usuario.id;
            string fechaInicio = "";
            string fechaFin = "";
            string tReporte;
            switch (_tipoReporte)
            {
                case "Siniestro":
                    tReporte = "tipoSiniestro";
                    break;
                case "Cliente":
                    tReporte = "tipoCliente";
                    break;
                default:
                    tReporte = "areaTrabajo";
                    break;
            }

            string stringConfirmacion = $"¿Desea generar un reporte {_periodoReporte} por {_tipoReporte} de la sede {sede.distrito}";
            string titulo = String.IsNullOrEmpty(Regex.Replace(txtTitulo.Text, @"\s+", " ").Replace(" ","")) ? $"Reporte {_tipoReporte} de {sede.distrito}"
                : Regex.Replace(txtTitulo.Text, @"\s+"," ");
            switch (_periodoReporte)
            {
                case "Diario":
                    fechaInicio = fechaFin = dtpFechaFin.Value.ToString("dd-MM-yyyy");
                    break;
                case "Mensual":
                    getFirstDayMonth(ref fechaInicio, ref fechaFin);
                    break;
                case "Anual":
                    getFirstDayYear(ref fechaInicio, ref fechaFin);
                    break;
                default: // Otro
                    fechaInicio = dtpInicio.Value.ToString("dd-MM-yyyy");
                    fechaFin = dtpFechaFin.Value.ToString("dd-MM-yyyy");
                    stringConfirmacion += $" del {fechaInicio} al {fechaFin}";
                    break; 
            }
            stringConfirmacion += "?";         
            
            // Confirmar los datos del reporte
            frmMessageBox confirmacion = new frmMessageBox(stringConfirmacion, MessageBoxButtons.OKCancel, titulo);
            if (confirmacion.ShowDialog() != DialogResult.OK) return;
            

            // Si acepta, generar
            ExcelWSClient daoExcel = new ExcelWSClient();
            
            reporte r= daoExcel.generarReporte(fechaInicio, fechaFin, tReporte, sede.id, idUsuario,titulo, 0);
            this.DialogResult = DialogResult.OK;
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
