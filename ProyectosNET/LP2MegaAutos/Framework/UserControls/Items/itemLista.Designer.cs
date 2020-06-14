﻿namespace LP2MegaAutos
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
            this.rpItem = new LP2MegaAutos.RoundedPanel();
            this.tlpAgregado = new System.Windows.Forms.TableLayoutPanel();
            this.lblAgregadoEl = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPor = new System.Windows.Forms.Label();
            this.lblTercerDato = new System.Windows.Forms.Label();
            this.lblSecundario = new System.Windows.Forms.Label();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.btnEditar = new System.Windows.Forms.Button();
            this.rpItem.SuspendLayout();
            this.tlpAgregado.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpItem
            // 
            this.rpItem.ArcRadiusBorde = 21;
            this.rpItem.ArcRadiusPanel = 21;
            this.rpItem.BackColor = System.Drawing.Color.Transparent;
            this.rpItem.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.rpItem.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpItem.Controls.Add(this.btnEditar);
            this.rpItem.Controls.Add(this.tlpAgregado);
            this.rpItem.Controls.Add(this.lblTercerDato);
            this.rpItem.Controls.Add(this.lblSecundario);
            this.rpItem.Controls.Add(this.lblPrincipal);
            this.rpItem.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpItem.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rpItem.Location = new System.Drawing.Point(0, 0);
            this.rpItem.Margin = new System.Windows.Forms.Padding(4);
            this.rpItem.MenosHeightBorde = 1;
            this.rpItem.MenosHeightPanel = 1;
            this.rpItem.MenosWidthBorde = 1;
            this.rpItem.MenosWidthPanel = 1;
            this.rpItem.Name = "rpItem";
            this.rpItem.PorcLuzColorBorde = 0;
            this.rpItem.Size = new System.Drawing.Size(663, 128);
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
            this.rpItem.Click += new System.EventHandler(this.itemLista_Click);
            this.rpItem.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.rpItem.MouseLeave += new System.EventHandler(this.rpItem_MouseLeave);
            // 
            // tlpAgregado
            // 
            this.tlpAgregado.BackColor = System.Drawing.Color.Transparent;
            this.tlpAgregado.ColumnCount = 4;
            this.tlpAgregado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAgregado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tlpAgregado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpAgregado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 313F));
            this.tlpAgregado.Controls.Add(this.lblAgregadoEl, 0, 0);
            this.tlpAgregado.Controls.Add(this.lblFecha, 1, 0);
            this.tlpAgregado.Controls.Add(this.lblNombre, 3, 0);
            this.tlpAgregado.Controls.Add(this.lblPor, 2, 0);
            this.tlpAgregado.Location = new System.Drawing.Point(41, 96);
            this.tlpAgregado.Margin = new System.Windows.Forms.Padding(4);
            this.tlpAgregado.Name = "tlpAgregado";
            this.tlpAgregado.RowCount = 1;
            this.tlpAgregado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAgregado.Size = new System.Drawing.Size(593, 26);
            this.tlpAgregado.TabIndex = 8;
            this.tagsExtender1.SetTag2(this.tlpAgregado, null);
            this.tagsExtender1.SetTag3(this.tlpAgregado, null);
            this.tagsExtender1.SetTagFontName(this.tlpAgregado, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.tlpAgregado, 10F);
            this.tagsExtender1.SetTagFontStyle(this.tlpAgregado, System.Drawing.FontStyle.Regular);
            this.tlpAgregado.Click += new System.EventHandler(this.itemLista_Click);
            this.tlpAgregado.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.tlpAgregado.MouseLeave += new System.EventHandler(this.rpItem_MouseLeave);
            // 
            // lblAgregadoEl
            // 
            this.lblAgregadoEl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAgregadoEl.AutoSize = true;
            this.lblAgregadoEl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.lblAgregadoEl.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblAgregadoEl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblAgregadoEl.Location = new System.Drawing.Point(4, 2);
            this.lblAgregadoEl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgregadoEl.Name = "lblAgregadoEl";
            this.lblAgregadoEl.Size = new System.Drawing.Size(105, 21);
            this.lblAgregadoEl.TabIndex = 3;
            this.tagsExtender1.SetTag2(this.lblAgregadoEl, null);
            this.tagsExtender1.SetTag3(this.lblAgregadoEl, null);
            this.tagsExtender1.SetTagFontName(this.lblAgregadoEl, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lblAgregadoEl, 9F);
            this.tagsExtender1.SetTagFontStyle(this.lblAgregadoEl, System.Drawing.FontStyle.Regular);
            this.lblAgregadoEl.Text = "Agregado el ";
            this.lblAgregadoEl.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.lblAgregadoEl.MouseLeave += new System.EventHandler(this.rpItem_MouseLeave);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.lblFecha.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblFecha.Location = new System.Drawing.Point(121, 2);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(97, 21);
            this.lblFecha.TabIndex = 4;
            this.tagsExtender1.SetTag2(this.lblFecha, null);
            this.tagsExtender1.SetTag3(this.lblFecha, null);
            this.tagsExtender1.SetTagFontName(this.lblFecha, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lblFecha, 9F);
            this.tagsExtender1.SetTagFontStyle(this.lblFecha, System.Drawing.FontStyle.Bold);
            this.lblFecha.Text = "25/05/2020";
            this.lblFecha.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.lblFecha.MouseLeave += new System.EventHandler(this.rpItem_MouseLeave);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.lblNombre.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblNombre.Location = new System.Drawing.Point(284, 2);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(122, 21);
            this.lblNombre.TabIndex = 6;
            this.tagsExtender1.SetTag2(this.lblNombre, null);
            this.tagsExtender1.SetTag3(this.lblNombre, null);
            this.tagsExtender1.SetTagFontName(this.lblNombre, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lblNombre, 9F);
            this.tagsExtender1.SetTagFontStyle(this.lblNombre, System.Drawing.FontStyle.Bold);
            this.lblNombre.Text = "Percy Jackson";
            this.lblNombre.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.lblNombre.MouseLeave += new System.EventHandler(this.rpItem_MouseLeave);
            // 
            // lblPor
            // 
            this.lblPor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPor.AutoSize = true;
            this.lblPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.lblPor.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblPor.Location = new System.Drawing.Point(233, 2);
            this.lblPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPor.Name = "lblPor";
            this.lblPor.Size = new System.Drawing.Size(35, 21);
            this.lblPor.TabIndex = 5;
            this.tagsExtender1.SetTag2(this.lblPor, null);
            this.tagsExtender1.SetTag3(this.lblPor, null);
            this.tagsExtender1.SetTagFontName(this.lblPor, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lblPor, 9F);
            this.tagsExtender1.SetTagFontStyle(this.lblPor, System.Drawing.FontStyle.Regular);
            this.lblPor.Text = "por";
            this.lblPor.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.lblPor.MouseLeave += new System.EventHandler(this.rpItem_MouseLeave);
            // 
            // lblTercerDato
            // 
            this.lblTercerDato.AutoSize = true;
            this.lblTercerDato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.lblTercerDato.Font = new System.Drawing.Font("Montserrat", 11F);
            this.lblTercerDato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblTercerDato.Location = new System.Drawing.Point(36, 66);
            this.lblTercerDato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTercerDato.Name = "lblTercerDato";
            this.lblTercerDato.Size = new System.Drawing.Size(167, 26);
            this.lblTercerDato.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.lblTercerDato, null);
            this.tagsExtender1.SetTag3(this.lblTercerDato, null);
            this.tagsExtender1.SetTagFontName(this.lblTercerDato, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lblTercerDato, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblTercerDato, System.Drawing.FontStyle.Regular);
            this.lblTercerDato.Text = "TextoTercerDato";
            this.lblTercerDato.Click += new System.EventHandler(this.itemLista_Click);
            this.lblTercerDato.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.lblTercerDato.MouseLeave += new System.EventHandler(this.rpItem_MouseLeave);
            // 
            // lblSecundario
            // 
            this.lblSecundario.AutoSize = true;
            this.lblSecundario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.lblSecundario.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold);
            this.lblSecundario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lblSecundario.Location = new System.Drawing.Point(36, 41);
            this.lblSecundario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecundario.Name = "lblSecundario";
            this.lblSecundario.Size = new System.Drawing.Size(178, 26);
            this.lblSecundario.TabIndex = 1;
            this.tagsExtender1.SetTag2(this.lblSecundario, null);
            this.tagsExtender1.SetTag3(this.lblSecundario, null);
            this.tagsExtender1.SetTagFontName(this.lblSecundario, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lblSecundario, 11F);
            this.tagsExtender1.SetTagFontStyle(this.lblSecundario, System.Drawing.FontStyle.Bold);
            this.lblSecundario.Text = "TextoSecundario";
            this.lblSecundario.Click += new System.EventHandler(this.itemLista_Click);
            this.lblSecundario.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.lblSecundario.MouseLeave += new System.EventHandler(this.rpItem_MouseLeave);
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.lblPrincipal.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.lblPrincipal.Location = new System.Drawing.Point(36, 14);
            this.lblPrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(164, 28);
            this.lblPrincipal.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.lblPrincipal, null);
            this.tagsExtender1.SetTag3(this.lblPrincipal, null);
            this.tagsExtender1.SetTagFontName(this.lblPrincipal, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lblPrincipal, 12F);
            this.tagsExtender1.SetTagFontStyle(this.lblPrincipal, System.Drawing.FontStyle.Bold);
            this.lblPrincipal.Text = "TextoPrincipal";
            this.lblPrincipal.Click += new System.EventHandler(this.itemLista_Click);
            this.lblPrincipal.MouseEnter += new System.EventHandler(this.rpItem_MouseEnter);
            this.lblPrincipal.MouseLeave += new System.EventHandler(this.rpItem_MouseLeave);
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
            this.btnEditar.Location = new System.Drawing.Point(586, 14);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(37, 34);
            this.btnEditar.TabIndex = 9;
            this.tagsExtender1.SetTag2(this.btnEditar, null);
            this.tagsExtender1.SetTag3(this.btnEditar, null);
            this.tagsExtender1.SetTagFontName(this.btnEditar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnEditar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btnEditar, System.Drawing.FontStyle.Regular);
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // itemLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rpItem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "itemLista";
            this.Size = new System.Drawing.Size(663, 128);
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.rpItem.ResumeLayout(false);
            this.rpItem.PerformLayout();
            this.tlpAgregado.ResumeLayout(false);
            this.tlpAgregado.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tlpAgregado;
        private System.Windows.Forms.Button btnEditar;
    }
}
