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

namespace LP2MegaAutos
{
    public partial class pantallaActualizarUsuarios : Pantalla
    {
        public pantallaActualizarUsuarios()
        {
            InitializeComponent();
            il_Usuarios1.ItemListaClick += btnItemLista_Click;
            il_Usuarios3.ItemListaClick += btnItemLista_Click;
            btn_Agregar.Click += btnAgregarClick;
            flpUsuarios.AutoScroll = true;
        }
        private void btnItemLista_Click(Object sender, EventArgs e)
        {
            pantallaEditarUsuario pes = new pantallaEditarUsuario();
            if (pes.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
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
