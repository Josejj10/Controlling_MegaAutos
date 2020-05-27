using System.Drawing;

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
            this.rpBtnMenuGenerarReporte = new LP2MegaAutos.RoundedPanel();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.rpBtnMenuServicios = new LP2MegaAutos.RoundedPanel();
            this.btnServicios = new System.Windows.Forms.Button();
            this.rpBtnMenuHome = new LP2MegaAutos.RoundedPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel_toggle_nocturno = new System.Windows.Forms.Panel();
            this.boton_toggle_nocturno = new System.Windows.Forms.Button();
            this.tags = new LP2MegaAutos.TagsExtender();
            this.pnlBackBackground = new System.Windows.Forms.Panel();
            this.rpMain = new LP2MegaAutos.RoundedPanel();
            this.title_bar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.rpBtnMenuGenerarReporte.SuspendLayout();
            this.rpBtnMenuServicios.SuspendLayout();
            this.rpBtnMenuHome.SuspendLayout();
            this.panel_toggle_nocturno.SuspendLayout();
            this.pnlBackBackground.SuspendLayout();
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
            this.panelMenu.Controls.Add(this.rpBtnMenuGenerarReporte);
            this.panelMenu.Controls.Add(this.rpBtnMenuServicios);
            this.panelMenu.Controls.Add(this.rpBtnMenuHome);
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
            // rpBtnMenuGenerarReporte
            // 
            this.rpBtnMenuGenerarReporte.ArcRadiusBorde = 15;
            this.rpBtnMenuGenerarReporte.ArcRadiusPanel = 15;
            this.rpBtnMenuGenerarReporte.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuGenerarReporte.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuGenerarReporte.Controls.Add(this.btnGenerarReporte);
            this.rpBtnMenuGenerarReporte.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.rpBtnMenuGenerarReporte.Location = new System.Drawing.Point(9, 83);
            this.rpBtnMenuGenerarReporte.Margin = new System.Windows.Forms.Padding(2);
            this.rpBtnMenuGenerarReporte.MenosHeightBorde = 1;
            this.rpBtnMenuGenerarReporte.MenosHeightPanel = 1;
            this.rpBtnMenuGenerarReporte.MenosWidthBorde = 1;
            this.rpBtnMenuGenerarReporte.MenosWidthPanel = 1;
            this.rpBtnMenuGenerarReporte.Name = "rpBtnMenuGenerarReporte";
            this.rpBtnMenuGenerarReporte.PorcLuzColorBorde = 0;
            this.rpBtnMenuGenerarReporte.Size = new System.Drawing.Size(80, 54);
            this.rpBtnMenuGenerarReporte.TabIndex = 28;
            this.tags.SetTag2(this.rpBtnMenuGenerarReporte, null);
            this.tags.SetTag3(this.rpBtnMenuGenerarReporte, null);
            this.tags.SetTagFontName(this.rpBtnMenuGenerarReporte, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpBtnMenuGenerarReporte, 10F);
            this.tags.SetTagFontStyle(this.rpBtnMenuGenerarReporte, System.Drawing.FontStyle.Regular);
            this.rpBtnMenuGenerarReporte.XBorde = 0;
            this.rpBtnMenuGenerarReporte.XPanel = 0;
            this.rpBtnMenuGenerarReporte.YBorde = 0;
            this.rpBtnMenuGenerarReporte.YPanel = 0;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarReporte.BackgroundImage = global::LP2MegaAutos.Properties.Resources.logo_megaautos;
            this.btnGenerarReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenerarReporte.FlatAppearance.BorderSize = 0;
            this.btnGenerarReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGenerarReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnGenerarReporte.Location = new System.Drawing.Point(10, 3);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(62, 48);
            this.btnGenerarReporte.TabIndex = 20;
            this.tags.SetTag2(this.btnGenerarReporte, null);
            this.tags.SetTag3(this.btnGenerarReporte, null);
            this.tags.SetTagFontName(this.btnGenerarReporte, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnGenerarReporte, 12F);
            this.tags.SetTagFontStyle(this.btnGenerarReporte, System.Drawing.FontStyle.Bold);
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // rpBtnMenuServicios
            // 
            this.rpBtnMenuServicios.ArcRadiusBorde = 15;
            this.rpBtnMenuServicios.ArcRadiusPanel = 15;
            this.rpBtnMenuServicios.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuServicios.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuServicios.Controls.Add(this.btnServicios);
            this.rpBtnMenuServicios.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.rpBtnMenuServicios.Location = new System.Drawing.Point(9, 147);
            this.rpBtnMenuServicios.Margin = new System.Windows.Forms.Padding(2);
            this.rpBtnMenuServicios.MenosHeightBorde = 1;
            this.rpBtnMenuServicios.MenosHeightPanel = 1;
            this.rpBtnMenuServicios.MenosWidthBorde = 1;
            this.rpBtnMenuServicios.MenosWidthPanel = 1;
            this.rpBtnMenuServicios.Name = "rpBtnMenuServicios";
            this.rpBtnMenuServicios.PorcLuzColorBorde = 0;
            this.rpBtnMenuServicios.Size = new System.Drawing.Size(80, 54);
            this.rpBtnMenuServicios.TabIndex = 27;
            this.tags.SetTag2(this.rpBtnMenuServicios, null);
            this.tags.SetTag3(this.rpBtnMenuServicios, null);
            this.tags.SetTagFontName(this.rpBtnMenuServicios, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpBtnMenuServicios, 10F);
            this.tags.SetTagFontStyle(this.rpBtnMenuServicios, System.Drawing.FontStyle.Regular);
            this.rpBtnMenuServicios.XBorde = 0;
            this.rpBtnMenuServicios.XPanel = 0;
            this.rpBtnMenuServicios.YBorde = 0;
            this.rpBtnMenuServicios.YPanel = 0;
            // 
            // btnServicios
            // 
            this.btnServicios.BackColor = System.Drawing.Color.Transparent;
            this.btnServicios.BackgroundImage = global::LP2MegaAutos.Properties.Resources.logo_megaautos;
            this.btnServicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnServicios.Location = new System.Drawing.Point(10, 3);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(62, 48);
            this.btnServicios.TabIndex = 20;
            this.tags.SetTag2(this.btnServicios, null);
            this.tags.SetTag3(this.btnServicios, null);
            this.tags.SetTagFontName(this.btnServicios, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnServicios, 12F);
            this.tags.SetTagFontStyle(this.btnServicios, System.Drawing.FontStyle.Bold);
            this.btnServicios.UseVisualStyleBackColor = false;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // rpBtnMenuHome
            // 
            this.rpBtnMenuHome.ArcRadiusBorde = 15;
            this.rpBtnMenuHome.ArcRadiusPanel = 15;
            this.rpBtnMenuHome.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuHome.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpBtnMenuHome.Controls.Add(this.btnHome);
            this.rpBtnMenuHome.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.rpBtnMenuHome.Location = new System.Drawing.Point(9, 18);
            this.rpBtnMenuHome.Margin = new System.Windows.Forms.Padding(2);
            this.rpBtnMenuHome.MenosHeightBorde = 1;
            this.rpBtnMenuHome.MenosHeightPanel = 1;
            this.rpBtnMenuHome.MenosWidthBorde = 1;
            this.rpBtnMenuHome.MenosWidthPanel = 1;
            this.rpBtnMenuHome.Name = "rpBtnMenuHome";
            this.rpBtnMenuHome.PorcLuzColorBorde = 0;
            this.rpBtnMenuHome.Size = new System.Drawing.Size(80, 54);
            this.rpBtnMenuHome.TabIndex = 26;
            this.tags.SetTag2(this.rpBtnMenuHome, null);
            this.tags.SetTag3(this.rpBtnMenuHome, null);
            this.tags.SetTagFontName(this.rpBtnMenuHome, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpBtnMenuHome, 10F);
            this.tags.SetTagFontStyle(this.rpBtnMenuHome, System.Drawing.FontStyle.Regular);
            this.rpBtnMenuHome.XBorde = 0;
            this.rpBtnMenuHome.XPanel = 0;
            this.rpBtnMenuHome.YBorde = 0;
            this.rpBtnMenuHome.YPanel = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::LP2MegaAutos.Properties.Resources.logo_megaautos;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnHome.Location = new System.Drawing.Point(10, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(62, 48);
            this.btnHome.TabIndex = 20;
            this.tags.SetTag2(this.btnHome, null);
            this.tags.SetTag3(this.btnHome, null);
            this.tags.SetTagFontName(this.btnHome, fontsD.Montserrat);
            this.tags.SetTagFontSize(this.btnHome, 12F);
            this.tags.SetTagFontStyle(this.btnHome, System.Drawing.FontStyle.Bold);
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            this.pnlBackBackground.Controls.Add(this.rpMain);
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
            // rpMain
            // 
            this.rpMain.ArcRadiusBorde = 15;
            this.rpMain.ArcRadiusPanel = 15;
            this.rpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpMain.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpMain.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rpMain.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpMain.Location = new System.Drawing.Point(70, 25);
            this.rpMain.MenosHeightBorde = 1;
            this.rpMain.MenosHeightPanel = 1;
            this.rpMain.MenosWidthBorde = 1;
            this.rpMain.MenosWidthPanel = 1;
            this.rpMain.Name = "rpMain";
            this.rpMain.PorcLuzColorBorde = 0;
            this.rpMain.Size = new System.Drawing.Size(611, 470);
            this.rpMain.TabIndex = 0;
            this.tags.SetTag2(this.rpMain, null);
            this.tags.SetTag3(this.rpMain, null);
            this.tags.SetTagFontName(this.rpMain, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpMain, 10F);
            this.tags.SetTagFontStyle(this.rpMain, System.Drawing.FontStyle.Regular);
            this.rpMain.XBorde = 0;
            this.rpMain.XPanel = 0;
            this.rpMain.YBorde = 0;
            this.rpMain.YPanel = 0;
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
            this.rpBtnMenuGenerarReporte.ResumeLayout(false);
            this.rpBtnMenuServicios.ResumeLayout(false);
            this.rpBtnMenuHome.ResumeLayout(false);
            this.panel_toggle_nocturno.ResumeLayout(false);
            this.pnlBackBackground.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel_toggle_nocturno;
        private System.Windows.Forms.Button boton_toggle_nocturno;
        private System.Windows.Forms.Panel pnlBackBackground;
        private RoundedPanel rpMain;
        private RoundedPanel rpBtnMenuHome;
        private System.Windows.Forms.Button btnHome;
        private RoundedPanel rpBtnMenuServicios;
        private System.Windows.Forms.Button btnServicios;
        private RoundedPanel rpBtnMenuGenerarReporte;
        private System.Windows.Forms.Button btnGenerarReporte;
    }
}