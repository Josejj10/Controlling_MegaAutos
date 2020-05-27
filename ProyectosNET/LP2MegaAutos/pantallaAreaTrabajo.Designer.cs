namespace LP2MegaAutos
{
    partial class pantallaAreaTrabajo
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
            this.rpn_ListaServicios = new LP2MegaAutos.RoundedPanel();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_ListaAreasTrabajo = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.rndReciente = new LP2MegaAutos.RoundedPanel();
            this.btnReciente = new System.Windows.Forms.Button();
            this.rndAntiguo = new LP2MegaAutos.RoundedPanel();
            this.btnAntiguo = new System.Windows.Forms.Button();
            this.rndZA = new LP2MegaAutos.RoundedPanel();
            this.btnZA = new System.Windows.Forms.Button();
            this.rndAZ = new LP2MegaAutos.RoundedPanel();
            this.btnAZ = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.il_Servicios2 = new LP2MegaAutos.itemLista();
            this.il_Servicios3 = new LP2MegaAutos.itemLista();
            this.il_Servicios1 = new LP2MegaAutos.itemLista();
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.rpn_ListaServicios.SuspendLayout();
            this.rndReciente.SuspendLayout();
            this.rndAntiguo.SuspendLayout();
            this.rndZA.SuspendLayout();
            this.rndAZ.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpn_ListaServicios
            // 
            this.rpn_ListaServicios.ArcRadiusBorde = 15;
            this.rpn_ListaServicios.ArcRadiusPanel = 15;
            this.rpn_ListaServicios.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpn_ListaServicios.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(226)))));
            this.rpn_ListaServicios.Controls.Add(this.btn_Agregar);
            this.rpn_ListaServicios.Controls.Add(this.lbl_ListaAreasTrabajo);
            this.rpn_ListaServicios.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.None;
            this.rpn_ListaServicios.Location = new System.Drawing.Point(36, 114);
            this.rpn_ListaServicios.MenosHeightBorde = 1;
            this.rpn_ListaServicios.MenosHeightPanel = 1;
            this.rpn_ListaServicios.MenosWidthBorde = 1;
            this.rpn_ListaServicios.MenosWidthPanel = 1;
            this.rpn_ListaServicios.Name = "rpn_ListaServicios";
            this.rpn_ListaServicios.PorcLuzColorBorde = 0;
            this.rpn_ListaServicios.Size = new System.Drawing.Size(539, 27);
            this.rpn_ListaServicios.TabIndex = 24;
            this.tagsExtender1.SetTag2(this.rpn_ListaServicios, null);
            this.tagsExtender1.SetTag3(this.rpn_ListaServicios, null);
            this.tagsExtender1.SetTagFontName(this.rpn_ListaServicios, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpn_ListaServicios, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpn_ListaServicios, System.Drawing.FontStyle.Regular);
            this.rpn_ListaServicios.XBorde = 0;
            this.rpn_ListaServicios.XPanel = 0;
            this.rpn_ListaServicios.YBorde = 0;
            this.rpn_ListaServicios.YPanel = 0;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(33)))));
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.White;
            this.btn_Agregar.Location = new System.Drawing.Point(441, 2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(78, 23);
            this.btn_Agregar.TabIndex = 6;
            this.tagsExtender1.SetTag2(this.btn_Agregar, null);
            this.tagsExtender1.SetTag3(this.btn_Agregar, null);
            this.tagsExtender1.SetTagFontName(this.btn_Agregar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btn_Agregar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btn_Agregar, System.Drawing.FontStyle.Regular);
            this.btn_Agregar.Text = "+ Agregar";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            // 
            // lbl_ListaAreasTrabajo
            // 
            this.lbl_ListaAreasTrabajo.AutoSize = true;
            this.lbl_ListaAreasTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(226)))));
            this.lbl_ListaAreasTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ListaAreasTrabajo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListaAreasTrabajo.ForeColor = System.Drawing.Color.White;
            this.lbl_ListaAreasTrabajo.Location = new System.Drawing.Point(190, 3);
            this.lbl_ListaAreasTrabajo.Name = "lbl_ListaAreasTrabajo";
            this.lbl_ListaAreasTrabajo.Size = new System.Drawing.Size(158, 19);
            this.lbl_ListaAreasTrabajo.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.lbl_ListaAreasTrabajo, null);
            this.tagsExtender1.SetTag3(this.lbl_ListaAreasTrabajo, null);
            this.tagsExtender1.SetTagFontName(this.lbl_ListaAreasTrabajo, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.lbl_ListaAreasTrabajo, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lbl_ListaAreasTrabajo, System.Drawing.FontStyle.Regular);
            this.lbl_ListaAreasTrabajo.Text = "Areas de Trabajo";
            this.lbl_ListaAreasTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Buscar.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.txt_Buscar.Location = new System.Drawing.Point(36, 29);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(538, 18);
            this.txt_Buscar.TabIndex = 26;
            this.tagsExtender1.SetTag2(this.txt_Buscar, null);
            this.tagsExtender1.SetTag3(this.txt_Buscar, null);
            this.tagsExtender1.SetTagFontName(this.txt_Buscar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.txt_Buscar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.txt_Buscar, System.Drawing.FontStyle.Regular);
            this.txt_Buscar.Text = "Buscar";
            this.txt_Buscar.Enter += new System.EventHandler(this.txt_Buscar_Enter);
            // 
            // rndReciente
            // 
            this.rndReciente.ArcRadiusBorde = 8;
            this.rndReciente.ArcRadiusPanel = 8;
            this.rndReciente.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rndReciente.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rndReciente.Controls.Add(this.btnReciente);
            this.rndReciente.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndReciente.Location = new System.Drawing.Point(444, 64);
            this.rndReciente.MenosHeightBorde = 1;
            this.rndReciente.MenosHeightPanel = 1;
            this.rndReciente.MenosWidthBorde = 1;
            this.rndReciente.MenosWidthPanel = 1;
            this.rndReciente.Name = "rndReciente";
            this.rndReciente.PorcLuzColorBorde = 0;
            this.rndReciente.Size = new System.Drawing.Size(130, 35);
            this.rndReciente.TabIndex = 30;
            this.tagsExtender1.SetTag2(this.rndReciente, null);
            this.tagsExtender1.SetTag3(this.rndReciente, null);
            this.tagsExtender1.SetTagFontName(this.rndReciente, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rndReciente, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rndReciente, System.Drawing.FontStyle.Regular);
            this.rndReciente.XBorde = 0;
            this.rndReciente.XPanel = 0;
            this.rndReciente.YBorde = 0;
            this.rndReciente.YPanel = 0;
            // 
            // btnReciente
            // 
            this.btnReciente.BackColor = System.Drawing.Color.White;
            this.btnReciente.FlatAppearance.BorderSize = 0;
            this.btnReciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReciente.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnReciente.Location = new System.Drawing.Point(3, 2);
            this.btnReciente.Name = "btnReciente";
            this.btnReciente.Size = new System.Drawing.Size(125, 30);
            this.btnReciente.TabIndex = 8;
            this.tagsExtender1.SetTag2(this.btnReciente, null);
            this.tagsExtender1.SetTag3(this.btnReciente, null);
            this.tagsExtender1.SetTagFontName(this.btnReciente, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnReciente, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btnReciente, System.Drawing.FontStyle.Regular);
            this.btnReciente.Text = "Reciente";
            this.btnReciente.UseVisualStyleBackColor = false;
            this.btnReciente.Click += new System.EventHandler(this.btnReciente_Click);
            // 
            // rndAntiguo
            // 
            this.rndAntiguo.ArcRadiusBorde = 8;
            this.rndAntiguo.ArcRadiusPanel = 8;
            this.rndAntiguo.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rndAntiguo.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rndAntiguo.Controls.Add(this.btnAntiguo);
            this.rndAntiguo.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndAntiguo.Location = new System.Drawing.Point(308, 64);
            this.rndAntiguo.MenosHeightBorde = 1;
            this.rndAntiguo.MenosHeightPanel = 1;
            this.rndAntiguo.MenosWidthBorde = 1;
            this.rndAntiguo.MenosWidthPanel = 1;
            this.rndAntiguo.Name = "rndAntiguo";
            this.rndAntiguo.PorcLuzColorBorde = 0;
            this.rndAntiguo.Size = new System.Drawing.Size(130, 35);
            this.rndAntiguo.TabIndex = 29;
            this.tagsExtender1.SetTag2(this.rndAntiguo, null);
            this.tagsExtender1.SetTag3(this.rndAntiguo, null);
            this.tagsExtender1.SetTagFontName(this.rndAntiguo, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rndAntiguo, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rndAntiguo, System.Drawing.FontStyle.Regular);
            this.rndAntiguo.XBorde = 0;
            this.rndAntiguo.XPanel = 0;
            this.rndAntiguo.YBorde = 0;
            this.rndAntiguo.YPanel = 0;
            // 
            // btnAntiguo
            // 
            this.btnAntiguo.BackColor = System.Drawing.Color.White;
            this.btnAntiguo.FlatAppearance.BorderSize = 0;
            this.btnAntiguo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAntiguo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAntiguo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAntiguo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAntiguo.Location = new System.Drawing.Point(3, 2);
            this.btnAntiguo.Name = "btnAntiguo";
            this.btnAntiguo.Size = new System.Drawing.Size(125, 30);
            this.btnAntiguo.TabIndex = 7;
            this.tagsExtender1.SetTag2(this.btnAntiguo, null);
            this.tagsExtender1.SetTag3(this.btnAntiguo, null);
            this.tagsExtender1.SetTagFontName(this.btnAntiguo, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnAntiguo, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btnAntiguo, System.Drawing.FontStyle.Regular);
            this.btnAntiguo.Text = "Antiguo";
            this.btnAntiguo.UseVisualStyleBackColor = false;
            this.btnAntiguo.Click += new System.EventHandler(this.btnAntiguo_Click);
            // 
            // rndZA
            // 
            this.rndZA.ArcRadiusBorde = 8;
            this.rndZA.ArcRadiusPanel = 8;
            this.rndZA.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rndZA.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rndZA.Controls.Add(this.btnZA);
            this.rndZA.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndZA.Location = new System.Drawing.Point(172, 64);
            this.rndZA.MenosHeightBorde = 1;
            this.rndZA.MenosHeightPanel = 1;
            this.rndZA.MenosWidthBorde = 1;
            this.rndZA.MenosWidthPanel = 1;
            this.rndZA.Name = "rndZA";
            this.rndZA.PorcLuzColorBorde = 0;
            this.rndZA.Size = new System.Drawing.Size(130, 35);
            this.rndZA.TabIndex = 28;
            this.tagsExtender1.SetTag2(this.rndZA, null);
            this.tagsExtender1.SetTag3(this.rndZA, null);
            this.tagsExtender1.SetTagFontName(this.rndZA, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rndZA, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rndZA, System.Drawing.FontStyle.Regular);
            this.rndZA.XBorde = 0;
            this.rndZA.XPanel = 0;
            this.rndZA.YBorde = 0;
            this.rndZA.YPanel = 0;
            // 
            // btnZA
            // 
            this.btnZA.BackColor = System.Drawing.Color.White;
            this.btnZA.FlatAppearance.BorderSize = 0;
            this.btnZA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnZA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZA.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnZA.Location = new System.Drawing.Point(3, 2);
            this.btnZA.Name = "btnZA";
            this.btnZA.Size = new System.Drawing.Size(125, 30);
            this.btnZA.TabIndex = 6;
            this.tagsExtender1.SetTag2(this.btnZA, null);
            this.tagsExtender1.SetTag3(this.btnZA, null);
            this.tagsExtender1.SetTagFontName(this.btnZA, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnZA, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btnZA, System.Drawing.FontStyle.Regular);
            this.btnZA.Text = "Z - A";
            this.btnZA.UseVisualStyleBackColor = false;
            this.btnZA.Click += new System.EventHandler(this.btnZA_Click);
            // 
            // rndAZ
            // 
            this.rndAZ.ArcRadiusBorde = 8;
            this.rndAZ.ArcRadiusPanel = 8;
            this.rndAZ.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rndAZ.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rndAZ.Controls.Add(this.btnAZ);
            this.rndAZ.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndAZ.Location = new System.Drawing.Point(36, 64);
            this.rndAZ.MenosHeightBorde = 1;
            this.rndAZ.MenosHeightPanel = 1;
            this.rndAZ.MenosWidthBorde = 1;
            this.rndAZ.MenosWidthPanel = 1;
            this.rndAZ.Name = "rndAZ";
            this.rndAZ.PorcLuzColorBorde = 0;
            this.rndAZ.Size = new System.Drawing.Size(130, 35);
            this.rndAZ.TabIndex = 27;
            this.tagsExtender1.SetTag2(this.rndAZ, null);
            this.tagsExtender1.SetTag3(this.rndAZ, null);
            this.tagsExtender1.SetTagFontName(this.rndAZ, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rndAZ, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rndAZ, System.Drawing.FontStyle.Regular);
            this.rndAZ.XBorde = 0;
            this.rndAZ.XPanel = 0;
            this.rndAZ.YBorde = 0;
            this.rndAZ.YPanel = 0;
            // 
            // btnAZ
            // 
            this.btnAZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.btnAZ.FlatAppearance.BorderSize = 0;
            this.btnAZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAZ.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAZ.Location = new System.Drawing.Point(3, 2);
            this.btnAZ.Name = "btnAZ";
            this.btnAZ.Size = new System.Drawing.Size(125, 30);
            this.btnAZ.TabIndex = 5;
            this.tagsExtender1.SetTag2(this.btnAZ, null);
            this.tagsExtender1.SetTag3(this.btnAZ, null);
            this.tagsExtender1.SetTagFontName(this.btnAZ, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnAZ, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btnAZ, System.Drawing.FontStyle.Regular);
            this.btnAZ.Text = "A - Z";
            this.btnAZ.UseVisualStyleBackColor = false;
            this.btnAZ.Click += new System.EventHandler(this.btnAZ_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.il_Servicios2);
            this.panel1.Controls.Add(this.il_Servicios3);
            this.panel1.Controls.Add(this.il_Servicios1);
            this.panel1.Location = new System.Drawing.Point(37, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 327);
            this.panel1.TabIndex = 31;
            this.tagsExtender1.SetTag2(this.panel1, null);
            this.tagsExtender1.SetTag3(this.panel1, null);
            this.tagsExtender1.SetTagFontName(this.panel1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.panel1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.panel1, System.Drawing.FontStyle.Regular);
            // 
            // il_Servicios2
            // 
            this.il_Servicios2.ColorBack = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.il_Servicios2.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.il_Servicios2.ColorPanel = System.Drawing.Color.White;
            this.il_Servicios2.Location = new System.Drawing.Point(21, 130);
            this.il_Servicios2.Name = "il_Servicios2";
            this.il_Servicios2.Size = new System.Drawing.Size(497, 104);
            this.il_Servicios2.TabIndex = 20;
            this.tagsExtender1.SetTag2(this.il_Servicios2, null);
            this.tagsExtender1.SetTag3(this.il_Servicios2, null);
            this.tagsExtender1.SetTagFontName(this.il_Servicios2, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.il_Servicios2, 10F);
            this.tagsExtender1.SetTagFontStyle(this.il_Servicios2, System.Drawing.FontStyle.Regular);
            this.il_Servicios2.TextoAgregadoPor = "Percy Jackson";
            this.il_Servicios2.TextoFecha = "dd - mm - aaaa";
            this.il_Servicios2.TextoPrincipal = "Pintura en horno";
            this.il_Servicios2.Textosecundario = "Pintura";
            this.il_Servicios2.TextoTercero = "PIN-002";
            // 
            // il_Servicios3
            // 
            this.il_Servicios3.ColorBack = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.il_Servicios3.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.il_Servicios3.ColorPanel = System.Drawing.Color.White;
            this.il_Servicios3.Location = new System.Drawing.Point(21, 254);
            this.il_Servicios3.Name = "il_Servicios3";
            this.il_Servicios3.Size = new System.Drawing.Size(497, 104);
            this.il_Servicios3.TabIndex = 21;
            this.tagsExtender1.SetTag2(this.il_Servicios3, null);
            this.tagsExtender1.SetTag3(this.il_Servicios3, null);
            this.tagsExtender1.SetTagFontName(this.il_Servicios3, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.il_Servicios3, 10F);
            this.tagsExtender1.SetTagFontStyle(this.il_Servicios3, System.Drawing.FontStyle.Regular);
            this.il_Servicios3.TextoAgregadoPor = "Percy Jackson";
            this.il_Servicios3.TextoFecha = "dd - mm - aaaa";
            this.il_Servicios3.TextoPrincipal = "Mecánica a domicilio";
            this.il_Servicios3.Textosecundario = "Mecánica";
            this.il_Servicios3.TextoTercero = "MEC-002";
            // 
            // il_Servicios1
            // 
            this.il_Servicios1.ColorBack = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.il_Servicios1.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.il_Servicios1.ColorPanel = System.Drawing.Color.White;
            this.il_Servicios1.Location = new System.Drawing.Point(21, 6);
            this.il_Servicios1.Name = "il_Servicios1";
            this.il_Servicios1.Size = new System.Drawing.Size(497, 104);
            this.il_Servicios1.TabIndex = 19;
            this.tagsExtender1.SetTag2(this.il_Servicios1, null);
            this.tagsExtender1.SetTag3(this.il_Servicios1, null);
            this.tagsExtender1.SetTagFontName(this.il_Servicios1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.il_Servicios1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.il_Servicios1, System.Drawing.FontStyle.Regular);
            this.il_Servicios1.TextoAgregadoPor = "Percy Jackson";
            this.il_Servicios1.TextoFecha = "dd - mm - aaaa";
            this.il_Servicios1.TextoPrincipal = "Mantenimiento Preventivo";
            this.il_Servicios1.Textosecundario = "Mecánica";
            this.il_Servicios1.TextoTercero = "MEC-001";
            // 
            // pantallaAreaTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.rndReciente);
            this.Controls.Add(this.rpn_ListaServicios);
            this.Controls.Add(this.rndAntiguo);
            this.Controls.Add(this.rndAZ);
            this.Controls.Add(this.rndZA);
            this.Name = "pantallaAreaTrabajo";
            this.Size = new System.Drawing.Size(611, 470);
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.rpn_ListaServicios.ResumeLayout(false);
            this.rpn_ListaServicios.PerformLayout();
            this.rndReciente.ResumeLayout(false);
            this.rndAntiguo.ResumeLayout(false);
            this.rndZA.ResumeLayout(false);
            this.rndAZ.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundedPanel rpn_ListaServicios;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_ListaAreasTrabajo;
        private System.Windows.Forms.TextBox txt_Buscar;
        private RoundedPanel rndReciente;
        private System.Windows.Forms.Button btnReciente;
        private RoundedPanel rndAntiguo;
        private System.Windows.Forms.Button btnAntiguo;
        private RoundedPanel rndZA;
        private System.Windows.Forms.Button btnZA;
        private RoundedPanel rndAZ;
        private System.Windows.Forms.Button btnAZ;
        private System.Windows.Forms.Panel panel1;
        private itemLista il_Servicios2;
        private itemLista il_Servicios3;
        private itemLista il_Servicios1;
        private TagsExtender tagsExtender1;
    }
}
