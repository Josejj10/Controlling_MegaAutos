using LP2MegaAutos.Framework;
using LP2MegaAutos.Properties;
using LP2MegaAutos.ServicioCliente;
using LP2MegaAutos.ServicioServicio;
using LP2MegaAutos.VentanasPrincipales;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2MegaAutos.Informacion.Vehiculos
{
    public partial class frmEditarVehiculo : MetroForm
    {
        ServicioVehiculo.vehiculo _vehiculo;
        ServicioCliente.cliente _cliente;
        //ServicioVehiculo.cliente _propietario;
        ServicioCliente.ClienteWSClient daoCliente;
        public frmEditarVehiculo()
        {
            InitializeComponent();
            _vehiculo = new ServicioVehiculo.vehiculo();
            _cliente = new ServicioCliente.cliente();
            daoCliente = new ServicioCliente.ClienteWSClient();

            cboTipoCliente.DataSource = new BindingList<ServicioCliente.cliente>(daoCliente.listarClientes().ToArray());
            cboTipoCliente.DisplayMember = "numDocumento";
            cboTipoCliente.ValueMember = "id";
            lbl_EditarVehiculo.Text = "Agregar vehículo";
            btnEliminar.Visible = btnEditar.Visible = false;
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
        }
        public frmEditarVehiculo(ServicioVehiculo.vehiculo vehiculo)
        {
            InitializeComponent();
            _vehiculo = vehiculo;
            //_propietario = new ServicioVehiculo.cliente();
            _cliente = new ServicioCliente.cliente();
            daoCliente = new ServicioCliente.ClienteWSClient();
            toggleComponentes();
            this.lbl_EditarVehiculo.Text = "Editar vehículo";
            this.txt_placaVehiculo.Text = vehiculo.placa.Trim();

            string cadena = vehiculo.propietario.numDocumento + " - " + vehiculo.propietario.nombre;

            cboTipoCliente.DataSource = new BindingList<ServicioCliente.cliente>(daoCliente.listarClientes().ToArray());
            cboTipoCliente.SelectedIndex = cboTipoCliente.FindString(cadena);
            cboTipoCliente.DisplayMember = "numDocumento";
            cboTipoCliente.ValueMember = "id";

            this.txt_TipoVehiculo.Text = OtrosHelper.tipoOracion(vehiculo.tipoVehiculo);
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
        }
        private void toggleComponentes()
        {
            bool en = lbl_EditarVehiculo.Enabled = txt_placaVehiculo.Enabled =
                cboTipoCliente.Enabled = txt_TipoVehiculo.Enabled = btn_guardar.Enabled
                = !lbl_EditarVehiculo.Enabled;


            if (!en)
            {
                // No habilitado
                lbl_EditarVehiculo.ForeColor = txt_placaVehiculo.ForeColor =
                    cboTipoCliente.ForeColor = txt_TipoVehiculo.ForeColor =
                    rnd_color_1.ColorPanel = rnd_color_3.ColorPanel =
                    rnd_color_2.ColorPanel =
                    rnd_guardar.ColorPanel =
                    rnd_color_1.ColorBorde = rnd_color_3.ColorBorde =
                    rnd_color_2.ColorBorde = rnd_guardar.ColorBorde
                    = Colores.Disabled;


                btnEditar.BackgroundImage = Resources.editar;
                return;
            }
            // Habilitado
            lbl_EditarVehiculo.ForeColor = Colores.HighContrast;
            txt_placaVehiculo.ForeColor =
               cboTipoCliente.ForeColor = txt_TipoVehiculo.ForeColor =
               Colores.HighContrast;

            rnd_color_1.ColorPanel = rnd_color_3.ColorPanel =
                    rnd_color_2.ColorPanel =
                    rnd_guardar.ColorPanel =
                    rnd_color_1.ColorBorde = rnd_color_3.ColorBorde =
                    rnd_color_2.ColorBorde = rnd_guardar.ColorBorde
                    = Colores.Rosa;

            btnEditar.BackgroundImage = Resources.Cancelar;
        }

        public ServicioVehiculo.vehiculo Vehiculo { get { return _vehiculo; } }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!vehiculoValido())
                return;
            frmMessageBox f = new frmMessageBox("¿Guardar Cambios?", MessageBoxButtons.OKCancel, "Guardar Cambios");
            if (f.ShowDialog() != DialogResult.OK)
                return;
            _vehiculo.placa = txt_placaVehiculo.Text;
            _vehiculo.propietario = new ServicioVehiculo.cliente();
            ServicioCliente.cliente cliente = (ServicioCliente.cliente)cboTipoCliente.SelectedItem;

            _vehiculo.propietario.id = cliente.id;
            _vehiculo.propietario.nombre = cliente.nombre;
            _vehiculo.propietario.numDocumento = cliente.numDocumento;
            _vehiculo.tipoVehiculo = txt_TipoVehiculo.Text;
            this.DialogResult = DialogResult.OK;
        }

        private bool vehiculoValido()
        {
            if (string.IsNullOrEmpty(txt_placaVehiculo.Text))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese la placa del vehículo.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (txt_placaVehiculo.Text.Length != 6)
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese una placa correcta.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (cboTipoCliente.SelectedIndex == -1)
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese el nombre del propietario del vehículo.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(txt_TipoVehiculo.Text))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese el tipo de vehículo.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            //_cliente = daoCliente.buscarPorNombre(txt_nombVehiculo.Text);
            //if (_cliente.id == 0)
            //{
            //    frmMessageBox f = new frmMessageBox("El cliente no existe en la base de datos. Por favor, ingrese un cliente existente.", MessageBoxButtons.OK);
            //    f.ShowDialog();
            //    return false;
            //}
            
            return true;
        }

        #region title_bar

        #region botones
        private void boton_cerrar_MouseClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void boton_minimizar_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Minimized;
        }
        #endregion botones

        #region movement
        // Llama a la clase estatica TitleBar
        private void title_bar_MouseUp(object sender, MouseEventArgs e)
        {
            TitleBar.mouse_Up();
        }

        private void title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            TitleBar.mouse_Down(MousePosition, Bounds);
        }

        private void title_bar_MouseMove(object sender, MouseEventArgs e)
        {
            TitleBar.mouse_Move(MousePosition, this);
        }

        #endregion movement

        #endregion title_bar

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar frm = new frmEliminar("eliminar el vehículo de placa" + _vehiculo.placa);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.Retry;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            toggleComponentes();
        }

        private void cboTipoCliente_Format(object sender, ListControlConvertEventArgs e)
        {
            string dni = ((cliente)e.ListItem).numDocumento;
            string nombre = ((cliente)e.ListItem).nombre;
            e.Value = dni + " - " + nombre;
        }
    }
}
