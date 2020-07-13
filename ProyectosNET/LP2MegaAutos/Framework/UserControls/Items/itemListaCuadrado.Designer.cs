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
            this.tlpTexto = new System.Windows.Forms.TableLayoutPanel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.pnlImg = new System.Windows.Forms.Panel();
            this.rpItem.SuspendLayout();
            this.tlpTexto.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpItem
            // 
            this.rpItem.ArcRadiusBorde = 15;
            this.rpItem.ArcRadiusPanel = 15;
            this.rpItem.BackColor = System.Drawing.Color.Transparent;
            this.rpItem.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.rpItem.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpItem.Controls.Add(this.tlpTexto);
            this.rpItem.Controls.Add(this.pnlImg);
            this.rpItem.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rpItem.Location = new System.Drawing.Point(0, 0);
            this.rpItem.MenosHeightBorde = 1;
            this.rpItem.MenosHeightPanel = 1;
            this.rpItem.MenosWidthBorde = 1;
            this.rpItem.MenosWidthPanel = 1;
            this.rpItem.Name = "rpItem";
            this.rpItem.PorcLuzColorBorde = 0;
            this.rpItem.Size = new System.Drawing.Size(106, 85);
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
            this.rpItem.Click += new System.EventHandler(this.itemLista_Click);
            this.rpItem.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.rpItem.MouseLeave += new System.EventHandler(this.roundedPanel1_MouseLeave);
            // 
            // tlpTexto
            // 
            this.tlpTexto.ColumnCount = 1;
            this.tlpTexto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTexto.Controls.Add(this.lblTexto, 0, 0);
            this.tlpTexto.Location = new System.Drawing.Point(4, 53);
            this.tlpTexto.Name = "tlpTexto";
            this.tlpTexto.RowCount = 1;
            this.tlpTexto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTexto.Size = new System.Drawing.Size(98, 21);
            this.tlpTexto.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.tlpTexto, null);
            this.tagsExtender1.SetTag3(this.tlpTexto, null);
            this.tagsExtender1.SetTagFontName(this.tlpTexto, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.tlpTexto, 10F);
            this.tagsExtender1.SetTagFontStyle(this.tlpTexto, System.Drawing.FontStyle.Regular);
            this.tlpTexto.Click += new System.EventHandler(this.itemLista_Click);
            this.tlpTexto.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.tlpTexto.MouseLeave += new System.EventHandler(this.roundedPanel1_MouseLeave);
            // 
            // lblTexto
            // 
            this.lblTexto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTexto.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTexto.Location = new System.Drawing.Point(3, 2);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(91, 16);
            this.lblTexto.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.lblTexto, null);
            this.tagsExtender1.SetTag3(this.lblTexto, null);
            this.tagsExtender1.SetTagFontName(this.lblTexto, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblTexto, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lblTexto, System.Drawing.FontStyle.Bold);
            this.lblTexto.Text = "Texto principal";
            this.lblTexto.Click += new System.EventHandler(this.itemLista_Click);
            this.lblTexto.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.lblTexto.MouseLeave += new System.EventHandler(this.roundedPanel1_MouseLeave);
            // 
            // pnlImg
            // 
            this.pnlImg.BackColor = System.Drawing.Color.Transparent;
            this.pnlImg.BackgroundImage = global::LP2MegaAutos.Properties.Resources.editar;
            this.pnlImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlImg.Location = new System.Drawing.Point(33, 8);
            this.pnlImg.Name = "pnlImg";
            this.pnlImg.Size = new System.Drawing.Size(40, 40);
            this.pnlImg.TabIndex = 1;
            this.tagsExtender1.SetTag2(this.pnlImg, null);
            this.tagsExtender1.SetTag3(this.pnlImg, null);
            this.tagsExtender1.SetTagFontName(this.pnlImg, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.pnlImg, 10F);
            this.tagsExtender1.SetTagFontStyle(this.pnlImg, System.Drawing.FontStyle.Regular);
            this.pnlImg.Click += new System.EventHandler(this.itemLista_Click);
            this.pnlImg.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.pnlImg.MouseLeave += new System.EventHandler(this.roundedPanel1_MouseLeave);
            // 
            // itemListaCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rpItem);
            this.Name = "itemListaCuadrado";
            this.Size = new System.Drawing.Size(106, 85);
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.rpItem.ResumeLayout(false);
            this.tlpTexto.ResumeLayout(false);
            this.tlpTexto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TagsExtender tagsExtender1;
        private RoundedPanel rpItem;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TableLayoutPanel tlpTexto;
        private System.Windows.Forms.Panel pnlImg;
    }
}
