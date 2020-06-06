namespace LP2MegaAutos.Framework.UserControls
{
    partial class PanelMenuStrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelMenuStrip));
            this.itemMenuStrip3 = new LP2MegaAutos.Framework.UserControls.Items.itemMenuStrip();
            this.itemMenuStrip4 = new LP2MegaAutos.Framework.UserControls.Items.itemMenuStrip();
            this.itemMenuStrip2 = new LP2MegaAutos.Framework.UserControls.Items.itemMenuStrip();
            this.itemMenuStrip1 = new LP2MegaAutos.Framework.UserControls.Items.itemMenuStrip();
            this.SuspendLayout();
            // 
            // itemMenuStrip3
            // 
            this.itemMenuStrip3.Imagen = ((System.Drawing.Image)(resources.GetObject("itemMenuStrip3.Imagen")));
            this.itemMenuStrip3.Location = new System.Drawing.Point(156, 0);
            this.itemMenuStrip3.Name = "itemMenuStrip3";
            this.itemMenuStrip3.Size = new System.Drawing.Size(52, 52);
            this.itemMenuStrip3.TabIndex = 3;
            // 
            // itemMenuStrip4
            // 
            this.itemMenuStrip4.Imagen = ((System.Drawing.Image)(resources.GetObject("itemMenuStrip4.Imagen")));
            this.itemMenuStrip4.Location = new System.Drawing.Point(104, 0);
            this.itemMenuStrip4.Name = "itemMenuStrip4";
            this.itemMenuStrip4.Size = new System.Drawing.Size(52, 52);
            this.itemMenuStrip4.TabIndex = 2;
            // 
            // itemMenuStrip2
            // 
            this.itemMenuStrip2.Imagen = ((System.Drawing.Image)(resources.GetObject("itemMenuStrip2.Imagen")));
            this.itemMenuStrip2.Location = new System.Drawing.Point(52, 0);
            this.itemMenuStrip2.Name = "itemMenuStrip2";
            this.itemMenuStrip2.Size = new System.Drawing.Size(52, 52);
            this.itemMenuStrip2.TabIndex = 1;
            // 
            // itemMenuStrip1
            // 
            this.itemMenuStrip1.Imagen = ((System.Drawing.Image)(resources.GetObject("itemMenuStrip1.Imagen")));
            this.itemMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.itemMenuStrip1.Name = "itemMenuStrip1";
            this.itemMenuStrip1.Size = new System.Drawing.Size(52, 52);
            this.itemMenuStrip1.TabIndex = 0;
            // 
            // PanelMenuStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemMenuStrip3);
            this.Controls.Add(this.itemMenuStrip4);
            this.Controls.Add(this.itemMenuStrip2);
            this.Controls.Add(this.itemMenuStrip1);
            this.Name = "PanelMenuStrip";
            this.Size = new System.Drawing.Size(208, 52);
            this.ResumeLayout(false);

        }

        #endregion

        private Items.itemMenuStrip itemMenuStrip1;
        private Items.itemMenuStrip itemMenuStrip2;
        private Items.itemMenuStrip itemMenuStrip3;
        private Items.itemMenuStrip itemMenuStrip4;
    }
}
