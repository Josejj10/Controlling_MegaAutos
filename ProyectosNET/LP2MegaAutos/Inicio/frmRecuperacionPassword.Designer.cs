namespace LP2MegaAutos.Inicio
{
    partial class frmRecuperacionPassword
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
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.rpTopMain = new LP2MegaAutos.RoundedPanel();
            this.title_bar = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.boton_minimizar = new System.Windows.Forms.Button();
            this.boton_cerrar = new System.Windows.Forms.Button();
            this.rnd_cancelar = new LP2MegaAutos.RoundedPanel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.rnd_guardar = new LP2MegaAutos.RoundedPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbl_nombreEmpresa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_codServ = new System.Windows.Forms.Panel();
            this.rnd_color_1 = new LP2MegaAutos.RoundedPanel();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new LP2MegaAutos.RoundedPanel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.roundedPanel2 = new LP2MegaAutos.RoundedPanel();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedPanel3 = new LP2MegaAutos.RoundedPanel();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.roundedPanel4 = new LP2MegaAutos.RoundedPanel();
            this.btnReenviar = new System.Windows.Forms.Button();
            this.title_bar.SuspendLayout();
            this.rnd_cancelar.SuspendLayout();
            this.rnd_guardar.SuspendLayout();
            this.pnl_codServ.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            this.SuspendLayout();
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
            this.title_bar.TabIndex = 59;
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
            this.button3.Location = new System.Drawing.Point(571, -1);
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
            this.boton_minimizar.Location = new System.Drawing.Point(784, 0);
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
            this.boton_cerrar.Location = new System.Drawing.Point(808, 0);
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
            // rnd_cancelar
            // 
            this.rnd_cancelar.ArcRadiusBorde = 5;
            this.rnd_cancelar.ArcRadiusPanel = 5;
            this.rnd_cancelar.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rnd_cancelar.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rnd_cancelar.Controls.Add(this.btn_cancelar);
            this.rnd_cancelar.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rnd_cancelar.Location = new System.Drawing.Point(306, 365);
            this.rnd_cancelar.MenosHeightBorde = 1;
            this.rnd_cancelar.MenosHeightPanel = 1;
            this.rnd_cancelar.MenosWidthBorde = 1;
            this.rnd_cancelar.MenosWidthPanel = 1;
            this.rnd_cancelar.Name = "rnd_cancelar";
            this.rnd_cancelar.PorcLuzColorBorde = 0;
            this.rnd_cancelar.Size = new System.Drawing.Size(180, 35);
            this.rnd_cancelar.TabIndex = 61;
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
            this.tagsExtender1.SetTagFontName(this.btn_cancelar, fontsD.Ninguno);
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
            this.rnd_guardar.Controls.Add(this.btnAceptar);
            this.rnd_guardar.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rnd_guardar.Location = new System.Drawing.Point(108, 365);
            this.rnd_guardar.MenosHeightBorde = 1;
            this.rnd_guardar.MenosHeightPanel = 1;
            this.rnd_guardar.MenosWidthBorde = 1;
            this.rnd_guardar.MenosWidthPanel = 1;
            this.rnd_guardar.Name = "rnd_guardar";
            this.rnd_guardar.PorcLuzColorBorde = 0;
            this.rnd_guardar.Size = new System.Drawing.Size(180, 35);
            this.rnd_guardar.TabIndex = 60;
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
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(1, 1);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(178, 33);
            this.btnAceptar.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.btnAceptar, null);
            this.tagsExtender1.SetTag3(this.btnAceptar, null);
            this.tagsExtender1.SetTagFontName(this.btnAceptar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnAceptar, 15F);
            this.tagsExtender1.SetTagFontStyle(this.btnAceptar, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbl_nombreEmpresa
            // 
            this.lbl_nombreEmpresa.AutoSize = true;
            this.lbl_nombreEmpresa.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.lbl_nombreEmpresa.Location = new System.Drawing.Point(106, 40);
            this.lbl_nombreEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombreEmpresa.Name = "lbl_nombreEmpresa";
            this.lbl_nombreEmpresa.Size = new System.Drawing.Size(382, 35);
            this.lbl_nombreEmpresa.TabIndex = 65;
            this.tagsExtender1.SetTag2(this.lbl_nombreEmpresa, null);
            this.tagsExtender1.SetTag3(this.lbl_nombreEmpresa, null);
            this.tagsExtender1.SetTagFontName(this.lbl_nombreEmpresa, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lbl_nombreEmpresa, 22F);
            this.tagsExtender1.SetTagFontStyle(this.lbl_nombreEmpresa, System.Drawing.FontStyle.Bold);
            this.lbl_nombreEmpresa.Text = "Recuperación de Contraseña";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panel1.Location = new System.Drawing.Point(47, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 2);
            this.panel1.TabIndex = 63;
            this.tagsExtender1.SetTag2(this.panel1, null);
            this.tagsExtender1.SetTag3(this.panel1, null);
            this.tagsExtender1.SetTagFontName(this.panel1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.panel1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.panel1, System.Drawing.FontStyle.Regular);
            // 
            // pnl_codServ
            // 
            this.pnl_codServ.Controls.Add(this.rnd_color_1);
            this.pnl_codServ.Controls.Add(this.txtToken);
            this.pnl_codServ.Controls.Add(this.lblCorreo);
            this.pnl_codServ.Location = new System.Drawing.Point(151, 141);
            this.pnl_codServ.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_codServ.Name = "pnl_codServ";
            this.pnl_codServ.Size = new System.Drawing.Size(292, 41);
            this.pnl_codServ.TabIndex = 62;
            this.tagsExtender1.SetTag2(this.pnl_codServ, null);
            this.tagsExtender1.SetTag3(this.pnl_codServ, null);
            this.tagsExtender1.SetTagFontName(this.pnl_codServ, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.pnl_codServ, 10F);
            this.tagsExtender1.SetTagFontStyle(this.pnl_codServ, System.Drawing.FontStyle.Regular);
            // 
            // rnd_color_1
            // 
            this.rnd_color_1.ArcRadiusBorde = 15;
            this.rnd_color_1.ArcRadiusPanel = 15;
            this.rnd_color_1.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rnd_color_1.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rnd_color_1.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rnd_color_1.Location = new System.Drawing.Point(2, 4);
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
            // txtToken
            // 
            this.txtToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtToken.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToken.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtToken.Location = new System.Drawing.Point(7, 18);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(284, 23);
            this.txtToken.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.txtToken, null);
            this.tagsExtender1.SetTag3(this.txtToken, null);
            this.tagsExtender1.SetTagFontName(this.txtToken, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.txtToken, 14F);
            this.tagsExtender1.SetTagFontStyle(this.txtToken, System.Drawing.FontStyle.Bold);
            this.txtToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblCorreo.Location = new System.Drawing.Point(4, 2);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(42, 16);
            this.lblCorreo.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.lblCorreo, null);
            this.tagsExtender1.SetTag3(this.lblCorreo, null);
            this.tagsExtender1.SetTagFontName(this.lblCorreo, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.lblCorreo, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lblCorreo, System.Drawing.FontStyle.Bold);
            this.lblCorreo.Text = "Token";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.roundedPanel1);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(151, 245);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 41);
            this.panel2.TabIndex = 66;
            this.tagsExtender1.SetTag2(this.panel2, null);
            this.tagsExtender1.SetTag3(this.panel2, null);
            this.tagsExtender1.SetTagFontName(this.panel2, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.panel2, 10F);
            this.tagsExtender1.SetTagFontStyle(this.panel2, System.Drawing.FontStyle.Regular);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.ArcRadiusBorde = 15;
            this.roundedPanel1.ArcRadiusPanel = 15;
            this.roundedPanel1.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.roundedPanel1.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.roundedPanel1.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.roundedPanel1.Location = new System.Drawing.Point(2, 4);
            this.roundedPanel1.MenosHeightBorde = 1;
            this.roundedPanel1.MenosHeightPanel = 1;
            this.roundedPanel1.MenosWidthBorde = 1;
            this.roundedPanel1.MenosWidthPanel = 1;
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.PorcLuzColorBorde = 0;
            this.roundedPanel1.Size = new System.Drawing.Size(3, 36);
            this.roundedPanel1.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.roundedPanel1, null);
            this.tagsExtender1.SetTag3(this.roundedPanel1, null);
            this.tagsExtender1.SetTagFontName(this.roundedPanel1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.roundedPanel1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.roundedPanel1, System.Drawing.FontStyle.Regular);
            this.roundedPanel1.XBorde = 0;
            this.roundedPanel1.XPanel = 0;
            this.roundedPanel1.YBorde = 0;
            this.roundedPanel1.YPanel = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtPassword.Location = new System.Drawing.Point(7, 18);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(284, 23);
            this.txtPassword.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.txtPassword, null);
            this.tagsExtender1.SetTag3(this.txtPassword, null);
            this.tagsExtender1.SetTagFontName(this.txtPassword, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.txtPassword, 14F);
            this.tagsExtender1.SetTagFontStyle(this.txtPassword, System.Drawing.FontStyle.Bold);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.label1, null);
            this.tagsExtender1.SetTag3(this.label1, null);
            this.tagsExtender1.SetTagFontName(this.label1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.label1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.label1, System.Drawing.FontStyle.Bold);
            this.label1.Text = "Contraseña";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.roundedPanel2);
            this.panel3.Controls.Add(this.txtNewPass);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(151, 306);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 41);
            this.panel3.TabIndex = 63;
            this.tagsExtender1.SetTag2(this.panel3, null);
            this.tagsExtender1.SetTag3(this.panel3, null);
            this.tagsExtender1.SetTagFontName(this.panel3, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.panel3, 10F);
            this.tagsExtender1.SetTagFontStyle(this.panel3, System.Drawing.FontStyle.Regular);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.ArcRadiusBorde = 15;
            this.roundedPanel2.ArcRadiusPanel = 15;
            this.roundedPanel2.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.roundedPanel2.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.roundedPanel2.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.roundedPanel2.Location = new System.Drawing.Point(2, 4);
            this.roundedPanel2.MenosHeightBorde = 1;
            this.roundedPanel2.MenosHeightPanel = 1;
            this.roundedPanel2.MenosWidthBorde = 1;
            this.roundedPanel2.MenosWidthPanel = 1;
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.PorcLuzColorBorde = 0;
            this.roundedPanel2.Size = new System.Drawing.Size(3, 36);
            this.roundedPanel2.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.roundedPanel2, null);
            this.tagsExtender1.SetTag3(this.roundedPanel2, null);
            this.tagsExtender1.SetTagFontName(this.roundedPanel2, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.roundedPanel2, 10F);
            this.tagsExtender1.SetTagFontStyle(this.roundedPanel2, System.Drawing.FontStyle.Regular);
            this.roundedPanel2.XBorde = 0;
            this.roundedPanel2.XPanel = 0;
            this.roundedPanel2.YBorde = 0;
            this.roundedPanel2.YPanel = 0;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPass.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtNewPass.Location = new System.Drawing.Point(7, 18);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(284, 23);
            this.txtNewPass.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.txtNewPass, null);
            this.tagsExtender1.SetTag3(this.txtNewPass, null);
            this.tagsExtender1.SetTagFontName(this.txtNewPass, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.txtNewPass, 14F);
            this.tagsExtender1.SetTagFontStyle(this.txtNewPass, System.Drawing.FontStyle.Bold);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(4, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.label2, null);
            this.tagsExtender1.SetTag3(this.label2, null);
            this.tagsExtender1.SetTagFontName(this.label2, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.label2, 10F);
            this.tagsExtender1.SetTagFontStyle(this.label2, System.Drawing.FontStyle.Bold);
            this.label2.Text = "Nueva Contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.ArcRadiusBorde = 5;
            this.roundedPanel3.ArcRadiusPanel = 5;
            this.roundedPanel3.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.roundedPanel3.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.roundedPanel3.Controls.Add(this.btnValidar);
            this.roundedPanel3.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.roundedPanel3.Location = new System.Drawing.Point(109, 195);
            this.roundedPanel3.MenosHeightBorde = 1;
            this.roundedPanel3.MenosHeightPanel = 1;
            this.roundedPanel3.MenosWidthBorde = 1;
            this.roundedPanel3.MenosWidthPanel = 1;
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.PorcLuzColorBorde = 0;
            this.roundedPanel3.Size = new System.Drawing.Size(180, 35);
            this.roundedPanel3.TabIndex = 67;
            this.tagsExtender1.SetTag2(this.roundedPanel3, null);
            this.tagsExtender1.SetTag3(this.roundedPanel3, null);
            this.tagsExtender1.SetTagFontName(this.roundedPanel3, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.roundedPanel3, 10F);
            this.tagsExtender1.SetTagFontStyle(this.roundedPanel3, System.Drawing.FontStyle.Regular);
            this.roundedPanel3.XBorde = 0;
            this.roundedPanel3.XPanel = 0;
            this.roundedPanel3.YBorde = 0;
            this.roundedPanel3.YPanel = 0;
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.Transparent;
            this.btnValidar.FlatAppearance.BorderSize = 0;
            this.btnValidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.ForeColor = System.Drawing.Color.White;
            this.btnValidar.Location = new System.Drawing.Point(1, 1);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(178, 33);
            this.btnValidar.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.btnValidar, null);
            this.tagsExtender1.SetTag3(this.btnValidar, null);
            this.tagsExtender1.SetTagFontName(this.btnValidar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnValidar, 15F);
            this.tagsExtender1.SetTagFontStyle(this.btnValidar, System.Drawing.FontStyle.Bold);
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTexto.Location = new System.Drawing.Point(101, 97);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(392, 32);
            this.lblTexto.TabIndex = 68;
            this.tagsExtender1.SetTag2(this.lblTexto, null);
            this.tagsExtender1.SetTag3(this.lblTexto, null);
            this.tagsExtender1.SetTagFontName(this.lblTexto, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.lblTexto, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lblTexto, System.Drawing.FontStyle.Bold);
            this.lblTexto.Text = "Se le envió un correo desde megaautos@gmail.com con\r\nun token que expirará en 2 h" +
    "oras o si le da Cancelar a esta pantalla.";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.ArcRadiusBorde = 5;
            this.roundedPanel4.ArcRadiusPanel = 5;
            this.roundedPanel4.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.roundedPanel4.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.roundedPanel4.Controls.Add(this.btnReenviar);
            this.roundedPanel4.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.roundedPanel4.Location = new System.Drawing.Point(305, 196);
            this.roundedPanel4.MenosHeightBorde = 1;
            this.roundedPanel4.MenosHeightPanel = 1;
            this.roundedPanel4.MenosWidthBorde = 1;
            this.roundedPanel4.MenosWidthPanel = 1;
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.PorcLuzColorBorde = 0;
            this.roundedPanel4.Size = new System.Drawing.Size(180, 35);
            this.roundedPanel4.TabIndex = 69;
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
            // btnReenviar
            // 
            this.btnReenviar.BackColor = System.Drawing.Color.Transparent;
            this.btnReenviar.FlatAppearance.BorderSize = 0;
            this.btnReenviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReenviar.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReenviar.ForeColor = System.Drawing.Color.White;
            this.btnReenviar.Location = new System.Drawing.Point(1, 1);
            this.btnReenviar.Name = "btnReenviar";
            this.btnReenviar.Size = new System.Drawing.Size(178, 33);
            this.btnReenviar.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.btnReenviar, null);
            this.tagsExtender1.SetTag3(this.btnReenviar, null);
            this.tagsExtender1.SetTagFontName(this.btnReenviar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnReenviar, 15F);
            this.tagsExtender1.SetTagFontStyle(this.btnReenviar, System.Drawing.FontStyle.Bold);
            this.btnReenviar.Text = "Reenviar Correo";
            this.btnReenviar.UseVisualStyleBackColor = false;
            this.btnReenviar.Click += new System.EventHandler(this.btnReenviar_Click);
            // 
            // frmRecuperacionPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 417);
            this.ControlBox = false;
            this.Controls.Add(this.roundedPanel4);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_nombreEmpresa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_codServ);
            this.Controls.Add(this.rnd_cancelar);
            this.Controls.Add(this.rnd_guardar);
            this.Controls.Add(this.title_bar);
            this.Controls.Add(this.rpTopMain);
            this.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecuperacionPassword";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.title_bar.ResumeLayout(false);
            this.rnd_cancelar.ResumeLayout(false);
            this.rnd_guardar.ResumeLayout(false);
            this.pnl_codServ.ResumeLayout(false);
            this.pnl_codServ.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TagsExtender tagsExtender1;
        private RoundedPanel rpTopMain;
        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button boton_minimizar;
        private System.Windows.Forms.Button boton_cerrar;
        private RoundedPanel rnd_cancelar;
        private System.Windows.Forms.Button btn_cancelar;
        private RoundedPanel rnd_guardar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbl_nombreEmpresa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_codServ;
        private RoundedPanel rnd_color_1;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Panel panel2;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label2;
        private RoundedPanel roundedPanel3;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblTexto;
        private RoundedPanel roundedPanel4;
        private System.Windows.Forms.Button btnReenviar;
    }
}