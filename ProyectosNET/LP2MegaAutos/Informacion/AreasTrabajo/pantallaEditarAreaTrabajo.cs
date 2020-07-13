using LP2MegaAutos.Framework;
using LP2MegaAutos.VentanasPrincipales;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2MegaAutos.Informacion.AreasTrabajo
{
    public partial class pantallaEditarAreaTrabajo : MetroForm
    {
        ServicioAreaTrabajo.areaTrabajo _areaTrabajo;
        public pantallaEditarAreaTrabajo()
        {
            InitializeComponent();
            _areaTrabajo = new ServicioAreaTrabajo.areaTrabajo();
            lbl_EditarAreaTrabajo.Text = "Agregar Área de Trabajo";
            btnEliminar.Visible = false;
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
        }
        
        public pantallaEditarAreaTrabajo(ServicioAreaTrabajo.areaTrabajo areaTrabajo)
        {
            InitializeComponent();
            _areaTrabajo = areaTrabajo;
            lbl_EditarAreaTrabajo.Text = "Editar Área de Trabajo";
            this.txt_nombAreaTrabajo.Text = OtrosHelper.tipoOracion(areaTrabajo.nombre);
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!areaTrabajoValido())
                return;
            frmMessageBox f = new frmMessageBox("¿Guardar Cambios?", MessageBoxButtons.OKCancel, "Guardar Cambios");
            if (f.ShowDialog() != DialogResult.OK)
                return;
            _areaTrabajo.nombre = txt_nombAreaTrabajo.Text;
            this.DialogResult = DialogResult.OK;
        }

        public ServicioAreaTrabajo.areaTrabajo AreaTrabajo { get { return _areaTrabajo; } }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar frm = new frmEliminar("eliminar el area de trabajo " + _areaTrabajo.nombre);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.Retry;
            }
        }

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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private bool areaTrabajoValido()
        {
            // Sacapalabras al txt
            if (string.IsNullOrEmpty(txt_nombAreaTrabajo.Text))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un nombre", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }
            return true;
        }
    }
}
