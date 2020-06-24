using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2MegaAutos.Framework.UserControls.Items;

public enum tipoItem
{
    Driver,
    Usuario,
    Cliente,
    Servicio
}

namespace LP2MegaAutos
{
    public partial class itemLista : UserControl
    {

        //private tipoItem _tipoItem;
        public itemLista()
        {
            InitializeComponent();
            
        }

        public void esconderBotonEditar()
        {
            this.btnEditar.Visible = false;
        }

        #region Propiedades
        [Description("Texto Principal"), Category("Item Lista")]
        public string TextoPrincipal
        {
            get { return lblPrincipal.Text; }
            set { lblPrincipal.Text = value; }
        }


        [Description("Texto Secundario"), Category("Item Lista")]
        public string Textosecundario
        {
            get { return lblSecundario.Text; }
            set { lblSecundario.Text = value; }
        }

        [Description("Texto Tercero"), Category("Item Lista")]
        public string TextoTercero
        {
            get { return lblTercerDato.Text; }
            set { lblTercerDato.Text = value; }
        }

        [Description("Texto Fecha"), Category("Item Lista")]
        public string TextoFecha
        {
            get { return lblFecha.Text; }
            set { lblFecha.Text = value; }
        }

        [Description("Texto Agregado Por"), Category("Item Lista")]
        public string TextoAgregadoPor
        {
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }
        }

        [Description("Color Borde Panel"), Category("Item Lista")]
        public Color ColorBorde
        {
            get { return rpItem.getColorBorde(); }
            set { rpItem.cambiarColorBorde(value); }

        }

        [Description("Color Panel"), Category("Item Lista")]
        public Color ColorPanel
        {
            get{ return rpItem.getColorPanel();}
            set { 
                rpItem.cambiarColorPanel(value);
                foreach (Control c in rpItem.Controls)
                    c.BackColor = value;
            }
        }
        [Description("Color Back"), Category("Item Lista")]
        public Color ColorBack
        {
            get { return rpItem.BackColor; }
            set { rpItem.BackColor = value; }
        }
        #endregion Propiedades


        #region Event Handlers
        // Para delegar el evento de Click al form que lo llamó,
        // Se tiene que suscribir de manera: itemLista2.EditarClick+= btnEditarClick;
        // Cuando se inserte  el itemLista (en el constructor si no se inserta de manera dinámica)
        // https://stackoverflow.com/questions/4430523/how-do-i-subscribe-to-an-event-of-a-usercontrol
        // Agradecido con el de arriba
        public delegate void ButtonClickEventHandler(object sender, EventArgs e);
        public event ButtonClickEventHandler ItemListaClick;
        public event ButtonClickEventHandler EditarClick;

        private void itemLista_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = ItemListaClick;
            if (h != null) h(this, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = EditarClick;
            if (h != null) h(this, e);
        }
        #endregion Event Handlers
        
        private void rpItem_MouseEnter(object sender, EventArgs e)
        {
            itemListaHelper.rpItem_MouseEnter(rpItem);
        }

        private void rpItem_MouseLeave(object sender, EventArgs e)
        {
            itemListaHelper.rpItem_MouseLeave(rpItem);
        }


        private void cambiarColores(Control parent, Color color)
        {
            foreach (Control c in parent.Controls)
            {   
                if (c.Controls != null) cambiarColores(c,color);
                c.BackColor = color;
            }
        }
    }
}



