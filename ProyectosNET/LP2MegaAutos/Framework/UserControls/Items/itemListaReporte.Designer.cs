namespace LP2MegaAutos
{
    partial class itemListaReporte
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
            this.rpItem = new LP2MegaAutos.RoundedPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGeneradoEl = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPor = new System.Windows.Forms.Label();
            this.lblQuienGenero = new System.Windows.Forms.Label();
            this.tlpSede = new System.Windows.Forms.TableLayoutPanel();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.lblSede = new System.Windows.Forms.Label();
            this.tloResumen = new System.Windows.Forms.TableLayoutPanel();
            this.lblResumen = new System.Windows.Forms.Label();
            this.lblEgresos = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSol3 = new System.Windows.Forms.Label();
            this.lblSol2 = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblSol1 = new System.Windows.Forms.Label();
            this.lblMontoIngresos = new System.Windows.Forms.Label();
            this.lblMontoEgresos = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.rpItem.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpSede.SuspendLayout();
            this.tloResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpItem
            // 
            this.rpItem.ArcRadiusBorde = 21;
            this.rpItem.ArcRadiusPanel = 21;
            this.rpItem.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.rpItem.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpItem.Controls.Add(this.tableLayoutPanel1);
            this.rpItem.Controls.Add(this.tlpSede);
            this.rpItem.Controls.Add(this.tloResumen);
            this.rpItem.Controls.Add(this.lblPrincipal);
            this.rpItem.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rpItem.Location = new System.Drawing.Point(0, 0);
            this.rpItem.Margin = new System.Windows.Forms.Padding(4);
            this.rpItem.MenosHeightBorde = 1;
            this.rpItem.MenosHeightPanel = 1;
            this.rpItem.MenosWidthBorde = 1;
            this.rpItem.MenosWidthPanel = 1;
            this.rpItem.Name = "rpItem";
            this.rpItem.PorcLuzColorBorde = 0;
            this.rpItem.Size = new System.Drawing.Size(723, 201);
            this.rpItem.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.rpItem, null);
            this.tagsExtender1.SetTag3(this.rpItem, null);
            this.tagsExtender1.SetTagFontName(this.rpItem, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpItem, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpItem, System.Drawing.FontStyle.Regular);
            this.rpItem.XBorde = 0;
            this.rpItem.XPanel = 0;
            this.rpItem.YBorde = 0;
            this.rpItem.YPanel = 0;
            this.rpItem.Click += new System.EventHandler(this.itemLista_Click);
            this.rpItem.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.rpItem.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 397F));
            this.tableLayoutPanel1.Controls.Add(this.lblGeneradoEl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFecha, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPor, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQuienGenero, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 36);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(675, 27);
            this.tableLayoutPanel1.TabIndex = 47;
            this.tagsExtender1.SetTag2(this.tableLayoutPanel1, null);
            this.tagsExtender1.SetTag3(this.tableLayoutPanel1, null);
            this.tagsExtender1.SetTagFontName(this.tableLayoutPanel1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.tableLayoutPanel1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.tableLayoutPanel1, System.Drawing.FontStyle.Regular);
            this.tableLayoutPanel1.Click += new System.EventHandler(this.itemLista_Click);
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // lblGeneradoEl
            // 
            this.lblGeneradoEl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGeneradoEl.AutoSize = true;
            this.lblGeneradoEl.BackColor = System.Drawing.Color.Transparent;
            this.lblGeneradoEl.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneradoEl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblGeneradoEl.Location = new System.Drawing.Point(4, 3);
            this.lblGeneradoEl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeneradoEl.Name = "lblGeneradoEl";
            this.lblGeneradoEl.Size = new System.Drawing.Size(104, 21);
            this.lblGeneradoEl.TabIndex = 7;
            this.tagsExtender1.SetTag2(this.lblGeneradoEl, null);
            this.tagsExtender1.SetTag3(this.lblGeneradoEl, null);
            this.tagsExtender1.SetTagFontName(this.lblGeneradoEl, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblGeneradoEl, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lblGeneradoEl, System.Drawing.FontStyle.Regular);
            this.lblGeneradoEl.Text = "Generado el ";
            this.lblGeneradoEl.Click += new System.EventHandler(this.itemLista_Click);
            this.lblGeneradoEl.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.lblGeneradoEl.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblFecha.Location = new System.Drawing.Point(118, 3);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(106, 21);
            this.lblFecha.TabIndex = 8;
            this.tagsExtender1.SetTag2(this.lblFecha, null);
            this.tagsExtender1.SetTag3(this.lblFecha, null);
            this.tagsExtender1.SetTagFontName(this.lblFecha, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblFecha, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lblFecha, System.Drawing.FontStyle.Bold);
            this.lblFecha.Text = "24/05/2020";
            this.lblFecha.Click += new System.EventHandler(this.itemLista_Click);
            this.lblFecha.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.lblFecha.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // lblPor
            // 
            this.lblPor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPor.AutoSize = true;
            this.lblPor.BackColor = System.Drawing.Color.Transparent;
            this.lblPor.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblPor.Location = new System.Drawing.Point(238, 3);
            this.lblPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPor.Name = "lblPor";
            this.lblPor.Size = new System.Drawing.Size(36, 21);
            this.lblPor.TabIndex = 9;
            this.tagsExtender1.SetTag2(this.lblPor, null);
            this.tagsExtender1.SetTag3(this.lblPor, null);
            this.tagsExtender1.SetTagFontName(this.lblPor, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblPor, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lblPor, System.Drawing.FontStyle.Regular);
            this.lblPor.Text = "por";
            this.lblPor.Click += new System.EventHandler(this.itemLista_Click);
            this.lblPor.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.lblPor.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // lblQuienGenero
            // 
            this.lblQuienGenero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQuienGenero.AutoSize = true;
            this.lblQuienGenero.BackColor = System.Drawing.Color.Transparent;
            this.lblQuienGenero.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuienGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblQuienGenero.Location = new System.Drawing.Point(282, 3);
            this.lblQuienGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuienGenero.Name = "lblQuienGenero";
            this.lblQuienGenero.Size = new System.Drawing.Size(117, 21);
            this.lblQuienGenero.TabIndex = 10;
            this.tagsExtender1.SetTag2(this.lblQuienGenero, null);
            this.tagsExtender1.SetTag3(this.lblQuienGenero, null);
            this.tagsExtender1.SetTagFontName(this.lblQuienGenero, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblQuienGenero, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lblQuienGenero, System.Drawing.FontStyle.Bold);
            this.lblQuienGenero.Text = "Percy Jackson";
            this.lblQuienGenero.Click += new System.EventHandler(this.itemLista_Click);
            this.lblQuienGenero.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.lblQuienGenero.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // tlpSede
            // 
            this.tlpSede.BackColor = System.Drawing.Color.Transparent;
            this.tlpSede.ColumnCount = 1;
            this.tlpSede.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSede.Controls.Add(this.lblTipoReporte, 0, 1);
            this.tlpSede.Controls.Add(this.lblSede, 0, 0);
            this.tlpSede.Location = new System.Drawing.Point(489, 71);
            this.tlpSede.Margin = new System.Windows.Forms.Padding(4);
            this.tlpSede.Name = "tlpSede";
            this.tlpSede.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlpSede.RowCount = 2;
            this.tlpSede.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSede.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpSede.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSede.Size = new System.Drawing.Size(207, 113);
            this.tlpSede.TabIndex = 21;
            this.tagsExtender1.SetTag2(this.tlpSede, null);
            this.tagsExtender1.SetTag3(this.tlpSede, null);
            this.tagsExtender1.SetTagFontName(this.tlpSede, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.tlpSede, 10F);
            this.tagsExtender1.SetTagFontStyle(this.tlpSede, System.Drawing.FontStyle.Regular);
            this.tlpSede.Click += new System.EventHandler(this.itemLista_Click);
            this.tlpSede.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.tlpSede.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTipoReporte.AutoSize = true;
            this.lblTipoReporte.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoReporte.Font = new System.Drawing.Font("Lato", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.lblTipoReporte.Location = new System.Drawing.Point(67, 70);
            this.lblTipoReporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(136, 27);
            this.lblTipoReporte.TabIndex = 20;
            this.tagsExtender1.SetTag2(this.lblTipoReporte, null);
            this.tagsExtender1.SetTag3(this.lblTipoReporte, null);
            this.tagsExtender1.SetTagFontName(this.lblTipoReporte, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.lblTipoReporte, 13F);
            this.tagsExtender1.SetTagFontStyle(this.lblTipoReporte, System.Drawing.FontStyle.Bold);
            this.lblTipoReporte.Text = "TipoReporte";
            this.lblTipoReporte.Click += new System.EventHandler(this.itemLista_Click);
            this.lblTipoReporte.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.lblTipoReporte.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // lblSede
            // 
            this.lblSede.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSede.AutoSize = true;
            this.lblSede.BackColor = System.Drawing.Color.Transparent;
            this.lblSede.Font = new System.Drawing.Font("Lato", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.lblSede.Location = new System.Drawing.Point(143, 14);
            this.lblSede.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(60, 27);
            this.lblSede.TabIndex = 19;
            this.tagsExtender1.SetTag2(this.lblSede, null);
            this.tagsExtender1.SetTag3(this.lblSede, null);
            this.tagsExtender1.SetTagFontName(this.lblSede, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.lblSede, 13F);
            this.tagsExtender1.SetTagFontStyle(this.lblSede, System.Drawing.FontStyle.Bold);
            this.lblSede.Text = "Sede";
            this.lblSede.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.lblSede.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // tloResumen
            // 
            this.tloResumen.BackColor = System.Drawing.Color.Transparent;
            this.tloResumen.ColumnCount = 3;
            this.tloResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tloResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tloResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tloResumen.Controls.Add(this.lblResumen, 0, 0);
            this.tloResumen.Controls.Add(this.lblEgresos, 0, 2);
            this.tloResumen.Controls.Add(this.lblTotal, 0, 3);
            this.tloResumen.Controls.Add(this.lblSol3, 1, 3);
            this.tloResumen.Controls.Add(this.lblSol2, 1, 2);
            this.tloResumen.Controls.Add(this.lblIngresos, 0, 1);
            this.tloResumen.Controls.Add(this.lblSol1, 1, 1);
            this.tloResumen.Controls.Add(this.lblMontoIngresos, 2, 1);
            this.tloResumen.Controls.Add(this.lblMontoEgresos, 2, 2);
            this.tloResumen.Controls.Add(this.lblMontoTotal, 2, 3);
            this.tloResumen.Location = new System.Drawing.Point(21, 71);
            this.tloResumen.Margin = new System.Windows.Forms.Padding(4);
            this.tloResumen.Name = "tloResumen";
            this.tloResumen.RowCount = 4;
            this.tloResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tloResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tloResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tloResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tloResumen.Size = new System.Drawing.Size(371, 123);
            this.tloResumen.TabIndex = 20;
            this.tagsExtender1.SetTag2(this.tloResumen, null);
            this.tagsExtender1.SetTag3(this.tloResumen, null);
            this.tagsExtender1.SetTagFontName(this.tloResumen, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.tloResumen, 10F);
            this.tagsExtender1.SetTagFontStyle(this.tloResumen, System.Drawing.FontStyle.Regular);
            this.tloResumen.Click += new System.EventHandler(this.itemLista_Click);
            this.tloResumen.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.tloResumen.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.BackColor = System.Drawing.Color.Transparent;
            this.lblResumen.Font = new System.Drawing.Font("Lato", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.lblResumen.Location = new System.Drawing.Point(4, 0);
            this.lblResumen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(101, 27);
            this.lblResumen.TabIndex = 1;
            this.tagsExtender1.SetTag2(this.lblResumen, null);
            this.tagsExtender1.SetTag3(this.lblResumen, null);
            this.tagsExtender1.SetTagFontName(this.lblResumen, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblResumen, 13F);
            this.tagsExtender1.SetTagFontStyle(this.lblResumen, System.Drawing.FontStyle.Regular);
            this.lblResumen.Text = "Resumen";
            this.lblResumen.Click += new System.EventHandler(this.itemLista_Click);
            this.lblResumen.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.lblResumen.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // lblEgresos
            // 
            this.lblEgresos.AutoSize = true;
            this.lblEgresos.BackColor = System.Drawing.Color.Transparent;
            this.lblEgresos.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblEgresos.Location = new System.Drawing.Point(4, 60);
            this.lblEgresos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEgresos.Name = "lblEgresos";
            this.lblEgresos.Size = new System.Drawing.Size(68, 23);
            this.lblEgresos.TabIndex = 11;
            this.tagsExtender1.SetTag2(this.lblEgresos, null);
            this.tagsExtender1.SetTag3(this.lblEgresos, null);
            this.tagsExtender1.SetTagFontName(this.lblEgresos, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblEgresos, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblEgresos, System.Drawing.FontStyle.Regular);
            this.lblEgresos.Text = "Costos";
            this.lblEgresos.Click += new System.EventHandler(this.itemLista_Click);
            this.lblEgresos.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.lblEgresos.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblTotal.Location = new System.Drawing.Point(4, 90);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 23);
            this.lblTotal.TabIndex = 12;
            this.tagsExtender1.SetTag2(this.lblTotal, null);
            this.tagsExtender1.SetTag3(this.lblTotal, null);
            this.tagsExtender1.SetTagFontName(this.lblTotal, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblTotal, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblTotal, System.Drawing.FontStyle.Regular);
            this.lblTotal.Text = "Margen";
            this.lblTotal.Click += new System.EventHandler(this.itemLista_Click);
            this.lblTotal.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.lblTotal.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // lblSol3
            // 
            this.lblSol3.AutoSize = true;
            this.lblSol3.BackColor = System.Drawing.Color.Transparent;
            this.lblSol3.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSol3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblSol3.Location = new System.Drawing.Point(120, 90);
            this.lblSol3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSol3.Name = "lblSol3";
            this.lblSol3.Size = new System.Drawing.Size(29, 23);
            this.lblSol3.TabIndex = 15;
            this.tagsExtender1.SetTag2(this.lblSol3, null);
            this.tagsExtender1.SetTag3(this.lblSol3, null);
            this.tagsExtender1.SetTagFontName(this.lblSol3, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblSol3, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblSol3, System.Drawing.FontStyle.Bold);
            this.lblSol3.Text = "S/";
            this.lblSol3.Click += new System.EventHandler(this.itemLista_Click);
            this.lblSol3.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.lblSol3.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // lblSol2
            // 
            this.lblSol2.AutoSize = true;
            this.lblSol2.BackColor = System.Drawing.Color.Transparent;
            this.lblSol2.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSol2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblSol2.Location = new System.Drawing.Point(120, 60);
            this.lblSol2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSol2.Name = "lblSol2";
            this.lblSol2.Size = new System.Drawing.Size(29, 23);
            this.lblSol2.TabIndex = 14;
            this.tagsExtender1.SetTag2(this.lblSol2, null);
            this.tagsExtender1.SetTag3(this.lblSol2, null);
            this.tagsExtender1.SetTagFontName(this.lblSol2, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblSol2, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblSol2, System.Drawing.FontStyle.Regular);
            this.lblSol2.Text = "S/";
            this.lblSol2.Click += new System.EventHandler(this.itemLista_Click);
            this.lblSol2.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.lblSol2.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.BackColor = System.Drawing.Color.Transparent;
            this.lblIngresos.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblIngresos.Location = new System.Drawing.Point(4, 30);
            this.lblIngresos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(108, 23);
            this.lblIngresos.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.lblIngresos, null);
            this.tagsExtender1.SetTag3(this.lblIngresos, null);
            this.tagsExtender1.SetTagFontName(this.lblIngresos, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblIngresos, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblIngresos, System.Drawing.FontStyle.Regular);
            this.lblIngresos.Text = "Facturación";
            this.lblIngresos.Click += new System.EventHandler(this.itemLista_Click);
            this.lblIngresos.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.lblIngresos.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // lblSol1
            // 
            this.lblSol1.AutoSize = true;
            this.lblSol1.BackColor = System.Drawing.Color.Transparent;
            this.lblSol1.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSol1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblSol1.Location = new System.Drawing.Point(120, 30);
            this.lblSol1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSol1.Name = "lblSol1";
            this.lblSol1.Size = new System.Drawing.Size(29, 23);
            this.lblSol1.TabIndex = 13;
            this.tagsExtender1.SetTag2(this.lblSol1, null);
            this.tagsExtender1.SetTag3(this.lblSol1, null);
            this.tagsExtender1.SetTagFontName(this.lblSol1, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblSol1, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblSol1, System.Drawing.FontStyle.Regular);
            this.lblSol1.Text = "S/";
            this.lblSol1.Click += new System.EventHandler(this.itemLista_Click);
            this.lblSol1.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.lblSol1.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // lblMontoIngresos
            // 
            this.lblMontoIngresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontoIngresos.AutoSize = true;
            this.lblMontoIngresos.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoIngresos.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblMontoIngresos.Location = new System.Drawing.Point(246, 30);
            this.lblMontoIngresos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoIngresos.Name = "lblMontoIngresos";
            this.lblMontoIngresos.Size = new System.Drawing.Size(121, 23);
            this.lblMontoIngresos.TabIndex = 16;
            this.tagsExtender1.SetTag2(this.lblMontoIngresos, null);
            this.tagsExtender1.SetTag3(this.lblMontoIngresos, null);
            this.tagsExtender1.SetTagFontName(this.lblMontoIngresos, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblMontoIngresos, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblMontoIngresos, System.Drawing.FontStyle.Regular);
            this.lblMontoIngresos.Text = "1,000,000.00";
            this.lblMontoIngresos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMontoIngresos.Click += new System.EventHandler(this.itemLista_Click);
            this.lblMontoIngresos.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.lblMontoIngresos.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // lblMontoEgresos
            // 
            this.lblMontoEgresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontoEgresos.AutoSize = true;
            this.lblMontoEgresos.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoEgresos.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblMontoEgresos.Location = new System.Drawing.Point(309, 60);
            this.lblMontoEgresos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoEgresos.Name = "lblMontoEgresos";
            this.lblMontoEgresos.Size = new System.Drawing.Size(58, 23);
            this.lblMontoEgresos.TabIndex = 17;
            this.tagsExtender1.SetTag2(this.lblMontoEgresos, null);
            this.tagsExtender1.SetTag3(this.lblMontoEgresos, null);
            this.tagsExtender1.SetTagFontName(this.lblMontoEgresos, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblMontoEgresos, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblMontoEgresos, System.Drawing.FontStyle.Regular);
            this.lblMontoEgresos.Text = "10.00";
            this.lblMontoEgresos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMontoEgresos.Click += new System.EventHandler(this.itemLista_Click);
            this.lblMontoEgresos.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.lblMontoEgresos.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoTotal.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblMontoTotal.Location = new System.Drawing.Point(260, 90);
            this.lblMontoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(107, 23);
            this.lblMontoTotal.TabIndex = 18;
            this.tagsExtender1.SetTag2(this.lblMontoTotal, null);
            this.tagsExtender1.SetTag3(this.lblMontoTotal, null);
            this.tagsExtender1.SetTagFontName(this.lblMontoTotal, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblMontoTotal, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblMontoTotal, System.Drawing.FontStyle.Bold);
            this.lblMontoTotal.Text = "100,000.00";
            this.lblMontoTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMontoTotal.Click += new System.EventHandler(this.itemLista_Click);
            this.lblMontoTotal.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.lblMontoTotal.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblPrincipal.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.lblPrincipal.Location = new System.Drawing.Point(23, 5);
            this.lblPrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(175, 30);
            this.lblPrincipal.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.lblPrincipal, null);
            this.tagsExtender1.SetTag3(this.lblPrincipal, null);
            this.tagsExtender1.SetTagFontName(this.lblPrincipal, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblPrincipal, 15F);
            this.tagsExtender1.SetTagFontStyle(this.lblPrincipal, System.Drawing.FontStyle.Bold);
            this.lblPrincipal.Text = "Texto Principal";
            this.lblPrincipal.Click += new System.EventHandler(this.itemLista_Click);
            this.lblPrincipal.MouseEnter += new System.EventHandler(this.itemLista_MouseEnter);
            this.lblPrincipal.MouseLeave += new System.EventHandler(this.itemLista_MouseLeave);
            // 
            // itemListaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rpItem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "itemListaReporte";
            this.Size = new System.Drawing.Size(723, 201);
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.rpItem.ResumeLayout(false);
            this.rpItem.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpSede.ResumeLayout(false);
            this.tlpSede.PerformLayout();
            this.tloResumen.ResumeLayout(false);
            this.tloResumen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel rpItem;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Label lblQuienGenero;
        private System.Windows.Forms.Label lblPor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblGeneradoEl;
        private TagsExtender tagsExtender1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblEgresos;
        private System.Windows.Forms.Label lblSol3;
        private System.Windows.Forms.Label lblSol2;
        private System.Windows.Forms.Label lblSol1;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label lblMontoEgresos;
        private System.Windows.Forms.Label lblMontoIngresos;
        private System.Windows.Forms.TableLayoutPanel tloResumen;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.TableLayoutPanel tlpSede;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTipoReporte;
    }
}
