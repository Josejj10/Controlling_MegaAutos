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
using LP2MegaAutos.ServicioVehiculo;

namespace LP2MegaAutos.Informacion.Vehiculos
{
    public partial class pantallaActualizarVehiculos : Pantalla
    {
        ServicioVehiculo.VehiculoWSClient daoVehiculo;
        List<vehiculo> _vehiculos;
        private string textoBuscar; //AGREGADO PARA BUSCAR
        public pantallaActualizarVehiculos()
        {
            InitializeComponent();
            textoBuscar = " vehiculo por placa, cliente o tipo de vehiculo";
            flpVehiculos.AutoScroll = true;
            daoVehiculo = new ServicioVehiculo.VehiculoWSClient();
            inicializarItemsLista();
            txt_Buscar.Text += textoBuscar;
        }

        #region Organizar
        private void organizarAZ()
        {
            _vehiculos = _vehiculos.OrderBy(g => g.placa).ToList();
            quitarItemsLista();
            crearItemsLista();
        }

        private void organizarZA()
        {
            _vehiculos = _vehiculos.OrderByDescending(g => g.placa).ToList();
            quitarItemsLista();
            crearItemsLista();
        }
        private void organizarAntiguo()
        {
            //_vehiculos = _vehiculos.OrderBy(g => g.fechaCreado).ToList();
            quitarItemsLista();
            crearItemsLista();
        }

        private void organizarReciente()
        {
            //_vehiculos = _vehiculos.OrderByDescending(g => g.fechaCreado).ToList();
            quitarItemsLista();
            crearItemsLista();
        }
        #endregion Organizar

        #region Botones Filtro
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
        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button)
                pantallaListasHelper.btn_MouseDown((Button)sender);
        }
        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Button)
                pantallaListasHelper.btn_MouseUp((Button)sender);
        }
        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Button)
                pantallaListasHelper.btn_MouseMove((Button)sender);
        }
        #endregion Botones Filtro

        private void inicializarItemsLista()
        {
            _vehiculos = daoVehiculo.listarVehiculos().ToList();
            crearItemsLista();
        }

        private void crearItemsLista()
        {
            if (_vehiculos == null) return;
            foreach (vehiculo v in _vehiculos)
            {
                createItemListaVehiculo(v, "Carter Kane", DateTime.Now);
            }
        }
        private void quitarItemsLista()
        {
            for (int i = 0; i < flpVehiculos.Controls.Count;)
                flpVehiculos.Controls.RemoveAt(i);
        }
        
        private itemLista createItemListaVehiculo(ServicioVehiculo.vehiculo vehiculo, string agregadoPor, DateTime fechaAgregado)
        {
            itemLista il = new itemLista();
            BotonesDinamicosHelper.personalizarItemLista(il);
            il.Name = "il" + vehiculo.id;
            il.TextoPrincipal = vehiculo.placa;
            il.Textosecundario = OtrosHelper.tipoOracion(vehiculo.propietario.nombre);
            il.TextoTercero = OtrosHelper.tipoOracion(vehiculo.tipoVehiculo);
            il.ItemListaClick += (sender, e) => { verDatosVehiculo(sender, e, vehiculo); };
            flpVehiculos.Controls.Add(il);
            return il;
        }
        private void verDatosVehiculo(object sender, EventArgs e, ServicioVehiculo.vehiculo veh)
        {
            frmEditarVehiculo pes = new frmEditarVehiculo(veh);
            DialogResult d = pes.ShowDialog();
            if (d == DialogResult.OK)
            {
                //Actualizar el vehiculo
                vehiculo v = pes.Vehiculo;
                daoVehiculo.actualizarVehiculo(v);
                flpVehiculos.Controls.RemoveByKey("il" + veh.id);
                createItemListaVehiculo(v, "Carter Kane", DateTime.Now);
                _vehiculos.Remove(veh);
                _vehiculos.Add(v);
                btnAZ_Click(btnAZ, new EventArgs());
            }
            else if(d== DialogResult.Retry)
            {
                //Eliminar
                daoVehiculo.eliminarVehiculo(veh.id);
                flpVehiculos.Controls.RemoveByKey("il" + veh.id);
                _vehiculos.Remove(veh);
                btnAZ_Click(btnAZ, e);
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            frmEditarVehiculo pas = new frmEditarVehiculo();

            if (pas.ShowDialog() == DialogResult.OK)
            {
                vehiculo _vehiculo= pas.Vehiculo;
                _vehiculos.Add(_vehiculo);
                frmMessageBox frm;
                if (daoVehiculo.insertarVehiculo(_vehiculo) == 0) // Ta mal
                    frm = new frmMessageBox("No se pudo insertar.");
                else // Inserto bien
                    frm = new frmMessageBox("Se inserto correctamente el vehiculo con placa " + _vehiculo.placa);
                frm.ShowDialog();
            }
        }

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
        private void crearItemsListaBuscar(List<vehiculo> _vehiculosB)
        {
            if (_vehiculosB == null) return;
            foreach (vehiculo v in _vehiculosB)
            {
                createItemListaVehiculo(v, "Carter Kane", DateTime.Now);
            }
        }

        private void txt_Buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            btnBuscar_Click(btnBuscar, e);
            // Tenemos la lista servicios
            //List<vehiculo> _vehiculosBuscados = new List<vehiculo>();
            //foreach (vehiculo v in _vehiculos)
            //    if (v.placa.Contains(txt_Buscar.Text.ToUpper())||
            //        v.propietario.nombre.Contains(txt_Buscar.Text.ToUpper()))
            //        _vehiculosBuscados.Add(v);

            //quitarItemsLista();
            //crearItemsListaBuscar(_vehiculosBuscados);
        }
        #endregion Buscar

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<vehiculo> _vehiculosBuscados = new List<vehiculo>();
            foreach (vehiculo v in _vehiculos)
                if (v.placa.Contains(txt_Buscar.Text.ToUpper()) ||
                    v.tipoVehiculo.Contains(txt_Buscar.Text.ToUpper()) ||
                    v.tipoVehiculo.Contains(txt_Buscar.Text) ||
                    v.propietario.nombre.Contains(txt_Buscar.Text.ToUpper()) ||
                    v.propietario.nombre.Contains(txt_Buscar.Text))
                    _vehiculosBuscados.Add(v);

            quitarItemsLista();
            if (_vehiculosBuscados.Count == 0)
            {
                frmMessageBox frm = new frmMessageBox("No se hallaron resultados para la búsqueda.", MessageBoxButtons.OK);
                frm.ShowDialog();
                _vehiculosBuscados = _vehiculos;
                txt_Buscar.Text = string.Empty;
            }
            crearItemsListaBuscar(_vehiculosBuscados);
            pantallaListasHelper.buscarLeave(txt_Buscar, textoBuscar);
        }
    }
}
