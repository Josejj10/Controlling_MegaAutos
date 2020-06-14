using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2MegaAutos.Framework.UserControls.Items;

namespace LP2MegaAutos
{
    public partial class itemListaReporte : UserControl
    {
        public itemListaReporte()
        {
            InitializeComponent();
        }

        #region Propiedades
        [Description("Texto Principal"), Category("Item Reporte")]
        public string TextoPrincipal
        {
            get { return lblPrincipal.Text; }
            set { lblPrincipal.Text = value; }
        }


        [Description("Fecha Generado"), Category("Item Reporte")]
        public string FechaGenerado
        {
            get { return lblFecha.Text; }
            set { lblFecha.Text = value; }
        }

        [Description("Que usuario lo generó."), Category("Item Reporte")]
        public string QuienGenero
        {
            get { return lblQuienGenero.Text; }
            set { lblQuienGenero.Text = value; }
        }

        [Description("Monto Total de Ingresos"), Category("Item Reporte")]
        public string MontoIngresos
        {
            get { return lblMontoIngresos.Text; }
            set { lblMontoIngresos.Text = value; }
        }

        [Description("Monto Total de Egresos"), Category("Item Reporte")]
        public string MontoEgresos
        {
            get { return lblMontoEgresos.Text; }
            set { lblMontoEgresos.Text = value; }
        }

        [Description("Monto Total"), Category("Item Reporte")]
        public string MontoTotal
        {
            get { return lblMontoTotal.Text; }
            set { lblMontoTotal.Text = value; }
        }
        
        [Description("Sede del Reporte"), Category("Item Reporte")]
        public string Sede
        {
            get { return lblSede.Text; }
            set { lblSede.Text = value; }
        }

        [Description("Color Borde"), Category("Item Reporte")]
        public Color ColorBorde
        {
            get { return rpItem.getColorBorde(); }
            set { rpItem.cambiarColorBorde(value); }

        }

        [Description("Color Panel"), Category("Item Reporte")]
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

        #region Event Handlers
        public delegate void ButtonClickEventHandler(object sender, EventArgs e);
        public event ButtonClickEventHandler ItemListaClick;
        private void itemLista_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = ItemListaClick;
            if (h != null) h(this, e);
        }
        #endregion

        private void itemLista_MouseEnter(object sender, EventArgs e)
        {
            itemListaHelper.rpItem_MouseEnter(rpItem);
        }

        private void itemLista_MouseLeave(object sender, EventArgs e)
        {
            itemListaHelper.rpItem_MouseLeave(rpItem);
        }
    }
}
