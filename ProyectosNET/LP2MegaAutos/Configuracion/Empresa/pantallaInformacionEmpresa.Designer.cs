namespace LP2MegaAutos
{
    partial class pantallaInformacionEmpresa
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtArchivo1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditarRutas = new System.Windows.Forms.Button();
            this.btnGuardar = new LP2MegaAutos.RoundedPanel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.roundedPanel1 = new LP2MegaAutos.RoundedPanel();
            this.btnDescargar1 = new System.Windows.Forms.Button();
            this.pnlObtener = new LP2MegaAutos.RoundedPanel();
            this.btnObtener = new System.Windows.Forms.Button();
            this.ofdArchivo1 = new System.Windows.Forms.OpenFileDialog();
            this.ofdArchivo2 = new System.Windows.Forms.OpenFileDialog();
            this.sfdArchivoEntrada = new System.Windows.Forms.SaveFileDialog();
            this.sfdArchivoReporte = new System.Windows.Forms.SaveFileDialog();
            this.btnGuardar.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.pnlObtener.SuspendLayout();
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
            this.lbl_nombreEmpresa.Size = new System.Drawing.Size(164, 35);
            this.lbl_nombreEmpresa.TabIndex = 52;
            this.tagsExtender1.SetTag2(this.lbl_nombreEmpresa, null);
            this.tagsExtender1.SetTag3(this.lbl_nombreEmpresa, null);
            this.tagsExtender1.SetTagFontName(this.lbl_nombreEmpresa, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lbl_nombreEmpresa, 22F);
            this.tagsExtender1.SetTagFontStyle(this.lbl_nombreEmpresa, System.Drawing.FontStyle.Bold);
            this.lbl_nombreEmpresa.Text = "MegaAutos";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panel4.Location = new System.Drawing.Point(19, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(719, 2);
            this.panel4.TabIndex = 56;
            this.tagsExtender1.SetTag2(this.panel4, null);
            this.tagsExtender1.SetTag3(this.panel4, null);
            this.tagsExtender1.SetTagFontName(this.panel4, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.panel4, 10F);
            this.tagsExtender1.SetTagFontStyle(this.panel4, System.Drawing.FontStyle.Regular);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.BackgroundImage = global::LP2MegaAutos.Properties.Resources.editar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(211, 20);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(32, 32);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.TabStop = false;
            this.btnEditar.Tag = "botonImagen";
            this.tagsExtender1.SetTag2(this.btnEditar, null);
            this.tagsExtender1.SetTag3(this.btnEditar, null);
            this.tagsExtender1.SetTagFontName(this.btnEditar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnEditar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btnEditar, System.Drawing.FontStyle.Regular);
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Enabled = false;
            this.btnExaminar.Location = new System.Drawing.Point(507, 124);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(37, 23);
            this.btnExaminar.TabIndex = 58;
            this.tagsExtender1.SetTag2(this.btnExaminar, null);
            this.tagsExtender1.SetTag3(this.btnExaminar, null);
            this.tagsExtender1.SetTagFontName(this.btnExaminar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnExaminar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btnExaminar, System.Drawing.FontStyle.Regular);
            this.btnExaminar.Text = "...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtArchivo1
            // 
            this.txtArchivo1.Enabled = false;
            this.txtArchivo1.Font = new System.Drawing.Font("Lato", 10F);
            this.txtArchivo1.Location = new System.Drawing.Point(27, 126);
            this.txtArchivo1.Name = "txtArchivo1";
            this.txtArchivo1.Size = new System.Drawing.Size(475, 23);
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
            this.label1.Location = new System.Drawing.Point(31, 94);
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
            this.label2.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(23, 231);
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
            // btnEditarRutas
            // 
            this.btnEditarRutas.BackColor = System.Drawing.Color.White;
            this.btnEditarRutas.BackgroundImage = global::LP2MegaAutos.Properties.Resources.editar;
            this.btnEditarRutas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarRutas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarRutas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarRutas.FlatAppearance.BorderSize = 0;
            this.btnEditarRutas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEditarRutas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEditarRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditarRutas.ForeColor = System.Drawing.Color.White;
            this.btnEditarRutas.Location = new System.Drawing.Point(561, 120);
            this.btnEditarRutas.Name = "btnEditarRutas";
            this.btnEditarRutas.Size = new System.Drawing.Size(32, 32);
            this.btnEditarRutas.TabIndex = 64;
            this.btnEditarRutas.TabStop = false;
            this.btnEditarRutas.Tag = "botonImagen";
            this.tagsExtender1.SetTag2(this.btnEditarRutas, null);
            this.tagsExtender1.SetTag3(this.btnEditarRutas, null);
            this.tagsExtender1.SetTagFontName(this.btnEditarRutas, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnEditarRutas, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btnEditarRutas, System.Drawing.FontStyle.Regular);
            this.btnEditarRutas.UseVisualStyleBackColor = false;
            this.btnEditarRutas.Click += new System.EventHandler(this.btnEditarRutas_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ArcRadiusBorde = 5;
            this.btnGuardar.ArcRadiusPanel = 5;
            this.btnGuardar.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnGuardar.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnGuardar.Controls.Add(this.btn_guardar);
            this.btnGuardar.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.btnGuardar.Location = new System.Drawing.Point(27, 164);
            this.btnGuardar.MenosHeightBorde = 1;
            this.btnGuardar.MenosHeightPanel = 1;
            this.btnGuardar.MenosWidthBorde = 1;
            this.btnGuardar.MenosWidthPanel = 1;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.PorcLuzColorBorde = 0;
            this.btnGuardar.Size = new System.Drawing.Size(119, 35);
            this.btnGuardar.TabIndex = 82;
            this.tagsExtender1.SetTag2(this.btnGuardar, null);
            this.tagsExtender1.SetTag3(this.btnGuardar, null);
            this.tagsExtender1.SetTagFontName(this.btnGuardar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnGuardar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btnGuardar, System.Drawing.FontStyle.Regular);
            this.btnGuardar.XBorde = 0;
            this.btnGuardar.XPanel = 0;
            this.btnGuardar.YBorde = 0;
            this.btnGuardar.YPanel = 0;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.Enabled = false;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
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
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.ArcRadiusBorde = 5;
            this.roundedPanel1.ArcRadiusPanel = 5;
            this.roundedPanel1.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.roundedPanel1.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.roundedPanel1.Controls.Add(this.btnDescargar1);
            this.roundedPanel1.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.roundedPanel1.Location = new System.Drawing.Point(166, 164);
            this.roundedPanel1.MenosHeightBorde = 1;
            this.roundedPanel1.MenosHeightPanel = 1;
            this.roundedPanel1.MenosWidthBorde = 1;
            this.roundedPanel1.MenosWidthPanel = 1;
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.PorcLuzColorBorde = 0;
            this.roundedPanel1.Size = new System.Drawing.Size(119, 35);
            this.roundedPanel1.TabIndex = 83;
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
            // btnDescargar1
            // 
            this.btnDescargar1.BackColor = System.Drawing.Color.Transparent;
            this.btnDescargar1.FlatAppearance.BorderSize = 0;
            this.btnDescargar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDescargar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargar1.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar1.ForeColor = System.Drawing.Color.White;
            this.btnDescargar1.Location = new System.Drawing.Point(0, 0);
            this.btnDescargar1.Name = "btnDescargar1";
            this.btnDescargar1.Size = new System.Drawing.Size(119, 35);
            this.btnDescargar1.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.btnDescargar1, null);
            this.tagsExtender1.SetTag3(this.btnDescargar1, null);
            this.tagsExtender1.SetTagFontName(this.btnDescargar1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnDescargar1, 15F);
            this.tagsExtender1.SetTagFontStyle(this.btnDescargar1, System.Drawing.FontStyle.Bold);
            this.btnDescargar1.Text = "Descargar";
            this.btnDescargar1.UseVisualStyleBackColor = false;
            this.btnDescargar1.Click += new System.EventHandler(this.btnDescargar1_Click);
            // 
            // pnlObtener
            // 
            this.pnlObtener.ArcRadiusBorde = 5;
            this.pnlObtener.ArcRadiusPanel = 5;
            this.pnlObtener.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.pnlObtener.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.pnlObtener.Controls.Add(this.btnObtener);
            this.pnlObtener.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.pnlObtener.Location = new System.Drawing.Point(27, 267);
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
            this.btnObtener.Enabled = false;
            this.btnObtener.FlatAppearance.BorderSize = 0;
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
            this.tagsExtender1.SetTagFontName(this.btnObtener, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnObtener, 15F);
            this.tagsExtender1.SetTagFontStyle(this.btnObtener, System.Drawing.FontStyle.Bold);
            this.btnObtener.Text = "Obtener Reporte";
            this.btnObtener.UseVisualStyleBackColor = false;
            this.btnObtener.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // ofdArchivo1
            // 
            this.ofdArchivo1.FileName = "ofdArchivo1";
            // 
            // ofdArchivo2
            // 
            this.ofdArchivo2.FileName = "ofdArchivo2";
            // 
            // pantallaInformacionEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlObtener);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditarRutas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArchivo1);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbl_nombreEmpresa);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "pantallaInformacionEmpresa";
            this.Size = new System.Drawing.Size(751, 520);
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.Load += new System.EventHandler(this.pantallaInformacionEmpresa_Load);
            this.btnGuardar.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.pnlObtener.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_nombreEmpresa;
        private TagsExtender tagsExtender1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtArchivo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditarRutas;
        private System.Windows.Forms.OpenFileDialog ofdArchivo1;
        private System.Windows.Forms.OpenFileDialog ofdArchivo2;
        private System.Windows.Forms.SaveFileDialog sfdArchivoEntrada;
        private System.Windows.Forms.SaveFileDialog sfdArchivoReporte;
        private RoundedPanel btnGuardar;
        private System.Windows.Forms.Button btn_guardar;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Button btnDescargar1;
        private RoundedPanel pnlObtener;
        private System.Windows.Forms.Button btnObtener;
    }
}
