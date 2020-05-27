namespace LP2MegaAutos
{
    partial class pantallaActualizarDrivers
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
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.btn_Reciente_Drivers = new System.Windows.Forms.Button();
            this.btn_Antiguo_Drivers = new System.Windows.Forms.Button();
            this.btn_ZA_Drivers = new System.Windows.Forms.Button();
            this.btn_AZ_Drivers = new System.Windows.Forms.Button();
            this.btn_AgregarDriver = new System.Windows.Forms.Button();
            this.lbl_ListaDrivers = new System.Windows.Forms.Label();
            this.rpn_ListaDrivers = new LP2MegaAutos.RoundedPanel();
            this.il_Drivers3 = new LP2MegaAutos.itemLista();
            this.il_Drivers2 = new LP2MegaAutos.itemLista();
            this.il_Drivers1 = new LP2MegaAutos.itemLista();
            this.rpn_ListaDrivers.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_BuscarUsuario
            // 
            this.txt_BuscarUsuario.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarUsuario.Location = new System.Drawing.Point(36, 29);
            this.txt_BuscarUsuario.Name = "txt_BuscarUsuario";
            this.txt_BuscarUsuario.Size = new System.Drawing.Size(148, 30);
            this.txt_BuscarUsuario.TabIndex = 1;
            this.tagsExtender1.SetTag2(this.txt_BuscarUsuario, null);
            this.tagsExtender1.SetTag3(this.txt_BuscarUsuario, null);
            this.tagsExtender1.SetTagFontName(this.txt_BuscarUsuario, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.txt_BuscarUsuario, 14.25F);
            this.tagsExtender1.SetTagFontStyle(this.txt_BuscarUsuario, System.Drawing.FontStyle.Bold);
            // 
            // btn_Reciente_Drivers
            // 
            this.btn_Reciente_Drivers.BackColor = System.Drawing.Color.Transparent;
            this.btn_Reciente_Drivers.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reciente_Drivers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_Reciente_Drivers.Location = new System.Drawing.Point(444, 65);
            this.btn_Reciente_Drivers.Name = "btn_Reciente_Drivers";
            this.btn_Reciente_Drivers.Size = new System.Drawing.Size(130, 35);
            this.btn_Reciente_Drivers.TabIndex = 8;
            this.tagsExtender1.SetTag2(this.btn_Reciente_Drivers, null);
            this.tagsExtender1.SetTag3(this.btn_Reciente_Drivers, null);
            this.tagsExtender1.SetTagFontName(this.btn_Reciente_Drivers, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btn_Reciente_Drivers, 15.75F);
            this.tagsExtender1.SetTagFontStyle(this.btn_Reciente_Drivers, System.Drawing.FontStyle.Bold);
            this.btn_Reciente_Drivers.Text = "Reciente";
            this.btn_Reciente_Drivers.UseVisualStyleBackColor = false;
            // 
            // btn_Antiguo_Drivers
            // 
            this.btn_Antiguo_Drivers.BackColor = System.Drawing.Color.Transparent;
            this.btn_Antiguo_Drivers.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Antiguo_Drivers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_Antiguo_Drivers.Location = new System.Drawing.Point(308, 65);
            this.btn_Antiguo_Drivers.Name = "btn_Antiguo_Drivers";
            this.btn_Antiguo_Drivers.Size = new System.Drawing.Size(130, 35);
            this.btn_Antiguo_Drivers.TabIndex = 7;
            this.tagsExtender1.SetTag2(this.btn_Antiguo_Drivers, null);
            this.tagsExtender1.SetTag3(this.btn_Antiguo_Drivers, null);
            this.tagsExtender1.SetTagFontName(this.btn_Antiguo_Drivers, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btn_Antiguo_Drivers, 15.75F);
            this.tagsExtender1.SetTagFontStyle(this.btn_Antiguo_Drivers, System.Drawing.FontStyle.Bold);
            this.btn_Antiguo_Drivers.Text = "Antiguo";
            this.btn_Antiguo_Drivers.UseVisualStyleBackColor = false;
            // 
            // btn_ZA_Drivers
            // 
            this.btn_ZA_Drivers.BackColor = System.Drawing.Color.Transparent;
            this.btn_ZA_Drivers.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ZA_Drivers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_ZA_Drivers.Location = new System.Drawing.Point(172, 65);
            this.btn_ZA_Drivers.Name = "btn_ZA_Drivers";
            this.btn_ZA_Drivers.Size = new System.Drawing.Size(130, 35);
            this.btn_ZA_Drivers.TabIndex = 6;
            this.tagsExtender1.SetTag2(this.btn_ZA_Drivers, null);
            this.tagsExtender1.SetTag3(this.btn_ZA_Drivers, null);
            this.tagsExtender1.SetTagFontName(this.btn_ZA_Drivers, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btn_ZA_Drivers, 15.75F);
            this.tagsExtender1.SetTagFontStyle(this.btn_ZA_Drivers, System.Drawing.FontStyle.Bold);
            this.btn_ZA_Drivers.Text = "Z - A";
            this.btn_ZA_Drivers.UseVisualStyleBackColor = false;
            // 
            // btn_AZ_Drivers
            // 
            this.btn_AZ_Drivers.BackColor = System.Drawing.Color.Transparent;
            this.btn_AZ_Drivers.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AZ_Drivers.Location = new System.Drawing.Point(36, 65);
            this.btn_AZ_Drivers.Name = "btn_AZ_Drivers";
            this.btn_AZ_Drivers.Size = new System.Drawing.Size(130, 35);
            this.btn_AZ_Drivers.TabIndex = 5;
            this.tagsExtender1.SetTag2(this.btn_AZ_Drivers, null);
            this.tagsExtender1.SetTag3(this.btn_AZ_Drivers, null);
            this.tagsExtender1.SetTagFontName(this.btn_AZ_Drivers, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btn_AZ_Drivers, 15.75F);
            this.tagsExtender1.SetTagFontStyle(this.btn_AZ_Drivers, System.Drawing.FontStyle.Bold);
            this.btn_AZ_Drivers.Text = "A - Z";
            this.btn_AZ_Drivers.UseVisualStyleBackColor = false;
            // 
            // btn_AgregarDriver
            // 
            this.btn_AgregarDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(33)))));
            this.btn_AgregarDriver.FlatAppearance.BorderSize = 0;
            this.btn_AgregarDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarDriver.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarDriver.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarDriver.Location = new System.Drawing.Point(432, 4);
            this.btn_AgregarDriver.Name = "btn_AgregarDriver";
            this.btn_AgregarDriver.Size = new System.Drawing.Size(94, 26);
            this.btn_AgregarDriver.TabIndex = 6;
            this.tagsExtender1.SetTag2(this.btn_AgregarDriver, null);
            this.tagsExtender1.SetTag3(this.btn_AgregarDriver, null);
            this.tagsExtender1.SetTagFontName(this.btn_AgregarDriver, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btn_AgregarDriver, 9.74F);
            this.tagsExtender1.SetTagFontStyle(this.btn_AgregarDriver, System.Drawing.FontStyle.Regular);
            this.btn_AgregarDriver.Text = "+ Agregar";
            this.btn_AgregarDriver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_AgregarDriver.UseVisualStyleBackColor = false;
            // 
            // lbl_ListaDrivers
            // 
            this.lbl_ListaDrivers.AutoSize = true;
            this.lbl_ListaDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(226)))));
            this.lbl_ListaDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ListaDrivers.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListaDrivers.ForeColor = System.Drawing.Color.White;
            this.lbl_ListaDrivers.Location = new System.Drawing.Point(213, 4);
            this.lbl_ListaDrivers.Name = "lbl_ListaDrivers";
            this.lbl_ListaDrivers.Size = new System.Drawing.Size(91, 29);
            this.lbl_ListaDrivers.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.lbl_ListaDrivers, null);
            this.tagsExtender1.SetTag3(this.lbl_ListaDrivers, null);
            this.tagsExtender1.SetTagFontName(this.lbl_ListaDrivers, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.lbl_ListaDrivers, 15.75F);
            this.tagsExtender1.SetTagFontStyle(this.lbl_ListaDrivers, System.Drawing.FontStyle.Bold);
            this.lbl_ListaDrivers.Text = "Drivers";
            this.lbl_ListaDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rpn_ListaDrivers
            // 
            this.rpn_ListaDrivers.ArcRadiusBorde = 15;
            this.rpn_ListaDrivers.ArcRadiusPanel = 15;
            this.rpn_ListaDrivers.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpn_ListaDrivers.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(226)))));
            this.rpn_ListaDrivers.Controls.Add(this.btn_AgregarDriver);
            this.rpn_ListaDrivers.Controls.Add(this.lbl_ListaDrivers);
            this.rpn_ListaDrivers.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.None;
            this.rpn_ListaDrivers.Location = new System.Drawing.Point(36, 106);
            this.rpn_ListaDrivers.MenosHeightBorde = 1;
            this.rpn_ListaDrivers.MenosHeightPanel = 1;
            this.rpn_ListaDrivers.MenosWidthBorde = 1;
            this.rpn_ListaDrivers.MenosWidthPanel = 1;
            this.rpn_ListaDrivers.Name = "rpn_ListaDrivers";
            this.rpn_ListaDrivers.PorcLuzColorBorde = 0;
            this.rpn_ListaDrivers.Size = new System.Drawing.Size(538, 36);
            this.rpn_ListaDrivers.TabIndex = 9;
            this.tagsExtender1.SetTag2(this.rpn_ListaDrivers, null);
            this.tagsExtender1.SetTag3(this.rpn_ListaDrivers, null);
            this.tagsExtender1.SetTagFontName(this.rpn_ListaDrivers, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpn_ListaDrivers, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpn_ListaDrivers, System.Drawing.FontStyle.Regular);
            this.rpn_ListaDrivers.XBorde = 0;
            this.rpn_ListaDrivers.XPanel = 0;
            this.rpn_ListaDrivers.YBorde = 0;
            this.rpn_ListaDrivers.YPanel = 0;
            // 
            // il_Drivers3
            // 
            this.il_Drivers3.ColorBack = System.Drawing.Color.White;
            this.il_Drivers3.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.il_Drivers3.ColorPanel = System.Drawing.Color.White;
            this.il_Drivers3.Location = new System.Drawing.Point(57, 364);
            this.il_Drivers3.Name = "il_Drivers3";
            this.il_Drivers3.Size = new System.Drawing.Size(497, 104);
            this.il_Drivers3.TabIndex = 12;
            this.tagsExtender1.SetTag2(this.il_Drivers3, null);
            this.tagsExtender1.SetTag3(this.il_Drivers3, null);
            this.tagsExtender1.SetTagFontName(this.il_Drivers3, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.il_Drivers3, 10F);
            this.tagsExtender1.SetTagFontStyle(this.il_Drivers3, System.Drawing.FontStyle.Regular);
            this.il_Drivers3.TextoAgregadoPor = "Percy Jackson";
            this.il_Drivers3.TextoFecha = "dd - mm - aaaa";
            this.il_Drivers3.TextoPrincipal = "TextoPrincipal";
            this.il_Drivers3.Textosecundario = "TextoSecundario";
            this.il_Drivers3.TextoTercero = "TextoTercerDato";
            // 
            // il_Drivers2
            // 
            this.il_Drivers2.ColorBack = System.Drawing.Color.White;
            this.il_Drivers2.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.il_Drivers2.ColorPanel = System.Drawing.Color.White;
            this.il_Drivers2.Location = new System.Drawing.Point(57, 254);
            this.il_Drivers2.Name = "il_Drivers2";
            this.il_Drivers2.Size = new System.Drawing.Size(497, 104);
            this.il_Drivers2.TabIndex = 11;
            this.tagsExtender1.SetTag2(this.il_Drivers2, null);
            this.tagsExtender1.SetTag3(this.il_Drivers2, null);
            this.tagsExtender1.SetTagFontName(this.il_Drivers2, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.il_Drivers2, 10F);
            this.tagsExtender1.SetTagFontStyle(this.il_Drivers2, System.Drawing.FontStyle.Regular);
            this.il_Drivers2.TextoAgregadoPor = "Percy Jackson";
            this.il_Drivers2.TextoFecha = "dd - mm - aaaa";
            this.il_Drivers2.TextoPrincipal = "3/8";
            this.il_Drivers2.Textosecundario = "Planchado";
            this.il_Drivers2.TextoTercero = "Cuenta Contable 2";
            // 
            // il_Drivers1
            // 
            this.il_Drivers1.ColorBack = System.Drawing.Color.White;
            this.il_Drivers1.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.il_Drivers1.ColorPanel = System.Drawing.Color.White;
            this.il_Drivers1.Location = new System.Drawing.Point(57, 146);
            this.il_Drivers1.Name = "il_Drivers1";
            this.il_Drivers1.Size = new System.Drawing.Size(497, 104);
            this.il_Drivers1.TabIndex = 10;
            this.tagsExtender1.SetTag2(this.il_Drivers1, null);
            this.tagsExtender1.SetTag3(this.il_Drivers1, null);
            this.tagsExtender1.SetTagFontName(this.il_Drivers1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.il_Drivers1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.il_Drivers1, System.Drawing.FontStyle.Regular);
            this.il_Drivers1.TextoAgregadoPor = "Percy Jackson";
            this.il_Drivers1.TextoFecha = "dd - mm - aaaa";
            this.il_Drivers1.TextoPrincipal = "1/5";
            this.il_Drivers1.Textosecundario = "Mecanica";
            this.il_Drivers1.TextoTercero = "Cuenta Contable";
            // 
            // pantallaActualizarDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.il_Drivers3);
            this.Controls.Add(this.il_Drivers2);
            this.Controls.Add(this.il_Drivers1);
            this.Controls.Add(this.rpn_ListaDrivers);
            this.Controls.Add(this.btn_Reciente_Drivers);
            this.Controls.Add(this.btn_Antiguo_Drivers);
            this.Controls.Add(this.btn_ZA_Drivers);
            this.Controls.Add(this.btn_AZ_Drivers);
            this.Controls.Add(this.txt_BuscarUsuario);
            this.Name = "pantallaActualizarDrivers";
            this.Size = new System.Drawing.Size(611, 470);
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.rpn_ListaDrivers.ResumeLayout(false);
            this.rpn_ListaDrivers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_BuscarUsuario;
        private TagsExtender tagsExtender1;
        private System.Windows.Forms.Button btn_Reciente_Drivers;
        private System.Windows.Forms.Button btn_Antiguo_Drivers;
        private System.Windows.Forms.Button btn_ZA_Drivers;
        private System.Windows.Forms.Button btn_AZ_Drivers;
        private System.Windows.Forms.Button btn_AgregarDriver;
        private System.Windows.Forms.Label lbl_ListaDrivers;
        private RoundedPanel rpn_ListaDrivers;
        private itemLista il_Drivers3;
        private itemLista il_Drivers2;
        private itemLista il_Drivers1;
    }
}
