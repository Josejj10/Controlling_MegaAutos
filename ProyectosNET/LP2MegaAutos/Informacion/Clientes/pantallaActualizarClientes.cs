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
using LP2MegaAutos.ServicioCliente;
using LP2MegaAutos.Framework;

namespace LP2MegaAutos
{
    public partial class pantallaActualizarClientes : Pantalla
    {
        ServicioCliente.ClienteWSClient daoCliente;
        List<cliente> _clientes;
        private string textoBuscar;
        public pantallaActualizarClientes()
        {
            InitializeComponent();
            flpClientes.AutoScroll = true;
            daoCliente = new ServicioCliente.ClienteWSClient();
            //inicializarItemsLista();
        }
        public void inicializarItemsLista()
        {
            _clientes = daoCliente.listarClientes().ToList();
            crearItemLista();
        }

        private void crearItemLista()
        {
            if (_clientes == null) return;
            foreach(cliente c in _clientes)
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
            _clientes = _clientes.OrderBy(c => c.nombre).ToList();
            quitarItemsLista();
            crearItemLista();
        }

        private void organizarZA()
        {
            _clientes = _clientes.OrderByDescending(c => c.nombre).ToList();
            quitarItemsLista();
            crearItemLista();
        }

        private void organizarAntiguo()
        {
            //clientes = clientes.OrderBy.OrderBy(c => c.fechaCreado).ToList();
            quitarItemsLista();
            crearItemLista();
        }

        private void organizarReciente()
        {
            //clientes = clientes.OrderBy(c => c.fechaCreado).ToList();
            quitarItemsLista();
            crearItemLista();
        }

        private itemLista createItemListaCliente(ServicioCliente.cliente cliente, string agregadoPor, DateTime fechaAgregado)
        {
            itemLista il = new itemLista();
            BotonesDinamicosHelper.personalizarItemLista(il);
            il.Name = "il" + cliente.id;
            il.TextoPrincipal = cliente.nombre;
            if (cliente.numDocumento.Length == 8) il.Textosecundario = "DNI: ";
            else if (cliente.numDocumento.Length == 11) il.Textosecundario = "RUC: ";
            else if (cliente.numDocumento.Length == 9) il.Textosecundario = "C.E: ";
            il.Textosecundario += cliente.numDocumento;
            il.TextoTercero = cliente.tipoCliente;
            il.ItemListaClick += (sender, e) => { verDatosCliente(sender, e, cliente); };
            flpClientes.Controls.Add(il);
            return il;
        }
        private void verDatosCliente(object sender, EventArgs e, ServicioCliente.cliente cliente)
        {
            pantallaEditarCliente pes = new pantallaEditarCliente(cliente);
            DialogResult d = pes.ShowDialog();
            if (d == DialogResult.OK)
            {
                // Actualizar el cliente
                cliente _cliente = pes.Cliente;
                daoCliente.actualizarCliente(_cliente);
                createItemListaCliente(_cliente, "Carter Kane", DateTime.Now);
                _clientes.Remove(cliente);
                _clientes.Add(_cliente);
                btnAZ_Click(btnAZ, new EventArgs());
            }
                
            else if (d == DialogResult.Retry)
            {
                // Eliminar
                daoCliente.eliminarCliente(cliente.id);
                organizarAZ();
                _clientes.Remove(cliente);
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

        private void pantallaActualizarClientes_Load(object sender, EventArgs e)
        {

        }

        private void il_Clientes1_Load(object sender, EventArgs e)
        {

        }
        private void txt_Buscar_Enter(object sender, EventArgs e)
        {
            if (txt_Buscar.Text == "Buscar")
                txt_Buscar.Text = string.Empty;
        }

        private void txt_Buscar_Leave(object sender, EventArgs e)
        {
            if (txt_Buscar.Text == string.Empty)
                txt_Buscar.Text = "Buscar";
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            pantallaEditarCliente pec = new pantallaEditarCliente();
            if (pec.ShowDialog() == DialogResult.OK)
            {
                cliente _cliente = pec.Cliente;
                _clientes.Add(_cliente);
                frmMessageBox frm;
                if (daoCliente.insertarCliente(_cliente) == 0)
                    frm = new frmMessageBox("No se pudo insertar.");
                else
                {
                    frm = new frmMessageBox("Se inserto correctamente el cliente " + _cliente.nombre);
                    btnAZ_Click(btnAZ, e);
                }

                frm.ShowDialog();
            }
        }
        private void crearItemsListaBuscar(List<cliente> _clientesB)
        {
            if (_clientesB == null) return;
            foreach (cliente c in _clientesB)
            {
                createItemListaCliente(c, "Carter Kane", DateTime.Now);
            }
        }

        private void txt_Buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            // Tenemos la lista usuarios
            List<cliente> _clientesBuscados = new List<cliente>();
            foreach (cliente u in _clientes)
                if (u.nombre.Contains(txt_Buscar.Text) ||
                    u.tipoCliente.Contains(txt_Buscar.Text) ||
                    u.correo.Contains(txt_Buscar.Text) ||
                    u.tipoDocumento.Contains(txt_Buscar.Text.ToUpper()))
                    _clientesBuscados.Add(u);

            quitarItemsLista();
            crearItemsListaBuscar(_clientesBuscados);
        }

    }
}
