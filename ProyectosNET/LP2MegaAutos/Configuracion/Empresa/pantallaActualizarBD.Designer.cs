namespace LP2MegaAutos
{
    partial class pantallaActualizarBD
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
            this.lbl_nombreEmpresa = new System.Windows.Forms.Label();
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtArchivo1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rpBtnGuardar = new LP2MegaAutos.RoundedPanel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.rpBtnDescargar = new LP2MegaAutos.RoundedPanel();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.pnlObtener = new LP2MegaAutos.RoundedPanel();
            this.btnObtener = new System.Windows.Forms.Button();
            this.cboSede = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ofdArchivo1 = new System.Windows.Forms.OpenFileDialog();
            this.ofdArchivo2 = new System.Windows.Forms.OpenFileDialog();
            this.sfdArchivoEntrada = new System.Windows.Forms.SaveFileDialog();
            this.sfdArchivoReporte = new System.Windows.Forms.SaveFileDialog();
            this.rpBtnGuardar.SuspendLayout();
            this.rpBtnDescargar.SuspendLayout();
            this.pnlObtener.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nombreEmpresa
            // 
            this.lbl_nombreEmpresa.AutoSize = true;
            this.lbl_nombreEmpresa.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.lbl_nombreEmpresa.Location = new System.Drawing.Point(24, 20);
            this.lbl_nombreEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombreEmpresa.Name = "lbl_nombreEmpresa";
            this.lbl_nombreEmpresa.Size = new System.Drawing.Size(335, 35);
            this.lbl_nombreEmpresa.TabIndex = 52;
            this.tagsExtender1.SetTag2(this.lbl_nombreEmpresa, null);
            this.tagsExtender1.SetTag3(this.lbl_nombreEmpresa, null);
            this.tagsExtender1.SetTagFontName(this.lbl_nombreEmpresa, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lbl_nombreEmpresa, 22F);
            this.tagsExtender1.SetTagFontStyle(this.lbl_nombreEmpresa, System.Drawing.FontStyle.Bold);
            this.lbl_nombreEmpresa.Text = "Actualizar Base de Datos";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panel4.Location = new System.Drawing.Point(19, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(719, 2);
            this.panel4.TabIndex = 56;
            this.tagsExtender1.SetTag2(this.panel4, null);
            this.tagsExtender1.SetTag3(this.panel4, null);
            this.tagsExtender1.SetTagFontName(this.panel4, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.panel4, 10F);
            this.tagsExtender1.SetTagFontStyle(this.panel4, System.Drawing.FontStyle.Regular);
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnExaminar.FlatAppearance.BorderSize = 0;
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnExaminar.ForeColor = System.Drawing.Color.White;
            this.btnExaminar.Location = new System.Drawing.Point(399, 3);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(37, 23);
            this.btnExaminar.TabIndex = 58;
            this.tagsExtender1.SetTag2(this.btnExaminar, null);
            this.tagsExtender1.SetTag3(this.btnExaminar, null);
            this.tagsExtender1.SetTagFontName(this.btnExaminar, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.btnExaminar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btnExaminar, System.Drawing.FontStyle.Regular);
            this.btnExaminar.Text = ". . .";
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtArchivo1
            // 
            this.txtArchivo1.Enabled = false;
            this.txtArchivo1.Font = new System.Drawing.Font("Lato", 10F);
            this.txtArchivo1.Location = new System.Drawing.Point(135, 3);
            this.txtArchivo1.Name = "txtArchivo1";
            this.txtArchivo1.Size = new System.Drawing.Size(258, 23);
            this.txtArchivo1.TabIndex = 59;
            this.tagsExtender1.SetTag2(this.txtArchivo1, null);
            this.tagsExtender1.SetTag3(this.txtArchivo1, null);
            this.tagsExtender1.SetTagFontName(this.txtArchivo1, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.txtArchivo1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.txtArchivo1, System.Drawing.FontStyle.Regular);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(39, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 60;
            this.tagsExtender1.SetTag2(this.label1, null);
            this.tagsExtender1.SetTag3(this.label1, null);
            this.tagsExtender1.SetTagFontName(this.label1, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.label1, 15F);
            this.tagsExtender1.SetTagFontStyle(this.label1, System.Drawing.FontStyle.Bold);
            this.label1.Text = "Subir Archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(4, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 63;
            this.tagsExtender1.SetTag2(this.label2, null);
            this.tagsExtender1.SetTag3(this.label2, null);
            this.tagsExtender1.SetTagFontName(this.label2, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.label2, 15F);
            this.tagsExtender1.SetTagFontStyle(this.label2, System.Drawing.FontStyle.Bold);
            this.label2.Text = "Recibir Archivo";
            // 
            // rpBtnGuardar
            // 
            this.rpBtnGuardar.ArcRadiusBorde = 5;
            this.rpBtnGuardar.ArcRadiusPanel = 5;
            this.rpBtnGuardar.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rpBtnGuardar.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rpBtnGuardar.Controls.Add(this.btn_guardar);
            this.rpBtnGuardar.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpBtnGuardar.Location = new System.Drawing.Point(3, 86);
            this.rpBtnGuardar.MenosHeightBorde = 1;
            this.rpBtnGuardar.MenosHeightPanel = 1;
            this.rpBtnGuardar.MenosWidthBorde = 1;
            this.rpBtnGuardar.MenosWidthPanel = 1;
            this.rpBtnGuardar.Name = "rpBtnGuardar";
            this.rpBtnGuardar.PorcLuzColorBorde = 0;
            this.rpBtnGuardar.Size = new System.Drawing.Size(119, 35);
            this.rpBtnGuardar.TabIndex = 82;
            this.tagsExtender1.SetTag2(this.rpBtnGuardar, null);
            this.tagsExtender1.SetTag3(this.rpBtnGuardar, null);
            this.tagsExtender1.SetTagFontName(this.rpBtnGuardar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpBtnGuardar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpBtnGuardar, System.Drawing.FontStyle.Regular);
            this.rpBtnGuardar.XBorde = 0;
            this.rpBtnGuardar.XPanel = 0;
            this.rpBtnGuardar.YBorde = 0;
            this.rpBtnGuardar.YPanel = 0;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.Enabled = false;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(0, 0);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(119, 35);
            this.btn_guardar.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.btn_guardar, null);
            this.tagsExtender1.SetTag3(this.btn_guardar, null);
            this.tagsExtender1.SetTagFontName(this.btn_guardar, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.btn_guardar, 15F);
            this.tagsExtender1.SetTagFontStyle(this.btn_guardar, System.Drawing.FontStyle.Bold);
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // rpBtnDescargar
            // 
            this.rpBtnDescargar.ArcRadiusBorde = 5;
            this.rpBtnDescargar.ArcRadiusPanel = 5;
            this.rpBtnDescargar.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rpBtnDescargar.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rpBtnDescargar.Controls.Add(this.btnDescargar);
            this.rpBtnDescargar.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpBtnDescargar.Location = new System.Drawing.Point(135, 86);
            this.rpBtnDescargar.MenosHeightBorde = 1;
            this.rpBtnDescargar.MenosHeightPanel = 1;
            this.rpBtnDescargar.MenosWidthBorde = 1;
            this.rpBtnDescargar.MenosWidthPanel = 1;
            this.rpBtnDescargar.Name = "rpBtnDescargar";
            this.rpBtnDescargar.PorcLuzColorBorde = 0;
            this.rpBtnDescargar.Size = new System.Drawing.Size(119, 35);
            this.rpBtnDescargar.TabIndex = 83;
            this.tagsExtender1.SetTag2(this.rpBtnDescargar, null);
            this.tagsExtender1.SetTag3(this.rpBtnDescargar, null);
            this.tagsExtender1.SetTagFontName(this.rpBtnDescargar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpBtnDescargar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpBtnDescargar, System.Drawing.FontStyle.Regular);
            this.rpBtnDescargar.XBorde = 0;
            this.rpBtnDescargar.XPanel = 0;
            this.rpBtnDescargar.YBorde = 0;
            this.rpBtnDescargar.YPanel = 0;
            // 
            // btnDescargar
            // 
            this.btnDescargar.BackColor = System.Drawing.Color.Transparent;
            this.btnDescargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescargar.Enabled = false;
            this.btnDescargar.FlatAppearance.BorderSize = 0;
            this.btnDescargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDescargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargar.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.ForeColor = System.Drawing.Color.White;
            this.btnDescargar.Location = new System.Drawing.Point(0, 0);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(119, 35);
            this.btnDescargar.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.btnDescargar, null);
            this.tagsExtender1.SetTag3(this.btnDescargar, null);
            this.tagsExtender1.SetTagFontName(this.btnDescargar, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.btnDescargar, 15F);
            this.tagsExtender1.SetTagFontStyle(this.btnDescargar, System.Drawing.FontStyle.Bold);
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = false;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar1_Click);
            // 
            // pnlObtener
            // 
            this.pnlObtener.ArcRadiusBorde = 5;
            this.pnlObtener.ArcRadiusPanel = 5;
            this.pnlObtener.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.pnlObtener.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.tableLayoutPanel1.SetColumnSpan(this.pnlObtener, 3);
            this.pnlObtener.Controls.Add(this.btnObtener);
            this.pnlObtener.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.pnlObtener.Location = new System.Drawing.Point(3, 183);
            this.pnlObtener.MenosHeightBorde = 1;
            this.pnlObtener.MenosHeightPanel = 1;
            this.pnlObtener.MenosWidthBorde = 1;
            this.pnlObtener.MenosWidthPanel = 1;
            this.pnlObtener.Name = "pnlObtener";
            this.pnlObtener.PorcLuzColorBorde = 0;
            this.pnlObtener.Size = new System.Drawing.Size(246, 35);
            this.pnlObtener.TabIndex = 84;
            this.tagsExtender1.SetTag2(this.pnlObtener, null);
            this.tagsExtender1.SetTag3(this.pnlObtener, null);
            this.tagsExtender1.SetTagFontName(this.pnlObtener, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.pnlObtener, 10F);
            this.tagsExtender1.SetTagFontStyle(this.pnlObtener, System.Drawing.FontStyle.Regular);
            this.pnlObtener.XBorde = 0;
            this.pnlObtener.XPanel = 0;
            this.pnlObtener.YBorde = 0;
            this.pnlObtener.YPanel = 0;
            // 
            // btnObtener
            // 
            this.btnObtener.BackColor = System.Drawing.Color.Transparent;
            this.btnObtener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObtener.Enabled = false;
            this.btnObtener.FlatAppearance.BorderSize = 0;
            this.btnObtener.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnObtener.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnObtener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObtener.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtener.ForeColor = System.Drawing.Color.White;
            this.btnObtener.Location = new System.Drawing.Point(0, 0);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(246, 35);
            this.btnObtener.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.btnObtener, null);
            this.tagsExtender1.SetTag3(this.btnObtener, null);
            this.tagsExtender1.SetTagFontName(this.btnObtener, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.btnObtener, 15F);
            this.tagsExtender1.SetTagFontStyle(this.btnObtener, System.Drawing.FontStyle.Bold);
            this.btnObtener.Text = "Obtener Reporte";
            this.btnObtener.UseVisualStyleBackColor = false;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // cboSede
            // 
            this.cboSede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.tableLayoutPanel1.SetColumnSpan(this.cboSede, 2);
            this.cboSede.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboSede.Font = new System.Drawing.Font("Montserrat", 12F);
            this.cboSede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.cboSede.FormattingEnabled = true;
            this.cboSede.Location = new System.Drawing.Point(135, 43);
            this.cboSede.Name = "cboSede";
            this.cboSede.Size = new System.Drawing.Size(360, 30);
            this.cboSede.TabIndex = 85;
            this.tagsExtender1.SetTag2(this.cboSede, null);
            this.tagsExtender1.SetTag3(this.cboSede, null);
            this.tagsExtender1.SetTagFontName(this.cboSede, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.cboSede, 10F);
            this.tagsExtender1.SetTagFontStyle(this.cboSede, System.Drawing.FontStyle.Regular);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 86;
            this.tagsExtender1.SetTag2(this.label3, null);
            this.tagsExtender1.SetTag3(this.label3, null);
            this.tagsExtender1.SetTagFontName(this.label3, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.label3, 13F);
            this.tagsExtender1.SetTagFontStyle(this.label3, System.Drawing.FontStyle.Bold);
            this.label3.Text = "Archivo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(4, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 87;
            this.tagsExtender1.SetTag2(this.label4, null);
            this.tagsExtender1.SetTag3(this.label4, null);
            this.tagsExtender1.SetTagFontName(this.label4, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.label4, 13F);
            this.tagsExtender1.SetTagFontStyle(this.label4, System.Drawing.FontStyle.Bold);
            this.label4.Text = "Sede:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.Controls.Add(this.btnExaminar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlObtener, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cboSede, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.rpBtnDescargar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rpBtnGuardar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtArchivo1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 132);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.19277F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.80723F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(513, 255);
            this.tableLayoutPanel1.TabIndex = 88;
            this.tagsExtender1.SetTag2(this.tableLayoutPanel1, null);
            this.tagsExtender1.SetTag3(this.tableLayoutPanel1, null);
            this.tagsExtender1.SetTagFontName(this.tableLayoutPanel1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.tableLayoutPanel1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.tableLayoutPanel1, System.Drawing.FontStyle.Regular);
            // 
            // ofdArchivo1
            // 
            this.ofdArchivo1.FileName = "ofdArchivo1";
            // 
            // ofdArchivo2
            // 
            this.ofdArchivo2.FileName = "ofdArchivo2";
            // 
            // pantallaActualizarBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbl_nombreEmpresa);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "pantallaActualizarBD";
            this.Size = new System.Drawing.Size(751, 520);
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.rpBtnGuardar.ResumeLayout(false);
            this.rpBtnDescargar.ResumeLayout(false);
            this.pnlObtener.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_nombreEmpresa;
        private TagsExtender tagsExtender1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtArchivo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofdArchivo1;
        private System.Windows.Forms.OpenFileDialog ofdArchivo2;
        private System.Windows.Forms.SaveFileDialog sfdArchivoEntrada;
        private System.Windows.Forms.SaveFileDialog sfdArchivoReporte;
        private RoundedPanel rpBtnGuardar;
        private System.Windows.Forms.Button btn_guardar;
        private RoundedPanel rpBtnDescargar;
        private System.Windows.Forms.Button btnDescargar;
        private RoundedPanel pnlObtener;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.ComboBox cboSede;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
