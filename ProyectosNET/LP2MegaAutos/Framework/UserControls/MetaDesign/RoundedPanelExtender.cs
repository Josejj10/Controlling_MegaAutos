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
    [ProvideProperty("ColorBorde", typeof(RoundedPanel))]

    public class RoundedPanelExtender : Component, IExtenderProvider
    {
        public bool CanExtend(object extendee)
        {
            return (extendee is RoundedPanel);
        }

        [Category("Appearance")]
        [DisplayName("Color RPanel")]
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
        [DisplayName("Color RBorde")]
        [Description("Del borde, no del panel.")]
        public Color GetColorBorde(RoundedPanel control)
        {
            return control.getColorBorde();
        }

        public void SetColorBorde(RoundedPanel control, Color value)
        {
            control.cambiarColorBorde(value);
        }

    }
}