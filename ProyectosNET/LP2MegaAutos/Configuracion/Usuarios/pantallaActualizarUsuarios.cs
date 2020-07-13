using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2MegaAutos.VentanasPrincipales;
using LP2MegaAutos.Framework;
using LP2MegaAutos.ServicioUsuario;
using System.Threading;

namespace LP2MegaAutos
{
    public partial class pantallaActualizarUsuarios : Pantalla
    {
        private ServicioUsuario.UsuarioWSClient daoUsuario;
        private List<usuario> _usuarios;
        private string textoBuscar; //AGREGADO PARA BUSCAR
        bool viendoActivo = true;

        public pantallaActualizarUsuarios()
        {
            InitializeComponent();
            textoBuscar = " usuario por nombre o correo"; //AGREGADO PARA BUSCAR
            flpUsuarios.AutoScroll = true;
            daoUsuario =
                new ServicioUsuario.UsuarioWSClient();
            txt_Buscar.Text += textoBuscar;
        }

        #region lista
        public void inicializarItemsLista()
        {
            quitarItemsLista();
            if (viendoActivo)
                _usuarios = daoUsuario.listarUsuarios().ToList();
            else
                _usuarios = daoUsuario.listarUsuariosInactivos().ToList();
            btnAZ_Click(btnAZ,new EventArgs());
        }

        private itemLista createItemListaUsuario(ServicioUsuario.usuario usuario)
        {
            itemLista il = new itemLista();
            BotonesDinamicosHelper.personalizarItemLista(il);
            il.Name = "il" + usuario.id;
            il.TextoPrincipal = usuario.nombre;
            il.Textosecundario = usuario.tipoUsuario;
            il.TextoTercero = usuario.correo;
            il.ItemListaClick += (sender, e) => { verDatosUsuario(sender, e, usuario); };
            flpUsuarios.Controls.Add(il);
            return il;
        }

        #region Organizar
        private void crearItemsLista()
        {
            if (_usuarios == null) return;
            foreach (usuario u in _usuarios)
            {
                createItemListaUsuario(u);
            }
        }

        private void quitarItemsLista()
        {
            for (int i = 0; i < flpUsuarios.Controls.Count;)
                flpUsuarios.Controls.RemoveAt(i);
        }

        private void organizarAZ()
        {
            _usuarios = _usuarios.OrderBy(g => g.nombre).ToList();
            quitarItemsLista();
            crearItemsLista();
        }

        private void organizarZA()
        {
            _usuarios = _usuarios.OrderByDescending(g => g.nombre).ToList();
            quitarItemsLista();
            crearItemsLista();
        } 
        
        private void organizarAntiguo()
        {
            _usuarios = _usuarios.OrderBy(g => g.fechaCreado).ToList();
            quitarItemsLista();
            crearItemsLista();
        }
        
        private void organizarReciente()
        {
            _usuarios = _usuarios.OrderByDescending(g => g.fechaCreado).ToList();
            quitarItemsLista();
            crearItemsLista();
        }
        #endregion Organizar

        private void verDatosUsuario(object sender, EventArgs e, ServicioUsuario.usuario usu)
        {
            pantallaEditarUsuario pas = new pantallaEditarUsuario(usu);
            DialogResult d = pas.ShowDialog();
            if (d == DialogResult.OK)
            {
                // Actualizar el Usuario
                usuario u = pas.Usuario;
                frmMessageBox frm = new frmMessageBox("Se actualizo correctamente el usuario", MessageBoxButtons.OK, "Mensaje", false);

                if (pas.CambiarPass)
                { // Si se esta cambiando la contraseña, llamar a actualizar password
                    if (daoUsuario.actualizarUsuarioPassword(u) == 0)
                    {
                        frm = new frmMessageBox("No se pudo actualizar el usuario", MessageBoxButtons.OK, "Error", true); ;
                    }
                }
                else if (daoUsuario.actualizarUsuario(u) == 0) // Si no, solo actualizar usuario
                    frm = new frmMessageBox("No se pudo actualizar el usuario", MessageBoxButtons.OK, "Error", true);

                frm.ShowDialog();
                flpUsuarios.Controls.RemoveByKey("il" + usu.id);
                createItemListaUsuario(u);
                _usuarios.Remove(usu);
                _usuarios.Add(u);
                btnAZ_Click(btnAZ, new EventArgs());
                // todo actualizar FechaUltimaModificacion en BD
            }
            else if(d == DialogResult.Retry)
            {
                frmMessageBox frm = new frmMessageBox("Hubo un error.", MessageBoxButtons.OK, "Mensaje", false);
                if (pas.Activando)
                {
                    // Activar
                    // if(daoUsuario.activarUsuario(usu.id) != 0)
                    frm = new frmMessageBox("Se activo correctamente el usuario. Ahora puede verlo en usuarios activos.",
                            MessageBoxButtons.OK, "Usuario Activado");
                }
                else // Eliminar
                    if(daoUsuario.eliminarUsuario(usu.id) != 0)
                        frm = new frmMessageBox("Se desactivo correctamente el usuario. Puede activarlo al ver usuarios inactivos.",
                            MessageBoxButtons.OK,"Usuario Desactivado");
                
                frm.ShowDialog();
                flpUsuarios.Controls.RemoveByKey("il" + usu.id);
                _usuarios.Remove(usu);
                // TODO seleccionar organizar segun el boton seleccionado
                btnAZ_Click(btnAZ, e);
            }
        }
        #endregion lista

        #region Botones Filtros
        private void btnAZ_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndAZ, rndZA, rndAntiguo, rndReciente);
            organizarAZ();
        }
        private void btnZA_Click(object sender, EventArgs e)
        {

            pantallaListasHelper.cambiarCuatroPaneles(
                rndZA, rndAZ, rndAntiguo, rndReciente);
            organizarZA();
        }

        private void btnAntiguo_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndAntiguo, rndZA, rndAZ, rndReciente);
            organizarAntiguo();
        }

        private void btnReciente_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndReciente, rndAntiguo, rndZA, rndAZ);
            organizarReciente();
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            pantallaListasHelper.btn_MouseDown((Button)sender);
        }

        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            pantallaListasHelper.btn_MouseUp((Button)sender);
        }

        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            pantallaListasHelper.btn_MouseMove((Button)sender);
        }
       

        #endregion Botones Filtros
    
        #region Buscar
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            pantallaEditarUsuario pas = new pantallaEditarUsuario();

            if (pas.ShowDialog() == DialogResult.OK)
            {
                // Agregar usuario
                usuario _usuario= pas.Usuario;
                frmMessageBox frm;
                if (daoUsuario.insertarUsuario(_usuario) == 0)
                { // Ta mal
                    frm = new frmMessageBox("No se pudo insertar.",MessageBoxButtons.OK);
                    frm.ShowDialog();
                    return;
                }
                else // Inserto bien
                    frm = new frmMessageBox("Se inserto correctamente el usuario " + _usuario.nombre,MessageBoxButtons.OK);
                _usuarios.Add(_usuario);
                frm.ShowDialog();
                btnAZ_Click(btnAZ, new EventArgs());
            }
        }

        private void crearItemsListaBuscar(List<usuario> _usuariosB)
        {
            if (_usuariosB == null) return;
            foreach (usuario u in _usuariosB)
            {
                createItemListaUsuario(u);
            }
        }

        private void txt_Buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            // Tenemos la lista usuarios
            List<usuario> _usuariosBuscados = new List<usuario>();
            foreach (usuario u in _usuarios)
                if (u.nombre.Contains(txt_Buscar.Text.ToUpper()) ||
                    u.tipoUsuario.Contains(txt_Buscar.Text.ToUpper()) ||
                    u.correo.Contains(txt_Buscar.Text.ToUpper()))
                    _usuariosBuscados.Add(u);

            quitarItemsLista();
            crearItemsListaBuscar(_usuariosBuscados);
        }

        #region Txt Buscar
        private void txt_Buscar_Enter(object sender, EventArgs e)
        {
            pantallaListasHelper.buscarEnter(txt_Buscar, textoBuscar); //AGREGADO PARA BUSCAR
        }

        private void txt_Buscar_Leave(object sender, EventArgs e)
        {
            pantallaListasHelper.buscarLeave(txt_Buscar, textoBuscar);//AGREGADO PARA BUSCAR
        }
        #endregion Txt Buscar


        #endregion Buscar

        private void btnVerInactivos_Click(object sender, EventArgs e)
        {
            this.viendoActivo = !this.viendoActivo;
            btnVerInactivos.Text = this.viendoActivo ? "Ver Inactivos": "Ver Activos";
            lbl_ListaServicios.Text = this.viendoActivo ? "Usuarios Activos": "Usuarios Inactivos";
            inicializarItemsLista();
        }
    }
}
