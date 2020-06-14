using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2MegaAutos.VentanasPrincipales
{
    public partial class Pantalla : UserControl
    {
        public bool DarkModeActive { get; set; }
        public Pantalla()
        {
            InitializeComponent();
            DarkModeActive = false;
        }


    }
}
