namespace LP2MegaAutos.Informacion.Vehiculos
{
    partial class frmEditarVehiculo
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
            this.title_bar = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.boton_minimizar = new System.Windows.Forms.Button();
            this.boton_cerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rnd_color_5 = new LP2MegaAutos.RoundedPanel();
            this.rnd_cancelar = new LP2MegaAutos.RoundedPanel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.rnd_guardar = new LP2MegaAutos.RoundedPanel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_EditarVehiculo = new System.Windows.Forms.Label();
            this.rpTopMain = new LP2MegaAutos.RoundedPanel();
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.pnl_TipoVehiculo = new System.Windows.Forms.Panel();
            this.rnd_color_3 = new LP2MegaAutos.RoundedPanel();
            this.txt_TipoVehiculo = new System.Windows.Forms.TextBox();
            this.lbl_TipoVehiculo = new System.Windows.Forms.Label();
            this.pnl_nombCliente = new System.Windows.Forms.Panel();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.rnd_color_2 = new LP2MegaAutos.RoundedPanel();
            this.lbl_nombCliente = new System.Windows.Forms.Label();
            this.pnl_placaVehiculo = new System.Windows.Forms.Panel();
            this.rnd_color_1 = new LP2MegaAutos.RoundedPanel();
            this.txt_placaVehiculo = new System.Windows.Forms.TextBox();
            this.lbl_placaVehiculo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.title_bar.SuspendLayout();
            this.rnd_cancelar.SuspendLayout();
            this.rnd_guardar.SuspendLayout();
            this.pnl_TipoVehiculo.SuspendLayout();
            this.pnl_nombCliente.SuspendLayout();
            this.pnl_placaVehiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_bar
            // 
            this.title_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.title_bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title_bar.Controls.Add(this.button3);
            this.title_bar.Controls.Add(this.boton_minimizar);
            this.title_bar.Controls.Add(this.boton_cerrar);
            this.title_bar.Location = new System.Drawing.Point(0, 0);
            this.title_bar.Name = "title_bar";
            this.title_bar.Size = new System.Drawing.Size(595, 24);
            this.title_bar.TabIndex = 75;
            this.title_bar.Tag = "titlebar";
            this.tagsExtender1.SetTag2(this.title_bar, null);
            this.tagsExtender1.SetTag3(this.title_bar, null);
            this.tagsExtender1.SetTagFontName(this.title_bar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.title_bar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.title_bar, System.Drawing.FontStyle.Regular);
            this.title_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseDown);
            this.title_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseMove);
            this.title_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseUp);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.BackgroundImage = global::LP2MegaAutos.Properties.Resources.boton_cerrar;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(33)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(33)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(574, -1);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 24);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.button3.Tag = "titlebar";
            this.tagsExtender1.SetTag2(this.button3, null);
            this.tagsExtender1.SetTag3(this.button3, null);
            this.tagsExtender1.SetTagFontName(this.button3, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.button3, 10F);
            this.tagsExtender1.SetTagFontStyle(this.button3, System.Drawing.FontStyle.Regular);
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.boton_cerrar_MouseClick);
            // 
            // boton_minimizar
            // 
            this.boton_minimizar.BackgroundImage = global::LP2MegaAutos.Properties.Resources.boton_minimizar;
            this.boton_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boton_minimizar.FlatAppearance.BorderSize = 0;
            this.boton_minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.boton_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.boton_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_minimizar.Location = new System.Drawing.Point(787, 0);
            this.boton_minimizar.Name = "boton_minimizar";
            this.boton_minimizar.Size = new System.Drawing.Size(24, 24);
            this.boton_minimizar.TabIndex = 0;
            this.boton_minimizar.TabStop = false;
            this.boton_minimizar.Tag = "titlebar";
            this.tagsExtender1.SetTag2(this.boton_minimizar, null);
            this.tagsExtender1.SetTag3(this.boton_minimizar, null);
            this.tagsExtender1.SetTagFontName(this.boton_minimizar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.boton_minimizar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.boton_minimizar, System.Drawing.FontStyle.Regular);
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
            this.boton_cerrar.Location = new System.Drawing.Point(811, 0);
            this.boton_cerrar.Margin = new System.Windows.Forms.Padding(0);
            this.boton_cerrar.Name = "boton_cerrar";
            this.boton_cerrar.Size = new System.Drawing.Size(24, 24);
            this.boton_cerrar.TabIndex = 0;
            this.boton_cerrar.TabStop = false;
            this.boton_cerrar.Tag = "titlebar";
            this.tagsExtender1.SetTag2(this.boton_cerrar, null);
            this.tagsExtender1.SetTag3(this.boton_cerrar, null);
            this.tagsExtender1.SetTagFontName(this.boton_cerrar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.boton_cerrar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.boton_cerrar, System.Drawing.FontStyle.Regular);
            this.boton_cerrar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 2);
            this.panel1.TabIndex = 77;
            this.tagsExtender1.SetTag2(this.panel1, null);
            this.tagsExtender1.SetTag3(this.panel1, null);
            this.tagsExtender1.SetTagFontName(this.panel1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.panel1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.panel1, System.Drawing.FontStyle.Regular);
            // 
            // rnd_color_5
            // 
            this.rnd_color_5.ArcRadiusBorde = 15;
            this.rnd_color_5.ArcRadiusPanel = 15;
            this.rnd_color_5.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rnd_color_5.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rnd_color_5.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rnd_color_5.Location = new System.Drawing.Point(40, 40);
            this.rnd_color_5.MenosHeightBorde = 1;
            this.rnd_color_5.MenosHeightPanel = 1;
            this.rnd_color_5.MenosWidthBorde = 1;
            this.rnd_color_5.MenosWidthPanel = 1;
            this.rnd_color_5.Name = "rnd_color_5";
            this.rnd_color_5.PorcLuzColorBorde = 0;
            this.rnd_color_5.Size = new System.Drawing.Size(3, 36);
            this.rnd_color_5.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.rnd_color_5, null);
            this.tagsExtender1.SetTag3(this.rnd_color_5, null);
            this.tagsExtender1.SetTagFontName(this.rnd_color_5, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rnd_color_5, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rnd_color_5, System.Drawing.FontStyle.Regular);
            this.rnd_color_5.XBorde = 0;
            this.rnd_color_5.XPanel = 0;
            this.rnd_color_5.YBorde = 0;
            this.rnd_color_5.YPanel = 0;
            // 
            // rnd_cancelar
            // 
            this.rnd_cancelar.ArcRadiusBorde = 5;
            this.rnd_cancelar.ArcRadiusPanel = 5;
            this.rnd_cancelar.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rnd_cancelar.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rnd_cancelar.Controls.Add(this.btn_cancelar);
            this.rnd_cancelar.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rnd_cancelar.Location = new System.Drawing.Point(71, 293);
            this.rnd_cancelar.MenosHeightBorde = 1;
            this.rnd_cancelar.MenosHeightPanel = 1;
            this.rnd_cancelar.MenosWidthBorde = 1;
            this.rnd_cancelar.MenosWidthPanel = 1;
            this.rnd_cancelar.Name = "rnd_cancelar";
            this.rnd_cancelar.PorcLuzColorBorde = 0;
            this.rnd_cancelar.Size = new System.Drawing.Size(180, 35);
            this.rnd_cancelar.TabIndex = 79;
            this.tagsExtender1.SetTag2(this.rnd_cancelar, null);
            this.tagsExtender1.SetTag3(this.rnd_cancelar, null);
            this.tagsExtender1.SetTagFontName(this.rnd_cancelar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rnd_cancelar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rnd_cancelar, System.Drawing.FontStyle.Regular);
            this.rnd_cancelar.XBorde = 0;
            this.rnd_cancelar.XPanel = 0;
            this.rnd_cancelar.YBorde = 0;
            this.rnd_cancelar.YPanel = 0;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(1, 1);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(178, 33);
            this.btn_cancelar.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.btn_cancelar, null);
            this.tagsExtender1.SetTag3(this.btn_cancelar, null);
            this.tagsExtender1.SetTagFontName(this.btn_cancelar, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.btn_cancelar, 15F);
            this.tagsExtender1.SetTagFontStyle(this.btn_cancelar, System.Drawing.FontStyle.Bold);
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // rnd_guardar
            // 
            this.rnd_guardar.ArcRadiusBorde = 5;
            this.rnd_guardar.ArcRadiusPanel = 5;
            this.rnd_guardar.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rnd_guardar.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rnd_guardar.Controls.Add(this.btn_guardar);
            this.rnd_guardar.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rnd_guardar.Location = new System.Drawing.Point(363, 293);
            this.rnd_guardar.MenosHeightBorde = 1;
            this.rnd_guardar.MenosHeightPanel = 1;
            this.rnd_guardar.MenosWidthBorde = 1;
            this.rnd_guardar.MenosWidthPanel = 1;
            this.rnd_guardar.Name = "rnd_guardar";
            this.rnd_guardar.PorcLuzColorBorde = 0;
            this.rnd_guardar.Size = new System.Drawing.Size(180, 35);
            this.rnd_guardar.TabIndex = 78;
            this.tagsExtender1.SetTag2(this.rnd_guardar, null);
            this.tagsExtender1.SetTag3(this.rnd_guardar, null);
            this.tagsExtender1.SetTagFontName(this.rnd_guardar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rnd_guardar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rnd_guardar, System.Drawing.FontStyle.Regular);
            this.rnd_guardar.XBorde = 0;
            this.rnd_guardar.XPanel = 0;
            this.rnd_guardar.YBorde = 0;
            this.rnd_guardar.YPanel = 0;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(1, 1);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(178, 33);
            this.btn_guardar.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.btn_guardar, null);
            this.tagsExtender1.SetTag3(this.btn_guardar, null);
            this.tagsExtender1.SetTagFontName(this.btn_guardar, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.btn_guardar, 15F);
            this.tagsExtender1.SetTagFontStyle(this.btn_guardar, System.Drawing.FontStyle.Bold);
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_EditarVehiculo
            // 
            this.lbl_EditarVehiculo.AutoSize = true;
            this.lbl_EditarVehiculo.BackColor = System.Drawing.Color.White;
            this.lbl_EditarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_EditarVehiculo.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EditarVehiculo.ForeColor = System.Drawing.Color.Black;
            this.lbl_EditarVehiculo.Location = new System.Drawing.Point(27, 42);
            this.lbl_EditarVehiculo.Name = "lbl_EditarVehiculo";
            this.lbl_EditarVehiculo.Size = new System.Drawing.Size(0, 35);
            this.lbl_EditarVehiculo.TabIndex = 80;
            this.tagsExtender1.SetTag2(this.lbl_EditarVehiculo, null);
            this.tagsExtender1.SetTag3(this.lbl_EditarVehiculo, null);
            this.tagsExtender1.SetTagFontName(this.lbl_EditarVehiculo, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lbl_EditarVehiculo, 22F);
            this.tagsExtender1.SetTagFontStyle(this.lbl_EditarVehiculo, System.Drawing.FontStyle.Bold);
            this.lbl_EditarVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rpTopMain
            // 
            this.rpTopMain.ArcRadiusBorde = 15;
            this.rpTopMain.ArcRadiusPanel = 15;
            this.rpTopMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpTopMain.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpTopMain.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.rpTopMain.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.None;
            this.rpTopMain.Location = new System.Drawing.Point(0, 24);
            this.rpTopMain.MenosHeightBorde = 1;
            this.rpTopMain.MenosHeightPanel = 1;
            this.rpTopMain.MenosWidthBorde = 1;
            this.rpTopMain.MenosWidthPanel = 1;
            this.rpTopMain.Name = "rpTopMain";
            this.rpTopMain.PorcLuzColorBorde = 0;
            this.rpTopMain.Size = new System.Drawing.Size(595, 8);
            this.rpTopMain.TabIndex = 74;
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
            // pnl_TipoVehiculo
            // 
            this.pnl_TipoVehiculo.Controls.Add(this.rnd_color_3);
            this.pnl_TipoVehiculo.Controls.Add(this.txt_TipoVehiculo);
            this.pnl_TipoVehiculo.Controls.Add(this.lbl_TipoVehiculo);
            this.pnl_TipoVehiculo.Location = new System.Drawing.Point(161, 222);
            this.pnl_TipoVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_TipoVehiculo.Name = "pnl_TipoVehiculo";
            this.pnl_TipoVehiculo.Size = new System.Drawing.Size(292, 41);
            this.pnl_TipoVehiculo.TabIndex = 82;
            this.tagsExtender1.SetTag2(this.pnl_TipoVehiculo, null);
            this.tagsExtender1.SetTag3(this.pnl_TipoVehiculo, null);
            this.tagsExtender1.SetTagFontName(this.pnl_TipoVehiculo, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.pnl_TipoVehiculo, 10F);
            this.tagsExtender1.SetTagFontStyle(this.pnl_TipoVehiculo, System.Drawing.FontStyle.Regular);
            // 
            // rnd_color_3
            // 
            this.rnd_color_3.ArcRadiusBorde = 15;
            this.rnd_color_3.ArcRadiusPanel = 15;
            this.rnd_color_3.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rnd_color_3.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rnd_color_3.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rnd_color_3.Location = new System.Drawing.Point(1, 4);
            this.rnd_color_3.MenosHeightBorde = 1;
            this.rnd_color_3.MenosHeightPanel = 1;
            this.rnd_color_3.MenosWidthBorde = 1;
            this.rnd_color_3.MenosWidthPanel = 1;
            this.rnd_color_3.Name = "rnd_color_3";
            this.rnd_color_3.PorcLuzColorBorde = 0;
            this.rnd_color_3.Size = new System.Drawing.Size(3, 36);
            this.rnd_color_3.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.rnd_color_3, null);
            this.tagsExtender1.SetTag3(this.rnd_color_3, null);
            this.tagsExtender1.SetTagFontName(this.rnd_color_3, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rnd_color_3, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rnd_color_3, System.Drawing.FontStyle.Regular);
            this.rnd_color_3.XBorde = 0;
            this.rnd_color_3.XPanel = 0;
            this.rnd_color_3.YBorde = 0;
            this.rnd_color_3.YPanel = 0;
            // 
            // txt_TipoVehiculo
            // 
            this.txt_TipoVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txt_TipoVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TipoVehiculo.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TipoVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt_TipoVehiculo.Location = new System.Drawing.Point(6, 18);
            this.txt_TipoVehiculo.Name = "txt_TipoVehiculo";
            this.txt_TipoVehiculo.Size = new System.Drawing.Size(284, 23);
            this.txt_TipoVehiculo.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.txt_TipoVehiculo, null);
            this.tagsExtender1.SetTag3(this.txt_TipoVehiculo, null);
            this.tagsExtender1.SetTagFontName(this.txt_TipoVehiculo, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.txt_TipoVehiculo, 14F);
            this.tagsExtender1.SetTagFontStyle(this.txt_TipoVehiculo, System.Drawing.FontStyle.Bold);
            // 
            // lbl_TipoVehiculo
            // 
            this.lbl_TipoVehiculo.AutoSize = true;
            this.lbl_TipoVehiculo.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_TipoVehiculo.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbl_TipoVehiculo.Location = new System.Drawing.Point(3, 2);
            this.lbl_TipoVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TipoVehiculo.Name = "lbl_TipoVehiculo";
            this.lbl_TipoVehiculo.Size = new System.Drawing.Size(84, 16);
            this.lbl_TipoVehiculo.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.lbl_TipoVehiculo, null);
            this.tagsExtender1.SetTag3(this.lbl_TipoVehiculo, null);
            this.tagsExtender1.SetTagFontName(this.lbl_TipoVehiculo, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.lbl_TipoVehiculo, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lbl_TipoVehiculo, System.Drawing.FontStyle.Bold);
            this.lbl_TipoVehiculo.Text = "Tipo Vehiculo";
            // 
            // pnl_nombCliente
            // 
            this.pnl_nombCliente.Controls.Add(this.cboTipoCliente);
            this.pnl_nombCliente.Controls.Add(this.rnd_color_2);
            this.pnl_nombCliente.Controls.Add(this.lbl_nombCliente);
            this.pnl_nombCliente.Location = new System.Drawing.Point(161, 161);
            this.pnl_nombCliente.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_nombCliente.Name = "pnl_nombCliente";
            this.pnl_nombCliente.Size = new System.Drawing.Size(292, 41);
            this.pnl_nombCliente.TabIndex = 81;
            this.tagsExtender1.SetTag2(this.pnl_nombCliente, null);
            this.tagsExtender1.SetTag3(this.pnl_nombCliente, null);
            this.tagsExtender1.SetTagFontName(this.pnl_nombCliente, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.pnl_nombCliente, 10F);
            this.tagsExtender1.SetTagFontStyle(this.pnl_nombCliente, System.Drawing.FontStyle.Regular);
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.cboTipoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoCliente.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Location = new System.Drawing.Point(4, 16);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(286, 24);
            this.cboTipoCliente.TabIndex = 84;
            this.tagsExtender1.SetTag2(this.cboTipoCliente, null);
            this.tagsExtender1.SetTag3(this.cboTipoCliente, null);
            this.tagsExtender1.SetTagFontName(this.cboTipoCliente, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.cboTipoCliente, 10F);
            this.tagsExtender1.SetTagFontStyle(this.cboTipoCliente, System.Drawing.FontStyle.Bold);
            this.cboTipoCliente.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cboTipoCliente_Format);
            // 
            // rnd_color_2
            // 
            this.rnd_color_2.ArcRadiusBorde = 15;
            this.rnd_color_2.ArcRadiusPanel = 15;
            this.rnd_color_2.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rnd_color_2.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rnd_color_2.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rnd_color_2.Location = new System.Drawing.Point(1, 4);
            this.rnd_color_2.MenosHeightBorde = 1;
            this.rnd_color_2.MenosHeightPanel = 1;
            this.rnd_color_2.MenosWidthBorde = 1;
            this.rnd_color_2.MenosWidthPanel = 1;
            this.rnd_color_2.Name = "rnd_color_2";
            this.rnd_color_2.PorcLuzColorBorde = 0;
            this.rnd_color_2.Size = new System.Drawing.Size(3, 36);
            this.rnd_color_2.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.rnd_color_2, null);
            this.tagsExtender1.SetTag3(this.rnd_color_2, null);
            this.tagsExtender1.SetTagFontName(this.rnd_color_2, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rnd_color_2, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rnd_color_2, System.Drawing.FontStyle.Regular);
            this.rnd_color_2.XBorde = 0;
            this.rnd_color_2.XPanel = 0;
            this.rnd_color_2.YBorde = 0;
            this.rnd_color_2.YPanel = 0;
            // 
            // lbl_nombCliente
            // 
            this.lbl_nombCliente.AutoSize = true;
            this.lbl_nombCliente.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_nombCliente.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbl_nombCliente.Location = new System.Drawing.Point(3, 2);
            this.lbl_nombCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombCliente.Name = "lbl_nombCliente";
            this.lbl_nombCliente.Size = new System.Drawing.Size(49, 16);
            this.lbl_nombCliente.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.lbl_nombCliente, null);
            this.tagsExtender1.SetTag3(this.lbl_nombCliente, null);
            this.tagsExtender1.SetTagFontName(this.lbl_nombCliente, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.lbl_nombCliente, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lbl_nombCliente, System.Drawing.FontStyle.Bold);
            this.lbl_nombCliente.Text = "Cliente";
            // 
            // pnl_placaVehiculo
            // 
            this.pnl_placaVehiculo.Controls.Add(this.rnd_color_1);
            this.pnl_placaVehiculo.Controls.Add(this.txt_placaVehiculo);
            this.pnl_placaVehiculo.Controls.Add(this.lbl_placaVehiculo);
            this.pnl_placaVehiculo.Location = new System.Drawing.Point(161, 100);
            this.pnl_placaVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_placaVehiculo.Name = "pnl_placaVehiculo";
            this.pnl_placaVehiculo.Size = new System.Drawing.Size(292, 41);
            this.pnl_placaVehiculo.TabIndex = 83;
            this.tagsExtender1.SetTag2(this.pnl_placaVehiculo, null);
            this.tagsExtender1.SetTag3(this.pnl_placaVehiculo, null);
            this.tagsExtender1.SetTagFontName(this.pnl_placaVehiculo, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.pnl_placaVehiculo, 10F);
            this.tagsExtender1.SetTagFontStyle(this.pnl_placaVehiculo, System.Drawing.FontStyle.Regular);
            // 
            // rnd_color_1
            // 
            this.rnd_color_1.ArcRadiusBorde = 15;
            this.rnd_color_1.ArcRadiusPanel = 15;
            this.rnd_color_1.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rnd_color_1.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rnd_color_1.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rnd_color_1.Location = new System.Drawing.Point(1, 4);
            this.rnd_color_1.MenosHeightBorde = 1;
            this.rnd_color_1.MenosHeightPanel = 1;
            this.rnd_color_1.MenosWidthBorde = 1;
            this.rnd_color_1.MenosWidthPanel = 1;
            this.rnd_color_1.Name = "rnd_color_1";
            this.rnd_color_1.PorcLuzColorBorde = 0;
            this.rnd_color_1.Size = new System.Drawing.Size(3, 36);
            this.rnd_color_1.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.rnd_color_1, null);
            this.tagsExtender1.SetTag3(this.rnd_color_1, null);
            this.tagsExtender1.SetTagFontName(this.rnd_color_1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rnd_color_1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rnd_color_1, System.Drawing.FontStyle.Regular);
            this.rnd_color_1.XBorde = 0;
            this.rnd_color_1.XPanel = 0;
            this.rnd_color_1.YBorde = 0;
            this.rnd_color_1.YPanel = 0;
            // 
            // txt_placaVehiculo
            // 
            this.txt_placaVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txt_placaVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_placaVehiculo.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_placaVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt_placaVehiculo.Location = new System.Drawing.Point(6, 18);
            this.txt_placaVehiculo.Name = "txt_placaVehiculo";
            this.txt_placaVehiculo.Size = new System.Drawing.Size(284, 23);
            this.txt_placaVehiculo.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.txt_placaVehiculo, null);
            this.tagsExtender1.SetTag3(this.txt_placaVehiculo, null);
            this.tagsExtender1.SetTagFontName(this.txt_placaVehiculo, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.txt_placaVehiculo, 14F);
            this.tagsExtender1.SetTagFontStyle(this.txt_placaVehiculo, System.Drawing.FontStyle.Bold);
            // 
            // lbl_placaVehiculo
            // 
            this.lbl_placaVehiculo.AutoSize = true;
            this.lbl_placaVehiculo.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_placaVehiculo.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placaVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbl_placaVehiculo.Location = new System.Drawing.Point(3, 2);
            this.lbl_placaVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_placaVehiculo.Name = "lbl_placaVehiculo";
            this.lbl_placaVehiculo.Size = new System.Drawing.Size(90, 16);
            this.lbl_placaVehiculo.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.lbl_placaVehiculo, null);
            this.tagsExtender1.SetTag3(this.lbl_placaVehiculo, null);
            this.tagsExtender1.SetTagFontName(this.lbl_placaVehiculo, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lbl_placaVehiculo, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lbl_placaVehiculo, System.Drawing.FontStyle.Bold);
            this.lbl_placaVehiculo.Text = "Placa Vehículo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = global::LP2MegaAutos.Properties.Resources.Driver;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(555, 49);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(28, 28);
            this.btnEliminar.TabIndex = 68;
            this.tagsExtender1.SetTag2(this.btnEliminar, null);
            this.tagsExtender1.SetTag3(this.btnEliminar, null);
            this.tagsExtender1.SetTagFontName(this.btnEliminar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnEliminar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btnEliminar, System.Drawing.FontStyle.Regular);
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImage = global::LP2MegaAutos.Properties.Resources.editar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(514, 49);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(28, 28);
            this.btnEditar.TabIndex = 67;
            this.tagsExtender1.SetTag2(this.btnEditar, null);
            this.tagsExtender1.SetTag3(this.btnEditar, null);
            this.tagsExtender1.SetTagFontName(this.btnEditar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnEditar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btnEditar, System.Drawing.FontStyle.Regular);
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmEditarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 350);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pnl_placaVehiculo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pnl_TipoVehiculo);
            this.Controls.Add(this.pnl_nombCliente);
            this.Controls.Add(this.title_bar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rnd_cancelar);
            this.Controls.Add(this.rnd_guardar);
            this.Controls.Add(this.lbl_EditarVehiculo);
            this.Controls.Add(this.rpTopMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditarVehiculo";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.title_bar.ResumeLayout(false);
            this.rnd_cancelar.ResumeLayout(false);
            this.rnd_guardar.ResumeLayout(false);
            this.pnl_TipoVehiculo.ResumeLayout(false);
            this.pnl_TipoVehiculo.PerformLayout();
            this.pnl_nombCliente.ResumeLayout(false);
            this.pnl_nombCliente.PerformLayout();
            this.pnl_placaVehiculo.ResumeLayout(false);
            this.pnl_placaVehiculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button boton_minimizar;
        private System.Windows.Forms.Button boton_cerrar;
        private System.Windows.Forms.Panel panel1;
        private RoundedPanel rnd_color_5;
        private RoundedPanel rnd_cancelar;
        private System.Windows.Forms.Button btn_cancelar;
        private RoundedPanel rnd_guardar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_EditarVehiculo;
        private RoundedPanel rpTopMain;
        private TagsExtender tagsExtender1;
        private System.Windows.Forms.Panel pnl_TipoVehiculo;
        private RoundedPanel rnd_color_3;
        private System.Windows.Forms.TextBox txt_TipoVehiculo;
        private System.Windows.Forms.Label lbl_TipoVehiculo;
        private System.Windows.Forms.Panel pnl_nombCliente;
        private RoundedPanel rnd_color_2;
        private System.Windows.Forms.Label lbl_nombCliente;
        private System.Windows.Forms.Panel pnl_placaVehiculo;
        private RoundedPanel rnd_color_1;
        private System.Windows.Forms.TextBox txt_placaVehiculo;
        private System.Windows.Forms.Label lbl_placaVehiculo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cboTipoCliente;
    }
}