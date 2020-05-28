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
            this.rpBtnMenuCerrarSesion = new LP2MegaAutos.RoundedPanel();
            this.btnMenuCerrarSesion = new System.Windows.Forms.Button();
            this.rpBtnMenuReportes = new LP2MegaAutos.RoundedPanel();
            this.btnMenuReportes = new System.Windows.Forms.Button();
            this.rpBtnMenuAjustes = new LP2MegaAutos.RoundedPanel();
            this.btnMenuAjustes = new System.Windows.Forms.Button();
            this.rpBtnMenuSedes = new LP2MegaAutos.RoundedPanel();
            this.btnMenuSedes = new System.Windows.Forms.Button();
            this.rpBtnMenuUsuarios = new LP2MegaAutos.RoundedPanel();
            this.btnMenuUsuarios = new System.Windows.Forms.Button();
            this.rpBtnMenuClientes = new LP2MegaAutos.RoundedPanel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.rpBtnMenuEmpresa = new LP2MegaAutos.RoundedPanel();
            this.btnMenuEmpresa = new System.Windows.Forms.Button();
            this.rpBtnMenuDrivers = new LP2MegaAutos.RoundedPanel();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.rpBtnMenuAreasTrabajo = new LP2MegaAutos.RoundedPanel();
            this.btnAreasTrabajo = new System.Windows.Forms.Button();
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
            this.pntIniGen = new LP2MegaAutos.pantallaInicioGerente();
            this.title_bar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.rpBtnMenuCerrarSesion.SuspendLayout();
            this.rpBtnMenuReportes.SuspendLayout();
            this.rpBtnMenuAjustes.SuspendLayout();
            this.rpBtnMenuSedes.SuspendLayout();
            this.rpBtnMenuUsuarios.SuspendLayout();
            this.rpBtnMenuClientes.SuspendLayout();
            this.rpBtnMenuEmpresa.SuspendLayout();
            this.rpBtnMenuDrivers.SuspendLayout();
            this.rpBtnMenuAreasTrabajo.SuspendLayout();
            this.rpBtnMenuGenerarReporte.SuspendLayout();
            this.rpBtnMenuServicios.SuspendLayout();
            this.rpBtnMenuHome.SuspendLayout();
            this.panel_toggle_nocturno.SuspendLayout();
            this.pnlBackBackground.SuspendLayout();
            this.rpMain.SuspendLayout();
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
            this.panelMenu.Controls.Add(this.rpBtnMenuCerrarSesion);
            this.panelMenu.Controls.Add(this.rpBtnMenuReportes);
            this.panelMenu.Controls.Add(this.rpBtnMenuAjustes);
            this.panelMenu.Controls.Add(this.rpBtnMenuSedes);
            this.panelMenu.Controls.Add(this.rpBtnMenuUsuarios);
            this.panelMenu.Controls.Add(this.rpBtnMenuClientes);
            this.panelMenu.Controls.Add(this.rpBtnMenuEmpresa);
            this.panelMenu.Controls.Add(this.rpBtnMenuDrivers);
            this.panelMenu.Controls.Add(this.rpBtnMenuAreasTrabajo);
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
            // rpBtnMenuCerrarSesion
            // 
            this.rpBtnMenuCerrarSesion.ArcRadiusBorde = 15;
            this.rpBtnMenuCerrarSesion.ArcRadiusPanel = 15;
            this.rpBtnMenuCerrarSesion.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuCerrarSesion.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuCerrarSesion.Controls.Add(this.btnMenuCerrarSesion);
            this.rpBtnMenuCerrarSesion.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.rpBtnMenuCerrarSesion.Location = new System.Drawing.Point(30, 441);
            this.rpBtnMenuCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.rpBtnMenuCerrarSesion.MenosHeightBorde = 1;
            this.rpBtnMenuCerrarSesion.MenosHeightPanel = 1;
            this.rpBtnMenuCerrarSesion.MenosWidthBorde = 1;
            this.rpBtnMenuCerrarSesion.MenosWidthPanel = 1;
            this.rpBtnMenuCerrarSesion.Name = "rpBtnMenuCerrarSesion";
            this.rpBtnMenuCerrarSesion.PorcLuzColorBorde = 0;
            this.rpBtnMenuCerrarSesion.Size = new System.Drawing.Size(59, 11);
            this.rpBtnMenuCerrarSesion.TabIndex = 37;
            this.tags.SetTag2(this.rpBtnMenuCerrarSesion, null);
            this.tags.SetTag3(this.rpBtnMenuCerrarSesion, null);
            this.tags.SetTagFontName(this.rpBtnMenuCerrarSesion, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpBtnMenuCerrarSesion, 10F);
            this.tags.SetTagFontStyle(this.rpBtnMenuCerrarSesion, System.Drawing.FontStyle.Regular);
            this.rpBtnMenuCerrarSesion.XBorde = 0;
            this.rpBtnMenuCerrarSesion.XPanel = 0;
            this.rpBtnMenuCerrarSesion.YBorde = 0;
            this.rpBtnMenuCerrarSesion.YPanel = 0;
            // 
            // btnMenuCerrarSesion
            // 
            this.btnMenuCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuCerrarSesion.BackgroundImage = global::LP2MegaAutos.Properties.Resources.logo_megaautos;
            this.btnMenuCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnMenuCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenuCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenuCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCerrarSesion.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenuCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnMenuCerrarSesion.Location = new System.Drawing.Point(6, 3);
            this.btnMenuCerrarSesion.Name = "btnMenuCerrarSesion";
            this.btnMenuCerrarSesion.Size = new System.Drawing.Size(41, 10);
            this.btnMenuCerrarSesion.TabIndex = 20;
            this.tags.SetTag2(this.btnMenuCerrarSesion, null);
            this.tags.SetTag3(this.btnMenuCerrarSesion, null);
            this.tags.SetTagFontName(this.btnMenuCerrarSesion, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnMenuCerrarSesion, 12F);
            this.tags.SetTagFontStyle(this.btnMenuCerrarSesion, System.Drawing.FontStyle.Bold);
            this.btnMenuCerrarSesion.UseVisualStyleBackColor = false;
            this.btnMenuCerrarSesion.Click += new System.EventHandler(this.btnMenuCerrarSesion_Click);
            // 
            // rpBtnMenuReportes
            // 
            this.rpBtnMenuReportes.ArcRadiusBorde = 15;
            this.rpBtnMenuReportes.ArcRadiusPanel = 15;
            this.rpBtnMenuReportes.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuReportes.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuReportes.Controls.Add(this.btnMenuReportes);
            this.rpBtnMenuReportes.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.rpBtnMenuReportes.Location = new System.Drawing.Point(30, 402);
            this.rpBtnMenuReportes.Margin = new System.Windows.Forms.Padding(2);
            this.rpBtnMenuReportes.MenosHeightBorde = 1;
            this.rpBtnMenuReportes.MenosHeightPanel = 1;
            this.rpBtnMenuReportes.MenosWidthBorde = 1;
            this.rpBtnMenuReportes.MenosWidthPanel = 1;
            this.rpBtnMenuReportes.Name = "rpBtnMenuReportes";
            this.rpBtnMenuReportes.PorcLuzColorBorde = 0;
            this.rpBtnMenuReportes.Size = new System.Drawing.Size(59, 35);
            this.rpBtnMenuReportes.TabIndex = 36;
            this.tags.SetTag2(this.rpBtnMenuReportes, null);
            this.tags.SetTag3(this.rpBtnMenuReportes, null);
            this.tags.SetTagFontName(this.rpBtnMenuReportes, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpBtnMenuReportes, 10F);
            this.tags.SetTagFontStyle(this.rpBtnMenuReportes, System.Drawing.FontStyle.Regular);
            this.rpBtnMenuReportes.XBorde = 0;
            this.rpBtnMenuReportes.XPanel = 0;
            this.rpBtnMenuReportes.YBorde = 0;
            this.rpBtnMenuReportes.YPanel = 0;
            // 
            // btnMenuReportes
            // 
            this.btnMenuReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuReportes.BackgroundImage = global::LP2MegaAutos.Properties.Resources.logo_megaautos;
            this.btnMenuReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuReportes.FlatAppearance.BorderSize = 0;
            this.btnMenuReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenuReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenuReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuReportes.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenuReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnMenuReportes.Location = new System.Drawing.Point(6, 3);
            this.btnMenuReportes.Name = "btnMenuReportes";
            this.btnMenuReportes.Size = new System.Drawing.Size(41, 29);
            this.btnMenuReportes.TabIndex = 20;
            this.tags.SetTag2(this.btnMenuReportes, null);
            this.tags.SetTag3(this.btnMenuReportes, null);
            this.tags.SetTagFontName(this.btnMenuReportes, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnMenuReportes, 12F);
            this.tags.SetTagFontStyle(this.btnMenuReportes, System.Drawing.FontStyle.Bold);
            this.btnMenuReportes.UseVisualStyleBackColor = false;
            this.btnMenuReportes.Click += new System.EventHandler(this.btnMenuReportes_Click);
            // 
            // rpBtnMenuAjustes
            // 
            this.rpBtnMenuAjustes.ArcRadiusBorde = 15;
            this.rpBtnMenuAjustes.ArcRadiusPanel = 15;
            this.rpBtnMenuAjustes.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuAjustes.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuAjustes.Controls.Add(this.btnMenuAjustes);
            this.rpBtnMenuAjustes.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.rpBtnMenuAjustes.Location = new System.Drawing.Point(30, 365);
            this.rpBtnMenuAjustes.Margin = new System.Windows.Forms.Padding(2);
            this.rpBtnMenuAjustes.MenosHeightBorde = 1;
            this.rpBtnMenuAjustes.MenosHeightPanel = 1;
            this.rpBtnMenuAjustes.MenosWidthBorde = 1;
            this.rpBtnMenuAjustes.MenosWidthPanel = 1;
            this.rpBtnMenuAjustes.Name = "rpBtnMenuAjustes";
            this.rpBtnMenuAjustes.PorcLuzColorBorde = 0;
            this.rpBtnMenuAjustes.Size = new System.Drawing.Size(59, 35);
            this.rpBtnMenuAjustes.TabIndex = 35;
            this.tags.SetTag2(this.rpBtnMenuAjustes, null);
            this.tags.SetTag3(this.rpBtnMenuAjustes, null);
            this.tags.SetTagFontName(this.rpBtnMenuAjustes, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpBtnMenuAjustes, 10F);
            this.tags.SetTagFontStyle(this.rpBtnMenuAjustes, System.Drawing.FontStyle.Regular);
            this.rpBtnMenuAjustes.XBorde = 0;
            this.rpBtnMenuAjustes.XPanel = 0;
            this.rpBtnMenuAjustes.YBorde = 0;
            this.rpBtnMenuAjustes.YPanel = 0;
            // 
            // btnMenuAjustes
            // 
            this.btnMenuAjustes.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuAjustes.BackgroundImage = global::LP2MegaAutos.Properties.Resources.logo_megaautos;
            this.btnMenuAjustes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuAjustes.FlatAppearance.BorderSize = 0;
            this.btnMenuAjustes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenuAjustes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenuAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAjustes.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenuAjustes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnMenuAjustes.Location = new System.Drawing.Point(6, 3);
            this.btnMenuAjustes.Name = "btnMenuAjustes";
            this.btnMenuAjustes.Size = new System.Drawing.Size(41, 29);
            this.btnMenuAjustes.TabIndex = 20;
            this.tags.SetTag2(this.btnMenuAjustes, null);
            this.tags.SetTag3(this.btnMenuAjustes, null);
            this.tags.SetTagFontName(this.btnMenuAjustes, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnMenuAjustes, 12F);
            this.tags.SetTagFontStyle(this.btnMenuAjustes, System.Drawing.FontStyle.Bold);
            this.btnMenuAjustes.UseVisualStyleBackColor = false;
            this.btnMenuAjustes.Click += new System.EventHandler(this.btnMenuAjustes_Click);
            // 
            // rpBtnMenuSedes
            // 
            this.rpBtnMenuSedes.ArcRadiusBorde = 15;
            this.rpBtnMenuSedes.ArcRadiusPanel = 15;
            this.rpBtnMenuSedes.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuSedes.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuSedes.Controls.Add(this.btnMenuSedes);
            this.rpBtnMenuSedes.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.rpBtnMenuSedes.Location = new System.Drawing.Point(30, 326);
            this.rpBtnMenuSedes.Margin = new System.Windows.Forms.Padding(2);
            this.rpBtnMenuSedes.MenosHeightBorde = 1;
            this.rpBtnMenuSedes.MenosHeightPanel = 1;
            this.rpBtnMenuSedes.MenosWidthBorde = 1;
            this.rpBtnMenuSedes.MenosWidthPanel = 1;
            this.rpBtnMenuSedes.Name = "rpBtnMenuSedes";
            this.rpBtnMenuSedes.PorcLuzColorBorde = 0;
            this.rpBtnMenuSedes.Size = new System.Drawing.Size(59, 35);
            this.rpBtnMenuSedes.TabIndex = 34;
            this.tags.SetTag2(this.rpBtnMenuSedes, null);
            this.tags.SetTag3(this.rpBtnMenuSedes, null);
            this.tags.SetTagFontName(this.rpBtnMenuSedes, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpBtnMenuSedes, 10F);
            this.tags.SetTagFontStyle(this.rpBtnMenuSedes, System.Drawing.FontStyle.Regular);
            this.rpBtnMenuSedes.XBorde = 0;
            this.rpBtnMenuSedes.XPanel = 0;
            this.rpBtnMenuSedes.YBorde = 0;
            this.rpBtnMenuSedes.YPanel = 0;
            // 
            // btnMenuSedes
            // 
            this.btnMenuSedes.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuSedes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuSedes.BackgroundImage")));
            this.btnMenuSedes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuSedes.FlatAppearance.BorderSize = 0;
            this.btnMenuSedes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenuSedes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenuSedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSedes.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenuSedes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnMenuSedes.Location = new System.Drawing.Point(6, 3);
            this.btnMenuSedes.Name = "btnMenuSedes";
            this.btnMenuSedes.Size = new System.Drawing.Size(41, 29);
            this.btnMenuSedes.TabIndex = 20;
            this.tags.SetTag2(this.btnMenuSedes, null);
            this.tags.SetTag3(this.btnMenuSedes, null);
            this.tags.SetTagFontName(this.btnMenuSedes, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnMenuSedes, 12F);
            this.tags.SetTagFontStyle(this.btnMenuSedes, System.Drawing.FontStyle.Bold);
            this.btnMenuSedes.UseVisualStyleBackColor = false;
            this.btnMenuSedes.Click += new System.EventHandler(this.btnMenuSedes_Click);
            // 
            // rpBtnMenuUsuarios
            // 
            this.rpBtnMenuUsuarios.ArcRadiusBorde = 15;
            this.rpBtnMenuUsuarios.ArcRadiusPanel = 15;
            this.rpBtnMenuUsuarios.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuUsuarios.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuUsuarios.Controls.Add(this.btnMenuUsuarios);
            this.rpBtnMenuUsuarios.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.rpBtnMenuUsuarios.Location = new System.Drawing.Point(30, 287);
            this.rpBtnMenuUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.rpBtnMenuUsuarios.MenosHeightBorde = 1;
            this.rpBtnMenuUsuarios.MenosHeightPanel = 1;
            this.rpBtnMenuUsuarios.MenosWidthBorde = 1;
            this.rpBtnMenuUsuarios.MenosWidthPanel = 1;
            this.rpBtnMenuUsuarios.Name = "rpBtnMenuUsuarios";
            this.rpBtnMenuUsuarios.PorcLuzColorBorde = 0;
            this.rpBtnMenuUsuarios.Size = new System.Drawing.Size(59, 35);
            this.rpBtnMenuUsuarios.TabIndex = 33;
            this.tags.SetTag2(this.rpBtnMenuUsuarios, null);
            this.tags.SetTag3(this.rpBtnMenuUsuarios, null);
            this.tags.SetTagFontName(this.rpBtnMenuUsuarios, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpBtnMenuUsuarios, 10F);
            this.tags.SetTagFontStyle(this.rpBtnMenuUsuarios, System.Drawing.FontStyle.Regular);
            this.rpBtnMenuUsuarios.XBorde = 0;
            this.rpBtnMenuUsuarios.XPanel = 0;
            this.rpBtnMenuUsuarios.YBorde = 0;
            this.rpBtnMenuUsuarios.YPanel = 0;
            // 
            // btnMenuUsuarios
            // 
            this.btnMenuUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuUsuarios.BackgroundImage = global::LP2MegaAutos.Properties.Resources.logo_megaautos;
            this.btnMenuUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuUsuarios.FlatAppearance.BorderSize = 0;
            this.btnMenuUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenuUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenuUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuUsuarios.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenuUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnMenuUsuarios.Location = new System.Drawing.Point(6, 3);
            this.btnMenuUsuarios.Name = "btnMenuUsuarios";
            this.btnMenuUsuarios.Size = new System.Drawing.Size(41, 29);
            this.btnMenuUsuarios.TabIndex = 20;
            this.tags.SetTag2(this.btnMenuUsuarios, null);
            this.tags.SetTag3(this.btnMenuUsuarios, null);
            this.tags.SetTagFontName(this.btnMenuUsuarios, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnMenuUsuarios, 12F);
            this.tags.SetTagFontStyle(this.btnMenuUsuarios, System.Drawing.FontStyle.Bold);
            this.btnMenuUsuarios.UseVisualStyleBackColor = false;
            this.btnMenuUsuarios.Click += new System.EventHandler(this.btnMenuUsuarios_Click);
            // 
            // rpBtnMenuClientes
            // 
            this.rpBtnMenuClientes.ArcRadiusBorde = 15;
            this.rpBtnMenuClientes.ArcRadiusPanel = 15;
            this.rpBtnMenuClientes.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuClientes.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuClientes.Controls.Add(this.btnClientes);
            this.rpBtnMenuClientes.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.rpBtnMenuClientes.Location = new System.Drawing.Point(30, 248);
            this.rpBtnMenuClientes.Margin = new System.Windows.Forms.Padding(2);
            this.rpBtnMenuClientes.MenosHeightBorde = 1;
            this.rpBtnMenuClientes.MenosHeightPanel = 1;
            this.rpBtnMenuClientes.MenosWidthBorde = 1;
            this.rpBtnMenuClientes.MenosWidthPanel = 1;
            this.rpBtnMenuClientes.Name = "rpBtnMenuClientes";
            this.rpBtnMenuClientes.PorcLuzColorBorde = 0;
            this.rpBtnMenuClientes.Size = new System.Drawing.Size(59, 35);
            this.rpBtnMenuClientes.TabIndex = 32;
            this.tags.SetTag2(this.rpBtnMenuClientes, null);
            this.tags.SetTag3(this.rpBtnMenuClientes, null);
            this.tags.SetTagFontName(this.rpBtnMenuClientes, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpBtnMenuClientes, 10F);
            this.tags.SetTagFontStyle(this.rpBtnMenuClientes, System.Drawing.FontStyle.Regular);
            this.rpBtnMenuClientes.XBorde = 0;
            this.rpBtnMenuClientes.XPanel = 0;
            this.rpBtnMenuClientes.YBorde = 0;
            this.rpBtnMenuClientes.YPanel = 0;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackgroundImage = global::LP2MegaAutos.Properties.Resources.logo_megaautos;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnClientes.Location = new System.Drawing.Point(6, 3);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(41, 29);
            this.btnClientes.TabIndex = 20;
            this.tags.SetTag2(this.btnClientes, null);
            this.tags.SetTag3(this.btnClientes, null);
            this.tags.SetTagFontName(this.btnClientes, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnClientes, 12F);
            this.tags.SetTagFontStyle(this.btnClientes, System.Drawing.FontStyle.Bold);
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // rpBtnMenuEmpresa
            // 
            this.rpBtnMenuEmpresa.ArcRadiusBorde = 15;
            this.rpBtnMenuEmpresa.ArcRadiusPanel = 15;
            this.rpBtnMenuEmpresa.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuEmpresa.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuEmpresa.Controls.Add(this.btnMenuEmpresa);
            this.rpBtnMenuEmpresa.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.rpBtnMenuEmpresa.Location = new System.Drawing.Point(30, 209);
            this.rpBtnMenuEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.rpBtnMenuEmpresa.MenosHeightBorde = 1;
            this.rpBtnMenuEmpresa.MenosHeightPanel = 1;
            this.rpBtnMenuEmpresa.MenosWidthBorde = 1;
            this.rpBtnMenuEmpresa.MenosWidthPanel = 1;
            this.rpBtnMenuEmpresa.Name = "rpBtnMenuEmpresa";
            this.rpBtnMenuEmpresa.PorcLuzColorBorde = 0;
            this.rpBtnMenuEmpresa.Size = new System.Drawing.Size(59, 35);
            this.rpBtnMenuEmpresa.TabIndex = 31;
            this.tags.SetTag2(this.rpBtnMenuEmpresa, null);
            this.tags.SetTag3(this.rpBtnMenuEmpresa, null);
            this.tags.SetTagFontName(this.rpBtnMenuEmpresa, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpBtnMenuEmpresa, 10F);
            this.tags.SetTagFontStyle(this.rpBtnMenuEmpresa, System.Drawing.FontStyle.Regular);
            this.rpBtnMenuEmpresa.XBorde = 0;
            this.rpBtnMenuEmpresa.XPanel = 0;
            this.rpBtnMenuEmpresa.YBorde = 0;
            this.rpBtnMenuEmpresa.YPanel = 0;
            // 
            // btnMenuEmpresa
            // 
            this.btnMenuEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuEmpresa.BackgroundImage = global::LP2MegaAutos.Properties.Resources.logo_megaautos;
            this.btnMenuEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuEmpresa.FlatAppearance.BorderSize = 0;
            this.btnMenuEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenuEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenuEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEmpresa.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenuEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnMenuEmpresa.Location = new System.Drawing.Point(6, 3);
            this.btnMenuEmpresa.Name = "btnMenuEmpresa";
            this.btnMenuEmpresa.Size = new System.Drawing.Size(41, 29);
            this.btnMenuEmpresa.TabIndex = 20;
            this.tags.SetTag2(this.btnMenuEmpresa, null);
            this.tags.SetTag3(this.btnMenuEmpresa, null);
            this.tags.SetTagFontName(this.btnMenuEmpresa, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnMenuEmpresa, 12F);
            this.tags.SetTagFontStyle(this.btnMenuEmpresa, System.Drawing.FontStyle.Bold);
            this.btnMenuEmpresa.UseVisualStyleBackColor = false;
            this.btnMenuEmpresa.Click += new System.EventHandler(this.btnMenuEmpresa_Click);
            // 
            // rpBtnMenuDrivers
            // 
            this.rpBtnMenuDrivers.ArcRadiusBorde = 15;
            this.rpBtnMenuDrivers.ArcRadiusPanel = 15;
            this.rpBtnMenuDrivers.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuDrivers.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuDrivers.Controls.Add(this.btnDrivers);
            this.rpBtnMenuDrivers.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.rpBtnMenuDrivers.Location = new System.Drawing.Point(30, 170);
            this.rpBtnMenuDrivers.Margin = new System.Windows.Forms.Padding(2);
            this.rpBtnMenuDrivers.MenosHeightBorde = 1;
            this.rpBtnMenuDrivers.MenosHeightPanel = 1;
            this.rpBtnMenuDrivers.MenosWidthBorde = 1;
            this.rpBtnMenuDrivers.MenosWidthPanel = 1;
            this.rpBtnMenuDrivers.Name = "rpBtnMenuDrivers";
            this.rpBtnMenuDrivers.PorcLuzColorBorde = 0;
            this.rpBtnMenuDrivers.Size = new System.Drawing.Size(59, 35);
            this.rpBtnMenuDrivers.TabIndex = 30;
            this.tags.SetTag2(this.rpBtnMenuDrivers, null);
            this.tags.SetTag3(this.rpBtnMenuDrivers, null);
            this.tags.SetTagFontName(this.rpBtnMenuDrivers, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpBtnMenuDrivers, 10F);
            this.tags.SetTagFontStyle(this.rpBtnMenuDrivers, System.Drawing.FontStyle.Regular);
            this.rpBtnMenuDrivers.XBorde = 0;
            this.rpBtnMenuDrivers.XPanel = 0;
            this.rpBtnMenuDrivers.YBorde = 0;
            this.rpBtnMenuDrivers.YPanel = 0;
            // 
            // btnDrivers
            // 
            this.btnDrivers.BackColor = System.Drawing.Color.Transparent;
            this.btnDrivers.BackgroundImage = global::LP2MegaAutos.Properties.Resources.logo_megaautos;
            this.btnDrivers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDrivers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnDrivers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnDrivers.Location = new System.Drawing.Point(6, 3);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(41, 29);
            this.btnDrivers.TabIndex = 20;
            this.tags.SetTag2(this.btnDrivers, null);
            this.tags.SetTag3(this.btnDrivers, null);
            this.tags.SetTagFontName(this.btnDrivers, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnDrivers, 12F);
            this.tags.SetTagFontStyle(this.btnDrivers, System.Drawing.FontStyle.Bold);
            this.btnDrivers.UseVisualStyleBackColor = false;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // rpBtnMenuAreasTrabajo
            // 
            this.rpBtnMenuAreasTrabajo.ArcRadiusBorde = 15;
            this.rpBtnMenuAreasTrabajo.ArcRadiusPanel = 15;
            this.rpBtnMenuAreasTrabajo.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuAreasTrabajo.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuAreasTrabajo.Controls.Add(this.btnAreasTrabajo);
            this.rpBtnMenuAreasTrabajo.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.rpBtnMenuAreasTrabajo.Location = new System.Drawing.Point(30, 131);
            this.rpBtnMenuAreasTrabajo.Margin = new System.Windows.Forms.Padding(2);
            this.rpBtnMenuAreasTrabajo.MenosHeightBorde = 1;
            this.rpBtnMenuAreasTrabajo.MenosHeightPanel = 1;
            this.rpBtnMenuAreasTrabajo.MenosWidthBorde = 1;
            this.rpBtnMenuAreasTrabajo.MenosWidthPanel = 1;
            this.rpBtnMenuAreasTrabajo.Name = "rpBtnMenuAreasTrabajo";
            this.rpBtnMenuAreasTrabajo.PorcLuzColorBorde = 0;
            this.rpBtnMenuAreasTrabajo.Size = new System.Drawing.Size(59, 35);
            this.rpBtnMenuAreasTrabajo.TabIndex = 29;
            this.tags.SetTag2(this.rpBtnMenuAreasTrabajo, null);
            this.tags.SetTag3(this.rpBtnMenuAreasTrabajo, null);
            this.tags.SetTagFontName(this.rpBtnMenuAreasTrabajo, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpBtnMenuAreasTrabajo, 10F);
            this.tags.SetTagFontStyle(this.rpBtnMenuAreasTrabajo, System.Drawing.FontStyle.Regular);
            this.rpBtnMenuAreasTrabajo.XBorde = 0;
            this.rpBtnMenuAreasTrabajo.XPanel = 0;
            this.rpBtnMenuAreasTrabajo.YBorde = 0;
            this.rpBtnMenuAreasTrabajo.YPanel = 0;
            // 
            // btnAreasTrabajo
            // 
            this.btnAreasTrabajo.BackColor = System.Drawing.Color.Transparent;
            this.btnAreasTrabajo.BackgroundImage = global::LP2MegaAutos.Properties.Resources.logo_megaautos;
            this.btnAreasTrabajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAreasTrabajo.FlatAppearance.BorderSize = 0;
            this.btnAreasTrabajo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAreasTrabajo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAreasTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAreasTrabajo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnAreasTrabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnAreasTrabajo.Location = new System.Drawing.Point(6, 3);
            this.btnAreasTrabajo.Name = "btnAreasTrabajo";
            this.btnAreasTrabajo.Size = new System.Drawing.Size(41, 29);
            this.btnAreasTrabajo.TabIndex = 20;
            this.tags.SetTag2(this.btnAreasTrabajo, null);
            this.tags.SetTag3(this.btnAreasTrabajo, null);
            this.tags.SetTagFontName(this.btnAreasTrabajo, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnAreasTrabajo, 12F);
            this.tags.SetTagFontStyle(this.btnAreasTrabajo, System.Drawing.FontStyle.Bold);
            this.btnAreasTrabajo.UseVisualStyleBackColor = false;
            this.btnAreasTrabajo.Click += new System.EventHandler(this.btnAreasTrabajo_Click);
            // 
            // rpBtnMenuGenerarReporte
            // 
            this.rpBtnMenuGenerarReporte.ArcRadiusBorde = 15;
            this.rpBtnMenuGenerarReporte.ArcRadiusPanel = 15;
            this.rpBtnMenuGenerarReporte.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuGenerarReporte.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuGenerarReporte.Controls.Add(this.btnGenerarReporte);
            this.rpBtnMenuGenerarReporte.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.rpBtnMenuGenerarReporte.Location = new System.Drawing.Point(30, 44);
            this.rpBtnMenuGenerarReporte.Margin = new System.Windows.Forms.Padding(2);
            this.rpBtnMenuGenerarReporte.MenosHeightBorde = 1;
            this.rpBtnMenuGenerarReporte.MenosHeightPanel = 1;
            this.rpBtnMenuGenerarReporte.MenosWidthBorde = 1;
            this.rpBtnMenuGenerarReporte.MenosWidthPanel = 1;
            this.rpBtnMenuGenerarReporte.Name = "rpBtnMenuGenerarReporte";
            this.rpBtnMenuGenerarReporte.PorcLuzColorBorde = 0;
            this.rpBtnMenuGenerarReporte.Size = new System.Drawing.Size(59, 35);
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
            this.btnGenerarReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerarReporte.FlatAppearance.BorderSize = 0;
            this.btnGenerarReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGenerarReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnGenerarReporte.Location = new System.Drawing.Point(10, 3);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(41, 29);
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
            this.rpBtnMenuServicios.Location = new System.Drawing.Point(30, 83);
            this.rpBtnMenuServicios.Margin = new System.Windows.Forms.Padding(2);
            this.rpBtnMenuServicios.MenosHeightBorde = 1;
            this.rpBtnMenuServicios.MenosHeightPanel = 1;
            this.rpBtnMenuServicios.MenosWidthBorde = 1;
            this.rpBtnMenuServicios.MenosWidthPanel = 1;
            this.rpBtnMenuServicios.Name = "rpBtnMenuServicios";
            this.rpBtnMenuServicios.PorcLuzColorBorde = 0;
            this.rpBtnMenuServicios.Size = new System.Drawing.Size(59, 35);
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
            this.btnServicios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnServicios.BackgroundImage")));
            this.btnServicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnServicios.Location = new System.Drawing.Point(6, 3);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(41, 29);
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
            this.rpBtnMenuHome.Location = new System.Drawing.Point(30, 5);
            this.rpBtnMenuHome.Margin = new System.Windows.Forms.Padding(2);
            this.rpBtnMenuHome.MenosHeightBorde = 1;
            this.rpBtnMenuHome.MenosHeightPanel = 1;
            this.rpBtnMenuHome.MenosWidthBorde = 1;
            this.rpBtnMenuHome.MenosWidthPanel = 1;
            this.rpBtnMenuHome.Name = "rpBtnMenuHome";
            this.rpBtnMenuHome.PorcLuzColorBorde = 0;
            this.rpBtnMenuHome.Size = new System.Drawing.Size(59, 35);
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
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnHome.Location = new System.Drawing.Point(12, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(41, 29);
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
            this.rpMain.Controls.Add(this.pntIniGen);
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
            // pntIniGen
            // 
            this.pntIniGen.BackColor = System.Drawing.Color.White;
            this.pntIniGen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pntIniGen.Location = new System.Drawing.Point(0, 0);
            this.pntIniGen.Name = "pntIniGen";
            this.pntIniGen.Size = new System.Drawing.Size(611, 470);
            this.pntIniGen.TabIndex = 0;
            this.tags.SetTag2(this.pntIniGen, null);
            this.tags.SetTag3(this.pntIniGen, null);
            this.tags.SetTagFontName(this.pntIniGen, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pntIniGen, 10F);
            this.tags.SetTagFontStyle(this.pntIniGen, System.Drawing.FontStyle.Regular);
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
            this.rpBtnMenuCerrarSesion.ResumeLayout(false);
            this.rpBtnMenuReportes.ResumeLayout(false);
            this.rpBtnMenuAjustes.ResumeLayout(false);
            this.rpBtnMenuSedes.ResumeLayout(false);
            this.rpBtnMenuUsuarios.ResumeLayout(false);
            this.rpBtnMenuClientes.ResumeLayout(false);
            this.rpBtnMenuEmpresa.ResumeLayout(false);
            this.rpBtnMenuDrivers.ResumeLayout(false);
            this.rpBtnMenuAreasTrabajo.ResumeLayout(false);
            this.rpBtnMenuGenerarReporte.ResumeLayout(false);
            this.rpBtnMenuServicios.ResumeLayout(false);
            this.rpBtnMenuHome.ResumeLayout(false);
            this.panel_toggle_nocturno.ResumeLayout(false);
            this.pnlBackBackground.ResumeLayout(false);
            this.rpMain.ResumeLayout(false);
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
        private RoundedPanel rpBtnMenuAreasTrabajo;
        private System.Windows.Forms.Button btnAreasTrabajo;
        private RoundedPanel rpBtnMenuDrivers;
        private System.Windows.Forms.Button btnDrivers;
        private RoundedPanel rpBtnMenuEmpresa;
        private System.Windows.Forms.Button btnMenuEmpresa;
        private RoundedPanel rpBtnMenuClientes;
        private System.Windows.Forms.Button btnClientes;
        private RoundedPanel rpBtnMenuUsuarios;
        private System.Windows.Forms.Button btnMenuUsuarios;
        private RoundedPanel rpBtnMenuSedes;
        private System.Windows.Forms.Button btnMenuSedes;
        private RoundedPanel rpBtnMenuAjustes;
        private System.Windows.Forms.Button btnMenuAjustes;
        private pantallaInicioGerente pntIniGen;
        private RoundedPanel rpBtnMenuReportes;
        private System.Windows.Forms.Button btnMenuReportes;
        private RoundedPanel rpBtnMenuCerrarSesion;
        private System.Windows.Forms.Button btnMenuCerrarSesion;
    }
}