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
            this.tloResumen = new System.Windows.Forms.TableLayoutPanel();
            this.lblResumen = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblEgresos = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSol3 = new System.Windows.Forms.Label();
            this.lblSol2 = new System.Windows.Forms.Label();
            this.lblMontoEgresos = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblSol1 = new System.Windows.Forms.Label();
            this.lblMontoIngresos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblGeneradoEl = new System.Windows.Forms.Label();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.rpItem.SuspendLayout();
            this.tloResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpItem
            // 
            this.rpItem.ArcRadiusBorde = 21;
            this.rpItem.ArcRadiusPanel = 21;
            this.rpItem.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.rpItem.ColorPanel = System.Drawing.Color.White;
            this.rpItem.Controls.Add(this.tloResumen);
            this.rpItem.Controls.Add(this.label1);
            this.rpItem.Controls.Add(this.lblNombre);
            this.rpItem.Controls.Add(this.lblPor);
            this.rpItem.Controls.Add(this.lblFecha);
            this.rpItem.Controls.Add(this.lblGeneradoEl);
            this.rpItem.Controls.Add(this.lblPrincipal);
            this.rpItem.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpItem.Location = new System.Drawing.Point(0, 0);
            this.rpItem.MenosHeightBorde = 1;
            this.rpItem.MenosHeightPanel = 1;
            this.rpItem.MenosWidthBorde = 1;
            this.rpItem.MenosWidthPanel = 1;
            this.rpItem.Name = "rpItem";
            this.rpItem.PorcLuzColorBorde = 0;
            this.rpItem.Size = new System.Drawing.Size(542, 163);
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
            // 
            // tloResumen
            // 
            this.tloResumen.BackColor = System.Drawing.Color.White;
            this.tloResumen.ColumnCount = 3;
            this.tloResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tloResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tloResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
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
            this.tloResumen.Location = new System.Drawing.Point(157, 54);
            this.tloResumen.Name = "tloResumen";
            this.tloResumen.RowCount = 4;
            this.tloResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tloResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tloResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tloResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tloResumen.Size = new System.Drawing.Size(229, 100);
            this.tloResumen.TabIndex = 20;
            this.tagsExtender1.SetTag2(this.tloResumen, null);
            this.tagsExtender1.SetTag3(this.tloResumen, null);
            this.tagsExtender1.SetTagFontName(this.tloResumen, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.tloResumen, 10F);
            this.tagsExtender1.SetTagFontStyle(this.tloResumen, System.Drawing.FontStyle.Regular);
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.BackColor = System.Drawing.Color.White;
            this.lblResumen.Font = new System.Drawing.Font("Lato", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblResumen.Location = new System.Drawing.Point(3, 0);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(79, 21);
            this.lblResumen.TabIndex = 1;
            this.tagsExtender1.SetTag2(this.lblResumen, null);
            this.tagsExtender1.SetTag3(this.lblResumen, null);
            this.tagsExtender1.SetTagFontName(this.lblResumen, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblResumen, 13F);
            this.tagsExtender1.SetTagFontStyle(this.lblResumen, System.Drawing.FontStyle.Regular);
            this.lblResumen.Text = "Resumen";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.BackColor = System.Drawing.Color.White;
            this.lblMontoTotal.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblMontoTotal.Location = new System.Drawing.Point(138, 75);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(88, 18);
            this.lblMontoTotal.TabIndex = 18;
            this.tagsExtender1.SetTag2(this.lblMontoTotal, null);
            this.tagsExtender1.SetTag3(this.lblMontoTotal, null);
            this.tagsExtender1.SetTagFontName(this.lblMontoTotal, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblMontoTotal, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblMontoTotal, System.Drawing.FontStyle.Bold);
            this.lblMontoTotal.Text = "100,000.00";
            this.lblMontoTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEgresos
            // 
            this.lblEgresos.AutoSize = true;
            this.lblEgresos.BackColor = System.Drawing.Color.White;
            this.lblEgresos.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblEgresos.Location = new System.Drawing.Point(3, 50);
            this.lblEgresos.Name = "lblEgresos";
            this.lblEgresos.Size = new System.Drawing.Size(61, 18);
            this.lblEgresos.TabIndex = 11;
            this.tagsExtender1.SetTag2(this.lblEgresos, null);
            this.tagsExtender1.SetTag3(this.lblEgresos, null);
            this.tagsExtender1.SetTagFontName(this.lblEgresos, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblEgresos, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblEgresos, System.Drawing.FontStyle.Regular);
            this.lblEgresos.Text = "Egresos";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblTotal.Location = new System.Drawing.Point(3, 75);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 18);
            this.lblTotal.TabIndex = 12;
            this.tagsExtender1.SetTag2(this.lblTotal, null);
            this.tagsExtender1.SetTag3(this.lblTotal, null);
            this.tagsExtender1.SetTagFontName(this.lblTotal, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblTotal, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblTotal, System.Drawing.FontStyle.Regular);
            this.lblTotal.Text = "Total";
            // 
            // lblSol3
            // 
            this.lblSol3.AutoSize = true;
            this.lblSol3.BackColor = System.Drawing.Color.White;
            this.lblSol3.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSol3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblSol3.Location = new System.Drawing.Point(88, 75);
            this.lblSol3.Name = "lblSol3";
            this.lblSol3.Size = new System.Drawing.Size(23, 18);
            this.lblSol3.TabIndex = 15;
            this.tagsExtender1.SetTag2(this.lblSol3, null);
            this.tagsExtender1.SetTag3(this.lblSol3, null);
            this.tagsExtender1.SetTagFontName(this.lblSol3, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblSol3, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblSol3, System.Drawing.FontStyle.Bold);
            this.lblSol3.Text = "S/";
            // 
            // lblSol2
            // 
            this.lblSol2.AutoSize = true;
            this.lblSol2.BackColor = System.Drawing.Color.White;
            this.lblSol2.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSol2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblSol2.Location = new System.Drawing.Point(88, 50);
            this.lblSol2.Name = "lblSol2";
            this.lblSol2.Size = new System.Drawing.Size(23, 18);
            this.lblSol2.TabIndex = 14;
            this.tagsExtender1.SetTag2(this.lblSol2, null);
            this.tagsExtender1.SetTag3(this.lblSol2, null);
            this.tagsExtender1.SetTagFontName(this.lblSol2, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblSol2, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblSol2, System.Drawing.FontStyle.Regular);
            this.lblSol2.Text = "S/";
            // 
            // lblMontoEgresos
            // 
            this.lblMontoEgresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontoEgresos.AutoSize = true;
            this.lblMontoEgresos.BackColor = System.Drawing.Color.White;
            this.lblMontoEgresos.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblMontoEgresos.Location = new System.Drawing.Point(178, 50);
            this.lblMontoEgresos.Name = "lblMontoEgresos";
            this.lblMontoEgresos.Size = new System.Drawing.Size(48, 18);
            this.lblMontoEgresos.TabIndex = 17;
            this.tagsExtender1.SetTag2(this.lblMontoEgresos, null);
            this.tagsExtender1.SetTag3(this.lblMontoEgresos, null);
            this.tagsExtender1.SetTagFontName(this.lblMontoEgresos, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblMontoEgresos, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblMontoEgresos, System.Drawing.FontStyle.Regular);
            this.lblMontoEgresos.Text = "10.00";
            this.lblMontoEgresos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.BackColor = System.Drawing.Color.White;
            this.lblIngresos.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblIngresos.Location = new System.Drawing.Point(3, 25);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(64, 18);
            this.lblIngresos.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.lblIngresos, null);
            this.tagsExtender1.SetTag3(this.lblIngresos, null);
            this.tagsExtender1.SetTagFontName(this.lblIngresos, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblIngresos, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblIngresos, System.Drawing.FontStyle.Regular);
            this.lblIngresos.Text = "Ingresos";
            // 
            // lblSol1
            // 
            this.lblSol1.AutoSize = true;
            this.lblSol1.BackColor = System.Drawing.Color.White;
            this.lblSol1.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSol1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblSol1.Location = new System.Drawing.Point(88, 25);
            this.lblSol1.Name = "lblSol1";
            this.lblSol1.Size = new System.Drawing.Size(23, 18);
            this.lblSol1.TabIndex = 13;
            this.tagsExtender1.SetTag2(this.lblSol1, null);
            this.tagsExtender1.SetTag3(this.lblSol1, null);
            this.tagsExtender1.SetTagFontName(this.lblSol1, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblSol1, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblSol1, System.Drawing.FontStyle.Regular);
            this.lblSol1.Text = "S/";
            // 
            // lblMontoIngresos
            // 
            this.lblMontoIngresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontoIngresos.AutoSize = true;
            this.lblMontoIngresos.BackColor = System.Drawing.Color.White;
            this.lblMontoIngresos.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblMontoIngresos.Location = new System.Drawing.Point(127, 25);
            this.lblMontoIngresos.Name = "lblMontoIngresos";
            this.lblMontoIngresos.Size = new System.Drawing.Size(99, 18);
            this.lblMontoIngresos.TabIndex = 16;
            this.tagsExtender1.SetTag2(this.lblMontoIngresos, null);
            this.tagsExtender1.SetTag3(this.lblMontoIngresos, null);
            this.tagsExtender1.SetTagFontName(this.lblMontoIngresos, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblMontoIngresos, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblMontoIngresos, System.Drawing.FontStyle.Regular);
            this.lblMontoIngresos.Text = "1,000,000.00";
            this.lblMontoIngresos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lato", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.label1.Location = new System.Drawing.Point(449, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 19;
            this.tagsExtender1.SetTag2(this.label1, null);
            this.tagsExtender1.SetTag3(this.label1, null);
            this.tagsExtender1.SetTagFontName(this.label1, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.label1, 13F);
            this.tagsExtender1.SetTagFontStyle(this.label1, System.Drawing.FontStyle.Bold);
            this.label1.Text = "Resumen";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblNombre.Location = new System.Drawing.Point(199, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 16);
            this.lblNombre.TabIndex = 10;
            this.tagsExtender1.SetTag2(this.lblNombre, null);
            this.tagsExtender1.SetTag3(this.lblNombre, null);
            this.tagsExtender1.SetTagFontName(this.lblNombre, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblNombre, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lblNombre, System.Drawing.FontStyle.Bold);
            this.lblNombre.Text = "Percy Jackson";
            // 
            // lblPor
            // 
            this.lblPor.AutoSize = true;
            this.lblPor.BackColor = System.Drawing.Color.White;
            this.lblPor.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblPor.Location = new System.Drawing.Point(176, 32);
            this.lblPor.Name = "lblPor";
            this.lblPor.Size = new System.Drawing.Size(27, 16);
            this.lblPor.TabIndex = 9;
            this.tagsExtender1.SetTag2(this.lblPor, null);
            this.tagsExtender1.SetTag3(this.lblPor, null);
            this.tagsExtender1.SetTagFontName(this.lblPor, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblPor, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lblPor, System.Drawing.FontStyle.Regular);
            this.lblPor.Text = "por";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.White;
            this.lblFecha.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblFecha.Location = new System.Drawing.Point(86, 32);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(94, 16);
            this.lblFecha.TabIndex = 8;
            this.tagsExtender1.SetTag2(this.lblFecha, null);
            this.tagsExtender1.SetTag3(this.lblFecha, null);
            this.tagsExtender1.SetTagFontName(this.lblFecha, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblFecha, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lblFecha, System.Drawing.FontStyle.Bold);
            this.lblFecha.Text = "dd - mm - aaaa";
            // 
            // lblGeneradoEl
            // 
            this.lblGeneradoEl.AutoSize = true;
            this.lblGeneradoEl.BackColor = System.Drawing.Color.White;
            this.lblGeneradoEl.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneradoEl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblGeneradoEl.Location = new System.Drawing.Point(12, 32);
            this.lblGeneradoEl.Name = "lblGeneradoEl";
            this.lblGeneradoEl.Size = new System.Drawing.Size(80, 16);
            this.lblGeneradoEl.TabIndex = 7;
            this.tagsExtender1.SetTag2(this.lblGeneradoEl, null);
            this.tagsExtender1.SetTag3(this.lblGeneradoEl, null);
            this.tagsExtender1.SetTagFontName(this.lblGeneradoEl, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblGeneradoEl, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lblGeneradoEl, System.Drawing.FontStyle.Regular);
            this.lblGeneradoEl.Text = "Generado el ";
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.BackColor = System.Drawing.Color.White;
            this.lblPrincipal.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.lblPrincipal.Location = new System.Drawing.Point(12, 4);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(140, 24);
            this.lblPrincipal.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.lblPrincipal, null);
            this.tagsExtender1.SetTag3(this.lblPrincipal, null);
            this.tagsExtender1.SetTagFontName(this.lblPrincipal, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblPrincipal, 15F);
            this.tagsExtender1.SetTagFontStyle(this.lblPrincipal, System.Drawing.FontStyle.Bold);
            this.lblPrincipal.Text = "Texto Principal";
            // 
            // itemListaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.rpItem);
            this.Name = "itemListaReporte";
            this.Size = new System.Drawing.Size(542, 163);
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.rpItem.ResumeLayout(false);
            this.rpItem.PerformLayout();
            this.tloResumen.ResumeLayout(false);
            this.tloResumen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel rpItem;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Label lblNombre;
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
        private System.Windows.Forms.Label label1;
    }
}
