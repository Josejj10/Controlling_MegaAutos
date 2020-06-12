using System.Drawing;
using System.Windows.Forms;

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
            this.btnAdelante = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.reloj_dark = new System.Windows.Forms.Timer(this.components);
            this.tags = new LP2MegaAutos.TagsExtender();
            this.pnlBackBackground = new System.Windows.Forms.Panel();
            this.contenedorPantalla1 = new LP2MegaAutos.VentanasPrincipales.ContenedorPantalla();
            this.pmsReportes = new LP2MegaAutos.Framework.UserControls.PanelMenuStrip();
            this.pmsUltimoReporte = new LP2MegaAutos.Framework.UserControls.PanelMenuStrip();
            this.rpBtnMenuHome = new LP2MegaAutos.RoundedPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.rpBtnMenuCerrarSesion = new LP2MegaAutos.RoundedPanel();
            this.btnMenuCerrarSesion = new System.Windows.Forms.Button();
            this.rpBtnMenuUltimoReporte = new LP2MegaAutos.RoundedPanel();
            this.btnMenuUltimoReporte = new System.Windows.Forms.Button();
            this.panelMenu = new MetroFramework.Controls.MetroPanel();
            this.roundedPanel1 = new LP2MegaAutos.RoundedPanel();
            this.btnPanelMenuProfile = new System.Windows.Forms.Button();
            this.rpBtnMenuReportes = new LP2MegaAutos.RoundedPanel();
            this.btnMenuReportes = new System.Windows.Forms.Button();
            this.panel_toggle_nocturno = new System.Windows.Forms.Panel();
            this.boton_toggle_nocturno = new System.Windows.Forms.Button();
            this.title_bar.SuspendLayout();
            this.pnlBackBackground.SuspendLayout();
            this.rpBtnMenuHome.SuspendLayout();
            this.rpBtnMenuCerrarSesion.SuspendLayout();
            this.rpBtnMenuUltimoReporte.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.rpBtnMenuReportes.SuspendLayout();
            this.panel_toggle_nocturno.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_bar_2
            // 
            this.title_bar_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
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
            this.title_bar.Controls.Add(this.btnAdelante);
            this.title_bar.Controls.Add(this.btnAtras);
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
            // btnAdelante
            // 
            this.btnAdelante.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdelante.AutoSize = true;
            this.btnAdelante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdelante.FlatAppearance.BorderSize = 0;
            this.btnAdelante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAdelante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAdelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdelante.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.btnAdelante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnAdelante.Location = new System.Drawing.Point(42, -5);
            this.btnAdelante.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(35, 34);
            this.btnAdelante.TabIndex = 40;
            this.tags.SetTag2(this.btnAdelante, null);
            this.tags.SetTag3(this.btnAdelante, null);
            this.tags.SetTagFontName(this.btnAdelante, fontsD.Lato);
            this.tags.SetTagFontSize(this.btnAdelante, 15F);
            this.tags.SetTagFontStyle(this.btnAdelante, System.Drawing.FontStyle.Regular);
            this.btnAdelante.Text = ">";
            this.btnAdelante.UseVisualStyleBackColor = true;
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            this.btnAdelante.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAdelante_MouseDown);
            this.btnAdelante.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAdelante_MouseUp);
            // 
            // btnAtras
            // 
            this.btnAtras.AutoSize = true;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.btnAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnAtras.Location = new System.Drawing.Point(0, -5);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(38, 34);
            this.btnAtras.TabIndex = 39;
            this.tags.SetTag2(this.btnAtras, null);
            this.tags.SetTag3(this.btnAtras, null);
            this.tags.SetTagFontName(this.btnAtras, fontsD.Lato);
            this.tags.SetTagFontSize(this.btnAtras, 15F);
            this.tags.SetTagFontStyle(this.btnAtras, System.Drawing.FontStyle.Regular);
            this.btnAtras.Text = "<";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            this.btnAtras.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAdelante_MouseDown);
            this.btnAtras.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAdelante_MouseUp);
            // 
            // reloj_dark
            // 
            this.reloj_dark.Interval = 25;
            this.reloj_dark.Tick += new System.EventHandler(this.reloj_dark_Tick);
            // 
            // pnlBackBackground
            // 
            this.pnlBackBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.pnlBackBackground.Controls.Add(this.contenedorPantalla1);
            this.pnlBackBackground.Controls.Add(this.pmsReportes);
            this.pnlBackBackground.Controls.Add(this.pmsUltimoReporte);
            this.pnlBackBackground.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlBackBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackBackground.Location = new System.Drawing.Point(81, 30);
            this.pnlBackBackground.Name = "pnlBackBackground";
            this.pnlBackBackground.Size = new System.Drawing.Size(751, 522);
            this.pnlBackBackground.TabIndex = 4;
            this.pnlBackBackground.Tag = "background";
            this.tags.SetTag2(this.pnlBackBackground, null);
            this.tags.SetTag3(this.pnlBackBackground, null);
            this.tags.SetTagFontName(this.pnlBackBackground, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlBackBackground, 10F);
            this.tags.SetTagFontStyle(this.pnlBackBackground, System.Drawing.FontStyle.Regular);
            // 
            // contenedorPantalla1
            // 
            this.contenedorPantalla1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contenedorPantalla1.AutoScroll = true;
            this.contenedorPantalla1.Location = new System.Drawing.Point(0, 0);
            this.contenedorPantalla1.Margin = new System.Windows.Forms.Padding(4);
            this.contenedorPantalla1.Name = "contenedorPantalla1";
            this.contenedorPantalla1.Size = new System.Drawing.Size(751, 522);
            this.contenedorPantalla1.TabIndex = 1;
            this.tags.SetTag2(this.contenedorPantalla1, null);
            this.tags.SetTag3(this.contenedorPantalla1, null);
            this.tags.SetTagFontName(this.contenedorPantalla1, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.contenedorPantalla1, 10F);
            this.tags.SetTagFontStyle(this.contenedorPantalla1, System.Drawing.FontStyle.Regular);
            // 
            // pmsReportes
            // 
            this.pmsReportes.Imagen1 = ((System.Drawing.Image)(resources.GetObject("pmsReportes.Imagen1")));
            this.pmsReportes.Imagen2 = ((System.Drawing.Image)(resources.GetObject("pmsReportes.Imagen2")));
            this.pmsReportes.Imagen3 = ((System.Drawing.Image)(resources.GetObject("pmsReportes.Imagen3")));
            this.pmsReportes.Imagen4 = ((System.Drawing.Image)(resources.GetObject("pmsReportes.Imagen4")));
            this.pmsReportes.Location = new System.Drawing.Point(0, 61);
            this.pmsReportes.Margin = new System.Windows.Forms.Padding(4);
            this.pmsReportes.Name = "pmsReportes";
            this.pmsReportes.NumItems = 4;
            this.pmsReportes.Size = new System.Drawing.Size(205, 52);
            this.pmsReportes.TabIndex = 0;
            this.tags.SetTag2(this.pmsReportes, null);
            this.tags.SetTag3(this.pmsReportes, null);
            this.tags.SetTagFontName(this.pmsReportes, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pmsReportes, 10F);
            this.tags.SetTagFontStyle(this.pmsReportes, System.Drawing.FontStyle.Regular);
            this.pmsReportes.Visible = false;
            this.pmsReportes.item1Click += new LP2MegaAutos.Framework.UserControls.PanelMenuStrip.ButtonClickEventHandler(this.pmsReportes_ListaReportesClick);
            this.pmsReportes.item2Click += new LP2MegaAutos.Framework.UserControls.PanelMenuStrip.ButtonClickEventHandler(this.pmsReportes_ReporteAreaTrabajoClick);
            this.pmsReportes.item3Click += new LP2MegaAutos.Framework.UserControls.PanelMenuStrip.ButtonClickEventHandler(this.pmsReportes_ReporteClienteClick);
            this.pmsReportes.item4Click += new LP2MegaAutos.Framework.UserControls.PanelMenuStrip.ButtonClickEventHandler(this.pmsReportes_ReporteVehiculoClick);
            // 
            // pmsUltimoReporte
            // 
            this.pmsUltimoReporte.Imagen1 = ((System.Drawing.Image)(resources.GetObject("pmsUltimoReporte.Imagen1")));
            this.pmsUltimoReporte.Imagen2 = ((System.Drawing.Image)(resources.GetObject("pmsUltimoReporte.Imagen2")));
            this.pmsUltimoReporte.Imagen3 = ((System.Drawing.Image)(resources.GetObject("pmsUltimoReporte.Imagen3")));
            this.pmsUltimoReporte.Imagen4 = ((System.Drawing.Image)(resources.GetObject("pmsUltimoReporte.Imagen4")));
            this.pmsUltimoReporte.Location = new System.Drawing.Point(0, 347);
            this.pmsUltimoReporte.Name = "pmsUltimoReporte";
            this.pmsUltimoReporte.NumItems = 3;
            this.pmsUltimoReporte.Size = new System.Drawing.Size(156, 52);
            this.pmsUltimoReporte.TabIndex = 2;
            this.tags.SetTag2(this.pmsUltimoReporte, null);
            this.tags.SetTag3(this.pmsUltimoReporte, null);
            this.tags.SetTagFontName(this.pmsUltimoReporte, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pmsUltimoReporte, 10F);
            this.tags.SetTagFontStyle(this.pmsUltimoReporte, System.Drawing.FontStyle.Regular);
            this.pmsUltimoReporte.item1Click += new LP2MegaAutos.Framework.UserControls.PanelMenuStrip.ButtonClickEventHandler(this.pmsUltimoReporte_EstadisticasClick);
            this.pmsUltimoReporte.item2Click += new LP2MegaAutos.Framework.UserControls.PanelMenuStrip.ButtonClickEventHandler(this.pmsUltimoReporte_DetalleClick);
            this.pmsUltimoReporte.item3Click += new LP2MegaAutos.Framework.UserControls.PanelMenuStrip.ButtonClickEventHandler(this.pmsUltimoReporte_ResumenClick);
            // 
            // rpBtnMenuHome
            // 
            this.rpBtnMenuHome.ArcRadiusBorde = 15;
            this.rpBtnMenuHome.ArcRadiusPanel = 15;
            this.rpBtnMenuHome.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuHome.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpBtnMenuHome.Controls.Add(this.btnHome);
            this.rpBtnMenuHome.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.rpBtnMenuHome.Location = new System.Drawing.Point(5, 5);
            this.rpBtnMenuHome.Margin = new System.Windows.Forms.Padding(2);
            this.rpBtnMenuHome.MenosHeightBorde = 1;
            this.rpBtnMenuHome.MenosHeightPanel = 1;
            this.rpBtnMenuHome.MenosWidthBorde = 1;
            this.rpBtnMenuHome.MenosWidthPanel = 1;
            this.rpBtnMenuHome.Name = "rpBtnMenuHome";
            this.rpBtnMenuHome.PorcLuzColorBorde = 0;
            this.rpBtnMenuHome.Size = new System.Drawing.Size(77, 52);
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
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnHome.Location = new System.Drawing.Point(20, 11);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(36, 30);
            this.btnHome.TabIndex = 20;
            this.tags.SetTag2(this.btnHome, null);
            this.tags.SetTag3(this.btnHome, null);
            this.tags.SetTagFontName(this.btnHome, fontsD.Montserrat);
            this.tags.SetTagFontSize(this.btnHome, 12F);
            this.tags.SetTagFontStyle(this.btnHome, System.Drawing.FontStyle.Bold);
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.btnMenu_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
            // 
            // rpBtnMenuCerrarSesion
            // 
            this.rpBtnMenuCerrarSesion.ArcRadiusBorde = 15;
            this.rpBtnMenuCerrarSesion.ArcRadiusPanel = 15;
            this.rpBtnMenuCerrarSesion.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuCerrarSesion.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuCerrarSesion.Controls.Add(this.btnMenuCerrarSesion);
            this.rpBtnMenuCerrarSesion.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.rpBtnMenuCerrarSesion.Location = new System.Drawing.Point(5, 403);
            this.rpBtnMenuCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.rpBtnMenuCerrarSesion.MenosHeightBorde = 1;
            this.rpBtnMenuCerrarSesion.MenosHeightPanel = 1;
            this.rpBtnMenuCerrarSesion.MenosWidthBorde = 1;
            this.rpBtnMenuCerrarSesion.MenosWidthPanel = 1;
            this.rpBtnMenuCerrarSesion.Name = "rpBtnMenuCerrarSesion";
            this.rpBtnMenuCerrarSesion.PorcLuzColorBorde = 0;
            this.rpBtnMenuCerrarSesion.Size = new System.Drawing.Size(77, 52);
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
            this.btnMenuCerrarSesion.BackgroundImage = global::LP2MegaAutos.Properties.Resources.Logout;
            this.btnMenuCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnMenuCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenuCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenuCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCerrarSesion.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenuCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnMenuCerrarSesion.Location = new System.Drawing.Point(20, 8);
            this.btnMenuCerrarSesion.Name = "btnMenuCerrarSesion";
            this.btnMenuCerrarSesion.Size = new System.Drawing.Size(36, 36);
            this.btnMenuCerrarSesion.TabIndex = 20;
            this.tags.SetTag2(this.btnMenuCerrarSesion, null);
            this.tags.SetTag3(this.btnMenuCerrarSesion, null);
            this.tags.SetTagFontName(this.btnMenuCerrarSesion, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnMenuCerrarSesion, 12F);
            this.tags.SetTagFontStyle(this.btnMenuCerrarSesion, System.Drawing.FontStyle.Bold);
            this.btnMenuCerrarSesion.UseVisualStyleBackColor = false;
            this.btnMenuCerrarSesion.Click += new System.EventHandler(this.btnMenuCerrarSesion_Click);
            this.btnMenuCerrarSesion.MouseEnter += new System.EventHandler(this.btnMenu_MouseEnter);
            this.btnMenuCerrarSesion.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
            // 
            // rpBtnMenuUltimoReporte
            // 
            this.rpBtnMenuUltimoReporte.ArcRadiusBorde = 15;
            this.rpBtnMenuUltimoReporte.ArcRadiusPanel = 15;
            this.rpBtnMenuUltimoReporte.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuUltimoReporte.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuUltimoReporte.Controls.Add(this.btnMenuUltimoReporte);
            this.rpBtnMenuUltimoReporte.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.rpBtnMenuUltimoReporte.Location = new System.Drawing.Point(5, 347);
            this.rpBtnMenuUltimoReporte.Margin = new System.Windows.Forms.Padding(2);
            this.rpBtnMenuUltimoReporte.MenosHeightBorde = 1;
            this.rpBtnMenuUltimoReporte.MenosHeightPanel = 1;
            this.rpBtnMenuUltimoReporte.MenosWidthBorde = 1;
            this.rpBtnMenuUltimoReporte.MenosWidthPanel = 1;
            this.rpBtnMenuUltimoReporte.Name = "rpBtnMenuUltimoReporte";
            this.rpBtnMenuUltimoReporte.PorcLuzColorBorde = 0;
            this.rpBtnMenuUltimoReporte.Size = new System.Drawing.Size(77, 52);
            this.rpBtnMenuUltimoReporte.TabIndex = 37;
            this.tags.SetTag2(this.rpBtnMenuUltimoReporte, null);
            this.tags.SetTag3(this.rpBtnMenuUltimoReporte, null);
            this.tags.SetTagFontName(this.rpBtnMenuUltimoReporte, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpBtnMenuUltimoReporte, 10F);
            this.tags.SetTagFontStyle(this.rpBtnMenuUltimoReporte, System.Drawing.FontStyle.Regular);
            this.rpBtnMenuUltimoReporte.XBorde = 0;
            this.rpBtnMenuUltimoReporte.XPanel = 0;
            this.rpBtnMenuUltimoReporte.YBorde = 0;
            this.rpBtnMenuUltimoReporte.YPanel = 0;
            // 
            // btnMenuUltimoReporte
            // 
            this.btnMenuUltimoReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuUltimoReporte.BackgroundImage = global::LP2MegaAutos.Properties.Resources.Reloj;
            this.btnMenuUltimoReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenuUltimoReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuUltimoReporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.btnMenuUltimoReporte.FlatAppearance.BorderSize = 0;
            this.btnMenuUltimoReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenuUltimoReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenuUltimoReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuUltimoReporte.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenuUltimoReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnMenuUltimoReporte.Location = new System.Drawing.Point(20, 8);
            this.btnMenuUltimoReporte.Name = "btnMenuUltimoReporte";
            this.btnMenuUltimoReporte.Size = new System.Drawing.Size(36, 36);
            this.btnMenuUltimoReporte.TabIndex = 20;
            this.tags.SetTag2(this.btnMenuUltimoReporte, null);
            this.tags.SetTag3(this.btnMenuUltimoReporte, null);
            this.tags.SetTagFontName(this.btnMenuUltimoReporte, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnMenuUltimoReporte, 12F);
            this.tags.SetTagFontStyle(this.btnMenuUltimoReporte, System.Drawing.FontStyle.Bold);
            this.btnMenuUltimoReporte.UseVisualStyleBackColor = false;
            this.btnMenuUltimoReporte.Click += new System.EventHandler(this.btnMenuUltimoReporte_Click);
            this.btnMenuUltimoReporte.MouseEnter += new System.EventHandler(this.btnMenu_MouseEnter);
            this.btnMenuUltimoReporte.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.panelMenu.Controls.Add(this.roundedPanel1);
            this.panelMenu.Controls.Add(this.rpBtnMenuUltimoReporte);
            this.panelMenu.Controls.Add(this.rpBtnMenuCerrarSesion);
            this.panelMenu.Controls.Add(this.rpBtnMenuReportes);
            this.panelMenu.Controls.Add(this.rpBtnMenuHome);
            this.panelMenu.Controls.Add(this.panel_toggle_nocturno);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.HorizontalScrollbarBarColor = true;
            this.panelMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMenu.HorizontalScrollbarSize = 10;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(81, 522);
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
            // roundedPanel1
            // 
            this.roundedPanel1.ArcRadiusBorde = 15;
            this.roundedPanel1.ArcRadiusPanel = 15;
            this.roundedPanel1.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.roundedPanel1.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.roundedPanel1.Controls.Add(this.btnPanelMenuProfile);
            this.roundedPanel1.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.roundedPanel1.Location = new System.Drawing.Point(5, 288);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.roundedPanel1.MenosHeightBorde = 1;
            this.roundedPanel1.MenosHeightPanel = 1;
            this.roundedPanel1.MenosWidthBorde = 1;
            this.roundedPanel1.MenosWidthPanel = 1;
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.PorcLuzColorBorde = 0;
            this.roundedPanel1.Size = new System.Drawing.Size(77, 52);
            this.roundedPanel1.TabIndex = 38;
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
            // btnPanelMenuProfile
            // 
            this.btnPanelMenuProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnPanelMenuProfile.BackgroundImage = global::LP2MegaAutos.Properties.Resources.Usuario;
            this.btnPanelMenuProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPanelMenuProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPanelMenuProfile.FlatAppearance.BorderSize = 0;
            this.btnPanelMenuProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPanelMenuProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPanelMenuProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelMenuProfile.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnPanelMenuProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnPanelMenuProfile.Location = new System.Drawing.Point(20, 8);
            this.btnPanelMenuProfile.Name = "btnPanelMenuProfile";
            this.btnPanelMenuProfile.Size = new System.Drawing.Size(36, 36);
            this.btnPanelMenuProfile.TabIndex = 20;
            this.tags.SetTag2(this.btnPanelMenuProfile, null);
            this.tags.SetTag3(this.btnPanelMenuProfile, null);
            this.tags.SetTagFontName(this.btnPanelMenuProfile, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnPanelMenuProfile, 12F);
            this.tags.SetTagFontStyle(this.btnPanelMenuProfile, System.Drawing.FontStyle.Bold);
            this.btnPanelMenuProfile.UseVisualStyleBackColor = false;
            this.btnPanelMenuProfile.Click += new System.EventHandler(this.btnMenuUsuario_Click);
            this.btnPanelMenuProfile.MouseEnter += new System.EventHandler(this.btnMenu_MouseEnter);
            this.btnPanelMenuProfile.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
            // 
            // rpBtnMenuReportes
            // 
            this.rpBtnMenuReportes.ArcRadiusBorde = 15;
            this.rpBtnMenuReportes.ArcRadiusPanel = 15;
            this.rpBtnMenuReportes.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuReportes.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.rpBtnMenuReportes.Controls.Add(this.btnMenuReportes);
            this.rpBtnMenuReportes.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.rpBtnMenuReportes.Location = new System.Drawing.Point(5, 61);
            this.rpBtnMenuReportes.Margin = new System.Windows.Forms.Padding(2);
            this.rpBtnMenuReportes.MenosHeightBorde = 1;
            this.rpBtnMenuReportes.MenosHeightPanel = 1;
            this.rpBtnMenuReportes.MenosWidthBorde = 1;
            this.rpBtnMenuReportes.MenosWidthPanel = 1;
            this.rpBtnMenuReportes.Name = "rpBtnMenuReportes";
            this.rpBtnMenuReportes.PorcLuzColorBorde = 0;
            this.rpBtnMenuReportes.Size = new System.Drawing.Size(77, 52);
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
            this.btnMenuReportes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuReportes.BackgroundImage")));
            this.btnMenuReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenuReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuReportes.FlatAppearance.BorderSize = 0;
            this.btnMenuReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenuReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenuReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuReportes.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenuReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnMenuReportes.Location = new System.Drawing.Point(20, 8);
            this.btnMenuReportes.Name = "btnMenuReportes";
            this.btnMenuReportes.Size = new System.Drawing.Size(36, 36);
            this.btnMenuReportes.TabIndex = 20;
            this.tags.SetTag2(this.btnMenuReportes, null);
            this.tags.SetTag3(this.btnMenuReportes, null);
            this.tags.SetTagFontName(this.btnMenuReportes, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnMenuReportes, 12F);
            this.tags.SetTagFontStyle(this.btnMenuReportes, System.Drawing.FontStyle.Bold);
            this.btnMenuReportes.UseVisualStyleBackColor = false;
            this.btnMenuReportes.Click += new System.EventHandler(this.btnMenuReportes_Click);
            this.btnMenuReportes.MouseEnter += new System.EventHandler(this.btnMenu_MouseEnter);
            this.btnMenuReportes.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 552);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBackBackground);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.title_bar_2);
            this.Controls.Add(this.title_bar);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.tags.SetTag2(this, null);
            this.tags.SetTag3(this, null);
            this.tags.SetTagFontName(this, fontsD.Ninguno);
            this.tags.SetTagFontSize(this, 10F);
            this.tags.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.title_bar.ResumeLayout(false);
            this.title_bar.PerformLayout();
            this.pnlBackBackground.ResumeLayout(false);
            this.rpBtnMenuHome.ResumeLayout(false);
            this.rpBtnMenuCerrarSesion.ResumeLayout(false);
            this.rpBtnMenuUltimoReporte.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.rpBtnMenuReportes.ResumeLayout(false);
            this.panel_toggle_nocturno.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title_bar_2;
        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.Button boton_minimizar;
        private System.Windows.Forms.Button boton_cerrar;
        private System.Windows.Forms.Timer reloj_dark;
        private TagsExtender tags;
        private System.Windows.Forms.Panel pnlBackBackground;
        private System.Windows.Forms.Panel panel_toggle_nocturno;
        private System.Windows.Forms.Button boton_toggle_nocturno;
        private RoundedPanel rpBtnMenuHome;
        private System.Windows.Forms.Button btnHome;
        private RoundedPanel rpBtnMenuCerrarSesion;
        private System.Windows.Forms.Button btnMenuCerrarSesion;
        private RoundedPanel rpBtnMenuUltimoReporte;
        private System.Windows.Forms.Button btnMenuUltimoReporte;
        private MetroFramework.Controls.MetroPanel panelMenu;
        private RoundedPanel rpBtnMenuReportes;
        private System.Windows.Forms.Button btnMenuReportes;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Button btnPanelMenuProfile;
        private Framework.UserControls.PanelMenuStrip pmsReportes;
        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.Button btnAtras;
        private VentanasPrincipales.ContenedorPantalla contenedorPantalla1;
        private Framework.UserControls.PanelMenuStrip pmsUltimoReporte;
    }
}