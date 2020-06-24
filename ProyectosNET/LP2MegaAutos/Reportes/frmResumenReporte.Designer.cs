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
            this.title_bar_2 = new System.Windows.Forms.Panel();
            this.title_bar = new System.Windows.Forms.Panel();
            this.boton_minimizar = new System.Windows.Forms.Button();
            this.boton_cerrar = new System.Windows.Forms.Button();
            this.btnFiltrar = new LP2MegaAutos.CustomControls.ClickableText();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSede = new System.Windows.Forms.Label();
            this.pnlColorArriba = new System.Windows.Forms.Panel();
            this.pnlColorAbajo = new System.Windows.Forms.Panel();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.flpReporteResumen.SuspendLayout();
            this.tlpGeneradoEl.SuspendLayout();
            this.title_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpReporteResumen
            // 
            this.flpReporteResumen.AutoScroll = true;
            this.flpReporteResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.flpReporteResumen.Controls.Add(this.itemListaResumen1);
            this.flpReporteResumen.Controls.Add(this.itemListaResumen2);
            this.flpReporteResumen.Controls.Add(this.itemListaResumen3);
            this.flpReporteResumen.Controls.Add(this.itemListaResumen4);
            this.flpReporteResumen.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpReporteResumen.Location = new System.Drawing.Point(32, 142);
            this.flpReporteResumen.Name = "flpReporteResumen";
            this.flpReporteResumen.Padding = new System.Windows.Forms.Padding(10);
            this.flpReporteResumen.Size = new System.Drawing.Size(971, 418);
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
            this.itemListaResumen1.Location = new System.Drawing.Point(13, 13);
            this.itemListaResumen1.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.itemListaResumen1.MontoEgresos = "99.00";
            this.itemListaResumen1.MontoIngresos = "9,999,999.00";
            this.itemListaResumen1.MontoTotal = "9,999,999.00";
            this.itemListaResumen1.Name = "itemListaResumen1";
            this.itemListaResumen1.Size = new System.Drawing.Size(210, 717);
            this.itemListaResumen1.TabIndex = 0;
            this.tags.SetTag2(this.itemListaResumen1, null);
            this.tags.SetTag3(this.itemListaResumen1, null);
            this.tags.SetTagFontName(this.itemListaResumen1, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.itemListaResumen1, 10F);
            this.tags.SetTagFontStyle(this.itemListaResumen1, System.Drawing.FontStyle.Regular);
            this.itemListaResumen1.TextoPrincipal = "Cuenta Grande";
            // 
            // itemListaResumen2
            // 
            this.itemListaResumen2.ColorBordeSubrayado = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.itemListaResumen2.ColorPanelSubrayado = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.itemListaResumen2.CuentasContables = "Cuentas Contables";
            this.itemListaResumen2.Location = new System.Drawing.Point(246, 13);
            this.itemListaResumen2.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.itemListaResumen2.MontoEgresos = "99.00";
            this.itemListaResumen2.MontoIngresos = "9,999,999.00";
            this.itemListaResumen2.MontoTotal = "9,999,999.00";
            this.itemListaResumen2.Name = "itemListaResumen2";
            this.itemListaResumen2.Size = new System.Drawing.Size(210, 717);
            this.itemListaResumen2.TabIndex = 1;
            this.tags.SetTag2(this.itemListaResumen2, null);
            this.tags.SetTag3(this.itemListaResumen2, null);
            this.tags.SetTagFontName(this.itemListaResumen2, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.itemListaResumen2, 10F);
            this.tags.SetTagFontStyle(this.itemListaResumen2, System.Drawing.FontStyle.Regular);
            this.itemListaResumen2.TextoPrincipal = "Cuenta Grande";
            // 
            // itemListaResumen3
            // 
            this.itemListaResumen3.ColorBordeSubrayado = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.itemListaResumen3.ColorPanelSubrayado = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.itemListaResumen3.CuentasContables = "Cuentas Contables";
            this.itemListaResumen3.Location = new System.Drawing.Point(479, 13);
            this.itemListaResumen3.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.itemListaResumen3.MontoEgresos = "99.00";
            this.itemListaResumen3.MontoIngresos = "9,999,999.00";
            this.itemListaResumen3.MontoTotal = "9,999,999.00";
            this.itemListaResumen3.Name = "itemListaResumen3";
            this.itemListaResumen3.Size = new System.Drawing.Size(210, 717);
            this.itemListaResumen3.TabIndex = 2;
            this.tags.SetTag2(this.itemListaResumen3, null);
            this.tags.SetTag3(this.itemListaResumen3, null);
            this.tags.SetTagFontName(this.itemListaResumen3, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.itemListaResumen3, 10F);
            this.tags.SetTagFontStyle(this.itemListaResumen3, System.Drawing.FontStyle.Regular);
            this.itemListaResumen3.TextoPrincipal = "Cuenta Grande";
            // 
            // itemListaResumen4
            // 
            this.itemListaResumen4.ColorBordeSubrayado = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.itemListaResumen4.ColorPanelSubrayado = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.itemListaResumen4.CuentasContables = "Cuentas Contables";
            this.itemListaResumen4.Location = new System.Drawing.Point(712, 13);
            this.itemListaResumen4.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.itemListaResumen4.MontoEgresos = "99.00";
            this.itemListaResumen4.MontoIngresos = "9,999,999.00";
            this.itemListaResumen4.MontoTotal = "9,999,999.00";
            this.itemListaResumen4.Name = "itemListaResumen4";
            this.itemListaResumen4.Size = new System.Drawing.Size(210, 717);
            this.itemListaResumen4.TabIndex = 3;
            this.tags.SetTag2(this.itemListaResumen4, null);
            this.tags.SetTag3(this.itemListaResumen4, null);
            this.tags.SetTagFontName(this.itemListaResumen4, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.itemListaResumen4, 10F);
            this.tags.SetTagFontStyle(this.itemListaResumen4, System.Drawing.FontStyle.Regular);
            this.itemListaResumen4.TextoPrincipal = "Cuenta Grande";
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
            this.tlpGeneradoEl.Controls.Add(this.lblQuienGenero, 3, 0);
            this.tlpGeneradoEl.Controls.Add(this.lblPor, 2, 0);
            this.tlpGeneradoEl.Controls.Add(this.lblFechaGenerado, 1, 0);
            this.tlpGeneradoEl.Location = new System.Drawing.Point(29, 75);
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
            // title_bar_2
            // 
            this.title_bar_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.title_bar_2.Enabled = false;
            this.title_bar_2.Location = new System.Drawing.Point(0, 24);
            this.title_bar_2.Name = "title_bar_2";
            this.title_bar_2.Size = new System.Drawing.Size(1040, 8);
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
            this.title_bar.Size = new System.Drawing.Size(1040, 24);
            this.title_bar.TabIndex = 53;
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
            this.boton_minimizar.Location = new System.Drawing.Point(991, -1);
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
            this.boton_cerrar.Location = new System.Drawing.Point(1015, -1);
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
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Montserrat", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(31, 601);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(173, 26);
            this.btnFiltrar.TabIndex = 55;
            this.tags.SetTag2(this.btnFiltrar, null);
            this.tags.SetTag3(this.btnFiltrar, null);
            this.tags.SetTagFontName(this.btnFiltrar, fontsD.Montserrat);
            this.tags.SetTagFontSize(this.btnFiltrar, 14F);
            this.tags.SetTagFontStyle(this.btnFiltrar, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.lblTitulo.Location = new System.Drawing.Point(29, 35);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(458, 35);
            this.lblTitulo.TabIndex = 54;
            this.tags.SetTag2(this.lblTitulo, null);
            this.tags.SetTag3(this.lblTitulo, null);
            this.tags.SetTagFontName(this.lblTitulo, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblTitulo, 21.75F);
            this.tags.SetTagFontStyle(this.lblTitulo, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Text = "Reporte Mensual - Área de Trabajo";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblFecha.Location = new System.Drawing.Point(817, 70);
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
            this.lblSede.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold);
            this.lblSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblSede.Location = new System.Drawing.Point(908, 41);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(109, 29);
            this.lblSede.TabIndex = 57;
            this.tags.SetTag2(this.lblSede, null);
            this.tags.SetTag3(this.lblSede, null);
            this.tags.SetTagFontName(this.lblSede, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblSede, 18F);
            this.tags.SetTagFontStyle(this.lblSede, System.Drawing.FontStyle.Bold);
            this.lblSede.Text = "Surquillo";
            // 
            // pnlColorArriba
            // 
            this.pnlColorArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.pnlColorArriba.Location = new System.Drawing.Point(32, 128);
            this.pnlColorArriba.Name = "pnlColorArriba";
            this.pnlColorArriba.Size = new System.Drawing.Size(971, 15);
            this.pnlColorArriba.TabIndex = 58;
            this.tags.SetTag2(this.pnlColorArriba, null);
            this.tags.SetTag3(this.pnlColorArriba, null);
            this.tags.SetTagFontName(this.pnlColorArriba, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlColorArriba, 10F);
            this.tags.SetTagFontStyle(this.pnlColorArriba, System.Drawing.FontStyle.Regular);
            // 
            // pnlColorAbajo
            // 
            this.pnlColorAbajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.pnlColorAbajo.Location = new System.Drawing.Point(32, 557);
            this.pnlColorAbajo.Name = "pnlColorAbajo";
            this.pnlColorAbajo.Size = new System.Drawing.Size(971, 15);
            this.pnlColorAbajo.TabIndex = 59;
            this.tags.SetTag2(this.pnlColorAbajo, null);
            this.tags.SetTag3(this.pnlColorAbajo, null);
            this.tags.SetTagFontName(this.pnlColorAbajo, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlColorAbajo, 10F);
            this.tags.SetTagFontStyle(this.pnlColorAbajo, System.Drawing.FontStyle.Regular);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnEstadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.btnEstadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnEstadisticas.Location = new System.Drawing.Point(391, 582);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(200, 45);
            this.btnEstadisticas.TabIndex = 60;
            this.tags.SetTag2(this.btnEstadisticas, null);
            this.tags.SetTag3(this.btnEstadisticas, null);
            this.tags.SetTagFontName(this.btnEstadisticas, fontsD.Montserrat);
            this.tags.SetTagFontSize(this.btnEstadisticas, 15F);
            this.tags.SetTagFontStyle(this.btnEstadisticas, System.Drawing.FontStyle.Bold);
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.btnDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnDetalle.Location = new System.Drawing.Point(597, 582);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(200, 45);
            this.btnDetalle.TabIndex = 61;
            this.tags.SetTag2(this.btnDetalle, null);
            this.tags.SetTag3(this.btnDetalle, null);
            this.tags.SetTagFontName(this.btnDetalle, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnDetalle, 15F);
            this.tags.SetTagFontStyle(this.btnDetalle, System.Drawing.FontStyle.Bold);
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = false;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnExportar.Location = new System.Drawing.Point(803, 582);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(200, 45);
            this.btnExportar.TabIndex = 62;
            this.tags.SetTag2(this.btnExportar, null);
            this.tags.SetTag3(this.btnExportar, null);
            this.tags.SetTagFontName(this.btnExportar, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnExportar, 15F);
            this.tags.SetTagFontStyle(this.btnExportar, System.Drawing.FontStyle.Bold);
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            // 
            // frmResumenReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 650);
            this.ControlBox = false;
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.pnlColorAbajo);
            this.Controls.Add(this.pnlColorArriba);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.title_bar_2);
            this.Controls.Add(this.title_bar);
            this.Controls.Add(this.tlpGeneradoEl);
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
            this.title_bar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel title_bar_2;
        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.Button boton_minimizar;
        private System.Windows.Forms.Button boton_cerrar;
        private CustomControls.ClickableText btnFiltrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.Panel pnlColorArriba;
        private System.Windows.Forms.Panel pnlColorAbajo;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnExportar;
    }
}