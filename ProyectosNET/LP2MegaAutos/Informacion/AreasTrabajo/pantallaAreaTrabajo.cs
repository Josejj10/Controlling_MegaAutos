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
using LP2MegaAutos.Informacion.AreasTrabajo;
using LP2MegaAutos.Framework;
using LP2MegaAutos.ServicioAreaTrabajo;

namespace LP2MegaAutos
{
    public partial class pantallaAreaTrabajo : Pantalla
    {
        ServicioAreaTrabajo.AreaTrabajoWSClient daoAreaTrabajo;
        List<areaTrabajo> _areasTrabajo;
        public string textoBuscar;

        public pantallaAreaTrabajo()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
            daoAreaTrabajo = new ServicioAreaTrabajo.AreaTrabajoWSClient();
            //inicializarItemsLista();
        }
        public void inicializarItemsLista()
        {
            _areasTrabajo = daoAreaTrabajo.listarAreaTrabajo().ToList();
            organizarAZ();
        }

        private void crearItemsLista()
        {
            if (_areasTrabajo == null) return;
            foreach (areaTrabajo a in _areasTrabajo)
            {
                createItemListaAreaTrabajo(a, "Carter Kane", DateTime.Now);
            }
        }
        private void quitarItemsLista()
        {
            for (int i = 0; i < flowLayoutPanel1.Controls.Count;)
                flowLayoutPanel1.Controls.RemoveAt(i);
        }

        private itemLista createItemListaAreaTrabajo(ServicioAreaTrabajo.areaTrabajo areaTrabajo, string agregadoPor, DateTime fechaAgregado)
        {
            itemLista il = new itemLista();
            BotonesDinamicosHelper.personalizarItemLista(il,42);
            il.Name = "il" + areaTrabajo.id;
            il.TextoPrincipal = areaTrabajo.nombre;
            il.ItemListaClick += (sender, e) => { ItemLista_Click(sender, e, areaTrabajo); };
            flowLayoutPanel1.Controls.Add(il);
            return il;
        }
        private void ItemLista_Click(Object sender, EventArgs e, areaTrabajo areaTrabajo)
        {
            pantallaEditarAreaTrabajo pas = new pantallaEditarAreaTrabajo(areaTrabajo);
            DialogResult d = pas.ShowDialog();
            if (d == DialogResult.OK) { 
                areaTrabajo _areaTrabajo = pas.AreaTrabajo;
                daoAreaTrabajo.actualizarAreaTrabajo(_areaTrabajo);
                createItemListaAreaTrabajo(_areaTrabajo, "Carter Kane", DateTime.Now);
                _areasTrabajo.Remove(areaTrabajo);
                _areasTrabajo.Add(_areaTrabajo);
                btnAZ_Click(btnAZ, new EventArgs());
            }
            else if (d == DialogResult.Retry)
            {
                daoAreaTrabajo.eliminarAreaTrabajo(areaTrabajo.id);
                organizarAZ();
                _areasTrabajo.Remove(areaTrabajo);
                btnAZ_Click(btnAZ, e); 
            }
        }
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

        private void txt_Buscar_Enter(object sender, EventArgs e)
        {
            txt_Buscar.Text = string.Empty;
        }

        private void txt_Buscar_Leave(object sender, EventArgs e)
        {
            if (txt_Buscar.Text == string.Empty)
                txt_Buscar.Text = "Buscar";
        }
        #endregion Botones Filtros

        #region Organizar
        private void organizarAZ()
        {
            _areasTrabajo = _areasTrabajo.OrderBy(g => g.nombre).ToList();
            quitarItemsLista();
            crearItemsLista();
        }

        private void organizarZA()
        {
            _areasTrabajo = _areasTrabajo.OrderByDescending(g => g.nombre).ToList();
            quitarItemsLista();
            crearItemsLista();
        }

        private void organizarAntiguo()
        {
            //_sedes = _sedes.OrderBy(g => g.fechaCreado).ToList();
            quitarItemsLista();
            crearItemsLista();
        }

        private void organizarReciente()
        {
            //_sedes = _sedes.OrderByDescending(g => g.fechaCreado).ToList();
            quitarItemsLista();
            crearItemsLista();
        }
        #endregion Organizar

        private void btnAgregarClick(object sender, EventArgs e)
        {
            pantallaEditarAreaTrabajo pes = new pantallaEditarAreaTrabajo();
            if (pes.ShowDialog() == DialogResult.OK)
            {
                areaTrabajo _areaTrabajo = pes.AreaTrabajo;
                _areasTrabajo.Add(_areaTrabajo);
                frmMessageBox frm;
                if (daoAreaTrabajo.insertarAreaTrabajo(_areaTrabajo) == 0) // Ta mal
                    frm = new frmMessageBox("No se pudo insertar.");
                else // Inserto bien
                    frm = new frmMessageBox("Se inserto correctamente el area de trabajo " + _areaTrabajo.nombre);
                frm.ShowDialog();
                btnAZ_Click(btnAZ, new EventArgs());
            }
        }
        #region Buscar //AGREGADO PARA BUSCAR
        private void crearItemsListaBuscar(List<areaTrabajo> _areasTrabajo)
        {
            if (_areasTrabajo == null) return;
            foreach (areaTrabajo u in _areasTrabajo)
            {
                createItemListaAreaTrabajo(u, "Carter Kane", DateTime.Now);
            }
        }

        private void txt_Buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            // Tenemos la lista usuarios
            List<areaTrabajo> _areasBuscadas = new List<areaTrabajo>();
            foreach (areaTrabajo u in _areasTrabajo)
                if (u.nombre.Contains(txt_Buscar.Text.ToUpper()))
                    _areasBuscadas.Add(u);

            quitarItemsLista();
            crearItemsListaBuscar(_areasBuscadas);
        }
        #endregion Buscar
    }
}