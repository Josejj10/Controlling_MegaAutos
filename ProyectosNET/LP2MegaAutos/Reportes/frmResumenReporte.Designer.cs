﻿namespace LP2MegaAutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResumenReporte));
            this.flpReporteResumen = new System.Windows.Forms.FlowLayoutPanel();
            this.tags = new LP2MegaAutos.TagsExtender();
            this.tlpGeneradoEl = new System.Windows.Forms.TableLayoutPanel();
            this.lblGeneradoEl = new System.Windows.Forms.Label();
            this.lblQuienGenero = new System.Windows.Forms.Label();
            this.lblPor = new System.Windows.Forms.Label();
            this.lblFechaGenerado = new System.Windows.Forms.Label();
            this.title_bar_2 = new System.Windows.Forms.Panel();
            this.title_bar = new System.Windows.Forms.Panel();
            this.boton_cerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSede = new System.Windows.Forms.Label();
            this.pnlColorArriba = new System.Windows.Forms.Panel();
            this.pnlColorAbajo = new System.Windows.Forms.Panel();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.sfdArchivoReporte = new System.Windows.Forms.SaveFileDialog();
            this.boton_minimizar = new System.Windows.Forms.Button();
            this.tlpGeneradoEl.SuspendLayout();
            this.title_bar.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpReporteResumen
            // 
            this.flpReporteResumen.AutoScroll = true;
            this.flpReporteResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.flpReporteResumen.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpReporteResumen.Location = new System.Drawing.Point(43, 175);
            this.flpReporteResumen.Margin = new System.Windows.Forms.Padding(4);
            this.flpReporteResumen.Name = "flpReporteResumen";
            this.flpReporteResumen.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.flpReporteResumen.Size = new System.Drawing.Size(1295, 514);
            this.flpReporteResumen.TabIndex = 0;
            this.tags.SetTag2(this.flpReporteResumen, null);
            this.tags.SetTag3(this.flpReporteResumen, null);
            this.tags.SetTagFontName(this.flpReporteResumen, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.flpReporteResumen, 10F);
            this.tags.SetTagFontStyle(this.flpReporteResumen, System.Drawing.FontStyle.Regular);
            // 
            // tlpGeneradoEl
            // 
            this.tlpGeneradoEl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.tlpGeneradoEl.ColumnCount = 4;
            this.tlpGeneradoEl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneradoEl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tlpGeneradoEl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpGeneradoEl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 468F));
            this.tlpGeneradoEl.Controls.Add(this.lblGeneradoEl, 0, 0);
            this.tlpGeneradoEl.Controls.Add(this.lblQuienGenero, 3, 0);
            this.tlpGeneradoEl.Controls.Add(this.lblPor, 2, 0);
            this.tlpGeneradoEl.Controls.Add(this.lblFechaGenerado, 1, 0);
            this.tlpGeneradoEl.Location = new System.Drawing.Point(43, 103);
            this.tlpGeneradoEl.Margin = new System.Windows.Forms.Padding(4);
            this.tlpGeneradoEl.Name = "tlpGeneradoEl";
            this.tlpGeneradoEl.RowCount = 1;
            this.tlpGeneradoEl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneradoEl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpGeneradoEl.Size = new System.Drawing.Size(807, 32);
            this.tlpGeneradoEl.TabIndex = 50;
            this.tags.SetTag2(this.tlpGeneradoEl, null);
            this.tags.SetTag3(this.tlpGeneradoEl, null);
            this.tags.SetTagFontName(this.tlpGeneradoEl, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.tlpGeneradoEl, 10F);
            this.tags.SetTagFontStyle(this.tlpGeneradoEl, System.Drawing.FontStyle.Regular);
            // 
            // lblGeneradoEl
            // 
            this.lblGeneradoEl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGeneradoEl.AutoSize = true;
            this.lblGeneradoEl.Font = new System.Drawing.Font("Lato", 12F);
            this.lblGeneradoEl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblGeneradoEl.Location = new System.Drawing.Point(4, 4);
            this.lblGeneradoEl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeneradoEl.Name = "lblGeneradoEl";
            this.lblGeneradoEl.Size = new System.Drawing.Size(118, 24);
            this.lblGeneradoEl.TabIndex = 35;
            this.tags.SetTag2(this.lblGeneradoEl, null);
            this.tags.SetTag3(this.lblGeneradoEl, null);
            this.tags.SetTagFontName(this.lblGeneradoEl, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblGeneradoEl, 12F);
            this.tags.SetTagFontStyle(this.lblGeneradoEl, System.Drawing.FontStyle.Regular);
            this.lblGeneradoEl.Text = "Generado el";
            // 
            // lblQuienGenero
            // 
            this.lblQuienGenero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQuienGenero.AutoSize = true;
            this.lblQuienGenero.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuienGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblQuienGenero.Location = new System.Drawing.Point(343, 4);
            this.lblQuienGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuienGenero.Name = "lblQuienGenero";
            this.lblQuienGenero.Size = new System.Drawing.Size(136, 24);
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
            this.lblPor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPor.AutoSize = true;
            this.lblPor.Font = new System.Drawing.Font("Lato", 12F);
            this.lblPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblPor.Location = new System.Drawing.Point(293, 4);
            this.lblPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPor.Name = "lblPor";
            this.lblPor.Size = new System.Drawing.Size(39, 24);
            this.lblPor.TabIndex = 37;
            this.tags.SetTag2(this.lblPor, null);
            this.tags.SetTag3(this.lblPor, null);
            this.tags.SetTagFontName(this.lblPor, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblPor, 12F);
            this.tags.SetTagFontStyle(this.lblPor, System.Drawing.FontStyle.Regular);
            this.lblPor.Text = "por";
            // 
            // lblFechaGenerado
            // 
            this.lblFechaGenerado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaGenerado.AutoSize = true;
            this.lblFechaGenerado.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaGenerado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblFechaGenerado.Location = new System.Drawing.Point(146, 4);
            this.lblFechaGenerado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaGenerado.Name = "lblFechaGenerado";
            this.lblFechaGenerado.Size = new System.Drawing.Size(124, 24);
            this.lblFechaGenerado.TabIndex = 36;
            this.tags.SetTag2(this.lblFechaGenerado, null);
            this.tags.SetTag3(this.lblFechaGenerado, null);
            this.tags.SetTagFontName(this.lblFechaGenerado, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblFechaGenerado, 12F);
            this.tags.SetTagFontStyle(this.lblFechaGenerado, System.Drawing.FontStyle.Bold);
            this.lblFechaGenerado.Text = "24/05/2020";
            // 
            // title_bar_2
            // 
            this.title_bar_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.title_bar_2.Enabled = false;
            this.title_bar_2.Location = new System.Drawing.Point(0, 29);
            this.title_bar_2.Margin = new System.Windows.Forms.Padding(4);
            this.title_bar_2.Name = "title_bar_2";
            this.title_bar_2.Size = new System.Drawing.Size(1387, 10);
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
            this.title_bar.Margin = new System.Windows.Forms.Padding(4);
            this.title_bar.Name = "title_bar";
            this.title_bar.Size = new System.Drawing.Size(1387, 29);
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
            this.boton_cerrar.Location = new System.Drawing.Point(1353, -1);
            this.boton_cerrar.Margin = new System.Windows.Forms.Padding(0);
            this.boton_cerrar.Name = "boton_cerrar";
            this.boton_cerrar.Size = new System.Drawing.Size(32, 30);
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.lblTitulo.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.lblTitulo.Location = new System.Drawing.Point(39, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(258, 45);
            this.lblTitulo.TabIndex = 54;
            this.tags.SetTag2(this.lblTitulo, null);
            this.tags.SetTag3(this.lblTitulo, null);
            this.tags.SetTagFontName(this.lblTitulo, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblTitulo, 21.75F);
            this.tags.SetTagFontStyle(this.lblTitulo, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Text = "Titulo Reporte";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.lblFecha.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblFecha.Location = new System.Drawing.Point(101, 40);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(255, 21);
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
            this.lblSede.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSede.AutoSize = true;
            this.lblSede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.lblSede.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold);
            this.lblSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblSede.Location = new System.Drawing.Point(224, 2);
            this.lblSede.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(132, 36);
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
            this.pnlColorArriba.Location = new System.Drawing.Point(43, 158);
            this.pnlColorArriba.Margin = new System.Windows.Forms.Padding(4);
            this.pnlColorArriba.Name = "pnlColorArriba";
            this.pnlColorArriba.Size = new System.Drawing.Size(1295, 18);
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
            this.pnlColorAbajo.Location = new System.Drawing.Point(43, 686);
            this.pnlColorAbajo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlColorAbajo.Name = "pnlColorAbajo";
            this.pnlColorAbajo.Size = new System.Drawing.Size(1295, 18);
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
            this.btnEstadisticas.Location = new System.Drawing.Point(521, 716);
            this.btnEstadisticas.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(267, 55);
            this.btnEstadisticas.TabIndex = 60;
            this.tags.SetTag2(this.btnEstadisticas, null);
            this.tags.SetTag3(this.btnEstadisticas, null);
            this.tags.SetTagFontName(this.btnEstadisticas, fontsD.Montserrat);
            this.tags.SetTagFontSize(this.btnEstadisticas, 15F);
            this.tags.SetTagFontStyle(this.btnEstadisticas, System.Drawing.FontStyle.Bold);
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Visible = false;
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.btnDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnDetalle.Location = new System.Drawing.Point(796, 716);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(267, 55);
            this.btnDetalle.TabIndex = 61;
            this.tags.SetTag2(this.btnDetalle, null);
            this.tags.SetTag3(this.btnDetalle, null);
            this.tags.SetTagFontName(this.btnDetalle, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnDetalle, 15F);
            this.tags.SetTagFontStyle(this.btnDetalle, System.Drawing.FontStyle.Bold);
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnExportar.Location = new System.Drawing.Point(1071, 716);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(267, 55);
            this.btnExportar.TabIndex = 62;
            this.tags.SetTag2(this.btnExportar, null);
            this.tags.SetTag3(this.btnExportar, null);
            this.tags.SetTagFontName(this.btnExportar, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnExportar, 15F);
            this.tags.SetTagFontStyle(this.btnExportar, System.Drawing.FontStyle.Bold);
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.pnlBackground.Controls.Add(this.btnSalir);
            this.pnlBackground.Controls.Add(this.pnlTitulo);
            this.pnlBackground.Controls.Add(this.tableLayoutPanel1);
            this.pnlBackground.Controls.Add(this.tlpGeneradoEl);
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1387, 805);
            this.pnlBackground.TabIndex = 63;
            this.tags.SetTag2(this.pnlBackground, null);
            this.tags.SetTag3(this.pnlBackground, null);
            this.tags.SetTagFontName(this.pnlBackground, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlBackground, 10F);
            this.tags.SetTagFontStyle(this.pnlBackground, System.Drawing.FontStyle.Regular);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnSalir.Location = new System.Drawing.Point(43, 716);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(267, 55);
            this.btnSalir.TabIndex = 64;
            this.tags.SetTag2(this.btnSalir, null);
            this.tags.SetTag3(this.btnSalir, null);
            this.tags.SetTagFontName(this.btnSalir, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnSalir, 15F);
            this.tags.SetTagFontStyle(this.btnSalir, System.Drawing.FontStyle.Bold);
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.pnlTitulo.Location = new System.Drawing.Point(43, 90);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(807, 2);
            this.pnlTitulo.TabIndex = 59;
            this.tags.SetTag2(this.pnlTitulo, null);
            this.tags.SetTag3(this.pnlTitulo, null);
            this.tags.SetTagFontName(this.pnlTitulo, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlTitulo, 10F);
            this.tags.SetTagFontStyle(this.pnlTitulo, System.Drawing.FontStyle.Regular);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblSede, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTipoReporte, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFecha, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(978, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.57377F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.42623F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 100);
            this.tableLayoutPanel1.TabIndex = 65;
            this.tags.SetTag2(this.tableLayoutPanel1, null);
            this.tags.SetTag3(this.tableLayoutPanel1, null);
            this.tags.SetTagFontName(this.tableLayoutPanel1, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.tableLayoutPanel1, 10F);
            this.tags.SetTagFontStyle(this.tableLayoutPanel1, System.Drawing.FontStyle.Regular);
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTipoReporte.AutoSize = true;
            this.lblTipoReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.lblTipoReporte.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold);
            this.lblTipoReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTipoReporte.Location = new System.Drawing.Point(157, 62);
            this.lblTipoReporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(199, 36);
            this.lblTipoReporte.TabIndex = 64;
            this.tags.SetTag2(this.lblTipoReporte, null);
            this.tags.SetTag3(this.lblTipoReporte, null);
            this.tags.SetTagFontName(this.lblTipoReporte, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.lblTipoReporte, 18F);
            this.tags.SetTagFontStyle(this.lblTipoReporte, System.Drawing.FontStyle.Bold);
            this.lblTipoReporte.Text = "Tipo Siniestro";
            // 
            // boton_minimizar
            // 
            this.boton_minimizar.BackgroundImage = global::LP2MegaAutos.Properties.Resources.boton_minimizar;
            this.boton_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boton_minimizar.FlatAppearance.BorderSize = 0;
            this.boton_minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.boton_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.boton_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_minimizar.Location = new System.Drawing.Point(1321, -1);
            this.boton_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.boton_minimizar.Name = "boton_minimizar";
            this.boton_minimizar.Size = new System.Drawing.Size(32, 30);
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
            // frmResumenReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 800);
            this.ControlBox = false;
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.pnlColorAbajo);
            this.Controls.Add(this.pnlColorArriba);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.title_bar_2);
            this.Controls.Add(this.title_bar);
            this.Controls.Add(this.flpReporteResumen);
            this.Controls.Add(this.pnlBackground);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResumenReporte";
            this.Padding = new System.Windows.Forms.Padding(27, 37, 27, 25);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.tags.SetTag2(this, null);
            this.tags.SetTag3(this, null);
            this.tags.SetTagFontName(this, fontsD.Ninguno);
            this.tags.SetTagFontSize(this, 10F);
            this.tags.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.Text = "Resumen Reporte";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.tlpGeneradoEl.ResumeLayout(false);
            this.tlpGeneradoEl.PerformLayout();
            this.title_bar.ResumeLayout(false);
            this.pnlBackground.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpReporteResumen;
        private TagsExtender tags;
        private System.Windows.Forms.TableLayoutPanel tlpGeneradoEl;
        private System.Windows.Forms.Label lblGeneradoEl;
        private System.Windows.Forms.Label lblFechaGenerado;
        private System.Windows.Forms.Label lblQuienGenero;
        private System.Windows.Forms.Label lblPor;
        private System.Windows.Forms.Panel title_bar_2;
        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.Button boton_cerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.Panel pnlColorArriba;
        private System.Windows.Forms.Panel pnlColorAbajo;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.SaveFileDialog sfdArchivoReporte;
        private System.Windows.Forms.Button boton_minimizar;
    }
}