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
    public partial class pantallaEditarDriver : UserControl
    {
        // Singleton instance para poder crearlo en la pantalla menu
        #region instancia
        private static pantallaEditarDriver _instancia;
        public static pantallaEditarDriver Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaEditarDriver();
                return _instancia;
            }
        }
        #endregion instancia
        public pantallaEditarDriver()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
