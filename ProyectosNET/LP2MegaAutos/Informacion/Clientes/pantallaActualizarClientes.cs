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
using LP2MegaAutos.ServicioCliente;
using LP2MegaAutos.Framework;

namespace LP2MegaAutos
{
    public partial class pantallaActualizarClientes : Pantalla
    {
        ServicioCliente.ClienteWSClient daoCliente;
        List<cliente> clientes;
        public pantallaActualizarClientes()
        {
            InitializeComponent();
            flpClientes.AutoScroll = true;
            daoCliente = new ServicioCliente.ClienteWSClient();
            inicializarItemsLista();
        }
        private void inicializarItemsLista()
        {
            clientes = daoCliente.listarClientes().ToList();
            crearItemLista();
        }

        private void crearItemLista()
        {
            if (clientes == null) return;
            foreach(cliente c in clientes)
            {
                createItemListaCliente(c, "Carter Kane", DateTime.Now);
            }
        }

        private void quitarItemsLista()
        {
            for (int i = 0; i < flpClientes.Controls.Count;)
                flpClientes.Controls.RemoveAt(i);
        }

        private void organizarAZ()
        {
            clientes = clientes.OrderBy(c => c.nombre).ToList();
            quitarItemsLista();
            crearItemLista();
        }

        private void organizarZA()
        {
            clientes = clientes.OrderByDescending(c => c.nombre).ToList();
            quitarItemsLista();
            crearItemLista();
        }

        //private void organizarAntiguo()
        //{
        //    clientes = clientes.OrderBy.OrderBy(c => c.fechaCreado).ToList();
        //    quitarItemsLista();
        //    crearItemLista();
        //}

        //private void organizarReciente()
        //{
        //    clientes = clientes.OrderBy(c => c.fechaCreado).ToList();
        //    quitarItemsLista();
        //    crearItemLista();
        //}

        private itemLista createItemListaCliente(ServicioCliente.cliente cliente, string agregadoPor, DateTime fechaAgregado)
        {
            itemLista il = new itemLista();
            BotonesDinamicosHelper.personalizarItemLista(il);
            il.Name = "il" + cliente.id;
            il.TextoAgregadoPor = agregadoPor;
            il.TextoFecha = fechaAgregado.ToString("dd/MM/yyyy");
            il.TextoPrincipal = cliente.nombre;
            if (cliente.numDocumento.Length == 8) il.Textosecundario = "DNI: ";
            else if (cliente.numDocumento.Length == 10) il.Textosecundario = "RUC: ";
            il.Textosecundario += cliente.numDocumento;
            il.TextoTercero = cliente.tipoCliente;
            il.ItemListaClick += (sender, e) => { verDatosCliente(sender, e, cliente); };
            il.esconderBotonEditar();
            flpClientes.Controls.Add(il);
            return il;
        }
        private void verDatosCliente(object sender, EventArgs e, ServicioCliente.cliente cl)
        {
            pantallaEditarCliente pes = new pantallaEditarCliente(cl);
            DialogResult d = pes.ShowDialog();
            if (d == DialogResult.OK)
            {
                // Actualizar el cliente
                cliente c = pes.Cliente;
                daoCliente.actualizarCliente(c);
                flpClientes.Controls.RemoveByKey("il" + cl.id);
                createItemListaCliente(c, "Carter Kane", DateTime.Now);
                clientes.Add(c);
                btnAZ_Click(btnAZ, new EventArgs());
            }
                
            else if (d == DialogResult.Retry)
            {
                // Eliminar
                daoCliente.eliminarCliente(cl.id);
                flpClientes.Controls.RemoveByKey("il" + cl.id);
                clientes.Remove(cl);
                //ordenarItemsLista();
                btnAZ_Click(btnAZ, e);
            }
        }
        private void btnEditarClick(Object sender, EventArgs e, cliente cliente)
        {
            pantallaEditarCliente pes = new pantallaEditarCliente();
            if (pes.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
        }

        private void btnAgregarClick(Object sender, EventArgs e)
        {
            pantallaAgregarCliente pas = new pantallaAgregarCliente();

            if (pas.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
        }

        private void btnAZ_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            pantallaListasHelper.cambiarCuatroPaneles(rndAZ, rndZA, rndAntiguo, rndReciente);
            organizarAZ();
        }

        private void btnZA_Click(object sender, EventArgs e)
        {
            pantallaListasHelper.cambiarCuatroPaneles(
                rndZA, rndAZ, rndAntiguo, rndReciente);
            organizarZA();
        }

        //private void btnAntiguo_Click(object sender, EventArgs e)
        //{
        //    pantallaListasHelper.cambiarCuatroPaneles(
        //        rndAntiguo, rndZA, rndAZ, rndReciente);
        //    organizarAntiguo();
        //}

        //private void btnReciente_Click(object sender, EventArgs e)
        //{
        //    pantallaListasHelper.cambiarCuatroPaneles(
        //        rndReciente, rndAntiguo, rndZA, rndAZ);
        //    organizarReciente();
        //}

        private void pantallaActualizarClientes_Load(object sender, EventArgs e)
        {

        }

        private void il_Clientes1_Load(object sender, EventArgs e)
        {

        }
        private void txt_Buscar_Enter(object sender, EventArgs e)
        {
            pantallaListasHelper.buscarEnter(txt_Buscar);
        }

        private void txt_Buscar_Leave(object sender, EventArgs e)
        {
            pantallaListasHelper.buscarLeave(txt_Buscar);
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            pantallaEditarCliente cl = new pantallaEditarCliente();
            if (cl.ShowDialog() == DialogResult.OK)
            {
                cliente _cliente = cl.Cliente;
                clientes.Add(_cliente);
                frmMessageBox frm;
                if (daoCliente.insertarCliente(_cliente) == 0)
                    frm = new frmMessageBox("No se pudo insertar.");
                else
                    frm = new frmMessageBox("Se inserto correctamente el cliente " + _cliente.nombre);
                frm.ShowDialog();
            }
        }


    }
}
