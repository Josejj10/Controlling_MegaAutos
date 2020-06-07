using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            set { btnItem.BackgroundImage = value; }
        }
        #endregion Propiedades
    }
}
