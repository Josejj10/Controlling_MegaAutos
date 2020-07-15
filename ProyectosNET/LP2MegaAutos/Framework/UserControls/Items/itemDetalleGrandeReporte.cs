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
    public partial class itemDetalleGrandeReporte : UserControl
    {
        public itemDetalleGrandeReporte()
        {
            InitializeComponent();
        }

        #region Propiedades
        [Description("Las letras mas grandes."), Category("Item Detalle")]
        public string CuentaGrande
        {
            get { return lblCuentaGrande.Text; }
            set { lblCuentaGrande.Text = value; }
        }


        [Description("Las letras abajo de las grandes."), Category("Item Detalle")]
        public string TipoCuenta
        {
            get { return lblTipoCuenta.Text; }
            set { lblTipoCuenta.Text = value; }
        }

        [Description("Ingreso de hasta 9 digitos aparte de los dos decimales."), Category("Item Detalle")]
        public string Ingreso
        {
            get { return lblIngreso.Text; }
            set { lblIngreso.Text = value; }
        }

        [Description("Egreso de hasta 9 digitos aparte de los dos decimales."), Category("Item Detalle")]
        public string Egreso
        {
            get { return lblEgreso.Text; }
            set { lblEgreso.Text = value; }
        }

        [Description("Monto Total de hasta 9 digitos aparte de los dos decimales."), Category("Item Detalle")]
        public string MontoTotal
        {
            get { return lblTotal.Text; }
            set { lblTotal.Text = value; }
        }

        #endregion Propiedades

    }
}
