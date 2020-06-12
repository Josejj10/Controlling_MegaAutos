using System.Drawing;

namespace LP2MegaAutos.Framework.UserControls
{
    partial class UltimoReporteDashboard
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
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.rpEgresos = new LP2MegaAutos.RoundedPanel();
            this.lblStringEgresos = new System.Windows.Forms.Label();
            this.tlpEgresos = new System.Windows.Forms.TableLayoutPanel();
            this.lblEgresos = new System.Windows.Forms.Label();
            this.rpIngresos = new LP2MegaAutos.RoundedPanel();
            this.lbStringIngresos = new System.Windows.Forms.Label();
            this.tlpIngresos = new System.Windows.Forms.TableLayoutPanel();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.rpTitulo = new LP2MegaAutos.RoundedPanel();
            this.rpTotal = new LP2MegaAutos.RoundedPanel();
            this.lblStringTotal = new System.Windows.Forms.Label();
            this.tlpTotal = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlReloj = new System.Windows.Forms.Panel();
            this.pnlColorArriba = new System.Windows.Forms.Panel();
            this.pnlUltimoReporte = new System.Windows.Forms.Panel();
            this.lblUltimoReporte = new System.Windows.Forms.Label();
            this.pnlTipoReporte = new System.Windows.Forms.Panel();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.pnlPeriodoReporte = new System.Windows.Forms.Panel();
            this.lblPeriodoReporte = new System.Windows.Forms.Label();
            this.pnlSede = new System.Windows.Forms.Panel();
            this.lblSede = new System.Windows.Forms.Label();
            this.pnlFechasReporte = new System.Windows.Forms.Panel();
            this.lblFechasReporte = new System.Windows.Forms.Label();
            this.pnlGeneradoPor = new System.Windows.Forms.Panel();
            this.tlpGeneradoPor = new System.Windows.Forms.TableLayoutPanel();
            this.lblStringGeneradoPor = new System.Windows.Forms.Label();
            this.lblGeneradoPor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStringEl = new System.Windows.Forms.Label();
            this.btnVerReporte = new System.Windows.Forms.Button();
            this.pnlVerReporte = new ShadowPanel.ShadowPanelRight();
            this.tags = new LP2MegaAutos.TagsExtender();
            this.pnlBackground.SuspendLayout();
            this.rpEgresos.SuspendLayout();
            this.tlpEgresos.SuspendLayout();
            this.rpIngresos.SuspendLayout();
            this.tlpIngresos.SuspendLayout();
            this.rpTotal.SuspendLayout();
            this.tlpTotal.SuspendLayout();
            this.pnlUltimoReporte.SuspendLayout();
            this.pnlTipoReporte.SuspendLayout();
            this.pnlPeriodoReporte.SuspendLayout();
            this.pnlSede.SuspendLayout();
            this.pnlFechasReporte.SuspendLayout();
            this.pnlGeneradoPor.SuspendLayout();
            this.tlpGeneradoPor.SuspendLayout();
            this.pnlVerReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBackground.Controls.Add(this.rpEgresos);
            this.pnlBackground.Controls.Add(this.rpIngresos);
            this.pnlBackground.Controls.Add(this.rpTitulo);
            this.pnlBackground.Controls.Add(this.rpTotal);
            this.pnlBackground.Controls.Add(this.lblTitulo);
            this.pnlBackground.Controls.Add(this.pnlReloj);
            this.pnlBackground.Controls.Add(this.pnlColorArriba);
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(230, 240);
            this.pnlBackground.TabIndex = 0;
            this.tags.SetTag2(this.pnlBackground, null);
            this.tags.SetTag3(this.pnlBackground, null);
            this.tags.SetTagFontName(this.pnlBackground, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlBackground, 10F);
            this.tags.SetTagFontStyle(this.pnlBackground, System.Drawing.FontStyle.Regular);
            // 
            // rpEgresos
            // 
            this.rpEgresos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rpEgresos.ArcRadiusBorde = 15;
            this.rpEgresos.ArcRadiusPanel = 15;
            this.rpEgresos.BackColor = System.Drawing.Color.Transparent;
            this.rpEgresos.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rpEgresos.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.rpEgresos.Controls.Add(this.lblStringEgresos);
            this.rpEgresos.Controls.Add(this.tlpEgresos);
            this.rpEgresos.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpEgresos.Location = new System.Drawing.Point(14, 182);
            this.rpEgresos.MenosHeightBorde = 1;
            this.rpEgresos.MenosHeightPanel = 1;
            this.rpEgresos.MenosWidthBorde = 1;
            this.rpEgresos.MenosWidthPanel = 1;
            this.rpEgresos.Name = "rpEgresos";
            this.rpEgresos.PorcLuzColorBorde = 0;
            this.rpEgresos.Size = new System.Drawing.Size(200, 50);
            this.rpEgresos.TabIndex = 52;
            this.tags.SetTag2(this.rpEgresos, null);
            this.tags.SetTag3(this.rpEgresos, null);
            this.tags.SetTagFontName(this.rpEgresos, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpEgresos, 10F);
            this.tags.SetTagFontStyle(this.rpEgresos, System.Drawing.FontStyle.Regular);
            this.rpEgresos.XBorde = 0;
            this.rpEgresos.XPanel = 0;
            this.rpEgresos.YBorde = 0;
            this.rpEgresos.YPanel = 0;
            // 
            // lblStringEgresos
            // 
            this.lblStringEgresos.AutoSize = true;
            this.lblStringEgresos.BackColor = System.Drawing.Color.Transparent;
            this.lblStringEgresos.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Bold);
            this.lblStringEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.lblStringEgresos.Location = new System.Drawing.Point(5, 9);
            this.lblStringEgresos.Name = "lblStringEgresos";
            this.lblStringEgresos.Size = new System.Drawing.Size(34, 18);
            this.lblStringEgresos.TabIndex = 48;
            this.tags.SetTag2(this.lblStringEgresos, null);
            this.tags.SetTag3(this.lblStringEgresos, null);
            this.tags.SetTagFontName(this.lblStringEgresos, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblStringEgresos, 11F);
            this.tags.SetTagFontStyle(this.lblStringEgresos, System.Drawing.FontStyle.Bold);
            this.lblStringEgresos.Text = "Egr.";
            this.lblStringEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpEgresos
            // 
            this.tlpEgresos.ColumnCount = 1;
            this.tlpEgresos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEgresos.Controls.Add(this.lblEgresos, 0, 0);
            this.tlpEgresos.Location = new System.Drawing.Point(42, 9);
            this.tlpEgresos.Name = "tlpEgresos";
            this.tlpEgresos.RowCount = 1;
            this.tlpEgresos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEgresos.Size = new System.Drawing.Size(155, 33);
            this.tlpEgresos.TabIndex = 0;
            this.tags.SetTag2(this.tlpEgresos, null);
            this.tags.SetTag3(this.tlpEgresos, null);
            this.tags.SetTagFontName(this.tlpEgresos, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.tlpEgresos, 10F);
            this.tags.SetTagFontStyle(this.tlpEgresos, System.Drawing.FontStyle.Regular);
            // 
            // lblEgresos
            // 
            this.lblEgresos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEgresos.AutoSize = true;
            this.lblEgresos.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.lblEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblEgresos.Location = new System.Drawing.Point(19, 4);
            this.lblEgresos.Name = "lblEgresos";
            this.lblEgresos.Size = new System.Drawing.Size(133, 24);
            this.lblEgresos.TabIndex = 48;
            this.tags.SetTag2(this.lblEgresos, null);
            this.tags.SetTag3(this.lblEgresos, null);
            this.tags.SetTagFontName(this.lblEgresos, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblEgresos, 15F);
            this.tags.SetTagFontStyle(this.lblEgresos, System.Drawing.FontStyle.Bold);
            this.lblEgresos.Text = "9,999,999.00";
            this.lblEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rpIngresos
            // 
            this.rpIngresos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rpIngresos.ArcRadiusBorde = 15;
            this.rpIngresos.ArcRadiusPanel = 15;
            this.rpIngresos.BackColor = System.Drawing.Color.Transparent;
            this.rpIngresos.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.rpIngresos.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.rpIngresos.Controls.Add(this.lbStringIngresos);
            this.rpIngresos.Controls.Add(this.tlpIngresos);
            this.rpIngresos.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpIngresos.Location = new System.Drawing.Point(14, 126);
            this.rpIngresos.MenosHeightBorde = 1;
            this.rpIngresos.MenosHeightPanel = 1;
            this.rpIngresos.MenosWidthBorde = 1;
            this.rpIngresos.MenosWidthPanel = 1;
            this.rpIngresos.Name = "rpIngresos";
            this.rpIngresos.PorcLuzColorBorde = 0;
            this.rpIngresos.Size = new System.Drawing.Size(200, 50);
            this.rpIngresos.TabIndex = 52;
            this.tags.SetTag2(this.rpIngresos, null);
            this.tags.SetTag3(this.rpIngresos, null);
            this.tags.SetTagFontName(this.rpIngresos, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpIngresos, 10F);
            this.tags.SetTagFontStyle(this.rpIngresos, System.Drawing.FontStyle.Regular);
            this.rpIngresos.XBorde = 0;
            this.rpIngresos.XPanel = 0;
            this.rpIngresos.YBorde = 0;
            this.rpIngresos.YPanel = 0;
            // 
            // lbStringIngresos
            // 
            this.lbStringIngresos.AutoSize = true;
            this.lbStringIngresos.BackColor = System.Drawing.Color.Transparent;
            this.lbStringIngresos.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Bold);
            this.lbStringIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.lbStringIngresos.Location = new System.Drawing.Point(5, 9);
            this.lbStringIngresos.Name = "lbStringIngresos";
            this.lbStringIngresos.Size = new System.Drawing.Size(32, 18);
            this.lbStringIngresos.TabIndex = 48;
            this.tags.SetTag2(this.lbStringIngresos, null);
            this.tags.SetTag3(this.lbStringIngresos, null);
            this.tags.SetTagFontName(this.lbStringIngresos, fontsD.Lato);
            this.tags.SetTagFontSize(this.lbStringIngresos, 11F);
            this.tags.SetTagFontStyle(this.lbStringIngresos, System.Drawing.FontStyle.Bold);
            this.lbStringIngresos.Text = "Ing.";
            this.lbStringIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpIngresos
            // 
            this.tlpIngresos.ColumnCount = 1;
            this.tlpIngresos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpIngresos.Controls.Add(this.lblIngresos, 0, 0);
            this.tlpIngresos.Location = new System.Drawing.Point(42, 9);
            this.tlpIngresos.Name = "tlpIngresos";
            this.tlpIngresos.RowCount = 1;
            this.tlpIngresos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpIngresos.Size = new System.Drawing.Size(155, 33);
            this.tlpIngresos.TabIndex = 0;
            this.tags.SetTag2(this.tlpIngresos, null);
            this.tags.SetTag3(this.tlpIngresos, null);
            this.tags.SetTagFontName(this.tlpIngresos, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.tlpIngresos, 10F);
            this.tags.SetTagFontStyle(this.tlpIngresos, System.Drawing.FontStyle.Regular);
            // 
            // lblIngresos
            // 
            this.lblIngresos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.lblIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblIngresos.Location = new System.Drawing.Point(19, 4);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(133, 24);
            this.lblIngresos.TabIndex = 48;
            this.tags.SetTag2(this.lblIngresos, null);
            this.tags.SetTag3(this.lblIngresos, null);
            this.tags.SetTagFontName(this.lblIngresos, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblIngresos, 15F);
            this.tags.SetTagFontStyle(this.lblIngresos, System.Drawing.FontStyle.Bold);
            this.lblIngresos.Text = "9,999,999.00";
            this.lblIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rpTitulo
            // 
            this.rpTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rpTitulo.ArcRadiusBorde = 15;
            this.rpTitulo.ArcRadiusPanel = 15;
            this.rpTitulo.BackColor = System.Drawing.Color.Transparent;
            this.rpTitulo.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rpTitulo.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rpTitulo.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpTitulo.Location = new System.Drawing.Point(21, 60);
            this.rpTitulo.MenosHeightBorde = 1;
            this.rpTitulo.MenosHeightPanel = 1;
            this.rpTitulo.MenosWidthBorde = 1;
            this.rpTitulo.MenosWidthPanel = 1;
            this.rpTitulo.Name = "rpTitulo";
            this.rpTitulo.PorcLuzColorBorde = 0;
            this.rpTitulo.Size = new System.Drawing.Size(187, 4);
            this.rpTitulo.TabIndex = 50;
            this.tags.SetTag2(this.rpTitulo, null);
            this.tags.SetTag3(this.rpTitulo, null);
            this.tags.SetTagFontName(this.rpTitulo, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpTitulo, 10F);
            this.tags.SetTagFontStyle(this.rpTitulo, System.Drawing.FontStyle.Regular);
            this.rpTitulo.XBorde = 0;
            this.rpTitulo.XPanel = 0;
            this.rpTitulo.YBorde = 0;
            this.rpTitulo.YPanel = 0;
            // 
            // rpTotal
            // 
            this.rpTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rpTotal.ArcRadiusBorde = 15;
            this.rpTotal.ArcRadiusPanel = 15;
            this.rpTotal.BackColor = System.Drawing.Color.Transparent;
            this.rpTotal.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.rpTotal.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.rpTotal.Controls.Add(this.lblStringTotal);
            this.rpTotal.Controls.Add(this.tlpTotal);
            this.rpTotal.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpTotal.Location = new System.Drawing.Point(14, 70);
            this.rpTotal.MenosHeightBorde = 1;
            this.rpTotal.MenosHeightPanel = 1;
            this.rpTotal.MenosWidthBorde = 1;
            this.rpTotal.MenosWidthPanel = 1;
            this.rpTotal.Name = "rpTotal";
            this.rpTotal.PorcLuzColorBorde = 0;
            this.rpTotal.Size = new System.Drawing.Size(200, 50);
            this.rpTotal.TabIndex = 51;
            this.tags.SetTag2(this.rpTotal, null);
            this.tags.SetTag3(this.rpTotal, null);
            this.tags.SetTagFontName(this.rpTotal, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpTotal, 10F);
            this.tags.SetTagFontStyle(this.rpTotal, System.Drawing.FontStyle.Regular);
            this.rpTotal.XBorde = 0;
            this.rpTotal.XPanel = 0;
            this.rpTotal.YBorde = 0;
            this.rpTotal.YPanel = 0;
            // 
            // lblStringTotal
            // 
            this.lblStringTotal.AutoSize = true;
            this.lblStringTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblStringTotal.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Bold);
            this.lblStringTotal.ForeColor = System.Drawing.Color.White;
            this.lblStringTotal.Location = new System.Drawing.Point(5, 9);
            this.lblStringTotal.Name = "lblStringTotal";
            this.lblStringTotal.Size = new System.Drawing.Size(42, 18);
            this.lblStringTotal.TabIndex = 48;
            this.tags.SetTag2(this.lblStringTotal, null);
            this.tags.SetTag3(this.lblStringTotal, null);
            this.tags.SetTagFontName(this.lblStringTotal, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblStringTotal, 11F);
            this.tags.SetTagFontStyle(this.lblStringTotal, System.Drawing.FontStyle.Bold);
            this.lblStringTotal.Text = "Total";
            this.lblStringTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpTotal
            // 
            this.tlpTotal.ColumnCount = 1;
            this.tlpTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTotal.Controls.Add(this.lblTotal, 0, 0);
            this.tlpTotal.Location = new System.Drawing.Point(42, 9);
            this.tlpTotal.Name = "tlpTotal";
            this.tlpTotal.RowCount = 1;
            this.tlpTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTotal.Size = new System.Drawing.Size(155, 33);
            this.tlpTotal.TabIndex = 0;
            this.tags.SetTag2(this.tlpTotal, null);
            this.tags.SetTag3(this.tlpTotal, null);
            this.tags.SetTagFontName(this.tlpTotal, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.tlpTotal, 10F);
            this.tags.SetTagFontStyle(this.tlpTotal, System.Drawing.FontStyle.Regular);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(19, 4);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(133, 24);
            this.lblTotal.TabIndex = 48;
            this.tags.SetTag2(this.lblTotal, null);
            this.tags.SetTag3(this.lblTotal, null);
            this.tags.SetTagFontName(this.lblTotal, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblTotal, 15F);
            this.tags.SetTagFontStyle(this.lblTotal, System.Drawing.FontStyle.Bold);
            this.lblTotal.Text = "9,999,999.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTitulo.Location = new System.Drawing.Point(51, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(126, 27);
            this.lblTitulo.TabIndex = 47;
            this.tags.SetTag2(this.lblTitulo, null);
            this.tags.SetTag3(this.lblTitulo, null);
            this.tags.SetTagFontName(this.lblTitulo, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblTitulo, 16F);
            this.tags.SetTagFontStyle(this.lblTitulo, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Text = "MegaAutos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlReloj
            // 
            this.pnlReloj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.pnlReloj.BackgroundImage = global::LP2MegaAutos.Properties.Resources.Reloj;
            this.pnlReloj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlReloj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReloj.Location = new System.Drawing.Point(0, 0);
            this.pnlReloj.Name = "pnlReloj";
            this.pnlReloj.Size = new System.Drawing.Size(40, 50);
            this.pnlReloj.TabIndex = 2;
            this.tags.SetTag2(this.pnlReloj, null);
            this.tags.SetTag3(this.pnlReloj, null);
            this.tags.SetTagFontName(this.pnlReloj, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlReloj, 10F);
            this.tags.SetTagFontStyle(this.pnlReloj, System.Drawing.FontStyle.Regular);
            // 
            // pnlColorArriba
            // 
            this.pnlColorArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.pnlColorArriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColorArriba.Location = new System.Drawing.Point(0, 0);
            this.pnlColorArriba.Name = "pnlColorArriba";
            this.pnlColorArriba.Size = new System.Drawing.Size(230, 15);
            this.pnlColorArriba.TabIndex = 1;
            this.tags.SetTag2(this.pnlColorArriba, null);
            this.tags.SetTag3(this.pnlColorArriba, null);
            this.tags.SetTagFontName(this.pnlColorArriba, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlColorArriba, 10F);
            this.tags.SetTagFontStyle(this.pnlColorArriba, System.Drawing.FontStyle.Regular);
            // 
            // pnlUltimoReporte
            // 
            this.pnlUltimoReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.pnlUltimoReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUltimoReporte.Controls.Add(this.lblUltimoReporte);
            this.pnlUltimoReporte.Location = new System.Drawing.Point(229, 15);
            this.pnlUltimoReporte.Name = "pnlUltimoReporte";
            this.pnlUltimoReporte.Size = new System.Drawing.Size(200, 40);
            this.pnlUltimoReporte.TabIndex = 2;
            this.tags.SetTag2(this.pnlUltimoReporte, null);
            this.tags.SetTag3(this.pnlUltimoReporte, null);
            this.tags.SetTagFontName(this.pnlUltimoReporte, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlUltimoReporte, 10F);
            this.tags.SetTagFontStyle(this.pnlUltimoReporte, System.Drawing.FontStyle.Regular);
            // 
            // lblUltimoReporte
            // 
            this.lblUltimoReporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUltimoReporte.AutoSize = true;
            this.lblUltimoReporte.BackColor = System.Drawing.Color.Transparent;
            this.lblUltimoReporte.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.lblUltimoReporte.ForeColor = System.Drawing.Color.White;
            this.lblUltimoReporte.Location = new System.Drawing.Point(18, 6);
            this.lblUltimoReporte.Name = "lblUltimoReporte";
            this.lblUltimoReporte.Size = new System.Drawing.Size(162, 27);
            this.lblUltimoReporte.TabIndex = 48;
            this.tags.SetTag2(this.lblUltimoReporte, null);
            this.tags.SetTag3(this.lblUltimoReporte, null);
            this.tags.SetTagFontName(this.lblUltimoReporte, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblUltimoReporte, 16F);
            this.tags.SetTagFontStyle(this.lblUltimoReporte, System.Drawing.FontStyle.Bold);
            this.lblUltimoReporte.Text = "Último Reporte";
            this.lblUltimoReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTipoReporte
            // 
            this.pnlTipoReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.pnlTipoReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTipoReporte.Controls.Add(this.lblTipoReporte);
            this.pnlTipoReporte.Location = new System.Drawing.Point(229, 54);
            this.pnlTipoReporte.Name = "pnlTipoReporte";
            this.pnlTipoReporte.Size = new System.Drawing.Size(200, 40);
            this.pnlTipoReporte.TabIndex = 49;
            this.tags.SetTag2(this.pnlTipoReporte, null);
            this.tags.SetTag3(this.pnlTipoReporte, null);
            this.tags.SetTagFontName(this.pnlTipoReporte, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlTipoReporte, 10F);
            this.tags.SetTagFontStyle(this.pnlTipoReporte, System.Drawing.FontStyle.Regular);
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipoReporte.AutoSize = true;
            this.lblTipoReporte.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoReporte.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.lblTipoReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblTipoReporte.Location = new System.Drawing.Point(3, 6);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(173, 27);
            this.lblTipoReporte.TabIndex = 48;
            this.tags.SetTag2(this.lblTipoReporte, null);
            this.tags.SetTag3(this.lblTipoReporte, null);
            this.tags.SetTagFontName(this.lblTipoReporte, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblTipoReporte, 16F);
            this.tags.SetTagFontStyle(this.lblTipoReporte, System.Drawing.FontStyle.Bold);
            this.lblTipoReporte.Text = "Áreas de Trabajo";
            this.lblTipoReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPeriodoReporte
            // 
            this.pnlPeriodoReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.pnlPeriodoReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPeriodoReporte.Controls.Add(this.lblPeriodoReporte);
            this.pnlPeriodoReporte.Location = new System.Drawing.Point(229, 93);
            this.pnlPeriodoReporte.Name = "pnlPeriodoReporte";
            this.pnlPeriodoReporte.Size = new System.Drawing.Size(200, 40);
            this.pnlPeriodoReporte.TabIndex = 50;
            this.tags.SetTag2(this.pnlPeriodoReporte, null);
            this.tags.SetTag3(this.pnlPeriodoReporte, null);
            this.tags.SetTagFontName(this.pnlPeriodoReporte, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlPeriodoReporte, 10F);
            this.tags.SetTagFontStyle(this.pnlPeriodoReporte, System.Drawing.FontStyle.Regular);
            // 
            // lblPeriodoReporte
            // 
            this.lblPeriodoReporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPeriodoReporte.AutoSize = true;
            this.lblPeriodoReporte.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriodoReporte.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.lblPeriodoReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblPeriodoReporte.Location = new System.Drawing.Point(3, 6);
            this.lblPeriodoReporte.Name = "lblPeriodoReporte";
            this.lblPeriodoReporte.Size = new System.Drawing.Size(95, 27);
            this.lblPeriodoReporte.TabIndex = 48;
            this.tags.SetTag2(this.lblPeriodoReporte, null);
            this.tags.SetTag3(this.lblPeriodoReporte, null);
            this.tags.SetTagFontName(this.lblPeriodoReporte, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblPeriodoReporte, 16F);
            this.tags.SetTagFontStyle(this.lblPeriodoReporte, System.Drawing.FontStyle.Bold);
            this.lblPeriodoReporte.Text = "Mensual";
            this.lblPeriodoReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSede
            // 
            this.pnlSede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.pnlSede.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSede.Controls.Add(this.lblSede);
            this.pnlSede.Location = new System.Drawing.Point(229, 132);
            this.pnlSede.Name = "pnlSede";
            this.pnlSede.Size = new System.Drawing.Size(200, 20);
            this.pnlSede.TabIndex = 51;
            this.tags.SetTag2(this.pnlSede, null);
            this.tags.SetTag3(this.pnlSede, null);
            this.tags.SetTagFontName(this.pnlSede, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlSede, 10F);
            this.tags.SetTagFontStyle(this.pnlSede, System.Drawing.FontStyle.Regular);
            // 
            // lblSede
            // 
            this.lblSede.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSede.AutoSize = true;
            this.lblSede.BackColor = System.Drawing.Color.Transparent;
            this.lblSede.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold);
            this.lblSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblSede.Location = new System.Drawing.Point(5, -1);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(72, 19);
            this.lblSede.TabIndex = 48;
            this.tags.SetTag2(this.lblSede, null);
            this.tags.SetTag3(this.lblSede, null);
            this.tags.SetTagFontName(this.lblSede, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblSede, 12F);
            this.tags.SetTagFontStyle(this.lblSede, System.Drawing.FontStyle.Bold);
            this.lblSede.Text = "Surquillo";
            this.lblSede.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFechasReporte
            // 
            this.pnlFechasReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.pnlFechasReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFechasReporte.Controls.Add(this.lblFechasReporte);
            this.pnlFechasReporte.Location = new System.Drawing.Point(229, 151);
            this.pnlFechasReporte.Name = "pnlFechasReporte";
            this.pnlFechasReporte.Size = new System.Drawing.Size(200, 20);
            this.pnlFechasReporte.TabIndex = 52;
            this.tags.SetTag2(this.pnlFechasReporte, null);
            this.tags.SetTag3(this.pnlFechasReporte, null);
            this.tags.SetTagFontName(this.pnlFechasReporte, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlFechasReporte, 10F);
            this.tags.SetTagFontStyle(this.pnlFechasReporte, System.Drawing.FontStyle.Regular);
            // 
            // lblFechasReporte
            // 
            this.lblFechasReporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechasReporte.AutoSize = true;
            this.lblFechasReporte.BackColor = System.Drawing.Color.Transparent;
            this.lblFechasReporte.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.lblFechasReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblFechasReporte.Location = new System.Drawing.Point(6, 1);
            this.lblFechasReporte.Name = "lblFechasReporte";
            this.lblFechasReporte.Size = new System.Drawing.Size(175, 17);
            this.lblFechasReporte.TabIndex = 48;
            this.tags.SetTag2(this.lblFechasReporte, null);
            this.tags.SetTag3(this.lblFechasReporte, null);
            this.tags.SetTagFontName(this.lblFechasReporte, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblFechasReporte, 10F);
            this.tags.SetTagFontStyle(this.lblFechasReporte, System.Drawing.FontStyle.Bold);
            this.lblFechasReporte.Text = "24/03/2020 - 24/04/2020";
            this.lblFechasReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlGeneradoPor
            // 
            this.pnlGeneradoPor.BackColor = System.Drawing.Color.White;
            this.pnlGeneradoPor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGeneradoPor.Controls.Add(this.tlpGeneradoPor);
            this.pnlGeneradoPor.Location = new System.Drawing.Point(229, 170);
            this.pnlGeneradoPor.Margin = new System.Windows.Forms.Padding(0);
            this.pnlGeneradoPor.Name = "pnlGeneradoPor";
            this.pnlGeneradoPor.Size = new System.Drawing.Size(200, 40);
            this.pnlGeneradoPor.TabIndex = 53;
            this.tags.SetTag2(this.pnlGeneradoPor, null);
            this.tags.SetTag3(this.pnlGeneradoPor, null);
            this.tags.SetTagFontName(this.pnlGeneradoPor, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlGeneradoPor, 10F);
            this.tags.SetTagFontStyle(this.pnlGeneradoPor, System.Drawing.FontStyle.Regular);
            // 
            // tlpGeneradoPor
            // 
            this.tlpGeneradoPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.tlpGeneradoPor.ColumnCount = 3;
            this.tlpGeneradoPor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGeneradoPor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpGeneradoPor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tlpGeneradoPor.Controls.Add(this.lblStringGeneradoPor, 0, 0);
            this.tlpGeneradoPor.Controls.Add(this.lblGeneradoPor, 2, 0);
            this.tlpGeneradoPor.Controls.Add(this.label1, 1, 1);
            this.tlpGeneradoPor.Controls.Add(this.lblStringEl, 0, 1);
            this.tlpGeneradoPor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeneradoPor.Location = new System.Drawing.Point(0, 0);
            this.tlpGeneradoPor.Name = "tlpGeneradoPor";
            this.tlpGeneradoPor.RowCount = 2;
            this.tlpGeneradoPor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGeneradoPor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpGeneradoPor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpGeneradoPor.Size = new System.Drawing.Size(198, 38);
            this.tlpGeneradoPor.TabIndex = 0;
            this.tags.SetTag2(this.tlpGeneradoPor, null);
            this.tags.SetTag3(this.tlpGeneradoPor, null);
            this.tags.SetTagFontName(this.tlpGeneradoPor, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.tlpGeneradoPor, 10F);
            this.tags.SetTagFontStyle(this.tlpGeneradoPor, System.Drawing.FontStyle.Regular);
            // 
            // lblStringGeneradoPor
            // 
            this.lblStringGeneradoPor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStringGeneradoPor.AutoSize = true;
            this.lblStringGeneradoPor.BackColor = System.Drawing.Color.Transparent;
            this.tlpGeneradoPor.SetColumnSpan(this.lblStringGeneradoPor, 2);
            this.lblStringGeneradoPor.Font = new System.Drawing.Font("Lato", 7F);
            this.lblStringGeneradoPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblStringGeneradoPor.Location = new System.Drawing.Point(3, 3);
            this.lblStringGeneradoPor.Name = "lblStringGeneradoPor";
            this.lblStringGeneradoPor.Size = new System.Drawing.Size(71, 12);
            this.lblStringGeneradoPor.TabIndex = 49;
            this.tags.SetTag2(this.lblStringGeneradoPor, null);
            this.tags.SetTag3(this.lblStringGeneradoPor, null);
            this.tags.SetTagFontName(this.lblStringGeneradoPor, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblStringGeneradoPor, 7F);
            this.tags.SetTagFontStyle(this.lblStringGeneradoPor, System.Drawing.FontStyle.Regular);
            this.lblStringGeneradoPor.Text = "Generado por:";
            this.lblStringGeneradoPor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGeneradoPor
            // 
            this.lblGeneradoPor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGeneradoPor.AutoSize = true;
            this.lblGeneradoPor.BackColor = System.Drawing.Color.Transparent;
            this.lblGeneradoPor.Font = new System.Drawing.Font("Lato", 7F, System.Drawing.FontStyle.Bold);
            this.lblGeneradoPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblGeneradoPor.Location = new System.Drawing.Point(119, 3);
            this.lblGeneradoPor.Name = "lblGeneradoPor";
            this.lblGeneradoPor.Size = new System.Drawing.Size(76, 12);
            this.lblGeneradoPor.TabIndex = 51;
            this.tags.SetTag2(this.lblGeneradoPor, null);
            this.tags.SetTag3(this.lblGeneradoPor, null);
            this.tags.SetTagFontName(this.lblGeneradoPor, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblGeneradoPor, 7F);
            this.tags.SetTagFontStyle(this.lblGeneradoPor, System.Drawing.FontStyle.Bold);
            this.lblGeneradoPor.Text = "Perseus Jackson";
            this.lblGeneradoPor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.tlpGeneradoPor.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Lato", 7F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(85, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 12);
            this.label1.TabIndex = 52;
            this.tags.SetTag2(this.label1, null);
            this.tags.SetTag3(this.label1, null);
            this.tags.SetTagFontName(this.label1, fontsD.Lato);
            this.tags.SetTagFontSize(this.label1, 7F);
            this.tags.SetTagFontStyle(this.label1, System.Drawing.FontStyle.Bold);
            this.label1.Text = "Miércoles, 24/05/2020";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStringEl
            // 
            this.lblStringEl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStringEl.AutoSize = true;
            this.lblStringEl.BackColor = System.Drawing.Color.Transparent;
            this.lblStringEl.Font = new System.Drawing.Font("Lato", 7F);
            this.lblStringEl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblStringEl.Location = new System.Drawing.Point(3, 22);
            this.lblStringEl.Name = "lblStringEl";
            this.lblStringEl.Size = new System.Drawing.Size(31, 12);
            this.lblStringEl.TabIndex = 50;
            this.tags.SetTag2(this.lblStringEl, null);
            this.tags.SetTag3(this.lblStringEl, null);
            this.tags.SetTagFontName(this.lblStringEl, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblStringEl, 7F);
            this.tags.SetTagFontStyle(this.lblStringEl, System.Drawing.FontStyle.Regular);
            this.lblStringEl.Text = "el día:";
            this.lblStringEl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnVerReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerReporte.FlatAppearance.BorderSize = 0;
            this.btnVerReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnVerReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerReporte.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnVerReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnVerReporte.Location = new System.Drawing.Point(0, 0);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(183, 36);
            this.btnVerReporte.TabIndex = 0;
            this.tags.SetTag2(this.btnVerReporte, null);
            this.tags.SetTag3(this.btnVerReporte, null);
            this.tags.SetTagFontName(this.btnVerReporte, fontsD.Montserrat);
            this.tags.SetTagFontSize(this.btnVerReporte, 12F);
            this.tags.SetTagFontStyle(this.btnVerReporte, System.Drawing.FontStyle.Bold);
            this.btnVerReporte.Text = "Ver Reporte";
            this.btnVerReporte.UseVisualStyleBackColor = false;
            this.btnVerReporte.Click += new System.EventHandler(this.btnVerReporte_Click);
            // 
            // pnlVerReporte
            // 
            this.pnlVerReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.pnlVerReporte.BorderColor = System.Drawing.Color.Empty;
            this.pnlVerReporte.Controls.Add(this.btnVerReporte);
            this.pnlVerReporte.Location = new System.Drawing.Point(239, 215);
            this.pnlVerReporte.Name = "pnlVerReporte";
            this.pnlVerReporte.PanelColor = System.Drawing.Color.Empty;
            this.pnlVerReporte.Size = new System.Drawing.Size(186, 40);
            this.pnlVerReporte.TabIndex = 54;
            this.pnlVerReporte.Tag = "shadow";
            this.tags.SetTag2(this.pnlVerReporte, null);
            this.tags.SetTag3(this.pnlVerReporte, null);
            this.tags.SetTagFontName(this.pnlVerReporte, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlVerReporte, 10F);
            this.tags.SetTagFontStyle(this.pnlVerReporte, System.Drawing.FontStyle.Regular);
            // 
            // UltimoReporteDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.pnlVerReporte);
            this.Controls.Add(this.pnlGeneradoPor);
            this.Controls.Add(this.pnlFechasReporte);
            this.Controls.Add(this.pnlSede);
            this.Controls.Add(this.pnlPeriodoReporte);
            this.Controls.Add(this.pnlTipoReporte);
            this.Controls.Add(this.pnlUltimoReporte);
            this.Controls.Add(this.pnlBackground);
            this.Name = "UltimoReporteDashboard";
            this.Size = new System.Drawing.Size(430, 255);
            this.tags.SetTag2(this, null);
            this.tags.SetTag3(this, null);
            this.tags.SetTagFontName(this, fontsD.Ninguno);
            this.tags.SetTagFontSize(this, 10F);
            this.tags.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.rpEgresos.ResumeLayout(false);
            this.rpEgresos.PerformLayout();
            this.tlpEgresos.ResumeLayout(false);
            this.tlpEgresos.PerformLayout();
            this.rpIngresos.ResumeLayout(false);
            this.rpIngresos.PerformLayout();
            this.tlpIngresos.ResumeLayout(false);
            this.tlpIngresos.PerformLayout();
            this.rpTotal.ResumeLayout(false);
            this.rpTotal.PerformLayout();
            this.tlpTotal.ResumeLayout(false);
            this.tlpTotal.PerformLayout();
            this.pnlUltimoReporte.ResumeLayout(false);
            this.pnlUltimoReporte.PerformLayout();
            this.pnlTipoReporte.ResumeLayout(false);
            this.pnlTipoReporte.PerformLayout();
            this.pnlPeriodoReporte.ResumeLayout(false);
            this.pnlPeriodoReporte.PerformLayout();
            this.pnlSede.ResumeLayout(false);
            this.pnlSede.PerformLayout();
            this.pnlFechasReporte.ResumeLayout(false);
            this.pnlFechasReporte.PerformLayout();
            this.pnlGeneradoPor.ResumeLayout(false);
            this.tlpGeneradoPor.ResumeLayout(false);
            this.tlpGeneradoPor.PerformLayout();
            this.pnlVerReporte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel pnlColorArriba;
        private System.Windows.Forms.Panel pnlReloj;
        private System.Windows.Forms.Label lblTitulo;
        private RoundedPanel rpTotal;
        private System.Windows.Forms.Label lblStringTotal;
        private System.Windows.Forms.TableLayoutPanel tlpTotal;
        private System.Windows.Forms.Label lblTotal;
        private RoundedPanel rpEgresos;
        private System.Windows.Forms.Label lblStringEgresos;
        private System.Windows.Forms.TableLayoutPanel tlpEgresos;
        private System.Windows.Forms.Label lblEgresos;
        private RoundedPanel rpIngresos;
        private System.Windows.Forms.Label lbStringIngresos;
        private System.Windows.Forms.TableLayoutPanel tlpIngresos;
        private System.Windows.Forms.Label lblIngresos;
        private RoundedPanel rpTitulo;
        private System.Windows.Forms.Panel pnlUltimoReporte;
        private System.Windows.Forms.Label lblUltimoReporte;
        private System.Windows.Forms.Panel pnlTipoReporte;
        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.Panel pnlPeriodoReporte;
        private System.Windows.Forms.Label lblPeriodoReporte;
        private System.Windows.Forms.Panel pnlSede;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.Panel pnlFechasReporte;
        private System.Windows.Forms.Label lblFechasReporte;
        private System.Windows.Forms.Panel pnlGeneradoPor;
        private System.Windows.Forms.TableLayoutPanel tlpGeneradoPor;
        private System.Windows.Forms.Label lblStringGeneradoPor;
        private System.Windows.Forms.Label lblGeneradoPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStringEl;
        private System.Windows.Forms.Button btnVerReporte;
        private ShadowPanel.ShadowPanelRight pnlVerReporte;
        private TagsExtender tags;
    }
}
