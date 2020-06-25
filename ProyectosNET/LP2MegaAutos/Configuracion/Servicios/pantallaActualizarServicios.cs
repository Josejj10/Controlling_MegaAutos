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
using LP2MegaAutos.ServicioServicio;
using LP2MegaAutos.Framework;

namespace LP2MegaAutos
{
    public partial class pantallaActualizarServicios : Pantalla
    {
        ServicioServicio.ServicioWSClient daoServicio;
        List<servicio> servicios;
        public pantallaActualizarServicios()
        {
            InitializeComponent();
            btn_Agregar.Click += btnAgregarClick;
            flpServicios.AutoScroll = true;
            daoServicio = new ServicioServicio.ServicioWSClient();
            inicializarItemsLista();
        }

        private void inicializarItemsLista()
        {
            servicios = daoServicio.listarServicios().ToList();
            crearItemsLista();
        }

        private void crearItemsLista()
        {
            if (servicios == null) return;
            foreach (servicio s in servicios)
            {
                createItemListaServicio(s, "Carter Kane", DateTime.Now);
            }
        }

        private void quitarItemsLista()
        {
            foreach (Control c in flpServicios.Controls)
                c.Parent.Controls.Remove(c);
        }

        private void organizarAZ()
        {
            servicios.OrderBy(g => g.nombre);
            quitarItemsLista();
            crearItemsLista();
        }

        private void organizarZA()
        {
            servicios.OrderByDescending(g => g.nombre);
            quitarItemsLista();
            crearItemsLista();
        }

        private itemLista createItemListaServicio(ServicioServicio.servicio servicio, string agregadoPor, DateTime fechaAgregado)
        {
            itemLista il = new itemLista();
            BotonesDinamicosHelper.personalizarItemLista(il);
            il.Name = "il" + servicio.id;
            il.TextoAgregadoPor = agregadoPor;
            il.TextoFecha = fechaAgregado.ToString("dd/MM/yyyy");
            il.TextoPrincipal = OtrosHelper.tipoOracion(servicio.nombre);
            il.Textosecundario = OtrosHelper.tipoOracion(servicio.tipoServicio);
            il.TextoTercero = OtrosHelper.tipoOracion(servicio.codigoServicio);
            il.ItemListaClick += (sender, e) => { verDatosServicio(sender, e, servicio); };
            il.EditarClick += (sender, e) => { btnEditarClick(sender, e, servicio); };
            il.esconderBotonEditar();
            flpServicios.Controls.Add(il);
            return il;
        }

        private void verDatosServicio(object sender, EventArgs e, ServicioServicio.servicio servicio)
        {
            pantallaEditarServicio pes = new pantallaEditarServicio(servicio);
            DialogResult d = pes.ShowDialog();
            if (d == DialogResult.OK)
                MessageBox.Show("OK");
            else if (d == DialogResult.Retry)
            {
                //Eliminar
                daoServicio.eliminarServicio(servicio.id);
                flpServicios.Controls.RemoveByKey("il" + servicio.id);
                //ordenarItemsLista();
                inicializarItemsLista();
            }
        }
        private void btnEditarClick(Object sender, EventArgs e, ServicioServicio.servicio servicio)
        {
            pantallaEditarServicio pes = new pantallaEditarServicio(servicio);
            if (pes.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
        }

        private void btnAgregarClick(Object sender, EventArgs e)
        {
            pantallaEditarServicio pes = new pantallaEditarServicio();
            
            if (pes.ShowDialog() == DialogResult.OK)
            {
                servicio _servicio = pes.Servicio;
                daoServicio.insertarServicio(_servicio);
            }
        }

        private void txt_Buscar_Enter(object sender, EventArgs e)
        {
            txt_Buscar.Text = string.Empty;
        }

        private void btnAZ_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndAZ.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rndZA.ColorPanel = Color.Transparent;
            this.rndAntiguo.ColorPanel = Color.Transparent;
            this.rndReciente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnZA.BackColor = Color.Transparent;
            this.btnAZ.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btnReciente.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Color.Transparent;
        }

        private void btnZA_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndAZ.ColorPanel = Color.Transparent;
            this.rndZA.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rndAntiguo.ColorPanel = Color.Transparent;
            this.rndReciente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnAZ.BackColor = Color.Transparent;
            this.btnZA.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btnReciente.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Color.Transparent;
        }

        private void btnAntiguo_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndAZ.ColorPanel = Color.Transparent;
            this.rndZA.ColorPanel = Color.Transparent;
            this.rndAntiguo.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rndReciente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnAZ.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btnReciente.BackColor = Color.Transparent;
            this.btnZA.BackColor = Color.Transparent;
        }

        private void btnReciente_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndAZ.ColorPanel = Color.Transparent;
            this.rndReciente.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rndZA.ColorPanel = Color.Transparent;
            this.rndAntiguo.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnAZ.BackColor = Color.Transparent;
            this.btnReciente.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btnZA.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Color.Transparent;
        }

        private void txt_Buscar_Leave(object sender, EventArgs e)
        {
            if (txt_Buscar.Text == string.Empty)
                txt_Buscar.Text = "Buscar";
        }

        //private void rndAZ_MouseDown(object sender, MouseEventArgs e)
        //{
        //    this.rndAZ.ColorPanel = Colores.AmarilloHover;
        //    this.btnAZ.BackColor = Colores.AmarilloHover;
        //}

        //private void rndZA_MouseDown(object sender, MouseEventArgs e)
        //{
        //    this.rndZA.ColorPanel = Colores.AmarilloHover;
        //    this.btnZA.BackColor = Colores.AmarilloHover;
        //}

        //private void rndAntiguo_MouseDown(object sender, MouseEventArgs e)
        //{
        //    this.rndAntiguo.ColorPanel = Colores.AmarilloHover;
        //    this.btnAntiguo.BackColor = Colores.AmarilloHover;
        //}

        //private void rndReciente_MouseDown(object sender, MouseEventArgs e)
        //{
        //    this.rndReciente.ColorPanel = Colores.AmarilloHover;
        //    this.btnReciente.BackColor = Colores.AmarilloHover;
        //}

        //private void rndAZ_MouseUp(object sender, MouseEventArgs e)
        //{
        //    this.rndAZ.ColorPanel = Colores.AmarilloInteractivo;
        //    this.btnAZ.BackColor = Colores.AmarilloInteractivo;
        //}

        //private void rndZA_MouseUp(object sender, MouseEventArgs e)
        //{
        //    this.rndZA.ColorPanel = Colores.AmarilloInteractivo;
        //    this.btnZA.BackColor = Colores.AmarilloInteractivo;
        //}

        //private void rndAntiguo_MouseUp(object sender, MouseEventArgs e)
        //{
        //    this.rndAntiguo.ColorPanel = Colores.AmarilloInteractivo;
        //    this.btnAntiguo.BackColor = Colores.AmarilloInteractivo;
        //}

        //private void rndReciente_MouseUp(object sender, MouseEventArgs e)
        //{
        //    this.rndReciente.ColorPanel = Colores.AmarilloInteractivo;
        //    this.btnReciente.BackColor = Colores.AmarilloInteractivo;
        //}

    }
}
