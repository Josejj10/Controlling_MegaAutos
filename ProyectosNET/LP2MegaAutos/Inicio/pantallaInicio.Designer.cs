using System.Drawing;
using System.Linq.Expressions;

namespace LP2MegaAutos
{
    partial class pantallaInicio
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantallaInicio));
            this.tags = new LP2MegaAutos.TagsExtender();
            this.pnlLineaTitulo = new System.Windows.Forms.Panel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnListaReportes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnImgVehiculo = new System.Windows.Forms.Button();
            this.btnImgCliente = new System.Windows.Forms.Button();
            this.btnImgAreaTrabajo = new System.Windows.Forms.Button();
            this.btnGenerarVehiculo = new System.Windows.Forms.Button();
            this.btnGenerarCliente = new System.Windows.Forms.Button();
            this.btnGenerarAreaTrabajo = new System.Windows.Forms.Button();
            this.lblCreditos = new LP2MegaAutos.CustomControls.ClickableText();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.pnlAbajoInformacion = new System.Windows.Forms.Panel();
            this.pnlAbajoConfiguracion = new System.Windows.Forms.Panel();
            this.pnlConfiguracion = new System.Windows.Forms.Panel();
            this.ultimoReporteDashboard1 = new LP2MegaAutos.Framework.UserControls.UltimoReporteDashboard();
            this.lblActualizarEmpresa = new LP2MegaAutos.CustomControls.ClickableText();
            this.SuspendLayout();
            // 
            // pnlLineaTitulo
            // 
            this.pnlLineaTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.pnlLineaTitulo.Location = new System.Drawing.Point(20, 69);
            this.pnlLineaTitulo.Name = "pnlLineaTitulo";
            this.pnlLineaTitulo.Size = new System.Drawing.Size(690, 1);
            this.pnlLineaTitulo.TabIndex = 40;
            this.tags.SetTag2(this.pnlLineaTitulo, null);
            this.tags.SetTag3(this.pnlLineaTitulo, null);
            this.tags.SetTagFontName(this.pnlLineaTitulo, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlLineaTitulo, 10F);
            this.tags.SetTagFontStyle(this.pnlLineaTitulo, System.Drawing.FontStyle.Regular);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.lblBienvenido.Location = new System.Drawing.Point(36, 24);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(99, 39);
            this.lblBienvenido.TabIndex = 41;
            this.tags.SetTag2(this.lblBienvenido, null);
            this.tags.SetTag3(this.lblBienvenido, null);
            this.tags.SetTagFontName(this.lblBienvenido, fontsD.Lato);
            this.tags.SetTagFontSize(this.lblBienvenido, 24F);
            this.tags.SetTagFontStyle(this.lblBienvenido, System.Drawing.FontStyle.Bold);
            this.lblBienvenido.Text = "Hola, ";
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackgroundImage = global::LP2MegaAutos.Properties.Resources.Usuario;
            this.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Location = new System.Drawing.Point(659, 29);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(36, 36);
            this.btnPerfil.TabIndex = 42;
            this.tags.SetTag2(this.btnPerfil, null);
            this.tags.SetTag3(this.btnPerfil, null);
            this.tags.SetTagFontName(this.btnPerfil, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnPerfil, 10F);
            this.tags.SetTagFontStyle(this.btnPerfil, System.Drawing.FontStyle.Regular);
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnListaReportes
            // 
            this.btnListaReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.btnListaReportes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListaReportes.BackgroundImage")));
            this.btnListaReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnListaReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaReportes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnListaReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.btnListaReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.btnListaReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaReportes.Location = new System.Drawing.Point(36, 88);
            this.btnListaReportes.Name = "btnListaReportes";
            this.btnListaReportes.Size = new System.Drawing.Size(179, 80);
            this.btnListaReportes.TabIndex = 43;
            this.tags.SetTag2(this.btnListaReportes, null);
            this.tags.SetTag3(this.btnListaReportes, null);
            this.tags.SetTagFontName(this.btnListaReportes, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnListaReportes, 10F);
            this.tags.SetTagFontStyle(this.btnListaReportes, System.Drawing.FontStyle.Regular);
            this.btnListaReportes.UseVisualStyleBackColor = false;
            this.btnListaReportes.Click += new System.EventHandler(this.btnListaReportes_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(64)))), ((int)(((byte)(93)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(64)))), ((int)(((byte)(93)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(64)))), ((int)(((byte)(93)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lato", 15F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(36, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 40);
            this.button1.TabIndex = 44;
            this.tags.SetTag2(this.button1, null);
            this.tags.SetTag3(this.button1, null);
            this.tags.SetTagFontName(this.button1, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.button1, 10F);
            this.tags.SetTagFontStyle(this.button1, System.Drawing.FontStyle.Regular);
            this.button1.Text = "Reportes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnListaReportes_Click);
            // 
            // btnImgVehiculo
            // 
            this.btnImgVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnImgVehiculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImgVehiculo.BackgroundImage")));
            this.btnImgVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImgVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImgVehiculo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnImgVehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnImgVehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnImgVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImgVehiculo.Location = new System.Drawing.Point(214, 88);
            this.btnImgVehiculo.Name = "btnImgVehiculo";
            this.btnImgVehiculo.Size = new System.Drawing.Size(41, 40);
            this.btnImgVehiculo.TabIndex = 45;
            this.tags.SetTag2(this.btnImgVehiculo, null);
            this.tags.SetTag3(this.btnImgVehiculo, null);
            this.tags.SetTagFontName(this.btnImgVehiculo, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnImgVehiculo, 10F);
            this.tags.SetTagFontStyle(this.btnImgVehiculo, System.Drawing.FontStyle.Regular);
            this.btnImgVehiculo.UseVisualStyleBackColor = false;
            this.btnImgVehiculo.Click += new System.EventHandler(this.btnGenerarVehiculo_Click);
            // 
            // btnImgCliente
            // 
            this.btnImgCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnImgCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImgCliente.BackgroundImage")));
            this.btnImgCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImgCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImgCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnImgCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnImgCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnImgCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImgCliente.Location = new System.Drawing.Point(214, 166);
            this.btnImgCliente.Name = "btnImgCliente";
            this.btnImgCliente.Size = new System.Drawing.Size(41, 40);
            this.btnImgCliente.TabIndex = 46;
            this.tags.SetTag2(this.btnImgCliente, null);
            this.tags.SetTag3(this.btnImgCliente, null);
            this.tags.SetTagFontName(this.btnImgCliente, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnImgCliente, 10F);
            this.tags.SetTagFontStyle(this.btnImgCliente, System.Drawing.FontStyle.Regular);
            this.btnImgCliente.UseVisualStyleBackColor = false;
            this.btnImgCliente.Click += new System.EventHandler(this.btnGenerarCliente_Click);
            // 
            // btnImgAreaTrabajo
            // 
            this.btnImgAreaTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnImgAreaTrabajo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImgAreaTrabajo.BackgroundImage")));
            this.btnImgAreaTrabajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImgAreaTrabajo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImgAreaTrabajo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnImgAreaTrabajo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnImgAreaTrabajo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnImgAreaTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImgAreaTrabajo.Location = new System.Drawing.Point(214, 127);
            this.btnImgAreaTrabajo.Name = "btnImgAreaTrabajo";
            this.btnImgAreaTrabajo.Size = new System.Drawing.Size(41, 40);
            this.btnImgAreaTrabajo.TabIndex = 47;
            this.tags.SetTag2(this.btnImgAreaTrabajo, null);
            this.tags.SetTag3(this.btnImgAreaTrabajo, null);
            this.tags.SetTagFontName(this.btnImgAreaTrabajo, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.btnImgAreaTrabajo, 10F);
            this.tags.SetTagFontStyle(this.btnImgAreaTrabajo, System.Drawing.FontStyle.Regular);
            this.btnImgAreaTrabajo.UseVisualStyleBackColor = false;
            this.btnImgAreaTrabajo.Click += new System.EventHandler(this.btnGenerarAreaTrabajo_Click);
            // 
            // btnGenerarVehiculo
            // 
            this.btnGenerarVehiculo.BackColor = System.Drawing.Color.White;
            this.btnGenerarVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarVehiculo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnGenerarVehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnGenerarVehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnGenerarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarVehiculo.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.btnGenerarVehiculo.Location = new System.Drawing.Point(254, 88);
            this.btnGenerarVehiculo.Name = "btnGenerarVehiculo";
            this.btnGenerarVehiculo.Size = new System.Drawing.Size(249, 40);
            this.btnGenerarVehiculo.TabIndex = 48;
            this.tags.SetTag2(this.btnGenerarVehiculo, null);
            this.tags.SetTag3(this.btnGenerarVehiculo, null);
            this.tags.SetTagFontName(this.btnGenerarVehiculo, fontsD.Lato);
            this.tags.SetTagFontSize(this.btnGenerarVehiculo, 15F);
            this.tags.SetTagFontStyle(this.btnGenerarVehiculo, System.Drawing.FontStyle.Regular);
            this.btnGenerarVehiculo.Text = "Generar por Vehículo";
            this.btnGenerarVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarVehiculo.UseVisualStyleBackColor = false;
            this.btnGenerarVehiculo.Click += new System.EventHandler(this.btnGenerarVehiculo_Click);
            // 
            // btnGenerarCliente
            // 
            this.btnGenerarCliente.BackColor = System.Drawing.Color.White;
            this.btnGenerarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnGenerarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnGenerarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnGenerarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarCliente.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.btnGenerarCliente.Location = new System.Drawing.Point(254, 166);
            this.btnGenerarCliente.Name = "btnGenerarCliente";
            this.btnGenerarCliente.Size = new System.Drawing.Size(249, 40);
            this.btnGenerarCliente.TabIndex = 49;
            this.tags.SetTag2(this.btnGenerarCliente, null);
            this.tags.SetTag3(this.btnGenerarCliente, null);
            this.tags.SetTagFontName(this.btnGenerarCliente, fontsD.Lato);
            this.tags.SetTagFontSize(this.btnGenerarCliente, 15F);
            this.tags.SetTagFontStyle(this.btnGenerarCliente, System.Drawing.FontStyle.Regular);
            this.btnGenerarCliente.Text = "Generar por Cliente";
            this.btnGenerarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarCliente.UseVisualStyleBackColor = false;
            this.btnGenerarCliente.Click += new System.EventHandler(this.btnGenerarCliente_Click);
            // 
            // btnGenerarAreaTrabajo
            // 
            this.btnGenerarAreaTrabajo.BackColor = System.Drawing.Color.White;
            this.btnGenerarAreaTrabajo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarAreaTrabajo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnGenerarAreaTrabajo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(159)))), ((int)(((byte)(40)))));
            this.btnGenerarAreaTrabajo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btnGenerarAreaTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarAreaTrabajo.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarAreaTrabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.btnGenerarAreaTrabajo.Location = new System.Drawing.Point(254, 127);
            this.btnGenerarAreaTrabajo.Name = "btnGenerarAreaTrabajo";
            this.btnGenerarAreaTrabajo.Size = new System.Drawing.Size(249, 40);
            this.btnGenerarAreaTrabajo.TabIndex = 50;
            this.tags.SetTag2(this.btnGenerarAreaTrabajo, null);
            this.tags.SetTag3(this.btnGenerarAreaTrabajo, null);
            this.tags.SetTagFontName(this.btnGenerarAreaTrabajo, fontsD.Lato);
            this.tags.SetTagFontSize(this.btnGenerarAreaTrabajo, 15F);
            this.tags.SetTagFontStyle(this.btnGenerarAreaTrabajo, System.Drawing.FontStyle.Regular);
            this.btnGenerarAreaTrabajo.Text = "Generar por Área Trabajo";
            this.btnGenerarAreaTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarAreaTrabajo.UseVisualStyleBackColor = false;
            this.btnGenerarAreaTrabajo.Click += new System.EventHandler(this.btnGenerarAreaTrabajo_Click);
            // 
            // lblCreditos
            // 
            this.lblCreditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCreditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCreditos.Font = new System.Drawing.Font("Montserrat", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.lblCreditos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCreditos.Location = new System.Drawing.Point(671, 493);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(80, 22);
            this.lblCreditos.TabIndex = 52;
            this.tags.SetTag2(this.lblCreditos, null);
            this.tags.SetTag3(this.lblCreditos, null);
            this.tags.SetTagFontName(this.lblCreditos, fontsD.Montserrat);
            this.tags.SetTagFontSize(this.lblCreditos, 12F);
            this.tags.SetTagFontStyle(this.lblCreditos, System.Drawing.FontStyle.Bold);
            this.lblCreditos.Text = "Créditos";
            this.lblCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCreditos.Click += new System.EventHandler(this.lblCreditos_Click);
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.pnlInformacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlInformacion.BackgroundImage")));
            this.pnlInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformacion.Location = new System.Drawing.Point(540, 88);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(80, 80);
            this.pnlInformacion.TabIndex = 53;
            this.tags.SetTag2(this.pnlInformacion, null);
            this.tags.SetTag3(this.pnlInformacion, null);
            this.tags.SetTagFontName(this.pnlInformacion, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlInformacion, 10F);
            this.tags.SetTagFontStyle(this.pnlInformacion, System.Drawing.FontStyle.Regular);
            // 
            // pnlAbajoInformacion
            // 
            this.pnlAbajoInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.pnlAbajoInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAbajoInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAbajoInformacion.Location = new System.Drawing.Point(540, 167);
            this.pnlAbajoInformacion.Name = "pnlAbajoInformacion";
            this.pnlAbajoInformacion.Size = new System.Drawing.Size(80, 10);
            this.pnlAbajoInformacion.TabIndex = 54;
            this.tags.SetTag2(this.pnlAbajoInformacion, null);
            this.tags.SetTag3(this.pnlAbajoInformacion, null);
            this.tags.SetTagFontName(this.pnlAbajoInformacion, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlAbajoInformacion, 10F);
            this.tags.SetTagFontStyle(this.pnlAbajoInformacion, System.Drawing.FontStyle.Regular);
            // 
            // pnlAbajoConfiguracion
            // 
            this.pnlAbajoConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.pnlAbajoConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAbajoConfiguracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAbajoConfiguracion.Location = new System.Drawing.Point(626, 167);
            this.pnlAbajoConfiguracion.Name = "pnlAbajoConfiguracion";
            this.pnlAbajoConfiguracion.Size = new System.Drawing.Size(80, 10);
            this.pnlAbajoConfiguracion.TabIndex = 56;
            this.tags.SetTag2(this.pnlAbajoConfiguracion, null);
            this.tags.SetTag3(this.pnlAbajoConfiguracion, null);
            this.tags.SetTagFontName(this.pnlAbajoConfiguracion, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlAbajoConfiguracion, 10F);
            this.tags.SetTagFontStyle(this.pnlAbajoConfiguracion, System.Drawing.FontStyle.Regular);
            // 
            // pnlConfiguracion
            // 
            this.pnlConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.pnlConfiguracion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlConfiguracion.BackgroundImage")));
            this.pnlConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlConfiguracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfiguracion.Location = new System.Drawing.Point(626, 88);
            this.pnlConfiguracion.Name = "pnlConfiguracion";
            this.pnlConfiguracion.Size = new System.Drawing.Size(80, 80);
            this.pnlConfiguracion.TabIndex = 55;
            this.tags.SetTag2(this.pnlConfiguracion, null);
            this.tags.SetTag3(this.pnlConfiguracion, null);
            this.tags.SetTagFontName(this.pnlConfiguracion, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.pnlConfiguracion, 10F);
            this.tags.SetTagFontStyle(this.pnlConfiguracion, System.Drawing.FontStyle.Regular);
            // 
            // ultimoReporteDashboard1
            // 
            this.ultimoReporteDashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.ultimoReporteDashboard1.Location = new System.Drawing.Point(36, 228);
            this.ultimoReporteDashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.ultimoReporteDashboard1.MontoEgresos = "9,999,999.00";
            this.ultimoReporteDashboard1.MontoIngresos = "9,999,999.00";
            this.ultimoReporteDashboard1.MontoTotal = "9,999,999.00";
            this.ultimoReporteDashboard1.Name = "ultimoReporteDashboard1";
            this.ultimoReporteDashboard1.PeriodoReporte = "Mensual";
            this.ultimoReporteDashboard1.RangoFechasReporte = "24/03/2020 - 24/04/2020";
            this.ultimoReporteDashboard1.SedeReporte = "Surquillo";
            this.ultimoReporteDashboard1.Size = new System.Drawing.Size(430, 255);
            this.ultimoReporteDashboard1.TabIndex = 57;
            this.tags.SetTag2(this.ultimoReporteDashboard1, null);
            this.tags.SetTag3(this.ultimoReporteDashboard1, null);
            this.tags.SetTagFontName(this.ultimoReporteDashboard1, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.ultimoReporteDashboard1, 10F);
            this.tags.SetTagFontStyle(this.ultimoReporteDashboard1, System.Drawing.FontStyle.Regular);
            this.ultimoReporteDashboard1.TextoPrincipal = "MegaAutos";
            this.ultimoReporteDashboard1.TipoReporte = "Áreas de Trabajo";
            this.ultimoReporteDashboard1.UsuarioGenerador = "Perseus Jackson";
            this.ultimoReporteDashboard1.VerReporteClick += new LP2MegaAutos.Framework.UserControls.UltimoReporteDashboard.ButtonClickEventHandler(this.ultimoReporteDashboard1_VerReporteClick);
            // 
            // lblActualizarEmpresa
            // 
            this.lblActualizarEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblActualizarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblActualizarEmpresa.Font = new System.Drawing.Font("Montserrat", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.lblActualizarEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActualizarEmpresa.Location = new System.Drawing.Point(32, 493);
            this.lblActualizarEmpresa.Name = "lblActualizarEmpresa";
            this.lblActualizarEmpresa.Size = new System.Drawing.Size(249, 22);
            this.lblActualizarEmpresa.TabIndex = 58;
            this.tags.SetTag2(this.lblActualizarEmpresa, null);
            this.tags.SetTag3(this.lblActualizarEmpresa, null);
            this.tags.SetTagFontName(this.lblActualizarEmpresa, fontsD.Ninguno);
            this.tags.SetTagFontSize(this.lblActualizarEmpresa, 12F);
            this.tags.SetTagFontStyle(this.lblActualizarEmpresa, System.Drawing.FontStyle.Bold);
            this.lblActualizarEmpresa.Text = "Cambiar Nombre Empresa";
            this.lblActualizarEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActualizarEmpresa.Visible = false;
            this.lblActualizarEmpresa.Click += new System.EventHandler(this.lblActualizarEmpresa_Click);
            // 
            // pantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.lblActualizarEmpresa);
            this.Controls.Add(this.ultimoReporteDashboard1);
            this.Controls.Add(this.pnlAbajoConfiguracion);
            this.Controls.Add(this.pnlAbajoInformacion);
            this.Controls.Add(this.pnlConfiguracion);
            this.Controls.Add(this.pnlInformacion);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.btnGenerarAreaTrabajo);
            this.Controls.Add(this.btnGenerarCliente);
            this.Controls.Add(this.btnGenerarVehiculo);
            this.Controls.Add(this.btnImgAreaTrabajo);
            this.Controls.Add(this.btnImgCliente);
            this.Controls.Add(this.btnImgVehiculo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListaReportes);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.pnlLineaTitulo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "pantallaInicio";
            this.Size = new System.Drawing.Size(751, 520);
            this.tags.SetTag2(this, null);
            this.tags.SetTag3(this, null);
            this.tags.SetTagFontName(this, fontsD.Ninguno);
            this.tags.SetTagFontSize(this, 10F);
            this.tags.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TagsExtender tags;
        private System.Windows.Forms.Panel pnlLineaTitulo;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnListaReportes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnImgVehiculo;
        private System.Windows.Forms.Button btnImgCliente;
        private System.Windows.Forms.Button btnImgAreaTrabajo;
        private System.Windows.Forms.Button btnGenerarVehiculo;
        private System.Windows.Forms.Button btnGenerarCliente;
        private System.Windows.Forms.Button btnGenerarAreaTrabajo;
        private CustomControls.ClickableText lblCreditos;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Panel pnlAbajoInformacion;
        private System.Windows.Forms.Panel pnlAbajoConfiguracion;
        private System.Windows.Forms.Panel pnlConfiguracion;
        private Framework.UserControls.UltimoReporteDashboard ultimoReporteDashboard1;
        private CustomControls.ClickableText lblActualizarEmpresa;
    }
}
