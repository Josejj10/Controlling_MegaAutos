﻿namespace LP2MegaAutos
{
    partial class frmCuentaContable
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
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.title_bar = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.boton_minimizar = new System.Windows.Forms.Button();
            this.boton_cerrar = new System.Windows.Forms.Button();
            this.rpTopMain = new LP2MegaAutos.RoundedPanel();
            this.rnd_cancelar = new LP2MegaAutos.RoundedPanel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.rnd_guardar = new LP2MegaAutos.RoundedPanel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_CuentaContable = new System.Windows.Forms.Label();
            this.title_bar.SuspendLayout();
            this.rnd_cancelar.SuspendLayout();
            this.rnd_guardar.SuspendLayout();
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
            this.title_bar.Size = new System.Drawing.Size(595, 24);
            this.title_bar.TabIndex = 63;
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
            this.button3.Location = new System.Drawing.Point(571, -1);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 24);
            this.button3.TabIndex = 2;
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
            this.rpTopMain.Size = new System.Drawing.Size(595, 8);
            this.rpTopMain.TabIndex = 62;
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
            // rnd_cancelar
            // 
            this.rnd_cancelar.ArcRadiusBorde = 5;
            this.rnd_cancelar.ArcRadiusPanel = 5;
            this.rnd_cancelar.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rnd_cancelar.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rnd_cancelar.Controls.Add(this.btn_cancelar);
            this.rnd_cancelar.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rnd_cancelar.Location = new System.Drawing.Point(71, 385);
            this.rnd_cancelar.MenosHeightBorde = 1;
            this.rnd_cancelar.MenosHeightPanel = 1;
            this.rnd_cancelar.MenosWidthBorde = 1;
            this.rnd_cancelar.MenosWidthPanel = 1;
            this.rnd_cancelar.Name = "rnd_cancelar";
            this.rnd_cancelar.PorcLuzColorBorde = 0;
            this.rnd_cancelar.Size = new System.Drawing.Size(180, 35);
            this.rnd_cancelar.TabIndex = 74;
            this.tagsExtender1.SetTag2(this.rnd_cancelar, null);
            this.tagsExtender1.SetTag3(this.rnd_cancelar, null);
            this.tagsExtender1.SetTagFontName(this.rnd_cancelar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rnd_cancelar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rnd_cancelar, System.Drawing.FontStyle.Regular);
            this.rnd_cancelar.XBorde = 0;
            this.rnd_cancelar.XPanel = 0;
            this.rnd_cancelar.YBorde = 0;
            this.rnd_cancelar.YPanel = 0;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(1, 1);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(178, 33);
            this.btn_cancelar.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.btn_cancelar, null);
            this.tagsExtender1.SetTag3(this.btn_cancelar, null);
            this.tagsExtender1.SetTagFontName(this.btn_cancelar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btn_cancelar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btn_cancelar, System.Drawing.FontStyle.Regular);
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // rnd_guardar
            // 
            this.rnd_guardar.ArcRadiusBorde = 5;
            this.rnd_guardar.ArcRadiusPanel = 5;
            this.rnd_guardar.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rnd_guardar.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rnd_guardar.Controls.Add(this.btn_guardar);
            this.rnd_guardar.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rnd_guardar.Location = new System.Drawing.Point(363, 385);
            this.rnd_guardar.MenosHeightBorde = 1;
            this.rnd_guardar.MenosHeightPanel = 1;
            this.rnd_guardar.MenosWidthBorde = 1;
            this.rnd_guardar.MenosWidthPanel = 1;
            this.rnd_guardar.Name = "rnd_guardar";
            this.rnd_guardar.PorcLuzColorBorde = 0;
            this.rnd_guardar.Size = new System.Drawing.Size(180, 35);
            this.rnd_guardar.TabIndex = 73;
            this.tagsExtender1.SetTag2(this.rnd_guardar, null);
            this.tagsExtender1.SetTag3(this.rnd_guardar, null);
            this.tagsExtender1.SetTagFontName(this.rnd_guardar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rnd_guardar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rnd_guardar, System.Drawing.FontStyle.Regular);
            this.rnd_guardar.XBorde = 0;
            this.rnd_guardar.XPanel = 0;
            this.rnd_guardar.YBorde = 0;
            this.rnd_guardar.YPanel = 0;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(1, 1);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(178, 33);
            this.btn_guardar.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.btn_guardar, null);
            this.tagsExtender1.SetTag3(this.btn_guardar, null);
            this.tagsExtender1.SetTagFontName(this.btn_guardar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btn_guardar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btn_guardar, System.Drawing.FontStyle.Regular);
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_CuentaContable
            // 
            this.lbl_CuentaContable.AutoSize = true;
            this.lbl_CuentaContable.BackColor = System.Drawing.Color.White;
            this.lbl_CuentaContable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_CuentaContable.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CuentaContable.ForeColor = System.Drawing.Color.Black;
            this.lbl_CuentaContable.Location = new System.Drawing.Point(27, 42);
            this.lbl_CuentaContable.Name = "lbl_CuentaContable";
            this.lbl_CuentaContable.Size = new System.Drawing.Size(230, 35);
            this.lbl_CuentaContable.TabIndex = 75;
            this.tagsExtender1.SetTag2(this.lbl_CuentaContable, null);
            this.tagsExtender1.SetTag3(this.lbl_CuentaContable, null);
            this.tagsExtender1.SetTagFontName(this.lbl_CuentaContable, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.lbl_CuentaContable, 12F);
            this.tagsExtender1.SetTagFontStyle(this.lbl_CuentaContable, System.Drawing.FontStyle.Bold);
            this.lbl_CuentaContable.Text = "Cuenta Contable";
            this.lbl_CuentaContable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCuentaContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 431);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_CuentaContable);
            this.Controls.Add(this.rnd_cancelar);
            this.Controls.Add(this.rnd_guardar);
            this.Controls.Add(this.title_bar);
            this.Controls.Add(this.rpTopMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCuentaContable";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.title_bar.ResumeLayout(false);
            this.rnd_cancelar.ResumeLayout(false);
            this.rnd_guardar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TagsExtender tagsExtender1;
        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button boton_minimizar;
        private System.Windows.Forms.Button boton_cerrar;
        private RoundedPanel rpTopMain;
        private RoundedPanel rnd_cancelar;
        private System.Windows.Forms.Button btn_cancelar;
        private RoundedPanel rnd_guardar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_CuentaContable;
    }
}