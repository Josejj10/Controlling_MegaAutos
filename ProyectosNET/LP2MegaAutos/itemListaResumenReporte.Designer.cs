namespace LP2MegaAutos
{
    partial class itemListaResumenReporte
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
            this.tlpItem = new System.Windows.Forms.TableLayoutPanel();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.rpItem.SuspendLayout();
            this.tlpItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpItem
            // 
            this.rpItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rpItem.ArcRadiusBorde = 15;
            this.rpItem.ArcRadiusPanel = 15;
            this.rpItem.BackColor = System.Drawing.Color.Transparent;
            this.rpItem.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.rpItem.ColorPanel = System.Drawing.Color.Transparent;
            this.rpItem.Controls.Add(this.tlpItem);
            this.rpItem.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpItem.Location = new System.Drawing.Point(7, 0);
            this.rpItem.MenosHeightBorde = 1;
            this.rpItem.MenosHeightPanel = 1;
            this.rpItem.MenosWidthBorde = 1;
            this.rpItem.MenosWidthPanel = 1;
            this.rpItem.Name = "rpItem";
            this.rpItem.PorcLuzColorBorde = 0;
            this.rpItem.Size = new System.Drawing.Size(187, 64);
            this.rpItem.TabIndex = 55;
            this.rpItem.XBorde = 0;
            this.rpItem.XPanel = 0;
            this.rpItem.YBorde = 0;
            this.rpItem.YPanel = 0;
            // 
            // tlpItem
            // 
            this.tlpItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpItem.ColumnCount = 1;
            this.tlpItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpItem.Controls.Add(this.lblMonto, 0, 1);
            this.tlpItem.Controls.Add(this.lblConcepto, 0, 1);
            this.tlpItem.Location = new System.Drawing.Point(7, 3);
            this.tlpItem.Name = "tlpItem";
            this.tlpItem.RowCount = 2;
            this.tlpItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tlpItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpItem.Size = new System.Drawing.Size(174, 58);
            this.tlpItem.TabIndex = 0;
            // 
            // lblMonto
            // 
            this.lblMonto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMonto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonto.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblMonto.Location = new System.Drawing.Point(4, 25);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(165, 28);
            this.lblMonto.TabIndex = 49;
            this.lblMonto.Text = "999,999,999.00";
            this.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConcepto
            // 
            this.lblConcepto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConcepto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConcepto.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.lblConcepto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.lblConcepto.Location = new System.Drawing.Point(4, 1);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(165, 19);
            this.lblConcepto.TabIndex = 48;
            this.lblConcepto.Text = "Concepto";
            this.lblConcepto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemListaResumenReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rpItem);
            this.Name = "itemListaResumenReporte";
            this.Size = new System.Drawing.Size(200, 64);
            this.rpItem.ResumeLayout(false);
            this.tlpItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel rpItem;
        private System.Windows.Forms.TableLayoutPanel tlpItem;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblConcepto;
    }
}
