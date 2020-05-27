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
            this.roundedPanel1 = new LP2MegaAutos.RoundedPanel();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.ArcRadiusBorde = 21;
            this.roundedPanel1.ArcRadiusPanel = 21;
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.roundedPanel1.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.roundedPanel1.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.MenosHeightBorde = 1;
            this.roundedPanel1.MenosHeightPanel = 1;
            this.roundedPanel1.MenosWidthBorde = 1;
            this.roundedPanel1.MenosWidthPanel = 1;
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.PorcLuzColorBorde = 0;
            this.roundedPanel1.Size = new System.Drawing.Size(497, 104);
            this.roundedPanel1.TabIndex = 2;
            this.roundedPanel1.XBorde = 0;
            this.roundedPanel1.XPanel = 0;
            this.roundedPanel1.YBorde = 0;
            this.roundedPanel1.YPanel = 0;
            // 
            // itemLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundedPanel1);
            this.Name = "itemLista";
            this.Size = new System.Drawing.Size(497, 104);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
    }
}
