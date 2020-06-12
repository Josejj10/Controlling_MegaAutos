namespace LP2MegaAutos.Framework.UserControls.Items
{
    partial class itemMenuStrip
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
            this.btnItem = new System.Windows.Forms.Button();
            this.tags = new LP2MegaAutos.TagsExtender();
            this.SuspendLayout();
            // 
            // btnItem
            // 
            this.btnItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnItem.BackgroundImage = global::LP2MegaAutos.Properties.Resources.AreaTrabajo;
            this.btnItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItem.Font = new System.Drawing.Font("Lato Semibold", 6.7F, System.Drawing.FontStyle.Bold);
            this.btnItem.ForeColor = System.Drawing.Color.White;
            this.btnItem.Location = new System.Drawing.Point(0, 0);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(52, 52);
            this.btnItem.TabIndex = 0;
            this.tags.SetTag2(this.btnItem, null);
            this.tags.SetTag3(this.btnItem, null);
            this.tags.SetTagFontName(this.btnItem, fontsD.Lato_Semibold);
            this.tags.SetTagFontSize(this.btnItem, 6.7F);
            this.tags.SetTagFontStyle(this.btnItem, System.Drawing.FontStyle.Bold);
            this.btnItem.UseVisualStyleBackColor = false;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            this.btnItem.MouseEnter += new System.EventHandler(this.btnItem_MouseEnter);
            this.btnItem.MouseLeave += new System.EventHandler(this.btnItem_Leave);
            // 
            // itemMenuStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnItem);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "itemMenuStrip";
            this.Size = new System.Drawing.Size(52, 52);
            this.tags.SetTag2(this, null);
            this.tags.SetTag3(this, null);
            this.tags.SetTagFontName(this, fontsD.Ninguno);
            this.tags.SetTagFontSize(this, 10F);
            this.tags.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.SizeChanged += new System.EventHandler(this.itemMenuStrip_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnItem;
        private TagsExtender tags;
    }
}
