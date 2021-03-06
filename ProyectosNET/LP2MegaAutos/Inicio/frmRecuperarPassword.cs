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
    public partial class frmRecuperarPassword : MetroForm
    {
        usuario _usuario;
        
        
        public frmRecuperarPassword()
        {
            InitializeComponent();
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!validarCampos()) return;
            // Enviar token
            ServicioPassword.PasswordWSClient daoPassword = new ServicioPassword.PasswordWSClient();
            int idUsu;
            if (0 == (idUsu = daoPassword.sendMail(this.txtCorreo.Text)))
                return;
            // Si no, si se envio el correo al usuario
            frmRecuperacionPassword frm = new frmRecuperacionPassword(this.txtCorreo.Text);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                _usuario = frm.Usuario;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                frmMessageBox frmMsg = new frmMessageBox(
                    "Fallo la autenticacion del token. No se realizaron modificaciones en la contraseña." +
                    "", MessageBoxButtons.OK, "No se recupero la contraseña", true);
                frmMsg.ShowDialog();
            }
        }

        private bool validarCampos()
        {
            frmMessageBox frm;
            if (String.IsNullOrEmpty(this.txtCorreo.Text))
            {
                frm = new frmMessageBox("Por favor ingrese correo electronico.", MessageBoxButtons.OK);
                frm.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(txtCorreo.Text) ||
                !txtCorreo.Text.Contains("@"))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un correo valido.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(txtCorreo.Text) ||
                !txtCorreo.Text.Contains("."))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un correo valido.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            return true;
        }

        private void txtCorreo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            btn_guardar_Click(sender, e);
        }

    }
}
