﻿namespace LP2MegaAutos
{
    partial class itemDetalleReporte
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
            this.tlpEgreso = new System.Windows.Forms.TableLayoutPanel();
            this.rpRosa = new LP2MegaAutos.RoundedPanel();
            this.lblEgreso = new System.Windows.Forms.Label();
            this.tlpIngreso = new System.Windows.Forms.TableLayoutPanel();
            this.rpVerde = new LP2MegaAutos.RoundedPanel();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.tlpCuenta = new System.Windows.Forms.TableLayoutPanel();
            this.rpIngresos = new LP2MegaAutos.RoundedPanel();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.lblCuentaGrande = new System.Windows.Forms.Label();
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.tlpEgreso.SuspendLayout();
            this.tlpIngreso.SuspendLayout();
            this.tlpCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpEgreso
            // 
            this.tlpEgreso.ColumnCount = 2;
            this.tlpEgreso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.16133F));
            this.tlpEgreso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.83867F));
            this.tlpEgreso.Controls.Add(this.rpRosa, 0, 0);
            this.tlpEgreso.Controls.Add(this.lblEgreso, 0, 0);
            this.tlpEgreso.Location = new System.Drawing.Point(407, 0);
            this.tlpEgreso.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEgreso.Name = "tlpEgreso";
            this.tlpEgreso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlpEgreso.RowCount = 1;
            this.tlpEgreso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEgreso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpEgreso.Size = new System.Drawing.Size(127, 60);
            this.tlpEgreso.TabIndex = 7;
            this.tagsExtender1.SetTag2(this.tlpEgreso, null);
            this.tagsExtender1.SetTag3(this.tlpEgreso, null);
            this.tagsExtender1.SetTagFontName(this.tlpEgreso, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.tlpEgreso, 10F);
            this.tagsExtender1.SetTagFontStyle(this.tlpEgreso, System.Drawing.FontStyle.Regular);
            // 
            // rpRosa
            // 
            this.rpRosa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rpRosa.ArcRadiusBorde = 15;
            this.rpRosa.ArcRadiusPanel = 15;
            this.rpRosa.BackColor = System.Drawing.Color.Transparent;
            this.rpRosa.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rpRosa.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rpRosa.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Top;
            this.rpRosa.Location = new System.Drawing.Point(118, 5);
            this.rpRosa.MenosHeightBorde = 1;
            this.rpRosa.MenosHeightPanel = 1;
            this.rpRosa.MenosWidthBorde = 1;
            this.rpRosa.MenosWidthPanel = 1;
            this.rpRosa.Name = "rpRosa";
            this.rpRosa.PorcLuzColorBorde = 0;
            this.rpRosa.Size = new System.Drawing.Size(4, 50);
            this.rpRosa.TabIndex = 48;
            this.tagsExtender1.SetTag2(this.rpRosa, null);
            this.tagsExtender1.SetTag3(this.rpRosa, null);
            this.tagsExtender1.SetTagFontName(this.rpRosa, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpRosa, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpRosa, System.Drawing.FontStyle.Regular);
            this.rpRosa.XBorde = 0;
            this.rpRosa.XPanel = 0;
            this.rpRosa.YBorde = 0;
            this.rpRosa.YPanel = 0;
            // 
            // lblEgreso
            // 
            this.lblEgreso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEgreso.AutoSize = true;
            this.lblEgreso.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEgreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblEgreso.Location = new System.Drawing.Point(8, 20);
            this.lblEgreso.Name = "lblEgreso";
            this.lblEgreso.Size = new System.Drawing.Size(102, 19);
            this.lblEgreso.TabIndex = 47;
            this.tagsExtender1.SetTag2(this.lblEgreso, null);
            this.tagsExtender1.SetTag3(this.lblEgreso, null);
            this.tagsExtender1.SetTagFontName(this.lblEgreso, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblEgreso, 12F);
            this.tagsExtender1.SetTagFontStyle(this.lblEgreso, System.Drawing.FontStyle.Bold);
            this.lblEgreso.Text = "9,999,999.00";
            this.lblEgreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlpIngreso
            // 
            this.tlpIngreso.ColumnCount = 2;
            this.tlpIngreso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.16133F));
            this.tlpIngreso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.83867F));
            this.tlpIngreso.Controls.Add(this.rpVerde, 0, 0);
            this.tlpIngreso.Controls.Add(this.lblIngreso, 0, 0);
            this.tlpIngreso.Location = new System.Drawing.Point(279, 0);
            this.tlpIngreso.Margin = new System.Windows.Forms.Padding(0);
            this.tlpIngreso.Name = "tlpIngreso";
            this.tlpIngreso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlpIngreso.RowCount = 1;
            this.tlpIngreso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIngreso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpIngreso.Size = new System.Drawing.Size(127, 60);
            this.tlpIngreso.TabIndex = 8;
            this.tagsExtender1.SetTag2(this.tlpIngreso, null);
            this.tagsExtender1.SetTag3(this.tlpIngreso, null);
            this.tagsExtender1.SetTagFontName(this.tlpIngreso, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.tlpIngreso, 10F);
            this.tagsExtender1.SetTagFontStyle(this.tlpIngreso, System.Drawing.FontStyle.Regular);
            // 
            // rpVerde
            // 
            this.rpVerde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rpVerde.ArcRadiusBorde = 15;
            this.rpVerde.ArcRadiusPanel = 15;
            this.rpVerde.BackColor = System.Drawing.Color.Transparent;
            this.rpVerde.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.rpVerde.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.rpVerde.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Top;
            this.rpVerde.Location = new System.Drawing.Point(118, 5);
            this.rpVerde.MenosHeightBorde = 1;
            this.rpVerde.MenosHeightPanel = 1;
            this.rpVerde.MenosWidthBorde = 1;
            this.rpVerde.MenosWidthPanel = 1;
            this.rpVerde.Name = "rpVerde";
            this.rpVerde.PorcLuzColorBorde = 0;
            this.rpVerde.Size = new System.Drawing.Size(4, 50);
            this.rpVerde.TabIndex = 48;
            this.tagsExtender1.SetTag2(this.rpVerde, null);
            this.tagsExtender1.SetTag3(this.rpVerde, null);
            this.tagsExtender1.SetTagFontName(this.rpVerde, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpVerde, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpVerde, System.Drawing.FontStyle.Regular);
            this.rpVerde.XBorde = 0;
            this.rpVerde.XPanel = 0;
            this.rpVerde.YBorde = 0;
            this.rpVerde.YPanel = 0;
            // 
            // lblIngreso
            // 
            this.lblIngreso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblIngreso.Location = new System.Drawing.Point(8, 20);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(102, 19);
            this.lblIngreso.TabIndex = 47;
            this.tagsExtender1.SetTag2(this.lblIngreso, null);
            this.tagsExtender1.SetTag3(this.lblIngreso, null);
            this.tagsExtender1.SetTagFontName(this.lblIngreso, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblIngreso, 12F);
            this.tagsExtender1.SetTagFontStyle(this.lblIngreso, System.Drawing.FontStyle.Bold);
            this.lblIngreso.Text = "9,999,999.00";
            this.lblIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlpCuenta
            // 
            this.tlpCuenta.AutoScroll = true;
            this.tlpCuenta.ColumnCount = 2;
            this.tlpCuenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.501548F));
            this.tlpCuenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.49845F));
            this.tlpCuenta.Controls.Add(this.rpIngresos, 0, 0);
            this.tlpCuenta.Controls.Add(this.lblTipoCuenta, 1, 1);
            this.tlpCuenta.Controls.Add(this.lblCuentaGrande, 1, 0);
            this.tlpCuenta.Location = new System.Drawing.Point(0, 0);
            this.tlpCuenta.Name = "tlpCuenta";
            this.tlpCuenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlpCuenta.RowCount = 2;
            this.tlpCuenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.66666F));
            this.tlpCuenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.33333F));
            this.tlpCuenta.Size = new System.Drawing.Size(276, 60);
            this.tlpCuenta.TabIndex = 9;
            this.tagsExtender1.SetTag2(this.tlpCuenta, null);
            this.tagsExtender1.SetTag3(this.tlpCuenta, null);
            this.tagsExtender1.SetTagFontName(this.tlpCuenta, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.tlpCuenta, 10F);
            this.tagsExtender1.SetTagFontStyle(this.tlpCuenta, System.Drawing.FontStyle.Regular);
            // 
            // rpIngresos
            // 
            this.rpIngresos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rpIngresos.ArcRadiusBorde = 15;
            this.rpIngresos.ArcRadiusPanel = 15;
            this.rpIngresos.BackColor = System.Drawing.Color.Transparent;
            this.rpIngresos.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.rpIngresos.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.rpIngresos.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Top;
            this.rpIngresos.Location = new System.Drawing.Point(10, 3);
            this.rpIngresos.MenosHeightBorde = 1;
            this.rpIngresos.MenosHeightPanel = 1;
            this.rpIngresos.MenosWidthBorde = 1;
            this.rpIngresos.MenosWidthPanel = 1;
            this.rpIngresos.Name = "rpIngresos";
            this.rpIngresos.PorcLuzColorBorde = 0;
            this.tlpCuenta.SetRowSpan(this.rpIngresos, 2);
            this.rpIngresos.Size = new System.Drawing.Size(4, 54);
            this.rpIngresos.TabIndex = 44;
            this.tagsExtender1.SetTag2(this.rpIngresos, null);
            this.tagsExtender1.SetTag3(this.rpIngresos, null);
            this.tagsExtender1.SetTagFontName(this.rpIngresos, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpIngresos, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpIngresos, System.Drawing.FontStyle.Regular);
            this.rpIngresos.XBorde = 0;
            this.rpIngresos.XPanel = 0;
            this.rpIngresos.YBorde = 0;
            this.rpIngresos.YPanel = 0;
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoCuenta.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.lblTipoCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTipoCuenta.Location = new System.Drawing.Point(20, 43);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(101, 17);
            this.lblTipoCuenta.TabIndex = 47;
            this.tagsExtender1.SetTag2(this.lblTipoCuenta, null);
            this.tagsExtender1.SetTag3(this.lblTipoCuenta, null);
            this.tagsExtender1.SetTagFontName(this.lblTipoCuenta, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblTipoCuenta, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lblTipoCuenta, System.Drawing.FontStyle.Bold);
            this.lblTipoCuenta.Text = "Tipo de Cuenta";
            this.lblTipoCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCuentaGrande
            // 
            this.lblCuentaGrande.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCuentaGrande.AutoSize = true;
            this.lblCuentaGrande.BackColor = System.Drawing.Color.Transparent;
            this.lblCuentaGrande.Font = new System.Drawing.Font("Lato", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblCuentaGrande.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblCuentaGrande.Location = new System.Drawing.Point(20, 11);
            this.lblCuentaGrande.Name = "lblCuentaGrande";
            this.lblCuentaGrande.Size = new System.Drawing.Size(125, 21);
            this.lblCuentaGrande.TabIndex = 45;
            this.tagsExtender1.SetTag2(this.lblCuentaGrande, null);
            this.tagsExtender1.SetTag3(this.lblCuentaGrande, null);
            this.tagsExtender1.SetTagFontName(this.lblCuentaGrande, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.lblCuentaGrande, 12.5F);
            this.tagsExtender1.SetTagFontStyle(this.lblCuentaGrande, System.Drawing.FontStyle.Bold);
            this.lblCuentaGrande.Text = "Cuenta Grande";
            this.lblCuentaGrande.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemDetalleReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpCuenta);
            this.Controls.Add(this.tlpIngreso);
            this.Controls.Add(this.tlpEgreso);
            this.Name = "itemDetalleReporte";
            this.Size = new System.Drawing.Size(534, 60);
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.tlpEgreso.ResumeLayout(false);
            this.tlpEgreso.PerformLayout();
            this.tlpIngreso.ResumeLayout(false);
            this.tlpIngreso.PerformLayout();
            this.tlpCuenta.ResumeLayout(false);
            this.tlpCuenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpEgreso;
        private RoundedPanel rpRosa;
        private System.Windows.Forms.Label lblEgreso;
        private System.Windows.Forms.TableLayoutPanel tlpIngreso;
        private RoundedPanel rpVerde;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.TableLayoutPanel tlpCuenta;
        private RoundedPanel rpIngresos;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.Label lblCuentaGrande;
        private TagsExtender tagsExtender1;
    }
}
