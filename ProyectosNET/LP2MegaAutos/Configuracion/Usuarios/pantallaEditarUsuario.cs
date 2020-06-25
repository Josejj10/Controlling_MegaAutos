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
using LP2MegaAutos.ServicioUsuario;
using LP2MegaAutos.VentanasPrincipales;

namespace LP2MegaAutos
{
    public partial class pantallaEditarUsuario : MetroForm
    {
        private usuario _usuario;
        public pantallaEditarUsuario()
        {
            InitializeComponent();
        }
        public pantallaEditarUsuario(usuario usuario)
        {
            InitializeComponent();
            txtNombre.Text = usuario.nombre;    
            txt_Correo.Text = usuario.correo;
            txt_RolUsuario.Text = usuario.tipoUsuario;
            txt_ContraseñaActual.Text = txt_NuevaCont.Text = txt_RepNCont.Text = "";
            _usuario = usuario;
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
        #region Ver Password
        private bool password_seen = false;
        private void boton_ver_password_Click(object sender, EventArgs e)
        {
                // Cambiar variable 
                password_seen = !password_seen;
                if (password_seen)
                {
                    txt_NuevaCont.PasswordChar = '\0';
                    boton_ver_password.BackgroundImage = global::LP2MegaAutos.Properties.Resources.boton_unsee_password;
                }
                else
                {
                    txt_NuevaCont.PasswordChar = '•';
                    boton_ver_password.BackgroundImage = global::LP2MegaAutos.Properties.Resources.boton_see_password;
                }
        }
        #endregion Ver Password

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public usuario Usuario { get {return _usuario; } }

        private bool usuarioValido()
        {
            // Sacapalabras al txt
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un nombre", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(txt_RolUsuario.Text))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese el rol.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (txt_NuevaCont.Text != txt_RepNCont.Text)
            {
                frmMessageBox f = new frmMessageBox("Por favor repita correctamente la nueva contraseña.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(txt_ContraseñaActual.Text))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese su contraseña para guardar los cambios.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }


            return true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!usuarioValido())
                return;
            // Validar
            frmMessageBox f = new frmMessageBox("¿Guardar Cambios?", MessageBoxButtons.OKCancel,"Guardar Cambios");
            if (f.ShowDialog() != DialogResult.OK)
                return;
            // Actualizar usuario
            _usuario.nombre = txtNombre.Text;
            _usuario.correo = txt_Correo.Text;
            _usuario.tipoUsuario = txt_RolUsuario.Text;
            // TODO 
            _usuario.password = txt_NuevaCont.Text;
            //_usuario.nombre = txt_NombreUsuario.Text
            this.DialogResult = DialogResult.OK;
        }

        private void btnAgregarPermisosClick(object sender, EventArgs e)
        {
            if (_usuario == null) return;
            pantallaAgregarPermisos pes = new pantallaAgregarPermisos(_usuario);
            if (pes.ShowDialog() != DialogResult.OK)
                return;

            // Si devolvio OK, actualizar los permisos del Usuario
            //daoUsuario.actualizarUsuario(pes.Usuario);
            // Aun no estoy seguro si ver Datos
        }

        private void crearItemsListaPermisos()
        {

        }

        private void crearitemListaPermiso()
        {

        }

        private void clickItemListaPermiso()
        {

        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            txtNombre.Text = _usuario.nombre;
            txt_Correo.Text = _usuario.correo;
            txt_RolUsuario.Text = _usuario.tipoUsuario;
            txt_NuevaCont.Text = txt_ContraseñaActual.Text = txt_RepNCont.Text = "";
        }

        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            txt_NuevaCont.Enabled = txt_RepNCont.Enabled = !txt_RepNCont.Enabled;
        }

        private void txt_ContraseñaActual_Enter(object sender, EventArgs e)
        {
            txt_ContraseñaActual.Text = "";
        }
    }
}
