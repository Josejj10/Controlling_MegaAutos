namespace LP2MegaAutos.Informacion.Vehiculos
{
    partial class frmEditarVehiculo
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
            this.title_bar = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.boton_minimizar = new System.Windows.Forms.Button();
            this.boton_cerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_placaVehiculo = new System.Windows.Forms.Panel();
            this.rnd_color_1 = new LP2MegaAutos.RoundedPanel();
            this.txt_placaVehiculo = new System.Windows.Forms.TextBox();
            this.lbl_placaVehiculo = new System.Windows.Forms.Label();
            this.rnd_cancelar = new LP2MegaAutos.RoundedPanel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.rnd_guardar = new LP2MegaAutos.RoundedPanel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_EditarVehiculo = new System.Windows.Forms.Label();
            this.rpTopMain = new LP2MegaAutos.RoundedPanel();
            this.title_bar.SuspendLayout();
            this.pnl_placaVehiculo.SuspendLayout();
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
            this.title_bar.TabIndex = 75;
            this.title_bar.Tag = "titlebar";
            this.title_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseDown);
            this.title_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseMove);
            this.title_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseMove);
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
            this.button3.Location = new System.Drawing.Point(574, -1);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 24);
            this.button3.TabIndex = 2;
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
            this.boton_minimizar.Location = new System.Drawing.Point(787, 0);
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
            this.boton_cerrar.Location = new System.Drawing.Point(811, 0);
            this.boton_cerrar.Margin = new System.Windows.Forms.Padding(0);
            this.boton_cerrar.Name = "boton_cerrar";
            this.boton_cerrar.Size = new System.Drawing.Size(24, 24);
            this.boton_cerrar.TabIndex = 0;
            this.boton_cerrar.TabStop = false;
            this.boton_cerrar.Tag = "titlebar";
            this.boton_cerrar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 2);
            this.panel1.TabIndex = 77;
            // 
            // pnl_placaVehiculo
            // 
            this.pnl_placaVehiculo.Controls.Add(this.rnd_color_1);
            this.pnl_placaVehiculo.Controls.Add(this.txt_placaVehiculo);
            this.pnl_placaVehiculo.Controls.Add(this.lbl_placaVehiculo);
            this.pnl_placaVehiculo.Location = new System.Drawing.Point(161, 100);
            this.pnl_placaVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_placaVehiculo.Name = "pnl_placaVehiculo";
            this.pnl_placaVehiculo.Size = new System.Drawing.Size(292, 41);
            this.pnl_placaVehiculo.TabIndex = 76;
            // 
            // rnd_color_1
            // 
            this.rnd_color_1.ArcRadiusBorde = 15;
            this.rnd_color_1.ArcRadiusPanel = 15;
            this.rnd_color_1.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rnd_color_1.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.rnd_color_1.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rnd_color_1.Location = new System.Drawing.Point(5, 4);
            this.rnd_color_1.MenosHeightBorde = 1;
            this.rnd_color_1.MenosHeightPanel = 1;
            this.rnd_color_1.MenosWidthBorde = 1;
            this.rnd_color_1.MenosWidthPanel = 1;
            this.rnd_color_1.Name = "rnd_color_1";
            this.rnd_color_1.PorcLuzColorBorde = 0;
            this.rnd_color_1.Size = new System.Drawing.Size(3, 36);
            this.rnd_color_1.TabIndex = 2;
            this.rnd_color_1.XBorde = 0;
            this.rnd_color_1.XPanel = 0;
            this.rnd_color_1.YBorde = 0;
            this.rnd_color_1.YPanel = 0;
            // 
            // txt_placaVehiculo
            // 
            this.txt_placaVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txt_placaVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_placaVehiculo.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_placaVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txt_placaVehiculo.Location = new System.Drawing.Point(10, 18);
            this.txt_placaVehiculo.Name = "txt_placaVehiculo";
            this.txt_placaVehiculo.Size = new System.Drawing.Size(284, 23);
            this.txt_placaVehiculo.TabIndex = 2;
            this.txt_placaVehiculo.Text = "ABC-123";
            // 
            // lbl_placaVehiculo
            // 
            this.lbl_placaVehiculo.AutoSize = true;
            this.lbl_placaVehiculo.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_placaVehiculo.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placaVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbl_placaVehiculo.Location = new System.Drawing.Point(7, 2);
            this.lbl_placaVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_placaVehiculo.Name = "lbl_placaVehiculo";
            this.lbl_placaVehiculo.Size = new System.Drawing.Size(90, 16);
            this.lbl_placaVehiculo.TabIndex = 2;
            this.lbl_placaVehiculo.Text = "Placa Vehículo";
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
            this.rnd_cancelar.TabIndex = 79;
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
            this.rnd_guardar.TabIndex = 78;
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
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_EditarVehiculo
            // 
            this.lbl_EditarVehiculo.AutoSize = true;
            this.lbl_EditarVehiculo.BackColor = System.Drawing.Color.White;
            this.lbl_EditarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_EditarVehiculo.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EditarVehiculo.ForeColor = System.Drawing.Color.Black;
            this.lbl_EditarVehiculo.Location = new System.Drawing.Point(27, 42);
            this.lbl_EditarVehiculo.Name = "lbl_EditarVehiculo";
            this.lbl_EditarVehiculo.Size = new System.Drawing.Size(206, 35);
            this.lbl_EditarVehiculo.TabIndex = 80;
            this.lbl_EditarVehiculo.Text = "Editar Vehiculo";
            this.lbl_EditarVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.rpTopMain.TabIndex = 74;
            this.rpTopMain.XBorde = 0;
            this.rpTopMain.XPanel = 0;
            this.rpTopMain.YBorde = 0;
            this.rpTopMain.YPanel = 0;
            // 
            // frmEditarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 431);
            this.Controls.Add(this.title_bar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_placaVehiculo);
            this.Controls.Add(this.rnd_cancelar);
            this.Controls.Add(this.rnd_guardar);
            this.Controls.Add(this.lbl_EditarVehiculo);
            this.Controls.Add(this.rpTopMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditarVehiculo";
            this.Resizable = false;
            this.title_bar.ResumeLayout(false);
            this.pnl_placaVehiculo.ResumeLayout(false);
            this.pnl_placaVehiculo.PerformLayout();
            this.rnd_cancelar.ResumeLayout(false);
            this.rnd_guardar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button boton_minimizar;
        private System.Windows.Forms.Button boton_cerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_placaVehiculo;
        private RoundedPanel rnd_color_1;
        private System.Windows.Forms.TextBox txt_placaVehiculo;
        private System.Windows.Forms.Label lbl_placaVehiculo;
        private RoundedPanel rnd_cancelar;
        private System.Windows.Forms.Button btn_cancelar;
        private RoundedPanel rnd_guardar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_EditarVehiculo;
        private RoundedPanel rpTopMain;
    }
}