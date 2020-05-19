using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2MegaAutos
{
   
    public class White_Mode : Colores
    {
        // Contrast
        public static Color HighContrast= Color.FromArgb(0,0,0);
        public static Color MediumContrast= Color.FromArgb(26, 37, 50);
        public static Color LowContrast= Color.FromArgb(142, 142, 147);

        // Background
        public static Color BackBackground= Color.FromArgb(245, 245, 246);
        public static Color FrontBackground= Color.FromArgb(255, 255, 255);

        // Coloridos
        public static Color Disabled= Color.FromArgb(189, 189, 189);
        public static Color PrincipalRojo= Color.FromArgb(229, 65, 33);
        public static Color PrincipalAzulMetalico= Color.FromArgb(54, 140, 161);

        // Forms
        public static Color FormText= Color.FromArgb(67, 71, 76);
        public static Color FormBackground= Color.FromArgb(245, 245, 246);
        public static Color FormShape= Color.FromArgb(112, 112, 112);
        public static Color ChooseAmarillo= AmarilloInteractivoMenos2;
    }

    public class Dark_Mode : Colores
    {
        // Contrast
        public static Color HighContrast= Color.FromArgb(245, 245, 246);
        public static Color MediumContrast= Color.FromArgb(217, 217, 217);
        public static Color LowContrast= Color.FromArgb(26, 37, 50);

        // Background
        public static Color BackBackground= Color.FromArgb(0, 0, 0);
        public static Color FrontBackground= Color.FromArgb(28, 28, 30);

        // Coloridos
        public static Color Disabled= Color.FromArgb(119, 119, 119);
        public static Color PrincipalRojo= Color.FromArgb(226, 47, 11);
        public static Color PrincipalAzulMetalico= Color.FromArgb(16, 133, 161);

        // Forms
        public static Color FormText= Color.FromArgb(142, 142, 147);
        public static Color FormBackground= Color.FromArgb(64, 64, 69);
        public static Color FormShape= Color.FromArgb(99, 99, 102);
        public static Color ChooseAmarillo= AmarilloInteractivo;

    }

    public class Colores
    {
        #region Denotive Colors
        public static Color Rosa = Color.FromArgb(227, 64, 94);
        public static Color VerdeSuccess = Color.FromArgb(152, 212, 73);
        public static Color AmarilloInteractivo = Color.FromArgb(247, 199, 45);
        public static Color AmarilloInteractivoMas1 = Color.FromArgb(247, 178, 83);
        public static Color AmarilloInteractivoMas2 = Color.FromArgb(247, 161, 45);
        public static Color AmarilloInteractivoMenos1 = Color.FromArgb(249, 215, 103);
        public static Color AmarilloInteractivoMenos2 = Color.FromArgb(250, 220, 124);
        public static Color PrincipalIndigo= Color.FromArgb(79, 191, 209);
        public static Color AmarilloHover = Color.FromArgb(222, 179, 40);
        public static Color AmarilloClick = Color.FromArgb(222, 159, 40);
        public static Color ClickableTextDefault = Rosa;
        public static Color ClickableTextEnter = Color.FromArgb(191, 90, 108);
        public static Color ClickableTextDown = Color.FromArgb(181, 51, 74);

        #endregion Denotive Colors

        //#region White Mode
        // Contrast
        ////public static Color HighContrastWhiteMode = Color.FromArgb(0, 0, 0);
        //public static Color MediumContrastWhiteMode = Color.FromArgb(26, 37, 50);
        //public static Color LowContrastWhiteMode = Color.FromArgb(142, 142, 147);

        //// Background
        //public static Color BackBackgroundWhiteMode = Color.FromArgb(245, 245, 246);
        //public static Color FrontBackgroundWhiteMode = Color.FromArgb(255,255,255);

        //// Coloridos
        //public static Color DisabledWhiteMode = Color.FromArgb(189, 189, 189);
        //public static Color PrincipalRojoMegaAutosWhiteMode = Color.FromArgb(229, 65, 33);
        //public static Color PrincipalAzulMetalicoWhiteMode = Color.FromArgb(54, 140, 161);

        //#region White forms
        //public static Color FormTextWhiteMode = Color.FromArgb(67,71,76);
        //public static Color FormBackgroundWhiteMode = Color.FromArgb(245,245,246);
        //public static Color FormShapeWhiteMode = Color.FromArgb(112,112,112);
        //public static Color ChooseAmarilloWhiteMode = AmarilloInteractivoMenos2 ;
        //#endregion White forms

        //#endregion White Mode

        //#region Dark Mode
        //// Contrast
        //public static Color HighContrastDarkMode = Color.FromArgb(245,245,246);
        //public static Color MediumContrastDarkMode = Color.FromArgb(217, 217, 217);
        //public static Color LowContrastDarkMode = Color.FromArgb(26,37,50);

        //// Background
        //public static Color BackBackgroundDarkMode = Color.FromArgb(0,0,0);
        //public static Color FrontBackgroundDarkMode = Color.FromArgb(28,28,30);

        //// Coloridos
        //public static Color DisabledDarkMode = Color.FromArgb(119, 119, 119);
        //public static Color PrincipalRojoMegaAutosDarkMode = Color.FromArgb(226,47,11);
        //public static Color PrincipalAzulMetalicoDarkMode = Color.FromArgb(16,133,161);

        //#region Dark form
        //public static Color FormTextDarkMode = Color.FromArgb(142, 142, 147);
        //public static Color FormBackgroundDarkMode = Color.FromArgb(64,64,69);
        //public static Color FormShapeDarkMode = Color.FromArgb(99,99,102);
        //public static Color ChooseAmarilloDarkMode = AmarilloInteractivo ;
        //#endregion Dark forms

        //#endregion Dark Mode


    }


}
