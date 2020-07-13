namespace LP2MegaAutos
{
    partial class itemLista
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
            this.rpItem = new LP2MegaAutos.RoundedPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTercerDato = new System.Windows.Forms.Label();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lblSecundario = new System.Windows.Forms.Label();
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.rpItem.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpItem
            // 
            this.rpItem.ArcRadiusBorde = 21;
            this.rpItem.ArcRadiusPanel = 21;
            this.rpItem.BackColor = System.Drawing.Color.Transparent;
            this.rpItem.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.rpItem.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpItem.Controls.Add(this.tableLayoutPanel1);
            this.rpItem.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rpItem.Location = new System.Drawing.Point(0, 0);
            this.rpItem.MenosHeightBorde = 1;
            this.rpItem.MenosHeightPanel = 1;
            this.rpItem.MenosWidthBorde = 1;
            this.rpItem.MenosWidthPanel = 1;
            this.rpItem.Name = "rpItem";
            this.rpItem.PorcLuzColorBorde = 0;
            this.rpItem.Size = new System.Drawing.Size(497, 81);
            this.rpItem.TabIndex = 2;
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
            this.rpItem.MouseLeave += new System.EventHandler(this.rpItem_MouseLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblTercerDato, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPrincipal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSecundario, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 72);
            this.tableLayoutPanel1.TabIndex = 10;
            this.tagsExtender1.SetTag2(this.tableLayoutPanel1, null);
            this.tagsExtender1.SetTag3(this.tableLayoutPanel1, null);
            this.tagsExtender1.SetTagFontName(this.tableLayoutPanel1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.tableLayoutPanel1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.tableLayoutPanel1, System.Drawing.FontStyle.Regular);
            this.tableLayoutPanel1.Click += new System.EventHandler(this.itemLista_Click);
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.rpItem_MouseLeave);
            // 
            // lblTercerDato
            // 
            this.lblTercerDato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTercerDato.AutoSize = true;
            this.lblTercerDato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.lblTercerDato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTercerDato.Font = new System.Drawing.Font("Montserrat", 11F);
            this.lblTercerDato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblTercerDato.Location = new System.Drawing.Point(232, 52);
            this.lblTercerDato.Name = "lblTercerDato";
            this.lblTercerDato.Size = new System.Drawing.Size(0, 20);
            this.lblTercerDato.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.lblTercerDato, null);
            this.tagsExtender1.SetTag3(this.lblTercerDato, null);
            this.tagsExtender1.SetTagFontName(this.lblTercerDato, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lblTercerDato, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblTercerDato, System.Drawing.FontStyle.Regular);
            this.lblTercerDato.Click += new System.EventHandler(this.itemLista_Click);
            this.lblTercerDato.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.lblTercerDato.MouseLeave += new System.EventHandler(this.rpItem_MouseLeave);
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.lblPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrincipal.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.lblPrincipal.Location = new System.Drawing.Point(122, 0);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(220, 27);
            this.lblPrincipal.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.lblPrincipal, null);
            this.tagsExtender1.SetTag3(this.lblPrincipal, null);
            this.tagsExtender1.SetTagFontName(this.lblPrincipal, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lblPrincipal, 12F);
            this.tagsExtender1.SetTagFontStyle(this.lblPrincipal, System.Drawing.FontStyle.Bold);
            this.lblPrincipal.Text = "PRINCIPALSFPLSAKFLSA";
            this.lblPrincipal.Click += new System.EventHandler(this.itemLista_Click);
            this.lblPrincipal.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.lblPrincipal.MouseLeave += new System.EventHandler(this.rpItem_MouseLeave);
            // 
            // lblSecundario
            // 
            this.lblSecundario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSecundario.AutoSize = true;
            this.lblSecundario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.lblSecundario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSecundario.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold);
            this.lblSecundario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblSecundario.Location = new System.Drawing.Point(232, 27);
            this.lblSecundario.Name = "lblSecundario";
            this.lblSecundario.Size = new System.Drawing.Size(0, 25);
            this.lblSecundario.TabIndex = 1;
            this.tagsExtender1.SetTag2(this.lblSecundario, null);
            this.tagsExtender1.SetTag3(this.lblSecundario, null);
            this.tagsExtender1.SetTagFontName(this.lblSecundario, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lblSecundario, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblSecundario, System.Drawing.FontStyle.Bold);
            this.lblSecundario.Click += new System.EventHandler(this.itemLista_Click);
            this.lblSecundario.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.lblSecundario.MouseLeave += new System.EventHandler(this.rpItem_MouseLeave);
            // 
            // itemLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rpItem);
            this.Name = "itemLista";
            this.Size = new System.Drawing.Size(497, 81);
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.rpItem.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel rpItem;
        private TagsExtender tagsExtender1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTercerDato;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblSecundario;
    }
}
