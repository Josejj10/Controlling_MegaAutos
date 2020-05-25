namespace LP2MegaAutos
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.title_bar_2 = new System.Windows.Forms.Panel();
            this.title_bar = new System.Windows.Forms.Panel();
            this.boton_minimizar = new System.Windows.Forms.Button();
            this.boton_cerrar = new System.Windows.Forms.Button();
            this.reloj_dark = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new MetroFramework.Controls.MetroPanel();
            this.roundedPanel2 = new LP2MegaAutos.RoundedPanel();
            this.panel_logo_empresa = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel_toggle_nocturno = new System.Windows.Forms.Panel();
            this.boton_toggle_nocturno = new System.Windows.Forms.Button();
            this.tags = new LP2MegaAutos.TagsExtender();
            this.pnlBackBackground = new System.Windows.Forms.Panel();
            this.frontBackground = new LP2MegaAutos.RoundedPanel();
            this.roundedPanel1 = new LP2MegaAutos.RoundedPanel();
            this.colorRoundedPanelExtender1 = new LP2MegaAutos.ColorRoundedPanelExtender();
            this.colorRoundedPanelExtender2 = new LP2MegaAutos.ColorRoundedPanelExtender();
            this.title_bar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.panel_logo_empresa.SuspendLayout();
            this.panel_toggle_nocturno.SuspendLayout();
            this.pnlBackBackground.SuspendLayout();
            this.frontBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_bar_2
            // 
            this.title_bar_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.title_bar_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_bar_2.Enabled = false;
            this.title_bar_2.Location = new System.Drawing.Point(0, 24);
            this.title_bar_2.Name = "title_bar_2";
            this.title_bar_2.Size = new System.Drawing.Size(832, 8);
            this.title_bar_2.TabIndex = 1;
            this.title_bar_2.Tag = "titlebar";
            this.tags.SetTag2(this.title_bar_2, null);
            this.tags.SetTag3(this.title_bar_2, null);
            this.tags.SetTagFontName(this.title_bar_2, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.title_bar_2, 10F);
            this.tags.SetTagFontStyle(this.title_bar_2, System.Drawing.FontStyle.Regular);
            // 
            // title_bar
            // 
            this.title_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.title_bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title_bar.Controls.Add(this.boton_minimizar);
            this.title_bar.Controls.Add(this.boton_cerrar);
            this.title_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_bar.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.title_bar.Location = new System.Drawing.Point(0, 0);
            this.title_bar.Name = "title_bar";
            this.title_bar.Size = new System.Drawing.Size(832, 24);
            this.title_bar.TabIndex = 2;
            this.title_bar.Tag = "titlebar";
            this.tags.SetTag2(this.title_bar, null);
            this.tags.SetTag3(this.title_bar, null);
            this.tags.SetTagFontName(this.title_bar, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.title_bar, 10F);
            this.tags.SetTagFontStyle(this.title_bar, System.Drawing.FontStyle.Regular);
            this.title_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseDown);
            this.title_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseMove);
            this.title_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseUp);
            // 
            // boton_minimizar
            // 
            this.boton_minimizar.BackgroundImage = global::LP2MegaAutos.Properties.Resources.boton_minimizar;
            this.boton_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boton_minimizar.FlatAppearance.BorderSize = 0;
            this.boton_minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.boton_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.boton_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_minimizar.Location = new System.Drawing.Point(784, 0);
            this.boton_minimizar.Name = "boton_minimizar";
            this.boton_minimizar.Size = new System.Drawing.Size(24, 24);
            this.boton_minimizar.TabIndex = 0;
            this.boton_minimizar.TabStop = false;
            this.boton_minimizar.Tag = "titlebar";
            this.tags.SetTag2(this.boton_minimizar, null);
            this.tags.SetTag3(this.boton_minimizar, null);
            this.tags.SetTagFontName(this.boton_minimizar, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.boton_minimizar, 10F);
            this.tags.SetTagFontStyle(this.boton_minimizar, System.Drawing.FontStyle.Regular);
            this.boton_minimizar.UseVisualStyleBackColor = true;
            this.boton_minimizar.Click += new System.EventHandler(this.boton_minimizar_MouseClick);
            // 
            // boton_cerrar
            // 
            this.boton_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.boton_cerrar.BackgroundImage = global::LP2MegaAutos.Properties.Resources.boton_cerrar;
            this.boton_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boton_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.boton_cerrar.FlatAppearance.BorderSize = 0;
            this.boton_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(33)))));
            this.boton_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(33)))));
            this.boton_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_cerrar.ForeColor = System.Drawing.Color.Transparent;
            this.boton_cerrar.Location = new System.Drawing.Point(808, 0);
            this.boton_cerrar.Margin = new System.Windows.Forms.Padding(0);
            this.boton_cerrar.Name = "boton_cerrar";
            this.boton_cerrar.Size = new System.Drawing.Size(24, 24);
            this.boton_cerrar.TabIndex = 0;
            this.boton_cerrar.TabStop = false;
            this.boton_cerrar.Tag = "titlebar";
            this.tags.SetTag2(this.boton_cerrar, null);
            this.tags.SetTag3(this.boton_cerrar, null);
            this.tags.SetTagFontName(this.boton_cerrar, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.boton_cerrar, 10F);
            this.tags.SetTagFontStyle(this.boton_cerrar, System.Drawing.FontStyle.Regular);
            this.boton_cerrar.UseVisualStyleBackColor = false;
            this.boton_cerrar.Click += new System.EventHandler(this.boton_cerrar_MouseClick);
            // 
            // reloj_dark
            // 
            this.reloj_dark.Interval = 25;
            this.reloj_dark.Tick += new System.EventHandler(this.reloj_dark_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.panelMenu.Controls.Add(this.roundedPanel2);
            this.panelMenu.Controls.Add(this.panel_toggle_nocturno);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.HorizontalScrollbarBarColor = true;
            this.panelMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMenu.HorizontalScrollbarSize = 10;
            this.panelMenu.Location = new System.Drawing.Point(0, 32);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(81, 520);
            this.panelMenu.TabIndex = 3;
            this.panelMenu.Tag = "panelMenu";
            this.tags.SetTag2(this.panelMenu, null);
            this.tags.SetTag3(this.panelMenu, null);
            this.tags.SetTagFontName(this.panelMenu, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.panelMenu, 10F);
            this.tags.SetTagFontStyle(this.panelMenu, System.Drawing.FontStyle.Regular);
            this.panelMenu.UseCustomBackColor = true;
            this.panelMenu.UseCustomForeColor = true;
            this.panelMenu.VerticalScrollbarBarColor = true;
            this.panelMenu.VerticalScrollbarHighlightOnWheel = false;
            this.panelMenu.VerticalScrollbarSize = 10;
            // 
            // roundedPanel2
            // 
            this.colorRoundedPanelExtender2.SetArcoRBorde(this.roundedPanel2, 15);
            this.colorRoundedPanelExtender1.SetArcoRBorde(this.roundedPanel2, 15);
            this.colorRoundedPanelExtender1.SetArcoRPanel(this.roundedPanel2, 15);
            this.colorRoundedPanelExtender2.SetArcoRPanel(this.roundedPanel2, 15);
            this.roundedPanel2.ArcRadiusBorde = 15;
            this.roundedPanel2.ArcRadiusPanel = 15;
            this.colorRoundedPanelExtender1.SetColorBorde(this.roundedPanel2, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246))))));
            this.colorRoundedPanelExtender2.SetColorBorde(this.roundedPanel2, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246))))));
            this.colorRoundedPanelExtender2.SetColorPanel(this.roundedPanel2, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.colorRoundedPanelExtender1.SetColorPanel(this.roundedPanel2, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.colorRoundedPanelExtender2.SetColorSistemaBorde(this.roundedPanel2, LP2MegaAutos.ColoresSistema.BackBackground);
            this.colorRoundedPanelExtender1.SetColorSistemaBorde(this.roundedPanel2, LP2MegaAutos.ColoresSistema.BackBackground);
            this.colorRoundedPanelExtender2.SetColorSistemaPanel(this.roundedPanel2, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.colorRoundedPanelExtender1.SetColorSistemaPanel(this.roundedPanel2, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanel2.Controls.Add(this.panel_logo_empresa);
            this.colorRoundedPanelExtender1.SetCorners(this.roundedPanel2, Plasmoid.Extensions.RectangleEdgeFilter.Left);
            this.colorRoundedPanelExtender2.SetCorners(this.roundedPanel2, Plasmoid.Extensions.RectangleEdgeFilter.Left);
            this.roundedPanel2.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.roundedPanel2.Location = new System.Drawing.Point(9, 18);
            this.roundedPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.roundedPanel2.MenosHeightBorde = 1;
            this.roundedPanel2.MenosHeightPanel = 1;
            this.roundedPanel2.MenosWidthBorde = 1;
            this.roundedPanel2.MenosWidthPanel = 1;
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.PorcLuzColorBorde = 0;
            this.roundedPanel2.Size = new System.Drawing.Size(80, 54);
            this.roundedPanel2.TabIndex = 26;
            this.tags.SetTag2(this.roundedPanel2, null);
            this.tags.SetTag3(this.roundedPanel2, null);
            this.tags.SetTagFontName(this.roundedPanel2, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.roundedPanel2, 10F);
            this.tags.SetTagFontStyle(this.roundedPanel2, System.Drawing.FontStyle.Regular);
            this.roundedPanel2.XBorde = 0;
            this.roundedPanel2.XPanel = 0;
            this.roundedPanel2.YBorde = 0;
            this.roundedPanel2.YPanel = 0;
            // 
            // panel_logo_empresa
            // 
            this.panel_logo_empresa.BackColor = System.Drawing.Color.Transparent;
            this.panel_logo_empresa.BackgroundImage = global::LP2MegaAutos.Properties.Resources.logo_megaautos;
            this.panel_logo_empresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_logo_empresa.Controls.Add(this.btnHome);
            this.panel_logo_empresa.Location = new System.Drawing.Point(13, 7);
            this.panel_logo_empresa.Name = "panel_logo_empresa";
            this.panel_logo_empresa.Size = new System.Drawing.Size(53, 44);
            this.panel_logo_empresa.TabIndex = 17;
            this.panel_logo_empresa.Tag = "logo";
            this.tags.SetTag2(this.panel_logo_empresa, null);
            this.tags.SetTag3(this.panel_logo_empresa, null);
            this.tags.SetTagFontName(this.panel_logo_empresa, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.panel_logo_empresa, 10F);
            this.tags.SetTagFontStyle(this.panel_logo_empresa, System.Drawing.FontStyle.Regular);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnHome.Location = new System.Drawing.Point(-13, -7);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(72, 54);
            this.btnHome.TabIndex = 20;
            this.tags.SetTag2(this.btnHome, null);
            this.tags.SetTag3(this.btnHome, null);
            this.tags.SetTagFontName(this.btnHome, fontsD.Montserrat);
            this.tags.SetTagFontSize(this.btnHome, 12F);
            this.tags.SetTagFontStyle(this.btnHome, System.Drawing.FontStyle.Bold);
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // panel_toggle_nocturno
            // 
            this.panel_toggle_nocturno.BackColor = System.Drawing.Color.Transparent;
            this.panel_toggle_nocturno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_toggle_nocturno.BackgroundImage")));
            this.panel_toggle_nocturno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_toggle_nocturno.Controls.Add(this.boton_toggle_nocturno);
            this.panel_toggle_nocturno.Location = new System.Drawing.Point(-6, 457);
            this.panel_toggle_nocturno.Name = "panel_toggle_nocturno";
            this.panel_toggle_nocturno.Size = new System.Drawing.Size(95, 60);
            this.panel_toggle_nocturno.TabIndex = 25;
            this.panel_toggle_nocturno.Tag = "button";
            this.tags.SetTag2(this.panel_toggle_nocturno, null);
            this.tags.SetTag3(this.panel_toggle_nocturno, null);
            this.tags.SetTagFontName(this.panel_toggle_nocturno, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.panel_toggle_nocturno, 10F);
            this.tags.SetTagFontStyle(this.panel_toggle_nocturno, System.Drawing.FontStyle.Regular);
            // 
            // boton_toggle_nocturno
            // 
            this.boton_toggle_nocturno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.boton_toggle_nocturno.BackgroundImage = global::LP2MegaAutos.Properties.Resources.toggle_modo_nocturno_desactivado;
            this.boton_toggle_nocturno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_toggle_nocturno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_toggle_nocturno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.boton_toggle_nocturno.FlatAppearance.BorderSize = 0;
            this.boton_toggle_nocturno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.boton_toggle_nocturno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.boton_toggle_nocturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_toggle_nocturno.Location = new System.Drawing.Point(48, 9);
            this.boton_toggle_nocturno.Name = "boton_toggle_nocturno";
            this.boton_toggle_nocturno.Size = new System.Drawing.Size(35, 35);
            this.boton_toggle_nocturno.TabIndex = 5;
            this.boton_toggle_nocturno.Tag = "toggle_oscuro";
            this.tags.SetTag2(this.boton_toggle_nocturno, null);
            this.tags.SetTag3(this.boton_toggle_nocturno, null);
            this.tags.SetTagFontName(this.boton_toggle_nocturno, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.boton_toggle_nocturno, 10F);
            this.tags.SetTagFontStyle(this.boton_toggle_nocturno, System.Drawing.FontStyle.Regular);
            this.boton_toggle_nocturno.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.boton_toggle_nocturno.UseVisualStyleBackColor = false;
            this.boton_toggle_nocturno.Click += new System.EventHandler(this.boton_toggle_nocturno_Click);
            // 
            // pnlBackBackground
            // 
            this.pnlBackBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.pnlBackBackground.Controls.Add(this.frontBackground);
            this.pnlBackBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackBackground.Location = new System.Drawing.Point(81, 32);
            this.pnlBackBackground.Name = "pnlBackBackground";
            this.pnlBackBackground.Size = new System.Drawing.Size(751, 520);
            this.pnlBackBackground.TabIndex = 4;
            this.pnlBackBackground.Tag = "background";
            this.tags.SetTag2(this.pnlBackBackground, null);
            this.tags.SetTag3(this.pnlBackBackground, null);
            this.tags.SetTagFontName(this.pnlBackBackground, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlBackBackground, 10F);
            this.tags.SetTagFontStyle(this.pnlBackBackground, System.Drawing.FontStyle.Regular);
            // 
            // frontBackground
            // 
            this.colorRoundedPanelExtender2.SetArcoRBorde(this.frontBackground, 15);
            this.colorRoundedPanelExtender1.SetArcoRBorde(this.frontBackground, 15);
            this.colorRoundedPanelExtender1.SetArcoRPanel(this.frontBackground, 15);
            this.colorRoundedPanelExtender2.SetArcoRPanel(this.frontBackground, 15);
            this.frontBackground.ArcRadiusBorde = 15;
            this.frontBackground.ArcRadiusPanel = 15;
            this.colorRoundedPanelExtender1.SetColorBorde(this.frontBackground, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246))))));
            this.colorRoundedPanelExtender2.SetColorBorde(this.frontBackground, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246))))));
            this.colorRoundedPanelExtender2.SetColorPanel(this.frontBackground, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.colorRoundedPanelExtender1.SetColorPanel(this.frontBackground, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.colorRoundedPanelExtender2.SetColorSistemaBorde(this.frontBackground, LP2MegaAutos.ColoresSistema.BackBackground);
            this.colorRoundedPanelExtender1.SetColorSistemaBorde(this.frontBackground, LP2MegaAutos.ColoresSistema.BackBackground);
            this.colorRoundedPanelExtender2.SetColorSistemaPanel(this.frontBackground, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.colorRoundedPanelExtender1.SetColorSistemaPanel(this.frontBackground, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.frontBackground.Controls.Add(this.roundedPanel1);
            this.colorRoundedPanelExtender1.SetCorners(this.frontBackground, Plasmoid.Extensions.RectangleEdgeFilter.All);
            this.colorRoundedPanelExtender2.SetCorners(this.frontBackground, Plasmoid.Extensions.RectangleEdgeFilter.All);
            this.frontBackground.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.frontBackground.Location = new System.Drawing.Point(70, 25);
            this.frontBackground.MenosHeightBorde = 1;
            this.frontBackground.MenosHeightPanel = 1;
            this.frontBackground.MenosWidthBorde = 1;
            this.frontBackground.MenosWidthPanel = 1;
            this.frontBackground.Name = "frontBackground";
            this.frontBackground.PorcLuzColorBorde = 0;
            this.frontBackground.Size = new System.Drawing.Size(611, 470);
            this.frontBackground.TabIndex = 0;
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
            // roundedPanel1
            // 
            this.colorRoundedPanelExtender2.SetArcoRBorde(this.roundedPanel1, 15);
            this.colorRoundedPanelExtender1.SetArcoRBorde(this.roundedPanel1, 15);
            this.colorRoundedPanelExtender1.SetArcoRPanel(this.roundedPanel1, 15);
            this.colorRoundedPanelExtender2.SetArcoRPanel(this.roundedPanel1, 15);
            this.roundedPanel1.ArcRadiusBorde = 15;
            this.roundedPanel1.ArcRadiusPanel = 15;
            this.colorRoundedPanelExtender1.SetColorBorde(this.roundedPanel1, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246))))));
            this.colorRoundedPanelExtender2.SetColorBorde(this.roundedPanel1, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246))))));
            this.colorRoundedPanelExtender2.SetColorPanel(this.roundedPanel1, System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161))))));
            this.colorRoundedPanelExtender1.SetColorPanel(this.roundedPanel1, System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161))))));
            this.colorRoundedPanelExtender2.SetColorSistemaBorde(this.roundedPanel1, LP2MegaAutos.ColoresSistema.BackBackground);
            this.colorRoundedPanelExtender1.SetColorSistemaBorde(this.roundedPanel1, LP2MegaAutos.ColoresSistema.BackBackground);
            this.colorRoundedPanelExtender2.SetColorSistemaPanel(this.roundedPanel1, LP2MegaAutos.ColoresSistema.PrincipalAzulMetalico);
            this.colorRoundedPanelExtender1.SetColorSistemaPanel(this.roundedPanel1, LP2MegaAutos.ColoresSistema.PrincipalAzulMetalico);
            this.colorRoundedPanelExtender1.SetCorners(this.roundedPanel1, Plasmoid.Extensions.RectangleEdgeFilter.Top);
            this.colorRoundedPanelExtender2.SetCorners(this.roundedPanel1, Plasmoid.Extensions.RectangleEdgeFilter.Top);
            this.roundedPanel1.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Top;
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 552);
            this.Controls.Add(this.pnlBackBackground);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.title_bar_2);
            this.Controls.Add(this.title_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tags.SetTag2(this, null);
            this.tags.SetTag3(this, null);
            this.tags.SetTagFontName(this, fontsD.Ninguno);
            this.tags.SetTagFontSize(this, 10F);
            this.tags.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.Text = "frmPrincipal";
            this.title_bar.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.panel_logo_empresa.ResumeLayout(false);
            this.panel_toggle_nocturno.ResumeLayout(false);
            this.pnlBackBackground.ResumeLayout(false);
            this.frontBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title_bar_2;
        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.Button boton_minimizar;
        private System.Windows.Forms.Button boton_cerrar;
        private System.Windows.Forms.Timer reloj_dark;
        private MetroFramework.Controls.MetroPanel panelMenu;
        private TagsExtender tags;
        private System.Windows.Forms.Panel panel_logo_empresa;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel_toggle_nocturno;
        private System.Windows.Forms.Button boton_toggle_nocturno;
        private System.Windows.Forms.Panel pnlBackBackground;
        private RoundedPanel frontBackground;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private ColorRoundedPanelExtender colorRoundedPanelExtender1;
        private ColorRoundedPanelExtender colorRoundedPanelExtender2;
    }
}