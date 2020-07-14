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
using LP2MegaAutos.ServicioServicio;
using LP2MegaAutos.Framework;

namespace LP2MegaAutos
{
    public partial class pantallaActualizarServicios : Pantalla
    {
        private ServicioServicio.ServicioWSClient daoServicio;
        private List<servicio> _servicios;
        private string textoBuscar; //AGREGADO PARA BUSCAR
        public pantallaActualizarServicios()
        {
            InitializeComponent();
            textoBuscar = " servicios por nombre o codigo";
            flpServicios.AutoScroll = true;
            daoServicio = new ServicioServicio.ServicioWSClient();
            //inicializarItemsLista();
            txt_Buscar.Text += textoBuscar;
        }

        public void inicializarItemsLista()
        {
            _servicios = daoServicio.listarServicios().ToList();
            crearItemsLista();
        }

        private void crearItemsLista()
        {
            if (_servicios == null) return;
            foreach (servicio s in _servicios)
            {
                createItemListaServicio(s, "Carter Kane", DateTime.Now);
            }
        }

        private void quitarItemsLista()
        {
            for (int i = 0; i < flpServicios.Controls.Count;)
                flpServicios.Controls.RemoveAt(i);
        }

        private void organizarAZ()
        {
            _servicios = _servicios.OrderBy(g => g.nombre).ToList();
            quitarItemsLista();
            crearItemsLista();
        }

        private void organizarZA()
        {
            _servicios = _servicios.OrderByDescending(g => g.nombre).ToList();
            quitarItemsLista();
            crearItemsLista();
        }
        private void organizarAntiguo()
        {
            //_servicios = _servicios.OrderBy(g => g.fechaCreado).ToList();
            quitarItemsLista();
            crearItemsLista();
        }

        private void organizarReciente()
        {
            //_servicios = _servicios.OrderByDescending(g => g.fechaCreado).ToList();
            quitarItemsLista();
            crearItemsLista();
        }
        private itemLista createItemListaServicio(ServicioServicio.servicio servicio, string agregadoPor, DateTime fechaAgregado)
        {
            itemLista il = new itemLista();
            BotonesDinamicosHelper.personalizarItemLista(il);
            il.Name = "il" + servicio.id;
            il.TextoPrincipal = OtrosHelper.tipoOracion(servicio.nombre);
            il.Textosecundario = OtrosHelper.tipoOracion(servicio.tipoServicio);
            il.TextoTercero = OtrosHelper.tipoOracion(servicio.codigoServicio);
            il.ItemListaClick += (sender, e) => { verDatosServicio(sender, e, servicio); };
            il.EditarClick += (sender, e) => { btnEditarClick(sender, e, servicio); };
            flpServicios.Controls.Add(il);
            return il;
        }

        private void verDatosServicio(object sender, EventArgs e, ServicioServicio.servicio serv)
        {
            pantallaEditarServicio pas = new pantallaEditarServicio(serv);
            DialogResult d = pas.ShowDialog();
            if (d == DialogResult.OK)
            {
                // Actualizar el Servicio
                servicio s = pas.Servicio;
                daoServicio.actualizarServicio(s);
                flpServicios.Controls.RemoveByKey("il" + serv.id);
                createItemListaServicio(s, "Carter Kane", DateTime.Now);
                _servicios.Remove(serv);
                _servicios.Add(s);
                btnAZ_Click(btnAZ, new EventArgs());
                // todo actualizar FechaUltimaModificacion en BD
            }
            else if (d == DialogResult.Retry)
            {
                // Eliminar
                daoServicio.eliminarServicio(serv.id);
                flpServicios.Controls.RemoveByKey("il" + serv.id);
                _servicios.Remove(serv);
                // TODO seleccionar organizar segun el boton seleccionado
                btnAZ_Click(btnAZ, e);
            }
        }
        private void btnEditarClick(Object sender, EventArgs e, ServicioServicio.servicio servicio)
        {
            pantallaEditarServicio pes = new pantallaEditarServicio(servicio);
            if (pes.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
        }

        #region Hide

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
        #endregion Hide

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
        #endregion Botones Filtros

        #region Txt Buscar
        private void txt_Buscar_Enter(object sender, EventArgs e)
        {
            pantallaListasHelper.buscarEnter(txt_Buscar, textoBuscar); //AGREGADO PARA BUSCAR
        }

        private void txt_Buscar_Leave(object sender, EventArgs e)
        {
            if (btnBuscar.Focused) return;
            pantallaListasHelper.buscarLeave(txt_Buscar, textoBuscar);//AGREGADO PARA BUSCAR
        }
        #endregion Txt Buscar

        #region Buscar //AGREGADO PARA BUSCAR
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            pantallaEditarServicio pas = new pantallaEditarServicio();
            if (pas.ShowDialog() == DialogResult.OK)
            {
                // Agregar servicio
                servicio _servicio = pas.Servicio;
                _servicios.Add(_servicio);
                frmMessageBox frm;
                if (daoServicio.insertarServicio(_servicio) == 0) // Ta mal
                    frm = new frmMessageBox("No se pudo insertar.");
                else // Inserto bien
                    frm = new frmMessageBox("Se inserto correctamente el servicio " + _servicio.nombre);
                frm.ShowDialog();
                btnAZ_Click(btnAZ, e);
            }
        }

        private void crearItemsListaBuscar(List<servicio> _serviciosB)
        {
            if (_serviciosB == null) return;
            foreach (servicio s in _serviciosB)
            {
                createItemListaServicio(s, "Carter Kane", DateTime.Now);
            }
        }

        private void txt_Buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            btnBuscar_Click(btnBuscar, e);
            // Tenemos la lista servicios
            //List<servicio> _serviciosBuscados = new List<servicio>();
            //foreach (servicio s in _servicios)
            //    if (s.nombre.Contains(txt_Buscar.Text.ToUpper())||
            //        s.codigoServicio.Contains(txt_Buscar.Text.ToUpper()))
            //        _serviciosBuscados.Add(s);

            //quitarItemsLista();
            //crearItemsListaBuscar(_serviciosBuscados);
        }
        #endregion Buscar

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<servicio> _serviciosBuscados = new List<servicio>();
            foreach (servicio u in _servicios)
                if (u.nombre.Contains(txt_Buscar.Text.ToUpper()) ||
                    u.nombre.Contains(txt_Buscar.Text) ||
                    u.codigoServicio.Contains(txt_Buscar.Text.ToUpper()) ||
                    u.codigoServicio.Contains(txt_Buscar.Text))
                    _serviciosBuscados.Add(u);

            quitarItemsLista();
            if (_serviciosBuscados.Count == 0)
            {
                frmMessageBox frm = new frmMessageBox("No se hallaron resultados para la búsqueda.", MessageBoxButtons.OK);
                frm.ShowDialog();
                _serviciosBuscados = _servicios;
                txt_Buscar.Text = string.Empty;
            }
            crearItemsListaBuscar(_serviciosBuscados);
            pantallaListasHelper.buscarLeave(txt_Buscar, textoBuscar);
        }
    }
}
