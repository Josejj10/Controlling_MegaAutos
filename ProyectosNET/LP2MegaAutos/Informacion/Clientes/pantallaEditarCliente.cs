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
        }

        public pantallaEditarCliente(ServicioCliente.cliente cliente)
        {
            InitializeComponent();
            _cliente = cliente;
            toggleComponentes();
            this.txt_NombreCliente.Text = OtrosHelper.tipoOracion(cliente.nombre);
            this.txt_NumeroDocumento.Text = OtrosHelper.tipoOracion(cliente.numDocumento);
            this.txt_TIpoDocumento.Text = OtrosHelper.tipoOracion(cliente.tipoCliente);
            this.txt_Telefono.Text = OtrosHelper.tipoOracion(cliente.telefono);
            this.txt_Correo.Text = OtrosHelper.tipoOracion(cliente.correo);
            this.txtTipoCliente.Text = OtrosHelper.tipoOracion(cliente.tipoCliente);

        }

        private void txt_NombreCliente_Enter(object sender, EventArgs e)
        {
            if (txt_NombreCliente.Text == "Agregar nombre de cliente...")
                txt_NombreCliente.Text = string.Empty;
            txt_NombreCliente.ForeColor = Colores.HighContrast;
        }

        private void txt_NombreCliente_Leave(object sender, EventArgs e)
        {
            if(txt_NombreCliente.Text == string.Empty)
            {
                txt_NombreCliente.ForeColor = Colores.LowContrast;
                txt_NombreCliente.Text = "Agregar nombre de cliente...";
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
            _cliente.numDocumento = txt_NumeroDocumento.Text;
            _cliente.tipoDocumento = txt_TIpoDocumento.Text;
            _cliente.telefono = txt_Telefono.Text;
            _cliente.correo = txt_Correo.Text;
            _cliente.tipoCliente = txtTipoCliente.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void pantallaEditarCliente_Load(object sender, EventArgs e)
        {

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
            _cliente.tipoDocumento = txt_TIpoDocumento.Text;
            _cliente.telefono = txt_Telefono.Text;
            _cliente.correo = txt_Correo.Text;
            _cliente.tipoCliente = txtTipoCliente.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            toggleComponentes();
        }

        private void toggleComponentes()
        {
            bool en = txt_NombreCliente.Enabled = txt_NumeroDocumento.Enabled =
                txt_TIpoDocumento.Enabled = txt_Telefono.Enabled = 
                txtTipoCliente.Enabled = btn_guardar.Enabled
                = !txt_NombreCliente.Enabled;

            
            // TODO TIPO DOC DISABLED (DEPENDE D LA CANTIDAD DE DIGITOS EN NUM DOC

            if (!en)
            {
                // No habilitado
                txt_NombreCliente.BackColor = txt_NumeroDocumento.BackColor =
                    txt_TIpoDocumento.BackColor = txt_Telefono.BackColor = txt_Correo.BackColor = txtTipoCliente.BackColor = Colores.FrontBackground;

                txt_NombreCliente.ForeColor = txt_NumeroDocumento.ForeColor =
                    txt_TIpoDocumento.ForeColor = txt_Telefono.ForeColor =
                    txt_Correo.ForeColor = txtTipoCliente.ForeColor =
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
               txt_TIpoDocumento.ForeColor = txt_Telefono.ForeColor =
               txt_Correo.ForeColor = txtTipoCliente.ForeColor = 
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

            btnEditar.BackgroundImage = Resources.Logout;
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
            bool isDouble = false;
            isDouble = Double.TryParse(txt_NumeroDocumento.Text, out resultado);

            // Sacapalabras al txt
            if (string.IsNullOrEmpty(txt_NombreCliente.Text))
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

            if ((txt_NumeroDocumento.Text.Length != 8) || (txt_NumeroDocumento.Text.Length != 10))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un numero de documento correcto.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (isDouble == false)
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un numero de documento correcto", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(txt_TIpoDocumento.Text))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un tipo documento correcto.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(txt_Correo.Text))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un correo correcto.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(txtTipoCliente.Text))
            {
                frmMessageBox f = new frmMessageBox("Por favor ingrese un tipo de cliente correcto.", MessageBoxButtons.OK);
                f.ShowDialog();
                return false;
            }

            return true;
        }

    }
}
