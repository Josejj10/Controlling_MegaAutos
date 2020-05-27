namespace LP2MegaAutos
{
    partial class pantallaAreaTrabajo
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
            this.frontBackground = new LP2MegaAutos.RoundedPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.roundedPanel1 = new LP2MegaAutos.RoundedPanel();
            this.tags = new LP2MegaAutos.TagsExtender();
            this.systemColorsExtender1 = new LP2MegaAutos.SystemColorsExtender();
            this.roundedPanelExtender1 = new LP2MegaAutos.RoundedPanelExtender();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.frontBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // frontBackground
            // 
            this.roundedPanelExtender1.SetArcoRBorde(this.frontBackground, 15);
            this.roundedPanelExtender1.SetArcoRPanel(this.frontBackground, 15);
            this.frontBackground.ArcRadiusBorde = 15;
            this.frontBackground.ArcRadiusPanel = 15;
            this.frontBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.systemColorsExtender1.SetBackColorSystem(this.frontBackground, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanelExtender1.SetColorSistemaBorde(this.frontBackground, LP2MegaAutos.ColoresSistema.BackBackground);
            this.roundedPanelExtender1.SetColorSistemaPanel(this.frontBackground, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.frontBackground.Controls.Add(this.panel1);
            this.frontBackground.Controls.Add(this.lblTitulo);
            this.frontBackground.Controls.Add(this.roundedPanel1);
            this.roundedPanelExtender1.SetCorners(this.frontBackground, Plasmoid.Extensions.RectangleEdgeFilter.All);
            this.frontBackground.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.frontBackground.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.frontBackground, LP2MegaAutos.ColoresSistema.HighContrast);
            this.frontBackground.Location = new System.Drawing.Point(-1, 0);
            this.frontBackground.MenosHeightBorde = 1;
            this.frontBackground.MenosHeightPanel = 1;
            this.frontBackground.MenosWidthBorde = 1;
            this.frontBackground.MenosWidthPanel = 1;
            this.frontBackground.Name = "frontBackground";
            this.frontBackground.PorcLuzColorBorde = 0;
            this.frontBackground.Size = new System.Drawing.Size(611, 470);
            this.frontBackground.TabIndex = 1;
            this.tags.SetTag2(this.frontBackground, null);
            this.tags.SetTag3(this.frontBackground, null);
            this.tags.SetTagFontName(this.frontBackground, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.frontBackground, 10F);
            this.tags.SetTagFontStyle(this.frontBackground, System.Drawing.FontStyle.Regular);
            this.frontBackground.XBorde = 0;
            this.frontBackground.XPanel = 0;
            this.frontBackground.YBorde = 0;
            this.frontBackground.YPanel = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.systemColorsExtender1.SetBackColorSystem(this.panel1, LP2MegaAutos.ColoresSistema.PrincipalAzulMetalico);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.panel1, LP2MegaAutos.ColoresSistema.HighContrast);
            this.panel1.Location = new System.Drawing.Point(21, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 26);
            this.panel1.TabIndex = 2;
            this.tags.SetTag2(this.panel1, null);
            this.tags.SetTag3(this.panel1, null);
            this.tags.SetTagFontName(this.panel1, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.panel1, 10F);
            this.tags.SetTagFontStyle(this.panel1, System.Drawing.FontStyle.Regular);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.systemColorsExtender1.SetBackColorSystem(this.label2, LP2MegaAutos.ColoresSistema.PrincipalAzulMetalico);
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.label2, LP2MegaAutos.ColoresSistema.HighContrast);
            this.label2.Location = new System.Drawing.Point(183, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 22);
            this.label2.TabIndex = 1;
            this.tags.SetTag2(this.label2, null);
            this.tags.SetTag3(this.label2, null);
            this.tags.SetTagFontName(this.label2, fontsD.Montserrat);
            this.tags.SetTagFontSize(this.label2, 12F);
            this.tags.SetTagFontStyle(this.label2, System.Drawing.FontStyle.Bold);
            this.label2.Text = "Cuentas Contables";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.systemColorsExtender1.SetBackColorSystem(this.lblTitulo, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.lblTitulo.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.lblTitulo, LP2MegaAutos.ColoresSistema.HighContrast);
            this.lblTitulo.Location = new System.Drawing.Point(14, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(164, 39);
            this.lblTitulo.TabIndex = 1;
            this.tags.SetTag2(this.lblTitulo, null);
            this.tags.SetTag3(this.lblTitulo, null);
            this.tags.SetTagFontName(this.lblTitulo, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.lblTitulo, 24F);
            this.tags.SetTagFontStyle(this.lblTitulo, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Text = "Planchado";
            // 
            // roundedPanel1
            // 
            this.roundedPanelExtender1.SetArcoRBorde(this.roundedPanel1, 15);
            this.roundedPanelExtender1.SetArcoRPanel(this.roundedPanel1, 15);
            this.roundedPanel1.ArcRadiusBorde = 15;
            this.roundedPanel1.ArcRadiusPanel = 15;
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.systemColorsExtender1.SetBackColorSystem(this.roundedPanel1, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanelExtender1.SetColorSistemaBorde(this.roundedPanel1, LP2MegaAutos.ColoresSistema.BackBackground);
            this.roundedPanelExtender1.SetColorSistemaPanel(this.roundedPanel1, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanelExtender1.SetCorners(this.roundedPanel1, Plasmoid.Extensions.RectangleEdgeFilter.Top);
            this.roundedPanel1.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Top;
            this.roundedPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.roundedPanel1, LP2MegaAutos.ColoresSistema.HighContrast);
            this.roundedPanel1.Location = new System.Drawing.Point(0, 1);
            this.roundedPanel1.MenosHeightBorde = 1;
            this.roundedPanel1.MenosHeightPanel = 1;
            this.roundedPanel1.MenosWidthBorde = 1;
            this.roundedPanel1.MenosWidthPanel = 1;
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.PorcLuzColorBorde = 0;
            this.roundedPanel1.Size = new System.Drawing.Size(611, 40);
            this.roundedPanel1.TabIndex = 0;
            this.tags.SetTag2(this.roundedPanel1, null);
            this.tags.SetTag3(this.roundedPanel1, null);
            this.tags.SetTagFontName(this.roundedPanel1, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.roundedPanel1, 10F);
            this.tags.SetTagFontStyle(this.roundedPanel1, System.Drawing.FontStyle.Regular);
            this.roundedPanel1.XBorde = 0;
            this.roundedPanel1.XPanel = 0;
            this.roundedPanel1.YBorde = 0;
            this.roundedPanel1.YPanel = 0;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pantallaAreaTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.systemColorsExtender1.SetBackColorSystem(this, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.Controls.Add(this.frontBackground);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this, LP2MegaAutos.ColoresSistema.HighContrast);
            this.Name = "pantallaAreaTrabajo";
            this.Size = new System.Drawing.Size(611, 470);
            this.tags.SetTag2(this, null);
            this.tags.SetTag3(this, null);
            this.tags.SetTagFontName(this, fontsD.Ninguno);
            this.tags.SetTagFontSize(this, 10F);
            this.tags.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.frontBackground.ResumeLayout(false);
            this.frontBackground.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel frontBackground;
        private RoundedPanel roundedPanel1;
        private TagsExtender tags;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private SystemColorsExtender systemColorsExtender1;
        private RoundedPanelExtender roundedPanelExtender1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}
