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
using LP2MegaAutos.Properties;
using LP2MegaAutos.Framework;
using LP2MegaAutos.VentanasPrincipales;
using LP2MegaAutos.ServicioComprobantePago;

namespace LP2MegaAutos
{
    public partial class pantallaEditarSede : MetroForm
    {
        ServicioSede.sede _sede;
        public pantallaEditarSede()
        {
            InitializeComponent();
            _sede = new ServicioSede.sede();
            txt_NombreSede.Text = "Agregar nombre de sede...";
            this.btnEliminar.Visible = this.btnEditar.Visible =false;
        }

        public pantallaEditarSede(ServicioSede.sede sede)
        {
            InitializeComponent();
            _sede = sede;
            toggleComponentes();
            this.cboDistritos.Text = OtrosHelper.tipoOracion(sede.distrito).Trim();
            this.txt_NombreSede.Text = OtrosHelper.tipoOracion(sede.nombre).Trim();
            this.txt_direccion.Text = OtrosHelper.tipoOracion(sede.direccion).Trim();
            this.txt_telefono.Text = OtrosHelper.tipoOracion(sede.telefono).Trim();
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

        private void txt_NombreSede_Enter(object sender, EventArgs e)
        {
            if (txt_NombreSede.Text == "Agregar nombre de sede...")
                txt_NombreSede.Text = string.Empty;
            txt_NombreSede.ForeColor = Colores.HighContrast;
        }

        private void txt_NombreSede_Leave(object sender, EventArgs e)
        {
            if (txt_NombreSede.Text == string.Empty)
            {
                txt_NombreSede.ForeColor = Colores.LowContrast;
                txt_NombreSede.Text = "Agregar nombre de sede...";
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!sedeValido())
                return;
            frmMessageBox f = new frmMessageBox("¿Guardar Cambios?", MessageBoxButtons.OKCancel, "Guardar Cambios");
            if (f.ShowDialog() != DialogResult.OK)
                return;
            _sede.nombre = txt_NombreSede.Text.Trim();
            _sede.distrito = cboDistritos.Text.Trim();
            _sede.direccion = txt_direccion.Text.Trim();
            _sede.telefono = txt_telefono.Text.Trim();
            this.DialogResult = DialogResult.OK;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            toggleComponentes();
        }

        private void toggleComponentes()
        {
            bool en = txt_NombreSede.Enabled = cboDistritos.Enabled =
                txt_direccion.Enabled = txt_telefono.Enabled = btn_guardar.Enabled
                = !txt_NombreSede.Enabled;


            if (!en)
            {
                // No habilitado
                txt_NombreSede.BackColor = Colores.FrontBackground;

                txt_NombreSede.ForeColor = cboDistritos.ForeColor =
                    txt_direccion.ForeColor = txt_telefono.ForeColor =
                    rnd_color_1.ColorPanel = rnd_color_3.ColorPanel =
                    roundedPanel2.ColorPanel =
                    rnd_guardar.ColorPanel =
                    rnd_color_1.ColorBorde = rnd_color_3.ColorBorde =
                    roundedPanel2.ColorBorde = rnd_guardar.ColorBorde
                    = Colores.Disabled;


                btnEditar.BackgroundImage = Resources.editar;
                return;
            }
            // Habilitado
            txt_NombreSede.ForeColor =
            cboDistritos.ForeColor =
               txt_direccion.ForeColor = txt_telefono.ForeColor =
               Colores.HighContrast;

            rnd_color_1.ColorPanel = rnd_color_3.ColorPanel =
                    roundedPanel2.ColorPanel =
                    rnd_guardar.ColorPanel =
                    rnd_color_1.ColorBorde = rnd_color_3.ColorBorde =
                    roundedPanel2.ColorBorde = rnd_guardar.ColorBorde
                    = Colores.Rosa;

            btnEditar.BackgroundImage = Resources.Cancelar;
        }

        public ServicioSede.sede Sede { get { return _sede; } }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar frm = new frmEliminar("eliminar la sede " + _sede.nombre);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.Retry;
            }
        }
        private bool sedeValido()
        {
            // Sacapalabras al txt
            if (string.IsNullOrEmpty(txt_NombreSede.Text) || txt_NombreSede.Text == "Agregar nombre de sede...")
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un nombre de la sede", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (cboDistritos.SelectedIndex == -1)
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un distrito.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(txt_direccion.Text))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese una dirreccion.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(txt_telefono.Text))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un teléfono.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (txt_telefono.Text.Length != 8)
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un teléfono correcto.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            return true;
        }
    }
}
