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
using LP2MegaAutos.Framework.UserControls.Items;

namespace LP2MegaAutos
{
    public partial class pantallaEditarUsuario : MetroForm
    {
        private usuario _usuario;
        private List<ePermisos?> _permisosIniciales = new List<ePermisos?>();
        private bool _agregando = true;
        private bool _activando = false;

        public pantallaEditarUsuario()
        {
            InitializeComponent();
            txtNombre.Text = "Agregar nombre de usuario...";
            _usuario = new usuario();
            _agregando = true;
            btnCambiarPassword.Visible =
            rpCambiarPassword.Visible =
            btnEditar.Visible =
            btnEliminar.Visible = false;
            _usuario.permisos = _permisosIniciales.ToArray();
            txtNombre.ForeColor = Colores.LowContrast;
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
        }
        public pantallaEditarUsuario(usuario usuario, bool viendoPropio = false)
        {
            if (usuario == null) this.DialogResult = DialogResult.Cancel;
            InitializeComponent();
            _usuario = usuario;
            txtNombre.Text = OtrosHelper.tipoOracion(usuario.nombre);    
            txt_Correo.Text = usuario.correo.ToLower();
            txt_RolUsuario.Text = OtrosHelper.tipoOracion(usuario.tipoUsuario);
            txt_NuevaCont.Text = txt_RepNCont.Text = "";
            _agregando = false;
            if (_usuario.permisos == null) _usuario.permisos = _permisosIniciales.ToArray();
            _permisosIniciales = _usuario.permisos.ToList();
            toggleComponentes();
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
            crearItemsListaPermisos();
            if (viendoPropio)
            {
                this.btnAgregarPermisos.Visible = false;
            }

            // if (usuario.activo != 0) return;

            // Si el usuario es inactivo
            //lbl_NuevaCont.Visible = rnd_color_3.Visible =
            //txt_NuevaCont.Visible = boton_ver_password.Visible =
            //lbl_RepNCont.Visible = rnd_color_4.Visible =
            //txt_RepNCont.Visible = btnVerRepetir.Visible =
            //btnAgregarPermisos.Visible =
            //rnd_Reestablecer.Visible =
            //rpCambiarPassword.Visible =
            //btnEditar.Visible = btnEliminar.Visible =
            //false;
            //_activando = true;
            //btn_guardar.Text = "Activar";
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
            borrarItemsLista();
            // Si no tiene permisos, no se crea nada
            if (_usuario.permisos == null || _usuario.permisos.Length==0) return;

            if (_usuario.permisos.Contains(ePermisos.All))
            {
                foreach (ePermisos e in Enum.GetValues(typeof(ePermisos)))
                {
                    if (e == ePermisos.All) continue;
                    itemListaCuadrado il = crearitemListaPermiso(e.ToString(), e);
                    BotonesDinamicosHelper.agregarImgFondo(e, il);
                    flpPermisos.Controls.Add(il);
                }
                return;
            }
            // Si no, no tiene todos
            foreach(ePermisos? e in _usuario.permisos) { 
                if (e == ePermisos.All) continue;
                itemListaCuadrado il = crearitemListaPermiso(e.ToString(), e);
                BotonesDinamicosHelper.agregarImgFondo(e,il);
                flpPermisos.Controls.Add(il);
            }
        }


        private int i = 1;
        private itemListaCuadrado crearitemListaPermiso(string nom, ePermisos? per)
        {
            itemListaCuadrado il = new itemListaCuadrado();
            il.Name = "ilc" + i++;
            il.TextoPrincipal = nom;
            il.ItemListaClick += (sender,e) => clickItemListaPermiso(sender,e,per);
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(il);
            return il;
        }

        private void clickItemListaPermiso(object sender, EventArgs e, ePermisos? per)
        {
            string titulo, descripcion;
            Image img = itemListaHelper.imagenPermisos(per);
            string [] str = itemListaHelper.recibirDescripcionPermisos(per).Split('|');
            titulo = str[0];
            descripcion = str[1];

            frmMessageBox f = new frmMessageBox(descripcion, MessageBoxButtons.OK, 
                titulo, false);
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

            if (_agregando) //Si se agrega
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

        public bool Activando { get { return _activando; } }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // Preguntar si desea realizar la accion
            frmEliminar f;

            // si el usuario es inactivo
            if (_activando)
            {
                f = new frmEliminar("activar el usuario " + txtNombre.Text, "Activar Usuario");
                if (f.ShowDialog() != DialogResult.OK) ;
                this.DialogResult = DialogResult.Retry;
                return;
            }

            if (!usuarioValido())
                return;
            
            if (_agregando)
                f = new frmEliminar("agregar el usuario " + txtNombre.Text, "Agregar Usuario");
            else
                f = new frmEliminar("modificar el usuario " + txtNombre.Text, "Modificar Usuario");
            
            if (f.ShowDialog() != DialogResult.OK)
                return;

            ServicioUsuario.UsuarioWSClient daoUsuario = new UsuarioWSClient();
            
            if (daoUsuario.verificarPassword(frmPrincipal.Usuario.correo, f.Password) == null)
            {
                frmMessageBox frm = new frmMessageBox("La contraseña es invalida", MessageBoxButtons.OK);
                frm.ShowDialog();
                return;
            }

            // Actualizar usuario
            _usuario.nombre = txtNombre.Text.ToUpper();
            _usuario.correo = txt_Correo.Text;
            _usuario.tipoUsuario = txt_RolUsuario.Text.ToUpper();

            // Actualizar contraseña si cambiarcontraseña esta activo
            if (btnCambiarPassword.Enabled || _agregando)
                _usuario.password = txt_RepNCont.Text;
            
            this.DialogResult = DialogResult.OK;
        }

        public bool CambiarPass { get { return btnCambiarPassword.Enabled; } }

        private void btnAgregarPermisosClick(object sender, EventArgs e)
        {
            if (_usuario == null) return;
            pantallaAgregarPermisos pes = new pantallaAgregarPermisos(_usuario);
            if (pes.ShowDialog() != DialogResult.OK)
                return;

            bool a = true;
            foreach (ePermisos per in pes.Usuario.permisos)
            {
                a &= _permisosIniciales.Contains(per);
            }

            if (a)
            {
                btn_guardar.Enabled = false;
                rnd_guardar.ColorBorde = rnd_guardar.ColorPanel
                    = Colores.Disabled;
            }
            else
            {
                btn_guardar.Enabled = true;
                rnd_guardar.ColorBorde = rnd_guardar.ColorPanel 
                    = Colores.AmarilloInteractivo;
            }

            // Si devolvio OK, cargar de nuevo la pantalla de permisos del usuario
            // y actualizar los permisos del usuario
            _usuario.permisos = pes.Usuario.permisos;
            crearItemsListaPermisos();
        }
      
        private void borrarItemsLista()
        {
            for (int i = 0; i < flpPermisos.Controls.Count;)
                flpPermisos.Controls.RemoveAt(i);
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            txtNombre.Text = OtrosHelper.tipoOracion(_usuario.nombre);
            txt_Correo.Text = OtrosHelper.tipoOracion(_usuario.correo);
            txt_RolUsuario.Text = OtrosHelper.tipoOracion(_usuario.tipoUsuario);
            txt_NuevaCont.Text = txt_RepNCont.Text = "";
            _usuario.permisos = _permisosIniciales.ToArray();
            crearItemsListaPermisos();
            btn_guardar.Enabled = false;
            rnd_guardar.ColorBorde = rnd_guardar.ColorPanel
            = Colores.Disabled;
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
                txt_RolUsuario.Enabled = btnCambiarPassword.Enabled =
                !txtNombre.Enabled;

            bool a = true;
            foreach(ePermisos e in _usuario.permisos)
            {
                a &= _permisosIniciales.Contains(e);
            }
            
            // Si son los mismos permisos que al inicio, se desactiva 
            if (a)
            {
                btn_guardar.Enabled = false;
                rnd_guardar.ColorPanel = rnd_guardar.ColorBorde = Colores.Disabled;
            }
            else {
                rnd_guardar.ColorPanel = rnd_guardar.ColorBorde = Colores.Rosa;
                btn_guardar.Enabled = true;
            }

                if (!en)
            {
                // No habilitado
                txtNombre.ForeColor = txt_Correo.ForeColor =
                    txt_NuevaCont.ForeColor = txt_RolUsuario.ForeColor =
                    txt_RepNCont.ForeColor =
                    rnd_color_1.ColorPanel = rnd_color_2.ColorPanel =
                    rnd_color_3.ColorPanel = rnd_color_4.ColorPanel =
                    rpCambiarPassword.ColorPanel =
                    rnd_color_1.ColorBorde = rnd_color_2.ColorBorde =
                    rnd_color_3.ColorBorde = rnd_color_4.ColorBorde =
                    rpCambiarPassword.ColorBorde
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
            
            rpCambiarPassword.ColorPanel = rpCambiarPassword.ColorBorde
            = Colores.AmarilloInteractivo;

            btnEditar.BackgroundImage = Resources.Cancelar;

            rnd_guardar.ColorPanel = rnd_guardar.ColorBorde = Colores.Rosa;
            btn_guardar.Enabled = true;

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

        private bool newPassword_seen;
        private void boton_ver_password_Click_1(object sender, EventArgs e)
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
        private void btnVerRepetir_Click(object sender, EventArgs e)
        {
            // Cambiar variable 
            newPassword_seen = !newPassword_seen;
            if (newPassword_seen)
            {
                txt_RepNCont.PasswordChar = '\0';
                btnVerRepetir.BackgroundImage = global::LP2MegaAutos.Properties.Resources.boton_unsee_password;
            }
            else
            {
                txt_RepNCont.PasswordChar = '•';
                btnVerRepetir.BackgroundImage = global::LP2MegaAutos.Properties.Resources.boton_see_password;
            }
        }
    }
}
