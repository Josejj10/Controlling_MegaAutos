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
        ServicioUsuario.UsuarioWSClient daoUsuario;

        public pantallaActualizarUsuarios()
        {
            InitializeComponent();
            btn_Agregar.Click += btnAgregarClick;
            flpUsuarios.AutoScroll = true;
            daoUsuario =
                new ServicioUsuario.UsuarioWSClient();
            inicializarItemsLista();
        }

        private void inicializarItemsLista()
        {
            List<usuario> usuarios = daoUsuario.listarUsuarios().ToList();
            if (usuarios == null) return;
            foreach (usuario u in usuarios)
            {
                createItemListaUsuario(u, "Carter Kane", DateTime.Now);
            }

        }

        private itemLista createItemListaUsuario(ServicioUsuario.usuario usuario, string agregadoPor, DateTime fechaAgregado)
        {
            itemLista il = new itemLista();
            il.Anchor = AnchorStyles.Top;
            il.BackColor = Color.Transparent;
            il.ColorBack = Color.Transparent;
            il.ColorBorde = Colores.PrincipalAzulMetalico;
            il.ColorPanel = Colores.BackBackground;
            //il.Location = new Point(35, 4);
            il.Margin = new Padding(4);
            il.Name = "il" + usuario.id;
            il.Size = new Size(497, 104);
            il.TextoAgregadoPor = agregadoPor;
            il.TextoFecha = fechaAgregado.ToString("dd/MM/yyyy");
            il.TextoPrincipal = usuario.nombre;
            il.Textosecundario = usuario.tipoUsuario;
            il.TextoTercero = usuario.correo;
            il.ItemListaClick += (sender, e) => { verDatosUsuario(sender, e, usuario); };
            il.EditarClick += (sender, e) => { btnEditarClick(sender, e, usuario); };
            flpUsuarios.Controls.Add(il);
            return il;
        }



        private void verDatosUsuario(object sender, EventArgs e, ServicioUsuario.usuario usuario)
        {
            pantallaEditarUsuario pes = new pantallaEditarUsuario(usuario);
            if (pes.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
        }

        private void btnEditarClick(object sender, EventArgs e, usuario usuario)
        {
            pantallaEditarInformacionPropia pas = new pantallaEditarInformacionPropia();
            if (pas.ShowDialog() == DialogResult.OK)
            {
                // Hacer algo
            }
        }

        private void btnAgregarClick(Object sender, EventArgs e)
        {
            pantallaAgregarUsuario pas = new pantallaAgregarUsuario();

            if (pas.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
        }
        
        #region Botones Filtros
        private void btnAZ_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndAZ, rndZA, rndAntiguo, rndReciente);
        }
        private void btnZA_Click(object sender, EventArgs e)
        {

            pantallaListasHelper.cambiarCuatroPaneles(
                rndZA, rndAZ, rndAntiguo, rndReciente);
        }

        private void btnAntiguo_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndAntiguo, rndZA, rndAZ, rndReciente);
        }

        private void btnReciente_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndReciente, rndAntiguo, rndZA, rndAZ);
        }
        #endregion Botones Filtros

        #region Txt Buscar
        private void txt_Buscar_Enter(object sender, EventArgs e)
        {
            pantallaListasHelper.buscarEnter(txt_Buscar);
        }

        private void txt_Buscar_Leave(object sender, EventArgs e)
        {
            pantallaListasHelper.buscarLeave(txt_Buscar);
        }
        #endregion Txt Buscar

    }
}
