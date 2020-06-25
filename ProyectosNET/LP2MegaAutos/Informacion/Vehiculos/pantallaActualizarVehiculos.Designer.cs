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
            this.panel3 = new System.Windows.Forms.Panel();
            this.flpVehiculos = new System.Windows.Forms.FlowLayoutPanel();
            this.roundedPanel4 = new LP2MegaAutos.RoundedPanel();
            this.rpn_ListaVehiculos = new LP2MegaAutos.RoundedPanel();
            this.lbl_ListaVehiculos = new System.Windows.Forms.Label();
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.cmbFiltrarPermisos = new System.Windows.Forms.ComboBox();
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
            this.pnlBuscar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.rpn_ListaVehiculos.SuspendLayout();
            this.rndReciente.SuspendLayout();
            this.rndAntiguo.SuspendLayout();
            this.rndZA.SuspendLayout();
            this.rndAZ.SuspendLayout();
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
            // panel3
            // 
            this.panel3.Controls.Add(this.flpVehiculos);
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
            // flpVehiculos
            // 
            this.flpVehiculos.AutoScroll = true;
            this.flpVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.flpVehiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpVehiculos.Location = new System.Drawing.Point(0, 27);
            this.flpVehiculos.Name = "flpVehiculos";
            this.flpVehiculos.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.flpVehiculos.Size = new System.Drawing.Size(566, 395);
            this.flpVehiculos.TabIndex = 54;
            this.tagsExtender1.SetTag2(this.flpVehiculos, null);
            this.tagsExtender1.SetTag3(this.flpVehiculos, null);
            this.tagsExtender1.SetTagFontName(this.flpVehiculos, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.flpVehiculos, 10F);
            this.tagsExtender1.SetTagFontStyle(this.flpVehiculos, System.Drawing.FontStyle.Regular);
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
            // cmbFiltrarPermisos
            // 
            this.cmbFiltrarPermisos.FormattingEnabled = true;
            this.cmbFiltrarPermisos.Location = new System.Drawing.Point(26, 309);
            this.cmbFiltrarPermisos.Name = "cmbFiltrarPermisos";
            this.cmbFiltrarPermisos.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltrarPermisos.TabIndex = 71;
            this.tagsExtender1.SetTag2(this.cmbFiltrarPermisos, null);
            this.tagsExtender1.SetTag3(this.cmbFiltrarPermisos, null);
            this.tagsExtender1.SetTagFontName(this.cmbFiltrarPermisos, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.cmbFiltrarPermisos, 10F);
            this.tagsExtender1.SetTagFontStyle(this.cmbFiltrarPermisos, System.Drawing.FontStyle.Regular);
            // 
            // cTxt_MasFiltros
            // 
            this.cTxt_MasFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cTxt_MasFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cTxt_MasFiltros.Font = new System.Drawing.Font("Montserrat", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTxt_MasFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.cTxt_MasFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cTxt_MasFiltros.Location = new System.Drawing.Point(23, 272);
            this.cTxt_MasFiltros.Name = "cTxt_MasFiltros";
            this.cTxt_MasFiltros.Size = new System.Drawing.Size(97, 21);
            this.cTxt_MasFiltros.TabIndex = 70;
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
            this.btn_Agregar.AutoSize = true;
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Agregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.btn_Agregar.Location = new System.Drawing.Point(27, 46);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(102, 31);
            this.btn_Agregar.TabIndex = 65;
            this.tagsExtender1.SetTag2(this.btn_Agregar, null);
            this.tagsExtender1.SetTag3(this.btn_Agregar, null);
            this.tagsExtender1.SetTagFontName(this.btn_Agregar, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btn_Agregar, 11F);
            this.tagsExtender1.SetTagFontStyle(this.btn_Agregar, System.Drawing.FontStyle.Bold);
            this.btn_Agregar.Text = "+ Agregar";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Agregar.UseVisualStyleBackColor = false;

            // 
            // rndReciente
            // 
            this.rndReciente.ArcRadiusBorde = 8;
            this.rndReciente.ArcRadiusPanel = 8;
            this.rndReciente.BackColor = System.Drawing.Color.Transparent;
            this.rndReciente.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rndReciente.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.rndReciente.Controls.Add(this.btnReciente);
            this.rndReciente.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndReciente.Location = new System.Drawing.Point(26, 227);
            this.rndReciente.MenosHeightBorde = 1;
            this.rndReciente.MenosHeightPanel = 1;
            this.rndReciente.MenosWidthBorde = 1;
            this.rndReciente.MenosWidthPanel = 1;
            this.rndReciente.Name = "rndReciente";
            this.rndReciente.PorcLuzColorBorde = 0;
            this.rndReciente.Size = new System.Drawing.Size(130, 35);
            this.rndReciente.TabIndex = 69;
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
            this.btnReciente.BackColor = System.Drawing.Color.Transparent;
            this.btnReciente.FlatAppearance.BorderSize = 0;
            this.btnReciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
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
            this.btnReciente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnReciente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            this.btnReciente.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // rndAntiguo
            // 
            this.rndAntiguo.ArcRadiusBorde = 8;
            this.rndAntiguo.ArcRadiusPanel = 8;
            this.rndAntiguo.BackColor = System.Drawing.Color.Transparent;
            this.rndAntiguo.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rndAntiguo.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.rndAntiguo.Controls.Add(this.btnAntiguo);
            this.rndAntiguo.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndAntiguo.Location = new System.Drawing.Point(26, 181);
            this.rndAntiguo.MenosHeightBorde = 1;
            this.rndAntiguo.MenosHeightPanel = 1;
            this.rndAntiguo.MenosWidthBorde = 1;
            this.rndAntiguo.MenosWidthPanel = 1;
            this.rndAntiguo.Name = "rndAntiguo";
            this.rndAntiguo.PorcLuzColorBorde = 0;
            this.rndAntiguo.Size = new System.Drawing.Size(130, 35);
            this.rndAntiguo.TabIndex = 68;
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
            this.btnAntiguo.BackColor = System.Drawing.Color.Transparent;
            this.btnAntiguo.FlatAppearance.BorderSize = 0;
            this.btnAntiguo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
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
            this.btnAntiguo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnAntiguo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            this.btnAntiguo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // rndZA
            // 
            this.rndZA.ArcRadiusBorde = 8;
            this.rndZA.ArcRadiusPanel = 8;
            this.rndZA.BackColor = System.Drawing.Color.Transparent;
            this.rndZA.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rndZA.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.rndZA.Controls.Add(this.btnZA);
            this.rndZA.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndZA.Location = new System.Drawing.Point(26, 135);
            this.rndZA.MenosHeightBorde = 1;
            this.rndZA.MenosHeightPanel = 1;
            this.rndZA.MenosWidthBorde = 1;
            this.rndZA.MenosWidthPanel = 1;
            this.rndZA.Name = "rndZA";
            this.rndZA.PorcLuzColorBorde = 0;
            this.rndZA.Size = new System.Drawing.Size(130, 35);
            this.rndZA.TabIndex = 67;
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
            this.btnZA.BackColor = System.Drawing.Color.Transparent;
            this.btnZA.FlatAppearance.BorderSize = 0;
            this.btnZA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
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
            this.btnZA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnZA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            this.btnZA.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // rndAZ
            // 
            this.rndAZ.ArcRadiusBorde = 8;
            this.rndAZ.ArcRadiusPanel = 8;
            this.rndAZ.BackColor = System.Drawing.Color.Transparent;
            this.rndAZ.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rndAZ.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rndAZ.Controls.Add(this.btnAZ);
            this.rndAZ.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndAZ.Location = new System.Drawing.Point(26, 89);
            this.rndAZ.MenosHeightBorde = 1;
            this.rndAZ.MenosHeightPanel = 1;
            this.rndAZ.MenosWidthBorde = 1;
            this.rndAZ.MenosWidthPanel = 1;
            this.rndAZ.Name = "rndAZ";
            this.rndAZ.PorcLuzColorBorde = 0;
            this.rndAZ.Size = new System.Drawing.Size(130, 35);
            this.rndAZ.TabIndex = 66;
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
            this.btnAZ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
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
            this.btnAZ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnAZ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            this.btnAZ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // pantallaActualizarVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.cmbFiltrarPermisos);
            this.Controls.Add(this.cTxt_MasFiltros);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.rndReciente);
            this.Controls.Add(this.rndAntiguo);
            this.Controls.Add(this.rndZA);
            this.Controls.Add(this.rndAZ);
            this.Controls.Add(this.panel3);
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
            this.panel3.ResumeLayout(false);
            this.rpn_ListaVehiculos.ResumeLayout(false);
            this.rpn_ListaVehiculos.PerformLayout();
            this.rndReciente.ResumeLayout(false);
            this.rndAntiguo.ResumeLayout(false);
            this.rndZA.ResumeLayout(false);
            this.rndAZ.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flpVehiculos;
        private RoundedPanel roundedPanel4;
        private RoundedPanel rpn_ListaVehiculos;
        private System.Windows.Forms.Label lbl_ListaVehiculos;
        private TagsExtender tagsExtender1;
        private System.Windows.Forms.ComboBox cmbFiltrarPermisos;
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
    }
}
