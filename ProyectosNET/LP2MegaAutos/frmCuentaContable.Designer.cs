namespace LP2MegaAutos
{
    partial class frmCuentaContable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_agrega = new System.Windows.Forms.Label();
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.clickableText1 = new LP2MegaAutos.CustomControls.ClickableText();
            this.clickableText2 = new LP2MegaAutos.CustomControls.ClickableText();
            this.SuspendLayout();
            // 
            // lbl_agrega
            // 
            this.lbl_agrega.AutoSize = true;
            this.lbl_agrega.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agrega.Location = new System.Drawing.Point(12, 9);
            this.lbl_agrega.Name = "lbl_agrega";
            this.lbl_agrega.Size = new System.Drawing.Size(554, 39);
            this.lbl_agrega.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.lbl_agrega, null);
            this.tagsExtender1.SetTag3(this.lbl_agrega, null);
            this.tagsExtender1.SetTagFontName(this.lbl_agrega, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.lbl_agrega, 24F);
            this.tagsExtender1.SetTagFontStyle(this.lbl_agrega, System.Drawing.FontStyle.Bold);
            this.lbl_agrega.Text = "Agregar Cuenta Contable a Planchado";
            // 
            // clickableText1
            // 
            this.clickableText1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clickableText1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clickableText1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickableText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.clickableText1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clickableText1.Location = new System.Drawing.Point(221, 352);
            this.clickableText1.Name = "clickableText1";
            this.clickableText1.Size = new System.Drawing.Size(94, 23);
            this.clickableText1.TabIndex = 1;
            this.tagsExtender1.SetTag2(this.clickableText1, null);
            this.tagsExtender1.SetTag3(this.clickableText1, null);
            this.tagsExtender1.SetTagFontName(this.clickableText1, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.clickableText1, 14F);
            this.tagsExtender1.SetTagFontStyle(this.clickableText1, System.Drawing.FontStyle.Bold);
            this.clickableText1.Text = "Aceptar";
            this.clickableText1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clickableText2
            // 
            this.clickableText2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clickableText2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clickableText2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickableText2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.clickableText2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clickableText2.Location = new System.Drawing.Point(464, 352);
            this.clickableText2.Name = "clickableText2";
            this.clickableText2.Size = new System.Drawing.Size(102, 23);
            this.clickableText2.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.clickableText2, null);
            this.tagsExtender1.SetTag3(this.clickableText2, null);
            this.tagsExtender1.SetTagFontName(this.clickableText2, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.clickableText2, 10F);
            this.tagsExtender1.SetTagFontStyle(this.clickableText2, System.Drawing.FontStyle.Regular);
            this.clickableText2.Text = "Cancelar";
            this.clickableText2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmCuentaContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.clickableText2);
            this.Controls.Add(this.clickableText1);
            this.Controls.Add(this.lbl_agrega);
            this.Name = "frmCuentaContable";
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_agrega;
        private TagsExtender tagsExtender1;
        private CustomControls.ClickableText clickableText1;
        private CustomControls.ClickableText clickableText2;
    }
}