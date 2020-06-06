using ShadowPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2MegaAutos
{

    public class White_Mode
    {
        // Contrast
        public static Color HighContrast = Color.FromArgb(26, 37, 50);
        public static Color MediumContrast = Color.FromArgb(80, 80, 80);
        public static Color LowContrast = Color.FromArgb(142, 142, 147);

        // Background
        public static Color BackBackground = Color.FromArgb(245, 245, 246);
        public static Color FrontBackground = Color.FromArgb(255, 255, 255);

        // Coloridos
        public static Color Disabled = Color.FromArgb(189, 189, 189);
        public static Color PrincipalRojo = Color.FromArgb(229, 65, 33);
        public static Color PrincipalAzulMetalico = Color.FromArgb(54, 140, 161);

        // Forms
        public static Color FormText = Color.FromArgb(81, 81, 81);
        public static Color FormBackground = Color.FromArgb(244, 244, 245);
        public static Color FormShape = Color.FromArgb(112, 112, 112);
        public static Color ChooseAmarillo = Color.FromArgb(247,199,44);
    }

    public class Dark_Mode
    {
        // Contrast
        public static Color HighContrast = Color.FromArgb(245, 245, 246);
        public static Color MediumContrast = Color.FromArgb(180, 180, 180);
        public static Color LowContrast = Color.FromArgb(130, 130, 130);

        // Background
        public static Color BackBackground = Color.FromArgb(18, 18, 18);
        public static Color FrontBackground = Color.FromArgb(26, 37, 50);

        // Coloridos
        public static Color Disabled = Color.FromArgb(119, 119, 119);
        public static Color PrincipalRojo = Color.FromArgb(226, 47, 11);
        public static Color PrincipalAzulMetalico = Color.FromArgb(16, 133, 161);

        // Forms
        public static Color FormText = Color.FromArgb(181, 181, 181);
        public static Color FormBackground = Color.FromArgb(64, 64, 69);
        public static Color FormShape = Color.FromArgb(99, 99, 102);
        public static Color ChooseAmarillo = Color.FromArgb(250,220,123);

    }


    public class Colores : White_Mode
    {
        #region Denotive Colors
        public static Color Rosa = Color.FromArgb(227, 64, 94);
        public static Color Morado = Color.FromArgb(174, 32, 226);
        public static Color VerdeSuccess = Color.FromArgb(152, 212, 73);
        public static Color AmarilloInteractivo = Color.FromArgb(247, 199, 45);
        public static Color AmarilloInteractivoMas1 = Color.FromArgb(247, 178, 83);
        public static Color AmarilloInteractivoMas2 = Color.FromArgb(247, 161, 45);
        public static Color AmarilloInteractivoMenos1 = Color.FromArgb(249, 215, 103);
        public static Color AmarilloInteractivoMenos2 = Color.FromArgb(250, 220, 124);
        public static Color PrincipalIndigo = Color.FromArgb(79, 191, 209);
        public static Color AmarilloHover = Color.FromArgb(222, 179, 40);
        public static Color AmarilloClick = Color.FromArgb(222, 159, 40);
        public static Color ClickableTextDefault = Rosa;
        public static Color ClickableTextEnter = Color.FromArgb(191, 90, 108);
        public static Color ClickableTextDown = Color.FromArgb(181, 51, 74);
       

        #endregion Denotive Colors

        public static Color opuesto(Color color)
        {
            int c = color.ToArgb();
            if (DarkMode.is_dark_mode_active())
            {
                // Cambiar de Dark Mode a White Mode
                if (c == Dark_Mode.HighContrast.ToArgb()) color = White_Mode.HighContrast;
                if (c == Dark_Mode.MediumContrast.ToArgb()) color = White_Mode.MediumContrast;
                if (c == Dark_Mode.LowContrast.ToArgb()) color = White_Mode.LowContrast;

                if (c == Dark_Mode.BackBackground.ToArgb()) color = White_Mode.BackBackground;
                if (c == Dark_Mode.FrontBackground.ToArgb()) color = White_Mode.FrontBackground;

                if (c == Dark_Mode.Disabled.ToArgb()) color = White_Mode.Disabled;
                if (c == Dark_Mode.PrincipalRojo.ToArgb()) color = White_Mode.PrincipalRojo;
                if (c == Dark_Mode.PrincipalAzulMetalico.ToArgb()) color = White_Mode.PrincipalAzulMetalico;
                if (c == Dark_Mode.FormText.ToArgb()) color = White_Mode.FormText;
                if (c == Dark_Mode.FormBackground.ToArgb()) color = White_Mode.FormBackground;
                if (c == Dark_Mode.FormShape.ToArgb()) color = White_Mode.FormShape;
                if (c == Dark_Mode.ChooseAmarillo.ToArgb()) color = White_Mode.ChooseAmarillo;

                return color;
            }

            // Si no, cambiar de White Mode a Dark Mode
            if (c == White_Mode.HighContrast.ToArgb()) color = Dark_Mode.HighContrast;
            if (c == White_Mode.MediumContrast.ToArgb()) color = Dark_Mode.MediumContrast;
            if (c == White_Mode.LowContrast.ToArgb()) color = Dark_Mode.LowContrast;

            if (c == White_Mode.BackBackground.ToArgb()) color = Dark_Mode.BackBackground;
            if (c == White_Mode.FrontBackground.ToArgb()) color = Dark_Mode.FrontBackground;

            if (c == White_Mode.Disabled.ToArgb()) color = Dark_Mode.Disabled;
            if (c == White_Mode.PrincipalRojo.ToArgb()) color = Dark_Mode.PrincipalRojo;
            if (c == White_Mode.PrincipalAzulMetalico.ToArgb()) color = Dark_Mode.PrincipalAzulMetalico;

            if (c == White_Mode.FormText.ToArgb()) color = Dark_Mode.FormText;
            
            if (c == White_Mode.FormBackground.ToArgb()) color = Dark_Mode.FormBackground;
            if (c == White_Mode.FormShape.ToArgb()) color = Dark_Mode.FormShape;
            if (c == White_Mode.ChooseAmarillo.ToArgb()) color = Dark_Mode.ChooseAmarillo;

            return color;
        }

        public static void cambiarToggle(Button c)
        {
            // Cambiar BackColor, MouseDownBack ,MouseOverBack a Azul DM
            if (DarkMode.is_dark_mode_active())
            {
                c.FlatAppearance.MouseOverBackColor = White_Mode.LowContrast;
                c.FlatAppearance.MouseDownBackColor = White_Mode.LowContrast;
                c.BackColor = White_Mode.LowContrast;
                return;
            }
            // Si no, cambiar a azul de Dark Mode
            c.FlatAppearance.MouseOverBackColor = Dark_Mode.PrincipalAzulMetalico;
            c.FlatAppearance.MouseDownBackColor = Dark_Mode.PrincipalAzulMetalico;
            c.BackColor = Dark_Mode.PrincipalAzulMetalico;
        }

        public static void cambiarColor(Control c)
        {
            cambiarBackColor(c);
            cambiarForeColor(c);
            if (c.GetType() == typeof(Button))
            {
                cambiarFlatAppearanceBackColor((Button)c);
                cambiarFlatAppearanceOverColor((Button)c);
            }
            if (c.GetType() == typeof(ShadowPanelRight))
                cambiarShadowPanelColor((ShadowPanelRight)c);

            if (c.GetType() == typeof(ShadowPanelRight))
                cambiarShadowPanelColor((ShadowPanelRight)c);

        }

        public static void cambiarBackColor(Control c)
        {
            Console.WriteLine("Back: " + c.BackColor + " " + c.Name + "  ===>  " + opuesto(c.BackColor));
            c.BackColor = opuesto(c.BackColor);
        }

        public static void cambiarForeColor(Control c)
        {
            Console.WriteLine("Fore: " + c.ForeColor + " " + c.Name + "  ===>  " + opuesto(c.ForeColor));
            c.ForeColor = opuesto(c.ForeColor);
        }

        public static void cambiarFlatAppearanceBackColor(Button c)
        {
            Console.WriteLine("FlatBack: "+ c.FlatAppearance.MouseDownBackColor + " " + c.Name + "  ===>  " + opuesto(c.FlatAppearance.MouseDownBackColor));
            c.FlatAppearance.MouseDownBackColor = opuesto(c.FlatAppearance.MouseDownBackColor);
        }

        public static void cambiarFlatAppearanceOverColor(Button c)
        {
            Console.WriteLine("FlatOver: " + c.FlatAppearance.MouseOverBackColor + " " + c.Name + "  ===>  " + opuesto(c.FlatAppearance.MouseOverBackColor));
            c.FlatAppearance.MouseOverBackColor = opuesto(c.FlatAppearance.MouseOverBackColor);
        }

        public static void cambiarShadowPanelColor(ShadowPanelRight s)
        {
            s.PanelColor = opuesto(s.PanelColor);
        }

        public static void cambiarRoundedPanelColor(RoundedPanel c)
        {
            c.cambiarColorPanel(opuesto(c.getColorPanel()));
            c.cambiarColorBorde(opuesto(c.getColorBorde()));
        }
    }
    public enum ColoresSistema
    {
        Rosa, Morado, VerdeSuccess, AmarilloInteractivo, AmarilloInteractivoMas1, AmarilloInteractivoMas2,
        AmarilloInteractivoMenos1, AmarilloInteractivoMenos2, PrincipalIndigo,
        HighContrast, MediumContrast, LowContrast, BackBackground, FrontBackground, Disabled, PrincipalRojo,
        PrincipalAzulMetalico, FormText, FormBackground, FormShape,Transparent, DMFrontBackground, NegroPuro
    }
}