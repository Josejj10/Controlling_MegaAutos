using System;
using System.Drawing;
using System.Windows.Forms;


namespace LP2MegaAutos.Framework.UserControls.Items
{
    public static class itemListaHelper
    {
        public static void rpItem_MouseEnter(RoundedPanel rpItem)
        {
            cambiarColores(rpItem, Colores.FrontBackground);
            rpItem.ColorPanel = Colores.FrontBackground;
        }

        public static void rpItem_MouseLeave(RoundedPanel rpItem)
        {
            cambiarColores(rpItem, Colores.BackBackground);
            rpItem.ColorPanel = Colores.BackBackground;
        }

        private static void cambiarColores(Control parent, Color color)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Controls != null) cambiarColores(c, color);
                c.BackColor = color;
            }
        }
    }
}
