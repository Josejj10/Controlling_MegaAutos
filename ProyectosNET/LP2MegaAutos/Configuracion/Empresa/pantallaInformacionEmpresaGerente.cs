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
    public partial class pantallaInformacionEmpresaGerente : UserControl
    {
        #region instancia
        private static pantallaInformacionEmpresaGerente _instancia;
        public static pantallaInformacionEmpresaGerente Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaInformacionEmpresaGerente();
                return _instancia;
            }
        }
        #endregion instancia

        public pantallaInformacionEmpresaGerente()
        {
            InitializeComponent();
        }
    }
}
