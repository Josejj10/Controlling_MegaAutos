namespace LP2MegaAutos
{
    partial class pantallaActualizarUsuarios
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
            this.systemColorsExtender1 = new LP2MegaAutos.SystemColorsExtender();
            this.roundedPanelExtender1 = new LP2MegaAutos.RoundedPanelExtender();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_AZ = new System.Windows.Forms.Button();
            this.btn_ZA = new System.Windows.Forms.Button();
            this.btn_Antiguo = new System.Windows.Forms.Button();
            this.btn_Reciente = new System.Windows.Forms.Button();
            this.rpn_ListaUsuarios = new LP2MegaAutos.RoundedPanel();
            this.lbl_ListaUsuarios = new System.Windows.Forms.Label();
            this.btn_AgregarUsuario = new System.Windows.Forms.Button();
            this.rpn_ListaUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.systemColorsExtender1.SetBackColorSystem(this.textBox1, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.textBox1.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemColorsExtender1.SetForeColorSystem(this.textBox1, LP2MegaAutos.ColoresSistema.HighContrast);
            this.textBox1.Location = new System.Drawing.Point(40, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 30);
            this.textBox1.TabIndex = 0;
            // 
            // btn_AZ
            // 
            this.btn_AZ.BackColor = System.Drawing.Color.Transparent;
            this.systemColorsExtender1.SetBackColorSystem(this.btn_AZ, LP2MegaAutos.ColoresSistema.Transparent);
            this.btn_AZ.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemColorsExtender1.SetForeColorSystem(this.btn_AZ, LP2MegaAutos.ColoresSistema.HighContrast);
            this.btn_AZ.Location = new System.Drawing.Point(36, 65);
            this.btn_AZ.Name = "btn_AZ";
            this.btn_AZ.Size = new System.Drawing.Size(130, 35);
            this.btn_AZ.TabIndex = 1;
            this.btn_AZ.Text = "A - Z";
            this.btn_AZ.UseVisualStyleBackColor = false;
            // 
            // btn_ZA
            // 
            this.btn_ZA.BackColor = System.Drawing.Color.Transparent;
            this.systemColorsExtender1.SetBackColorSystem(this.btn_ZA, LP2MegaAutos.ColoresSistema.Transparent);
            this.btn_ZA.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ZA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.btn_ZA, LP2MegaAutos.ColoresSistema.HighContrast);
            this.btn_ZA.Location = new System.Drawing.Point(172, 65);
            this.btn_ZA.Name = "btn_ZA";
            this.btn_ZA.Size = new System.Drawing.Size(130, 35);
            this.btn_ZA.TabIndex = 2;
            this.btn_ZA.Text = "Z - A";
            this.btn_ZA.UseVisualStyleBackColor = false;
            // 
            // btn_Antiguo
            // 
            this.btn_Antiguo.BackColor = System.Drawing.Color.Transparent;
            this.systemColorsExtender1.SetBackColorSystem(this.btn_Antiguo, LP2MegaAutos.ColoresSistema.Transparent);
            this.btn_Antiguo.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Antiguo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.btn_Antiguo, LP2MegaAutos.ColoresSistema.HighContrast);
            this.btn_Antiguo.Location = new System.Drawing.Point(308, 65);
            this.btn_Antiguo.Name = "btn_Antiguo";
            this.btn_Antiguo.Size = new System.Drawing.Size(130, 35);
            this.btn_Antiguo.TabIndex = 3;
            this.btn_Antiguo.Text = "Antiguo";
            this.btn_Antiguo.UseVisualStyleBackColor = false;
            // 
            // btn_Reciente
            // 
            this.btn_Reciente.BackColor = System.Drawing.Color.Transparent;
            this.systemColorsExtender1.SetBackColorSystem(this.btn_Reciente, LP2MegaAutos.ColoresSistema.Transparent);
            this.btn_Reciente.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.btn_Reciente, LP2MegaAutos.ColoresSistema.HighContrast);
            this.btn_Reciente.Location = new System.Drawing.Point(444, 65);
            this.btn_Reciente.Name = "btn_Reciente";
            this.btn_Reciente.Size = new System.Drawing.Size(130, 35);
            this.btn_Reciente.TabIndex = 4;
            this.btn_Reciente.Text = "Reciente";
            this.btn_Reciente.UseVisualStyleBackColor = false;
            // 
            // rpn_ListaUsuarios
            // 
            this.roundedPanelExtender1.SetArcoRBorde(this.rpn_ListaUsuarios, 15);
            this.roundedPanelExtender1.SetArcoRPanel(this.rpn_ListaUsuarios, 15);
            this.rpn_ListaUsuarios.ArcRadiusBorde = 15;
            this.rpn_ListaUsuarios.ArcRadiusPanel = 15;
            this.systemColorsExtender1.SetBackColorSystem(this.rpn_ListaUsuarios, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanelExtender1.SetColorSistemaBorde(this.rpn_ListaUsuarios, LP2MegaAutos.ColoresSistema.BackBackground);
            this.roundedPanelExtender1.SetColorSistemaPanel(this.rpn_ListaUsuarios, LP2MegaAutos.ColoresSistema.Morado);
            this.rpn_ListaUsuarios.Controls.Add(this.btn_AgregarUsuario);
            this.rpn_ListaUsuarios.Controls.Add(this.lbl_ListaUsuarios);
            this.roundedPanelExtender1.SetCorners(this.rpn_ListaUsuarios, Plasmoid.Extensions.RectangleEdgeFilter.None);
            this.rpn_ListaUsuarios.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.None;
            this.systemColorsExtender1.SetForeColorSystem(this.rpn_ListaUsuarios, LP2MegaAutos.ColoresSistema.HighContrast);
            this.rpn_ListaUsuarios.Location = new System.Drawing.Point(36, 106);
            this.rpn_ListaUsuarios.MenosHeightBorde = 1;
            this.rpn_ListaUsuarios.MenosHeightPanel = 1;
            this.rpn_ListaUsuarios.MenosWidthBorde = 1;
            this.rpn_ListaUsuarios.MenosWidthPanel = 1;
            this.rpn_ListaUsuarios.Name = "rpn_ListaUsuarios";
            this.rpn_ListaUsuarios.PorcLuzColorBorde = 0;
            this.rpn_ListaUsuarios.Size = new System.Drawing.Size(538, 36);
            this.rpn_ListaUsuarios.TabIndex = 5;
            this.rpn_ListaUsuarios.XBorde = 0;
            this.rpn_ListaUsuarios.XPanel = 0;
            this.rpn_ListaUsuarios.YBorde = 0;
            this.rpn_ListaUsuarios.YPanel = 0;
            // 
            // lbl_ListaUsuarios
            // 
            this.lbl_ListaUsuarios.AutoSize = true;
            this.lbl_ListaUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(226)))));
            this.systemColorsExtender1.SetBackColorSystem(this.lbl_ListaUsuarios, LP2MegaAutos.ColoresSistema.Morado);
            this.lbl_ListaUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ListaUsuarios.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListaUsuarios.ForeColor = System.Drawing.Color.White;
            this.systemColorsExtender1.SetForeColorSystem(this.lbl_ListaUsuarios, LP2MegaAutos.ColoresSistema.HighContrast);
            this.lbl_ListaUsuarios.Location = new System.Drawing.Point(215, 1);
            this.lbl_ListaUsuarios.Name = "lbl_ListaUsuarios";
            this.lbl_ListaUsuarios.Size = new System.Drawing.Size(108, 29);
            this.lbl_ListaUsuarios.TabIndex = 0;
            this.lbl_ListaUsuarios.Text = "Usuarios";
            this.lbl_ListaUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_AgregarUsuario
            // 
            this.btn_AgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(33)))));
            this.systemColorsExtender1.SetBackColorSystem(this.btn_AgregarUsuario, LP2MegaAutos.ColoresSistema.PrincipalRojo);
            this.btn_AgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btn_AgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarUsuario.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarUsuario.ForeColor = System.Drawing.Color.White;
            this.systemColorsExtender1.SetForeColorSystem(this.btn_AgregarUsuario, LP2MegaAutos.ColoresSistema.HighContrast);
            this.btn_AgregarUsuario.Location = new System.Drawing.Point(432, 4);
            this.btn_AgregarUsuario.Name = "btn_AgregarUsuario";
            this.btn_AgregarUsuario.Size = new System.Drawing.Size(94, 26);
            this.btn_AgregarUsuario.TabIndex = 6;
            this.btn_AgregarUsuario.Text = "+ Agregar";
            this.btn_AgregarUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_AgregarUsuario.UseVisualStyleBackColor = false;
            // 
            // pantallaActualizarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.systemColorsExtender1.SetBackColorSystem(this, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.Controls.Add(this.rpn_ListaUsuarios);
            this.Controls.Add(this.btn_Reciente);
            this.Controls.Add(this.btn_Antiguo);
            this.Controls.Add(this.btn_ZA);
            this.Controls.Add(this.btn_AZ);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this, LP2MegaAutos.ColoresSistema.HighContrast);
            this.Name = "pantallaActualizarUsuarios";
            this.Size = new System.Drawing.Size(611, 470);
            this.rpn_ListaUsuarios.ResumeLayout(false);
            this.rpn_ListaUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SystemColorsExtender systemColorsExtender1;
        private RoundedPanelExtender roundedPanelExtender1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_AZ;
        private System.Windows.Forms.Button btn_ZA;
        private System.Windows.Forms.Button btn_Antiguo;
        private System.Windows.Forms.Button btn_Reciente;
        private RoundedPanel rpn_ListaUsuarios;
        private System.Windows.Forms.Button btn_AgregarUsuario;
        private System.Windows.Forms.Label lbl_ListaUsuarios;
    }
}
