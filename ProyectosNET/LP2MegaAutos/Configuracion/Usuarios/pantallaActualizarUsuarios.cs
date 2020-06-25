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

namespace LP2MegaAutos
{
    public partial class pantallaActualizarUsuarios : Pantalla
    {
        private ServicioUsuario.UsuarioWSClient daoUsuario;
        private List<usuario> _usuarios;
        private string textoBuscar; //AGREGADO PARA BUSCAR

        public pantallaActualizarUsuarios()
        {
            InitializeComponent();
            textoBuscar = " usuario por nombre o correo"; //AGREGADO PARA BUSCAR
            flpUsuarios.AutoScroll = true;
            daoUsuario =
                new ServicioUsuario.UsuarioWSClient();
            inicializarItemsLista();
            txt_Buscar.Text += textoBuscar;
        }

        #region lista
        private void inicializarItemsLista()
        {
            _usuarios = daoUsuario.listarUsuarios().ToList();
            btnAZ_Click(btnAZ,new EventArgs());
        }

        private itemLista createItemListaUsuario(ServicioUsuario.usuario usuario, string agregadoPor, DateTime fechaAgregado)
        {
            itemLista il = new itemLista();
            il.Anchor = AnchorStyles.Top;
            il.BackColor = Color.Transparent;
            il.ColorBack = Color.Transparent;
            il.ColorBorde = Colores.PrincipalAzulMetalico;
            il.ColorPanel = Colores.BackBackground;
            il.Margin = new Padding(4);
            il.Name = "il" + usuario.id;
            il.Size = new Size(497, 104);
            il.TextoAgregadoPor = agregadoPor;
            il.TextoFecha = fechaAgregado.ToString("dd/MM/yyyy");
            il.TextoPrincipal = usuario.nombre;
            il.Textosecundario = usuario.tipoUsuario;
            il.TextoTercero = usuario.correo;
            il.ItemListaClick += (sender, e) => { verDatosUsuario(sender, e, usuario); };
            il.esconderBotonEditar();
            flpUsuarios.Controls.Add(il);
            return il;
        }

        #region Organizar
        private void crearItemsLista()
        {
            if (_usuarios == null) return;
            foreach (usuario u in _usuarios)
            {
                createItemListaUsuario(u, "Carter Kane", DateTime.Now);
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
            if (d== DialogResult.OK)
            {
                // Actualizar el Usuario
                usuario u = pas.Usuario;
                daoUsuario.actualizarUsuario(u);
                flpUsuarios.Controls.RemoveByKey("il" + usu.id);
                createItemListaUsuario(u, "Carter Kane", DateTime.Now);
                _usuarios.Remove(usu);
                _usuarios.Add(u);
                btnAZ_Click(btnAZ, new EventArgs());
                // todo actualizar FechaUltimaModificacion en BD
            }
            else if(d == DialogResult.Retry)
            {
                // Eliminar
                daoUsuario.eliminarUsuario(usu.id);
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
        #endregion Botones Filtros

        #region Txt Buscar
        private void txt_Buscar_Enter(object sender, EventArgs e)
        {
            pantallaListasHelper.buscarEnter(txt_Buscar,textoBuscar); //AGREGADO PARA BUSCAR
        }

        private void txt_Buscar_Leave(object sender, EventArgs e)
        {
            pantallaListasHelper.buscarLeave(txt_Buscar, textoBuscar);//AGREGADO PARA BUSCAR
        }
        #endregion Txt Buscar

        #region Buscar //AGREGADO PARA BUSCAR
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            pantallaEditarUsuario pas = new pantallaEditarUsuario();

            if (pas.ShowDialog() == DialogResult.OK)
            {
                // Agregar usuario
                usuario _usuario= pas.Usuario;
                _usuarios.Add(_usuario);
                frmMessageBox frm;
                if (daoUsuario.insertarUsuario(_usuario) == 0) // Ta mal
                    frm = new frmMessageBox("No se pudo insertar.");
                else // Inserto bien
                    frm = new frmMessageBox("Se inserto correctamente el usuario " + _usuario.nombre);
                frm.ShowDialog();
            }
        }

        private void crearItemsListaBuscar(List<usuario> _usuariosB)
        {
            if (_usuariosB == null) return;
            foreach (usuario u in _usuariosB)
            {
                createItemListaUsuario(u, "Carter Kane", DateTime.Now);
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
        #endregion Buscar
    }
}
