using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2MegaAutos.Framework.UserControls
{
    public partial class PanelMenuStrip : UserControl
    {
        private int _numItems = 4;
        public PanelMenuStrip()
        {
            InitializeComponent();
            suscribirEventos();
        }

        public PanelMenuStrip(int numItems)
        {
            InitializeComponent();
            this.NumItems = numItems;
            suscribirEventos();
        }

        private void suscribirEventos()
        {
            itemMenuStrip1.mouseLeave += itemMenuStrip_MouseLeave;
            itemMenuStrip2.mouseLeave += itemMenuStrip_MouseLeave;
            itemMenuStrip3.mouseLeave += itemMenuStrip_MouseLeave;
            itemMenuStrip4.mouseLeave += itemMenuStrip_MouseLeave;
            itemMenuStrip1.click += itemMenuStrip1_Click;
            itemMenuStrip2.click += itemMenuStrip2_Click;
            itemMenuStrip3.click += itemMenuStrip3_Click;
            itemMenuStrip4.click += itemMenuStrip4_Click;
        }

        private void enableOrDisableButtons()
        {
            this.itemMenuStrip1.Visible= false;
            this.itemMenuStrip2.Visible = false;
            this.itemMenuStrip3.Visible = false;
            this.itemMenuStrip4.Visible = false;

            if (_numItems > 3) this.itemMenuStrip4.Visible = true;
            if (_numItems > 2) this.itemMenuStrip3.Visible = true;
            if (_numItems > 1) this.itemMenuStrip2.Visible = true;
            if (_numItems > 0) this.itemMenuStrip1.Visible = true;
        }

        #region Propiedades
        [Description("Numero de Items"), Category("PanelMenuStrip")]
        public int NumItems
        {
            get { return this._numItems; }
            set
            {
                this._numItems = value;
                // Modificar el tamaño para que muestre solo x items
                // Cada item mide 52 x 52
                // 205 max
                // 52 > 52+51
                // 51 en vez de 52 por el borde
                this.Size = new Size(52 + 51 *(_numItems-1), 52);
                enableOrDisableButtons();
            }

        }

        [Description("Imagen Item 1"), Category("PanelMenuStrip")]
        public Image Imagen1
        {
            get { return this.itemMenuStrip1.Imagen; }
            set { this.itemMenuStrip1.Imagen = value; }
        }

        [Description("Imagen Item 2"), Category("PanelMenuStrip")]
        public Image Imagen2
        {
            get { return this.itemMenuStrip2.Imagen; }
            set { this.itemMenuStrip2.Imagen = value; }
        }

        [Description("Imagen Item 3"), Category("PanelMenuStrip")]
        public Image Imagen3
        {
            get { return this.itemMenuStrip3.Imagen; }
            set { this.itemMenuStrip3.Imagen = value; }
        }

        [Description("Imagen Item 4"), Category("PanelMenuStrip")]
        public Image Imagen4
        {
            get { return this.itemMenuStrip4.Imagen; }
            set { this.itemMenuStrip4.Imagen = value; }
        }

        public ImageLayout LayoutImagenes
        {
            set {
                itemMenuStrip1.BackgroundLayout = 
                    itemMenuStrip2.BackgroundLayout = 
                    itemMenuStrip3.BackgroundLayout =
                    itemMenuStrip4.BackgroundLayout = value;
            }
        }

        #endregion Propiedades

        #region Delegar Clicks
        public delegate void ButtonClickEventHandler(object sender, EventArgs e);
        public event ButtonClickEventHandler item1Click, item2Click, item3Click, item4Click;
        private void itemMenuStrip1_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = item1Click;
            if (h != null) h(this, e);
        }

        private void itemMenuStrip2_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = item2Click;
            if (h != null) h(this, e);
        }

        private void itemMenuStrip3_Click(object sender, EventArgs e)
        {

            ButtonClickEventHandler h = item3Click;
            if (h != null) h(this, e);
        }

        private void itemMenuStrip4_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = item4Click;
            if (h != null) h(this, e);
        }
        #endregion Delegar Clicks
        
        // Desaparece al salir
        private void itemMenuStrip_MouseLeave(object sender, EventArgs e)
            {
            if (itemMenuStrip1.ClientRectangle.Contains
                (itemMenuStrip1.PointToClient(Cursor.Position))){
                return;
            }
            if (_numItems > 1 && itemMenuStrip2.ClientRectangle.Contains
                (itemMenuStrip2.PointToClient(Cursor.Position))){
                return;
            }
            if (_numItems > 2 && itemMenuStrip3.ClientRectangle.Contains
                (itemMenuStrip3.PointToClient(Cursor.Position))){
                return;
            }
            if (_numItems > 3 && itemMenuStrip4.ClientRectangle.Contains
                (itemMenuStrip4.PointToClient(Cursor.Position))){
                return;
            }
            this.Visible = false;
        }

    }
}

