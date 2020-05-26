using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LP2MegaAutos.CustomControls
{
    public partial class ClickableText : Label
    {
        Color cDefault = Colores.ClickableTextDefault;
        Color cEnter = Colores.ClickableTextEnter;
        Color cDown = Colores.ClickableTextDown;

        #region  Public Constructors  
        public ClickableText()
        {
            // Default Color
            this.ForeColor = cDefault;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = Tipografias.GetFromHash("Montserrat", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AutoSize = false;
        }

        public ClickableText(Color cDefault, Color cEnter, Color cDown)
        {
            this.ForeColor = cDefault;
            this.cDefault = cDefault;
            this.cEnter = cEnter;
            this.cDown = cDown;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = Tipografias.GetFromHash("Montserrat", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AutoSize = false;
        }

        #endregion  Public Constructors  

        #region  Protected Overridden Methods  

        protected override void OnMouseEnter(EventArgs e)
        {
            this.ForeColor = cEnter;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.ForeColor = cDefault;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.ForeColor = cDown;
        }

        #region OnMouseUpEvents
        protected override void OnMouseUp(MouseEventArgs e)
        {
           this.ForeColor = cDefault;
        }

        #endregion OnMouseUpEvents

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.FitToContents();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            this.FitToContents();
        }

        #endregion  Protected Overridden Methods  

        #region  Protected Virtual Methods  

        protected virtual void FitToContents()
        {
            Size size;

            size = this.GetPreferredSize(new Size(this.Width, 0));

            this.Height = size.Height;
        }

        #endregion  Protected Virtual Methods  

        #region  Public Properties  

        [DefaultValue(false), Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override bool AutoSize
        {
            get { return base.AutoSize; }
            set { base.AutoSize = value; }
        }

        #endregion  Public Properties  
    }
}