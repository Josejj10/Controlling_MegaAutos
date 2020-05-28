﻿using System;
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
    public partial class itemListaCuadrado : UserControl
    {
        public itemListaCuadrado()
        {
            InitializeComponent();
        }

        [Description("Texto Principal"), Category("Item Lista Cuadrado")]
        public string TextoPrincipal
        {
            get { return lblTexto.Text; }
            set { lblTexto.Text = value; }
        }

        [Description("Imagen"), Category("Item Lista Cuadrado")]
        public Image imgFondo
        {
            get { return pnlImg.BackgroundImage; }
            set { pnlImg.BackgroundImage = value; }
        }
    }
}
