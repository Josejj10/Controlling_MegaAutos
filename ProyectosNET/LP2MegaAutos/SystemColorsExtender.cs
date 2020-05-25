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
    [ProvideProperty("BackColorSystem", typeof(Control))]
    [ProvideProperty("ForeColorSystem", typeof(Control))]

    public class SystemColorsExtender : Component, IExtenderProvider
    {
        
        public bool CanExtend(object extendee)
        {
            return (extendee is Control);
        }

        [Category("Appearance")]
        [DisplayName("BackColor Sistema")]
        [Description("De los Colores de clase Colores.")]
        
        public ColoresSistema GetBackColorSystem(Control control)
        {
            if (Colores.dColores.ContainsKey(control.BackColor))
                return Colores.dColores[control.BackColor];
            return ColoresSistema.FrontBackground;
        }

        public void SetBackColorSystem(Control control, ColoresSistema value)
        {
            control.BackColor = Colores.dColoresSistema[value];
        }

        [Category("Appearance")]
        [DisplayName("ForeColor Sistema")]
        [Description("De los Colores de clase Colores.")]
        
        public ColoresSistema GetForeColorSystem(Control control)
        {
            if (Colores.dColores.ContainsKey(control.ForeColor))
                return Colores.dColores[control.ForeColor];
            return ColoresSistema.HighContrast;
        }

        public void SetForeColorSystem(Control control, ColoresSistema value)
        {
            if (Colores.dColoresSistema.ContainsKey(value))
                control.ForeColor = Colores.dColoresSistema[value];
            control.ForeColor = Colores.HighContrast;
            //control.ForeColor = Colores.dColoresSistema[value];
        }

    }
}