namespace LP2MegaAutos
{
    partial class pantallaActualizarSedes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantallaActualizarSedes));
            this.il_Sedes2 = new LP2MegaAutos.itemLista();
            this.il_Sedes1 = new LP2MegaAutos.itemLista();
            this.rpn_ListaDrivers = new LP2MegaAutos.RoundedPanel();
            this.btn_AgregarSede = new System.Windows.Forms.Button();
            this.lbl_ListaSedes = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.rpTopMain = new LP2MegaAutos.RoundedPanel();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roundedPanel4 = new LP2MegaAutos.RoundedPanel();
            this.btn_ZA = new System.Windows.Forms.Button();
            this.rnd_ZA = new LP2MegaAutos.RoundedPanel();
            this.btn_Antiguo = new System.Windows.Forms.Button();
            this.rnd_Antiguo = new LP2MegaAutos.RoundedPanel();
            this.btn_Reciente = new System.Windows.Forms.Button();
            this.rnd_Reciente = new LP2MegaAutos.RoundedPanel();
            this.rnd_AZ = new LP2MegaAutos.RoundedPanel();
            this.btn_AZ = new System.Windows.Forms.Button();
            this.rpn_ListaDrivers.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlBuscar.SuspendLayout();
            this.rnd_ZA.SuspendLayout();
            this.rnd_Antiguo.SuspendLayout();
            this.rnd_Reciente.SuspendLayout();
            this.rnd_AZ.SuspendLayout();
            this.SuspendLayout();
            // 
            // il_Sedes2
            // 
            this.il_Sedes2.ColorBack = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.il_Sedes2.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.il_Sedes2.ColorPanel = System.Drawing.Color.White;
            this.il_Sedes2.Location = new System.Drawing.Point(21, 130);
            this.il_Sedes2.Name = "il_Sedes2";
            this.il_Sedes2.Size = new System.Drawing.Size(497, 104);
            this.il_Sedes2.TabIndex = 20;
            this.tagsExtender1.SetTag2(this.il_Sedes2, null);
            this.tagsExtender1.SetTag3(this.il_Sedes2, null);
            this.tagsExtender1.SetTagFontName(this.il_Sedes2, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.il_Sedes2, 10F);
            this.tagsExtender1.SetTagFontStyle(this.il_Sedes2, System.Drawing.FontStyle.Regular);
            this.il_Sedes2.TextoAgregadoPor = "Percy Jackson";
            this.il_Sedes2.TextoFecha = "dd - mm - aaaa";
            this.il_Sedes2.TextoPrincipal = "Taller Sur";
            this.il_Sedes2.Textosecundario = "Surquillo";
            this.il_Sedes2.TextoTercero = "Av. Ipsum Lorem 234";
            // 
            // il_Sedes1
            // 
            this.il_Sedes1.ColorBack = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.il_Sedes1.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.il_Sedes1.ColorPanel = System.Drawing.Color.White;
            this.il_Sedes1.Location = new System.Drawing.Point(21, 6);
            this.il_Sedes1.Name = "il_Sedes1";
            this.il_Sedes1.Size = new System.Drawing.Size(497, 104);
            this.il_Sedes1.TabIndex = 19;
            this.tagsExtender1.SetTag2(this.il_Sedes1, null);
            this.tagsExtender1.SetTag3(this.il_Sedes1, null);
            this.tagsExtender1.SetTagFontName(this.il_Sedes1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.il_Sedes1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.il_Sedes1, System.Drawing.FontStyle.Regular);
            this.il_Sedes1.TextoAgregadoPor = "Percy Jackson";
            this.il_Sedes1.TextoFecha = "dd - mm - aaaa";
            this.il_Sedes1.TextoPrincipal = "Taller Principal";
            this.il_Sedes1.Textosecundario = "Independencia";
            this.il_Sedes1.TextoTercero = "Av. Lorem Ipsum 213";
            // 
            // rpn_ListaDrivers
            // 
            this.rpn_ListaDrivers.ArcRadiusBorde = 15;
            this.rpn_ListaDrivers.ArcRadiusPanel = 15;
            this.rpn_ListaDrivers.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpn_ListaDrivers.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(226)))));
            this.rpn_ListaDrivers.Controls.Add(this.btn_AgregarSede);
            this.rpn_ListaDrivers.Controls.Add(this.lbl_ListaSedes);
            this.rpn_ListaDrivers.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.None;
            this.rpn_ListaDrivers.Location = new System.Drawing.Point(36, 115);
            this.rpn_ListaDrivers.MenosHeightBorde = 1;
            this.rpn_ListaDrivers.MenosHeightPanel = 1;
            this.rpn_ListaDrivers.MenosWidthBorde = 1;
            this.rpn_ListaDrivers.MenosWidthPanel = 1;
            this.rpn_ListaDrivers.Name = "rpn_ListaDrivers";
            this.rpn_ListaDrivers.PorcLuzColorBorde = 0;
            this.rpn_ListaDrivers.Size = new System.Drawing.Size(539, 27);
            this.rpn_ListaDrivers.TabIndex = 18;
            this.tagsExtender1.SetTag2(this.rpn_ListaDrivers, null);
            this.tagsExtender1.SetTag3(this.rpn_ListaDrivers, null);
            this.tagsExtender1.SetTagFontName(this.rpn_ListaDrivers, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpn_ListaDrivers, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpn_ListaDrivers, System.Drawing.FontStyle.Regular);
            this.rpn_ListaDrivers.XBorde = 0;
            this.rpn_ListaDrivers.XPanel = 0;
            this.rpn_ListaDrivers.YBorde = 0;
            this.rpn_ListaDrivers.YPanel = 0;
            // 
            // btn_AgregarSede
            // 
            this.btn_AgregarSede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(33)))));
            this.btn_AgregarSede.FlatAppearance.BorderSize = 0;
            this.btn_AgregarSede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarSede.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarSede.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarSede.Location = new System.Drawing.Point(441, 2);
            this.btn_AgregarSede.Name = "btn_AgregarSede";
            this.btn_AgregarSede.Size = new System.Drawing.Size(78, 23);
            this.btn_AgregarSede.TabIndex = 6;
            this.tagsExtender1.SetTag2(this.btn_AgregarSede, null);
            this.tagsExtender1.SetTag3(this.btn_AgregarSede, null);
            this.tagsExtender1.SetTagFontName(this.btn_AgregarSede, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btn_AgregarSede, 8F);
            this.tagsExtender1.SetTagFontStyle(this.btn_AgregarSede, System.Drawing.FontStyle.Bold);
            this.btn_AgregarSede.Text = "+ Agregar";
            this.btn_AgregarSede.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_AgregarSede.UseVisualStyleBackColor = false;
            // 
            // lbl_ListaSedes
            // 
            this.lbl_ListaSedes.AutoSize = true;
            this.lbl_ListaSedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(226)))));
            this.lbl_ListaSedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ListaSedes.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListaSedes.ForeColor = System.Drawing.Color.White;
            this.lbl_ListaSedes.Location = new System.Drawing.Point(240, 2);
            this.lbl_ListaSedes.Name = "lbl_ListaSedes";
            this.lbl_ListaSedes.Size = new System.Drawing.Size(59, 22);
            this.lbl_ListaSedes.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.lbl_ListaSedes, null);
            this.tagsExtender1.SetTag3(this.lbl_ListaSedes, null);
            this.tagsExtender1.SetTagFontName(this.lbl_ListaSedes, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lbl_ListaSedes, 12F);
            this.tagsExtender1.SetTagFontStyle(this.lbl_ListaSedes, System.Drawing.FontStyle.Bold);
            this.lbl_ListaSedes.Text = "Sedes";
            this.lbl_ListaSedes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txt_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Buscar.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.txt_Buscar.Location = new System.Drawing.Point(57, 45);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(538, 18);
            this.txt_Buscar.TabIndex = 17;
            this.tagsExtender1.SetTag2(this.txt_Buscar, null);
            this.tagsExtender1.SetTag3(this.txt_Buscar, null);
            this.tagsExtender1.SetTagFontName(this.txt_Buscar, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.txt_Buscar, 11F);
            this.tagsExtender1.SetTagFontStyle(this.txt_Buscar, System.Drawing.FontStyle.Bold);
            this.txt_Buscar.Text = "Buscar";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.il_Sedes2);
            this.panel1.Controls.Add(this.il_Sedes1);
            this.panel1.Location = new System.Drawing.Point(36, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 314);
            this.panel1.TabIndex = 27;
            this.tagsExtender1.SetTag2(this.panel1, null);
            this.tagsExtender1.SetTag3(this.panel1, null);
            this.tagsExtender1.SetTagFontName(this.panel1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.panel1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.panel1, System.Drawing.FontStyle.Regular);
            // 
            // rpTopMain
            // 
            this.rpTopMain.ArcRadiusBorde = 15;
            this.rpTopMain.ArcRadiusPanel = 15;
            this.rpTopMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpTopMain.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpTopMain.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(226)))));
            this.rpTopMain.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Top;
            this.rpTopMain.Location = new System.Drawing.Point(0, 0);
            this.rpTopMain.MenosHeightBorde = 1;
            this.rpTopMain.MenosHeightPanel = 1;
            this.rpTopMain.MenosWidthBorde = 1;
            this.rpTopMain.MenosWidthPanel = 1;
            this.rpTopMain.Name = "rpTopMain";
            this.rpTopMain.PorcLuzColorBorde = 0;
            this.rpTopMain.Size = new System.Drawing.Size(611, 40);
            this.rpTopMain.TabIndex = 29;
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
            // pnlBuscar
            // 
            this.pnlBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.pnlBuscar.Controls.Add(this.panel2);
            this.pnlBuscar.Location = new System.Drawing.Point(0, 39);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(611, 30);
            this.pnlBuscar.TabIndex = 30;
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
            this.panel2.Location = new System.Drawing.Point(26, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 25);
            this.panel2.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.panel2, null);
            this.tagsExtender1.SetTag3(this.panel2, null);
            this.tagsExtender1.SetTagFontName(this.panel2, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.panel2, 10F);
            this.tagsExtender1.SetTagFontStyle(this.panel2, System.Drawing.FontStyle.Regular);
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.ArcRadiusBorde = 5;
            this.roundedPanel4.ArcRadiusPanel = 5;
            this.roundedPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.roundedPanel4.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.roundedPanel4.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(226)))));
            this.roundedPanel4.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Bottom;
            this.roundedPanel4.Location = new System.Drawing.Point(0, 454);
            this.roundedPanel4.MenosHeightBorde = 1;
            this.roundedPanel4.MenosHeightPanel = 1;
            this.roundedPanel4.MenosWidthBorde = 1;
            this.roundedPanel4.MenosWidthPanel = 1;
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.PorcLuzColorBorde = 0;
            this.roundedPanel4.Size = new System.Drawing.Size(611, 16);
            this.roundedPanel4.TabIndex = 49;
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
            // btn_ZA
            // 
            this.btn_ZA.BackColor = System.Drawing.Color.White;
            this.btn_ZA.FlatAppearance.BorderSize = 0;
            this.btn_ZA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ZA.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ZA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_ZA.Location = new System.Drawing.Point(3, 3);
            this.btn_ZA.Name = "btn_ZA";
            this.btn_ZA.Size = new System.Drawing.Size(125, 30);
            this.btn_ZA.TabIndex = 6;
            this.tagsExtender1.SetTag2(this.btn_ZA, null);
            this.tagsExtender1.SetTag3(this.btn_ZA, null);
            this.tagsExtender1.SetTagFontName(this.btn_ZA, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btn_ZA, 12F);
            this.tagsExtender1.SetTagFontStyle(this.btn_ZA, System.Drawing.FontStyle.Bold);
            this.btn_ZA.Text = "Z - A";
            this.btn_ZA.UseVisualStyleBackColor = false;
            this.btn_ZA.Click += new System.EventHandler(this.btn_ZA_Click);
            // 
            // rnd_ZA
            // 
            this.rnd_ZA.ArcRadiusBorde = 8;
            this.rnd_ZA.ArcRadiusPanel = 8;
            this.rnd_ZA.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rnd_ZA.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rnd_ZA.Controls.Add(this.btn_ZA);
            this.rnd_ZA.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rnd_ZA.Location = new System.Drawing.Point(172, 74);
            this.rnd_ZA.MenosHeightBorde = 1;
            this.rnd_ZA.MenosHeightPanel = 1;
            this.rnd_ZA.MenosWidthBorde = 1;
            this.rnd_ZA.MenosWidthPanel = 1;
            this.rnd_ZA.Name = "rnd_ZA";
            this.rnd_ZA.PorcLuzColorBorde = 0;
            this.rnd_ZA.Size = new System.Drawing.Size(130, 35);
            this.rnd_ZA.TabIndex = 23;
            this.tagsExtender1.SetTag2(this.rnd_ZA, null);
            this.tagsExtender1.SetTag3(this.rnd_ZA, null);
            this.tagsExtender1.SetTagFontName(this.rnd_ZA, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rnd_ZA, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rnd_ZA, System.Drawing.FontStyle.Regular);
            this.rnd_ZA.XBorde = 0;
            this.rnd_ZA.XPanel = 0;
            this.rnd_ZA.YBorde = 0;
            this.rnd_ZA.YPanel = 0;
            // 
            // btn_Antiguo
            // 
            this.btn_Antiguo.BackColor = System.Drawing.Color.White;
            this.btn_Antiguo.FlatAppearance.BorderSize = 0;
            this.btn_Antiguo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Antiguo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Antiguo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Antiguo.Location = new System.Drawing.Point(3, 3);
            this.btn_Antiguo.Name = "btn_Antiguo";
            this.btn_Antiguo.Size = new System.Drawing.Size(125, 30);
            this.btn_Antiguo.TabIndex = 7;
            this.tagsExtender1.SetTag2(this.btn_Antiguo, null);
            this.tagsExtender1.SetTag3(this.btn_Antiguo, null);
            this.tagsExtender1.SetTagFontName(this.btn_Antiguo, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btn_Antiguo, 12F);
            this.tagsExtender1.SetTagFontStyle(this.btn_Antiguo, System.Drawing.FontStyle.Bold);
            this.btn_Antiguo.Text = "Antiguo";
            this.btn_Antiguo.UseVisualStyleBackColor = false;
            this.btn_Antiguo.Click += new System.EventHandler(this.btn_Antiguo_Click);
            // 
            // rnd_Antiguo
            // 
            this.rnd_Antiguo.ArcRadiusBorde = 8;
            this.rnd_Antiguo.ArcRadiusPanel = 8;
            this.rnd_Antiguo.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rnd_Antiguo.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rnd_Antiguo.Controls.Add(this.btn_Antiguo);
            this.rnd_Antiguo.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rnd_Antiguo.Location = new System.Drawing.Point(308, 74);
            this.rnd_Antiguo.MenosHeightBorde = 1;
            this.rnd_Antiguo.MenosHeightPanel = 1;
            this.rnd_Antiguo.MenosWidthBorde = 1;
            this.rnd_Antiguo.MenosWidthPanel = 1;
            this.rnd_Antiguo.Name = "rnd_Antiguo";
            this.rnd_Antiguo.PorcLuzColorBorde = 0;
            this.rnd_Antiguo.Size = new System.Drawing.Size(130, 35);
            this.rnd_Antiguo.TabIndex = 24;
            this.tagsExtender1.SetTag2(this.rnd_Antiguo, null);
            this.tagsExtender1.SetTag3(this.rnd_Antiguo, null);
            this.tagsExtender1.SetTagFontName(this.rnd_Antiguo, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rnd_Antiguo, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rnd_Antiguo, System.Drawing.FontStyle.Regular);
            this.rnd_Antiguo.XBorde = 0;
            this.rnd_Antiguo.XPanel = 0;
            this.rnd_Antiguo.YBorde = 0;
            this.rnd_Antiguo.YPanel = 0;
            // 
            // btn_Reciente
            // 
            this.btn_Reciente.BackColor = System.Drawing.Color.White;
            this.btn_Reciente.FlatAppearance.BorderSize = 0;
            this.btn_Reciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reciente.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Reciente.Location = new System.Drawing.Point(3, 3);
            this.btn_Reciente.Name = "btn_Reciente";
            this.btn_Reciente.Size = new System.Drawing.Size(125, 30);
            this.btn_Reciente.TabIndex = 8;
            this.tagsExtender1.SetTag2(this.btn_Reciente, null);
            this.tagsExtender1.SetTag3(this.btn_Reciente, null);
            this.tagsExtender1.SetTagFontName(this.btn_Reciente, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btn_Reciente, 12F);
            this.tagsExtender1.SetTagFontStyle(this.btn_Reciente, System.Drawing.FontStyle.Bold);
            this.btn_Reciente.Text = "Reciente";
            this.btn_Reciente.UseVisualStyleBackColor = false;
            this.btn_Reciente.Click += new System.EventHandler(this.btn_Reciente_Click);
            // 
            // rnd_Reciente
            // 
            this.rnd_Reciente.ArcRadiusBorde = 8;
            this.rnd_Reciente.ArcRadiusPanel = 8;
            this.rnd_Reciente.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rnd_Reciente.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rnd_Reciente.Controls.Add(this.btn_Reciente);
            this.rnd_Reciente.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rnd_Reciente.Location = new System.Drawing.Point(444, 74);
            this.rnd_Reciente.MenosHeightBorde = 1;
            this.rnd_Reciente.MenosHeightPanel = 1;
            this.rnd_Reciente.MenosWidthBorde = 1;
            this.rnd_Reciente.MenosWidthPanel = 1;
            this.rnd_Reciente.Name = "rnd_Reciente";
            this.rnd_Reciente.PorcLuzColorBorde = 0;
            this.rnd_Reciente.Size = new System.Drawing.Size(130, 35);
            this.rnd_Reciente.TabIndex = 25;
            this.tagsExtender1.SetTag2(this.rnd_Reciente, null);
            this.tagsExtender1.SetTag3(this.rnd_Reciente, null);
            this.tagsExtender1.SetTagFontName(this.rnd_Reciente, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rnd_Reciente, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rnd_Reciente, System.Drawing.FontStyle.Regular);
            this.rnd_Reciente.XBorde = 0;
            this.rnd_Reciente.XPanel = 0;
            this.rnd_Reciente.YBorde = 0;
            this.rnd_Reciente.YPanel = 0;
            // 
            // rnd_AZ
            // 
            this.rnd_AZ.ArcRadiusBorde = 8;
            this.rnd_AZ.ArcRadiusPanel = 8;
            this.rnd_AZ.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rnd_AZ.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rnd_AZ.Controls.Add(this.btn_AZ);
            this.rnd_AZ.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rnd_AZ.Location = new System.Drawing.Point(36, 74);
            this.rnd_AZ.MenosHeightBorde = 1;
            this.rnd_AZ.MenosHeightPanel = 1;
            this.rnd_AZ.MenosWidthBorde = 1;
            this.rnd_AZ.MenosWidthPanel = 1;
            this.rnd_AZ.Name = "rnd_AZ";
            this.rnd_AZ.PorcLuzColorBorde = 0;
            this.rnd_AZ.Size = new System.Drawing.Size(130, 35);
            this.rnd_AZ.TabIndex = 22;
            this.tagsExtender1.SetTag2(this.rnd_AZ, null);
            this.tagsExtender1.SetTag3(this.rnd_AZ, null);
            this.tagsExtender1.SetTagFontName(this.rnd_AZ, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rnd_AZ, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rnd_AZ, System.Drawing.FontStyle.Regular);
            this.rnd_AZ.XBorde = 0;
            this.rnd_AZ.XPanel = 0;
            this.rnd_AZ.YBorde = 0;
            this.rnd_AZ.YPanel = 0;
            // 
            // btn_AZ
            // 
            this.btn_AZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.btn_AZ.FlatAppearance.BorderSize = 0;
            this.btn_AZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AZ.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_AZ.Location = new System.Drawing.Point(3, 3);
            this.btn_AZ.Name = "btn_AZ";
            this.btn_AZ.Size = new System.Drawing.Size(125, 30);
            this.btn_AZ.TabIndex = 5;
            this.tagsExtender1.SetTag2(this.btn_AZ, null);
            this.tagsExtender1.SetTag3(this.btn_AZ, null);
            this.tagsExtender1.SetTagFontName(this.btn_AZ, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btn_AZ, 12F);
            this.tagsExtender1.SetTagFontStyle(this.btn_AZ, System.Drawing.FontStyle.Bold);
            this.btn_AZ.Text = "A - Z";
            this.btn_AZ.UseVisualStyleBackColor = false;
            this.btn_AZ.Click += new System.EventHandler(this.btn_AZ_Click);
            // 
            // pantallaActualizarSedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.roundedPanel4);
            this.Controls.Add(this.rpTopMain);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.rpn_ListaDrivers);
            this.Controls.Add(this.rnd_Reciente);
            this.Controls.Add(this.rnd_Antiguo);
            this.Controls.Add(this.rnd_ZA);
            this.Controls.Add(this.rnd_AZ);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBuscar);
            this.Name = "pantallaActualizarSedes";
            this.Size = new System.Drawing.Size(611, 470);
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.rpn_ListaDrivers.ResumeLayout(false);
            this.rpn_ListaDrivers.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlBuscar.ResumeLayout(false);
            this.rnd_ZA.ResumeLayout(false);
            this.rnd_Antiguo.ResumeLayout(false);
            this.rnd_Reciente.ResumeLayout(false);
            this.rnd_AZ.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private itemLista il_Sedes2;
        private itemLista il_Sedes1;
        private RoundedPanel rpn_ListaDrivers;
        private System.Windows.Forms.Button btn_AgregarSede;
        private System.Windows.Forms.Label lbl_ListaSedes;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Panel panel1;
        private TagsExtender tagsExtender1;
        private RoundedPanel rpTopMain;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Panel panel2;
        private RoundedPanel roundedPanel4;
        private System.Windows.Forms.Button btn_ZA;
        private RoundedPanel rnd_ZA;
        private System.Windows.Forms.Button btn_Antiguo;
        private RoundedPanel rnd_Antiguo;
        private System.Windows.Forms.Button btn_Reciente;
        private RoundedPanel rnd_Reciente;
        private RoundedPanel rnd_AZ;
        private System.Windows.Forms.Button btn_AZ;
    }
}
