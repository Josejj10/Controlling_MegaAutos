﻿using System;
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
        public string textoBuscar;
        public pantallaActualizarSedes()
        {
            InitializeComponent();
            flpSedes.AutoScroll = true;
            textoBuscar = "sede por nombre o distrito";
            daoSede = new ServicioSede.SedeWSClient();
            txt_Buscar.Text += textoBuscar;
        }

        #region itemLista
        public void inicializarItemsLista()
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
            il.TextoPrincipal = sede.nombre;
            il.Textosecundario = sede.distrito;
            il.TextoTercero = sede.direccion;
            il.ItemListaClick += (sender, e) => { verDatosSede(sender, e, sede); };
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
                _sedes.Remove(sede);
                _sedes.Add(_sede);
                btnAZ_Click(btnAZ, new EventArgs());
            }
            else if (d == DialogResult.Retry)
            {
                // Eliminar
                daoSede.eliminarSede(sede.id);
                organizarAZ();
                // Eliminar
                _sedes.Remove(sede);
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
                btnAZ_Click(btnAZ, new EventArgs());
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
            pantallaListasHelper.buscarEnter(txt_Buscar, textoBuscar); //AGREGADO PARA BUSCAR
        }

        private void txt_Buscar_Leave(object sender, EventArgs e)
        {
            if (btnBuscar.Focused) return;
            pantallaListasHelper.buscarLeave(txt_Buscar, textoBuscar);//AGREGADO PARA BUSCAR
        }
        #endregion Botones Filtros

        #region Buscar //AGREGADO PARA BUSCAR
        private void crearItemsListaBuscar(List<sede> _sede)
        {
            if (_sede == null) return;
            foreach (sede u in _sede)
            {
                createItemListaSede(u, "Carter Kane", DateTime.Now);
            }
        }

        private void txt_Buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            btnBuscar_Click(btnBuscar, e);
            // Tenemos la lista usuarios
            //List<sede> _usuariosBuscados = new List<sede>();
            //foreach (sede u in _sedes)
            //    if (u.nombre.Contains(txt_Buscar.Text.ToUpper()) ||
            //        u.distrito.Contains(txt_Buscar.Text.ToUpper()) ||
            //        u.direccion.Contains(txt_Buscar.Text.ToUpper()))
            //        _usuariosBuscados.Add(u);

            //quitarItemsLista();
            //crearItemsListaBuscar(_usuariosBuscados);
        }
        #endregion Buscar

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<sede> _sedesBuscados = new List<sede>();
            foreach (sede s in _sedes)
                if (s.nombre.Contains(txt_Buscar.Text.ToUpper()) ||
                    s.nombre.Contains(txt_Buscar.Text) ||
                    s.distrito.Contains(txt_Buscar.Text.ToUpper()) ||
                    s.distrito.Contains(txt_Buscar.Text))
                    _sedesBuscados.Add(s);

            quitarItemsLista();
            if (_sedesBuscados.Count == 0)
            {
                frmMessageBox frm = new frmMessageBox("No se hallaron resultados para la búsqueda.", MessageBoxButtons.OK);
                frm.ShowDialog();
                _sedesBuscados = _sedes;
                txt_Buscar.Text = string.Empty;
            }
            crearItemsListaBuscar(_sedesBuscados);
            pantallaListasHelper.buscarLeave(txt_Buscar, textoBuscar);
        }
    }
}
