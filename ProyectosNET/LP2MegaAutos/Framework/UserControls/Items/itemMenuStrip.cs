using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Threading;

namespace LP2MegaAutos.Framework.UserControls.Items
{
    public partial class itemMenuStrip : UserControl
    {
        public itemMenuStrip()
        {
            InitializeComponent();
        }

        #region Propiedades
        [Description("Icono que aparece"), Category("Item Menu")]
        public Image Imagen
        {
            get { return btnItem.BackgroundImage;  }
            set { _imagen = value; btnItem.BackgroundImage = _imagen; }
        }
        public ImageLayout BackgroundLayout
        {
            set { btnItem.BackgroundImageLayout = value; }
        }
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Texto
        {
            get
            {
                return _texto;
            }
            set
            {
                _texto = value;
                FontSize = nuevoFontSize(this.CreateGraphics());
            }
        }
        public Image _imagen;
        public string _texto = "";
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float FontSize
        {
            get
            {
                return btnItem.Font.Size;
            }
            set
            {
                tags.SetTagFontSize(btnItem, value);
                Tipografias.crearFonts(btnItem.Parent, tags);
            }
        }


        #endregion Propiedades

        #region Eventos Delegados
        public delegate void MouseLeaveEventHandler(object sender, EventArgs e);
        public event MouseLeaveEventHandler mouseLeave;

        public delegate void ButtonClickEventHandler(object sender, EventArgs e);
        public event ButtonClickEventHandler click;
        public int i = 0;
        private void btnItem_Leave(object sender, EventArgs e)
        {
            // Cambiar Texto por Imagen
            btnItem.BackgroundImage = _imagen;
            btnItem.Text = "";
            MouseLeaveEventHandler h = mouseLeave;
            if (h != null) h(this, e);
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = click;
            if (h != null) h(this, e);
        }

        #endregion Eventos Delegados
        private void itemMenuStrip_SizeChanged(object sender, EventArgs e)
        {
            btnItem.Size = this.Size;
        }

        private void btnItem_MouseEnter(object sender, EventArgs e)
        {
            // Cambiar Imagen por Texto
            btnItem.BackgroundImage = null;
            btnItem.Text = Texto;
        }
        
        private float nuevoFontSize(Graphics graphics)
        {
            SizeF stringSize = graphics.MeasureString(_texto, btnItem.Font);
            float wRatio = btnItem.Width / stringSize.Width;
            float hRatio = btnItem.Height / stringSize.Height;
            float ratio = Math.Min(hRatio, wRatio);
            return btnItem.Font.Size * ratio;
        }

    }
}
