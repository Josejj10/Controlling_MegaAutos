namespace LP2MegaAutos.Informacion.Vehiculos
{
    partial class pantallaActualizarVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantallaActualizarVehiculos));
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.cTxt_MasFiltros = new LP2MegaAutos.CustomControls.ClickableText();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.rndReciente = new LP2MegaAutos.RoundedPanel();
            this.btnReciente = new System.Windows.Forms.Button();
            this.rndAntiguo = new LP2MegaAutos.RoundedPanel();
            this.btnAntiguo = new System.Windows.Forms.Button();
            this.rndZA = new LP2MegaAutos.RoundedPanel();
            this.btnZA = new System.Windows.Forms.Button();
            this.rndAZ = new LP2MegaAutos.RoundedPanel();
            this.btnAZ = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.il_Vehiculo1 = new LP2MegaAutos.itemLista();
            this.il_Vehiculo2 = new LP2MegaAutos.itemLista();
            this.il_Vehiculo3 = new LP2MegaAutos.itemLista();
            this.roundedPanel4 = new LP2MegaAutos.RoundedPanel();
            this.rpn_ListaVehiculos = new LP2MegaAutos.RoundedPanel();
            this.lbl_ListaVehiculos = new System.Windows.Forms.Label();
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.cmbFiltroTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.pnlBuscar.SuspendLayout();
            this.rndReciente.SuspendLayout();
            this.rndAntiguo.SuspendLayout();
            this.rndZA.SuspendLayout();
            this.rndAZ.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.rpn_ListaVehiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.pnlBuscar.Controls.Add(this.panel2);
            this.pnlBuscar.Controls.Add(this.txt_Buscar);
            this.pnlBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuscar.Location = new System.Drawing.Point(0, 0);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(751, 30);
            this.pnlBuscar.TabIndex = 29;
            this.tagsExtender1.SetTag2(this.pnlBuscar, null);
            this.tagsExtender1.SetTag3(this.pnlBuscar, null);
            this.tagsExtender1.SetTagFontName(this.pnlBuscar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.pnlBuscar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.pnlBuscar, System.Drawing.FontStyle.Regular);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(6, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 25);
            this.panel2.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.panel2, null);
            this.tagsExtender1.SetTag3(this.panel2, null);
            this.tagsExtender1.SetTagFontName(this.panel2, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.panel2, 10F);
            this.tagsExtender1.SetTagFontStyle(this.panel2, System.Drawing.FontStyle.Regular);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txt_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Buscar.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.txt_Buscar.Location = new System.Drawing.Point(37, 6);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(515, 18);
            this.txt_Buscar.TabIndex = 17;
            this.tagsExtender1.SetTag2(this.txt_Buscar, null);
            this.tagsExtender1.SetTag3(this.txt_Buscar, null);
            this.tagsExtender1.SetTagFontName(this.txt_Buscar, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.txt_Buscar, 11F);
            this.tagsExtender1.SetTagFontStyle(this.txt_Buscar, System.Drawing.FontStyle.Bold);
            this.txt_Buscar.Text = "Buscar";
            this.txt_Buscar.Enter += new System.EventHandler(this.txt_Buscar_Enter);
            this.txt_Buscar.Leave += new System.EventHandler(this.txt_Buscar_Leave);
            // 
            // cTxt_MasFiltros
            // 
            this.cTxt_MasFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cTxt_MasFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cTxt_MasFiltros.Font = new System.Drawing.Font("Montserrat", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTxt_MasFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.cTxt_MasFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cTxt_MasFiltros.Location = new System.Drawing.Point(22, 272);
            this.cTxt_MasFiltros.Name = "cTxt_MasFiltros";
            this.cTxt_MasFiltros.Size = new System.Drawing.Size(97, 21);
            this.cTxt_MasFiltros.TabIndex = 63;
            this.tagsExtender1.SetTag2(this.cTxt_MasFiltros, null);
            this.tagsExtender1.SetTag3(this.cTxt_MasFiltros, null);
            this.tagsExtender1.SetTagFontName(this.cTxt_MasFiltros, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.cTxt_MasFiltros, 11F);
            this.tagsExtender1.SetTagFontStyle(this.cTxt_MasFiltros, System.Drawing.FontStyle.Bold);
            this.cTxt_MasFiltros.Text = "Más Filtros";
            this.cTxt_MasFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.White;
            this.btn_Agregar.Location = new System.Drawing.Point(26, 48);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(78, 22);
            this.btn_Agregar.TabIndex = 58;
            this.tagsExtender1.SetTag2(this.btn_Agregar, null);
            this.tagsExtender1.SetTag3(this.btn_Agregar, null);
            this.tagsExtender1.SetTagFontName(this.btn_Agregar, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btn_Agregar, 8F);
            this.tagsExtender1.SetTagFontStyle(this.btn_Agregar, System.Drawing.FontStyle.Bold);
            this.btn_Agregar.Text = "+ Agregar";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            // 
            // rndReciente
            // 
            this.rndReciente.ArcRadiusBorde = 8;
            this.rndReciente.ArcRadiusPanel = 8;
            this.rndReciente.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rndReciente.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rndReciente.Controls.Add(this.btnReciente);
            this.rndReciente.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndReciente.Location = new System.Drawing.Point(24, 227);
            this.rndReciente.MenosHeightBorde = 1;
            this.rndReciente.MenosHeightPanel = 1;
            this.rndReciente.MenosWidthBorde = 1;
            this.rndReciente.MenosWidthPanel = 1;
            this.rndReciente.Name = "rndReciente";
            this.rndReciente.PorcLuzColorBorde = 0;
            this.rndReciente.Size = new System.Drawing.Size(130, 35);
            this.rndReciente.TabIndex = 62;
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
            this.btnReciente.Image = ((System.Drawing.Image)(resources.GetObject("btnReciente.Image")));
            this.btnReciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReciente.Location = new System.Drawing.Point(3, 3);
            this.btnReciente.Name = "btnReciente";
            this.btnReciente.Size = new System.Drawing.Size(124, 29);
            this.btnReciente.TabIndex = 8;
            this.tagsExtender1.SetTag2(this.btnReciente, null);
            this.tagsExtender1.SetTag3(this.btnReciente, null);
            this.tagsExtender1.SetTagFontName(this.btnReciente, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btnReciente, 12F);
            this.tagsExtender1.SetTagFontStyle(this.btnReciente, System.Drawing.FontStyle.Bold);
            this.btnReciente.Text = "Reciente";
            this.btnReciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.rndAntiguo.Location = new System.Drawing.Point(25, 181);
            this.rndAntiguo.MenosHeightBorde = 1;
            this.rndAntiguo.MenosHeightPanel = 1;
            this.rndAntiguo.MenosWidthBorde = 1;
            this.rndAntiguo.MenosWidthPanel = 1;
            this.rndAntiguo.Name = "rndAntiguo";
            this.rndAntiguo.PorcLuzColorBorde = 0;
            this.rndAntiguo.Size = new System.Drawing.Size(130, 35);
            this.rndAntiguo.TabIndex = 61;
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
            this.btnAntiguo.Image = ((System.Drawing.Image)(resources.GetObject("btnAntiguo.Image")));
            this.btnAntiguo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAntiguo.Location = new System.Drawing.Point(3, 3);
            this.btnAntiguo.Name = "btnAntiguo";
            this.btnAntiguo.Size = new System.Drawing.Size(124, 29);
            this.btnAntiguo.TabIndex = 7;
            this.tagsExtender1.SetTag2(this.btnAntiguo, null);
            this.tagsExtender1.SetTag3(this.btnAntiguo, null);
            this.tagsExtender1.SetTagFontName(this.btnAntiguo, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btnAntiguo, 12F);
            this.tagsExtender1.SetTagFontStyle(this.btnAntiguo, System.Drawing.FontStyle.Bold);
            this.btnAntiguo.Text = "Antiguo";
            this.btnAntiguo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.rndZA.Location = new System.Drawing.Point(25, 135);
            this.rndZA.MenosHeightBorde = 1;
            this.rndZA.MenosHeightPanel = 1;
            this.rndZA.MenosWidthBorde = 1;
            this.rndZA.MenosWidthPanel = 1;
            this.rndZA.Name = "rndZA";
            this.rndZA.PorcLuzColorBorde = 0;
            this.rndZA.Size = new System.Drawing.Size(130, 35);
            this.rndZA.TabIndex = 60;
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
            this.btnZA.Image = ((System.Drawing.Image)(resources.GetObject("btnZA.Image")));
            this.btnZA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZA.Location = new System.Drawing.Point(3, 3);
            this.btnZA.Name = "btnZA";
            this.btnZA.Size = new System.Drawing.Size(124, 29);
            this.btnZA.TabIndex = 6;
            this.tagsExtender1.SetTag2(this.btnZA, null);
            this.tagsExtender1.SetTag3(this.btnZA, null);
            this.tagsExtender1.SetTagFontName(this.btnZA, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btnZA, 12F);
            this.tagsExtender1.SetTagFontStyle(this.btnZA, System.Drawing.FontStyle.Bold);
            this.btnZA.Text = "Z - A";
            this.btnZA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.rndAZ.Location = new System.Drawing.Point(25, 89);
            this.rndAZ.MenosHeightBorde = 1;
            this.rndAZ.MenosHeightPanel = 1;
            this.rndAZ.MenosWidthBorde = 1;
            this.rndAZ.MenosWidthPanel = 1;
            this.rndAZ.Name = "rndAZ";
            this.rndAZ.PorcLuzColorBorde = 0;
            this.rndAZ.Size = new System.Drawing.Size(130, 35);
            this.rndAZ.TabIndex = 59;
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
            this.btnAZ.Image = ((System.Drawing.Image)(resources.GetObject("btnAZ.Image")));
            this.btnAZ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAZ.Location = new System.Drawing.Point(3, 3);
            this.btnAZ.Name = "btnAZ";
            this.btnAZ.Size = new System.Drawing.Size(124, 29);
            this.btnAZ.TabIndex = 5;
            this.tagsExtender1.SetTag2(this.btnAZ, null);
            this.tagsExtender1.SetTag3(this.btnAZ, null);
            this.tagsExtender1.SetTagFontName(this.btnAZ, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btnAZ, 12F);
            this.tagsExtender1.SetTagFontStyle(this.btnAZ, System.Drawing.FontStyle.Bold);
            this.btnAZ.Text = "A - Z";
            this.btnAZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAZ.UseVisualStyleBackColor = false;
            this.btnAZ.Click += new System.EventHandler(this.btnAZ_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.roundedPanel4);
            this.panel3.Controls.Add(this.rpn_ListaVehiculos);
            this.panel3.Location = new System.Drawing.Point(171, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(566, 438);
            this.panel3.TabIndex = 64;
            this.tagsExtender1.SetTag2(this.panel3, null);
            this.tagsExtender1.SetTag3(this.panel3, null);
            this.tagsExtender1.SetTagFontName(this.panel3, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.panel3, 10F);
            this.tagsExtender1.SetTagFontStyle(this.panel3, System.Drawing.FontStyle.Regular);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.flowLayoutPanel1.Controls.Add(this.il_Vehiculo1);
            this.flowLayoutPanel1.Controls.Add(this.il_Vehiculo2);
            this.flowLayoutPanel1.Controls.Add(this.il_Vehiculo3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(566, 395);
            this.flowLayoutPanel1.TabIndex = 54;
            this.tagsExtender1.SetTag2(this.flowLayoutPanel1, null);
            this.tagsExtender1.SetTag3(this.flowLayoutPanel1, null);
            this.tagsExtender1.SetTagFontName(this.flowLayoutPanel1, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.flowLayoutPanel1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.flowLayoutPanel1, System.Drawing.FontStyle.Regular);
            // 
            // il_Vehiculo1
            // 
            this.il_Vehiculo1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.il_Vehiculo1.ColorBack = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.il_Vehiculo1.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.il_Vehiculo1.ColorPanel = System.Drawing.Color.White;
            this.il_Vehiculo1.Location = new System.Drawing.Point(34, 3);
            this.il_Vehiculo1.Name = "il_Vehiculo1";
            this.il_Vehiculo1.Size = new System.Drawing.Size(497, 104);
            this.il_Vehiculo1.TabIndex = 54;
            this.tagsExtender1.SetTag2(this.il_Vehiculo1, null);
            this.tagsExtender1.SetTag3(this.il_Vehiculo1, null);
            this.tagsExtender1.SetTagFontName(this.il_Vehiculo1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.il_Vehiculo1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.il_Vehiculo1, System.Drawing.FontStyle.Regular);
            this.il_Vehiculo1.TextoAgregadoPor = "Percy Jackson";
            this.il_Vehiculo1.TextoFecha = "dd - mm - aaaa";
            this.il_Vehiculo1.TextoPrincipal = "ABC-123";
            this.il_Vehiculo1.Textosecundario = "Sir Shackleton III";
            this.il_Vehiculo1.TextoTercero = "Camioneta";
            // 
            // il_Vehiculo2
            // 
            this.il_Vehiculo2.ColorBack = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.il_Vehiculo2.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.il_Vehiculo2.ColorPanel = System.Drawing.Color.White;
            this.il_Vehiculo2.Location = new System.Drawing.Point(34, 113);
            this.il_Vehiculo2.Name = "il_Vehiculo2";
            this.il_Vehiculo2.Size = new System.Drawing.Size(497, 104);
            this.il_Vehiculo2.TabIndex = 56;
            this.tagsExtender1.SetTag2(this.il_Vehiculo2, null);
            this.tagsExtender1.SetTag3(this.il_Vehiculo2, null);
            this.tagsExtender1.SetTagFontName(this.il_Vehiculo2, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.il_Vehiculo2, 10F);
            this.tagsExtender1.SetTagFontStyle(this.il_Vehiculo2, System.Drawing.FontStyle.Regular);
            this.il_Vehiculo2.TextoAgregadoPor = "Percy Jackson";
            this.il_Vehiculo2.TextoFecha = "dd - mm - aaaa";
            this.il_Vehiculo2.TextoPrincipal = "DEF-987";
            this.il_Vehiculo2.Textosecundario = "Carter Kane";
            this.il_Vehiculo2.TextoTercero = "Auto";
            // 
            // il_Vehiculo3
            // 
            this.il_Vehiculo3.ColorBack = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.il_Vehiculo3.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.il_Vehiculo3.ColorPanel = System.Drawing.Color.White;
            this.il_Vehiculo3.Location = new System.Drawing.Point(34, 223);
            this.il_Vehiculo3.Name = "il_Vehiculo3";
            this.il_Vehiculo3.Size = new System.Drawing.Size(497, 104);
            this.il_Vehiculo3.TabIndex = 55;
            this.tagsExtender1.SetTag2(this.il_Vehiculo3, null);
            this.tagsExtender1.SetTag3(this.il_Vehiculo3, null);
            this.tagsExtender1.SetTagFontName(this.il_Vehiculo3, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.il_Vehiculo3, 10F);
            this.tagsExtender1.SetTagFontStyle(this.il_Vehiculo3, System.Drawing.FontStyle.Regular);
            this.il_Vehiculo3.TextoAgregadoPor = "Percy Jackson";
            this.il_Vehiculo3.TextoFecha = "dd - mm - aaaa";
            this.il_Vehiculo3.TextoPrincipal = "XYZ-666";
            this.il_Vehiculo3.Textosecundario = "Lucia Fernandez";
            this.il_Vehiculo3.TextoTercero = "Deportivo";
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.ArcRadiusBorde = 5;
            this.roundedPanel4.ArcRadiusPanel = 5;
            this.roundedPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.roundedPanel4.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.roundedPanel4.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.roundedPanel4.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.None;
            this.roundedPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roundedPanel4.Location = new System.Drawing.Point(0, 422);
            this.roundedPanel4.MenosHeightBorde = 1;
            this.roundedPanel4.MenosHeightPanel = 1;
            this.roundedPanel4.MenosWidthBorde = 1;
            this.roundedPanel4.MenosWidthPanel = 1;
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.PorcLuzColorBorde = 0;
            this.roundedPanel4.Size = new System.Drawing.Size(566, 16);
            this.roundedPanel4.TabIndex = 53;
            this.tagsExtender1.SetTag2(this.roundedPanel4, null);
            this.tagsExtender1.SetTag3(this.roundedPanel4, null);
            this.tagsExtender1.SetTagFontName(this.roundedPanel4, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.roundedPanel4, 10F);
            this.tagsExtender1.SetTagFontStyle(this.roundedPanel4, System.Drawing.FontStyle.Regular);
            this.roundedPanel4.XBorde = 0;
            this.roundedPanel4.XPanel = 0;
            this.roundedPanel4.YBorde = 0;
            this.roundedPanel4.YPanel = 0;
            // 
            // rpn_ListaVehiculos
            // 
            this.rpn_ListaVehiculos.ArcRadiusBorde = 15;
            this.rpn_ListaVehiculos.ArcRadiusPanel = 15;
            this.rpn_ListaVehiculos.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpn_ListaVehiculos.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.rpn_ListaVehiculos.Controls.Add(this.lbl_ListaVehiculos);
            this.rpn_ListaVehiculos.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.None;
            this.rpn_ListaVehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.rpn_ListaVehiculos.Location = new System.Drawing.Point(0, 0);
            this.rpn_ListaVehiculos.MenosHeightBorde = 1;
            this.rpn_ListaVehiculos.MenosHeightPanel = 1;
            this.rpn_ListaVehiculos.MenosWidthBorde = 1;
            this.rpn_ListaVehiculos.MenosWidthPanel = 1;
            this.rpn_ListaVehiculos.Name = "rpn_ListaVehiculos";
            this.rpn_ListaVehiculos.PorcLuzColorBorde = 0;
            this.rpn_ListaVehiculos.Size = new System.Drawing.Size(566, 27);
            this.rpn_ListaVehiculos.TabIndex = 51;
            this.tagsExtender1.SetTag2(this.rpn_ListaVehiculos, null);
            this.tagsExtender1.SetTag3(this.rpn_ListaVehiculos, null);
            this.tagsExtender1.SetTagFontName(this.rpn_ListaVehiculos, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpn_ListaVehiculos, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpn_ListaVehiculos, System.Drawing.FontStyle.Regular);
            this.rpn_ListaVehiculos.XBorde = 0;
            this.rpn_ListaVehiculos.XPanel = 0;
            this.rpn_ListaVehiculos.YBorde = 0;
            this.rpn_ListaVehiculos.YPanel = 0;
            // 
            // lbl_ListaVehiculos
            // 
            this.lbl_ListaVehiculos.AutoSize = true;
            this.lbl_ListaVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lbl_ListaVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ListaVehiculos.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListaVehiculos.ForeColor = System.Drawing.Color.White;
            this.lbl_ListaVehiculos.Location = new System.Drawing.Point(229, 2);
            this.lbl_ListaVehiculos.Name = "lbl_ListaVehiculos";
            this.lbl_ListaVehiculos.Size = new System.Drawing.Size(90, 22);
            this.lbl_ListaVehiculos.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.lbl_ListaVehiculos, null);
            this.tagsExtender1.SetTag3(this.lbl_ListaVehiculos, null);
            this.tagsExtender1.SetTagFontName(this.lbl_ListaVehiculos, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lbl_ListaVehiculos, 12F);
            this.tagsExtender1.SetTagFontStyle(this.lbl_ListaVehiculos, System.Drawing.FontStyle.Bold);
            this.lbl_ListaVehiculos.Text = "Vehículos";
            this.lbl_ListaVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbFiltroTipoVehiculo
            // 
            this.cmbFiltroTipoVehiculo.FormattingEnabled = true;
            this.cmbFiltroTipoVehiculo.Location = new System.Drawing.Point(24, 311);
            this.cmbFiltroTipoVehiculo.Name = "cmbFiltroTipoVehiculo";
            this.cmbFiltroTipoVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltroTipoVehiculo.TabIndex = 65;
            this.tagsExtender1.SetTag2(this.cmbFiltroTipoVehiculo, null);
            this.tagsExtender1.SetTag3(this.cmbFiltroTipoVehiculo, null);
            this.tagsExtender1.SetTagFontName(this.cmbFiltroTipoVehiculo, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.cmbFiltroTipoVehiculo, 10F);
            this.tagsExtender1.SetTagFontStyle(this.cmbFiltroTipoVehiculo, System.Drawing.FontStyle.Regular);
            // 
            // pantallaActualizarVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbFiltroTipoVehiculo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cTxt_MasFiltros);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.rndReciente);
            this.Controls.Add(this.rndAntiguo);
            this.Controls.Add(this.rndZA);
            this.Controls.Add(this.rndAZ);
            this.Controls.Add(this.pnlBuscar);
            this.Name = "pantallaActualizarVehiculos";
            this.Size = new System.Drawing.Size(751, 520);
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.rndReciente.ResumeLayout(false);
            this.rndAntiguo.ResumeLayout(false);
            this.rndZA.ResumeLayout(false);
            this.rndAZ.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.rpn_ListaVehiculos.ResumeLayout(false);
            this.rpn_ListaVehiculos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Buscar;
        private CustomControls.ClickableText cTxt_MasFiltros;
        private System.Windows.Forms.Button btn_Agregar;
        private RoundedPanel rndReciente;
        private System.Windows.Forms.Button btnReciente;
        private RoundedPanel rndAntiguo;
        private System.Windows.Forms.Button btnAntiguo;
        private RoundedPanel rndZA;
        private System.Windows.Forms.Button btnZA;
        private RoundedPanel rndAZ;
        private System.Windows.Forms.Button btnAZ;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private itemLista il_Vehiculo1;
        private itemLista il_Vehiculo2;
        private itemLista il_Vehiculo3;
        private RoundedPanel roundedPanel4;
        private RoundedPanel rpn_ListaVehiculos;
        private System.Windows.Forms.Label lbl_ListaVehiculos;
        private TagsExtender tagsExtender1;
        private System.Windows.Forms.ComboBox cmbFiltroTipoVehiculo;
    }
}
