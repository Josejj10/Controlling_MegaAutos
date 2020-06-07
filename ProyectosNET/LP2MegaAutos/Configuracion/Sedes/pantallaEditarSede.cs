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
    public partial class pantallaEditarSede : UserControl
    {
        // Singleton instance para poder crearlo en la pantalla menu
        #region instancia
        private static pantallaEditarSede _instancia;
        public static pantallaEditarSede Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaEditarSede();
                return _instancia;
            }
        }
        #endregion instancia

        public pantallaEditarSede()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
