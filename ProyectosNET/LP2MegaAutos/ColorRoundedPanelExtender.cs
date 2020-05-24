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
    [ProvideProperty("ColorBorde", typeof(RoundedPanel))]
    public class ColorRoundedPanelExtender: Component, IExtenderProvider
    {
        private Hashtable colorPanelValues = new Hashtable();
        private Hashtable colorBordeValues = new Hashtable();

        public bool CanExtend(object extendee)
        {
            return (extendee is RoundedPanel);
        }

        [Category("Appearance")]
        [DisplayName("RPanel Color")]
        [Description("Del panel, no del borde.")]
        public Color GetColorPanel(RoundedPanel control)
        {
            if (colorPanelValues.ContainsKey(control))
                return (Color)colorPanelValues[control];
            return Color.White;
        }

        [Category("Appearance")]
        [DisplayName("RBorder Color")]
        [Description("Del panel, no del borde.")]
        public void SetColorPanel(RoundedPanel control, Color value)
        {
            colorPanelValues[control] = value;
            control.cambiarColorPanel(value);
        }

        [Category("Appearance")]
        [DisplayName("Color Rounded Borde")]
        [Description("Del borde, no del panel.")]
        public Color GetColorBorde(RoundedPanel control)
        {
            if (colorBordeValues.ContainsKey(control))
                return (Color)colorBordeValues[control];
            return Color.White;
        }

        [Category("Appearance")]
        [DisplayName("Color Rounded Borde")]
        [Description("Del borde, no del panel.")]
        public void SetColorBorde(RoundedPanel control, Color value)
        {
            colorBordeValues[control] = value;
            control.cambiarColorBorde(value);
        }

    }
}
