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
    public partial class pantallaEditarServicios : UserControl
    {
        // Singleton instance para poder crearlo en la pantalla menu
        #region instancia
        private static pantallaEditarServicios _instancia;
        public static pantallaEditarServicios Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaEditarServicios();
                return _instancia;
            }
        }
        #endregion instancia


        public pantallaEditarServicios()
        {
            InitializeComponent();
        }
    }
}
