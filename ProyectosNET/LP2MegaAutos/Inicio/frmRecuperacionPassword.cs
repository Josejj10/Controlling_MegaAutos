using LP2MegaAutos.ServicioUsuario;
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

namespace LP2MegaAutos.Inicio
{
    public partial class frmRecuperacionPassword : MetroForm
    {
        usuario _usuario;

        public frmRecuperacionPassword()
        {
            InitializeComponent();
            cambiarEstados();
        }

        public void cambiarEstados()
        {
            this.roundedPanel1.Enabled =
            this.roundedPanel2.Enabled =
            this.txtNewPass.Enabled =
            this.txtPassword.Enabled =
            this.btnAceptar.Enabled =
            !this.roundedPanel1.Enabled;

            if (this.roundedPanel1.Enabled)
            {
                this.roundedPanel1.ColorPanel =
                this.roundedPanel2.ColorPanel =
                this.roundedPanel1.ColorBorde =
                this.roundedPanel2.ColorBorde =
                Colores.Rosa;
            }
            else
            {
                this.roundedPanel1.ColorPanel =
                this.roundedPanel2.ColorPanel =
                this.roundedPanel1.ColorBorde =
                this.roundedPanel2.ColorBorde =
                Colores.Disabled;
            }
        }


        public usuario Usuario { get { return this._usuario; } }

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

        private void btnValidar_Click(object sender, EventArgs e)
        {
            //if(validar)
            if (true)
            {
                cambiarEstados();
                this.btnValidar.Enabled = false;
                this.btnValidar.Text = "Validado.";
            }
        }

        private bool validarCampos()
        {
            frmMessageBox frm;
            if (String.IsNullOrEmpty(this.txtPassword.Text+this.txtNewPass.Text))
            {
                frm = new frmMessageBox("Por favor llene todos los campos.", MessageBoxButtons.OK);
                frm.ShowDialog();
                return false;
            }
            if (this.txtNewPass.Text != this.txtPassword.Text)
            {
                frm = new frmMessageBox("Las contraseñas ingresadas son distintas.", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validarCampos()) return;
            frmMessageBox frm = new frmMessageBox("¿Desea guardar los cambios?");
            if (frm.ShowDialog() != DialogResult.OK) return;

            // _usuario = ServicioToken.getUsuario();
            _usuario = new usuario();
            _usuario.nombre = "Cambio Password";
            this.DialogResult = DialogResult.OK;
            
            // Si no,
            frm = new frmMessageBox("No se ha aplicado ningún cambio.",MessageBoxButtons.OK);
            frm.ShowDialog();
        }
    }
}
