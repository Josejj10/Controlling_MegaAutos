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
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.rpItem = new LP2MegaAutos.RoundedPanel();
            this.pnlImg = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.rpItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpItem
            // 
            this.rpItem.ArcRadiusBorde = 15;
            this.rpItem.ArcRadiusPanel = 15;
            this.rpItem.BackColor = System.Drawing.Color.Transparent;
            this.rpItem.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.rpItem.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpItem.Controls.Add(this.pnlImg);
            this.rpItem.Controls.Add(this.lblTexto);
            this.rpItem.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpItem.Location = new System.Drawing.Point(0, 0);
            this.rpItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rpItem.MenosHeightBorde = 1;
            this.rpItem.MenosHeightPanel = 1;
            this.rpItem.MenosWidthBorde = 1;
            this.rpItem.MenosWidthPanel = 1;
            this.rpItem.Name = "rpItem";
            this.rpItem.PorcLuzColorBorde = 0;
            this.rpItem.Size = new System.Drawing.Size(141, 105);
            this.rpItem.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.rpItem, null);
            this.tagsExtender1.SetTag3(this.rpItem, null);
            this.tagsExtender1.SetTagFontName(this.rpItem, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpItem, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpItem, System.Drawing.FontStyle.Regular);
            this.rpItem.XBorde = 0;
            this.rpItem.XPanel = 0;
            this.rpItem.YBorde = 0;
            this.rpItem.YPanel = 0;
            this.rpItem.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.rpItem.MouseLeave += new System.EventHandler(this.roundedPanel1_MouseLeave);
            // 
            // pnlImg
            // 
            this.pnlImg.BackColor = System.Drawing.Color.Transparent;
            this.pnlImg.BackgroundImage = global::LP2MegaAutos.Properties.Resources.editar;
            this.pnlImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImg.Location = new System.Drawing.Point(48, 17);
            this.pnlImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlImg.Name = "pnlImg";
            this.pnlImg.Size = new System.Drawing.Size(47, 43);
            this.pnlImg.TabIndex = 1;
            this.tagsExtender1.SetTag2(this.pnlImg, null);
            this.tagsExtender1.SetTag3(this.pnlImg, null);
            this.tagsExtender1.SetTagFontName(this.pnlImg, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.pnlImg, 10F);
            this.tagsExtender1.SetTagFontStyle(this.pnlImg, System.Drawing.FontStyle.Regular);
            this.pnlImg.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.pnlImg.MouseLeave += new System.EventHandler(this.roundedPanel1_MouseLeave);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.lblTexto.Location = new System.Drawing.Point(11, 70);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(121, 21);
            this.lblTexto.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.lblTexto, null);
            this.tagsExtender1.SetTag3(this.lblTexto, null);
            this.tagsExtender1.SetTagFontName(this.lblTexto, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblTexto, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lblTexto, System.Drawing.FontStyle.Bold);
            this.lblTexto.Text = "Texto principal";
            this.lblTexto.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.lblTexto.MouseLeave += new System.EventHandler(this.roundedPanel1_MouseLeave);
            // 
            // itemListaCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rpItem);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "itemListaCuadrado";
            this.Size = new System.Drawing.Size(141, 105);
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.rpItem.ResumeLayout(false);
            this.rpItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TagsExtender tagsExtender1;
        private RoundedPanel rpItem;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Panel pnlImg;
    }
}
