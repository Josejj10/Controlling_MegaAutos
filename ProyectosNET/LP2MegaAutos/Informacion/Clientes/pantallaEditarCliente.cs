using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2MegaAutos.Properties;
using MetroFramework.Forms;
using LP2MegaAutos.Framework;
using LP2MegaAutos.VentanasPrincipales;

namespace LP2MegaAutos
{
    public partial class pantallaEditarCliente : MetroForm
    { 
        ServicioCliente.cliente _cliente;
        public pantallaEditarCliente()
        {
            InitializeComponent();
            _cliente = new ServicioCliente.cliente();
            txt_NombreCliente.Text = "Agregar nombre del cliente...";
            this.btnEditar.Visible = false;
            this.btnEliminar.Visible = false;
            this.txt_NombreCliente.ForeColor = Colores.LowContrast;
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
        }

        public pantallaEditarCliente(ServicioCliente.cliente cliente)
        {
            InitializeComponent();
            _cliente = new ServicioCliente.cliente();
            _cliente = cliente;
            toggleComponentes();
            this.txt_NombreCliente.Text = OtrosHelper.tipoOracion(cliente.nombre).Trim();
            this.txt_NumeroDocumento.Text = OtrosHelper.tipoOracion(cliente.numDocumento).Trim();
            this.cboTipoDocumento.Text = OtrosHelper.tipoOracion(cliente.tipoDocumento).Trim();
            this.txt_Telefono.Text = OtrosHelper.tipoOracion(cliente.telefono).Trim();
            this.txt_Correo.Text = OtrosHelper.tipoOracion(cliente.correo).Trim();
            this.cboTipoCliente.Text = OtrosHelper.tipoOracion(cliente.tipoCliente).Trim();
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
        }

        private void txt_NombreCliente_Enter(object sender, EventArgs e)
        {
            if (txt_NombreCliente.Text == "Agregar nombre del cliente...")
                txt_NombreCliente.Text = string.Empty;
            txt_NombreCliente.ForeColor = Colores.HighContrast;
        }

        private void txt_NombreCliente_Leave(object sender, EventArgs e)
        {
            if(txt_NombreCliente.Text == string.Empty)
            {
                txt_NombreCliente.ForeColor = Colores.LowContrast;
                txt_NombreCliente.Text = "Agregar nombre del cliente...";
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!clienteValido())
                return;
            frmMessageBox f = new frmMessageBox("¿Guardar Cambios?", MessageBoxButtons.OKCancel, "Guardar Cambios");
            if (f.ShowDialog() != DialogResult.OK)
                return;
            _cliente.nombre = txt_NombreCliente.Text;
            _cliente.numDocumento = txt_NumeroDocumento.Text.Trim();

            if (txt_Telefono.Text.Trim() == string.Empty)
                _cliente.telefono = "--";
            else
                _cliente.telefono = txt_Telefono.Text.Trim();
            _cliente.tipoDocumento = cboTipoDocumento.Text.Trim();

            if (txt_Correo.Text.Trim() == string.Empty)
                _cliente.correo = "--";
            else
                _cliente.correo = txt_Correo.Text;
            _cliente.tipoCliente = cboTipoCliente.Text;
            this.DialogResult = DialogResult.OK;
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

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            if (!clienteValido())
                return;
            frmMessageBox f = new frmMessageBox("¿Guardar Cambios?", MessageBoxButtons.OKCancel, "Guardar Cambios");
            if (f.ShowDialog() != DialogResult.OK)
                return;
            _cliente.nombre = txt_NombreCliente.Text;
            _cliente.numDocumento= txt_NumeroDocumento.Text;
            _cliente.tipoDocumento = cboTipoDocumento.Text;
            _cliente.telefono = txt_Telefono.Text;
            _cliente.correo = txt_Correo.Text;
            _cliente.tipoCliente = cboTipoCliente.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            toggleComponentes();
        }

        private void toggleComponentes()
        {
            bool en = txt_NombreCliente.Enabled = txt_NumeroDocumento.Enabled =
                txt_Telefono.Enabled = txt_Correo.Enabled =
                cboTipoCliente.Enabled = btn_guardar.Enabled
                = !txt_NombreCliente.Enabled;
            
            // TODO TIPO DOC DISABLED (DEPENDE D LA CANTIDAD DE DIGITOS EN NUM DOC

            if (!en)
            {
                // No habilitado
                txt_NombreCliente.ForeColor = txt_NumeroDocumento.ForeColor =
                    txt_Telefono.ForeColor =
                    txt_Correo.ForeColor = cboTipoCliente.ForeColor =
                    rnd_color_1.ColorPanel = 
                    roundedPanel1.ColorPanel =
                    roundedPanel2.ColorPanel =
                    roundedPanel3.ColorPanel =
                    roundedPanel4.ColorPanel =
                    rnd_guardar.ColorPanel =
                    rnd_color_1.ColorBorde =
                    roundedPanel1.ColorBorde =
                    roundedPanel2.ColorBorde =
                    roundedPanel3.ColorBorde =
                    roundedPanel4.ColorBorde =
                    rnd_guardar.ColorBorde
                    = Colores.Disabled;


                btnEditar.BackgroundImage = Resources.editar;
                return;
            }
            // Habilitado
            txt_NombreCliente.ForeColor = Colores.HighContrast;
            txt_NumeroDocumento.ForeColor =
              txt_Telefono.ForeColor =
               txt_Correo.ForeColor = cboTipoCliente.ForeColor = 
               Colores.HighContrast;

            rnd_color_1.ColorPanel = 
                roundedPanel1.ColorPanel =
                    roundedPanel2.ColorPanel =
                    roundedPanel3.ColorPanel =
                    roundedPanel4.ColorPanel =
                    rnd_guardar.ColorPanel =
                    rnd_color_1.ColorBorde = roundedPanel1.ColorBorde =
                    roundedPanel2.ColorBorde =
                    roundedPanel3.ColorBorde =
                    roundedPanel4.ColorBorde =
                    rnd_guardar.ColorBorde
                    = Colores.Rosa;

            rnd_guardar.ColorPanel = rnd_guardar.ColorBorde = Colores.Rosa;
            btnEditar.BackgroundImage = Resources.Cancelar;
        }

        public ServicioCliente.cliente Cliente { get { return _cliente; } }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar frm = new frmEliminar("eliminar el cliente " + _cliente.nombre);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.Retry;
            }
        }

        private bool clienteValido()
        {
            double resultado = 0;
            
            // Sacapalabras al txt
            if (string.IsNullOrEmpty(txt_NombreCliente.Text) || txt_NombreCliente.Text == "Agregar nombre del cliente...")
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un nombre", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(txt_NumeroDocumento.Text))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un numero de documento.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if ((txt_NumeroDocumento.Text.Length != 8) && (txt_NumeroDocumento.Text.Length != 11) && (txt_NumeroDocumento.Text.Length != 9))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un numero de documento correcto.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (Double.TryParse(txt_NumeroDocumento.Text, out resultado) == false)
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un numero de documento correcto", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (cboTipoDocumento.SelectedIndex == -1)
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un tipo documento correcto.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            // Validacion Correo
            //if (string.IsNullOrEmpty(txt_Correo.Text))
            //{
            //    frmMessageBox f = new frmMessageBox("Por favor ingrese un correo correcto.", MessageBoxButtons.OK);
            //    f.ShowDialog();
            //    return false;
            //}

            if (cboTipoCliente.SelectedIndex == -1)
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un tipo de cliente correcto.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            //if (string.IsNullOrEmpty(txt_Telefono.Text))
            //{
            //    frmMessageBox f = new frmMessageBox("Por favor ingrese un telefono correcto.", MessageBoxButtons.OK);
            //    f.ShowDialog();
            //    return false;
            //}

            if (txt_Telefono.Text.Length != 9 && txt_Telefono.Text != string.Empty)
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un telefono correcto (9 digitos) o en blanco.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if ((txt_NumeroDocumento.Text.Length == 8) && (cboTipoDocumento.Text != "DNI"))
            {
                frmMessageBox f = new frmMessageBox("RUC (11 digitos), DNI (8 digitos), CARNET EXTRANJERIA (9 digitos)", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if ((txt_NumeroDocumento.Text.Length == 11) && (cboTipoDocumento.Text != "RUC"))
            {
                frmMessageBox f = new frmMessageBox("RUC (11 digitos), DNI (8 digitos), CARNET EXTRANJERIA (9 digitos)", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if ((txt_NumeroDocumento.Text.Length == 9) && (cboTipoDocumento.Text != "CARNET EXTRANJERIA"))
            {
                frmMessageBox f = new frmMessageBox("RUC (11 digitos), DNI (8 digitos), CARNET EXTRANJERIA (9 digitos)", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }


            if ((txt_Telefono.Text != string.Empty) && (!txt_Correo.Text.Contains("@")) && (!txt_Correo.Text.Contains(".")))
            {
                frmMessageBox f = new frmMessageBox("Ingresar un correo correcto.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            return true;
        }

        private void txt_NumeroDocumento_Leave(object sender, EventArgs e)
        {
            double resultado;
            if (Double.TryParse(txt_NumeroDocumento.Text, out resultado) == false)
                return;
            
            // Verificar los digitos del numero de documetno
            if (txt_NumeroDocumento.Text.Length == 8)
                cboTipoDocumento.SelectedIndex = 0;

            if (txt_NumeroDocumento.Text.Length == 11)
                cboTipoDocumento.SelectedIndex = 1;

            if (txt_NumeroDocumento.Text.Length == 9)
                cboTipoDocumento.SelectedIndex = 2;

        }
    }
}
