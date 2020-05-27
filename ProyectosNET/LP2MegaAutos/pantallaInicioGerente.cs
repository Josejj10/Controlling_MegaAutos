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
    public partial class pantallaInicioGerente : UserControl
    {
        // Singleton instance para poder crearlo en la pantalla menu
        #region instancia
        private static pantallaInicioGerente _instancia;
        public static pantallaInicioGerente Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaInicioGerente();
                return _instancia;
            }
        }
        #endregion instancia

        public pantallaInicioGerente()
        {
            InitializeComponent();
        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }
    }
}
