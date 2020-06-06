namespace LP2MegaAutos
{
    partial class itemListaCuadrado
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemListaCuadrado));
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.roundedPanel1 = new LP2MegaAutos.RoundedPanel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.pnlImg = new System.Windows.Forms.Panel();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.ArcRadiusBorde = 15;
            this.roundedPanel1.ArcRadiusPanel = 15;
            this.roundedPanel1.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.roundedPanel1.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roundedPanel1.Controls.Add(this.pnlImg);
            this.roundedPanel1.Controls.Add(this.lblTexto);
            this.roundedPanel1.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.MenosHeightBorde = 1;
            this.roundedPanel1.MenosHeightPanel = 1;
            this.roundedPanel1.MenosWidthBorde = 1;
            this.roundedPanel1.MenosWidthPanel = 1;
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.PorcLuzColorBorde = 0;
            this.roundedPanel1.Size = new System.Drawing.Size(106, 85);
            this.roundedPanel1.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.roundedPanel1, null);
            this.tagsExtender1.SetTag3(this.roundedPanel1, null);
            this.tagsExtender1.SetTagFontName(this.roundedPanel1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.roundedPanel1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.roundedPanel1, System.Drawing.FontStyle.Regular);
            this.roundedPanel1.XBorde = 0;
            this.roundedPanel1.XPanel = 0;
            this.roundedPanel1.YBorde = 0;
            this.roundedPanel1.YPanel = 0;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.lblTexto.Location = new System.Drawing.Point(8, 57);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(91, 16);
            this.lblTexto.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.lblTexto, null);
            this.tagsExtender1.SetTag3(this.lblTexto, null);
            this.tagsExtender1.SetTagFontName(this.lblTexto, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.lblTexto, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lblTexto, System.Drawing.FontStyle.Bold);
            this.lblTexto.Text = "Texto principal";
            // 
            // pnlImg
            // 
            this.pnlImg.BackColor = System.Drawing.Color.Transparent;
            this.pnlImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlImg.BackgroundImage")));
            this.pnlImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImg.Location = new System.Drawing.Point(36, 14);
            this.pnlImg.Name = "pnlImg";
            this.pnlImg.Size = new System.Drawing.Size(35, 35);
            this.pnlImg.TabIndex = 1;
            this.tagsExtender1.SetTag2(this.pnlImg, null);
            this.tagsExtender1.SetTag3(this.pnlImg, null);
            this.tagsExtender1.SetTagFontName(this.pnlImg, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.pnlImg, 10F);
            this.tagsExtender1.SetTagFontStyle(this.pnlImg, System.Drawing.FontStyle.Regular);
            // 
            // itemListaCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundedPanel1);
            this.Name = "itemListaCuadrado";
            this.Size = new System.Drawing.Size(106, 85);
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TagsExtender tagsExtender1;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Panel pnlImg;
    }
}
