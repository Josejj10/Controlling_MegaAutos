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

namespace LP2MegaAutos.VentanasPrincipales
{
    public partial class frmMessageBox : MetroForm
    {
        public frmMessageBox()
        {
            InitializeComponent();
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
        }

        public frmMessageBox(string mensaje, MessageBoxButtons btns = MessageBoxButtons.OKCancel,
                            string titulo = default(string), bool OKenRojo = false)
        {
            if (btns.HasFlag(MessageBoxButtons.YesNoCancel)) {
                Console.WriteLine("frmMessageBox no admite YesNoCancel");
                return;
            }
            InitializeComponent();
            if (!string.IsNullOrEmpty(titulo))
                lblTitulo.Text =  titulo;
            lblTexto.Text = mensaje;

            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
            if (btns.HasFlag(MessageBoxButtons.OKCancel))
                return;

            if (btns.HasFlag(MessageBoxButtons.OK))
            {
                rndCancelar.Parent.Controls.Remove(rndCancelar);
                tlpBotones.SetColumnSpan(rndOk,2);
            }

            if (btns.HasFlag(MessageBoxButtons.YesNo))
            {
                btnOk.Text = "Yes";
                btnCancelar.Text = "No";
            }

            if (OKenRojo)
                rndOk.ColorBorde = rndOk.ColorPanel = Colores.PrincipalRojo;
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


        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmMessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOk_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                btnNo_Click(sender, e);
            //  Si no, nada
        }
    }
}
