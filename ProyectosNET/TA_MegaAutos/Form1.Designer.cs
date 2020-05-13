using ShadowPanel;
namespace TA_MegaAutos
{
    partial class Login_Screen
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
            this.title_bar = new System.Windows.Forms.Panel();
            this.boton_minimizar = new System.Windows.Forms.Button();
            this.boton_cerrar = new System.Windows.Forms.Button();
            this.title_bar_2 = new System.Windows.Forms.Panel();
            this.reloj_dark = new System.Windows.Forms.Timer(this.components);
            this.panel_background = new System.Windows.Forms.Panel();
            this.boton_olvido_password = new System.Windows.Forms.Label();
            this.panel_toggle_nocturno = new System.Windows.Forms.Panel();
            this.boton_toggle_nocturno = new System.Windows.Forms.Button();
            this.panel_acceder = new ShadowPanel.ShadowPanelRight();
            this.boton_acceder = new System.Windows.Forms.Button();
            this.panel_seleccionado_correo = new System.Windows.Forms.Panel();
            this.panel_correo = new ShadowPanel.ShadowPanelRight();
            this.textBox_correo = new System.Windows.Forms.TextBox();
            this.label_correo = new System.Windows.Forms.Label();
            this.panel_seleccionado_password = new System.Windows.Forms.Panel();
            this.panel_password = new ShadowPanel.ShadowPanelRight();
            this.boton_ver_password = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_texto_amarillo = new System.Windows.Forms.Label();
            this.subtitulo_login = new System.Windows.Forms.Label();
            this.label_texto_gris = new System.Windows.Forms.Label();
            this.titulo_login = new System.Windows.Forms.Label();
            this.panel_logo_empresa = new System.Windows.Forms.Panel();
            this.title_bar.SuspendLayout();
            this.panel_background.SuspendLayout();
            this.panel_toggle_nocturno.SuspendLayout();
            this.panel_acceder.SuspendLayout();
            this.panel_correo.SuspendLayout();
            this.panel_password.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_bar
            // 
            this.title_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.title_bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title_bar.Controls.Add(this.boton_minimizar);
            this.title_bar.Controls.Add(this.boton_cerrar);
            this.title_bar.Location = new System.Drawing.Point(0, 0);
            this.title_bar.Name = "title_bar";
            this.title_bar.Size = new System.Drawing.Size(832, 24);
            this.title_bar.TabIndex = 0;
            this.title_bar.Tag = "titlebar";
            this.title_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseDown);
            this.title_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseMove);
            this.title_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseUp);
            // 
            // boton_minimizar
            // 
            this.boton_minimizar.BackgroundImage = global::TA_MegaAutos.Properties.Resources.boton_minimizar;
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
            this.boton_minimizar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.boton_minimizar_MouseClick);
            // 
            // boton_cerrar
            // 
            this.boton_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.boton_cerrar.BackgroundImage = global::TA_MegaAutos.Properties.Resources.boton_cerrar;
            this.boton_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boton_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.boton_cerrar.FlatAppearance.BorderSize = 0;
            this.boton_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(33)))));
            this.boton_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(33)))));
            this.boton_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_cerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.boton_cerrar.Location = new System.Drawing.Point(808, 0);
            this.boton_cerrar.Margin = new System.Windows.Forms.Padding(0);
            this.boton_cerrar.Name = "boton_cerrar";
            this.boton_cerrar.Size = new System.Drawing.Size(24, 24);
            this.boton_cerrar.TabIndex = 0;
            this.boton_cerrar.TabStop = false;
            this.boton_cerrar.Tag = "titlebar";
            this.boton_cerrar.UseVisualStyleBackColor = false;
            this.boton_cerrar.Click += new System.EventHandler(this.boton_cerrar_MouseClick);
            // 
            // title_bar_2
            // 
            this.title_bar_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.title_bar_2.Enabled = false;
            this.title_bar_2.Location = new System.Drawing.Point(0, 24);
            this.title_bar_2.Name = "title_bar_2";
            this.title_bar_2.Size = new System.Drawing.Size(832, 8);
            this.title_bar_2.TabIndex = 0;
            this.title_bar_2.Tag = "titlebar";
            // 
            // reloj_dark
            // 
            this.reloj_dark.Interval = 25;
            this.reloj_dark.Tick += new System.EventHandler(this.reloj_dark_Tick);
            // 
            // panel_background
            // 
            this.panel_background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.panel_background.BackgroundImage = global::TA_MegaAutos.Properties.Resources.background_login;
            this.panel_background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_background.Controls.Add(this.boton_olvido_password);
            this.panel_background.Controls.Add(this.panel_toggle_nocturno);
            this.panel_background.Controls.Add(this.panel_acceder);
            this.panel_background.Controls.Add(this.panel_seleccionado_correo);
            this.panel_background.Controls.Add(this.panel_correo);
            this.panel_background.Controls.Add(this.panel_seleccionado_password);
            this.panel_background.Controls.Add(this.panel_password);
            this.panel_background.Controls.Add(this.label_texto_amarillo);
            this.panel_background.Controls.Add(this.subtitulo_login);
            this.panel_background.Controls.Add(this.label_texto_gris);
            this.panel_background.Controls.Add(this.titulo_login);
            this.panel_background.Controls.Add(this.panel_logo_empresa);
            this.panel_background.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel_background.Location = new System.Drawing.Point(0, 32);
            this.panel_background.Name = "panel_background";
            this.panel_background.Size = new System.Drawing.Size(832, 520);
            this.panel_background.TabIndex = 1;
            // 
            // boton_olvido_password
            // 
            this.boton_olvido_password.AutoSize = true;
            this.boton_olvido_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_olvido_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_olvido_password.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.boton_olvido_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.boton_olvido_password.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_olvido_password.Location = new System.Drawing.Point(112, 409);
            this.boton_olvido_password.Name = "boton_olvido_password";
            this.boton_olvido_password.Size = new System.Drawing.Size(141, 17);
            this.boton_olvido_password.TabIndex = 5;
            this.boton_olvido_password.Text = "Olvidé mi contraseña";
            this.boton_olvido_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_toggle_nocturno
            // 
            this.panel_toggle_nocturno.BackgroundImage = global::TA_MegaAutos.Properties.Resources.toggle_white;
            this.panel_toggle_nocturno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_toggle_nocturno.Controls.Add(this.boton_toggle_nocturno);
            this.panel_toggle_nocturno.Location = new System.Drawing.Point(23, 448);
            this.panel_toggle_nocturno.Name = "panel_toggle_nocturno";
            this.panel_toggle_nocturno.Size = new System.Drawing.Size(95, 60);
            this.panel_toggle_nocturno.TabIndex = 4;
            // 
            // boton_toggle_nocturno
            // 
            this.boton_toggle_nocturno.BackgroundImage = global::TA_MegaAutos.Properties.Resources.toggle_modo_nocturno_desactivado;
            this.boton_toggle_nocturno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_toggle_nocturno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.boton_toggle_nocturno.FlatAppearance.BorderSize = 0;
            this.boton_toggle_nocturno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.boton_toggle_nocturno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.boton_toggle_nocturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_toggle_nocturno.Location = new System.Drawing.Point(48, 9);
            this.boton_toggle_nocturno.Name = "boton_toggle_nocturno";
            this.boton_toggle_nocturno.Size = new System.Drawing.Size(35, 35);
            this.boton_toggle_nocturno.TabIndex = 5;
            this.boton_toggle_nocturno.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.boton_toggle_nocturno.UseVisualStyleBackColor = true;
            this.boton_toggle_nocturno.Click += new System.EventHandler(this.boton_toggle_nocturno_Click);
            // 
            // panel_acceder
            // 
            this.panel_acceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.panel_acceder.BorderColor = System.Drawing.Color.Empty;
            this.panel_acceder.Controls.Add(this.boton_acceder);
            this.panel_acceder.Location = new System.Drawing.Point(36, 345);
            this.panel_acceder.Name = "panel_acceder";
            this.panel_acceder.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.panel_acceder.Size = new System.Drawing.Size(294, 50);
            this.panel_acceder.TabIndex = 0;
            // 
            // boton_acceder
            // 
            this.boton_acceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.boton_acceder.FlatAppearance.BorderSize = 0;
            this.boton_acceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.boton_acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_acceder.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.boton_acceder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.boton_acceder.Location = new System.Drawing.Point(0, 0);
            this.boton_acceder.Name = "boton_acceder";
            this.boton_acceder.Size = new System.Drawing.Size(291, 45);
            this.boton_acceder.TabIndex = 0;
            this.boton_acceder.Text = "Acceder";
            this.boton_acceder.UseVisualStyleBackColor = false;
            // 
            // panel_seleccionado_correo
            // 
            this.panel_seleccionado_correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.panel_seleccionado_correo.Location = new System.Drawing.Point(36, 220);
            this.panel_seleccionado_correo.Name = "panel_seleccionado_correo";
            this.panel_seleccionado_correo.Size = new System.Drawing.Size(10, 53);
            this.panel_seleccionado_correo.TabIndex = 0;
            this.panel_seleccionado_correo.Visible = false;
            this.panel_seleccionado_correo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_input_Paint);
            // 
            // panel_correo
            // 
            this.panel_correo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.panel_correo.Controls.Add(this.textBox_correo);
            this.panel_correo.Controls.Add(this.label_correo);
            this.panel_correo.Location = new System.Drawing.Point(36, 219);
            this.panel_correo.Name = "panel_correo";
            this.panel_correo.PanelColor = System.Drawing.Color.Empty;
            this.panel_correo.Size = new System.Drawing.Size(294, 60);
            this.panel_correo.TabIndex = 0;
            this.panel_correo.Tag = "form";
            // 
            // textBox_correo
            // 
            this.textBox_correo.AutoCompleteCustomSource.AddRange(new string[] {
            "josejj2210@gmail.com"});
            this.textBox_correo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_correo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.textBox_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_correo.Font = new System.Drawing.Font("Montserrat", 10.5F, System.Drawing.FontStyle.Bold);
            this.textBox_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(71)))), ((int)(((byte)(76)))));
            this.textBox_correo.Location = new System.Drawing.Point(18, 27);
            this.textBox_correo.MinimumSize = new System.Drawing.Size(232, 22);
            this.textBox_correo.Name = "textBox_correo";
            this.textBox_correo.Size = new System.Drawing.Size(266, 18);
            this.textBox_correo.TabIndex = 1;
            this.textBox_correo.Tag = "form";
            this.textBox_correo.Click += new System.EventHandler(this.textBox_correo_Click);
            this.textBox_correo.Enter += new System.EventHandler(this.textBox_correo_Click);
            // 
            // label_correo
            // 
            this.label_correo.AutoSize = true;
            this.label_correo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_correo.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(71)))), ((int)(((byte)(76)))));
            this.label_correo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_correo.Location = new System.Drawing.Point(14, 5);
            this.label_correo.Name = "label_correo";
            this.label_correo.Size = new System.Drawing.Size(62, 21);
            this.label_correo.TabIndex = 0;
            this.label_correo.Tag = "form";
            this.label_correo.Text = "Correo";
            this.label_correo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_seleccionado_password
            // 
            this.panel_seleccionado_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.panel_seleccionado_password.Location = new System.Drawing.Point(36, 279);
            this.panel_seleccionado_password.Name = "panel_seleccionado_password";
            this.panel_seleccionado_password.Size = new System.Drawing.Size(10, 53);
            this.panel_seleccionado_password.TabIndex = 0;
            this.panel_seleccionado_password.Visible = false;
            this.panel_seleccionado_password.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_input_Paint);
            // 
            // panel_password
            // 
            this.panel_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.panel_password.Controls.Add(this.boton_ver_password);
            this.panel_password.Controls.Add(this.textBox_password);
            this.panel_password.Controls.Add(this.label_password);
            this.panel_password.Location = new System.Drawing.Point(36, 278);
            this.panel_password.Name = "panel_password";
            this.panel_password.PanelColor = System.Drawing.Color.Empty;
            this.panel_password.Size = new System.Drawing.Size(294, 60);
            this.panel_password.TabIndex = 0;
            this.panel_password.Tag = "form";
            // 
            // boton_ver_password
            // 
            this.boton_ver_password.BackColor = System.Drawing.Color.Transparent;
            this.boton_ver_password.BackgroundImage = global::TA_MegaAutos.Properties.Resources.boton_see_password;
            this.boton_ver_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boton_ver_password.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.boton_ver_password.FlatAppearance.BorderSize = 0;
            this.boton_ver_password.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.boton_ver_password.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.boton_ver_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_ver_password.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.boton_ver_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.boton_ver_password.Location = new System.Drawing.Point(256, 18);
            this.boton_ver_password.Name = "boton_ver_password";
            this.boton_ver_password.Size = new System.Drawing.Size(28, 25);
            this.boton_ver_password.TabIndex = 0;
            this.boton_ver_password.TabStop = false;
            this.boton_ver_password.Tag = "ojo";
            this.boton_ver_password.UseVisualStyleBackColor = false;
            this.boton_ver_password.Click += new System.EventHandler(this.boton_ver_password_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Font = new System.Drawing.Font("Montserrat", 10.5F, System.Drawing.FontStyle.Bold);
            this.textBox_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(71)))), ((int)(((byte)(76)))));
            this.textBox_password.Location = new System.Drawing.Point(18, 25);
            this.textBox_password.MinimumSize = new System.Drawing.Size(232, 22);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '•';
            this.textBox_password.Size = new System.Drawing.Size(232, 18);
            this.textBox_password.TabIndex = 2;
            this.textBox_password.Tag = "form";
            this.textBox_password.Click += new System.EventHandler(this.textBox_password_Click);
            this.textBox_password.Enter += new System.EventHandler(this.textBox_password_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_password.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(71)))), ((int)(((byte)(76)))));
            this.label_password.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_password.Location = new System.Drawing.Point(14, 3);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(98, 21);
            this.label_password.TabIndex = 0;
            this.label_password.Tag = "form";
            this.label_password.Text = "Contraseña";
            this.label_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_texto_amarillo
            // 
            this.label_texto_amarillo.AutoSize = true;
            this.label_texto_amarillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_texto_amarillo.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label_texto_amarillo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.label_texto_amarillo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_texto_amarillo.Location = new System.Drawing.Point(199, 178);
            this.label_texto_amarillo.Name = "label_texto_amarillo";
            this.label_texto_amarillo.Size = new System.Drawing.Size(64, 19);
            this.label_texto_amarillo.TabIndex = 0;
            this.label_texto_amarillo.Text = "ingrese";
            this.label_texto_amarillo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subtitulo_login
            // 
            this.subtitulo_login.AutoSize = true;
            this.subtitulo_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtitulo_login.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.subtitulo_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(71)))), ((int)(((byte)(76)))));
            this.subtitulo_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subtitulo_login.Location = new System.Drawing.Point(35, 128);
            this.subtitulo_login.Name = "subtitulo_login";
            this.subtitulo_login.Size = new System.Drawing.Size(275, 28);
            this.subtitulo_login.TabIndex = 0;
            this.subtitulo_login.Tag = "subtitulo";
            this.subtitulo_login.Text = "Experiencia y Calidad AA";
            this.subtitulo_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_texto_gris
            // 
            this.label_texto_gris.AutoSize = true;
            this.label_texto_gris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_texto_gris.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.label_texto_gris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(71)))), ((int)(((byte)(76)))));
            this.label_texto_gris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_texto_gris.Location = new System.Drawing.Point(36, 178);
            this.label_texto_gris.Name = "label_texto_gris";
            this.label_texto_gris.Size = new System.Drawing.Size(167, 38);
            this.label_texto_gris.TabIndex = 0;
            this.label_texto_gris.Tag = "subtitulo";
            this.label_texto_gris.Text = "Bienvenido, por favor\r\na su cuenta.";
            this.label_texto_gris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titulo_login
            // 
            this.titulo_login.AutoSize = true;
            this.titulo_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titulo_login.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.titulo_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.titulo_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titulo_login.Location = new System.Drawing.Point(33, 87);
            this.titulo_login.Name = "titulo_login";
            this.titulo_login.Size = new System.Drawing.Size(198, 41);
            this.titulo_login.TabIndex = 0;
            this.titulo_login.Tag = "titulo";
            this.titulo_login.Text = "MegaAutos";
            this.titulo_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titulo_login.Paint += new System.Windows.Forms.PaintEventHandler(this.titulo_login_Paint);
            // 
            // panel_logo_empresa
            // 
            this.panel_logo_empresa.BackgroundImage = global::TA_MegaAutos.Properties.Resources.logo_megaautos;
            this.panel_logo_empresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_logo_empresa.Location = new System.Drawing.Point(14, 11);
            this.panel_logo_empresa.Name = "panel_logo_empresa";
            this.panel_logo_empresa.Size = new System.Drawing.Size(48, 40);
            this.panel_logo_empresa.TabIndex = 0;
            this.panel_logo_empresa.Tag = "logo";
            // 
            // Login_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 552);
            this.ControlBox = false;
            this.Controls.Add(this.title_bar_2);
            this.Controls.Add(this.title_bar);
            this.Controls.Add(this.panel_background);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Login_Screen";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.title_bar.ResumeLayout(false);
            this.panel_background.ResumeLayout(false);
            this.panel_background.PerformLayout();
            this.panel_toggle_nocturno.ResumeLayout(false);
            this.panel_acceder.ResumeLayout(false);
            this.panel_correo.ResumeLayout(false);
            this.panel_correo.PerformLayout();
            this.panel_password.ResumeLayout(false);
            this.panel_password.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.Button boton_cerrar;
        private System.Windows.Forms.Button boton_minimizar;
        private System.Windows.Forms.Panel title_bar_2;
        private System.Windows.Forms.Panel panel_background;
        private System.Windows.Forms.Panel panel_logo_empresa;
        private System.Windows.Forms.Label titulo_login;
        private System.Windows.Forms.Label subtitulo_login;
        private System.Windows.Forms.Label label_texto_amarillo;
        private System.Windows.Forms.Label label_texto_gris;
        private System.Windows.Forms.Label label_correo;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Panel panel_seleccionado_correo;
        private System.Windows.Forms.Panel panel_seleccionado_password;
        private ShadowPanel.ShadowPanelRight shadowPanel1;
        private ShadowPanel.ShadowPanelRight panel_password;
        private ShadowPanel.ShadowPanelRight panel_correo;
        private ShadowPanelRight panel_acceder;
        private System.Windows.Forms.Button boton_acceder;
        private System.Windows.Forms.TextBox textBox_correo;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button boton_ver_password;
        private System.Windows.Forms.Panel panel_toggle_nocturno;
        private System.Windows.Forms.Button boton_toggle_nocturno;
        private System.Windows.Forms.Timer reloj_dark;
        private System.Windows.Forms.Label boton_olvido_password;
    }
}

