using Plasmoid.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

// https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.iextenderprovider?redirectedfrom=MSDN&view=netframework-4.7.2
// Agradecido con el de arriba

namespace LP2MegaAutos
{
    [ProvideProperty("ColorPanel", typeof(RoundedPanel))]
    [ProvideProperty("ColorSistemaPanel", typeof(RoundedPanel))]
    [ProvideProperty("ColorSistemaBorde", typeof(RoundedPanel))]
    [ProvideProperty("ColorBorde", typeof(RoundedPanel))]
    [ProvideProperty("ArcoRPanel", typeof(RoundedPanel))]
    [ProvideProperty("ArcoRBorde", typeof(RoundedPanel))]
    [ProvideProperty("Corners", typeof(RoundedPanel))]

    public class ColorRoundedPanelExtender : Component, IExtenderProvider
    {
        //private Hashtable colorSistemaPanelValues = new Hashtable();
        //private Hashtable colorSistemaBordeValues = new Hashtable();

        public bool CanExtend(object extendee)
        {
            return (extendee is RoundedPanel);
        }

        [Category("Appearance")]
        [DisplayName("RPanel Color")]
        [Description("Del panel, no del borde.")]
        public Color GetColorPanel(RoundedPanel control)
        {
            return control.getColorPanel();
        }

        public void SetColorPanel(RoundedPanel control, Color value)
        {
            control.cambiarColorPanel(value);
        }
        
        [Category("Appearance")]
        [DisplayName("RPanel Color Sistema")]
        [Description("Del panel, no del borde. Cambia el color a un color de la clase Colores")]
        public ColoresSistema GetColorSistemaPanel(RoundedPanel control)
        {
            //if (colorSistemaPanelValues.ContainsKey(control))
            //   return (ColoresSistema)colorSistemaPanelValues[control];
            return Colores.dColores[control.getColorPanel()];
            //return ColoresSistema.FrontBackground;
        }

        public void SetColorSistemaPanel(RoundedPanel control, ColoresSistema value)
        {
            //colorSistemaPanelValues[control] = value;
            control.cambiarColorPanel(Colores.dColoresSistema[value]);
        }
        
        [Category("Appearance")]
        [DisplayName("RBorde Color Sistema")]
        [Description("Del borde, no del panel. Cambia el color a un color de la clase Colores.")]
        public ColoresSistema GetColorSistemaBorde(RoundedPanel control)
        {
            // if (colorSistemaBordeValues.ContainsKey(control))
            //     return (ColoresSistema)colorSistemaBordeValues[control];
            // return ColoresSistema.Transparent;
            return Colores.dColores[control.getColorBorde()];
        }

        public void SetColorSistemaBorde(RoundedPanel control, ColoresSistema value)
        {
            //colorSistemaBordeValues[control] = value;
            control.cambiarColorBorde(Colores.switchColoresSistema(value));
        }


        [Category("Appearance")]
        [DisplayName("RBorder Color")]
        [Description("Del borde, no del panel.")]
        public Color GetColorBorde(RoundedPanel control)
        {
            return control.getColorBorde();
        }

        public void SetColorBorde(RoundedPanel control, Color value)
        {
            control.cambiarColorBorde(value);
        }

        [Category("Appearance")]
        [DisplayName("RP Arco")]
        [Description("Del panel, no del borde.")]
        public int GetArcoRPanel(RoundedPanel control)
        {
            return control.ArcRadiusPanel;
        }

        [Category("Appearance")]
        [DisplayName("RP Arco")]
        [Description("Del panel, no del borde.")]
        public void SetArcoRPanel(RoundedPanel control, int value)
        {
            control.ArcRadiusPanel = value;
        }

        [Category("Appearance")]
        [DisplayName("RB Arco")]
        [Description("Del borde, no del panel.")]
        public int GetArcoRBorde(RoundedPanel control)
        {
            return control.ArcRadiusBorde;
        }

        [Category("Appearance")]
        [DisplayName("RB Arco")]
        [Description("Del borde, no del panel.")]
        public void SetArcoRBorde(RoundedPanel control, int value)
        {
            control.ArcRadiusBorde = value;
        }

        [Category("Appearance")]
        [DisplayName("RP Corners")]
        [Description("Esquinas a redondear.")]
        public RectangleEdgeFilter GetCorners(RoundedPanel control)
        {
            return control.CornersRound;
        }

        public void SetCorners(RoundedPanel control, RectangleEdgeFilter value)
        {
            control.CornersRound = value;
        }



    }
}