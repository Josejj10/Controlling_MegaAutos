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
    public partial class pantallaEditarServicio : UserControl
    {
        // Singleton instance para poder crearlo en la pantalla menu
        #region instancia
        private static pantallaEditarServicio _instancia;
        public static pantallaEditarServicio Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaEditarServicio();
                return _instancia;
            }
        }
        #endregion instancia


        public pantallaEditarServicio()
        {
            InitializeComponent();
        }

        private void pantallaEditarServicios_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
