namespace LP2MegaAutos
{
    partial class itemLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemLista));
            this.rpItem = new LP2MegaAutos.RoundedPanel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblAgregadoEl = new System.Windows.Forms.Label();
            this.lblTercerDato = new System.Windows.Forms.Label();
            this.lblSecundario = new System.Windows.Forms.Label();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.rpItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpItem
            // 
            this.rpItem.ArcRadiusBorde = 21;
            this.rpItem.ArcRadiusPanel = 21;
            this.rpItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpItem.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.rpItem.ColorPanel = System.Drawing.Color.White;
            this.rpItem.Controls.Add(this.btnEditar);
            this.rpItem.Controls.Add(this.lblNombre);
            this.rpItem.Controls.Add(this.lblPor);
            this.rpItem.Controls.Add(this.lblFecha);
            this.rpItem.Controls.Add(this.lblAgregadoEl);
            this.rpItem.Controls.Add(this.lblTercerDato);
            this.rpItem.Controls.Add(this.lblSecundario);
            this.rpItem.Controls.Add(this.lblPrincipal);
            this.rpItem.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpItem.Location = new System.Drawing.Point(0, 0);
            this.rpItem.MenosHeightBorde = 1;
            this.rpItem.MenosHeightPanel = 1;
            this.rpItem.MenosWidthBorde = 1;
            this.rpItem.MenosWidthPanel = 1;
            this.rpItem.Name = "rpItem";
            this.rpItem.PorcLuzColorBorde = 0;
            this.rpItem.Size = new System.Drawing.Size(497, 104);
            this.rpItem.TabIndex = 2;
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
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(444, 10);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(32, 32);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.TabStop = false;
            this.btnEditar.Tag = "botonImagen";
            this.tagsExtender1.SetTag2(this.btnEditar, null);
            this.tagsExtender1.SetTag3(this.btnEditar, null);
            this.tagsExtender1.SetTagFontName(this.btnEditar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnEditar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btnEditar, System.Drawing.FontStyle.Regular);
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblNombre.Location = new System.Drawing.Point(232, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 17);
            this.lblNombre.TabIndex = 6;
            this.tagsExtender1.SetTag2(this.lblNombre, null);
            this.tagsExtender1.SetTag3(this.lblNombre, null);
            this.tagsExtender1.SetTagFontName(this.lblNombre, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lblNombre, 9F);
            this.tagsExtender1.SetTagFontStyle(this.lblNombre, System.Drawing.FontStyle.Bold);
            this.lblNombre.Text = "Percy Jackson";
            // 
            // lblPor
            // 
            this.lblPor.AutoSize = true;
            this.lblPor.BackColor = System.Drawing.Color.White;
            this.lblPor.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblPor.Location = new System.Drawing.Point(206, 83);
            this.lblPor.Name = "lblPor";
            this.lblPor.Size = new System.Drawing.Size(29, 17);
            this.lblPor.TabIndex = 5;
            this.tagsExtender1.SetTag2(this.lblPor, null);
            this.tagsExtender1.SetTag3(this.lblPor, null);
            this.tagsExtender1.SetTagFontName(this.lblPor, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lblPor, 9F);
            this.tagsExtender1.SetTagFontStyle(this.lblPor, System.Drawing.FontStyle.Regular);
            this.lblPor.Text = "por";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.White;
            this.lblFecha.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblFecha.Location = new System.Drawing.Point(107, 83);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 17);
            this.lblFecha.TabIndex = 4;
            this.tagsExtender1.SetTag2(this.lblFecha, null);
            this.tagsExtender1.SetTag3(this.lblFecha, null);
            this.tagsExtender1.SetTagFontName(this.lblFecha, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lblFecha, 9F);
            this.tagsExtender1.SetTagFontStyle(this.lblFecha, System.Drawing.FontStyle.Bold);
            this.lblFecha.Text = "dd - mm - aaaa";
            // 
            // lblAgregadoEl
            // 
            this.lblAgregadoEl.AutoSize = true;
            this.lblAgregadoEl.BackColor = System.Drawing.Color.White;
            this.lblAgregadoEl.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblAgregadoEl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblAgregadoEl.Location = new System.Drawing.Point(28, 83);
            this.lblAgregadoEl.Name = "lblAgregadoEl";
            this.lblAgregadoEl.Size = new System.Drawing.Size(84, 17);
            this.lblAgregadoEl.TabIndex = 3;
            this.tagsExtender1.SetTag2(this.lblAgregadoEl, null);
            this.tagsExtender1.SetTag3(this.lblAgregadoEl, null);
            this.tagsExtender1.SetTagFontName(this.lblAgregadoEl, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lblAgregadoEl, 9F);
            this.tagsExtender1.SetTagFontStyle(this.lblAgregadoEl, System.Drawing.FontStyle.Regular);
            this.lblAgregadoEl.Text = "Agregado el ";
            // 
            // lblTercerDato
            // 
            this.lblTercerDato.AutoSize = true;
            this.lblTercerDato.BackColor = System.Drawing.Color.White;
            this.lblTercerDato.Font = new System.Drawing.Font("Montserrat", 11F);
            this.lblTercerDato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblTercerDato.Location = new System.Drawing.Point(27, 54);
            this.lblTercerDato.Name = "lblTercerDato";
            this.lblTercerDato.Size = new System.Drawing.Size(131, 21);
            this.lblTercerDato.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.lblTercerDato, null);
            this.tagsExtender1.SetTag3(this.lblTercerDato, null);
            this.tagsExtender1.SetTagFontName(this.lblTercerDato, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lblTercerDato, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblTercerDato, System.Drawing.FontStyle.Regular);
            this.lblTercerDato.Text = "TextoTercerDato";
            // 
            // lblSecundario
            // 
            this.lblSecundario.AutoSize = true;
            this.lblSecundario.BackColor = System.Drawing.Color.White;
            this.lblSecundario.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold);
            this.lblSecundario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblSecundario.Location = new System.Drawing.Point(27, 33);
            this.lblSecundario.Name = "lblSecundario";
            this.lblSecundario.Size = new System.Drawing.Size(141, 21);
            this.lblSecundario.TabIndex = 1;
            this.tagsExtender1.SetTag2(this.lblSecundario, null);
            this.tagsExtender1.SetTag3(this.lblSecundario, null);
            this.tagsExtender1.SetTagFontName(this.lblSecundario, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lblSecundario, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblSecundario, System.Drawing.FontStyle.Bold);
            this.lblSecundario.Text = "TextoSecundario";
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.BackColor = System.Drawing.Color.White;
            this.lblPrincipal.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.lblPrincipal.Location = new System.Drawing.Point(27, 14);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(131, 22);
            this.lblPrincipal.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.lblPrincipal, null);
            this.tagsExtender1.SetTag3(this.lblPrincipal, null);
            this.tagsExtender1.SetTagFontName(this.lblPrincipal, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lblPrincipal, 12F);
            this.tagsExtender1.SetTagFontStyle(this.lblPrincipal, System.Drawing.FontStyle.Bold);
            this.lblPrincipal.Text = "TextoPrincipal";
            // 
            // itemLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rpItem);
            this.Name = "itemLista";
            this.Size = new System.Drawing.Size(497, 104);
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.rpItem.ResumeLayout(false);
            this.rpItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel rpItem;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblTercerDato;
        private System.Windows.Forms.Label lblSecundario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblAgregadoEl;
        private TagsExtender tagsExtender1;
        private System.Windows.Forms.Button btnEditar;
    }
}
