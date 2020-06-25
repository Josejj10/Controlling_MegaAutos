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

namespace LP2MegaAutos
{
    public partial class pantallaEditarServicio : MetroForm
    {
        ServicioServicio.servicio _servicio;
        public pantallaEditarServicio()
        {
            InitializeComponent();
            txt_NombreServicio.Text = "Agregar nombre de servicio...";
        }
        public pantallaEditarServicio(ServicioServicio.servicio servicio)
        {
            InitializeComponent();
            _servicio = servicio;
            toggleComponentes();
            this.txt_NombreServicio.Text = servicio.nombre;
            this.txt_codServ.Text = servicio.codigoServicio;
            this.txt_descripcion.Text = servicio.descripcion;
            this.txt_tipoServicio.Text = servicio.tipoServicio;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            toggleComponentes();
        }

        private void toggleComponentes()
        {
            bool en = txt_NombreServicio.Enabled = txt_codServ.Enabled =
                txt_descripcion.Enabled = txt_tipoServicio.Enabled = btn_guardar.Enabled
                = !txt_NombreServicio.Enabled;


            if (!en)
            {
                // No habilitado
                txt_NombreServicio.BackColor = txt_codServ.BackColor =
                    txt_descripcion.BackColor = txt_tipoServicio.BackColor
                    = Colores.FrontBackground;

                txt_NombreServicio.ForeColor = txt_codServ.ForeColor =
                    txt_descripcion.ForeColor = txt_tipoServicio.ForeColor =
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
               txt_descripcion.ForeColor = txt_tipoServicio.ForeColor =
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
