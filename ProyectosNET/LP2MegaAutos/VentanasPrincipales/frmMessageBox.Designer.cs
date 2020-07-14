namespace LP2MegaAutos.VentanasPrincipales
{
    partial class frmMessageBox
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.rndCancelar = new LP2MegaAutos.RoundedPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rndOk = new LP2MegaAutos.RoundedPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.rpTopMain = new LP2MegaAutos.RoundedPanel();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.title_bar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.rndCancelar.SuspendLayout();
            this.rndOk.SuspendLayout();
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
            this.title_bar.Size = new System.Drawing.Size(430, 24);
            this.title_bar.TabIndex = 77;
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
            this.button3.Location = new System.Drawing.Point(405, -1);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 24);
            this.button3.TabIndex = 78;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTexto, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitulo, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 160);
            this.tableLayoutPanel1.TabIndex = 82;
            this.tagsExtender1.SetTag2(this.tableLayoutPanel1, null);
            this.tagsExtender1.SetTag3(this.tableLayoutPanel1, null);
            this.tagsExtender1.SetTagFontName(this.tableLayoutPanel1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.tableLayoutPanel1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.tableLayoutPanel1, System.Drawing.FontStyle.Regular);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panel1.Location = new System.Drawing.Point(3, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 1);
            this.panel1.TabIndex = 86;
            this.tagsExtender1.SetTag2(this.panel1, null);
            this.tagsExtender1.SetTag3(this.panel1, null);
            this.tagsExtender1.SetTagFontName(this.panel1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.panel1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.panel1, System.Drawing.FontStyle.Regular);
            // 
            // lblTexto
            // 
            this.lblTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTexto.Location = new System.Drawing.Point(160, 50);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(63, 110);
            this.lblTexto.TabIndex = 84;
            this.tagsExtender1.SetTag2(this.lblTexto, null);
            this.tagsExtender1.SetTag3(this.lblTexto, null);
            this.tagsExtender1.SetTagFontName(this.lblTexto, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lblTexto, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lblTexto, System.Drawing.FontStyle.Regular);
            this.lblTexto.Text = "Mensaje";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.lblTitulo.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.lblTitulo.Location = new System.Drawing.Point(130, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(123, 35);
            this.lblTitulo.TabIndex = 85;
            this.tagsExtender1.SetTag2(this.lblTitulo, null);
            this.tagsExtender1.SetTag3(this.lblTitulo, null);
            this.tagsExtender1.SetTagFontName(this.lblTitulo, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblTitulo, 22F);
            this.tagsExtender1.SetTagFontStyle(this.lblTitulo, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Text = "Mensaje";
            // 
            // tlpBotones
            // 
            this.tlpBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.tlpBotones.ColumnCount = 2;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Controls.Add(this.rndCancelar, 0, 0);
            this.tlpBotones.Controls.Add(this.rndOk, 0, 0);
            this.tlpBotones.Location = new System.Drawing.Point(25, 219);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Size = new System.Drawing.Size(380, 61);
            this.tlpBotones.TabIndex = 83;
            this.tagsExtender1.SetTag2(this.tlpBotones, null);
            this.tagsExtender1.SetTag3(this.tlpBotones, null);
            this.tagsExtender1.SetTagFontName(this.tlpBotones, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.tlpBotones, 10F);
            this.tagsExtender1.SetTagFontStyle(this.tlpBotones, System.Drawing.FontStyle.Regular);
            // 
            // rndCancelar
            // 
            this.rndCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rndCancelar.ArcRadiusBorde = 5;
            this.rndCancelar.ArcRadiusPanel = 5;
            this.rndCancelar.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rndCancelar.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rndCancelar.Controls.Add(this.btnCancelar);
            this.rndCancelar.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndCancelar.Location = new System.Drawing.Point(202, 13);
            this.rndCancelar.MenosHeightBorde = 1;
            this.rndCancelar.MenosHeightPanel = 1;
            this.rndCancelar.MenosWidthBorde = 1;
            this.rndCancelar.MenosWidthPanel = 1;
            this.rndCancelar.Name = "rndCancelar";
            this.rndCancelar.PorcLuzColorBorde = 0;
            this.rndCancelar.Size = new System.Drawing.Size(165, 35);
            this.rndCancelar.TabIndex = 76;
            this.tagsExtender1.SetTag2(this.rndCancelar, null);
            this.tagsExtender1.SetTag3(this.rndCancelar, null);
            this.tagsExtender1.SetTagFontName(this.rndCancelar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rndCancelar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rndCancelar, System.Drawing.FontStyle.Regular);
            this.rndCancelar.XBorde = 0;
            this.rndCancelar.XPanel = 0;
            this.rndCancelar.YBorde = 0;
            this.rndCancelar.YPanel = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(3, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(159, 29);
            this.btnCancelar.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.btnCancelar, null);
            this.tagsExtender1.SetTag3(this.btnCancelar, null);
            this.tagsExtender1.SetTagFontName(this.btnCancelar, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.btnCancelar, 15F);
            this.tagsExtender1.SetTagFontStyle(this.btnCancelar, System.Drawing.FontStyle.Regular);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // rndOk
            // 
            this.rndOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rndOk.ArcRadiusBorde = 5;
            this.rndOk.ArcRadiusPanel = 5;
            this.rndOk.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rndOk.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rndOk.Controls.Add(this.btnOk);
            this.rndOk.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndOk.Location = new System.Drawing.Point(12, 13);
            this.rndOk.MenosHeightBorde = 1;
            this.rndOk.MenosHeightPanel = 1;
            this.rndOk.MenosWidthBorde = 1;
            this.rndOk.MenosWidthPanel = 1;
            this.rndOk.Name = "rndOk";
            this.rndOk.PorcLuzColorBorde = 0;
            this.rndOk.Size = new System.Drawing.Size(165, 35);
            this.rndOk.TabIndex = 74;
            this.tagsExtender1.SetTag2(this.rndOk, null);
            this.tagsExtender1.SetTag3(this.rndOk, null);
            this.tagsExtender1.SetTagFontName(this.rndOk, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rndOk, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rndOk, System.Drawing.FontStyle.Regular);
            this.rndOk.XBorde = 0;
            this.rndOk.XPanel = 0;
            this.rndOk.YBorde = 0;
            this.rndOk.YPanel = 0;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(3, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(159, 29);
            this.btnOk.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.btnOk, null);
            this.tagsExtender1.SetTag3(this.btnOk, null);
            this.tagsExtender1.SetTagFontName(this.btnOk, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.btnOk, 15F);
            this.tagsExtender1.SetTagFontStyle(this.btnOk, System.Drawing.FontStyle.Regular);
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMessageBox_KeyDown);
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
            this.rpTopMain.Size = new System.Drawing.Size(430, 8);
            this.rpTopMain.TabIndex = 76;
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
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(430, 301);
            this.pnlBackground.TabIndex = 84;
            this.tagsExtender1.SetTag2(this.pnlBackground, null);
            this.tagsExtender1.SetTag3(this.pnlBackground, null);
            this.tagsExtender1.SetTagFontName(this.pnlBackground, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.pnlBackground, 10F);
            this.tagsExtender1.SetTagFontStyle(this.pnlBackground, System.Drawing.FontStyle.Regular);
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 300);
            this.ControlBox = false;
            this.Controls.Add(this.tlpBotones);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.title_bar);
            this.Controls.Add(this.rpTopMain);
            this.Controls.Add(this.pnlBackground);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMessageBox";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.ShowIcon = false;
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMessageBox_KeyDown);
            this.title_bar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpBotones.ResumeLayout(false);
            this.rndCancelar.ResumeLayout(false);
            this.rndOk.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.Button boton_minimizar;
        private System.Windows.Forms.Button boton_cerrar;
        private RoundedPanel rpTopMain;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private RoundedPanel rndOk;
        private System.Windows.Forms.Button btnOk;
        private RoundedPanel rndCancelar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlBackground;
        private TagsExtender tagsExtender1;
    }
}