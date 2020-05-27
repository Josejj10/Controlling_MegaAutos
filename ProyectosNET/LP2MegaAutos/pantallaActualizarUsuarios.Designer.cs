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
            this.txt_BuscarUsuario = new System.Windows.Forms.TextBox();
            this.btn_AZ = new System.Windows.Forms.Button();
            this.btn_ZA = new System.Windows.Forms.Button();
            this.btn_Antiguo = new System.Windows.Forms.Button();
            this.btn_Reciente = new System.Windows.Forms.Button();
            this.rpn_ListaUsuarios = new LP2MegaAutos.RoundedPanel();
            this.btn_AgregarUsuario = new System.Windows.Forms.Button();
            this.lbl_ListaUsuarios = new System.Windows.Forms.Label();
            this.itemLista1 = new LP2MegaAutos.itemLista();
            this.itemLista2 = new LP2MegaAutos.itemLista();
            this.itemLista3 = new LP2MegaAutos.itemLista();
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.rpn_ListaUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_BuscarUsuario
            // 
            this.txt_BuscarUsuario.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarUsuario.Location = new System.Drawing.Point(36, 29);
            this.txt_BuscarUsuario.Name = "txt_BuscarUsuario";
            this.txt_BuscarUsuario.Size = new System.Drawing.Size(148, 30);
            this.txt_BuscarUsuario.TabIndex = 0;
            // 
            // btn_AZ
            // 
            this.btn_AZ.BackColor = System.Drawing.Color.Transparent;
            this.btn_AZ.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AZ.Location = new System.Drawing.Point(36, 65);
            this.btn_AZ.Name = "btn_AZ";
            this.btn_AZ.Size = new System.Drawing.Size(130, 35);
            this.btn_AZ.TabIndex = 1;
            this.tagsExtender1.SetTag2(this.btn_AZ, null);
            this.tagsExtender1.SetTag3(this.btn_AZ, null);
            this.tagsExtender1.SetTagFontName(this.btn_AZ, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btn_AZ, 15.75F);
            this.tagsExtender1.SetTagFontStyle(this.btn_AZ, System.Drawing.FontStyle.Bold);
            this.btn_AZ.Text = "A - Z";
            this.btn_AZ.UseVisualStyleBackColor = false;
            // 
            // btn_ZA
            // 
            this.btn_ZA.BackColor = System.Drawing.Color.Transparent;
            this.btn_ZA.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ZA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_ZA.Location = new System.Drawing.Point(172, 65);
            this.btn_ZA.Name = "btn_ZA";
            this.btn_ZA.Size = new System.Drawing.Size(130, 35);
            this.btn_ZA.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.btn_ZA, null);
            this.tagsExtender1.SetTag3(this.btn_ZA, null);
            this.tagsExtender1.SetTagFontName(this.btn_ZA, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btn_ZA, 15.75F);
            this.tagsExtender1.SetTagFontStyle(this.btn_ZA, System.Drawing.FontStyle.Bold);
            this.btn_ZA.Text = "Z - A";
            this.btn_ZA.UseVisualStyleBackColor = false;
            // 
            // btn_Antiguo
            // 
            this.btn_Antiguo.BackColor = System.Drawing.Color.Transparent;
            this.btn_Antiguo.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Antiguo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_Antiguo.Location = new System.Drawing.Point(308, 65);
            this.btn_Antiguo.Name = "btn_Antiguo";
            this.btn_Antiguo.Size = new System.Drawing.Size(130, 35);
            this.btn_Antiguo.TabIndex = 3;
            this.tagsExtender1.SetTag2(this.btn_Antiguo, null);
            this.tagsExtender1.SetTag3(this.btn_Antiguo, null);
            this.tagsExtender1.SetTagFontName(this.btn_Antiguo, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btn_Antiguo, 15.75F);
            this.tagsExtender1.SetTagFontStyle(this.btn_Antiguo, System.Drawing.FontStyle.Bold);
            this.btn_Antiguo.Text = "Antiguo";
            this.btn_Antiguo.UseVisualStyleBackColor = false;
            // 
            // btn_Reciente
            // 
            this.btn_Reciente.BackColor = System.Drawing.Color.Transparent;
            this.btn_Reciente.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_Reciente.Location = new System.Drawing.Point(444, 65);
            this.btn_Reciente.Name = "btn_Reciente";
            this.btn_Reciente.Size = new System.Drawing.Size(130, 35);
            this.btn_Reciente.TabIndex = 4;
            this.tagsExtender1.SetTag2(this.btn_Reciente, null);
            this.tagsExtender1.SetTag3(this.btn_Reciente, null);
            this.tagsExtender1.SetTagFontName(this.btn_Reciente, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btn_Reciente, 15.75F);
            this.tagsExtender1.SetTagFontStyle(this.btn_Reciente, System.Drawing.FontStyle.Bold);
            this.btn_Reciente.Text = "Reciente";
            this.btn_Reciente.UseVisualStyleBackColor = false;
            // 
            // rpn_ListaUsuarios
            // 
            this.rpn_ListaUsuarios.ArcRadiusBorde = 15;
            this.rpn_ListaUsuarios.ArcRadiusPanel = 15;
            this.rpn_ListaUsuarios.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpn_ListaUsuarios.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(226)))));
            this.rpn_ListaUsuarios.Controls.Add(this.btn_AgregarUsuario);
            this.rpn_ListaUsuarios.Controls.Add(this.lbl_ListaUsuarios);
            this.rpn_ListaUsuarios.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.None;
            this.rpn_ListaUsuarios.Location = new System.Drawing.Point(36, 106);
            this.rpn_ListaUsuarios.MenosHeightBorde = 1;
            this.rpn_ListaUsuarios.MenosHeightPanel = 1;
            this.rpn_ListaUsuarios.MenosWidthBorde = 1;
            this.rpn_ListaUsuarios.MenosWidthPanel = 1;
            this.rpn_ListaUsuarios.Name = "rpn_ListaUsuarios";
            this.rpn_ListaUsuarios.PorcLuzColorBorde = 0;
            this.rpn_ListaUsuarios.Size = new System.Drawing.Size(538, 36);
            this.rpn_ListaUsuarios.TabIndex = 5;
            this.tagsExtender1.SetTag2(this.rpn_ListaUsuarios, null);
            this.tagsExtender1.SetTag3(this.rpn_ListaUsuarios, null);
            this.tagsExtender1.SetTagFontName(this.rpn_ListaUsuarios, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpn_ListaUsuarios, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpn_ListaUsuarios, System.Drawing.FontStyle.Regular);
            this.rpn_ListaUsuarios.XBorde = 0;
            this.rpn_ListaUsuarios.XPanel = 0;
            this.rpn_ListaUsuarios.YBorde = 0;
            this.rpn_ListaUsuarios.YPanel = 0;
            // 
            // btn_AgregarUsuario
            // 
            this.btn_AgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(33)))));
            this.btn_AgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btn_AgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarUsuario.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarUsuario.Location = new System.Drawing.Point(432, 4);
            this.btn_AgregarUsuario.Name = "btn_AgregarUsuario";
            this.btn_AgregarUsuario.Size = new System.Drawing.Size(94, 26);
            this.btn_AgregarUsuario.TabIndex = 6;
            this.tagsExtender1.SetTag2(this.btn_AgregarUsuario, null);
            this.tagsExtender1.SetTag3(this.btn_AgregarUsuario, null);
            this.tagsExtender1.SetTagFontName(this.btn_AgregarUsuario, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btn_AgregarUsuario, 9.74F);
            this.tagsExtender1.SetTagFontStyle(this.btn_AgregarUsuario, System.Drawing.FontStyle.Regular);
            this.btn_AgregarUsuario.Text = "+ Agregar";
            this.btn_AgregarUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_AgregarUsuario.UseVisualStyleBackColor = false;
            // 
            // lbl_ListaUsuarios
            // 
            this.lbl_ListaUsuarios.AutoSize = true;
            this.lbl_ListaUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(226)))));
            this.lbl_ListaUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ListaUsuarios.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListaUsuarios.ForeColor = System.Drawing.Color.White;
            this.lbl_ListaUsuarios.Location = new System.Drawing.Point(213, 4);
            this.lbl_ListaUsuarios.Name = "lbl_ListaUsuarios";
            this.lbl_ListaUsuarios.Size = new System.Drawing.Size(108, 29);
            this.lbl_ListaUsuarios.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.lbl_ListaUsuarios, null);
            this.tagsExtender1.SetTag3(this.lbl_ListaUsuarios, null);
            this.tagsExtender1.SetTagFontName(this.lbl_ListaUsuarios, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lbl_ListaUsuarios, 15.75F);
            this.tagsExtender1.SetTagFontStyle(this.lbl_ListaUsuarios, System.Drawing.FontStyle.Bold);
            this.lbl_ListaUsuarios.Text = "Usuarios";
            this.lbl_ListaUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemLista1
            // 
            this.itemLista1.ColorBack = System.Drawing.Color.White;
            this.itemLista1.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.itemLista1.ColorPanel = System.Drawing.Color.White;
            this.itemLista1.Location = new System.Drawing.Point(53, 148);
            this.itemLista1.Name = "itemLista1";
            this.itemLista1.Size = new System.Drawing.Size(497, 104);
            this.itemLista1.TabIndex = 6;
            this.tagsExtender1.SetTag2(this.itemLista1, null);
            this.tagsExtender1.SetTag3(this.itemLista1, null);
            this.tagsExtender1.SetTagFontName(this.itemLista1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.itemLista1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.itemLista1, System.Drawing.FontStyle.Regular);
            this.itemLista1.TextoAgregadoPor = "Percy Jackson";
            this.itemLista1.TextoFecha = "dd - mm - aaaa";
            this.itemLista1.TextoPrincipal = "Jonathan Berrospi";
            this.itemLista1.Textosecundario = "Jefe de Logistica";
            this.itemLista1.TextoTercero = "jberrospi@pucp.edu.pe";
            // 
            // itemLista2
            // 
            this.itemLista2.ColorBack = System.Drawing.Color.White;
            this.itemLista2.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.itemLista2.ColorPanel = System.Drawing.Color.White;
            this.itemLista2.Location = new System.Drawing.Point(53, 256);
            this.itemLista2.Name = "itemLista2";
            this.itemLista2.Size = new System.Drawing.Size(497, 104);
            this.itemLista2.TabIndex = 7;
            this.tagsExtender1.SetTag2(this.itemLista2, null);
            this.tagsExtender1.SetTag3(this.itemLista2, null);
            this.tagsExtender1.SetTagFontName(this.itemLista2, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.itemLista2, 10F);
            this.tagsExtender1.SetTagFontStyle(this.itemLista2, System.Drawing.FontStyle.Regular);
            this.itemLista2.TextoAgregadoPor = "Percy Jackson";
            this.itemLista2.TextoFecha = "dd - mm - aaaa";
            this.itemLista2.TextoPrincipal = "Juan Villegaz";
            this.itemLista2.Textosecundario = "Analista";
            this.itemLista2.TextoTercero = "jvillegaz@pucp.edu.pe";
            // 
            // itemLista3
            // 
            this.itemLista3.ColorBack = System.Drawing.Color.White;
            this.itemLista3.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.itemLista3.ColorPanel = System.Drawing.Color.White;
            this.itemLista3.Location = new System.Drawing.Point(53, 366);
            this.itemLista3.Name = "itemLista3";
            this.itemLista3.Size = new System.Drawing.Size(497, 104);
            this.itemLista3.TabIndex = 8;
            this.itemLista3.TextoAgregadoPor = "Percy Jackson";
            this.itemLista3.TextoFecha = "dd - mm - aaaa";
            this.itemLista3.TextoPrincipal = "TextoPrincipal";
            this.itemLista3.Textosecundario = "TextoSecundario";
            this.itemLista3.TextoTercero = "TextoTercerDato";
            // 
            // pantallaActualizarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.itemLista3);
            this.Controls.Add(this.itemLista2);
            this.Controls.Add(this.itemLista1);
            this.Controls.Add(this.rpn_ListaUsuarios);
            this.Controls.Add(this.btn_Reciente);
            this.Controls.Add(this.btn_Antiguo);
            this.Controls.Add(this.btn_ZA);
            this.Controls.Add(this.btn_AZ);
            this.Controls.Add(this.txt_BuscarUsuario);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Name = "pantallaActualizarUsuarios";
            this.Size = new System.Drawing.Size(611, 470);
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.rpn_ListaUsuarios.ResumeLayout(false);
            this.rpn_ListaUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_BuscarUsuario;
        private System.Windows.Forms.Button btn_AZ;
        private System.Windows.Forms.Button btn_ZA;
        private System.Windows.Forms.Button btn_Antiguo;
        private System.Windows.Forms.Button btn_Reciente;
        private RoundedPanel rpn_ListaUsuarios;
        private System.Windows.Forms.Button btn_AgregarUsuario;
        private System.Windows.Forms.Label lbl_ListaUsuarios;
        private itemLista itemLista1;
        private itemLista itemLista2;
        private itemLista itemLista3;
        private TagsExtender tagsExtender1;
    }
}
