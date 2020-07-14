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
    public partial class itemListaResumenReporte : UserControl
    {
        public itemListaResumenReporte()
        {
            InitializeComponent();
        }

        #region Propiedades
        [Description("Concepto del Item"), Category("Item Lista")]
        public string Concepto
        {
            get { return lblConcepto.Text; }
            set { lblConcepto.Text = value; }
        }


        [Description("Monto del Concepto, hasta 9 digitos sin incluir dos decimales."), Category("Item Lista")]
        public string Monto
        {
            get { return lblMonto.Text; }
            set { lblMonto.Text = value; }
        }

        [Description("Color Borde Panel"), Category("Item Lista")]
        public Color ColorBorde
        {
            get { return rpItem.getColorBorde(); }
            set { rpItem.cambiarColorBorde(value); }

        }

        [Description("Color Panel"), Category("Item Lista")]
        public Color ColorPanel
        {
            get { return rpItem.getColorPanel(); }
            set
            {
                rpItem.cambiarColorPanel(value);
                foreach (Control c in rpItem.Controls)
                    c.BackColor = value;
            }
        }
        [Description("Color Back"), Category("Item Lista")]
        public Color ColorBack
        {
            get { return rpItem.BackColor; }
            set { rpItem.BackColor = value; }
        }
        #endregion Propiedades

        // Delegar click
        public delegate void ButtonClickEventHandler(object sender, EventArgs e);
        public event ButtonClickEventHandler ItemListaClick;

        private void itemLista_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = ItemListaClick;
            if (h != null) h(this, e);
        }

    }
}
