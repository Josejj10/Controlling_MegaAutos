using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2MegaAutos
{
    public partial class itemListaResumen : UserControl
    {
        public itemListaResumen()
        {
            InitializeComponent();
        }

        private bool _cuentasVisibles = false;
        private void lblBtnCuentasContables_Click(object sender, EventArgs e)
        {
            this.flpCuentasContables.Visible = !_cuentasVisibles;
            _cuentasVisibles = !_cuentasVisibles;
        }


        #region Propiedades
        [Description("Nombre de la Cuenta"), Category("Lista Resumen")]
        public string TextoPrincipal
        {
            get { return lblCuentaGrande.Text; }
            set { lblCuentaGrande.Text = value; }
        }


        [Description("Monto Total"), Category("Lista Resumen")]
        public string MontoTotal
        {
            get { return lblTotal.Text; }
            set { lblTotal.Text = value; }
        }

        [Description("Monto Ingresos"), Category("Lista Resumen")]
        public string TextoTercero
        {
            get { return lblIngresos.Text; }
            set { lblIngresos.Text = value; }
        }

        [Description("Monto Egresos"), Category("Lista Resumen")]
        public string TextoFecha
        {
            get { return lblEgresos.Text; }
            set { lblEgresos.Text = value; }
        }

        [Description("Cambia el titulo Cuentas Contables."), Category("Lista Resumen")]
        public string CuentasContables
        {
            get { return lblBtnCuentasContables.Text; }
            set { lblBtnCuentasContables.Text = value; }
        }

        [Description("Color del Borde del Subrayado del Titulo"), Category("Lista Resumen")]
        public Color ColorBordeSubrayado
        {
            get { return rpTitulo.getColorBorde(); }
            set { rpTitulo.cambiarColorBorde(value); }

        }

        [Description("Color del Subrayado del Titulo"), Category("Lista Resumen")]
        public Color ColorPanelSubrayado
        {
            get { return rpTitulo.getColorPanel(); }
            set
            {
                rpTitulo.cambiarColorPanel(value);
            }
        }
        #endregion Propiedades


    }
}
