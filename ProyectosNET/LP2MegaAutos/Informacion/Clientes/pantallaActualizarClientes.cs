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

namespace LP2MegaAutos
{
    public partial class pantallaActualizarClientes : Pantalla
    {
        ServicioCliente.ClienteWSClient daoCliente;
        List<cliente> clientes;
        public pantallaActualizarClientes()
        {
            InitializeComponent();
            this.btn_Agregar.Click += btnAgregarClick;
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
            foreach (Control c in flpClientes.Controls)
                c.Parent.Controls.Remove(c);
        }

        private void organizarAZ()
        {
            clientes.OrderBy(c => c.nombre);
            quitarItemsLista();
            crearItemLista();
        }

        private void organizarZA()
        {
            clientes.OrderByDescending(c => c.nombre);
            quitarItemsLista();
            crearItemLista();
        }

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
        private void verDatosCliente(object sender, EventArgs e, ServicioCliente.cliente cliente)
        {
            pantallaEditarCliente pes = new pantallaEditarCliente(cliente);
            DialogResult d = pes.ShowDialog();
            if (d == DialogResult.OK)
                MessageBox.Show("OK");
            else if (d == DialogResult.Retry)
            {
                // Eliminar
                daoCliente.eliminarCliente(cliente.id);
                flpClientes.Controls.RemoveByKey("il" + cliente.id);
                //ordenarItemsLista();
                inicializarItemsLista();
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
            this.rndAZ.ColorPanel = Colores.ChooseAmarillo;
            this.rndZA.ColorPanel = Color.Transparent;
            this.rndAntiguo.ColorPanel = Color.Transparent;
            this.rndReciente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnZA.BackColor = Color.Transparent;
            this.btnAZ.BackColor = Colores.ChooseAmarillo;
            this.btnReciente.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Color.Transparent;
        }

        private void btnZA_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndAZ.ColorPanel = Color.Transparent;
            this.rndZA.ColorPanel = Colores.ChooseAmarillo;
            this.rndAntiguo.ColorPanel = Color.Transparent;
            this.rndReciente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnAZ.BackColor = Color.Transparent;
            this.btnZA.BackColor = Colores.ChooseAmarillo;
            this.btnReciente.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Color.Transparent;
        }

        private void btnAntiguo_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndAZ.ColorPanel = Color.Transparent;
            this.rndZA.ColorPanel = Color.Transparent;
            this.rndAntiguo.ColorPanel = Colores.ChooseAmarillo;
            this.rndReciente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnAZ.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Colores.ChooseAmarillo;
            this.btnReciente.BackColor = Color.Transparent;
            this.btnZA.BackColor = Color.Transparent;
        }

        private void btnReciente_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndAZ.ColorPanel = Color.Transparent;
            this.rndReciente.ColorPanel = Colores.ChooseAmarillo;
            this.rndZA.ColorPanel = Color.Transparent;
            this.rndAntiguo.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnAZ.BackColor = Color.Transparent;
            this.btnReciente.BackColor = Colores.ChooseAmarillo;
            this.btnZA.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Color.Transparent;
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
            pantallaEditarCliente cl = new pantallaEditarCliente();
            if (cl.ShowDialog() == DialogResult.OK)
            {
                cliente _cliente = cl.Cliente;
                daoCliente.insertarCliente(_cliente);
            }
        }


    }
}
