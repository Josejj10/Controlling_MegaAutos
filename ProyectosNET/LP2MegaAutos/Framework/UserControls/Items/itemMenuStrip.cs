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

namespace LP2MegaAutos.Framework.UserControls.Items
{
    public partial class itemMenuStrip : UserControl
    {
        public itemMenuStrip()
        {
            InitializeComponent();
            tags.SetTagFontSize(btnTexto,12);
            Tipografias.crearFonts(btnTexto,tags);
        }
        
        #region Propiedades
        [Description("Icono que aparece"), Category("Item Menu")]
        public Image Imagen
        {
            get { return btnItem.BackgroundImage;  }
            set { btnItem.BackgroundImage = value; }
        }

        public ImageLayout BackgroundLayout
        {
            set { btnItem.BackgroundImageLayout = value; }
        }
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float FontSize
        {
            get
            {
                return btnTexto.Font.Size;
            }
            set
            {
                tags.SetTagFontSize(btnTexto, value);
            }
        }

        public string Texto
        {
            get
            {
                return btnTexto.Text;
            }
            set
            {
                btnTexto.Text = value;
            }
        }

        #endregion Propiedades

        #region Eventos Delegados
        public delegate void MouseLeaveEventHandler(object sender, EventArgs e);
        public event MouseLeaveEventHandler mouseLeave;

        public delegate void ButtonClickEventHandler(object sender, EventArgs e);
        public event ButtonClickEventHandler click;

        private void btnItem_Leave(object sender, EventArgs e)
        {
            btnTexto.Visible = false;
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
            btnTexto.Size = this.Size;
        }

        private void btnItem_MouseEnter(object sender, EventArgs e)
        {
            btnTexto.Visible = true;
        }

        private void btnTexto_Paint(object sender, PaintEventArgs e)
        {
            Tipografias.crearFonts(btnTexto.Parent, tags);
        }
    }
}
