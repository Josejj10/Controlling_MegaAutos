using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2MegaAutos.Framework
{
    public static class pantallaListasHelper
    {
        // Helper que sirve para almacenar los metodos de los botones
        // Comunes en las pantallas que listan
        private static bool mouseDown = false;
        private static Color colorInicial = Colores.ChooseAmarillo;
        public static void cambiarCuatroPaneles(RoundedPanel rpElegido,
            RoundedPanel rp2, RoundedPanel rp3, RoundedPanel rp4)
        {
            // Cambiar Color RoundedPanels
            rpElegido.ColorPanel = Colores.ChooseAmarillo;
            rp2.ColorPanel = rp3.ColorPanel =
                rp4.ColorPanel = Colores.FrontBackground;

            // Cambiar Color Botones
            rpElegido.Controls[0].BackColor = Colores.ChooseAmarillo;
            rp2.Controls[0].BackColor =
                rp3.Controls[0].BackColor =
                rp4.Controls[0].BackColor = Color.Transparent;
        }
        public static void cambiarTresPaneles(RoundedPanel rpElegido,
            RoundedPanel rp2, RoundedPanel rp3)
        {
            // Cambiar Color RoundedPanels
            rpElegido.ColorPanel = Colores.ChooseAmarillo;
            rp2.ColorPanel = rp3.ColorPanel = Colores.FrontBackground;

            // Cambiar Color Botones
            rpElegido.Controls[0].BackColor = Colores.ChooseAmarillo;
            rp2.Controls[0].BackColor =
                rp3.Controls[0].BackColor = Color.Transparent;
        }

        public static void buscarEnter(TextBox txt_Buscar, string datoBuscar = "")
        {
            if (txt_Buscar.Text == "Buscar" + datoBuscar)
                txt_Buscar.Text = string.Empty;
        }
        public static void buscarLeave(TextBox txt_Buscar, string datoBuscar = "")
        {
            if (txt_Buscar.Text == string.Empty)
                txt_Buscar.Text = "Buscar"+datoBuscar;
        }

        public static void btn_MouseDown(Button btn)
        {
            colorInicial = btn.BackColor;
            btn.BackColor = Colores.AmarilloHover;
            ((RoundedPanel)btn.Parent).ColorPanel = Colores.AmarilloHover;
            mouseDown = true;

        }

        public static void btn_MouseUp(Button btn)
        {
            if (!mouseDown) return;
            btn.BackColor = Colores.ChooseAmarillo;
            ((RoundedPanel)btn.Parent).ColorPanel = Colores.ChooseAmarillo;
            mouseDown = false;
        }
        
        public static void btn_MouseMove(Button btn)
        {
            if (!btn.ClientRectangle.Contains
                (btn.PointToClient(Cursor.Position))&& mouseDown)
                btn_VolverInicial(btn);
        }

        private static void btn_VolverInicial(Button btn)
        {
            btn.BackColor = colorInicial;
            ((RoundedPanel)btn.Parent).ColorPanel = colorInicial;
            mouseDown = false;
        }


    }
}
