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

namespace LP2MegaAutos
{
    public partial class pantallaActualizarSedes : Pantalla
    {
        ServicioSede.SedeWSClient daoSede;
        List<sede> sedes;
        public pantallaActualizarSedes()
        {
            InitializeComponent();
            flpSedes.AutoScroll = true;
            daoSede = new ServicioSede.SedeWSClient();

            inicializarItemsLista();
        }

        private void inicializarItemsLista()
        {
            sedes = daoSede.listarSedes().ToList();
            crearItemsLista();
        }

        private void crearItemsLista()
        {
            if (sedes == null) return;
            foreach (sede s in sedes)
            {
                createItemListaSede(s, "Carter Kane", DateTime.Now);
            }
        }

        private void quitarItemsLista()
        {
            foreach (Control c in flpSedes.Controls)
                c.Parent.Controls.Remove(c);
        }

        private void organizarAZ()
        {
            sedes.OrderBy(g => g.distrito);
            quitarItemsLista();
            crearItemsLista();
        }

        private void organizarZA()
        {
            sedes.OrderByDescending(g => g.distrito);
            quitarItemsLista();
            crearItemsLista();
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
                sede = pes.Sede;
                daoSede.actualizarSede(sede);
            }
            else if (d == DialogResult.Retry)
            {
                // Eliminar
                daoSede.eliminarSede(sede.id);
                flpSedes.Controls.RemoveByKey("il" + sede.id);
            }
        }

        private void btn_AZ_Click(object sender, EventArgs e)
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
            organizarAZ();
        }

        private void btn_ZA_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndZA.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rndAZ.ColorPanel = Color.Transparent;
            this.rndAntiguo.ColorPanel = Color.Transparent;
            this.rndReciente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnAZ.BackColor = Color.Transparent;
            this.btnZA.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btnReciente.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Color.Transparent;
            organizarZA();
        }

        private void btn_Antiguo_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndAntiguo.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rndZA.ColorPanel = Color.Transparent;
            this.rndAZ.ColorPanel = Color.Transparent;
            this.rndReciente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnZA.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btnReciente.BackColor = Color.Transparent;
            this.btnAZ.BackColor = Color.Transparent;
        }

        private void btn_Reciente_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rndReciente.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rndZA.ColorPanel = Color.Transparent;
            this.rndAntiguo.ColorPanel = Color.Transparent;
            this.rndAZ.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btnZA.BackColor = Color.Transparent;
            this.btnReciente.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btnAZ.BackColor = Color.Transparent;
            this.btnAntiguo.BackColor = Color.Transparent;
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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            pantallaEditarSede pes = new pantallaEditarSede();
            if (pes.ShowDialog() == DialogResult.OK)
            {
                sede _sede = pes.Sede;
                daoSede.insertarSede(_sede);
            }
        }
    }
}
