using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        #region Propiedades
        [Description("Texto Principal"), Category("Item Lista")]
        public string TextoPrincipal
        {
            get { return lblPrincipal.Text; }
            set { lblPrincipal.Text = value; }
        }

        //[Description("Determina que ventana se abrirar al darle click"), Category("Item Lista")]
        //public tipoItem TipoItem
        //{
        //    get { return _tipoItem; }
        //    set { _tipoItem = value; }
        //}


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

        //protected virtual void btnEditar_Click(object sender, EventArgs e)
        //{
        //    switch (_tipoItem)
        //    {
        //        case tipoItem.Cliente:
        //            break;
        //        case tipoItem.Driver:
        //            break;
        //        case tipoItem.Servicio:
        //            break;
        //        case tipoItem.Usuario:
        //            break;
        //        default:
        //            MessageBox.Show("Nada aun");
        //            break;
        //    }
        //}
    }
}



