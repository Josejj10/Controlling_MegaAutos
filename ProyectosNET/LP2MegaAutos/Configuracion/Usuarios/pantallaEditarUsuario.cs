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
using LP2MegaAutos.Framework;
using LP2MegaAutos.Properties;

namespace LP2MegaAutos
{
    public partial class pantallaEditarUsuario : MetroForm
    {
        private usuario _usuario;
        private bool agregando = true;
        public pantallaEditarUsuario()
        {
            InitializeComponent();
            txtNombre.Text = "Agregar nombre de usuario...";
            _usuario = new usuario();
            agregando = true;
            btnCambiarPassword.Visible =
            rpCambiarPassword.Visible =
            btnEditar.Visible =
            btnEliminar.Visible = false;
        }
        public pantallaEditarUsuario(usuario usuario)
        {
            if (usuario == null) this.DialogResult = DialogResult.Cancel;
            InitializeComponent();
            toggleComponentes();
            txtNombre.Text = OtrosHelper.tipoOracion(usuario.nombre);    
            txt_Correo.Text = usuario.correo.ToLower();
            txt_RolUsuario.Text = OtrosHelper.tipoOracion(usuario.tipoUsuario);
            txt_NuevaCont.Text = txt_RepNCont.Text = "";
            _usuario = usuario;
            crearItemsListaPermisos();
            agregando = false;
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
        #region listaPermisos
        private void crearItemsListaPermisos()
        {
            foreach(ePermisos e in Enum.GetValues(typeof(ePermisos))){
                if (e == ePermisos.All) return;
                itemListaCuadrado il = crearitemListaPermiso(e.ToString());
                BotonesDinamicosHelper.agregarImgFondo(e,il);
                flpPermisos.Controls.Add(il);
            }
        }


        private int i = 1;
        private itemListaCuadrado crearitemListaPermiso(string nom)
        {
            itemListaCuadrado il = new itemListaCuadrado();
            il.Name = "ilc" + i++;
            il.TextoPrincipal = nom;
            il.ItemListaClick += (sender,e) => clickItemListaPermiso(sender,e);
            return il;
        }

        private void clickItemListaPermiso(object sender, EventArgs e)
        {
            frmMessageBox f = new frmMessageBox("Por crear", MessageBoxButtons.OK, 
                ((itemListaCuadrado)sender).TextoPrincipal, true);
            f.ShowDialog();
        }
        #endregion listaPermisos


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public usuario Usuario { get {return _usuario; } }

        private bool usuarioValido()
        {
            // Sacapalabras al txt
            if (string.IsNullOrEmpty(txtNombre.Text) || 
                txtNombre.Text == "Agregar nombre de usuario...")
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un nombre para el usuario.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(txt_Correo.Text) ||
                !txt_Correo.Text.Contains("@"))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un correo valido.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(txt_RolUsuario.Text))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese el rol.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (agregando) //Si se agrega
            {
                if(txt_NuevaCont.Text != txt_RepNCont.Text || string.IsNullOrEmpty(txt_NuevaCont.Text))
                {
                    frmMessageBox f = new frmMessageBox("Por favor ingrese y repita correctamente la nueva contraseña.", MessageBoxButtons.OK);
                    f.ShowDialog();
                    return false;
                }

            }
            else
            if (txt_NuevaCont.Enabled && ( txt_NuevaCont.Text != txt_RepNCont.Text || string.IsNullOrEmpty(txt_NuevaCont.Text)))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese y repita correctamente la nueva contraseña.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            return true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!usuarioValido())
                return;
            // Preguntar si desea realizar la accion
            frmEliminar f;

            if (agregando)
                f = new frmEliminar("agregar el usuario " + txtNombre.Text, "Agregar Usuario");
            else
                f = new frmEliminar("modificar el usuario " + txtNombre.Text, "Modificar Usuario");
            
            if (f.ShowDialog() != DialogResult.OK)
                return;

            // Validar contraseña actual
            //ServicioUsuario.UsuarioWS daoUsuario;
            // if (!daoUsuario.validarUsuario(_usuario.id, txt_ContraseñaActual.Text)){ 
            //     frmMessageBox frm = new frmMessageBox("La contraseña es invalida",MessageBoxButtons.OK);
            //     frmMessaBox.Show();
            //     return;
            //}

            // Actualizar usuario
            _usuario.nombre = txtNombre.Text.ToUpper();
            _usuario.correo = txt_Correo.Text.ToUpper();
            _usuario.tipoUsuario = txt_RolUsuario.Text.ToUpper();

            // Actualizar contraseña si cambiarcontraseña esta activo
            if (btnCambiarPassword.Enabled)
                _usuario.password = txt_RepNCont.Text;
            
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
      
        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            txtNombre.Text = _usuario.nombre;
            txt_Correo.Text = _usuario.correo;
            txt_RolUsuario.Text = _usuario.tipoUsuario;
            txt_NuevaCont.Text = txt_RepNCont.Text = "";
        }

        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            bool en = txt_NuevaCont.Enabled = txt_RepNCont.Enabled = !txt_RepNCont.Enabled;
            // cambiar colores de password
            if (en)
            {
                txt_NuevaCont.ForeColor = txt_RepNCont.ForeColor =
                Colores.HighContrast;
                rnd_color_3.ColorBorde = rnd_color_3.ColorPanel =
                rnd_color_4.ColorBorde = rnd_color_4.ColorPanel =
                Colores.Rosa;

                rnd_color_3.ColorPanel = rnd_color_4.ColorPanel =
                rnd_color_3.ColorBorde = rnd_color_4.ColorBorde =
                Colores.Rosa;

            }
            else
            {
                rnd_color_3.ColorBorde = rnd_color_3.ColorPanel =
                rnd_color_4.ColorBorde = rnd_color_4.ColorPanel =
                txt_NuevaCont.ForeColor = txt_RepNCont.ForeColor =
                Colores.Disabled;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            toggleComponentes();
        }

        private void toggleComponentes()
        {
            bool en = txtNombre.Enabled = txt_Correo.Enabled =
                txt_RolUsuario.Enabled = btn_guardar.Enabled =
                //txt_NuevaCont.Enabled = txt_RepNCont.Enabled =
                btnCambiarPassword.Enabled = btnReestablecer.Enabled =
                //flpPermisos.Enabled =
                !txtNombre.Enabled;

            if (!en)
            {
                // No habilitado
                txt_NuevaCont.Enabled = txt_RepNCont.Enabled = false;
                txtNombre.BackColor = Colores.FrontBackground;

                txtNombre.ForeColor = txt_Correo.ForeColor =
                    txt_NuevaCont.ForeColor = txt_RolUsuario.ForeColor =
                    txt_RepNCont.ForeColor =
                    rnd_color_1.ColorPanel = rnd_color_2.ColorPanel =
                    rnd_color_3.ColorPanel = rnd_color_4.ColorPanel =
                    rnd_guardar.ColorPanel = rpCambiarPassword.ColorPanel =
                    rnd_color_1.ColorBorde = rnd_color_2.ColorBorde =
                    rnd_color_3.ColorBorde = rnd_color_4.ColorBorde =
                    rnd_guardar.ColorBorde = rpCambiarPassword.ColorBorde =
                    rnd_Reestablecer.ColorBorde = rnd_Reestablecer.ColorPanel
                    = Colores.Disabled;

                btnEditar.BackgroundImage = Resources.editar;
                return;
            }
            // Habilitado
            txtNombre.ForeColor = txt_Correo.ForeColor =
            txt_NuevaCont.ForeColor = txt_RolUsuario.ForeColor =
            txt_RepNCont.ForeColor = Colores.HighContrast;
        
            rnd_color_1.ColorPanel = rnd_color_2.ColorPanel =
            //rnd_color_3.ColorPanel = rnd_color_4.ColorPanel =
            rnd_color_1.ColorBorde = rnd_color_2.ColorBorde =
            //rnd_color_3.ColorBorde = rnd_color_4.ColorBorde =
            Colores.Rosa;
            
            rnd_guardar.ColorPanel = rnd_guardar.ColorBorde =
            rpCambiarPassword.ColorPanel = rpCambiarPassword.ColorBorde =
            rnd_Reestablecer.ColorBorde = rnd_Reestablecer.ColorPanel
            = Colores.AmarilloInteractivo;

            btnEditar.BackgroundImage = Resources.Logout;
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar frm = new frmEliminar("eliminar el usuario " + _usuario.nombre);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.Retry;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Agregar nombre de usuario...")
                txtNombre.Text = string.Empty;
            txtNombre.ForeColor = Colores.HighContrast;
        }

        private void txt_Nombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.ForeColor = Colores.LowContrast;
                txtNombre.Text = "Agregar nombre de usuario...";
            }
        }


    }
}
