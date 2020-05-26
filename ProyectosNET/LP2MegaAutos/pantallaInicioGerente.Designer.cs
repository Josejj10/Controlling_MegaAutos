namespace LP2MegaAutos
{
    partial class pantallaInicioGerente
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
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.roundedPanel1 = new LP2MegaAutos.RoundedPanel();
            this.roundedPanelExtender1 = new LP2MegaAutos.RoundedPanelExtender();
            this.rpn_izqGR = new LP2MegaAutos.RoundedPanel();
            this.rpn_derGR = new LP2MegaAutos.RoundedPanel();
            this.btn_GenerarReporte = new System.Windows.Forms.Button();
            this.rpn_AreaTrabajo = new LP2MegaAutos.RoundedPanel();
            this.rpn_Reportes = new LP2MegaAutos.RoundedPanel();
            this.rpn_Servicios = new LP2MegaAutos.RoundedPanel();
            this.rpn_Drivers = new LP2MegaAutos.RoundedPanel();
            this.rpn_Sedes = new LP2MegaAutos.RoundedPanel();
            this.rpn_Usuarios = new LP2MegaAutos.RoundedPanel();
            this.rpn_Clientes = new LP2MegaAutos.RoundedPanel();
            this.rpn_Empresa = new LP2MegaAutos.RoundedPanel();
            this.rpn_CerrarSesion = new LP2MegaAutos.RoundedPanel();
            this.rpn_Ajustes = new LP2MegaAutos.RoundedPanel();
            this.rpn_ActualizarBase = new LP2MegaAutos.RoundedPanel();
            this.btn_AreaTrabajo = new System.Windows.Forms.Button();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.btn_Servicios = new System.Windows.Forms.Button();
            this.btn_Drivers = new System.Windows.Forms.Button();
            this.btn_Empresa = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_Usuarios = new System.Windows.Forms.Button();
            this.btn_Sedes = new System.Windows.Forms.Button();
            this.btn_ActualizarBD = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.roundedPanel2 = new LP2MegaAutos.RoundedPanel();
            this.roundedPanel3 = new LP2MegaAutos.RoundedPanel();
            this.roundedPanel1.SuspendLayout();
            this.rpn_AreaTrabajo.SuspendLayout();
            this.rpn_Reportes.SuspendLayout();
            this.rpn_Servicios.SuspendLayout();
            this.rpn_Drivers.SuspendLayout();
            this.rpn_Sedes.SuspendLayout();
            this.rpn_Usuarios.SuspendLayout();
            this.rpn_Clientes.SuspendLayout();
            this.rpn_Empresa.SuspendLayout();
            this.rpn_CerrarSesion.SuspendLayout();
            this.rpn_Ajustes.SuspendLayout();
            this.rpn_ActualizarBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.systemColorsExtender1.SetBackColorSystem(this.lblBienvenido, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.lblBienvenido.Font = new System.Drawing.Font("Montserrat", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemColorsExtender1.SetForeColorSystem(this.lblBienvenido, LP2MegaAutos.ColoresSistema.HighContrast);
            this.lblBienvenido.Location = new System.Drawing.Point(171, 19);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(269, 59);
            this.lblBienvenido.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.lblBienvenido, null);
            this.tagsExtender1.SetTag3(this.lblBienvenido, null);
            this.tagsExtender1.SetTagFontName(this.lblBienvenido, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.lblBienvenido, 10F);
            this.tagsExtender1.SetTagFontStyle(this.lblBienvenido, System.Drawing.FontStyle.Regular);
            this.lblBienvenido.Text = "Bienvenido";
            this.lblBienvenido.Click += new System.EventHandler(this.lblBienvenido_Click);
            // 
            // roundedPanel1
            // 
            this.roundedPanelExtender1.SetArcoRBorde(this.roundedPanel1, 15);
            this.roundedPanelExtender1.SetArcoRPanel(this.roundedPanel1, 15);
            this.roundedPanel1.ArcRadiusBorde = 15;
            this.roundedPanel1.ArcRadiusPanel = 15;
            this.systemColorsExtender1.SetBackColorSystem(this.roundedPanel1, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanelExtender1.SetColorSistemaBorde(this.roundedPanel1, LP2MegaAutos.ColoresSistema.BackBackground);
            this.roundedPanelExtender1.SetColorSistemaPanel(this.roundedPanel1, LP2MegaAutos.ColoresSistema.PrincipalIndigo);
            this.roundedPanel1.Controls.Add(this.btn_GenerarReporte);
            this.roundedPanelExtender1.SetCorners(this.roundedPanel1, Plasmoid.Extensions.RectangleEdgeFilter.All);
            this.roundedPanel1.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.roundedPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.roundedPanel1, LP2MegaAutos.ColoresSistema.HighContrast);
            this.roundedPanel1.Location = new System.Drawing.Point(53, 107);
            this.roundedPanel1.MenosHeightBorde = 1;
            this.roundedPanel1.MenosHeightPanel = 1;
            this.roundedPanel1.MenosWidthBorde = 1;
            this.roundedPanel1.MenosWidthPanel = 1;
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.PorcLuzColorBorde = 0;
            this.roundedPanel1.Size = new System.Drawing.Size(505, 100);
            this.roundedPanel1.TabIndex = 1;
            this.tagsExtender1.SetTag2(this.roundedPanel1, null);
            this.tagsExtender1.SetTag3(this.roundedPanel1, null);
            this.tagsExtender1.SetTagFontName(this.roundedPanel1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.roundedPanel1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.roundedPanel1, System.Drawing.FontStyle.Regular);
            this.roundedPanel1.XBorde = 0;
            this.roundedPanel1.XPanel = 0;
            this.roundedPanel1.YBorde = 0;
            this.roundedPanel1.YPanel = 0;
            // 
            // rpn_izqGR
            // 
            this.roundedPanelExtender1.SetArcoRBorde(this.rpn_izqGR, 15);
            this.roundedPanelExtender1.SetArcoRPanel(this.rpn_izqGR, 15);
            this.rpn_izqGR.ArcRadiusBorde = 15;
            this.rpn_izqGR.ArcRadiusPanel = 15;
            this.systemColorsExtender1.SetBackColorSystem(this.rpn_izqGR, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanelExtender1.SetColorSistemaBorde(this.rpn_izqGR, LP2MegaAutos.ColoresSistema.BackBackground);
            this.roundedPanelExtender1.SetColorSistemaPanel(this.rpn_izqGR, LP2MegaAutos.ColoresSistema.PrincipalIndigo);
            this.roundedPanelExtender1.SetCorners(this.rpn_izqGR, Plasmoid.Extensions.RectangleEdgeFilter.Right);
            this.rpn_izqGR.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Right;
            this.systemColorsExtender1.SetForeColorSystem(this.rpn_izqGR, LP2MegaAutos.ColoresSistema.HighContrast);
            this.rpn_izqGR.Location = new System.Drawing.Point(0, 107);
            this.rpn_izqGR.MenosHeightBorde = 1;
            this.rpn_izqGR.MenosHeightPanel = 1;
            this.rpn_izqGR.MenosWidthBorde = 1;
            this.rpn_izqGR.MenosWidthPanel = 1;
            this.rpn_izqGR.Name = "rpn_izqGR";
            this.rpn_izqGR.PorcLuzColorBorde = 0;
            this.rpn_izqGR.Size = new System.Drawing.Size(53, 100);
            this.rpn_izqGR.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.rpn_izqGR, null);
            this.tagsExtender1.SetTag3(this.rpn_izqGR, null);
            this.tagsExtender1.SetTagFontName(this.rpn_izqGR, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpn_izqGR, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpn_izqGR, System.Drawing.FontStyle.Regular);
            this.rpn_izqGR.XBorde = 0;
            this.rpn_izqGR.XPanel = 0;
            this.rpn_izqGR.YBorde = 0;
            this.rpn_izqGR.YPanel = 0;
            // 
            // rpn_derGR
            // 
            this.roundedPanelExtender1.SetArcoRBorde(this.rpn_derGR, 15);
            this.roundedPanelExtender1.SetArcoRPanel(this.rpn_derGR, 15);
            this.rpn_derGR.ArcRadiusBorde = 15;
            this.rpn_derGR.ArcRadiusPanel = 15;
            this.rpn_derGR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.systemColorsExtender1.SetBackColorSystem(this.rpn_derGR, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanelExtender1.SetColorSistemaBorde(this.rpn_derGR, LP2MegaAutos.ColoresSistema.BackBackground);
            this.roundedPanelExtender1.SetColorSistemaPanel(this.rpn_derGR, LP2MegaAutos.ColoresSistema.PrincipalIndigo);
            this.roundedPanelExtender1.SetCorners(this.rpn_derGR, Plasmoid.Extensions.RectangleEdgeFilter.Left);
            this.rpn_derGR.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.rpn_derGR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.rpn_derGR, LP2MegaAutos.ColoresSistema.HighContrast);
            this.rpn_derGR.Location = new System.Drawing.Point(558, 107);
            this.rpn_derGR.MenosHeightBorde = 1;
            this.rpn_derGR.MenosHeightPanel = 1;
            this.rpn_derGR.MenosWidthBorde = 1;
            this.rpn_derGR.MenosWidthPanel = 1;
            this.rpn_derGR.Name = "rpn_derGR";
            this.rpn_derGR.PorcLuzColorBorde = 0;
            this.rpn_derGR.Size = new System.Drawing.Size(53, 100);
            this.rpn_derGR.TabIndex = 3;
            this.tagsExtender1.SetTag2(this.rpn_derGR, null);
            this.tagsExtender1.SetTag3(this.rpn_derGR, null);
            this.tagsExtender1.SetTagFontName(this.rpn_derGR, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpn_derGR, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpn_derGR, System.Drawing.FontStyle.Regular);
            this.rpn_derGR.XBorde = 0;
            this.rpn_derGR.XPanel = 0;
            this.rpn_derGR.YBorde = 0;
            this.rpn_derGR.YPanel = 0;
            // 
            // btn_GenerarReporte
            // 
            this.btn_GenerarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.systemColorsExtender1.SetBackColorSystem(this.btn_GenerarReporte, LP2MegaAutos.ColoresSistema.PrincipalIndigo);
            this.btn_GenerarReporte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_GenerarReporte.FlatAppearance.BorderSize = 0;
            this.btn_GenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GenerarReporte.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerarReporte.ForeColor = System.Drawing.Color.White;
            this.systemColorsExtender1.SetForeColorSystem(this.btn_GenerarReporte, LP2MegaAutos.ColoresSistema.HighContrast);
            this.btn_GenerarReporte.Location = new System.Drawing.Point(6, 3);
            this.btn_GenerarReporte.Name = "btn_GenerarReporte";
            this.btn_GenerarReporte.Size = new System.Drawing.Size(493, 94);
            this.btn_GenerarReporte.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.btn_GenerarReporte, null);
            this.tagsExtender1.SetTag3(this.btn_GenerarReporte, null);
            this.tagsExtender1.SetTagFontName(this.btn_GenerarReporte, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btn_GenerarReporte, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btn_GenerarReporte, System.Drawing.FontStyle.Regular);
            this.btn_GenerarReporte.Text = "Generar Reporte";
            this.btn_GenerarReporte.UseVisualStyleBackColor = false;
            // 
            // rpn_AreaTrabajo
            // 
            this.roundedPanelExtender1.SetArcoRBorde(this.rpn_AreaTrabajo, 15);
            this.roundedPanelExtender1.SetArcoRPanel(this.rpn_AreaTrabajo, 15);
            this.rpn_AreaTrabajo.ArcRadiusBorde = 15;
            this.rpn_AreaTrabajo.ArcRadiusPanel = 15;
            this.systemColorsExtender1.SetBackColorSystem(this.rpn_AreaTrabajo, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanelExtender1.SetColorSistemaBorde(this.rpn_AreaTrabajo, LP2MegaAutos.ColoresSistema.PrincipalIndigo);
            this.roundedPanelExtender1.SetColorSistemaPanel(this.rpn_AreaTrabajo, LP2MegaAutos.ColoresSistema.PrincipalRojo);
            this.rpn_AreaTrabajo.Controls.Add(this.btn_AreaTrabajo);
            this.roundedPanelExtender1.SetCorners(this.rpn_AreaTrabajo, Plasmoid.Extensions.RectangleEdgeFilter.All);
            this.rpn_AreaTrabajo.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.systemColorsExtender1.SetForeColorSystem(this.rpn_AreaTrabajo, LP2MegaAutos.ColoresSistema.HighContrast);
            this.rpn_AreaTrabajo.Location = new System.Drawing.Point(16, 230);
            this.rpn_AreaTrabajo.MenosHeightBorde = 1;
            this.rpn_AreaTrabajo.MenosHeightPanel = 1;
            this.rpn_AreaTrabajo.MenosWidthBorde = 1;
            this.rpn_AreaTrabajo.MenosWidthPanel = 1;
            this.rpn_AreaTrabajo.Name = "rpn_AreaTrabajo";
            this.rpn_AreaTrabajo.PorcLuzColorBorde = 0;
            this.rpn_AreaTrabajo.Size = new System.Drawing.Size(140, 70);
            this.rpn_AreaTrabajo.TabIndex = 4;
            this.tagsExtender1.SetTag2(this.rpn_AreaTrabajo, null);
            this.tagsExtender1.SetTag3(this.rpn_AreaTrabajo, null);
            this.tagsExtender1.SetTagFontName(this.rpn_AreaTrabajo, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpn_AreaTrabajo, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpn_AreaTrabajo, System.Drawing.FontStyle.Regular);
            this.rpn_AreaTrabajo.XBorde = 0;
            this.rpn_AreaTrabajo.XPanel = 0;
            this.rpn_AreaTrabajo.YBorde = 0;
            this.rpn_AreaTrabajo.YPanel = 0;
            // 
            // rpn_Reportes
            // 
            this.roundedPanelExtender1.SetArcoRBorde(this.rpn_Reportes, 15);
            this.roundedPanelExtender1.SetArcoRPanel(this.rpn_Reportes, 15);
            this.rpn_Reportes.ArcRadiusBorde = 15;
            this.rpn_Reportes.ArcRadiusPanel = 15;
            this.rpn_Reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.systemColorsExtender1.SetBackColorSystem(this.rpn_Reportes, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanelExtender1.SetColorSistemaBorde(this.rpn_Reportes, LP2MegaAutos.ColoresSistema.BackBackground);
            this.roundedPanelExtender1.SetColorSistemaPanel(this.rpn_Reportes, LP2MegaAutos.ColoresSistema.PrincipalRojo);
            this.rpn_Reportes.Controls.Add(this.btn_Reportes);
            this.roundedPanelExtender1.SetCorners(this.rpn_Reportes, Plasmoid.Extensions.RectangleEdgeFilter.All);
            this.rpn_Reportes.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpn_Reportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.rpn_Reportes, LP2MegaAutos.ColoresSistema.HighContrast);
            this.rpn_Reportes.Location = new System.Drawing.Point(162, 230);
            this.rpn_Reportes.MenosHeightBorde = 1;
            this.rpn_Reportes.MenosHeightPanel = 1;
            this.rpn_Reportes.MenosWidthBorde = 1;
            this.rpn_Reportes.MenosWidthPanel = 1;
            this.rpn_Reportes.Name = "rpn_Reportes";
            this.rpn_Reportes.PorcLuzColorBorde = 0;
            this.rpn_Reportes.Size = new System.Drawing.Size(140, 70);
            this.rpn_Reportes.TabIndex = 5;
            this.tagsExtender1.SetTag2(this.rpn_Reportes, null);
            this.tagsExtender1.SetTag3(this.rpn_Reportes, null);
            this.tagsExtender1.SetTagFontName(this.rpn_Reportes, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpn_Reportes, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpn_Reportes, System.Drawing.FontStyle.Regular);
            this.rpn_Reportes.XBorde = 0;
            this.rpn_Reportes.XPanel = 0;
            this.rpn_Reportes.YBorde = 0;
            this.rpn_Reportes.YPanel = 0;
            // 
            // rpn_Servicios
            // 
            this.roundedPanelExtender1.SetArcoRBorde(this.rpn_Servicios, 15);
            this.roundedPanelExtender1.SetArcoRPanel(this.rpn_Servicios, 15);
            this.rpn_Servicios.ArcRadiusBorde = 15;
            this.rpn_Servicios.ArcRadiusPanel = 15;
            this.rpn_Servicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.systemColorsExtender1.SetBackColorSystem(this.rpn_Servicios, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanelExtender1.SetColorSistemaBorde(this.rpn_Servicios, LP2MegaAutos.ColoresSistema.BackBackground);
            this.roundedPanelExtender1.SetColorSistemaPanel(this.rpn_Servicios, LP2MegaAutos.ColoresSistema.PrincipalRojo);
            this.rpn_Servicios.Controls.Add(this.btn_Servicios);
            this.roundedPanelExtender1.SetCorners(this.rpn_Servicios, Plasmoid.Extensions.RectangleEdgeFilter.All);
            this.rpn_Servicios.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpn_Servicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.rpn_Servicios, LP2MegaAutos.ColoresSistema.HighContrast);
            this.rpn_Servicios.Location = new System.Drawing.Point(308, 230);
            this.rpn_Servicios.MenosHeightBorde = 1;
            this.rpn_Servicios.MenosHeightPanel = 1;
            this.rpn_Servicios.MenosWidthBorde = 1;
            this.rpn_Servicios.MenosWidthPanel = 1;
            this.rpn_Servicios.Name = "rpn_Servicios";
            this.rpn_Servicios.PorcLuzColorBorde = 0;
            this.rpn_Servicios.Size = new System.Drawing.Size(140, 70);
            this.rpn_Servicios.TabIndex = 5;
            this.tagsExtender1.SetTag2(this.rpn_Servicios, null);
            this.tagsExtender1.SetTag3(this.rpn_Servicios, null);
            this.tagsExtender1.SetTagFontName(this.rpn_Servicios, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpn_Servicios, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpn_Servicios, System.Drawing.FontStyle.Regular);
            this.rpn_Servicios.XBorde = 0;
            this.rpn_Servicios.XPanel = 0;
            this.rpn_Servicios.YBorde = 0;
            this.rpn_Servicios.YPanel = 0;
            // 
            // rpn_Drivers
            // 
            this.roundedPanelExtender1.SetArcoRBorde(this.rpn_Drivers, 15);
            this.roundedPanelExtender1.SetArcoRPanel(this.rpn_Drivers, 15);
            this.rpn_Drivers.ArcRadiusBorde = 15;
            this.rpn_Drivers.ArcRadiusPanel = 15;
            this.rpn_Drivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.systemColorsExtender1.SetBackColorSystem(this.rpn_Drivers, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanelExtender1.SetColorSistemaBorde(this.rpn_Drivers, LP2MegaAutos.ColoresSistema.BackBackground);
            this.roundedPanelExtender1.SetColorSistemaPanel(this.rpn_Drivers, LP2MegaAutos.ColoresSistema.PrincipalRojo);
            this.rpn_Drivers.Controls.Add(this.btn_Drivers);
            this.roundedPanelExtender1.SetCorners(this.rpn_Drivers, Plasmoid.Extensions.RectangleEdgeFilter.All);
            this.rpn_Drivers.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpn_Drivers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.rpn_Drivers, LP2MegaAutos.ColoresSistema.HighContrast);
            this.rpn_Drivers.Location = new System.Drawing.Point(454, 230);
            this.rpn_Drivers.MenosHeightBorde = 1;
            this.rpn_Drivers.MenosHeightPanel = 1;
            this.rpn_Drivers.MenosWidthBorde = 1;
            this.rpn_Drivers.MenosWidthPanel = 1;
            this.rpn_Drivers.Name = "rpn_Drivers";
            this.rpn_Drivers.PorcLuzColorBorde = 0;
            this.rpn_Drivers.Size = new System.Drawing.Size(140, 70);
            this.rpn_Drivers.TabIndex = 5;
            this.tagsExtender1.SetTag2(this.rpn_Drivers, null);
            this.tagsExtender1.SetTag3(this.rpn_Drivers, null);
            this.tagsExtender1.SetTagFontName(this.rpn_Drivers, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpn_Drivers, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpn_Drivers, System.Drawing.FontStyle.Regular);
            this.rpn_Drivers.XBorde = 0;
            this.rpn_Drivers.XPanel = 0;
            this.rpn_Drivers.YBorde = 0;
            this.rpn_Drivers.YPanel = 0;
            // 
            // rpn_Sedes
            // 
            this.roundedPanelExtender1.SetArcoRBorde(this.rpn_Sedes, 15);
            this.roundedPanelExtender1.SetArcoRPanel(this.rpn_Sedes, 15);
            this.rpn_Sedes.ArcRadiusBorde = 15;
            this.rpn_Sedes.ArcRadiusPanel = 15;
            this.rpn_Sedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.systemColorsExtender1.SetBackColorSystem(this.rpn_Sedes, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanelExtender1.SetColorSistemaBorde(this.rpn_Sedes, LP2MegaAutos.ColoresSistema.BackBackground);
            this.roundedPanelExtender1.SetColorSistemaPanel(this.rpn_Sedes, LP2MegaAutos.ColoresSistema.Morado);
            this.rpn_Sedes.Controls.Add(this.btn_Sedes);
            this.roundedPanelExtender1.SetCorners(this.rpn_Sedes, Plasmoid.Extensions.RectangleEdgeFilter.All);
            this.rpn_Sedes.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpn_Sedes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.rpn_Sedes, LP2MegaAutos.ColoresSistema.HighContrast);
            this.rpn_Sedes.Location = new System.Drawing.Point(454, 306);
            this.rpn_Sedes.MenosHeightBorde = 1;
            this.rpn_Sedes.MenosHeightPanel = 1;
            this.rpn_Sedes.MenosWidthBorde = 1;
            this.rpn_Sedes.MenosWidthPanel = 1;
            this.rpn_Sedes.Name = "rpn_Sedes";
            this.rpn_Sedes.PorcLuzColorBorde = 0;
            this.rpn_Sedes.Size = new System.Drawing.Size(140, 70);
            this.rpn_Sedes.TabIndex = 7;
            this.tagsExtender1.SetTag2(this.rpn_Sedes, null);
            this.tagsExtender1.SetTag3(this.rpn_Sedes, null);
            this.tagsExtender1.SetTagFontName(this.rpn_Sedes, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpn_Sedes, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpn_Sedes, System.Drawing.FontStyle.Regular);
            this.rpn_Sedes.XBorde = 0;
            this.rpn_Sedes.XPanel = 0;
            this.rpn_Sedes.YBorde = 0;
            this.rpn_Sedes.YPanel = 0;
            // 
            // rpn_Usuarios
            // 
            this.roundedPanelExtender1.SetArcoRBorde(this.rpn_Usuarios, 15);
            this.roundedPanelExtender1.SetArcoRPanel(this.rpn_Usuarios, 15);
            this.rpn_Usuarios.ArcRadiusBorde = 15;
            this.rpn_Usuarios.ArcRadiusPanel = 15;
            this.rpn_Usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.systemColorsExtender1.SetBackColorSystem(this.rpn_Usuarios, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanelExtender1.SetColorSistemaBorde(this.rpn_Usuarios, LP2MegaAutos.ColoresSistema.BackBackground);
            this.roundedPanelExtender1.SetColorSistemaPanel(this.rpn_Usuarios, LP2MegaAutos.ColoresSistema.Morado);
            this.rpn_Usuarios.Controls.Add(this.btn_Usuarios);
            this.roundedPanelExtender1.SetCorners(this.rpn_Usuarios, Plasmoid.Extensions.RectangleEdgeFilter.All);
            this.rpn_Usuarios.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpn_Usuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.rpn_Usuarios, LP2MegaAutos.ColoresSistema.HighContrast);
            this.rpn_Usuarios.Location = new System.Drawing.Point(308, 306);
            this.rpn_Usuarios.MenosHeightBorde = 1;
            this.rpn_Usuarios.MenosHeightPanel = 1;
            this.rpn_Usuarios.MenosWidthBorde = 1;
            this.rpn_Usuarios.MenosWidthPanel = 1;
            this.rpn_Usuarios.Name = "rpn_Usuarios";
            this.rpn_Usuarios.PorcLuzColorBorde = 0;
            this.rpn_Usuarios.Size = new System.Drawing.Size(140, 70);
            this.rpn_Usuarios.TabIndex = 8;
            this.tagsExtender1.SetTag2(this.rpn_Usuarios, null);
            this.tagsExtender1.SetTag3(this.rpn_Usuarios, null);
            this.tagsExtender1.SetTagFontName(this.rpn_Usuarios, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpn_Usuarios, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpn_Usuarios, System.Drawing.FontStyle.Regular);
            this.rpn_Usuarios.XBorde = 0;
            this.rpn_Usuarios.XPanel = 0;
            this.rpn_Usuarios.YBorde = 0;
            this.rpn_Usuarios.YPanel = 0;
            // 
            // rpn_Clientes
            // 
            this.roundedPanelExtender1.SetArcoRBorde(this.rpn_Clientes, 15);
            this.roundedPanelExtender1.SetArcoRPanel(this.rpn_Clientes, 15);
            this.rpn_Clientes.ArcRadiusBorde = 15;
            this.rpn_Clientes.ArcRadiusPanel = 15;
            this.rpn_Clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.systemColorsExtender1.SetBackColorSystem(this.rpn_Clientes, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanelExtender1.SetColorSistemaBorde(this.rpn_Clientes, LP2MegaAutos.ColoresSistema.BackBackground);
            this.roundedPanelExtender1.SetColorSistemaPanel(this.rpn_Clientes, LP2MegaAutos.ColoresSistema.Morado);
            this.rpn_Clientes.Controls.Add(this.btn_Clientes);
            this.roundedPanelExtender1.SetCorners(this.rpn_Clientes, Plasmoid.Extensions.RectangleEdgeFilter.All);
            this.rpn_Clientes.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpn_Clientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.rpn_Clientes, LP2MegaAutos.ColoresSistema.HighContrast);
            this.rpn_Clientes.Location = new System.Drawing.Point(162, 306);
            this.rpn_Clientes.MenosHeightBorde = 1;
            this.rpn_Clientes.MenosHeightPanel = 1;
            this.rpn_Clientes.MenosWidthBorde = 1;
            this.rpn_Clientes.MenosWidthPanel = 1;
            this.rpn_Clientes.Name = "rpn_Clientes";
            this.rpn_Clientes.PorcLuzColorBorde = 0;
            this.rpn_Clientes.Size = new System.Drawing.Size(140, 70);
            this.rpn_Clientes.TabIndex = 9;
            this.tagsExtender1.SetTag2(this.rpn_Clientes, null);
            this.tagsExtender1.SetTag3(this.rpn_Clientes, null);
            this.tagsExtender1.SetTagFontName(this.rpn_Clientes, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpn_Clientes, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpn_Clientes, System.Drawing.FontStyle.Regular);
            this.rpn_Clientes.XBorde = 0;
            this.rpn_Clientes.XPanel = 0;
            this.rpn_Clientes.YBorde = 0;
            this.rpn_Clientes.YPanel = 0;
            // 
            // rpn_Empresa
            // 
            this.roundedPanelExtender1.SetArcoRBorde(this.rpn_Empresa, 15);
            this.roundedPanelExtender1.SetArcoRPanel(this.rpn_Empresa, 15);
            this.rpn_Empresa.ArcRadiusBorde = 15;
            this.rpn_Empresa.ArcRadiusPanel = 15;
            this.rpn_Empresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.systemColorsExtender1.SetBackColorSystem(this.rpn_Empresa, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanelExtender1.SetColorSistemaBorde(this.rpn_Empresa, LP2MegaAutos.ColoresSistema.BackBackground);
            this.roundedPanelExtender1.SetColorSistemaPanel(this.rpn_Empresa, LP2MegaAutos.ColoresSistema.Morado);
            this.rpn_Empresa.Controls.Add(this.btn_Empresa);
            this.roundedPanelExtender1.SetCorners(this.rpn_Empresa, Plasmoid.Extensions.RectangleEdgeFilter.All);
            this.rpn_Empresa.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpn_Empresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.rpn_Empresa, LP2MegaAutos.ColoresSistema.HighContrast);
            this.rpn_Empresa.Location = new System.Drawing.Point(16, 306);
            this.rpn_Empresa.MenosHeightBorde = 1;
            this.rpn_Empresa.MenosHeightPanel = 1;
            this.rpn_Empresa.MenosWidthBorde = 1;
            this.rpn_Empresa.MenosWidthPanel = 1;
            this.rpn_Empresa.Name = "rpn_Empresa";
            this.rpn_Empresa.PorcLuzColorBorde = 0;
            this.rpn_Empresa.Size = new System.Drawing.Size(140, 70);
            this.rpn_Empresa.TabIndex = 6;
            this.tagsExtender1.SetTag2(this.rpn_Empresa, null);
            this.tagsExtender1.SetTag3(this.rpn_Empresa, null);
            this.tagsExtender1.SetTagFontName(this.rpn_Empresa, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpn_Empresa, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpn_Empresa, System.Drawing.FontStyle.Regular);
            this.rpn_Empresa.XBorde = 0;
            this.rpn_Empresa.XPanel = 0;
            this.rpn_Empresa.YBorde = 0;
            this.rpn_Empresa.YPanel = 0;
            // 
            // rpn_CerrarSesion
            // 
            this.roundedPanelExtender1.SetArcoRBorde(this.rpn_CerrarSesion, 15);
            this.roundedPanelExtender1.SetArcoRPanel(this.rpn_CerrarSesion, 15);
            this.rpn_CerrarSesion.ArcRadiusBorde = 15;
            this.rpn_CerrarSesion.ArcRadiusPanel = 15;
            this.rpn_CerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.systemColorsExtender1.SetBackColorSystem(this.rpn_CerrarSesion, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanelExtender1.SetColorSistemaBorde(this.rpn_CerrarSesion, LP2MegaAutos.ColoresSistema.BackBackground);
            this.roundedPanelExtender1.SetColorSistemaPanel(this.rpn_CerrarSesion, LP2MegaAutos.ColoresSistema.LowContrast);
            this.rpn_CerrarSesion.Controls.Add(this.btn_CerrarSesion);
            this.roundedPanelExtender1.SetCorners(this.rpn_CerrarSesion, Plasmoid.Extensions.RectangleEdgeFilter.All);
            this.rpn_CerrarSesion.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpn_CerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.rpn_CerrarSesion, LP2MegaAutos.ColoresSistema.HighContrast);
            this.rpn_CerrarSesion.Location = new System.Drawing.Point(381, 382);
            this.rpn_CerrarSesion.MenosHeightBorde = 1;
            this.rpn_CerrarSesion.MenosHeightPanel = 1;
            this.rpn_CerrarSesion.MenosWidthBorde = 1;
            this.rpn_CerrarSesion.MenosWidthPanel = 1;
            this.rpn_CerrarSesion.Name = "rpn_CerrarSesion";
            this.rpn_CerrarSesion.PorcLuzColorBorde = 0;
            this.rpn_CerrarSesion.Size = new System.Drawing.Size(140, 70);
            this.rpn_CerrarSesion.TabIndex = 8;
            this.tagsExtender1.SetTag2(this.rpn_CerrarSesion, null);
            this.tagsExtender1.SetTag3(this.rpn_CerrarSesion, null);
            this.tagsExtender1.SetTagFontName(this.rpn_CerrarSesion, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpn_CerrarSesion, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpn_CerrarSesion, System.Drawing.FontStyle.Regular);
            this.rpn_CerrarSesion.XBorde = 0;
            this.rpn_CerrarSesion.XPanel = 0;
            this.rpn_CerrarSesion.YBorde = 0;
            this.rpn_CerrarSesion.YPanel = 0;
            // 
            // rpn_Ajustes
            // 
            this.roundedPanelExtender1.SetArcoRBorde(this.rpn_Ajustes, 15);
            this.roundedPanelExtender1.SetArcoRPanel(this.rpn_Ajustes, 15);
            this.rpn_Ajustes.ArcRadiusBorde = 15;
            this.rpn_Ajustes.ArcRadiusPanel = 15;
            this.rpn_Ajustes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.systemColorsExtender1.SetBackColorSystem(this.rpn_Ajustes, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanelExtender1.SetColorSistemaBorde(this.rpn_Ajustes, LP2MegaAutos.ColoresSistema.BackBackground);
            this.roundedPanelExtender1.SetColorSistemaPanel(this.rpn_Ajustes, LP2MegaAutos.ColoresSistema.LowContrast);
            this.rpn_Ajustes.Controls.Add(this.btnAjustes);
            this.roundedPanelExtender1.SetCorners(this.rpn_Ajustes, Plasmoid.Extensions.RectangleEdgeFilter.All);
            this.rpn_Ajustes.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpn_Ajustes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.rpn_Ajustes, LP2MegaAutos.ColoresSistema.HighContrast);
            this.rpn_Ajustes.Location = new System.Drawing.Point(235, 382);
            this.rpn_Ajustes.MenosHeightBorde = 1;
            this.rpn_Ajustes.MenosHeightPanel = 1;
            this.rpn_Ajustes.MenosWidthBorde = 1;
            this.rpn_Ajustes.MenosWidthPanel = 1;
            this.rpn_Ajustes.Name = "rpn_Ajustes";
            this.rpn_Ajustes.PorcLuzColorBorde = 0;
            this.rpn_Ajustes.Size = new System.Drawing.Size(140, 70);
            this.rpn_Ajustes.TabIndex = 9;
            this.tagsExtender1.SetTag2(this.rpn_Ajustes, null);
            this.tagsExtender1.SetTag3(this.rpn_Ajustes, null);
            this.tagsExtender1.SetTagFontName(this.rpn_Ajustes, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpn_Ajustes, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpn_Ajustes, System.Drawing.FontStyle.Regular);
            this.rpn_Ajustes.XBorde = 0;
            this.rpn_Ajustes.XPanel = 0;
            this.rpn_Ajustes.YBorde = 0;
            this.rpn_Ajustes.YPanel = 0;
            // 
            // rpn_ActualizarBase
            // 
            this.roundedPanelExtender1.SetArcoRBorde(this.rpn_ActualizarBase, 15);
            this.roundedPanelExtender1.SetArcoRPanel(this.rpn_ActualizarBase, 15);
            this.rpn_ActualizarBase.ArcRadiusBorde = 15;
            this.rpn_ActualizarBase.ArcRadiusPanel = 15;
            this.rpn_ActualizarBase.BackColor = System.Drawing.Color.Transparent;
            this.systemColorsExtender1.SetBackColorSystem(this.rpn_ActualizarBase, LP2MegaAutos.ColoresSistema.Transparent);
            this.roundedPanelExtender1.SetColorSistemaBorde(this.rpn_ActualizarBase, LP2MegaAutos.ColoresSistema.BackBackground);
            this.roundedPanelExtender1.SetColorSistemaPanel(this.rpn_ActualizarBase, LP2MegaAutos.ColoresSistema.LowContrast);
            this.rpn_ActualizarBase.Controls.Add(this.btn_ActualizarBD);
            this.roundedPanelExtender1.SetCorners(this.rpn_ActualizarBase, Plasmoid.Extensions.RectangleEdgeFilter.All);
            this.rpn_ActualizarBase.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rpn_ActualizarBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.rpn_ActualizarBase, LP2MegaAutos.ColoresSistema.HighContrast);
            this.rpn_ActualizarBase.Location = new System.Drawing.Point(89, 382);
            this.rpn_ActualizarBase.MenosHeightBorde = 1;
            this.rpn_ActualizarBase.MenosHeightPanel = 1;
            this.rpn_ActualizarBase.MenosWidthBorde = 1;
            this.rpn_ActualizarBase.MenosWidthPanel = 1;
            this.rpn_ActualizarBase.Name = "rpn_ActualizarBase";
            this.rpn_ActualizarBase.PorcLuzColorBorde = 0;
            this.rpn_ActualizarBase.Size = new System.Drawing.Size(140, 70);
            this.rpn_ActualizarBase.TabIndex = 6;
            this.tagsExtender1.SetTag2(this.rpn_ActualizarBase, null);
            this.tagsExtender1.SetTag3(this.rpn_ActualizarBase, null);
            this.tagsExtender1.SetTagFontName(this.rpn_ActualizarBase, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpn_ActualizarBase, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpn_ActualizarBase, System.Drawing.FontStyle.Regular);
            this.rpn_ActualizarBase.XBorde = 0;
            this.rpn_ActualizarBase.XPanel = 0;
            this.rpn_ActualizarBase.YBorde = 0;
            this.rpn_ActualizarBase.YPanel = 0;
            // 
            // btn_AreaTrabajo
            // 
            this.btn_AreaTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(33)))));
            this.systemColorsExtender1.SetBackColorSystem(this.btn_AreaTrabajo, LP2MegaAutos.ColoresSistema.PrincipalRojo);
            this.btn_AreaTrabajo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_AreaTrabajo.FlatAppearance.BorderSize = 0;
            this.btn_AreaTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AreaTrabajo.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.btn_AreaTrabajo.ForeColor = System.Drawing.Color.White;
            this.systemColorsExtender1.SetForeColorSystem(this.btn_AreaTrabajo, LP2MegaAutos.ColoresSistema.HighContrast);
            this.btn_AreaTrabajo.Location = new System.Drawing.Point(13, 3);
            this.btn_AreaTrabajo.Name = "btn_AreaTrabajo";
            this.btn_AreaTrabajo.Size = new System.Drawing.Size(115, 64);
            this.btn_AreaTrabajo.TabIndex = 1;
            this.tagsExtender1.SetTag2(this.btn_AreaTrabajo, null);
            this.tagsExtender1.SetTag3(this.btn_AreaTrabajo, null);
            this.tagsExtender1.SetTagFontName(this.btn_AreaTrabajo, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btn_AreaTrabajo, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btn_AreaTrabajo, System.Drawing.FontStyle.Regular);
            this.btn_AreaTrabajo.Text = "Areas de Trabajo";
            this.btn_AreaTrabajo.UseVisualStyleBackColor = false;
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(33)))));
            this.systemColorsExtender1.SetBackColorSystem(this.btn_Reportes, LP2MegaAutos.ColoresSistema.PrincipalRojo);
            this.btn_Reportes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Reportes.FlatAppearance.BorderSize = 0;
            this.btn_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reportes.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Reportes.ForeColor = System.Drawing.Color.White;
            this.systemColorsExtender1.SetForeColorSystem(this.btn_Reportes, LP2MegaAutos.ColoresSistema.HighContrast);
            this.btn_Reportes.Location = new System.Drawing.Point(19, 3);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(115, 64);
            this.btn_Reportes.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.btn_Reportes, null);
            this.tagsExtender1.SetTag3(this.btn_Reportes, null);
            this.tagsExtender1.SetTagFontName(this.btn_Reportes, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btn_Reportes, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btn_Reportes, System.Drawing.FontStyle.Regular);
            this.btn_Reportes.Text = "Reportes";
            this.btn_Reportes.UseVisualStyleBackColor = false;
            // 
            // btn_Servicios
            // 
            this.btn_Servicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(33)))));
            this.systemColorsExtender1.SetBackColorSystem(this.btn_Servicios, LP2MegaAutos.ColoresSistema.PrincipalRojo);
            this.btn_Servicios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Servicios.FlatAppearance.BorderSize = 0;
            this.btn_Servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Servicios.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Servicios.ForeColor = System.Drawing.Color.White;
            this.systemColorsExtender1.SetForeColorSystem(this.btn_Servicios, LP2MegaAutos.ColoresSistema.HighContrast);
            this.btn_Servicios.Location = new System.Drawing.Point(12, 3);
            this.btn_Servicios.Name = "btn_Servicios";
            this.btn_Servicios.Size = new System.Drawing.Size(120, 64);
            this.btn_Servicios.TabIndex = 3;
            this.tagsExtender1.SetTag2(this.btn_Servicios, null);
            this.tagsExtender1.SetTag3(this.btn_Servicios, null);
            this.tagsExtender1.SetTagFontName(this.btn_Servicios, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btn_Servicios, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btn_Servicios, System.Drawing.FontStyle.Regular);
            this.btn_Servicios.Text = "Servicios";
            this.btn_Servicios.UseVisualStyleBackColor = false;
            // 
            // btn_Drivers
            // 
            this.btn_Drivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(33)))));
            this.systemColorsExtender1.SetBackColorSystem(this.btn_Drivers, LP2MegaAutos.ColoresSistema.PrincipalRojo);
            this.btn_Drivers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Drivers.FlatAppearance.BorderSize = 0;
            this.btn_Drivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Drivers.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Drivers.ForeColor = System.Drawing.Color.White;
            this.systemColorsExtender1.SetForeColorSystem(this.btn_Drivers, LP2MegaAutos.ColoresSistema.HighContrast);
            this.btn_Drivers.Location = new System.Drawing.Point(13, 3);
            this.btn_Drivers.Name = "btn_Drivers";
            this.btn_Drivers.Size = new System.Drawing.Size(114, 64);
            this.btn_Drivers.TabIndex = 4;
            this.tagsExtender1.SetTag2(this.btn_Drivers, null);
            this.tagsExtender1.SetTag3(this.btn_Drivers, null);
            this.tagsExtender1.SetTagFontName(this.btn_Drivers, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btn_Drivers, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btn_Drivers, System.Drawing.FontStyle.Regular);
            this.btn_Drivers.Text = "Drivers";
            this.btn_Drivers.UseVisualStyleBackColor = false;
            // 
            // btn_Empresa
            // 
            this.btn_Empresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(226)))));
            this.systemColorsExtender1.SetBackColorSystem(this.btn_Empresa, LP2MegaAutos.ColoresSistema.Morado);
            this.btn_Empresa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Empresa.FlatAppearance.BorderSize = 0;
            this.btn_Empresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Empresa.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Empresa.ForeColor = System.Drawing.Color.White;
            this.systemColorsExtender1.SetForeColorSystem(this.btn_Empresa, LP2MegaAutos.ColoresSistema.HighContrast);
            this.btn_Empresa.Location = new System.Drawing.Point(13, 3);
            this.btn_Empresa.Name = "btn_Empresa";
            this.btn_Empresa.Size = new System.Drawing.Size(115, 64);
            this.btn_Empresa.TabIndex = 2;
            this.tagsExtender1.SetTag2(this.btn_Empresa, null);
            this.tagsExtender1.SetTag3(this.btn_Empresa, null);
            this.tagsExtender1.SetTagFontName(this.btn_Empresa, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btn_Empresa, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btn_Empresa, System.Drawing.FontStyle.Regular);
            this.btn_Empresa.Text = "Empresa";
            this.btn_Empresa.UseVisualStyleBackColor = false;
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(226)))));
            this.systemColorsExtender1.SetBackColorSystem(this.btn_Clientes, LP2MegaAutos.ColoresSistema.Morado);
            this.btn_Clientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Clientes.FlatAppearance.BorderSize = 0;
            this.btn_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clientes.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Clientes.ForeColor = System.Drawing.Color.White;
            this.systemColorsExtender1.SetForeColorSystem(this.btn_Clientes, LP2MegaAutos.ColoresSistema.HighContrast);
            this.btn_Clientes.Location = new System.Drawing.Point(19, 3);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(115, 64);
            this.btn_Clientes.TabIndex = 3;
            this.tagsExtender1.SetTag2(this.btn_Clientes, null);
            this.tagsExtender1.SetTag3(this.btn_Clientes, null);
            this.tagsExtender1.SetTagFontName(this.btn_Clientes, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btn_Clientes, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btn_Clientes, System.Drawing.FontStyle.Regular);
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = false;
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(226)))));
            this.systemColorsExtender1.SetBackColorSystem(this.btn_Usuarios, LP2MegaAutos.ColoresSistema.Morado);
            this.btn_Usuarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Usuarios.FlatAppearance.BorderSize = 0;
            this.btn_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Usuarios.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Usuarios.ForeColor = System.Drawing.Color.White;
            this.systemColorsExtender1.SetForeColorSystem(this.btn_Usuarios, LP2MegaAutos.ColoresSistema.HighContrast);
            this.btn_Usuarios.Location = new System.Drawing.Point(17, 3);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(115, 64);
            this.btn_Usuarios.TabIndex = 4;
            this.tagsExtender1.SetTag2(this.btn_Usuarios, null);
            this.tagsExtender1.SetTag3(this.btn_Usuarios, null);
            this.tagsExtender1.SetTagFontName(this.btn_Usuarios, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btn_Usuarios, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btn_Usuarios, System.Drawing.FontStyle.Regular);
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.UseVisualStyleBackColor = false;
            // 
            // btn_Sedes
            // 
            this.btn_Sedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(32)))), ((int)(((byte)(226)))));
            this.systemColorsExtender1.SetBackColorSystem(this.btn_Sedes, LP2MegaAutos.ColoresSistema.Morado);
            this.btn_Sedes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Sedes.FlatAppearance.BorderSize = 0;
            this.btn_Sedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sedes.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Sedes.ForeColor = System.Drawing.Color.White;
            this.systemColorsExtender1.SetForeColorSystem(this.btn_Sedes, LP2MegaAutos.ColoresSistema.HighContrast);
            this.btn_Sedes.Location = new System.Drawing.Point(13, 3);
            this.btn_Sedes.Name = "btn_Sedes";
            this.btn_Sedes.Size = new System.Drawing.Size(115, 64);
            this.btn_Sedes.TabIndex = 5;
            this.tagsExtender1.SetTag2(this.btn_Sedes, null);
            this.tagsExtender1.SetTag3(this.btn_Sedes, null);
            this.tagsExtender1.SetTagFontName(this.btn_Sedes, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btn_Sedes, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btn_Sedes, System.Drawing.FontStyle.Regular);
            this.btn_Sedes.Text = "Sedes";
            this.btn_Sedes.UseVisualStyleBackColor = false;
            // 
            // btn_ActualizarBD
            // 
            this.btn_ActualizarBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.systemColorsExtender1.SetBackColorSystem(this.btn_ActualizarBD, LP2MegaAutos.ColoresSistema.LowContrast);
            this.btn_ActualizarBD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ActualizarBD.FlatAppearance.BorderSize = 0;
            this.btn_ActualizarBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ActualizarBD.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ActualizarBD.ForeColor = System.Drawing.Color.White;
            this.systemColorsExtender1.SetForeColorSystem(this.btn_ActualizarBD, LP2MegaAutos.ColoresSistema.HighContrast);
            this.btn_ActualizarBD.Location = new System.Drawing.Point(13, 3);
            this.btn_ActualizarBD.Name = "btn_ActualizarBD";
            this.btn_ActualizarBD.Size = new System.Drawing.Size(115, 64);
            this.btn_ActualizarBD.TabIndex = 3;
            this.tagsExtender1.SetTag2(this.btn_ActualizarBD, null);
            this.tagsExtender1.SetTag3(this.btn_ActualizarBD, null);
            this.tagsExtender1.SetTagFontName(this.btn_ActualizarBD, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btn_ActualizarBD, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btn_ActualizarBD, System.Drawing.FontStyle.Regular);
            this.btn_ActualizarBD.Text = "Actualizar Base de Datos";
            this.btn_ActualizarBD.UseVisualStyleBackColor = false;
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.systemColorsExtender1.SetBackColorSystem(this.btnAjustes, LP2MegaAutos.ColoresSistema.LowContrast);
            this.btnAjustes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.btnAjustes.ForeColor = System.Drawing.Color.White;
            this.systemColorsExtender1.SetForeColorSystem(this.btnAjustes, LP2MegaAutos.ColoresSistema.HighContrast);
            this.btnAjustes.Location = new System.Drawing.Point(13, 3);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(115, 64);
            this.btnAjustes.TabIndex = 4;
            this.tagsExtender1.SetTag2(this.btnAjustes, null);
            this.tagsExtender1.SetTag3(this.btnAjustes, null);
            this.tagsExtender1.SetTagFontName(this.btnAjustes, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btnAjustes, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btnAjustes, System.Drawing.FontStyle.Regular);
            this.btnAjustes.Text = "Ajustes";
            this.btnAjustes.UseVisualStyleBackColor = false;
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.systemColorsExtender1.SetBackColorSystem(this.btn_CerrarSesion, LP2MegaAutos.ColoresSistema.LowContrast);
            this.btn_CerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_CerrarSesion.FlatAppearance.BorderSize = 0;
            this.btn_CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CerrarSesion.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.btn_CerrarSesion.ForeColor = System.Drawing.Color.White;
            this.systemColorsExtender1.SetForeColorSystem(this.btn_CerrarSesion, LP2MegaAutos.ColoresSistema.HighContrast);
            this.btn_CerrarSesion.Location = new System.Drawing.Point(12, 3);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(115, 64);
            this.btn_CerrarSesion.TabIndex = 5;
            this.tagsExtender1.SetTag2(this.btn_CerrarSesion, null);
            this.tagsExtender1.SetTag3(this.btn_CerrarSesion, null);
            this.tagsExtender1.SetTagFontName(this.btn_CerrarSesion, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.btn_CerrarSesion, 10F);
            this.tagsExtender1.SetTagFontStyle(this.btn_CerrarSesion, System.Drawing.FontStyle.Regular);
            this.btn_CerrarSesion.Text = "Cerrar Sesion";
            this.btn_CerrarSesion.UseVisualStyleBackColor = false;
            // 
            // roundedPanel2
            // 
            this.roundedPanelExtender1.SetArcoRBorde(this.roundedPanel2, 15);
            this.roundedPanelExtender1.SetArcoRPanel(this.roundedPanel2, 15);
            this.roundedPanel2.ArcRadiusBorde = 15;
            this.roundedPanel2.ArcRadiusPanel = 15;
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.systemColorsExtender1.SetBackColorSystem(this.roundedPanel2, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanelExtender1.SetColorSistemaBorde(this.roundedPanel2, LP2MegaAutos.ColoresSistema.BackBackground);
            this.roundedPanelExtender1.SetColorSistemaPanel(this.roundedPanel2, LP2MegaAutos.ColoresSistema.LowContrast);
            this.roundedPanelExtender1.SetCorners(this.roundedPanel2, Plasmoid.Extensions.RectangleEdgeFilter.Right);
            this.roundedPanel2.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Right;
            this.roundedPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.roundedPanel2, LP2MegaAutos.ColoresSistema.HighContrast);
            this.roundedPanel2.Location = new System.Drawing.Point(0, 382);
            this.roundedPanel2.MenosHeightBorde = 1;
            this.roundedPanel2.MenosHeightPanel = 1;
            this.roundedPanel2.MenosWidthBorde = 1;
            this.roundedPanel2.MenosWidthPanel = 1;
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.PorcLuzColorBorde = 0;
            this.roundedPanel2.Size = new System.Drawing.Size(83, 70);
            this.roundedPanel2.TabIndex = 3;
            this.tagsExtender1.SetTag2(this.roundedPanel2, null);
            this.tagsExtender1.SetTag3(this.roundedPanel2, null);
            this.tagsExtender1.SetTagFontName(this.roundedPanel2, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.roundedPanel2, 10F);
            this.tagsExtender1.SetTagFontStyle(this.roundedPanel2, System.Drawing.FontStyle.Regular);
            this.roundedPanel2.XBorde = 0;
            this.roundedPanel2.XPanel = 0;
            this.roundedPanel2.YBorde = 0;
            this.roundedPanel2.YPanel = 0;
            // 
            // roundedPanel3
            // 
            this.roundedPanelExtender1.SetArcoRBorde(this.roundedPanel3, 15);
            this.roundedPanelExtender1.SetArcoRPanel(this.roundedPanel3, 15);
            this.roundedPanel3.ArcRadiusBorde = 15;
            this.roundedPanel3.ArcRadiusPanel = 15;
            this.roundedPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.systemColorsExtender1.SetBackColorSystem(this.roundedPanel3, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.roundedPanelExtender1.SetColorSistemaBorde(this.roundedPanel3, LP2MegaAutos.ColoresSistema.BackBackground);
            this.roundedPanelExtender1.SetColorSistemaPanel(this.roundedPanel3, LP2MegaAutos.ColoresSistema.LowContrast);
            this.roundedPanelExtender1.SetCorners(this.roundedPanel3, Plasmoid.Extensions.RectangleEdgeFilter.Left);
            this.roundedPanel3.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.Left;
            this.roundedPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this.roundedPanel3, LP2MegaAutos.ColoresSistema.HighContrast);
            this.roundedPanel3.Location = new System.Drawing.Point(527, 382);
            this.roundedPanel3.MenosHeightBorde = 1;
            this.roundedPanel3.MenosHeightPanel = 1;
            this.roundedPanel3.MenosWidthBorde = 1;
            this.roundedPanel3.MenosWidthPanel = 1;
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.PorcLuzColorBorde = 0;
            this.roundedPanel3.Size = new System.Drawing.Size(84, 70);
            this.roundedPanel3.TabIndex = 4;
            this.tagsExtender1.SetTag2(this.roundedPanel3, null);
            this.tagsExtender1.SetTag3(this.roundedPanel3, null);
            this.tagsExtender1.SetTagFontName(this.roundedPanel3, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.roundedPanel3, 10F);
            this.tagsExtender1.SetTagFontStyle(this.roundedPanel3, System.Drawing.FontStyle.Regular);
            this.roundedPanel3.XBorde = 0;
            this.roundedPanel3.XPanel = 0;
            this.roundedPanel3.YBorde = 0;
            this.roundedPanel3.YPanel = 0;
            // 
            // pantallaInicioGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.systemColorsExtender1.SetBackColorSystem(this, LP2MegaAutos.ColoresSistema.FrontBackground);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.rpn_Sedes);
            this.Controls.Add(this.rpn_CerrarSesion);
            this.Controls.Add(this.rpn_Ajustes);
            this.Controls.Add(this.rpn_Drivers);
            this.Controls.Add(this.rpn_ActualizarBase);
            this.Controls.Add(this.rpn_Usuarios);
            this.Controls.Add(this.rpn_Servicios);
            this.Controls.Add(this.rpn_Clientes);
            this.Controls.Add(this.rpn_Reportes);
            this.Controls.Add(this.rpn_Empresa);
            this.Controls.Add(this.rpn_AreaTrabajo);
            this.Controls.Add(this.rpn_derGR);
            this.Controls.Add(this.rpn_izqGR);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.lblBienvenido);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.systemColorsExtender1.SetForeColorSystem(this, LP2MegaAutos.ColoresSistema.HighContrast);
            this.Name = "pantallaInicioGerente";
            this.Size = new System.Drawing.Size(611, 470);
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.roundedPanel1.ResumeLayout(false);
            this.rpn_AreaTrabajo.ResumeLayout(false);
            this.rpn_Reportes.ResumeLayout(false);
            this.rpn_Servicios.ResumeLayout(false);
            this.rpn_Drivers.ResumeLayout(false);
            this.rpn_Sedes.ResumeLayout(false);
            this.rpn_Usuarios.ResumeLayout(false);
            this.rpn_Clientes.ResumeLayout(false);
            this.rpn_Empresa.ResumeLayout(false);
            this.rpn_CerrarSesion.ResumeLayout(false);
            this.rpn_Ajustes.ResumeLayout(false);
            this.rpn_ActualizarBase.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SystemColorsExtender systemColorsExtender1;
        private TagsExtender tagsExtender1;
        private System.Windows.Forms.Label lblBienvenido;
        private RoundedPanel roundedPanel1;
        private RoundedPanelExtender roundedPanelExtender1;
        private RoundedPanel rpn_izqGR;
        private RoundedPanel rpn_derGR;
        private System.Windows.Forms.Button btn_GenerarReporte;
        private RoundedPanel rpn_AreaTrabajo;
        private System.Windows.Forms.Button btn_AreaTrabajo;
        private RoundedPanel rpn_Reportes;
        private System.Windows.Forms.Button btn_Reportes;
        private RoundedPanel rpn_Servicios;
        private System.Windows.Forms.Button btn_Servicios;
        private RoundedPanel rpn_Drivers;
        private System.Windows.Forms.Button btn_Drivers;
        private RoundedPanel rpn_Sedes;
        private System.Windows.Forms.Button btn_Sedes;
        private RoundedPanel rpn_Usuarios;
        private System.Windows.Forms.Button btn_Usuarios;
        private RoundedPanel rpn_Clientes;
        private System.Windows.Forms.Button btn_Clientes;
        private RoundedPanel rpn_Empresa;
        private System.Windows.Forms.Button btn_Empresa;
        private RoundedPanel rpn_CerrarSesion;
        private System.Windows.Forms.Button btn_CerrarSesion;
        private RoundedPanel rpn_Ajustes;
        private System.Windows.Forms.Button btnAjustes;
        private RoundedPanel rpn_ActualizarBase;
        private System.Windows.Forms.Button btn_ActualizarBD;
        private RoundedPanel roundedPanel2;
        private RoundedPanel roundedPanel3;
    }
}
