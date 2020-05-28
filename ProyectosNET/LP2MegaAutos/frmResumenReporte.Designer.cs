namespace LP2MegaAutos
{
    partial class frmResumenReporte
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
            this.flpReporteResumen = new System.Windows.Forms.FlowLayoutPanel();
            this.itemListaResumen1 = new LP2MegaAutos.itemListaResumen();
            this.itemListaResumen2 = new LP2MegaAutos.itemListaResumen();
            this.itemListaResumen3 = new LP2MegaAutos.itemListaResumen();
            this.itemListaResumen4 = new LP2MegaAutos.itemListaResumen();
            this.tags = new LP2MegaAutos.TagsExtender();
            this.tlpGeneradoEl = new System.Windows.Forms.TableLayoutPanel();
            this.lblGeneradoEl = new System.Windows.Forms.Label();
            this.lblFechaGenerado = new System.Windows.Forms.Label();
            this.lblQuienGenero = new System.Windows.Forms.Label();
            this.lblPor = new System.Windows.Forms.Label();
            this.pnlRojo = new System.Windows.Forms.Panel();
            this.tlpDetalles = new System.Windows.Forms.TableLayoutPanel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSede = new System.Windows.Forms.Label();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.rpTopMain = new LP2MegaAutos.RoundedPanel();
            this.btnFiltrar = new LP2MegaAutos.CustomControls.ClickableText();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rndDetalle = new LP2MegaAutos.RoundedPanel();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.title_bar_2 = new System.Windows.Forms.Panel();
            this.title_bar = new System.Windows.Forms.Panel();
            this.boton_minimizar = new System.Windows.Forms.Button();
            this.boton_cerrar = new System.Windows.Forms.Button();
            this.flpReporteResumen.SuspendLayout();
            this.tlpGeneradoEl.SuspendLayout();
            this.pnlRojo.SuspendLayout();
            this.tlpDetalles.SuspendLayout();
            this.rpTopMain.SuspendLayout();
            this.rndDetalle.SuspendLayout();
            this.title_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpReporteResumen
            // 
            this.flpReporteResumen.AutoScroll = true;
            this.flpReporteResumen.Controls.Add(this.itemListaResumen1);
            this.flpReporteResumen.Controls.Add(this.itemListaResumen2);
            this.flpReporteResumen.Controls.Add(this.itemListaResumen3);
            this.flpReporteResumen.Controls.Add(this.itemListaResumen4);
            this.flpReporteResumen.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpReporteResumen.Location = new System.Drawing.Point(0, 147);
            this.flpReporteResumen.Name = "flpReporteResumen";
            this.flpReporteResumen.Size = new System.Drawing.Size(833, 366);
            this.flpReporteResumen.TabIndex = 0;
            this.tags.SetTag2(this.flpReporteResumen, null);
            this.tags.SetTag3(this.flpReporteResumen, null);
            this.tags.SetTagFontName(this.flpReporteResumen, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.flpReporteResumen, 10F);
            this.tags.SetTagFontStyle(this.flpReporteResumen, System.Drawing.FontStyle.Regular);
            // 
            // itemListaResumen1
            // 
            this.itemListaResumen1.ColorBordeSubrayado = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.itemListaResumen1.ColorPanelSubrayado = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.itemListaResumen1.CuentasContables = "Cuentas Contables";
            this.itemListaResumen1.Location = new System.Drawing.Point(3, 3);
            this.itemListaResumen1.MontoTotal = "9,999,999.00";
            this.itemListaResumen1.Name = "itemListaResumen1";
            this.itemListaResumen1.Size = new System.Drawing.Size(210, 717);
            this.itemListaResumen1.TabIndex = 0;
            this.tags.SetTag2(this.itemListaResumen1, null);
            this.tags.SetTag3(this.itemListaResumen1, null);
            this.tags.SetTagFontName(this.itemListaResumen1, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.itemListaResumen1, 10F);
            this.tags.SetTagFontStyle(this.itemListaResumen1, System.Drawing.FontStyle.Regular);
            this.itemListaResumen1.TextoFecha = "99.00";
            this.itemListaResumen1.TextoPrincipal = "Cuenta Grande";
            this.itemListaResumen1.TextoTercero = "9,999,999.00";
            // 
            // itemListaResumen2
            // 
            this.itemListaResumen2.ColorBordeSubrayado = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.itemListaResumen2.ColorPanelSubrayado = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.itemListaResumen2.CuentasContables = "Cuentas Contables";
            this.itemListaResumen2.Location = new System.Drawing.Point(219, 3);
            this.itemListaResumen2.MontoTotal = "9,999,999.00";
            this.itemListaResumen2.Name = "itemListaResumen2";
            this.itemListaResumen2.Size = new System.Drawing.Size(210, 717);
            this.itemListaResumen2.TabIndex = 1;
            this.tags.SetTag2(this.itemListaResumen2, null);
            this.tags.SetTag3(this.itemListaResumen2, null);
            this.tags.SetTagFontName(this.itemListaResumen2, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.itemListaResumen2, 10F);
            this.tags.SetTagFontStyle(this.itemListaResumen2, System.Drawing.FontStyle.Regular);
            this.itemListaResumen2.TextoFecha = "99.00";
            this.itemListaResumen2.TextoPrincipal = "Cuenta Grande";
            this.itemListaResumen2.TextoTercero = "9,999,999.00";
            // 
            // itemListaResumen3
            // 
            this.itemListaResumen3.ColorBordeSubrayado = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.itemListaResumen3.ColorPanelSubrayado = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.itemListaResumen3.CuentasContables = "Cuentas Contables";
            this.itemListaResumen3.Location = new System.Drawing.Point(435, 3);
            this.itemListaResumen3.MontoTotal = "9,999,999.00";
            this.itemListaResumen3.Name = "itemListaResumen3";
            this.itemListaResumen3.Size = new System.Drawing.Size(210, 717);
            this.itemListaResumen3.TabIndex = 2;
            this.tags.SetTag2(this.itemListaResumen3, null);
            this.tags.SetTag3(this.itemListaResumen3, null);
            this.tags.SetTagFontName(this.itemListaResumen3, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.itemListaResumen3, 10F);
            this.tags.SetTagFontStyle(this.itemListaResumen3, System.Drawing.FontStyle.Regular);
            this.itemListaResumen3.TextoFecha = "99.00";
            this.itemListaResumen3.TextoPrincipal = "Cuenta Grande";
            this.itemListaResumen3.TextoTercero = "9,999,999.00";
            // 
            // itemListaResumen4
            // 
            this.itemListaResumen4.ColorBordeSubrayado = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.itemListaResumen4.ColorPanelSubrayado = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.itemListaResumen4.CuentasContables = "Cuentas Contables";
            this.itemListaResumen4.Location = new System.Drawing.Point(651, 3);
            this.itemListaResumen4.MontoTotal = "9,999,999.00";
            this.itemListaResumen4.Name = "itemListaResumen4";
            this.itemListaResumen4.Size = new System.Drawing.Size(210, 717);
            this.itemListaResumen4.TabIndex = 3;
            this.tags.SetTag2(this.itemListaResumen4, null);
            this.tags.SetTag3(this.itemListaResumen4, null);
            this.tags.SetTagFontName(this.itemListaResumen4, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.itemListaResumen4, 10F);
            this.tags.SetTagFontStyle(this.itemListaResumen4, System.Drawing.FontStyle.Regular);
            this.itemListaResumen4.TextoFecha = "99.00";
            this.itemListaResumen4.TextoPrincipal = "Cuenta Grande";
            this.itemListaResumen4.TextoTercero = "9,999,999.00";
            // 
            // tlpGeneradoEl
            // 
            this.tlpGeneradoEl.BackColor = System.Drawing.Color.Transparent;
            this.tlpGeneradoEl.ColumnCount = 4;
            this.tlpGeneradoEl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneradoEl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tlpGeneradoEl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpGeneradoEl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 351F));
            this.tlpGeneradoEl.Controls.Add(this.lblGeneradoEl, 0, 0);
            this.tlpGeneradoEl.Controls.Add(this.lblFechaGenerado, 1, 0);
            this.tlpGeneradoEl.Controls.Add(this.lblQuienGenero, 3, 0);
            this.tlpGeneradoEl.Controls.Add(this.lblPor, 2, 0);
            this.tlpGeneradoEl.Location = new System.Drawing.Point(0, 113);
            this.tlpGeneradoEl.Name = "tlpGeneradoEl";
            this.tlpGeneradoEl.RowCount = 1;
            this.tlpGeneradoEl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneradoEl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpGeneradoEl.Size = new System.Drawing.Size(605, 26);
            this.tlpGeneradoEl.TabIndex = 50;
            this.tags.SetTag2(this.tlpGeneradoEl, null);
            this.tags.SetTag3(this.tlpGeneradoEl, null);
            this.tags.SetTagFontName(this.tlpGeneradoEl, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.tlpGeneradoEl, 10F);
            this.tags.SetTagFontStyle(this.tlpGeneradoEl, System.Drawing.FontStyle.Regular);
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
            this.tags.SetTagFontName(this.lblQuienGenero, fontsD.Lato);
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
            this.tags.SetTagFontStyle(this.lblPor, System.Drawing.FontStyle.Regular);
            this.lblPor.Text = "por";
            // 
            // pnlRojo
            // 
            this.pnlRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            this.pnlRojo.Controls.Add(this.tlpDetalles);
            this.pnlRojo.Location = new System.Drawing.Point(0, 83);
            this.pnlRojo.Name = "pnlRojo";
            this.pnlRojo.Size = new System.Drawing.Size(832, 30);
            this.pnlRojo.TabIndex = 49;
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
            this.tlpDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.1885F));
            this.tlpDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.62056F));
            this.tlpDetalles.Controls.Add(this.lblFecha, 0, 0);
            this.tlpDetalles.Controls.Add(this.lblSede, 0, 0);
            this.tlpDetalles.Controls.Add(this.lblTipoReporte, 0, 0);
            this.tlpDetalles.Location = new System.Drawing.Point(0, 0);
            this.tlpDetalles.Name = "tlpDetalles";
            this.tlpDetalles.RowCount = 1;
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDetalles.Size = new System.Drawing.Size(833, 30);
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
            this.lblFecha.Location = new System.Drawing.Point(635, 5);
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
            this.lblSede.Location = new System.Drawing.Point(390, 5);
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
            // rpTopMain
            // 
            this.rpTopMain.ArcRadiusBorde = 15;
            this.rpTopMain.ArcRadiusPanel = 15;
            this.rpTopMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpTopMain.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpTopMain.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.rpTopMain.Controls.Add(this.btnFiltrar);
            this.rpTopMain.Controls.Add(this.lblTitulo);
            this.rpTopMain.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Top;
            this.rpTopMain.Location = new System.Drawing.Point(0, 31);
            this.rpTopMain.MenosHeightBorde = 1;
            this.rpTopMain.MenosHeightPanel = 1;
            this.rpTopMain.MenosWidthBorde = 1;
            this.rpTopMain.MenosWidthPanel = 1;
            this.rpTopMain.Name = "rpTopMain";
            this.rpTopMain.PorcLuzColorBorde = 0;
            this.rpTopMain.Size = new System.Drawing.Size(832, 52);
            this.rpTopMain.TabIndex = 48;
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
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(760, 20);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(48, 18);
            this.btnFiltrar.TabIndex = 34;
            this.tags.SetTag2(this.btnFiltrar, null);
            this.tags.SetTag3(this.btnFiltrar, null);
            this.tags.SetTagFontName(this.btnFiltrar, fontsD.Montserrat_SemiBold);
            this.tags.SetTagFontSize(this.btnFiltrar, 9.75F);
            this.tags.SetTagFontStyle(this.btnFiltrar, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.lblTitulo.Location = new System.Drawing.Point(299, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(234, 35);
            this.lblTitulo.TabIndex = 33;
            this.tags.SetTag2(this.lblTitulo, null);
            this.tags.SetTag3(this.lblTitulo, null);
            this.tags.SetTagFontName(this.lblTitulo, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblTitulo, 21.75F);
            this.tags.SetTagFontStyle(this.lblTitulo, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Text = "Reporte Mensual";
            // 
            // rndDetalle
            // 
            this.rndDetalle.ArcRadiusBorde = 8;
            this.rndDetalle.ArcRadiusPanel = 8;
            this.rndDetalle.BackColor = System.Drawing.Color.Transparent;
            this.rndDetalle.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rndDetalle.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rndDetalle.Controls.Add(this.btnDetalle);
            this.rndDetalle.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndDetalle.Location = new System.Drawing.Point(691, 116);
            this.rndDetalle.MenosHeightBorde = 1;
            this.rndDetalle.MenosHeightPanel = 1;
            this.rndDetalle.MenosWidthBorde = 1;
            this.rndDetalle.MenosWidthPanel = 1;
            this.rndDetalle.Name = "rndDetalle";
            this.rndDetalle.PorcLuzColorBorde = 0;
            this.rndDetalle.Size = new System.Drawing.Size(139, 28);
            this.rndDetalle.TabIndex = 51;
            this.tags.SetTag2(this.rndDetalle, null);
            this.tags.SetTag3(this.rndDetalle, null);
            this.tags.SetTagFontName(this.rndDetalle, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rndDetalle, 10F);
            this.tags.SetTagFontStyle(this.rndDetalle, System.Drawing.FontStyle.Regular);
            this.rndDetalle.XBorde = 0;
            this.rndDetalle.XPanel = 0;
            this.rndDetalle.YBorde = 0;
            this.rndDetalle.YPanel = 0;
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.Transparent;
            this.btnDetalle.FlatAppearance.BorderSize = 0;
            this.btnDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.btnDetalle.ForeColor = System.Drawing.Color.White;
            this.btnDetalle.Location = new System.Drawing.Point(3, 3);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(132, 22);
            this.btnDetalle.TabIndex = 6;
            this.tags.SetTag2(this.btnDetalle, null);
            this.tags.SetTag3(this.btnDetalle, null);
            this.tags.SetTagFontName(this.btnDetalle, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnDetalle, 9F);
            this.tags.SetTagFontStyle(this.btnDetalle, System.Drawing.FontStyle.Regular);
            this.btnDetalle.Text = "Volver al Detalle";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // title_bar_2
            // 
            this.title_bar_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.title_bar_2.Enabled = false;
            this.title_bar_2.Location = new System.Drawing.Point(0, 24);
            this.title_bar_2.Name = "title_bar_2";
            this.title_bar_2.Size = new System.Drawing.Size(832, 8);
            this.title_bar_2.TabIndex = 52;
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
            this.title_bar.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.title_bar.Location = new System.Drawing.Point(0, 0);
            this.title_bar.Name = "title_bar";
            this.title_bar.Size = new System.Drawing.Size(832, 24);
            this.title_bar.TabIndex = 53;
            this.title_bar.Tag = "titlebar";
            this.tags.SetTag2(this.title_bar, null);
            this.tags.SetTag3(this.title_bar, null);
            this.tags.SetTagFontName(this.title_bar, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.title_bar, 10F);
            this.tags.SetTagFontStyle(this.title_bar, System.Drawing.FontStyle.Regular);
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
            // 
            // frmResumenReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 554);
            this.ControlBox = false;
            this.Controls.Add(this.title_bar_2);
            this.Controls.Add(this.title_bar);
            this.Controls.Add(this.rndDetalle);
            this.Controls.Add(this.tlpGeneradoEl);
            this.Controls.Add(this.pnlRojo);
            this.Controls.Add(this.rpTopMain);
            this.Controls.Add(this.flpReporteResumen);
            this.DisplayHeader = false;
            this.Name = "frmResumenReporte";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.tags.SetTag2(this, null);
            this.tags.SetTag3(this, null);
            this.tags.SetTagFontName(this, fontsD.Ninguno);
            this.tags.SetTagFontSize(this, 10F);
            this.tags.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.Text = "Resumen Reporte";
            this.flpReporteResumen.ResumeLayout(false);
            this.tlpGeneradoEl.ResumeLayout(false);
            this.tlpGeneradoEl.PerformLayout();
            this.pnlRojo.ResumeLayout(false);
            this.tlpDetalles.ResumeLayout(false);
            this.tlpDetalles.PerformLayout();
            this.rpTopMain.ResumeLayout(false);
            this.rpTopMain.PerformLayout();
            this.rndDetalle.ResumeLayout(false);
            this.title_bar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpReporteResumen;
        private itemListaResumen itemListaResumen1;
        private itemListaResumen itemListaResumen2;
        private itemListaResumen itemListaResumen3;
        private itemListaResumen itemListaResumen4;
        private TagsExtender tags;
        private System.Windows.Forms.TableLayoutPanel tlpGeneradoEl;
        private System.Windows.Forms.Label lblGeneradoEl;
        private System.Windows.Forms.Label lblFechaGenerado;
        private System.Windows.Forms.Label lblQuienGenero;
        private System.Windows.Forms.Label lblPor;
        private System.Windows.Forms.Panel pnlRojo;
        private System.Windows.Forms.TableLayoutPanel tlpDetalles;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.Label lblTipoReporte;
        private RoundedPanel rpTopMain;
        private CustomControls.ClickableText btnFiltrar;
        private System.Windows.Forms.Label lblTitulo;
        private RoundedPanel rndDetalle;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Panel title_bar_2;
        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.Button boton_minimizar;
        private System.Windows.Forms.Button boton_cerrar;
    }
}