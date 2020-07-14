namespace LP2MegaAutos
{
    partial class pantallaDetalleReporte
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
            this.rpTopMain = new LP2MegaAutos.RoundedPanel();
            this.clickableText1 = new LP2MegaAutos.CustomControls.ClickableText();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rpBtnGenerarReporte = new LP2MegaAutos.RoundedPanel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.pnlRojo = new System.Windows.Forms.Panel();
            this.tlpDetalles = new System.Windows.Forms.TableLayoutPanel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSede = new System.Windows.Forms.Label();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.tags = new LP2MegaAutos.TagsExtender();
            this.lblGeneradoEl = new System.Windows.Forms.Label();
            this.lblFechaGenerado = new System.Windows.Forms.Label();
            this.lblQuienGenero = new System.Windows.Forms.Label();
            this.lblPor = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblEgresos = new System.Windows.Forms.Label();
            this.rpIngresos = new LP2MegaAutos.RoundedPanel();
            this.rpEgresos = new LP2MegaAutos.RoundedPanel();
            this.rndResumen = new LP2MegaAutos.RoundedPanel();
            this.btnResumen = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.itemDetalleGrandeReporte1 = new LP2MegaAutos.itemDetalleGrandeReporte();
            this.itemDetalleReporte1 = new LP2MegaAutos.itemDetalleReporte();
            this.itemDetalleReporte3 = new LP2MegaAutos.itemDetalleReporte();
            this.itemDetalleGrandeReporte2 = new LP2MegaAutos.itemDetalleGrandeReporte();
            this.itemDetalleReporte2 = new LP2MegaAutos.itemDetalleReporte();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rpTopMain.SuspendLayout();
            this.rpBtnGenerarReporte.SuspendLayout();
            this.pnlRojo.SuspendLayout();
            this.tlpDetalles.SuspendLayout();
            this.rndResumen.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpTopMain
            // 
            this.rpTopMain.ArcRadiusBorde = 15;
            this.rpTopMain.ArcRadiusPanel = 15;
            this.rpTopMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpTopMain.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpTopMain.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.rpTopMain.Controls.Add(this.clickableText1);
            this.rpTopMain.Controls.Add(this.lblTitulo);
            this.rpTopMain.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Top;
            this.rpTopMain.Location = new System.Drawing.Point(0, 0);
            this.rpTopMain.MenosHeightBorde = 1;
            this.rpTopMain.MenosHeightPanel = 1;
            this.rpTopMain.MenosWidthBorde = 1;
            this.rpTopMain.MenosWidthPanel = 1;
            this.rpTopMain.Name = "rpTopMain";
            this.rpTopMain.PorcLuzColorBorde = 0;
            this.rpTopMain.Size = new System.Drawing.Size(611, 50);
            this.rpTopMain.TabIndex = 31;
            this.tags.SetTag2(this.rpTopMain, null);
            this.tags.SetTag3(this.rpTopMain, null);
            this.tags.SetTagFontName(this.rpTopMain, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpTopMain, 10F);
            this.tags.SetTagFontStyle(this.rpTopMain, System.Drawing.FontStyle.Regular);
            this.rpTopMain.XBorde = 0;
            this.rpTopMain.XPanel = 0;
            this.rpTopMain.YBorde = 0;
            this.rpTopMain.YPanel = 0;
            // 
            // clickableText1
            // 
            this.clickableText1.BackColor = System.Drawing.Color.Transparent;
            this.clickableText1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clickableText1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clickableText1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickableText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.clickableText1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clickableText1.Location = new System.Drawing.Point(553, 19);
            this.clickableText1.Name = "clickableText1";
            this.clickableText1.Size = new System.Drawing.Size(48, 18);
            this.clickableText1.TabIndex = 34;
            this.tags.SetTag2(this.clickableText1, null);
            this.tags.SetTag3(this.clickableText1, null);
            this.tags.SetTagFontName(this.clickableText1, fontsD.Montserrat_SemiBold);
            this.tags.SetTagFontSize(this.clickableText1, 10F);
            this.tags.SetTagFontStyle(this.clickableText1, System.Drawing.FontStyle.Underline);
            this.clickableText1.Text = "Filtrar";
            this.clickableText1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.lblTitulo.Location = new System.Drawing.Point(191, 8);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(234, 35);
            this.lblTitulo.TabIndex = 33;
            this.tags.SetTag2(this.lblTitulo, null);
            this.tags.SetTag3(this.lblTitulo, null);
            this.tags.SetTagFontName(this.lblTitulo, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblTitulo, 10F);
            this.tags.SetTagFontStyle(this.lblTitulo, System.Drawing.FontStyle.Regular);
            this.lblTitulo.Text = "Reporte Mensual";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // rpBtnGenerarReporte
            // 
            this.rpBtnGenerarReporte.ArcRadiusBorde = 15;
            this.rpBtnGenerarReporte.ArcRadiusPanel = 15;
            this.rpBtnGenerarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpBtnGenerarReporte.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpBtnGenerarReporte.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rpBtnGenerarReporte.Controls.Add(this.btnExportar);
            this.rpBtnGenerarReporte.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Bottom;
            this.rpBtnGenerarReporte.Location = new System.Drawing.Point(0, 413);
            this.rpBtnGenerarReporte.MenosHeightBorde = 1;
            this.rpBtnGenerarReporte.MenosHeightPanel = 1;
            this.rpBtnGenerarReporte.MenosWidthBorde = 1;
            this.rpBtnGenerarReporte.MenosWidthPanel = 1;
            this.rpBtnGenerarReporte.Name = "rpBtnGenerarReporte";
            this.rpBtnGenerarReporte.PorcLuzColorBorde = 0;
            this.rpBtnGenerarReporte.Size = new System.Drawing.Size(611, 57);
            this.rpBtnGenerarReporte.TabIndex = 32;
            this.tags.SetTag2(this.rpBtnGenerarReporte, null);
            this.tags.SetTag3(this.rpBtnGenerarReporte, null);
            this.tags.SetTagFontName(this.rpBtnGenerarReporte, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpBtnGenerarReporte, 10F);
            this.tags.SetTagFontStyle(this.rpBtnGenerarReporte, System.Drawing.FontStyle.Regular);
            this.rpBtnGenerarReporte.XBorde = 0;
            this.rpBtnGenerarReporte.XPanel = 0;
            this.rpBtnGenerarReporte.YBorde = 0;
            this.rpBtnGenerarReporte.YPanel = 0;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Transparent;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnExportar.Location = new System.Drawing.Point(16, 3);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(578, 51);
            this.btnExportar.TabIndex = 32;
            this.tags.SetTag2(this.btnExportar, null);
            this.tags.SetTag3(this.btnExportar, null);
            this.tags.SetTagFontName(this.btnExportar, fontsD.Lato);
            this.tags.SetTagFontSize(this.btnExportar, 10F);
            this.tags.SetTagFontStyle(this.btnExportar, System.Drawing.FontStyle.Regular);
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // pnlRojo
            // 
            this.pnlRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            this.pnlRojo.Controls.Add(this.tlpDetalles);
            this.pnlRojo.Location = new System.Drawing.Point(0, 50);
            this.pnlRojo.Name = "pnlRojo";
            this.pnlRojo.Size = new System.Drawing.Size(611, 30);
            this.pnlRojo.TabIndex = 33;
            this.tags.SetTag2(this.pnlRojo, null);
            this.tags.SetTag3(this.pnlRojo, null);
            this.tags.SetTagFontName(this.pnlRojo, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlRojo, 10F);
            this.tags.SetTagFontStyle(this.pnlRojo, System.Drawing.FontStyle.Regular);
            // 
            // tlpDetalles
            // 
            this.tlpDetalles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpDetalles.ColumnCount = 3;
            this.tlpDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.24223F));
            this.tlpDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.55156F));
            this.tlpDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.04255F));
            this.tlpDetalles.Controls.Add(this.lblFecha, 0, 0);
            this.tlpDetalles.Controls.Add(this.lblSede, 0, 0);
            this.tlpDetalles.Controls.Add(this.lblTipoReporte, 0, 0);
            this.tlpDetalles.Location = new System.Drawing.Point(0, 0);
            this.tlpDetalles.Name = "tlpDetalles";
            this.tlpDetalles.RowCount = 1;
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDetalles.Size = new System.Drawing.Size(611, 30);
            this.tlpDetalles.TabIndex = 35;
            this.tags.SetTag2(this.tlpDetalles, null);
            this.tags.SetTag3(this.tlpDetalles, null);
            this.tags.SetTagFontName(this.tlpDetalles, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.tlpDetalles, 10F);
            this.tags.SetTagFontStyle(this.tlpDetalles, System.Drawing.FontStyle.Regular);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.lblFecha.Location = new System.Drawing.Point(413, 5);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(195, 19);
            this.lblFecha.TabIndex = 35;
            this.tags.SetTag2(this.lblFecha, null);
            this.tags.SetTag3(this.lblFecha, null);
            this.tags.SetTagFontName(this.lblFecha, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblFecha, 12F);
            this.tags.SetTagFontStyle(this.lblFecha, System.Drawing.FontStyle.Bold);
            this.lblFecha.Text = "24/03/2020 - 24/04/2020";
            // 
            // lblSede
            // 
            this.lblSede.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSede.AutoSize = true;
            this.lblSede.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.lblSede.Location = new System.Drawing.Point(263, 5);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(72, 19);
            this.lblSede.TabIndex = 2;
            this.tags.SetTag2(this.lblSede, null);
            this.tags.SetTag3(this.lblSede, null);
            this.tags.SetTagFontName(this.lblSede, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblSede, 12F);
            this.tags.SetTagFontStyle(this.lblSede, System.Drawing.FontStyle.Bold);
            this.lblSede.Text = "Surquillo";
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTipoReporte.AutoSize = true;
            this.lblTipoReporte.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.lblTipoReporte.Location = new System.Drawing.Point(3, 5);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(121, 19);
            this.lblTipoReporte.TabIndex = 1;
            this.tags.SetTag2(this.lblTipoReporte, null);
            this.tags.SetTag3(this.lblTipoReporte, null);
            this.tags.SetTagFontName(this.lblTipoReporte, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblTipoReporte, 12F);
            this.tags.SetTagFontStyle(this.lblTipoReporte, System.Drawing.FontStyle.Bold);
            this.lblTipoReporte.Text = "Área de Trabajo";
            // 
            // lblGeneradoEl
            // 
            this.lblGeneradoEl.AutoSize = true;
            this.lblGeneradoEl.Font = new System.Drawing.Font("Lato", 12F);
            this.lblGeneradoEl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblGeneradoEl.Location = new System.Drawing.Point(3, 0);
            this.lblGeneradoEl.Name = "lblGeneradoEl";
            this.lblGeneradoEl.Size = new System.Drawing.Size(94, 19);
            this.lblGeneradoEl.TabIndex = 35;
            this.tags.SetTag2(this.lblGeneradoEl, null);
            this.tags.SetTag3(this.lblGeneradoEl, null);
            this.tags.SetTagFontName(this.lblGeneradoEl, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblGeneradoEl, 12F);
            this.tags.SetTagFontStyle(this.lblGeneradoEl, System.Drawing.FontStyle.Regular);
            this.lblGeneradoEl.Text = "Generado el";
            // 
            // lblFechaGenerado
            // 
            this.lblFechaGenerado.AutoSize = true;
            this.lblFechaGenerado.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaGenerado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblFechaGenerado.Location = new System.Drawing.Point(106, 0);
            this.lblFechaGenerado.Name = "lblFechaGenerado";
            this.lblFechaGenerado.Size = new System.Drawing.Size(95, 19);
            this.lblFechaGenerado.TabIndex = 36;
            this.tags.SetTag2(this.lblFechaGenerado, null);
            this.tags.SetTag3(this.lblFechaGenerado, null);
            this.tags.SetTagFontName(this.lblFechaGenerado, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblFechaGenerado, 12F);
            this.tags.SetTagFontStyle(this.lblFechaGenerado, System.Drawing.FontStyle.Bold);
            this.lblFechaGenerado.Text = "24/05/2020";
            // 
            // lblQuienGenero
            // 
            this.lblQuienGenero.AutoSize = true;
            this.lblQuienGenero.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuienGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblQuienGenero.Location = new System.Drawing.Point(257, 0);
            this.lblQuienGenero.Name = "lblQuienGenero";
            this.lblQuienGenero.Size = new System.Drawing.Size(111, 19);
            this.lblQuienGenero.TabIndex = 38;
            this.tags.SetTag2(this.lblQuienGenero, null);
            this.tags.SetTag3(this.lblQuienGenero, null);
            this.tags.SetTagFontName(this.lblQuienGenero, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.lblQuienGenero, 12F);
            this.tags.SetTagFontStyle(this.lblQuienGenero, System.Drawing.FontStyle.Bold);
            this.lblQuienGenero.Text = "Percy Jackson";
            // 
            // lblPor
            // 
            this.lblPor.AutoSize = true;
            this.lblPor.Font = new System.Drawing.Font("Lato", 12F);
            this.lblPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblPor.Location = new System.Drawing.Point(212, 0);
            this.lblPor.Name = "lblPor";
            this.lblPor.Size = new System.Drawing.Size(33, 19);
            this.lblPor.TabIndex = 37;
            this.tags.SetTag2(this.lblPor, null);
            this.tags.SetTag3(this.lblPor, null);
            this.tags.SetTagFontName(this.lblPor, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblPor, 12F);
            this.tags.SetTagFontStyle(this.lblPor, System.Drawing.FontStyle.Bold);
            this.lblPor.Text = "por";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.lblIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblIngresos.Location = new System.Drawing.Point(366, 109);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(96, 27);
            this.lblIngresos.TabIndex = 39;
            this.tags.SetTag2(this.lblIngresos, null);
            this.tags.SetTag3(this.lblIngresos, null);
            this.tags.SetTagFontName(this.lblIngresos, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblIngresos, 16F);
            this.tags.SetTagFontStyle(this.lblIngresos, System.Drawing.FontStyle.Bold);
            this.lblIngresos.Text = "Ingresos";
            // 
            // lblEgresos
            // 
            this.lblEgresos.AutoSize = true;
            this.lblEgresos.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.lblEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblEgresos.Location = new System.Drawing.Point(498, 109);
            this.lblEgresos.Name = "lblEgresos";
            this.lblEgresos.Size = new System.Drawing.Size(90, 27);
            this.lblEgresos.TabIndex = 40;
            this.tags.SetTag2(this.lblEgresos, null);
            this.tags.SetTag3(this.lblEgresos, null);
            this.tags.SetTagFontName(this.lblEgresos, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblEgresos, 16F);
            this.tags.SetTagFontStyle(this.lblEgresos, System.Drawing.FontStyle.Bold);
            this.lblEgresos.Text = "Egresos";
            this.lblEgresos.Click += new System.EventHandler(this.label3_Click);
            // 
            // rpIngresos
            // 
            this.rpIngresos.ArcRadiusBorde = 15;
            this.rpIngresos.ArcRadiusPanel = 15;
            this.rpIngresos.BackColor = System.Drawing.Color.Transparent;
            this.rpIngresos.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.rpIngresos.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.rpIngresos.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Top;
            this.rpIngresos.Location = new System.Drawing.Point(378, 138);
            this.rpIngresos.MenosHeightBorde = 1;
            this.rpIngresos.MenosHeightPanel = 1;
            this.rpIngresos.MenosWidthBorde = 1;
            this.rpIngresos.MenosWidthPanel = 1;
            this.rpIngresos.Name = "rpIngresos";
            this.rpIngresos.PorcLuzColorBorde = 0;
            this.rpIngresos.Size = new System.Drawing.Size(73, 4);
            this.rpIngresos.TabIndex = 41;
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
            // rpEgresos
            // 
            this.rpEgresos.ArcRadiusBorde = 15;
            this.rpEgresos.ArcRadiusPanel = 15;
            this.rpEgresos.BackColor = System.Drawing.Color.Transparent;
            this.rpEgresos.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rpEgresos.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rpEgresos.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Top;
            this.rpEgresos.Location = new System.Drawing.Point(507, 138);
            this.rpEgresos.MenosHeightBorde = 1;
            this.rpEgresos.MenosHeightPanel = 1;
            this.rpEgresos.MenosWidthBorde = 1;
            this.rpEgresos.MenosWidthPanel = 1;
            this.rpEgresos.Name = "rpEgresos";
            this.rpEgresos.PorcLuzColorBorde = 0;
            this.rpEgresos.Size = new System.Drawing.Size(73, 4);
            this.rpEgresos.TabIndex = 42;
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
            // rndResumen
            // 
            this.rndResumen.ArcRadiusBorde = 8;
            this.rndResumen.ArcRadiusPanel = 8;
            this.rndResumen.BackColor = System.Drawing.Color.Transparent;
            this.rndResumen.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rndResumen.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rndResumen.Controls.Add(this.btnResumen);
            this.rndResumen.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndResumen.Location = new System.Drawing.Point(3, 111);
            this.rndResumen.MenosHeightBorde = 1;
            this.rndResumen.MenosHeightPanel = 1;
            this.rndResumen.MenosWidthBorde = 1;
            this.rndResumen.MenosWidthPanel = 1;
            this.rndResumen.Name = "rndResumen";
            this.rndResumen.PorcLuzColorBorde = 0;
            this.rndResumen.Size = new System.Drawing.Size(139, 28);
            this.rndResumen.TabIndex = 44;
            this.tags.SetTag2(this.rndResumen, null);
            this.tags.SetTag3(this.rndResumen, null);
            this.tags.SetTagFontName(this.rndResumen, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rndResumen, 10F);
            this.tags.SetTagFontStyle(this.rndResumen, System.Drawing.FontStyle.Regular);
            this.rndResumen.XBorde = 0;
            this.rndResumen.XPanel = 0;
            this.rndResumen.YBorde = 0;
            this.rndResumen.YPanel = 0;
            // 
            // btnResumen
            // 
            this.btnResumen.BackColor = System.Drawing.Color.Transparent;
            this.btnResumen.FlatAppearance.BorderSize = 0;
            this.btnResumen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumen.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.btnResumen.ForeColor = System.Drawing.Color.White;
            this.btnResumen.Location = new System.Drawing.Point(3, 3);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(132, 22);
            this.btnResumen.TabIndex = 6;
            this.tags.SetTag2(this.btnResumen, null);
            this.tags.SetTag3(this.btnResumen, null);
            this.tags.SetTagFontName(this.btnResumen, fontsD.Montserrat);
            this.tags.SetTagFontSize(this.btnResumen, 9F);
            this.tags.SetTagFontStyle(this.btnResumen, System.Drawing.FontStyle.Regular);
            this.btnResumen.Text = "Ver Resumen";
            this.btnResumen.UseVisualStyleBackColor = false;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.flowLayoutPanel1.Controls.Add(this.itemDetalleGrandeReporte1);
            this.flowLayoutPanel1.Controls.Add(this.itemDetalleReporte1);
            this.flowLayoutPanel1.Controls.Add(this.itemDetalleReporte3);
            this.flowLayoutPanel1.Controls.Add(this.itemDetalleGrandeReporte2);
            this.flowLayoutPanel1.Controls.Add(this.itemDetalleReporte2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 145);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(605, 252);
            this.flowLayoutPanel1.TabIndex = 45;
            this.tags.SetTag2(this.flowLayoutPanel1, null);
            this.tags.SetTag3(this.flowLayoutPanel1, null);
            this.tags.SetTagFontName(this.flowLayoutPanel1, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.flowLayoutPanel1, 10F);
            this.tags.SetTagFontStyle(this.flowLayoutPanel1, System.Drawing.FontStyle.Regular);
            // 
            // itemDetalleGrandeReporte1
            // 
            this.itemDetalleGrandeReporte1.AutoSize = true;
            this.itemDetalleGrandeReporte1.CuentaGrande = "Hola";
            this.itemDetalleGrandeReporte1.Egreso = "9,999,999.00";
            this.itemDetalleGrandeReporte1.Ingreso = "9,999,999.00";
            this.itemDetalleGrandeReporte1.Location = new System.Drawing.Point(9, 4);
            this.itemDetalleGrandeReporte1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemDetalleGrandeReporte1.Name = "itemDetalleGrandeReporte1";
            this.itemDetalleGrandeReporte1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.itemDetalleGrandeReporte1.Size = new System.Drawing.Size(575, 74);
            this.itemDetalleGrandeReporte1.TabIndex = 0;
            this.tags.SetTag2(this.itemDetalleGrandeReporte1, null);
            this.tags.SetTag3(this.itemDetalleGrandeReporte1, null);
            this.tags.SetTagFontName(this.itemDetalleGrandeReporte1, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.itemDetalleGrandeReporte1, 10F);
            this.tags.SetTagFontStyle(this.itemDetalleGrandeReporte1, System.Drawing.FontStyle.Regular);
            this.itemDetalleGrandeReporte1.TipoCuenta = "Tipo de Cuenta";
            // 
            // itemDetalleReporte1
            // 
            this.itemDetalleReporte1.CuentaGrande = "Cuenta Grande";
            this.itemDetalleReporte1.Egreso = "9,999,999.00";
            this.itemDetalleReporte1.Ingreso = "9,999,999.00";
            this.itemDetalleReporte1.Location = new System.Drawing.Point(50, 86);
            this.itemDetalleReporte1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemDetalleReporte1.Name = "itemDetalleReporte1";
            this.itemDetalleReporte1.Size = new System.Drawing.Size(534, 60);
            this.itemDetalleReporte1.TabIndex = 1;
            this.tags.SetTag2(this.itemDetalleReporte1, null);
            this.tags.SetTag3(this.itemDetalleReporte1, null);
            this.tags.SetTagFontName(this.itemDetalleReporte1, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.itemDetalleReporte1, 10F);
            this.tags.SetTagFontStyle(this.itemDetalleReporte1, System.Drawing.FontStyle.Regular);
            this.itemDetalleReporte1.TipoCuenta = "Tipo de Cuenta";
            // 
            // itemDetalleReporte3
            // 
            this.itemDetalleReporte3.CuentaGrande = "Cuenta Grande";
            this.itemDetalleReporte3.Egreso = "9,999,999.00";
            this.itemDetalleReporte3.Ingreso = "9,999,999.00";
            this.itemDetalleReporte3.Location = new System.Drawing.Point(50, 154);
            this.itemDetalleReporte3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemDetalleReporte3.Name = "itemDetalleReporte3";
            this.itemDetalleReporte3.Size = new System.Drawing.Size(534, 60);
            this.itemDetalleReporte3.TabIndex = 4;
            this.tags.SetTag2(this.itemDetalleReporte3, null);
            this.tags.SetTag3(this.itemDetalleReporte3, null);
            this.tags.SetTagFontName(this.itemDetalleReporte3, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.itemDetalleReporte3, 10F);
            this.tags.SetTagFontStyle(this.itemDetalleReporte3, System.Drawing.FontStyle.Regular);
            this.itemDetalleReporte3.TipoCuenta = "Tipo de Cuenta";
            // 
            // itemDetalleGrandeReporte2
            // 
            this.itemDetalleGrandeReporte2.AutoScroll = true;
            this.itemDetalleGrandeReporte2.CuentaGrande = "Cuenta Grande";
            this.itemDetalleGrandeReporte2.Egreso = "9,999,999.00";
            this.itemDetalleGrandeReporte2.Ingreso = "9,999,999.00";
            this.itemDetalleGrandeReporte2.Location = new System.Drawing.Point(9, 222);
            this.itemDetalleGrandeReporte2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemDetalleGrandeReporte2.Name = "itemDetalleGrandeReporte2";
            this.itemDetalleGrandeReporte2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.itemDetalleGrandeReporte2.Size = new System.Drawing.Size(575, 71);
            this.itemDetalleGrandeReporte2.TabIndex = 3;
            this.tags.SetTag2(this.itemDetalleGrandeReporte2, null);
            this.tags.SetTag3(this.itemDetalleGrandeReporte2, null);
            this.tags.SetTagFontName(this.itemDetalleGrandeReporte2, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.itemDetalleGrandeReporte2, 10F);
            this.tags.SetTagFontStyle(this.itemDetalleGrandeReporte2, System.Drawing.FontStyle.Regular);
            this.itemDetalleGrandeReporte2.TipoCuenta = "Tipo de Cuenta";
            // 
            // itemDetalleReporte2
            // 
            this.itemDetalleReporte2.CuentaGrande = "Cuenta Grande";
            this.itemDetalleReporte2.Egreso = "9,999,999.00";
            this.itemDetalleReporte2.Ingreso = "9,999,999.00";
            this.itemDetalleReporte2.Location = new System.Drawing.Point(50, 301);
            this.itemDetalleReporte2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemDetalleReporte2.Name = "itemDetalleReporte2";
            this.itemDetalleReporte2.Size = new System.Drawing.Size(534, 60);
            this.itemDetalleReporte2.TabIndex = 2;
            this.tags.SetTag2(this.itemDetalleReporte2, null);
            this.tags.SetTag3(this.itemDetalleReporte2, null);
            this.tags.SetTagFontName(this.itemDetalleReporte2, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.itemDetalleReporte2, 10F);
            this.tags.SetTagFontStyle(this.itemDetalleReporte2, System.Drawing.FontStyle.Regular);
            this.itemDetalleReporte2.TipoCuenta = "Tipo de Cuenta";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 351F));
            this.tableLayoutPanel1.Controls.Add(this.lblGeneradoEl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaGenerado, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQuienGenero, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPor, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(605, 26);
            this.tableLayoutPanel1.TabIndex = 46;
            this.tags.SetTag2(this.tableLayoutPanel1, null);
            this.tags.SetTag3(this.tableLayoutPanel1, null);
            this.tags.SetTagFontName(this.tableLayoutPanel1, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.tableLayoutPanel1, 10F);
            this.tags.SetTagFontStyle(this.tableLayoutPanel1, System.Drawing.FontStyle.Regular);
            // 
            // pantallaDetalleReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.rndResumen);
            this.Controls.Add(this.rpEgresos);
            this.Controls.Add(this.rpIngresos);
            this.Controls.Add(this.lblEgresos);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.pnlRojo);
            this.Controls.Add(this.rpBtnGenerarReporte);
            this.Controls.Add(this.rpTopMain);
            this.Name = "pantallaDetalleReporte";
            this.Size = new System.Drawing.Size(611, 470);
            this.tags.SetTag2(this, null);
            this.tags.SetTag3(this, null);
            this.tags.SetTagFontName(this, fontsD.Ninguno);
            this.tags.SetTagFontSize(this, 10F);
            this.tags.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.Load += new System.EventHandler(this.pantallaListarReportes_Load);
            this.rpTopMain.ResumeLayout(false);
            this.rpTopMain.PerformLayout();
            this.rpBtnGenerarReporte.ResumeLayout(false);
            this.pnlRojo.ResumeLayout(false);
            this.tlpDetalles.ResumeLayout(false);
            this.tlpDetalles.PerformLayout();
            this.rndResumen.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundedPanel rpTopMain;
        private RoundedPanel rpBtnGenerarReporte;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlRojo;
        private TagsExtender tags;
        private System.Windows.Forms.Label lblGeneradoEl;
        private System.Windows.Forms.Label lblFechaGenerado;
        private System.Windows.Forms.Label lblQuienGenero;
        private System.Windows.Forms.Label lblPor;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblEgresos;
        private RoundedPanel rpIngresos;
        private RoundedPanel rpEgresos;
        private RoundedPanel rndResumen;
        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private itemDetalleGrandeReporte itemDetalleGrandeReporte1;
        private itemDetalleReporte itemDetalleReporte1;
        private itemDetalleReporte itemDetalleReporte3;
        private itemDetalleGrandeReporte itemDetalleGrandeReporte2;
        private itemDetalleReporte itemDetalleReporte2;
        private System.Windows.Forms.TableLayoutPanel tlpDetalles;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomControls.ClickableText clickableText1;
    }
}
