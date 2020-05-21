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
    [ProvideProperty("Tag2", typeof(Control))]
    [ProvideProperty("Tag3", typeof(Control))]
    [ProvideProperty("TagFontName", typeof(Control))]
    [ProvideProperty("TagFontSize", typeof(Control))]
    [ProvideProperty("TagFontStyle", typeof(Control))]
    public class TagsExtender : Component, IExtenderProvider
    {
        private Hashtable tag2Values = new Hashtable();
        private Hashtable tag3Values = new Hashtable();
        private Hashtable tagFontNameValues = new Hashtable();
        private Hashtable tagFontSizeValues = new Hashtable();
        private Hashtable tagFontStyleValues = new Hashtable();

        public bool CanExtend(object extendee)
        {
            return (extendee is Control && !(extendee is Form));
        }

        [Category("Data")]
        [DisplayName("Tag 2")]
        [Description("Otro Tag por si lo necesitas :D.")]
        public string GetTag2(Control control)
        {
            if (tag2Values.ContainsKey(control))
                return (string)tag2Values[control];
            return null;
        }
        
        [Category("Data")]
        [DisplayName("Tag 2")]
        [Description("Otro Tag por si lo necesitas :D.")]
        public void SetTag2(Control control, string value)
        {
            if (string.IsNullOrEmpty(value))
                tag2Values.Remove(control);
            else
                tag2Values[control] = value;
        }

        [Category("Data")]
        [DisplayName("Tag 3")]
        [Description("Porque no hay segunda sin tercera.")]
        public string GetTag3(Control control)
        {
            if (tag3Values.ContainsKey(control))
                return (string)tag3Values[control];
            return null;
        }

        [Category("Data")]
        [DisplayName("Tag 3")]
        [Description("Porque no hay segunda sin tercera.")]
        public void SetTag3(Control control, string value)
        {
            if (string.IsNullOrEmpty(value))
                tag3Values.Remove(control);
            else
                tag3Values[control] = value;
        }

        [Category("Data")]
        [DisplayName("Font Name")]
        [Description("Para las Tipografias Embebidas.")]
        public fontsD GetTagFontName(Control control)
        {
            if (tagFontNameValues.ContainsKey(control.Name))
                return (fontsD)tagFontNameValues[control.Name];
            return fontsD.Ninguno; // Valor default es Ninguno, que devuelve ""
        }

        [Category("Data")]
        [DisplayName("Font Name")]
        [Description("Para las Tipografias Embebidas.")]
        public void SetTagFontName(Control control, fontsD value)
        {
            // Toca confiar en el gran Dieguito Maradona
            tagFontNameValues[control.Name] = value;
        }


        [Category("Data")]
        [DisplayName("Font Size")]
        [Description("Para las Tipografias Embebidas")]
        public float GetTagFontSize(Control control)
        {
            if (tagFontSizeValues.ContainsKey(control))
                return (float)tagFontSizeValues[control];
            return 10f; //Valor default
        }

        [Category("Data")]
        [DisplayName("Font Size")]
        [Description("Para las Tipografias Embebidas")]
        public void SetTagFontSize(Control control, float value)
        {
            if (value == 0)
                tagFontSizeValues.Remove(control);
            else
                tagFontSizeValues[control] = value;
        }


        [Category("Data")]
        [DisplayName("Font Style")]
        [Description("Para las Tipografias Embebidas")]
        public FontStyle GetTagFontStyle(Control control)
        {
            if (tagFontStyleValues.ContainsKey(control))
                return (FontStyle)tagFontStyleValues[control];
            return FontStyle.Regular;
        }

        [Category("Data")]
        [DisplayName("Font Style")]
        [Description("Para las Tipografias Embebidas")]
        public void SetTagFontStyle(Control control, FontStyle value)
        {
            // Aca hay que creer en Dieguito Maradona que 
            // Esta recibiendo un buen Font Style
            tagFontStyleValues[control] = value;
        }
    }
}