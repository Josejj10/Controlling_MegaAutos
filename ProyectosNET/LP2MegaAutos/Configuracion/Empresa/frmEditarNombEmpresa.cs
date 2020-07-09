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

namespace LP2MegaAutos.Configuracion.Empresa
{
    public partial class frmEditarNombEmpresa : MetroForm
    {
        private string nuevoNombre;

        public string NuevoNombre { get => nuevoNombre; }


        public frmEditarNombEmpresa()
        {
            InitializeComponent();
        }

        public frmEditarNombEmpresa(ServicioEmpresa.empresa empresa)
        {
            InitializeComponent();
            this.txt_nombEmpresa.Text = nuevoNombre = empresa.nombre;
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // TODO actualizar nombre de la empresa
            // this.nuevoNombre = nuevoNombre de la empresa q devuelve el dao 
            frmMessageBox confirmar = new frmMessageBox(
                $"¿Desea cambiar el nombre de la empresa a {nuevoNombre}?",MessageBoxButtons.OKCancel , "Advertencia",true);
            if (confirmar.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
            confirmar = new frmMessageBox(
                "No se realizo ningún cambio.", MessageBoxButtons.OK);
            confirmar.ShowDialog();
        }

    }
}
