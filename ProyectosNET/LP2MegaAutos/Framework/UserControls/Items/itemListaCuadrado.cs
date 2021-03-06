﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2MegaAutos.Framework.UserControls.Items;

namespace LP2MegaAutos
{
    public partial class itemListaCuadrado : UserControl
    {
        private bool _seleccionado;

        public itemListaCuadrado()
        {
            InitializeComponent();
        }
        #region Propiedades
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

        public bool Seleccionado{
            get
            {
                return this._seleccionado;
            }
            set {
                _seleccionado = value;
                cambiarColores();
            }
        }

        #endregion Propiedades

        private void cambiarColores()
        {
            rpItem.ColorPanel = lblTexto.BackColor = tlpTexto.BackColor =
                pnlImg.BackColor = _seleccionado ? Colores.AmarilloInteractivo : Colores.FrontBackground;
            lblTexto.ForeColor = _seleccionado ? Colores.FrontBackground : Colores.MediumContrast;
        }


        #region Event Handlers

        public delegate void ButtonClickEventHandler(object sender, EventArgs e);
        public event ButtonClickEventHandler ItemListaClick;

        private void itemLista_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = ItemListaClick;
            if (h != null) h(this, e);
        }

        #endregion Event Handlers


        private void rpItem_MouseEnter(object sender, EventArgs e)
        {
            itemListaHelper.rpItem_MouseEnter(rpItem);
            lblTexto.ForeColor = !_seleccionado ? Colores.FrontBackground : Colores.MediumContrast;
        }

        private void roundedPanel1_MouseLeave(object sender, EventArgs e)
        {
            
            cambiarColores();
        }
    }
}
