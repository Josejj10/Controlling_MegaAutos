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
using LP2MegaAutos.ServicioDriver;
using LP2MegaAutos.Framework;
using LP2MegaAutos.VentanasPrincipales;
using System.Text.RegularExpressions;
using LP2MegaAutos.ServicioCliente;

namespace LP2MegaAutos
{
    public partial class pantallaEditarDriver : MetroForm
    {
        ServicioDriver.driver _driver;
        public pantallaEditarDriver()
        {
            InitializeComponent();
            _driver = new ServicioDriver.driver();
            this.btnEditar.Visible = false;
            this.btnEliminar.Visible = false;
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
        }

        public pantallaEditarDriver(ServicioDriver.driver driver)
        {
            InitializeComponent();
            _driver = driver;
            toggleComponentes();
            this.txt_Formula.Text = OtrosHelper.tipoOracion(driver.formula.ToString());
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            toggleComponentes();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!driverValido())
                return;
            frmMessageBox f = new frmMessageBox("¿Guardar Cambios?", MessageBoxButtons.OKCancel, "Guardar Cambios");
            if (f.ShowDialog() != DialogResult.OK)
                return;
            _driver.formula = Convert.ToDouble(txt_Formula.Text);
            this.DialogResult = DialogResult.OK;
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
        private void pantallaEditarDriver_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void toggleComponentes()
        {
            bool en = txt_Formula.Enabled  = btn_guardar.Enabled = !lblDriver.Enabled;

            if (!en)
            {
                // No habilitado
                lblDriver.BackColor = txt_Formula.BackColor = 
                     Colores.FrontBackground;

                lblDriver.ForeColor = txt_Formula.ForeColor = 
                    rnd_color_1.ColorPanel =

                    rnd_guardar.ColorPanel =
                    rnd_color_1.ColorBorde =

                    rnd_guardar.ColorBorde
                    = Colores.Disabled;

                lblDriver.Enabled = false;
                btnEditar.BackgroundImage = Resources.editar;
                return;
            }
            // Habilitado
            lblDriver.ForeColor = txt_Formula.ForeColor = Colores.HighContrast;

            rnd_color_1.ColorPanel =

                    rnd_guardar.ColorPanel =
                    rnd_color_1.ColorBorde = 
                    rnd_guardar.ColorBorde
                    = Colores.Rosa;

            lblDriver.Enabled = true;
            btnEditar.BackgroundImage = Resources.Cancelar;
        }

        public ServicioDriver.driver Driver { get { return _driver; } }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar frm = new frmEliminar("eliminar el driver " + _driver.formula.ToString());
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.Retry;
            }
        }

        private bool driverValido()
        {
            // Sacapalabras al txt
            double resultado = 0;
            bool isDouble = false;

            isDouble = Double.TryParse(txt_Formula.Text, out resultado);
            resultado = Double.Parse(txt_Formula.Text);

            if (string.IsNullOrEmpty(txt_Formula.Text))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese una formula", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (isDouble == false)
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese una formula correcta", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (resultado >= 1)
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese una formula correcta (menor a 1)", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            return true;
        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            if (!driverValido())
                return;
            frmMessageBox f = new frmMessageBox("¿Guardar Cambios?", MessageBoxButtons.OKCancel, "Guardar Cambios");
            if (f.ShowDialog() != DialogResult.OK)
                return;
            _driver.formula = double.Parse(txt_Formula.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
