namespace LP2MegaAutos
{
    partial class frmDetalleReporte
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
            this.tags = new LP2MegaAutos.TagsExtender();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblEgresos = new System.Windows.Forms.Label();
            this.rpIngresos = new LP2MegaAutos.RoundedPanel();
            this.rpEgresos = new LP2MegaAutos.RoundedPanel();
            this.flpReportes = new System.Windows.Forms.FlowLayoutPanel();
            this.title_bar_2 = new System.Windows.Forms.Panel();
            this.title_bar = new System.Windows.Forms.Panel();
            this.boton_minimizar = new System.Windows.Forms.Button();
            this.boton_cerrar = new System.Windows.Forms.Button();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlColorArriba = new System.Windows.Forms.Panel();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.rpConcepto = new LP2MegaAutos.RoundedPanel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnResumen = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.tlpGeneradoEl = new System.Windows.Forms.TableLayoutPanel();
            this.lblGeneradoEl = new System.Windows.Forms.Label();
            this.lblQuienGenero = new System.Windows.Forms.Label();
            this.lblPor = new System.Windows.Forms.Label();
            this.lblFechaGenerado = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSede = new System.Windows.Forms.Label();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.sfdArchivoReporte = new System.Windows.Forms.SaveFileDialog();
            this.roundedPanel1 = new LP2MegaAutos.RoundedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.title_bar.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.tlpGeneradoEl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.lblIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblIngresos.Location = new System.Drawing.Point(675, 169);
            this.lblIngresos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(116, 33);
            this.lblIngresos.TabIndex = 39;
            this.tags.SetTag2(this.lblIngresos, null);
            this.tags.SetTag3(this.lblIngresos, null);
            this.tags.SetTagFontName(this.lblIngresos, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblIngresos, 16F);
            this.tags.SetTagFontStyle(this.lblIngresos, System.Drawing.FontStyle.Bold);
            this.lblIngresos.Text = "Ingresos";
            // 
            // lblEgresos
            // 
            this.lblEgresos.AutoSize = true;
            this.lblEgresos.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.lblEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblEgresos.Location = new System.Drawing.Point(851, 169);
            this.lblEgresos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEgresos.Name = "lblEgresos";
            this.lblEgresos.Size = new System.Drawing.Size(109, 33);
            this.lblEgresos.TabIndex = 40;
            this.tags.SetTag2(this.lblEgresos, null);
            this.tags.SetTag3(this.lblEgresos, null);
            this.tags.SetTagFontName(this.lblEgresos, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblEgresos, 16F);
            this.tags.SetTagFontStyle(this.lblEgresos, System.Drawing.FontStyle.Bold);
            this.lblEgresos.Text = "Egresos";
            // 
            // rpIngresos
            // 
            this.rpIngresos.ArcRadiusBorde = 15;
            this.rpIngresos.ArcRadiusPanel = 15;
            this.rpIngresos.BackColor = System.Drawing.Color.Transparent;
            this.rpIngresos.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.rpIngresos.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.rpIngresos.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Top;
            this.rpIngresos.Location = new System.Drawing.Point(681, 206);
            this.rpIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.rpIngresos.MenosHeightBorde = 1;
            this.rpIngresos.MenosHeightPanel = 1;
            this.rpIngresos.MenosWidthBorde = 1;
            this.rpIngresos.MenosWidthPanel = 1;
            this.rpIngresos.Name = "rpIngresos";
            this.rpIngresos.PorcLuzColorBorde = 0;
            this.rpIngresos.Size = new System.Drawing.Size(97, 5);
            this.rpIngresos.TabIndex = 41;
            this.tags.SetTag2(this.rpIngresos, null);
            this.tags.SetTag3(this.rpIngresos, null);
            this.tags.SetTagFontName(this.rpIngresos, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpIngresos, 10F);
            this.tags.SetTagFontStyle(this.rpIngresos, System.Drawing.FontStyle.Regular);
            this.rpIngresos.XBorde = 0;
            this.rpIngresos.XPanel = 0;
            this.rpIngresos.YBorde = 0;
            this.rpIngresos.YPanel = 0;
            // 
            // rpEgresos
            // 
            this.rpEgresos.ArcRadiusBorde = 15;
            this.rpEgresos.ArcRadiusPanel = 15;
            this.rpEgresos.BackColor = System.Drawing.Color.Transparent;
            this.rpEgresos.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rpEgresos.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rpEgresos.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Top;
            this.rpEgresos.Location = new System.Drawing.Point(857, 206);
            this.rpEgresos.Margin = new System.Windows.Forms.Padding(4);
            this.rpEgresos.MenosHeightBorde = 1;
            this.rpEgresos.MenosHeightPanel = 1;
            this.rpEgresos.MenosWidthBorde = 1;
            this.rpEgresos.MenosWidthPanel = 1;
            this.rpEgresos.Name = "rpEgresos";
            this.rpEgresos.PorcLuzColorBorde = 0;
            this.rpEgresos.Size = new System.Drawing.Size(97, 5);
            this.rpEgresos.TabIndex = 42;
            this.tags.SetTag2(this.rpEgresos, null);
            this.tags.SetTag3(this.rpEgresos, null);
            this.tags.SetTagFontName(this.rpEgresos, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpEgresos, 10F);
            this.tags.SetTagFontStyle(this.rpEgresos, System.Drawing.FontStyle.Regular);
            this.rpEgresos.XBorde = 0;
            this.rpEgresos.XPanel = 0;
            this.rpEgresos.YBorde = 0;
            this.rpEgresos.YPanel = 0;
            // 
            // flpReportes
            // 
            this.flpReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flpReportes.AutoScroll = true;
            this.flpReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.flpReportes.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpReportes.Location = new System.Drawing.Point(199, 236);
            this.flpReportes.Margin = new System.Windows.Forms.Padding(4);
            this.flpReportes.Name = "flpReportes";
            this.flpReportes.Size = new System.Drawing.Size(989, 468);
            this.flpReportes.TabIndex = 45;
            this.tags.SetTag2(this.flpReportes, null);
            this.tags.SetTag3(this.flpReportes, null);
            this.tags.SetTagFontName(this.flpReportes, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.flpReportes, 10F);
            this.tags.SetTagFontStyle(this.flpReportes, System.Drawing.FontStyle.Regular);
            // 
            // title_bar_2
            // 
            this.title_bar_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.title_bar_2.Enabled = false;
            this.title_bar_2.Location = new System.Drawing.Point(0, 28);
            this.title_bar_2.Margin = new System.Windows.Forms.Padding(4);
            this.title_bar_2.Name = "title_bar_2";
            this.title_bar_2.Size = new System.Drawing.Size(1387, 10);
            this.title_bar_2.TabIndex = 54;
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
            this.title_bar.TabIndex = 55;
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
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.pnlBackground.Controls.Add(this.roundedPanel1);
            this.pnlBackground.Controls.Add(this.label1);
            this.pnlBackground.Controls.Add(this.btnCerrar);
            this.pnlBackground.Controls.Add(this.pnlTitulo);
            this.pnlBackground.Controls.Add(this.pnlColorArriba);
            this.pnlBackground.Controls.Add(this.lblConcepto);
            this.pnlBackground.Controls.Add(this.rpConcepto);
            this.pnlBackground.Controls.Add(this.btnExportar);
            this.pnlBackground.Controls.Add(this.lblTitulo);
            this.pnlBackground.Controls.Add(this.btnResumen);
            this.pnlBackground.Controls.Add(this.btnEstadisticas);
            this.pnlBackground.Controls.Add(this.tlpGeneradoEl);
            this.pnlBackground.Controls.Add(this.flpReportes);
            this.pnlBackground.Controls.Add(this.tableLayoutPanel1);
            this.pnlBackground.Controls.Add(this.rpEgresos);
            this.pnlBackground.Controls.Add(this.lblIngresos);
            this.pnlBackground.Controls.Add(this.lblEgresos);
            this.pnlBackground.Controls.Add(this.rpIngresos);
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1387, 805);
            this.pnlBackground.TabIndex = 64;
            this.tags.SetTag2(this.pnlBackground, null);
            this.tags.SetTag3(this.pnlBackground, null);
            this.tags.SetTagFontName(this.pnlBackground, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlBackground, 10F);
            this.tags.SetTagFontStyle(this.pnlBackground, System.Drawing.FontStyle.Regular);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnCerrar.Location = new System.Drawing.Point(921, 712);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(267, 55);
            this.btnCerrar.TabIndex = 73;
            this.tags.SetTag2(this.btnCerrar, null);
            this.tags.SetTag3(this.btnCerrar, null);
            this.tags.SetTagFontName(this.btnCerrar, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnCerrar, 15F);
            this.tags.SetTagFontStyle(this.btnCerrar, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.pnlTitulo.Location = new System.Drawing.Point(41, 102);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(807, 2);
            this.pnlTitulo.TabIndex = 70;
            this.tags.SetTag2(this.pnlTitulo, null);
            this.tags.SetTag3(this.pnlTitulo, null);
            this.tags.SetTagFontName(this.pnlTitulo, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlTitulo, 10F);
            this.tags.SetTagFontStyle(this.pnlTitulo, System.Drawing.FontStyle.Regular);
            // 
            // pnlColorArriba
            // 
            this.pnlColorArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.pnlColorArriba.Location = new System.Drawing.Point(199, 219);
            this.pnlColorArriba.Margin = new System.Windows.Forms.Padding(4);
            this.pnlColorArriba.Name = "pnlColorArriba";
            this.pnlColorArriba.Size = new System.Drawing.Size(989, 18);
            this.pnlColorArriba.TabIndex = 69;
            this.tags.SetTag2(this.pnlColorArriba, null);
            this.tags.SetTag3(this.pnlColorArriba, null);
            this.tags.SetTagFontName(this.pnlColorArriba, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlColorArriba, 10F);
            this.tags.SetTagFontStyle(this.pnlColorArriba, System.Drawing.FontStyle.Regular);
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.lblConcepto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblConcepto.Location = new System.Drawing.Point(236, 169);
            this.lblConcepto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(132, 33);
            this.lblConcepto.TabIndex = 67;
            this.tags.SetTag2(this.lblConcepto, null);
            this.tags.SetTag3(this.lblConcepto, null);
            this.tags.SetTagFontName(this.lblConcepto, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.lblConcepto, 16F);
            this.tags.SetTagFontStyle(this.lblConcepto, System.Drawing.FontStyle.Bold);
            this.lblConcepto.Text = "Concepto";
            // 
            // rpConcepto
            // 
            this.rpConcepto.ArcRadiusBorde = 15;
            this.rpConcepto.ArcRadiusPanel = 15;
            this.rpConcepto.BackColor = System.Drawing.Color.Transparent;
            this.rpConcepto.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.rpConcepto.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.rpConcepto.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Top;
            this.rpConcepto.Location = new System.Drawing.Point(239, 206);
            this.rpConcepto.Margin = new System.Windows.Forms.Padding(4);
            this.rpConcepto.MenosHeightBorde = 1;
            this.rpConcepto.MenosHeightPanel = 1;
            this.rpConcepto.MenosWidthBorde = 1;
            this.rpConcepto.MenosWidthPanel = 1;
            this.rpConcepto.Name = "rpConcepto";
            this.rpConcepto.PorcLuzColorBorde = 0;
            this.rpConcepto.Size = new System.Drawing.Size(207, 5);
            this.rpConcepto.TabIndex = 68;
            this.tags.SetTag2(this.rpConcepto, null);
            this.tags.SetTag3(this.rpConcepto, null);
            this.tags.SetTagFontName(this.rpConcepto, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.rpConcepto, 10F);
            this.tags.SetTagFontStyle(this.rpConcepto, System.Drawing.FontStyle.Regular);
            this.rpConcepto.XBorde = 0;
            this.rpConcepto.XPanel = 0;
            this.rpConcepto.YBorde = 0;
            this.rpConcepto.YPanel = 0;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnExportar.Location = new System.Drawing.Point(199, 712);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(183, 55);
            this.btnExportar.TabIndex = 65;
            this.tags.SetTag2(this.btnExportar, null);
            this.tags.SetTag3(this.btnExportar, null);
            this.tags.SetTagFontName(this.btnExportar, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnExportar, 15F);
            this.tags.SetTagFontStyle(this.btnExportar, System.Drawing.FontStyle.Bold);
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.lblTitulo.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.lblTitulo.Location = new System.Drawing.Point(33, 53);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(258, 45);
            this.lblTitulo.TabIndex = 66;
            this.tags.SetTag2(this.lblTitulo, null);
            this.tags.SetTag3(this.lblTitulo, null);
            this.tags.SetTagFontName(this.lblTitulo, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblTitulo, 21.75F);
            this.tags.SetTagFontStyle(this.lblTitulo, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Text = "Titulo Reporte";
            // 
            // btnResumen
            // 
            this.btnResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnResumen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumen.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.btnResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnResumen.Location = new System.Drawing.Point(390, 712);
            this.btnResumen.Margin = new System.Windows.Forms.Padding(4);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(166, 55);
            this.btnResumen.TabIndex = 64;
            this.tags.SetTag2(this.btnResumen, null);
            this.tags.SetTag3(this.btnResumen, null);
            this.tags.SetTagFontName(this.btnResumen, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnResumen, 15F);
            this.tags.SetTagFontStyle(this.btnResumen, System.Drawing.FontStyle.Bold);
            this.btnResumen.Text = "Resumen";
            this.btnResumen.UseVisualStyleBackColor = false;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnEstadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.btnEstadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnEstadisticas.Location = new System.Drawing.Point(564, 712);
            this.btnEstadisticas.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(202, 55);
            this.btnEstadisticas.TabIndex = 63;
            this.tags.SetTag2(this.btnEstadisticas, null);
            this.tags.SetTag3(this.btnEstadisticas, null);
            this.tags.SetTagFontName(this.btnEstadisticas, fontsD.Montserrat);
            this.tags.SetTagFontSize(this.btnEstadisticas, 15F);
            this.tags.SetTagFontStyle(this.btnEstadisticas, System.Drawing.FontStyle.Bold);
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Visible = false;
            // 
            // tlpGeneradoEl
            // 
            this.tlpGeneradoEl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.tlpGeneradoEl.ColumnCount = 4;
            this.tlpGeneradoEl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneradoEl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tlpGeneradoEl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpGeneradoEl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 468F));
            this.tlpGeneradoEl.Controls.Add(this.lblGeneradoEl, 0, 0);
            this.tlpGeneradoEl.Controls.Add(this.lblQuienGenero, 3, 0);
            this.tlpGeneradoEl.Controls.Add(this.lblPor, 2, 0);
            this.tlpGeneradoEl.Controls.Add(this.lblFechaGenerado, 1, 0);
            this.tlpGeneradoEl.Location = new System.Drawing.Point(41, 113);
            this.tlpGeneradoEl.Margin = new System.Windows.Forms.Padding(4);
            this.tlpGeneradoEl.Name = "tlpGeneradoEl";
            this.tlpGeneradoEl.RowCount = 1;
            this.tlpGeneradoEl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneradoEl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpGeneradoEl.Size = new System.Drawing.Size(807, 32);
            this.tlpGeneradoEl.TabIndex = 65;
            this.tags.SetTag2(this.tlpGeneradoEl, null);
            this.tags.SetTag3(this.tlpGeneradoEl, null);
            this.tags.SetTagFontName(this.tlpGeneradoEl, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.tlpGeneradoEl, 10F);
            this.tags.SetTagFontStyle(this.tlpGeneradoEl, System.Drawing.FontStyle.Regular);
            // 
            // lblGeneradoEl
            // 
            this.lblGeneradoEl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGeneradoEl.AutoSize = true;
            this.lblGeneradoEl.Font = new System.Drawing.Font("Lato", 12F);
            this.lblGeneradoEl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblGeneradoEl.Location = new System.Drawing.Point(10, 4);
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
            this.lblPor.Location = new System.Drawing.Point(289, 4);
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
            // roundedPanel1
            // 
            this.roundedPanel1.ArcRadiusBorde = 15;
            this.roundedPanel1.ArcRadiusPanel = 15;
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.roundedPanel1.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.roundedPanel1.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Top;
            this.roundedPanel1.Location = new System.Drawing.Point(1024, 206);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.roundedPanel1.MenosHeightBorde = 1;
            this.roundedPanel1.MenosHeightPanel = 1;
            this.roundedPanel1.MenosWidthBorde = 1;
            this.roundedPanel1.MenosWidthPanel = 1;
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.PorcLuzColorBorde = 0;
            this.roundedPanel1.Size = new System.Drawing.Size(97, 5);
            this.roundedPanel1.TabIndex = 75;
            this.tags.SetTag2(this.roundedPanel1, null);
            this.tags.SetTag3(this.roundedPanel1, null);
            this.tags.SetTagFontName(this.roundedPanel1, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.roundedPanel1, 10F);
            this.tags.SetTagFontStyle(this.roundedPanel1, System.Drawing.FontStyle.Regular);
            this.roundedPanel1.XBorde = 0;
            this.roundedPanel1.XPanel = 0;
            this.roundedPanel1.YBorde = 0;
            this.roundedPanel1.YPanel = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(1037, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 33);
            this.label1.TabIndex = 74;
            this.tags.SetTag2(this.label1, null);
            this.tags.SetTag3(this.label1, null);
            this.tags.SetTagFontName(this.label1, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.label1, 16F);
            this.tags.SetTagFontStyle(this.label1, System.Drawing.FontStyle.Bold);
            this.label1.Text = "Total";
            // 
            // frmDetalleReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 805);
            this.Controls.Add(this.title_bar_2);
            this.Controls.Add(this.title_bar);
            this.Controls.Add(this.pnlBackground);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDetalleReporte";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.tags.SetTag2(this, null);
            this.tags.SetTag3(this, null);
            this.tags.SetTagFontName(this, fontsD.Ninguno);
            this.tags.SetTagFontSize(this, 10F);
            this.tags.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.title_bar.ResumeLayout(false);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.tlpGeneradoEl.ResumeLayout(false);
            this.tlpGeneradoEl.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TagsExtender tags;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblEgresos;
        private RoundedPanel rpIngresos;
        private RoundedPanel rpEgresos;
        private System.Windows.Forms.FlowLayoutPanel flpReportes;
        private System.Windows.Forms.Panel title_bar_2;
        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.Button boton_cerrar;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tlpGeneradoEl;
        private System.Windows.Forms.Label lblGeneradoEl;
        private System.Windows.Forms.Label lblQuienGenero;
        private System.Windows.Forms.Label lblPor;
        private System.Windows.Forms.Label lblFechaGenerado;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Label lblConcepto;
        private RoundedPanel rpConcepto;
        private System.Windows.Forms.Panel pnlColorArriba;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button boton_minimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.SaveFileDialog sfdArchivoReporte;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label1;
    }
}
