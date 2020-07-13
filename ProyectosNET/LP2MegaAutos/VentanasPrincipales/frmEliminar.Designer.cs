namespace LP2MegaAutos.VentanasPrincipales
{
    partial class frmEliminar
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
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.title_bar = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.boton_minimizar = new System.Windows.Forms.Button();
            this.boton_cerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rnd_cancelar = new LP2MegaAutos.RoundedPanel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.rpTopMain = new LP2MegaAutos.RoundedPanel();
            this.rndEliminar = new LP2MegaAutos.RoundedPanel();
            this.btnDarDeBaja = new System.Windows.Forms.Button();
            this.rpn_Reportes = new LP2MegaAutos.RoundedPanel();
            this.txt_ContraseñaActual = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.title_bar.SuspendLayout();
            this.rnd_cancelar.SuspendLayout();
            this.rndEliminar.SuspendLayout();
            this.rpn_Reportes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.lbl_Contraseña.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contraseña.Location = new System.Drawing.Point(168, 161);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(83, 18);
            this.lbl_Contraseña.TabIndex = 75;
            this.lbl_Contraseña.Text = "Contraseña";
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
            this.title_bar.Size = new System.Drawing.Size(430, 24);
            this.title_bar.TabIndex = 77;
            this.title_bar.Tag = "titlebar";
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
            this.button3.Location = new System.Drawing.Point(405, -1);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 24);
            this.button3.TabIndex = 78;
            this.button3.TabStop = false;
            this.button3.Tag = "titlebar";
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
            this.boton_cerrar.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.lblTitulo.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.lblTitulo.Location = new System.Drawing.Point(96, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(238, 35);
            this.lblTitulo.TabIndex = 79;
            this.lblTitulo.Text = "Confirmar Acción";
            // 
            // rnd_cancelar
            // 
            this.rnd_cancelar.ArcRadiusBorde = 5;
            this.rnd_cancelar.ArcRadiusPanel = 5;
            this.rnd_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.rnd_cancelar.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rnd_cancelar.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.rnd_cancelar.Controls.Add(this.btn_cancelar);
            this.rnd_cancelar.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rnd_cancelar.Location = new System.Drawing.Point(222, 227);
            this.rnd_cancelar.MenosHeightBorde = 1;
            this.rnd_cancelar.MenosHeightPanel = 1;
            this.rnd_cancelar.MenosWidthBorde = 1;
            this.rnd_cancelar.MenosWidthPanel = 1;
            this.rnd_cancelar.Name = "rnd_cancelar";
            this.rnd_cancelar.PorcLuzColorBorde = 0;
            this.rnd_cancelar.Size = new System.Drawing.Size(157, 35);
            this.rnd_cancelar.TabIndex = 78;
            this.rnd_cancelar.XBorde = 0;
            this.rnd_cancelar.XPanel = 0;
            this.rnd_cancelar.YBorde = 0;
            this.rnd_cancelar.YPanel = 0;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(3, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(151, 29);
            this.btn_cancelar.TabIndex = 0;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
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
            this.rpTopMain.Size = new System.Drawing.Size(430, 8);
            this.rpTopMain.TabIndex = 76;
            this.rpTopMain.XBorde = 0;
            this.rpTopMain.XPanel = 0;
            this.rpTopMain.YBorde = 0;
            this.rpTopMain.YPanel = 0;
            // 
            // rndEliminar
            // 
            this.rndEliminar.ArcRadiusBorde = 5;
            this.rndEliminar.ArcRadiusPanel = 5;
            this.rndEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.rndEliminar.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(33)))));
            this.rndEliminar.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(33)))));
            this.rndEliminar.Controls.Add(this.btnDarDeBaja);
            this.rndEliminar.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndEliminar.Location = new System.Drawing.Point(51, 227);
            this.rndEliminar.MenosHeightBorde = 1;
            this.rndEliminar.MenosHeightPanel = 1;
            this.rndEliminar.MenosWidthBorde = 1;
            this.rndEliminar.MenosWidthPanel = 1;
            this.rndEliminar.Name = "rndEliminar";
            this.rndEliminar.PorcLuzColorBorde = 0;
            this.rndEliminar.Size = new System.Drawing.Size(165, 35);
            this.rndEliminar.TabIndex = 73;
            this.rndEliminar.XBorde = 0;
            this.rndEliminar.XPanel = 0;
            this.rndEliminar.YBorde = 0;
            this.rndEliminar.YPanel = 0;
            // 
            // btnDarDeBaja
            // 
            this.btnDarDeBaja.BackColor = System.Drawing.Color.Transparent;
            this.btnDarDeBaja.FlatAppearance.BorderSize = 0;
            this.btnDarDeBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDarDeBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarDeBaja.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarDeBaja.ForeColor = System.Drawing.Color.White;
            this.btnDarDeBaja.Location = new System.Drawing.Point(3, 3);
            this.btnDarDeBaja.Name = "btnDarDeBaja";
            this.btnDarDeBaja.Size = new System.Drawing.Size(159, 28);
            this.btnDarDeBaja.TabIndex = 0;
            this.btnDarDeBaja.Text = "Confirmar";
            this.btnDarDeBaja.UseVisualStyleBackColor = false;
            this.btnDarDeBaja.Click += new System.EventHandler(this.btnDarDeBaja_Click);
            // 
            // rpn_Reportes
            // 
            this.rpn_Reportes.ArcRadiusBorde = 15;
            this.rpn_Reportes.ArcRadiusPanel = 15;
            this.rpn_Reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.rpn_Reportes.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpn_Reportes.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rpn_Reportes.Controls.Add(this.txt_ContraseñaActual);
            this.rpn_Reportes.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpn_Reportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.rpn_Reportes.Location = new System.Drawing.Point(98, 182);
            this.rpn_Reportes.MenosHeightBorde = 1;
            this.rpn_Reportes.MenosHeightPanel = 1;
            this.rpn_Reportes.MenosWidthBorde = 1;
            this.rpn_Reportes.MenosWidthPanel = 1;
            this.rpn_Reportes.Name = "rpn_Reportes";
            this.rpn_Reportes.PorcLuzColorBorde = 0;
            this.rpn_Reportes.Size = new System.Drawing.Size(235, 34);
            this.rpn_Reportes.TabIndex = 74;
            this.rpn_Reportes.XBorde = 0;
            this.rpn_Reportes.XPanel = 0;
            this.rpn_Reportes.YBorde = 0;
            this.rpn_Reportes.YPanel = 0;
            // 
            // txt_ContraseñaActual
            // 
            this.txt_ContraseñaActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.txt_ContraseñaActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ContraseñaActual.Font = new System.Drawing.Font("Lato", 12F);
            this.txt_ContraseñaActual.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ContraseñaActual.Location = new System.Drawing.Point(20, 11);
            this.txt_ContraseñaActual.Name = "txt_ContraseñaActual";
            this.txt_ContraseñaActual.PasswordChar = '*';
            this.txt_ContraseñaActual.Size = new System.Drawing.Size(196, 20);
            this.txt_ContraseñaActual.TabIndex = 0;
            this.txt_ContraseñaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ContraseñaActual.UseSystemPasswordChar = true;
            this.txt_ContraseñaActual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eliminar_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panel1.Location = new System.Drawing.Point(11, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 1);
            this.panel1.TabIndex = 80;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblTexto, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 66);
            this.tableLayoutPanel1.TabIndex = 82;
            // 
            // lblTexto
            // 
            this.lblTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(162, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(59, 66);
            this.lblTexto.TabIndex = 82;
            this.lblTexto.Text = "¿Desea ";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.pnlBackground.Controls.Add(this.rnd_cancelar);
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(430, 277);
            this.pnlBackground.TabIndex = 83;
            // 
            // frmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 276);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.title_bar);
            this.Controls.Add(this.rpTopMain);
            this.Controls.Add(this.rndEliminar);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.rpn_Reportes);
            this.Controls.Add(this.pnlBackground);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEliminar";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.ShowIcon = false;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.title_bar.ResumeLayout(false);
            this.rnd_cancelar.ResumeLayout(false);
            this.rndEliminar.ResumeLayout(false);
            this.rpn_Reportes.ResumeLayout(false);
            this.rpn_Reportes.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedPanel rndEliminar;
        private System.Windows.Forms.Button btnDarDeBaja;
        private System.Windows.Forms.Label lbl_Contraseña;
        private RoundedPanel rpn_Reportes;
        private System.Windows.Forms.TextBox txt_ContraseñaActual;
        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.Button boton_minimizar;
        private System.Windows.Forms.Button boton_cerrar;
        private RoundedPanel rpTopMain;
        private System.Windows.Forms.Button button3;
        private RoundedPanel rnd_cancelar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Panel pnlBackground;
    }
}