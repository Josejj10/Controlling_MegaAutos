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
        }

        private void enableOrDisableButtons()
        {
            this.itemMenuStrip1.Enabled = false;
            this.itemMenuStrip2.Enabled = false;
            this.itemMenuStrip3.Enabled = false;
            this.itemMenuStrip4.Enabled = false;
            this.itemMenuStrip1.Visible= false;
            this.itemMenuStrip2.Visible = false;
            this.itemMenuStrip3.Visible = false;
            this.itemMenuStrip4.Visible = false;

            if (_numItems > 3)
            {
                this.itemMenuStrip4.Visible = true;
                this.itemMenuStrip4.Enabled= true;
            }
            if (_numItems > 2)
            {
                this.itemMenuStrip3.Visible = true;
                this.itemMenuStrip3.Enabled= true;
            }
            if (_numItems > 1)
            {
                this.itemMenuStrip2.Visible = true;
                this.itemMenuStrip2.Enabled= true;
            }
            if (_numItems > 0)
            {
                this.itemMenuStrip1.Visible = true;
                this.itemMenuStrip1.Enabled = true;
            }
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
                this.Size = new Size(52 * _numItems, 52);
                enableOrDisableButtons();
            }

        }

        [Description("Imagen Item 1"), Category("PanelMenuStrip")]
        public Image Imagen1
        {
            get { return this.itemMenuStrip1.BackgroundImage; }
            set { this.itemMenuStrip1.BackgroundImage = value; }
        }

        [Description("Imagen Item 2"), Category("PanelMenuStrip")]
        public Image Imagen2
        {
            get { return this.itemMenuStrip2.BackgroundImage; }
            set { this.itemMenuStrip2.BackgroundImage = value; }
        }

        [Description("Imagen Item 3"), Category("PanelMenuStrip")]
        public Image Imagen3
        {
            get { return this.itemMenuStrip3.BackgroundImage; }
            set { this.itemMenuStrip3.BackgroundImage = value; }
        }

        [Description("Imagen Item 4"), Category("PanelMenuStrip")]
        public Image Imagen4
        {
            get { return this.itemMenuStrip4.BackgroundImage; }
            set { this.itemMenuStrip4.BackgroundImage = value; }
        }
    }
    #endregion Propiedades
}

