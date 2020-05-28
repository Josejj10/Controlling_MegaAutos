﻿namespace LP2MegaAutos
{
    partial class frmFiltrarReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltrarReportes));
            this.pnlSede = new LP2MegaAutos.RoundedPanel();
            this.txtSede = new System.Windows.Forms.TextBox();
            this.pnlImgSede = new System.Windows.Forms.Panel();
            this.rpFechaFin = new LP2MegaAutos.RoundedPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnlImgFechaFin = new System.Windows.Forms.Panel();
            this.rpInputBuscar = new LP2MegaAutos.RoundedPanel();
            this.txt_InputBuscar = new System.Windows.Forms.TextBox();
            this.pnlImgBuscar = new System.Windows.Forms.Panel();
            this.rpPorCliente = new LP2MegaAutos.RoundedPanel();
            this.btnPorCliente = new System.Windows.Forms.Button();
            this.rpPorVehiculo = new LP2MegaAutos.RoundedPanel();
            this.btnPorVehiculo = new System.Windows.Forms.Button();
            this.rpPorAreaTrabajo = new LP2MegaAutos.RoundedPanel();
            this.btnPorAreaTrabajo = new System.Windows.Forms.Button();
            this.rpFechaIni = new LP2MegaAutos.RoundedPanel();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.pnlImgFechaIni = new System.Windows.Forms.Panel();
            this.rpBtnGenerarReporte = new LP2MegaAutos.RoundedPanel();
            this.btnFiltrarReporte = new System.Windows.Forms.Button();
            this.rndOtro = new LP2MegaAutos.RoundedPanel();
            this.btnOtro = new System.Windows.Forms.Button();
            this.rndAnual = new LP2MegaAutos.RoundedPanel();
            this.btnAnual = new System.Windows.Forms.Button();
            this.rndMensual = new LP2MegaAutos.RoundedPanel();
            this.btnMensual = new System.Windows.Forms.Button();
            this.rpDiario = new LP2MegaAutos.RoundedPanel();
            this.btnDiario = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rpTopMain = new LP2MegaAutos.RoundedPanel();
            this.chkSede = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.pnlSede.SuspendLayout();
            this.rpFechaFin.SuspendLayout();
            this.rpInputBuscar.SuspendLayout();
            this.rpPorCliente.SuspendLayout();
            this.rpPorVehiculo.SuspendLayout();
            this.rpPorAreaTrabajo.SuspendLayout();
            this.rpFechaIni.SuspendLayout();
            this.rpBtnGenerarReporte.SuspendLayout();
            this.rndOtro.SuspendLayout();
            this.rndAnual.SuspendLayout();
            this.rndMensual.SuspendLayout();
            this.rpDiario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSede
            // 
            this.pnlSede.ArcRadiusBorde = 15;
            this.pnlSede.ArcRadiusPanel = 15;
            this.pnlSede.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.pnlSede.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.pnlSede.Controls.Add(this.txtSede);
            this.pnlSede.Controls.Add(this.pnlImgSede);
            this.pnlSede.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.pnlSede.Location = new System.Drawing.Point(112, 66);
            this.pnlSede.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSede.MenosHeightBorde = 1;
            this.pnlSede.MenosHeightPanel = 1;
            this.pnlSede.MenosWidthBorde = 1;
            this.pnlSede.MenosWidthPanel = 1;
            this.pnlSede.Name = "pnlSede";
            this.pnlSede.PorcLuzColorBorde = 0;
            this.pnlSede.Size = new System.Drawing.Size(183, 45);
            this.pnlSede.TabIndex = 57;
            this.tagsExtender1.SetTag2(this.pnlSede, null);
            this.tagsExtender1.SetTag3(this.pnlSede, null);
            this.tagsExtender1.SetTagFontName(this.pnlSede, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.pnlSede, 10F);
            this.tagsExtender1.SetTagFontStyle(this.pnlSede, System.Drawing.FontStyle.Regular);
            this.pnlSede.XBorde = 0;
            this.pnlSede.XPanel = 0;
            this.pnlSede.YBorde = 0;
            this.pnlSede.YPanel = 0;
            // 
            // txtSede
            // 
            this.txtSede.AutoCompleteCustomSource.AddRange(new string[] {
            "ABC-123",
            "AAA-222",
            "LWYRUP"});
            this.txtSede.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSede.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtSede.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSede.Font = new System.Drawing.Font("Montserrat", 15F);
            this.txtSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.txtSede.Location = new System.Drawing.Point(37, 8);
            this.txtSede.Margin = new System.Windows.Forms.Padding(0);
            this.txtSede.Name = "txtSede";
            this.txtSede.Size = new System.Drawing.Size(143, 25);
            this.txtSede.TabIndex = 38;
            this.tagsExtender1.SetTag2(this.txtSede, null);
            this.tagsExtender1.SetTag3(this.txtSede, null);
            this.tagsExtender1.SetTagFontName(this.txtSede, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.txtSede, 15F);
            this.tagsExtender1.SetTagFontStyle(this.txtSede, System.Drawing.FontStyle.Regular);
            this.txtSede.Text = "Sede";
            // 
            // pnlImgSede
            // 
            this.pnlImgSede.BackColor = System.Drawing.Color.Transparent;
            this.pnlImgSede.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlImgSede.BackgroundImage")));
            this.pnlImgSede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImgSede.Location = new System.Drawing.Point(8, 10);
            this.pnlImgSede.Name = "pnlImgSede";
            this.pnlImgSede.Size = new System.Drawing.Size(25, 25);
            this.pnlImgSede.TabIndex = 37;
            this.tagsExtender1.SetTag2(this.pnlImgSede, null);
            this.tagsExtender1.SetTag3(this.pnlImgSede, null);
            this.tagsExtender1.SetTagFontName(this.pnlImgSede, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.pnlImgSede, 10F);
            this.tagsExtender1.SetTagFontStyle(this.pnlImgSede, System.Drawing.FontStyle.Regular);
            // 
            // rpFechaFin
            // 
            this.rpFechaFin.ArcRadiusBorde = 15;
            this.rpFechaFin.ArcRadiusPanel = 15;
            this.rpFechaFin.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.rpFechaFin.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.rpFechaFin.Controls.Add(this.dateTimePicker1);
            this.rpFechaFin.Controls.Add(this.pnlImgFechaFin);
            this.rpFechaFin.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpFechaFin.Location = new System.Drawing.Point(300, 179);
            this.rpFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.rpFechaFin.MenosHeightBorde = 1;
            this.rpFechaFin.MenosHeightPanel = 1;
            this.rpFechaFin.MenosWidthBorde = 1;
            this.rpFechaFin.MenosWidthPanel = 1;
            this.rpFechaFin.Name = "rpFechaFin";
            this.rpFechaFin.PorcLuzColorBorde = 0;
            this.rpFechaFin.Size = new System.Drawing.Size(182, 62);
            this.rpFechaFin.TabIndex = 56;
            this.tagsExtender1.SetTag2(this.rpFechaFin, null);
            this.tagsExtender1.SetTag3(this.rpFechaFin, null);
            this.tagsExtender1.SetTagFontName(this.rpFechaFin, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpFechaFin, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpFechaFin, System.Drawing.FontStyle.Regular);
            this.rpFechaFin.XBorde = 0;
            this.rpFechaFin.XPanel = 0;
            this.rpFechaFin.YBorde = 0;
            this.rpFechaFin.YPanel = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Montserrat", 13F);
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Montserrat", 13F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(41, 21);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 29);
            this.dateTimePicker1.TabIndex = 38;
            this.tagsExtender1.SetTag2(this.dateTimePicker1, null);
            this.tagsExtender1.SetTag3(this.dateTimePicker1, null);
            this.tagsExtender1.SetTagFontName(this.dateTimePicker1, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.dateTimePicker1, 13F);
            this.tagsExtender1.SetTagFontStyle(this.dateTimePicker1, System.Drawing.FontStyle.Regular);
            this.dateTimePicker1.Value = new System.DateTime(2020, 5, 27, 0, 0, 0, 0);
            // 
            // pnlImgFechaFin
            // 
            this.pnlImgFechaFin.BackColor = System.Drawing.Color.Transparent;
            this.pnlImgFechaFin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlImgFechaFin.BackgroundImage")));
            this.pnlImgFechaFin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImgFechaFin.Location = new System.Drawing.Point(11, 25);
            this.pnlImgFechaFin.Name = "pnlImgFechaFin";
            this.pnlImgFechaFin.Size = new System.Drawing.Size(25, 25);
            this.pnlImgFechaFin.TabIndex = 37;
            this.tagsExtender1.SetTag2(this.pnlImgFechaFin, null);
            this.tagsExtender1.SetTag3(this.pnlImgFechaFin, null);
            this.tagsExtender1.SetTagFontName(this.pnlImgFechaFin, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.pnlImgFechaFin, 10F);
            this.tagsExtender1.SetTagFontStyle(this.pnlImgFechaFin, System.Drawing.FontStyle.Regular);
            // 
            // rpInputBuscar
            // 
            this.rpInputBuscar.ArcRadiusBorde = 15;
            this.rpInputBuscar.ArcRadiusPanel = 15;
            this.rpInputBuscar.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.rpInputBuscar.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.rpInputBuscar.Controls.Add(this.txt_InputBuscar);
            this.rpInputBuscar.Controls.Add(this.pnlImgBuscar);
            this.rpInputBuscar.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpInputBuscar.Location = new System.Drawing.Point(112, 339);
            this.rpInputBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.rpInputBuscar.MenosHeightBorde = 1;
            this.rpInputBuscar.MenosHeightPanel = 1;
            this.rpInputBuscar.MenosWidthBorde = 1;
            this.rpInputBuscar.MenosWidthPanel = 1;
            this.rpInputBuscar.Name = "rpInputBuscar";
            this.rpInputBuscar.PorcLuzColorBorde = 0;
            this.rpInputBuscar.Size = new System.Drawing.Size(371, 45);
            this.rpInputBuscar.TabIndex = 55;
            this.tagsExtender1.SetTag2(this.rpInputBuscar, null);
            this.tagsExtender1.SetTag3(this.rpInputBuscar, null);
            this.tagsExtender1.SetTagFontName(this.rpInputBuscar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpInputBuscar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpInputBuscar, System.Drawing.FontStyle.Regular);
            this.rpInputBuscar.XBorde = 0;
            this.rpInputBuscar.XPanel = 0;
            this.rpInputBuscar.YBorde = 0;
            this.rpInputBuscar.YPanel = 0;
            // 
            // txt_InputBuscar
            // 
            this.txt_InputBuscar.AutoCompleteCustomSource.AddRange(new string[] {
            "ABC-123",
            "AAA-222",
            "LWYRUP"});
            this.txt_InputBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_InputBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_InputBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txt_InputBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_InputBuscar.Font = new System.Drawing.Font("Montserrat", 15F);
            this.txt_InputBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.txt_InputBuscar.Location = new System.Drawing.Point(41, 7);
            this.txt_InputBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.txt_InputBuscar.Name = "txt_InputBuscar";
            this.txt_InputBuscar.Size = new System.Drawing.Size(315, 25);
            this.txt_InputBuscar.TabIndex = 18;
            this.tagsExtender1.SetTag2(this.txt_InputBuscar, null);
            this.tagsExtender1.SetTag3(this.txt_InputBuscar, null);
            this.tagsExtender1.SetTagFontName(this.txt_InputBuscar, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.txt_InputBuscar, 15F);
            this.tagsExtender1.SetTagFontStyle(this.txt_InputBuscar, System.Drawing.FontStyle.Regular);
            this.txt_InputBuscar.Text = "Placa";
            // 
            // pnlImgBuscar
            // 
            this.pnlImgBuscar.BackColor = System.Drawing.Color.Transparent;
            this.pnlImgBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlImgBuscar.BackgroundImage")));
            this.pnlImgBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImgBuscar.Location = new System.Drawing.Point(8, 10);
            this.pnlImgBuscar.Name = "pnlImgBuscar";
            this.pnlImgBuscar.Size = new System.Drawing.Size(25, 25);
            this.pnlImgBuscar.TabIndex = 37;
            this.tagsExtender1.SetTag2(this.pnlImgBuscar, null);
            this.tagsExtender1.SetTag3(this.pnlImgBuscar, null);
            this.tagsExtender1.SetTagFontName(this.pnlImgBuscar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.pnlImgBuscar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.pnlImgBuscar, System.Drawing.FontStyle.Regular);
            // 
            // rpPorCliente
            // 
            this.rpPorCliente.ArcRadiusBorde = 8;
            this.rpPorCliente.ArcRadiusPanel = 8;
            this.rpPorCliente.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rpPorCliente.ColorPanel = System.Drawing.Color.Transparent;
            this.rpPorCliente.Controls.Add(this.btnPorCliente);
            this.rpPorCliente.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpPorCliente.Location = new System.Drawing.Point(375, 260);
            this.rpPorCliente.MenosHeightBorde = 1;
            this.rpPorCliente.MenosHeightPanel = 1;
            this.rpPorCliente.MenosWidthBorde = 1;
            this.rpPorCliente.MenosWidthPanel = 1;
            this.rpPorCliente.Name = "rpPorCliente";
            this.rpPorCliente.PorcLuzColorBorde = 0;
            this.rpPorCliente.Size = new System.Drawing.Size(107, 59);
            this.rpPorCliente.TabIndex = 54;
            this.tagsExtender1.SetTag2(this.rpPorCliente, null);
            this.tagsExtender1.SetTag3(this.rpPorCliente, null);
            this.tagsExtender1.SetTagFontName(this.rpPorCliente, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpPorCliente, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpPorCliente, System.Drawing.FontStyle.Regular);
            this.rpPorCliente.XBorde = 0;
            this.rpPorCliente.XPanel = 0;
            this.rpPorCliente.YBorde = 0;
            this.rpPorCliente.YPanel = 0;
            // 
            // btnPorCliente
            // 
            this.btnPorCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnPorCliente.FlatAppearance.BorderSize = 0;
            this.btnPorCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPorCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorCliente.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnPorCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnPorCliente.Location = new System.Drawing.Point(3, 3);
            this.btnPorCliente.Name = "btnPorCliente";
            this.btnPorCliente.Size = new System.Drawing.Size(101, 54);
            this.btnPorCliente.TabIndex = 5;
            this.tagsExtender1.SetTag2(this.btnPorCliente, null);
            this.tagsExtender1.SetTag3(this.btnPorCliente, null);
            this.tagsExtender1.SetTagFontName(this.btnPorCliente, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btnPorCliente, 12F);
            this.tagsExtender1.SetTagFontStyle(this.btnPorCliente, System.Drawing.FontStyle.Bold);
            this.btnPorCliente.Text = "Cliente";
            this.btnPorCliente.UseVisualStyleBackColor = false;
            this.btnPorCliente.Click += new System.EventHandler(this.btnPorCliente_Click);
            // 
            // rpPorVehiculo
            // 
            this.rpPorVehiculo.ArcRadiusBorde = 8;
            this.rpPorVehiculo.ArcRadiusPanel = 8;
            this.rpPorVehiculo.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rpPorVehiculo.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rpPorVehiculo.Controls.Add(this.btnPorVehiculo);
            this.rpPorVehiculo.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpPorVehiculo.Location = new System.Drawing.Point(112, 260);
            this.rpPorVehiculo.MenosHeightBorde = 1;
            this.rpPorVehiculo.MenosHeightPanel = 1;
            this.rpPorVehiculo.MenosWidthBorde = 1;
            this.rpPorVehiculo.MenosWidthPanel = 1;
            this.rpPorVehiculo.Name = "rpPorVehiculo";
            this.rpPorVehiculo.PorcLuzColorBorde = 0;
            this.rpPorVehiculo.Size = new System.Drawing.Size(107, 59);
            this.rpPorVehiculo.TabIndex = 53;
            this.tagsExtender1.SetTag2(this.rpPorVehiculo, null);
            this.tagsExtender1.SetTag3(this.rpPorVehiculo, null);
            this.tagsExtender1.SetTagFontName(this.rpPorVehiculo, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpPorVehiculo, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpPorVehiculo, System.Drawing.FontStyle.Regular);
            this.rpPorVehiculo.XBorde = 0;
            this.rpPorVehiculo.XPanel = 0;
            this.rpPorVehiculo.YBorde = 0;
            this.rpPorVehiculo.YPanel = 0;
            // 
            // btnPorVehiculo
            // 
            this.btnPorVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.btnPorVehiculo.FlatAppearance.BorderSize = 0;
            this.btnPorVehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPorVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorVehiculo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnPorVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnPorVehiculo.Location = new System.Drawing.Point(3, 3);
            this.btnPorVehiculo.Name = "btnPorVehiculo";
            this.btnPorVehiculo.Size = new System.Drawing.Size(101, 54);
            this.btnPorVehiculo.TabIndex = 5;
            this.tagsExtender1.SetTag2(this.btnPorVehiculo, null);
            this.tagsExtender1.SetTag3(this.btnPorVehiculo, null);
            this.tagsExtender1.SetTagFontName(this.btnPorVehiculo, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btnPorVehiculo, 12F);
            this.tagsExtender1.SetTagFontStyle(this.btnPorVehiculo, System.Drawing.FontStyle.Bold);
            this.btnPorVehiculo.Text = "Vehículo";
            this.btnPorVehiculo.UseVisualStyleBackColor = false;
            this.btnPorVehiculo.Click += new System.EventHandler(this.btnPorVehiculo_Click);
            // 
            // rpPorAreaTrabajo
            // 
            this.rpPorAreaTrabajo.ArcRadiusBorde = 8;
            this.rpPorAreaTrabajo.ArcRadiusPanel = 8;
            this.rpPorAreaTrabajo.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rpPorAreaTrabajo.ColorPanel = System.Drawing.Color.Transparent;
            this.rpPorAreaTrabajo.Controls.Add(this.btnPorAreaTrabajo);
            this.rpPorAreaTrabajo.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpPorAreaTrabajo.Location = new System.Drawing.Point(225, 260);
            this.rpPorAreaTrabajo.MenosHeightBorde = 1;
            this.rpPorAreaTrabajo.MenosHeightPanel = 1;
            this.rpPorAreaTrabajo.MenosWidthBorde = 1;
            this.rpPorAreaTrabajo.MenosWidthPanel = 1;
            this.rpPorAreaTrabajo.Name = "rpPorAreaTrabajo";
            this.rpPorAreaTrabajo.PorcLuzColorBorde = 0;
            this.rpPorAreaTrabajo.Size = new System.Drawing.Size(144, 59);
            this.rpPorAreaTrabajo.TabIndex = 52;
            this.tagsExtender1.SetTag2(this.rpPorAreaTrabajo, null);
            this.tagsExtender1.SetTag3(this.rpPorAreaTrabajo, null);
            this.tagsExtender1.SetTagFontName(this.rpPorAreaTrabajo, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpPorAreaTrabajo, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpPorAreaTrabajo, System.Drawing.FontStyle.Regular);
            this.rpPorAreaTrabajo.XBorde = 0;
            this.rpPorAreaTrabajo.XPanel = 0;
            this.rpPorAreaTrabajo.YBorde = 0;
            this.rpPorAreaTrabajo.YPanel = 0;
            // 
            // btnPorAreaTrabajo
            // 
            this.btnPorAreaTrabajo.BackColor = System.Drawing.Color.Transparent;
            this.btnPorAreaTrabajo.FlatAppearance.BorderSize = 0;
            this.btnPorAreaTrabajo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPorAreaTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorAreaTrabajo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnPorAreaTrabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnPorAreaTrabajo.Location = new System.Drawing.Point(3, 3);
            this.btnPorAreaTrabajo.Name = "btnPorAreaTrabajo";
            this.btnPorAreaTrabajo.Size = new System.Drawing.Size(138, 54);
            this.btnPorAreaTrabajo.TabIndex = 5;
            this.tagsExtender1.SetTag2(this.btnPorAreaTrabajo, null);
            this.tagsExtender1.SetTag3(this.btnPorAreaTrabajo, null);
            this.tagsExtender1.SetTagFontName(this.btnPorAreaTrabajo, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btnPorAreaTrabajo, 12F);
            this.tagsExtender1.SetTagFontStyle(this.btnPorAreaTrabajo, System.Drawing.FontStyle.Bold);
            this.btnPorAreaTrabajo.Text = "Área de\r\nTrabajo";
            this.btnPorAreaTrabajo.UseVisualStyleBackColor = false;
            this.btnPorAreaTrabajo.Click += new System.EventHandler(this.btnPorAreaTrabajo_Click);
            // 
            // rpFechaIni
            // 
            this.rpFechaIni.ArcRadiusBorde = 15;
            this.rpFechaIni.ArcRadiusPanel = 15;
            this.rpFechaIni.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.rpFechaIni.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.rpFechaIni.Controls.Add(this.dtpInicio);
            this.rpFechaIni.Controls.Add(this.pnlImgFechaIni);
            this.rpFechaIni.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpFechaIni.Location = new System.Drawing.Point(112, 179);
            this.rpFechaIni.Margin = new System.Windows.Forms.Padding(2);
            this.rpFechaIni.MenosHeightBorde = 1;
            this.rpFechaIni.MenosHeightPanel = 1;
            this.rpFechaIni.MenosWidthBorde = 1;
            this.rpFechaIni.MenosWidthPanel = 1;
            this.rpFechaIni.Name = "rpFechaIni";
            this.rpFechaIni.PorcLuzColorBorde = 0;
            this.rpFechaIni.Size = new System.Drawing.Size(182, 62);
            this.rpFechaIni.TabIndex = 51;
            this.tagsExtender1.SetTag2(this.rpFechaIni, null);
            this.tagsExtender1.SetTag3(this.rpFechaIni, null);
            this.tagsExtender1.SetTagFontName(this.rpFechaIni, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpFechaIni, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpFechaIni, System.Drawing.FontStyle.Regular);
            this.rpFechaIni.XBorde = 0;
            this.rpFechaIni.XPanel = 0;
            this.rpFechaIni.YBorde = 0;
            this.rpFechaIni.YPanel = 0;
            // 
            // dtpInicio
            // 
            this.dtpInicio.CalendarFont = new System.Drawing.Font("Montserrat", 13F);
            this.dtpInicio.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpInicio.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.dtpInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpInicio.Font = new System.Drawing.Font("Montserrat", 13F);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(41, 21);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(128, 29);
            this.dtpInicio.TabIndex = 38;
            this.tagsExtender1.SetTag2(this.dtpInicio, null);
            this.tagsExtender1.SetTag3(this.dtpInicio, null);
            this.tagsExtender1.SetTagFontName(this.dtpInicio, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.dtpInicio, 13F);
            this.tagsExtender1.SetTagFontStyle(this.dtpInicio, System.Drawing.FontStyle.Regular);
            this.dtpInicio.Value = new System.DateTime(2020, 5, 27, 0, 0, 0, 0);
            // 
            // pnlImgFechaIni
            // 
            this.pnlImgFechaIni.BackColor = System.Drawing.Color.Transparent;
            this.pnlImgFechaIni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlImgFechaIni.BackgroundImage")));
            this.pnlImgFechaIni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImgFechaIni.Location = new System.Drawing.Point(11, 25);
            this.pnlImgFechaIni.Name = "pnlImgFechaIni";
            this.pnlImgFechaIni.Size = new System.Drawing.Size(25, 25);
            this.pnlImgFechaIni.TabIndex = 37;
            this.tagsExtender1.SetTag2(this.pnlImgFechaIni, null);
            this.tagsExtender1.SetTag3(this.pnlImgFechaIni, null);
            this.tagsExtender1.SetTagFontName(this.pnlImgFechaIni, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.pnlImgFechaIni, 10F);
            this.tagsExtender1.SetTagFontStyle(this.pnlImgFechaIni, System.Drawing.FontStyle.Regular);
            // 
            // rpBtnGenerarReporte
            // 
            this.rpBtnGenerarReporte.ArcRadiusBorde = 15;
            this.rpBtnGenerarReporte.ArcRadiusPanel = 15;
            this.rpBtnGenerarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpBtnGenerarReporte.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpBtnGenerarReporte.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            this.rpBtnGenerarReporte.Controls.Add(this.btnFiltrarReporte);
            this.rpBtnGenerarReporte.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Bottom;
            this.rpBtnGenerarReporte.Location = new System.Drawing.Point(-8, 391);
            this.rpBtnGenerarReporte.MenosHeightBorde = 1;
            this.rpBtnGenerarReporte.MenosHeightPanel = 1;
            this.rpBtnGenerarReporte.MenosWidthBorde = 1;
            this.rpBtnGenerarReporte.MenosWidthPanel = 1;
            this.rpBtnGenerarReporte.Name = "rpBtnGenerarReporte";
            this.rpBtnGenerarReporte.PorcLuzColorBorde = 0;
            this.rpBtnGenerarReporte.Size = new System.Drawing.Size(611, 67);
            this.rpBtnGenerarReporte.TabIndex = 45;
            this.tagsExtender1.SetTag2(this.rpBtnGenerarReporte, null);
            this.tagsExtender1.SetTag3(this.rpBtnGenerarReporte, null);
            this.tagsExtender1.SetTagFontName(this.rpBtnGenerarReporte, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpBtnGenerarReporte, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpBtnGenerarReporte, System.Drawing.FontStyle.Regular);
            this.rpBtnGenerarReporte.XBorde = 0;
            this.rpBtnGenerarReporte.XPanel = 0;
            this.rpBtnGenerarReporte.YBorde = 0;
            this.rpBtnGenerarReporte.YPanel = 0;
            // 
            // btnFiltrarReporte
            // 
            this.btnFiltrarReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltrarReporte.FlatAppearance.BorderSize = 0;
            this.btnFiltrarReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFiltrarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarReporte.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnFiltrarReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnFiltrarReporte.Location = new System.Drawing.Point(16, -1);
            this.btnFiltrarReporte.Name = "btnFiltrarReporte";
            this.btnFiltrarReporte.Size = new System.Drawing.Size(578, 43);
            this.btnFiltrarReporte.TabIndex = 32;
            this.tagsExtender1.SetTag2(this.btnFiltrarReporte, null);
            this.tagsExtender1.SetTag3(this.btnFiltrarReporte, null);
            this.tagsExtender1.SetTagFontName(this.btnFiltrarReporte, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.btnFiltrarReporte, 22F);
            this.tagsExtender1.SetTagFontStyle(this.btnFiltrarReporte, System.Drawing.FontStyle.Bold);
            this.btnFiltrarReporte.Text = "Filtrar";
            this.btnFiltrarReporte.UseVisualStyleBackColor = false;
            // 
            // rndOtro
            // 
            this.rndOtro.ArcRadiusBorde = 8;
            this.rndOtro.ArcRadiusPanel = 8;
            this.rndOtro.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rndOtro.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rndOtro.Controls.Add(this.btnOtro);
            this.rndOtro.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndOtro.Location = new System.Drawing.Point(400, 128);
            this.rndOtro.MenosHeightBorde = 1;
            this.rndOtro.MenosHeightPanel = 1;
            this.rndOtro.MenosWidthBorde = 1;
            this.rndOtro.MenosWidthPanel = 1;
            this.rndOtro.Name = "rndOtro";
            this.rndOtro.PorcLuzColorBorde = 0;
            this.rndOtro.Size = new System.Drawing.Size(82, 35);
            this.rndOtro.TabIndex = 50;
            this.tagsExtender1.SetTag2(this.rndOtro, null);
            this.tagsExtender1.SetTag3(this.rndOtro, null);
            this.tagsExtender1.SetTagFontName(this.rndOtro, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rndOtro, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rndOtro, System.Drawing.FontStyle.Regular);
            this.rndOtro.XBorde = 0;
            this.rndOtro.XPanel = 0;
            this.rndOtro.YBorde = 0;
            this.rndOtro.YPanel = 0;
            // 
            // btnOtro
            // 
            this.btnOtro.BackColor = System.Drawing.Color.White;
            this.btnOtro.FlatAppearance.BorderSize = 0;
            this.btnOtro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtro.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnOtro.Location = new System.Drawing.Point(3, 3);
            this.btnOtro.Name = "btnOtro";
            this.btnOtro.Size = new System.Drawing.Size(76, 30);
            this.btnOtro.TabIndex = 8;
            this.tagsExtender1.SetTag2(this.btnOtro, null);
            this.tagsExtender1.SetTag3(this.btnOtro, null);
            this.tagsExtender1.SetTagFontName(this.btnOtro, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btnOtro, 12F);
            this.tagsExtender1.SetTagFontStyle(this.btnOtro, System.Drawing.FontStyle.Bold);
            this.btnOtro.Text = "Otro";
            this.btnOtro.UseVisualStyleBackColor = false;
            this.btnOtro.Click += new System.EventHandler(this.btnOtro_Click);
            // 
            // rndAnual
            // 
            this.rndAnual.ArcRadiusBorde = 8;
            this.rndAnual.ArcRadiusPanel = 8;
            this.rndAnual.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rndAnual.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rndAnual.Controls.Add(this.btnAnual);
            this.rndAnual.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndAnual.Location = new System.Drawing.Point(301, 128);
            this.rndAnual.MenosHeightBorde = 1;
            this.rndAnual.MenosHeightPanel = 1;
            this.rndAnual.MenosWidthBorde = 1;
            this.rndAnual.MenosWidthPanel = 1;
            this.rndAnual.Name = "rndAnual";
            this.rndAnual.PorcLuzColorBorde = 0;
            this.rndAnual.Size = new System.Drawing.Size(94, 35);
            this.rndAnual.TabIndex = 49;
            this.tagsExtender1.SetTag2(this.rndAnual, null);
            this.tagsExtender1.SetTag3(this.rndAnual, null);
            this.tagsExtender1.SetTagFontName(this.rndAnual, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rndAnual, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rndAnual, System.Drawing.FontStyle.Regular);
            this.rndAnual.XBorde = 0;
            this.rndAnual.XPanel = 0;
            this.rndAnual.YBorde = 0;
            this.rndAnual.YPanel = 0;
            // 
            // btnAnual
            // 
            this.btnAnual.BackColor = System.Drawing.Color.White;
            this.btnAnual.FlatAppearance.BorderSize = 0;
            this.btnAnual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAnual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnual.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAnual.Location = new System.Drawing.Point(3, 3);
            this.btnAnual.Name = "btnAnual";
            this.btnAnual.Size = new System.Drawing.Size(88, 30);
            this.btnAnual.TabIndex = 7;
            this.tagsExtender1.SetTag2(this.btnAnual, null);
            this.tagsExtender1.SetTag3(this.btnAnual, null);
            this.tagsExtender1.SetTagFontName(this.btnAnual, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btnAnual, 12F);
            this.tagsExtender1.SetTagFontStyle(this.btnAnual, System.Drawing.FontStyle.Bold);
            this.btnAnual.Text = "Anual";
            this.btnAnual.UseVisualStyleBackColor = false;
            this.btnAnual.Click += new System.EventHandler(this.btnAnual_Click);
            // 
            // rndMensual
            // 
            this.rndMensual.ArcRadiusBorde = 8;
            this.rndMensual.ArcRadiusPanel = 8;
            this.rndMensual.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rndMensual.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rndMensual.Controls.Add(this.btnMensual);
            this.rndMensual.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndMensual.Location = new System.Drawing.Point(201, 128);
            this.rndMensual.MenosHeightBorde = 1;
            this.rndMensual.MenosHeightPanel = 1;
            this.rndMensual.MenosWidthBorde = 1;
            this.rndMensual.MenosWidthPanel = 1;
            this.rndMensual.Name = "rndMensual";
            this.rndMensual.PorcLuzColorBorde = 0;
            this.rndMensual.Size = new System.Drawing.Size(94, 35);
            this.rndMensual.TabIndex = 48;
            this.tagsExtender1.SetTag2(this.rndMensual, null);
            this.tagsExtender1.SetTag3(this.rndMensual, null);
            this.tagsExtender1.SetTagFontName(this.rndMensual, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rndMensual, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rndMensual, System.Drawing.FontStyle.Regular);
            this.rndMensual.XBorde = 0;
            this.rndMensual.XPanel = 0;
            this.rndMensual.YBorde = 0;
            this.rndMensual.YPanel = 0;
            // 
            // btnMensual
            // 
            this.btnMensual.BackColor = System.Drawing.Color.White;
            this.btnMensual.FlatAppearance.BorderSize = 0;
            this.btnMensual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMensual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMensual.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnMensual.Location = new System.Drawing.Point(3, 3);
            this.btnMensual.Name = "btnMensual";
            this.btnMensual.Size = new System.Drawing.Size(88, 30);
            this.btnMensual.TabIndex = 6;
            this.tagsExtender1.SetTag2(this.btnMensual, null);
            this.tagsExtender1.SetTag3(this.btnMensual, null);
            this.tagsExtender1.SetTagFontName(this.btnMensual, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btnMensual, 12F);
            this.tagsExtender1.SetTagFontStyle(this.btnMensual, System.Drawing.FontStyle.Bold);
            this.btnMensual.Text = "Mensual";
            this.btnMensual.UseVisualStyleBackColor = false;
            this.btnMensual.Click += new System.EventHandler(this.btnMensual_Click);
            // 
            // rpDiario
            // 
            this.rpDiario.ArcRadiusBorde = 8;
            this.rpDiario.ArcRadiusPanel = 8;
            this.rpDiario.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rpDiario.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rpDiario.Controls.Add(this.btnDiario);
            this.rpDiario.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpDiario.Location = new System.Drawing.Point(112, 128);
            this.rpDiario.MenosHeightBorde = 1;
            this.rpDiario.MenosHeightPanel = 1;
            this.rpDiario.MenosWidthBorde = 1;
            this.rpDiario.MenosWidthPanel = 1;
            this.rpDiario.Name = "rpDiario";
            this.rpDiario.PorcLuzColorBorde = 0;
            this.rpDiario.Size = new System.Drawing.Size(82, 35);
            this.rpDiario.TabIndex = 47;
            this.tagsExtender1.SetTag2(this.rpDiario, null);
            this.tagsExtender1.SetTag3(this.rpDiario, null);
            this.tagsExtender1.SetTagFontName(this.rpDiario, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpDiario, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpDiario, System.Drawing.FontStyle.Regular);
            this.rpDiario.XBorde = 0;
            this.rpDiario.XPanel = 0;
            this.rpDiario.YBorde = 0;
            this.rpDiario.YPanel = 0;
            // 
            // btnDiario
            // 
            this.btnDiario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.btnDiario.FlatAppearance.BorderSize = 0;
            this.btnDiario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiario.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDiario.Location = new System.Drawing.Point(3, 3);
            this.btnDiario.Name = "btnDiario";
            this.btnDiario.Size = new System.Drawing.Size(76, 30);
            this.btnDiario.TabIndex = 5;
            this.tagsExtender1.SetTag2(this.btnDiario, null);
            this.tagsExtender1.SetTag3(this.btnDiario, null);
            this.tagsExtender1.SetTagFontName(this.btnDiario, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btnDiario, 12F);
            this.tagsExtender1.SetTagFontStyle(this.btnDiario, System.Drawing.FontStyle.Bold);
            this.btnDiario.Text = "Diario";
            this.btnDiario.UseVisualStyleBackColor = false;
            this.btnDiario.Click += new System.EventHandler(this.btnDiario_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.lblTitulo.Location = new System.Drawing.Point(17, 21);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(202, 35);
            this.lblTitulo.TabIndex = 46;
            this.tagsExtender1.SetTag2(this.lblTitulo, null);
            this.tagsExtender1.SetTag3(this.lblTitulo, null);
            this.tagsExtender1.SetTagFontName(this.lblTitulo, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblTitulo, 22F);
            this.tagsExtender1.SetTagFontStyle(this.lblTitulo, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Text = "Filtrar Reporte";
            // 
            // rpTopMain
            // 
            this.rpTopMain.ArcRadiusBorde = 15;
            this.rpTopMain.ArcRadiusPanel = 15;
            this.rpTopMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpTopMain.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpTopMain.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(64)))), ((int)(((byte)(32)))));
            this.rpTopMain.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Top;
            this.rpTopMain.Location = new System.Drawing.Point(-8, -20);
            this.rpTopMain.MenosHeightBorde = 1;
            this.rpTopMain.MenosHeightPanel = 1;
            this.rpTopMain.MenosWidthBorde = 1;
            this.rpTopMain.MenosWidthPanel = 1;
            this.rpTopMain.Name = "rpTopMain";
            this.rpTopMain.PorcLuzColorBorde = 0;
            this.rpTopMain.Size = new System.Drawing.Size(611, 40);
            this.rpTopMain.TabIndex = 44;
            this.tagsExtender1.SetTag2(this.rpTopMain, null);
            this.tagsExtender1.SetTag3(this.rpTopMain, null);
            this.tagsExtender1.SetTagFontName(this.rpTopMain, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpTopMain, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpTopMain, System.Drawing.FontStyle.Regular);
            this.rpTopMain.XBorde = 0;
            this.rpTopMain.XPanel = 0;
            this.rpTopMain.YBorde = 0;
            this.rpTopMain.YPanel = 0;
            // 
            // chkSede
            // 
            this.chkSede.AutoSize = true;
            this.chkSede.Location = new System.Drawing.Point(69, 82);
            this.chkSede.Name = "chkSede";
            this.chkSede.Size = new System.Drawing.Size(15, 14);
            this.chkSede.TabIndex = 58;
            this.tagsExtender1.SetTag2(this.chkSede, null);
            this.tagsExtender1.SetTag3(this.chkSede, null);
            this.tagsExtender1.SetTagFontName(this.chkSede, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.chkSede, 10F);
            this.tagsExtender1.SetTagFontStyle(this.chkSede, System.Drawing.FontStyle.Regular);
            this.chkSede.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(69, 138);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 59;
            this.tagsExtender1.SetTag2(this.checkBox1, null);
            this.tagsExtender1.SetTag3(this.checkBox1, null);
            this.tagsExtender1.SetTagFontName(this.checkBox1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.checkBox1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.checkBox1, System.Drawing.FontStyle.Regular);
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(69, 283);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 60;
            this.tagsExtender1.SetTag2(this.checkBox2, null);
            this.tagsExtender1.SetTag3(this.checkBox2, null);
            this.tagsExtender1.SetTagFontName(this.checkBox2, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.checkBox2, 10F);
            this.tagsExtender1.SetTagFontStyle(this.checkBox2, System.Drawing.FontStyle.Regular);
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(69, 353);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 61;
            this.tagsExtender1.SetTag2(this.checkBox3, null);
            this.tagsExtender1.SetTag3(this.checkBox3, null);
            this.tagsExtender1.SetTagFontName(this.checkBox3, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.checkBox3, 10F);
            this.tagsExtender1.SetTagFontStyle(this.checkBox3, System.Drawing.FontStyle.Regular);
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // frmFiltrarReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 431);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chkSede);
            this.Controls.Add(this.pnlSede);
            this.Controls.Add(this.rpFechaFin);
            this.Controls.Add(this.rpInputBuscar);
            this.Controls.Add(this.rpPorCliente);
            this.Controls.Add(this.rpPorVehiculo);
            this.Controls.Add(this.rpPorAreaTrabajo);
            this.Controls.Add(this.rpFechaIni);
            this.Controls.Add(this.rpBtnGenerarReporte);
            this.Controls.Add(this.rndOtro);
            this.Controls.Add(this.rndAnual);
            this.Controls.Add(this.rndMensual);
            this.Controls.Add(this.rpDiario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rpTopMain);
            this.DisplayHeader = false;
            this.Movable = false;
            this.Name = "frmFiltrarReportes";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.Text = "frmFiltrarReportes";
            this.pnlSede.ResumeLayout(false);
            this.pnlSede.PerformLayout();
            this.rpFechaFin.ResumeLayout(false);
            this.rpInputBuscar.ResumeLayout(false);
            this.rpInputBuscar.PerformLayout();
            this.rpPorCliente.ResumeLayout(false);
            this.rpPorVehiculo.ResumeLayout(false);
            this.rpPorAreaTrabajo.ResumeLayout(false);
            this.rpFechaIni.ResumeLayout(false);
            this.rpBtnGenerarReporte.ResumeLayout(false);
            this.rndOtro.ResumeLayout(false);
            this.rndAnual.ResumeLayout(false);
            this.rndMensual.ResumeLayout(false);
            this.rpDiario.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedPanel pnlSede;
        private System.Windows.Forms.TextBox txtSede;
        private System.Windows.Forms.Panel pnlImgSede;
        private RoundedPanel rpFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel pnlImgFechaFin;
        private RoundedPanel rpInputBuscar;
        private System.Windows.Forms.TextBox txt_InputBuscar;
        private System.Windows.Forms.Panel pnlImgBuscar;
        private RoundedPanel rpPorCliente;
        private System.Windows.Forms.Button btnPorCliente;
        private RoundedPanel rpPorVehiculo;
        private System.Windows.Forms.Button btnPorVehiculo;
        private RoundedPanel rpPorAreaTrabajo;
        private System.Windows.Forms.Button btnPorAreaTrabajo;
        private RoundedPanel rpFechaIni;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Panel pnlImgFechaIni;
        private RoundedPanel rpBtnGenerarReporte;
        private System.Windows.Forms.Button btnFiltrarReporte;
        private RoundedPanel rndOtro;
        private System.Windows.Forms.Button btnOtro;
        private RoundedPanel rndAnual;
        private System.Windows.Forms.Button btnAnual;
        private RoundedPanel rndMensual;
        private System.Windows.Forms.Button btnMensual;
        private RoundedPanel rpDiario;
        private System.Windows.Forms.Button btnDiario;
        private System.Windows.Forms.Label lblTitulo;
        private RoundedPanel rpTopMain;
        private System.Windows.Forms.CheckBox chkSede;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private TagsExtender tagsExtender1;
    }
}