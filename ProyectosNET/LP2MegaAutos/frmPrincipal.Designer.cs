namespace LP2MegaAutos
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.title_bar_2 = new System.Windows.Forms.Panel();
            this.title_bar = new System.Windows.Forms.Panel();
            this.boton_minimizar = new System.Windows.Forms.Button();
            this.boton_cerrar = new System.Windows.Forms.Button();
            this.reloj_dark = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new MetroFramework.Controls.MetroPanel();
            this.panel_toggle_nocturno = new System.Windows.Forms.Panel();
            this.boton_toggle_nocturno = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.btnVerReportes = new System.Windows.Forms.Button();
            this.btnActualizarBD = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel_logo_empresa = new System.Windows.Forms.Panel();
            this.tags = new LP2MegaAutos.TagsExtender();
            this.pnlBackBackground = new System.Windows.Forms.Panel();
            this.frontBackground = new LP2MegaAutos.RoundedPanel();
            this.title_bar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel_toggle_nocturno.SuspendLayout();
            this.pnlBackBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_bar_2
            // 
            this.title_bar_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.title_bar_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_bar_2.Enabled = false;
            this.title_bar_2.Location = new System.Drawing.Point(0, 24);
            this.title_bar_2.Name = "title_bar_2";
            this.title_bar_2.Size = new System.Drawing.Size(832, 8);
            this.title_bar_2.TabIndex = 1;
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
            this.title_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_bar.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.title_bar.Location = new System.Drawing.Point(0, 0);
            this.title_bar.Name = "title_bar";
            this.title_bar.Size = new System.Drawing.Size(832, 24);
            this.title_bar.TabIndex = 2;
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
            this.boton_minimizar.Location = new System.Drawing.Point(784, 0);
            this.boton_minimizar.Name = "boton_minimizar";
            this.boton_minimizar.Size = new System.Drawing.Size(24, 24);
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
            this.boton_cerrar.Location = new System.Drawing.Point(808, 0);
            this.boton_cerrar.Margin = new System.Windows.Forms.Padding(0);
            this.boton_cerrar.Name = "boton_cerrar";
            this.boton_cerrar.Size = new System.Drawing.Size(24, 24);
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
            // reloj_dark
            // 
            this.reloj_dark.Interval = 25;
            this.reloj_dark.Tick += new System.EventHandler(this.reloj_dark_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.panelMenu.Controls.Add(this.panel_toggle_nocturno);
            this.panelMenu.Controls.Add(this.btnAjustes);
            this.panelMenu.Controls.Add(this.btnVerReportes);
            this.panelMenu.Controls.Add(this.btnActualizarBD);
            this.panelMenu.Controls.Add(this.btnGenerarReporte);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panel_logo_empresa);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.HorizontalScrollbarBarColor = true;
            this.panelMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMenu.HorizontalScrollbarSize = 10;
            this.panelMenu.Location = new System.Drawing.Point(0, 32);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(81, 520);
            this.panelMenu.TabIndex = 3;
            this.panelMenu.Tag = "panelMenu";
            this.tags.SetTag2(this.panelMenu, null);
            this.tags.SetTag3(this.panelMenu, null);
            this.tags.SetTagFontName(this.panelMenu, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.panelMenu, 10F);
            this.tags.SetTagFontStyle(this.panelMenu, System.Drawing.FontStyle.Regular);
            this.panelMenu.UseCustomBackColor = true;
            this.panelMenu.UseCustomForeColor = true;
            this.panelMenu.VerticalScrollbarBarColor = true;
            this.panelMenu.VerticalScrollbarHighlightOnWheel = false;
            this.panelMenu.VerticalScrollbarSize = 10;
            // 
            // panel_toggle_nocturno
            // 
            this.panel_toggle_nocturno.BackColor = System.Drawing.Color.Transparent;
            this.panel_toggle_nocturno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_toggle_nocturno.BackgroundImage")));
            this.panel_toggle_nocturno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_toggle_nocturno.Controls.Add(this.boton_toggle_nocturno);
            this.panel_toggle_nocturno.Location = new System.Drawing.Point(-6, 457);
            this.panel_toggle_nocturno.Name = "panel_toggle_nocturno";
            this.panel_toggle_nocturno.Size = new System.Drawing.Size(95, 60);
            this.panel_toggle_nocturno.TabIndex = 25;
            this.panel_toggle_nocturno.Tag = "button";
            this.tags.SetTag2(this.panel_toggle_nocturno, null);
            this.tags.SetTag3(this.panel_toggle_nocturno, null);
            this.tags.SetTagFontName(this.panel_toggle_nocturno, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.panel_toggle_nocturno, 10F);
            this.tags.SetTagFontStyle(this.panel_toggle_nocturno, System.Drawing.FontStyle.Regular);
            // 
            // boton_toggle_nocturno
            // 
            this.boton_toggle_nocturno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.boton_toggle_nocturno.BackgroundImage = global::LP2MegaAutos.Properties.Resources.toggle_modo_nocturno_desactivado;
            this.boton_toggle_nocturno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_toggle_nocturno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_toggle_nocturno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.boton_toggle_nocturno.FlatAppearance.BorderSize = 0;
            this.boton_toggle_nocturno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.boton_toggle_nocturno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.boton_toggle_nocturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_toggle_nocturno.Location = new System.Drawing.Point(48, 9);
            this.boton_toggle_nocturno.Name = "boton_toggle_nocturno";
            this.boton_toggle_nocturno.Size = new System.Drawing.Size(35, 35);
            this.boton_toggle_nocturno.TabIndex = 5;
            this.boton_toggle_nocturno.Tag = "toggle_oscuro";
            this.tags.SetTag2(this.boton_toggle_nocturno, null);
            this.tags.SetTag3(this.boton_toggle_nocturno, null);
            this.tags.SetTagFontName(this.boton_toggle_nocturno, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.boton_toggle_nocturno, 10F);
            this.tags.SetTagFontStyle(this.boton_toggle_nocturno, System.Drawing.FontStyle.Regular);
            this.boton_toggle_nocturno.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.boton_toggle_nocturno.UseVisualStyleBackColor = false;
            this.boton_toggle_nocturno.Click += new System.EventHandler(this.boton_toggle_nocturno_Click);
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnAjustes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnAjustes.Location = new System.Drawing.Point(0, 383);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(81, 45);
            this.btnAjustes.TabIndex = 24;
            this.tags.SetTag2(this.btnAjustes, null);
            this.tags.SetTag3(this.btnAjustes, null);
            this.tags.SetTagFontName(this.btnAjustes, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnAjustes, 12F);
            this.tags.SetTagFontStyle(this.btnAjustes, System.Drawing.FontStyle.Bold);
            this.btnAjustes.Text = "Home";
            this.btnAjustes.UseVisualStyleBackColor = false;
            // 
            // btnVerReportes
            // 
            this.btnVerReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(33)))));
            this.btnVerReportes.FlatAppearance.BorderSize = 0;
            this.btnVerReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnVerReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerReportes.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnVerReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnVerReportes.Location = new System.Drawing.Point(0, 207);
            this.btnVerReportes.Name = "btnVerReportes";
            this.btnVerReportes.Size = new System.Drawing.Size(81, 45);
            this.btnVerReportes.TabIndex = 23;
            this.tags.SetTag2(this.btnVerReportes, null);
            this.tags.SetTag3(this.btnVerReportes, null);
            this.tags.SetTagFontName(this.btnVerReportes, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnVerReportes, 12F);
            this.tags.SetTagFontStyle(this.btnVerReportes, System.Drawing.FontStyle.Bold);
            this.btnVerReportes.Text = "Home";
            this.btnVerReportes.UseVisualStyleBackColor = false;
            // 
            // btnActualizarBD
            // 
            this.btnActualizarBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnActualizarBD.FlatAppearance.BorderSize = 0;
            this.btnActualizarBD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnActualizarBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarBD.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnActualizarBD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnActualizarBD.Location = new System.Drawing.Point(0, 269);
            this.btnActualizarBD.Name = "btnActualizarBD";
            this.btnActualizarBD.Size = new System.Drawing.Size(81, 45);
            this.btnActualizarBD.TabIndex = 22;
            this.tags.SetTag2(this.btnActualizarBD, null);
            this.tags.SetTag3(this.btnActualizarBD, null);
            this.tags.SetTagFontName(this.btnActualizarBD, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnActualizarBD, 12F);
            this.tags.SetTagFontStyle(this.btnActualizarBD, System.Drawing.FontStyle.Bold);
            this.btnActualizarBD.Text = "Home";
            this.btnActualizarBD.UseVisualStyleBackColor = false;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.btnGenerarReporte.FlatAppearance.BorderSize = 0;
            this.btnGenerarReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnGenerarReporte.Location = new System.Drawing.Point(0, 147);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(81, 45);
            this.btnGenerarReporte.TabIndex = 21;
            this.tags.SetTag2(this.btnGenerarReporte, null);
            this.tags.SetTag3(this.btnGenerarReporte, null);
            this.tags.SetTagFontName(this.btnGenerarReporte, fontsD.Montserrat);
            this.tags.SetTagFontSize(this.btnGenerarReporte, 12F);
            this.tags.SetTagFontStyle(this.btnGenerarReporte, System.Drawing.FontStyle.Bold);
            this.btnGenerarReporte.Text = "Home";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnHome.Location = new System.Drawing.Point(0, 92);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(81, 45);
            this.btnHome.TabIndex = 20;
            this.tags.SetTag2(this.btnHome, null);
            this.tags.SetTag3(this.btnHome, null);
            this.tags.SetTagFontName(this.btnHome, fontsD.Montserrat);
            this.tags.SetTagFontSize(this.btnHome, 12F);
            this.tags.SetTagFontStyle(this.btnHome, System.Drawing.FontStyle.Bold);
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // panel_logo_empresa
            // 
            this.panel_logo_empresa.BackColor = System.Drawing.Color.Transparent;
            this.panel_logo_empresa.BackgroundImage = global::LP2MegaAutos.Properties.Resources.logo_megaautos;
            this.panel_logo_empresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_logo_empresa.Location = new System.Drawing.Point(16, 25);
            this.panel_logo_empresa.Name = "panel_logo_empresa";
            this.panel_logo_empresa.Size = new System.Drawing.Size(48, 40);
            this.panel_logo_empresa.TabIndex = 17;
            this.panel_logo_empresa.Tag = "logo";
            this.tags.SetTag2(this.panel_logo_empresa, null);
            this.tags.SetTag3(this.panel_logo_empresa, null);
            this.tags.SetTagFontName(this.panel_logo_empresa, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.panel_logo_empresa, 10F);
            this.tags.SetTagFontStyle(this.panel_logo_empresa, System.Drawing.FontStyle.Regular);
            // 
            // pnlBackBackground
            // 
            this.pnlBackBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.pnlBackBackground.Controls.Add(this.frontBackground);
            this.pnlBackBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackBackground.Location = new System.Drawing.Point(81, 32);
            this.pnlBackBackground.Name = "pnlBackBackground";
            this.pnlBackBackground.Size = new System.Drawing.Size(751, 520);
            this.pnlBackBackground.TabIndex = 4;
            this.pnlBackBackground.Tag = "background";
            this.tags.SetTag2(this.pnlBackBackground, null);
            this.tags.SetTag3(this.pnlBackBackground, null);
            this.tags.SetTagFontName(this.pnlBackBackground, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlBackBackground, 10F);
            this.tags.SetTagFontStyle(this.pnlBackBackground, System.Drawing.FontStyle.Regular);
            // 
            // frontBackground
            // 
            this.frontBackground.Location = new System.Drawing.Point(27, 14);
            this.frontBackground.Name = "frontBackground";
            this.frontBackground.Size = new System.Drawing.Size(712, 487);
            this.frontBackground.TabIndex = 0;
            this.tags.SetTag2(this.frontBackground, null);
            this.tags.SetTag3(this.frontBackground, null);
            this.tags.SetTagFontName(this.frontBackground, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.frontBackground, 10F);
            this.tags.SetTagFontStyle(this.frontBackground, System.Drawing.FontStyle.Regular);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 552);
            this.Controls.Add(this.pnlBackBackground);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.title_bar_2);
            this.Controls.Add(this.title_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tags.SetTag2(this, null);
            this.tags.SetTag3(this, null);
            this.tags.SetTagFontName(this, fontsD.Ninguno);
            this.tags.SetTagFontSize(this, 10F);
            this.tags.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.Text = "frmPrincipal";
            this.title_bar.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel_toggle_nocturno.ResumeLayout(false);
            this.pnlBackBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title_bar_2;
        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.Button boton_minimizar;
        private System.Windows.Forms.Button boton_cerrar;
        private System.Windows.Forms.Timer reloj_dark;
        private MetroFramework.Controls.MetroPanel panelMenu;
        private TagsExtender tags;
        private System.Windows.Forms.Panel panel_logo_empresa;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnVerReportes;
        private System.Windows.Forms.Button btnActualizarBD;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Panel panel_toggle_nocturno;
        private System.Windows.Forms.Button boton_toggle_nocturno;
        private System.Windows.Forms.Panel pnlBackBackground;
        private RoundedPanel frontBackground;
    }
}