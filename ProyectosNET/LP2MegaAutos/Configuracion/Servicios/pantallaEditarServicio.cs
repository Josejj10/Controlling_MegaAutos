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
using System.Windows.Controls.Primitives;
using LP2MegaAutos.Properties;
using LP2MegaAutos.VentanasPrincipales;
using LP2MegaAutos.Framework;

namespace LP2MegaAutos
{
    public partial class pantallaEditarServicio : MetroForm
    {
        ServicioServicio.servicio _servicio;
        public pantallaEditarServicio()
        {
            InitializeComponent();
            _servicio = new ServicioServicio.servicio();
            txt_NombreServicio.Text = "Agregar nombre de servicio...";
        }
        public pantallaEditarServicio(ServicioServicio.servicio servicio)
        {
            InitializeComponent();
            _servicio = servicio;
            toggleComponentes();
            this.txt_NombreServicio.Text = OtrosHelper.tipoOracion(servicio.nombre);
            this.txt_codServ.Text = servicio.codigoServicio;
            this.txt_descripcion.Text = OtrosHelper.tipoParrafo(servicio.descripcion);
            //this.txt_tipoServicio.Text = OtrosHelper.tipoOracion(servicio.tipoServicio);
            this.cboTipoServicio.Text = OtrosHelper.tipoOracion(servicio.tipoServicio);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            toggleComponentes();
        }

        private void toggleComponentes()
        {
            bool en = txt_NombreServicio.Enabled = txt_codServ.Enabled =
                txt_descripcion.Enabled = cboTipoServicio.Enabled = btn_guardar.Enabled
                = !txt_NombreServicio.Enabled;


            if (!en)
            {
                // No habilitado
                txt_NombreServicio.BackColor = txt_codServ.BackColor =
                    txt_descripcion.BackColor = cboTipoServicio.BackColor
                    = Colores.FrontBackground;

                txt_NombreServicio.ForeColor = txt_codServ.ForeColor =
                    txt_descripcion.ForeColor = cboTipoServicio.ForeColor =
                    rnd_color_1.ColorPanel = rnd_color_3.ColorPanel =
                    rnd_color_2.ColorPanel =
                    rnd_guardar.ColorPanel =
                    rnd_color_1.ColorBorde = rnd_color_3.ColorBorde =
                    rnd_color_2.ColorBorde = rnd_guardar.ColorBorde
                    = Colores.Disabled;


                btnEditar.BackgroundImage = Resources.editar;
                return;
            }
            // Habilitado
            txt_NombreServicio.ForeColor = Colores.HighContrast;
            txt_codServ.ForeColor =
               txt_descripcion.ForeColor = cboTipoServicio.ForeColor =
               Colores.HighContrast;

            rnd_color_1.ColorPanel = rnd_color_3.ColorPanel =
                    rnd_color_2.ColorPanel =
                    rnd_guardar.ColorPanel =
                    rnd_color_1.ColorBorde = rnd_color_3.ColorBorde =
                    rnd_color_2.ColorBorde = rnd_guardar.ColorBorde
                    = Colores.Rosa;

            btnEditar.BackgroundImage = Resources.Logout;
        }

        public ServicioServicio.servicio Servicio { get { return _servicio; } }
       
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!servicioValido())
                return;
            frmMessageBox f = new frmMessageBox("¿Guardar Cambios?", MessageBoxButtons.OKCancel, "Guardar Cambios");
            if (f.ShowDialog() != DialogResult.OK)
                return;
            _servicio.nombre = txt_NombreServicio.Text;
            _servicio.codigoServicio = txt_codServ.Text;
            _servicio.descripcion = txt_descripcion.Text;
            _servicio.tipoServicio = cboTipoServicio.Text;
            this.DialogResult = DialogResult.OK;
        }

        private bool servicioValido()
        {
            // Sacapalabras al txt
            if (string.IsNullOrEmpty(txt_NombreServicio.Text) || txt_NombreServicio.Text=="Agregar nombre de servicio...")
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese el nombre de servicio", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(txt_codServ.Text))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese el código de servicio.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(txt_descripcion.Text))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese la descripción del servicio.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (cboTipoServicio.SelectedIndex == -1)
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese el tipo de servicio.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (txt_codServ.Text.Length != 7)
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un codigo de servicio correcto.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            return true;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar frm = new frmEliminar("eliminar el servicio" + _servicio.nombre);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.Retry;
            }
        }
    }
}
