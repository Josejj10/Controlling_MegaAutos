using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2MegaAutos.Reportes;

namespace LP2MegaAutos
{
    public partial class itemListaResumen : UserControl
    {
        private int nItems = 0;
        public itemListaResumen()
        {
            InitializeComponent();
        }

        private bool _cuentasVisibles = false;
        private void lblBtnCuentasContables_Click(object sender, EventArgs e)
        {
            _cuentasVisibles = this.flpCuentasContables.Visible = !_cuentasVisibles;

            if (_cuentasVisibles)
            {
                this.Height += 90 * nItems;
                tlpLista.Height += 90 * nItems;
                flpCuentasContables.Height += 90 * nItems;
                return;
            }
            this.Height -= 90 * nItems;
            tlpLista.Height -= 90 * nItems;
            flpCuentasContables.Height -= 90 * nItems;
        }


        #region Propiedades
        [Description("Nombre de la Cuenta"), Category("Lista Resumen")]
        public string TextoPrincipal
        {
            get { return lblCuentaGrande.Text; }
            set { lblCuentaGrande.Text = value; }
        }


        [Description("Monto Total"), Category("Lista Resumen")]
        public string MontoTotal
        {
            get { return lblTotal.Text; }
            set { lblTotal.Text = value; }
        }

        [Description("Monto Ingresos"), Category("Lista Resumen")]
        public string MontoIngresos
        {
            get { return lblIngresos.Text; }
            set { lblIngresos.Text = value; }
        }

        [Description("Monto Egresos"), Category("Lista Resumen")]
        public string MontoEgresos
        {
            get { return lblEgresos.Text; }
            set { lblEgresos.Text = value; }
        }

        [Description("Cambia el titulo Cuentas Contables."), Category("Lista Resumen")]
        public string CuentasContables
        {
            get { return lblBtnCuentasContables.Text; }
            set { lblBtnCuentasContables.Text = value; }
        }

        [Description("Color del Borde del Subrayado del Titulo"), Category("Lista Resumen")]
        public Color ColorBordeSubrayado
        {
            get { return rpTitulo.getColorBorde(); }
            set { rpTitulo.cambiarColorBorde(value); }

        }

        [Description("Color del Subrayado del Titulo"), Category("Lista Resumen")]
        public Color ColorPanelSubrayado
        {
            get { return rpTitulo.getColorPanel(); }
            set
            {
                rpTitulo.cambiarColorPanel(value);
            }
        }
        #endregion Propiedades

        private itemListaResumenReporte crearItemLista()
        {
            itemListaResumenReporte item = new itemListaResumenReporte();
            item.ColorBack = Color.Transparent;
            item.ColorBorde = Colores.PrincipalIndigo;
            item.ColorPanel = Colores.CasiPuro;
            item.Margin = new Padding(3, 3, 3, 3);
            item.Anchor = AnchorStyles.None;
            item.Name = "itemListaResumenReporte"+ ++nItems;
            item.TabIndex = 5+ nItems;
            return item;
        }

        public void addCuentaContable(string concepto, string monto /* ,ordenTrabajo ot*/)
        {
            if (nItems == 0)
            {
                this.Height +=92;
                rpCuentasContables.Visible = true;
            }
            itemListaResumenReporte item = crearItemLista();
            item.Concepto = concepto;
            item.Monto = monto;
            // TODO Delegar el click
            item.ItemListaClick += (sender, e) => { abrirDetalleOrdentrabajo(sender, e/*.,ot*/); };
            flpCuentasContables.Controls.Add(item);
        }


        private void abrirDetalleOrdentrabajo(Object sender, EventArgs e/*, ordenTrabajo ot*/)
        {
            pantallaOrdenTrabajo frm = new pantallaOrdenTrabajo();
            frm.Show();
        }



    }
}
