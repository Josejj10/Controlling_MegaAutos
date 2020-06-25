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
using LP2MegaAutos.ServicioSede;
using LP2MegaAutos.Framework;

namespace LP2MegaAutos
{
    public partial class pantallaActualizarSedes : Pantalla
    {
        ServicioSede.SedeWSClient daoSede;
        List<sede> _sedes;
        public pantallaActualizarSedes()
        {
            InitializeComponent();
            flpSedes.AutoScroll = true;
            daoSede = new ServicioSede.SedeWSClient();
            inicializarItemsLista();
        }

        #region itemLista
        private void inicializarItemsLista()
        {
            _sedes = daoSede.listarSedes().ToList();
            organizarAZ();
        }

        private void crearItemsLista()
        {
            if (_sedes == null) return;
            foreach (sede s in _sedes)
            {
                createItemListaSede(s, "Carter Kane", DateTime.Now);
            }
        }

        private void quitarItemsLista()
        {
            for (int i = 0; i < flpSedes.Controls.Count;)
                flpSedes.Controls.RemoveAt(i);
        }

        
        private itemLista createItemListaSede(ServicioSede.sede sede, string agregadoPor, DateTime fechaAgregado)
        {
            itemLista il = new itemLista();
            BotonesDinamicosHelper.personalizarItemLista(il);
            il.Name = "il" + sede.id;
            il.TextoAgregadoPor = agregadoPor;
            il.TextoFecha = fechaAgregado.ToString("dd/MM/yyyy");
            il.TextoPrincipal = sede.nombre;
            il.Textosecundario = sede.distrito;
            il.TextoTercero = sede.direccion;
            il.ItemListaClick += (sender, e) => { verDatosSede(sender, e, sede); };
            il.esconderBotonEditar();
            flpSedes.Controls.Add(il);
            return il;
        }

        private void verDatosSede(object sender, EventArgs e, ServicioSede.sede sede)
        {
            pantallaEditarSede pes = new pantallaEditarSede(sede);
            DialogResult d = pes.ShowDialog();
            if (d == DialogResult.OK)
            {
                sede _sede = pes.Sede;
                daoSede.actualizarSede(_sede);
                createItemListaSede(_sede, "Carter Kane", DateTime.Now);
                _sedes.Add(_sede);
                btnAZ_Click(btnAZ, new EventArgs());
                // todo actualizar FechaUltimaModificacion en BD
            }
            else if (d == DialogResult.Retry)
            {
                // Eliminar
                daoSede.eliminarSede(sede.id);
                organizarAZ();
                // Eliminar
                _sedes.Remove(sede);
                // TODO seleccionar organizar segun el boton seleccionado
                btnAZ_Click(btnAZ, e);
            }
        }

        #region Organizar
        private void organizarAZ()
        {
            _sedes = _sedes.OrderBy(g => g.nombre).ToList();
            quitarItemsLista();
            crearItemsLista();
        }

        private void organizarZA()
        {
            _sedes = _sedes.OrderByDescending(g => g.nombre).ToList();
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

        private void btnAgregarClick(Object sender, EventArgs e)
        {
            pantallaEditarSede pes = new pantallaEditarSede();
            if (pes.ShowDialog() == DialogResult.OK)
            {
                // Agregar sede
                sede _sede = pes.Sede;
                _sedes.Add(_sede);
                frmMessageBox frm;
                if (daoSede.insertarSede(_sede) == 0) // Ta mal
                    frm = new frmMessageBox("No se pudo insertar.");
                else // Inserto bien
                    frm = new frmMessageBox("Se inserto correctamente la sede en " + _sede.distrito);
                frm.ShowDialog();
            }
        }

        #endregion itemLista

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
        
    }
}
