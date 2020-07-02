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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnObtener = new System.Windows.Forms.Button();
            this.btnDescargar1 = new System.Windows.Forms.Button();
            this.ofdArchivo1 = new System.Windows.Forms.OpenFileDialog();
            this.ofdArchivo2 = new System.Windows.Forms.OpenFileDialog();
            this.sfdArchivoEntrada = new System.Windows.Forms.SaveFileDialog();
            this.sfdArchivoReporte = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lbl_nombreEmpresa
            // 
            this.lbl_nombreEmpresa.AutoSize = true;
            this.lbl_nombreEmpresa.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.lbl_nombreEmpresa.Location = new System.Drawing.Point(32, 25);
            this.lbl_nombreEmpresa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_nombreEmpresa.Name = "lbl_nombreEmpresa";
            this.lbl_nombreEmpresa.Size = new System.Drawing.Size(211, 45);
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
            this.panel4.Location = new System.Drawing.Point(25, 94);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(959, 2);
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
            this.btnEditar.Location = new System.Drawing.Point(281, 25);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(43, 39);
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
            this.btnExaminar.Location = new System.Drawing.Point(676, 153);
            this.btnExaminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(49, 28);
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
            this.txtArchivo1.Location = new System.Drawing.Point(36, 155);
            this.txtArchivo1.Margin = new System.Windows.Forms.Padding(4);
            this.txtArchivo1.Name = "txtArchivo1";
            this.txtArchivo1.Size = new System.Drawing.Size(632, 27);
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
            this.label1.Location = new System.Drawing.Point(41, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 30);
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
            this.label2.Location = new System.Drawing.Point(35, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 30);
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
            this.btnEditarRutas.Location = new System.Drawing.Point(931, 104);
            this.btnEditarRutas.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarRutas.Name = "btnEditarRutas";
            this.btnEditarRutas.Size = new System.Drawing.Size(43, 39);
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
            this.btnGuardar.Location = new System.Drawing.Point(733, 153);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 28);
            this.btnGuardar.TabIndex = 65;
            this.tagsExtender1.SetTag2(this.btnGuardar, null);
            this.tagsExtender1.SetTag3(this.btnGuardar, null);
            this.tagsExtender1.SetTagFontName(this.btnGuardar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnGuardar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btnGuardar, System.Drawing.FontStyle.Regular);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnObtener
            // 
            this.btnObtener.Location = new System.Drawing.Point(234, 224);
            this.btnObtener.Margin = new System.Windows.Forms.Padding(4);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(171, 28);
            this.btnObtener.TabIndex = 66;
            this.tagsExtender1.SetTag2(this.btnObtener, null);
            this.tagsExtender1.SetTag3(this.btnObtener, null);
            this.tagsExtender1.SetTagFontName(this.btnObtener, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnObtener, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btnObtener, System.Drawing.FontStyle.Regular);
            this.btnObtener.Text = "Obtener Reporte";
            this.btnObtener.UseVisualStyleBackColor = true;
            this.btnObtener.Visible = false;
            this.btnObtener.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnDescargar1
            // 
            this.btnDescargar1.Location = new System.Drawing.Point(833, 153);
            this.btnDescargar1.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescargar1.Name = "btnDescargar1";
            this.btnDescargar1.Size = new System.Drawing.Size(100, 28);
            this.btnDescargar1.TabIndex = 67;
            this.tagsExtender1.SetTag2(this.btnDescargar1, null);
            this.tagsExtender1.SetTag3(this.btnDescargar1, null);
            this.tagsExtender1.SetTagFontName(this.btnDescargar1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnDescargar1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btnDescargar1, System.Drawing.FontStyle.Regular);
            this.btnDescargar1.Text = "Descargar último archivo";
            this.btnDescargar1.UseVisualStyleBackColor = true;
            this.btnDescargar1.Click += new System.EventHandler(this.btnDescargar1_Click);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDescargar1);
            this.Controls.Add(this.btnObtener);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditarRutas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArchivo1);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbl_nombreEmpresa);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "pantallaInformacionEmpresa";
            this.Size = new System.Drawing.Size(1001, 640);
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.OpenFileDialog ofdArchivo1;
        private System.Windows.Forms.OpenFileDialog ofdArchivo2;
        private System.Windows.Forms.Button btnDescargar1;
        private System.Windows.Forms.SaveFileDialog sfdArchivoEntrada;
        private System.Windows.Forms.SaveFileDialog sfdArchivoReporte;
    }
}
