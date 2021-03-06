﻿using LP2MegaAutos.ServicioUsuario;
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
        private usuario _usuario;
        private string _correo;
        private int CARACTERES_TOKEN = 16;
        ServicioPassword.PasswordWSClient daoPassword;

        public frmRecuperacionPassword()
        {
            InitializeComponent();
            cambiarEstados();
            daoPassword = new ServicioPassword.PasswordWSClient();
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
        }
        
        public frmRecuperacionPassword(string correo)
        {
            InitializeComponent();
            cambiarEstados();
            _correo = correo;
            daoPassword = new ServicioPassword.PasswordWSClient();
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
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
            frmMessageBox frm = new frmMessageBox(
                "Cancelar invalidaría el token y se le tendría que enviar un correo nuevamente.",
                MessageBoxButtons.OKCancel, "Cancelar Recuperación", true);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                daoPassword.invalidarToken(_correo, "");
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private bool validarTxtToken()
        {
            frmMessageBox frm;
            if (this.txtToken.Text.Length!=CARACTERES_TOKEN || 
                String.IsNullOrEmpty(this.txtToken.Text))
            {
                frm = new frmMessageBox("El token debe tener "+CARACTERES_TOKEN+ " caracteres.");
                frm.ShowDialog();
                return false;
            }
            return true;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            frmMessageBox frm;
            if (!validarTxtToken()) return;
            Console.WriteLine($"Correo: {_correo}, token: {this.txtToken.Text}");
            if (!daoPassword.verificarToken(_correo, this.txtToken.Text))
            {
                frm = new frmMessageBox("Token Invalido.", MessageBoxButtons.OK, "Error", true);
                frm.ShowDialog();
                return;
            }
            cambiarEstados();
            this.btnValidar.Enabled = this.txtToken.Enabled = this.btnReenviar.Enabled = false;
            this.btnValidar.Text = "Validado.";
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

            daoPassword.recuperarPasswrd(_correo, this.txtToken.Text, this.txtPassword.Text);

            // Conseguir el usuario para iniciar sesion
            ServicioUsuario.UsuarioWSClient daoUsuario = new ServicioUsuario.UsuarioWSClient();
            _usuario = daoUsuario.buscarPorCorreo(_correo);
            if (_usuario == null || _usuario.id == 0)
            {
                // Si no,
                frm = new frmMessageBox("No se ha aplicado ningún cambio.", MessageBoxButtons.OK);
                frm.ShowDialog();
            }
            this.DialogResult = DialogResult.OK;
        }
        private void btnAceptar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            btnAceptar_Click(sender, e);
        }

        private void btnReenviar_Click(object sender, EventArgs e)
        {
            // Enviar token
            ServicioPassword.PasswordWSClient daoPassword = new ServicioPassword.PasswordWSClient();
            int idUsu;
            frmMessageBox frm;
            if (0 == (idUsu = daoPassword.sendMail(this._correo)))
            {
                frm = new frmMessageBox("Usuario no encontrado. No se pudo reenviar el correo a " + _correo, MessageBoxButtons.OK);
                frm.ShowDialog();
                return;
            }
            // Si no, se envio el correo
            frm = new frmMessageBox("Se ha reenviado el correo a " + _correo, MessageBoxButtons.OK);
            frm.ShowDialog();
        }

        private void txtToken_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            btnValidar_Click(sender, e);
        }
    }
}
