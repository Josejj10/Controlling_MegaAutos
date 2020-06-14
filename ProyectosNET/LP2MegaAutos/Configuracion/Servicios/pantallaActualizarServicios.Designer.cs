using System.Drawing;
using System.Drawing.Text;

namespace LP2MegaAutos
{
    partial class pantallaActualizarServicios
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantallaActualizarServicios));
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.tagsExtender1 = new LP2MegaAutos.TagsExtender();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.il_Servicios2 = new LP2MegaAutos.itemLista();
            this.il_Servicios1 = new LP2MegaAutos.itemLista();
            this.il_Servicios3 = new LP2MegaAutos.itemLista();
            this.itemLista1 = new LP2MegaAutos.itemLista();
            this.roundedPanel4 = new LP2MegaAutos.RoundedPanel();
            this.rpn_ListaServicios = new LP2MegaAutos.RoundedPanel();
            this.lbl_ListaServicios = new System.Windows.Forms.Label();
            this.cTxt_MasFiltros = new LP2MegaAutos.CustomControls.ClickableText();
            this.cmbFiltrarTipoServicio = new System.Windows.Forms.ComboBox();
            this.rndReciente = new LP2MegaAutos.RoundedPanel();
            this.btnReciente = new System.Windows.Forms.Button();
            this.rndAntiguo = new LP2MegaAutos.RoundedPanel();
            this.btnAntiguo = new System.Windows.Forms.Button();
            this.rndZA = new LP2MegaAutos.RoundedPanel();
            this.btnZA = new System.Windows.Forms.Button();
            this.rndAZ = new LP2MegaAutos.RoundedPanel();
            this.btnAZ = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.pnlBuscar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.rpn_ListaServicios.SuspendLayout();
            this.rndReciente.SuspendLayout();
            this.rndAntiguo.SuspendLayout();
            this.rndZA.SuspendLayout();
            this.rndAZ.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txt_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Buscar.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.txt_Buscar.Location = new System.Drawing.Point(37, 6);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(515, 18);
            this.txt_Buscar.TabIndex = 17;
            this.tagsExtender1.SetTag2(this.txt_Buscar, null);
            this.tagsExtender1.SetTag3(this.txt_Buscar, null);
            this.tagsExtender1.SetTagFontName(this.txt_Buscar, fontsD.Lato);
            this.tagsExtender1.SetTagFontSize(this.txt_Buscar, 11F);
            this.tagsExtender1.SetTagFontStyle(this.txt_Buscar, System.Drawing.FontStyle.Bold);
            this.txt_Buscar.Text = "Buscar";
            this.txt_Buscar.Enter += new System.EventHandler(this.txt_Buscar_Enter);
            this.txt_Buscar.Leave += new System.EventHandler(this.txt_Buscar_Leave);
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.pnlBuscar.Controls.Add(this.panel2);
            this.pnlBuscar.Controls.Add(this.txt_Buscar);
            this.pnlBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuscar.Location = new System.Drawing.Point(0, 0);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(751, 30);
            this.pnlBuscar.TabIndex = 27;
            this.tagsExtender1.SetTag2(this.pnlBuscar, null);
            this.tagsExtender1.SetTag3(this.pnlBuscar, null);
            this.tagsExtender1.SetTagFontName(this.pnlBuscar, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.pnlBuscar, 10F);
            this.tagsExtender1.SetTagFontStyle(this.pnlBuscar, System.Drawing.FontStyle.Regular);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(6, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 25);
            this.panel2.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.panel2, null);
            this.tagsExtender1.SetTag3(this.panel2, null);
            this.tagsExtender1.SetTagFontName(this.panel2, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.panel2, 10F);
            this.tagsExtender1.SetTagFontStyle(this.panel2, System.Drawing.FontStyle.Regular);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.roundedPanel4);
            this.panel3.Controls.Add(this.rpn_ListaServicios);
            this.panel3.Location = new System.Drawing.Point(171, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(566, 438);
            this.panel3.TabIndex = 50;
            this.tagsExtender1.SetTag2(this.panel3, null);
            this.tagsExtender1.SetTag3(this.panel3, null);
            this.tagsExtender1.SetTagFontName(this.panel3, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.panel3, 10F);
            this.tagsExtender1.SetTagFontStyle(this.panel3, System.Drawing.FontStyle.Regular);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.flowLayoutPanel1.Controls.Add(this.il_Servicios2);
            this.flowLayoutPanel1.Controls.Add(this.il_Servicios1);
            this.flowLayoutPanel1.Controls.Add(this.il_Servicios3);
            this.flowLayoutPanel1.Controls.Add(this.itemLista1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(566, 395);
            this.flowLayoutPanel1.TabIndex = 54;
            this.tagsExtender1.SetTag2(this.flowLayoutPanel1, null);
            this.tagsExtender1.SetTag3(this.flowLayoutPanel1, null);
            this.tagsExtender1.SetTagFontName(this.flowLayoutPanel1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.flowLayoutPanel1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.flowLayoutPanel1, System.Drawing.FontStyle.Regular);
            // 
            // il_Servicios2
            // 
            this.il_Servicios2.ColorBack = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.il_Servicios2.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.il_Servicios2.ColorPanel = System.Drawing.Color.White;
            this.il_Servicios2.Location = new System.Drawing.Point(35, 4);
            this.il_Servicios2.Margin = new System.Windows.Forms.Padding(4);
            this.il_Servicios2.Name = "il_Servicios2";
            this.il_Servicios2.Size = new System.Drawing.Size(497, 104);
            this.il_Servicios2.TabIndex = 55;
            this.tagsExtender1.SetTag2(this.il_Servicios2, null);
            this.tagsExtender1.SetTag3(this.il_Servicios2, null);
            this.tagsExtender1.SetTagFontName(this.il_Servicios2, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.il_Servicios2, 10F);
            this.tagsExtender1.SetTagFontStyle(this.il_Servicios2, System.Drawing.FontStyle.Regular);
            this.il_Servicios2.TextoAgregadoPor = "Percy Jackson";
            this.il_Servicios2.TextoFecha = "dd - mm - aaaa";
            this.il_Servicios2.TextoPrincipal = "Pintura en horno";
            this.il_Servicios2.Textosecundario = "Pintura";
            this.il_Servicios2.TextoTercero = "PIN-002";
            // 
            // il_Servicios1
            // 
            this.il_Servicios1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.il_Servicios1.ColorBack = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.il_Servicios1.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.il_Servicios1.ColorPanel = System.Drawing.Color.White;
            this.il_Servicios1.Location = new System.Drawing.Point(35, 116);
            this.il_Servicios1.Margin = new System.Windows.Forms.Padding(4);
            this.il_Servicios1.Name = "il_Servicios1";
            this.il_Servicios1.Size = new System.Drawing.Size(497, 104);
            this.il_Servicios1.TabIndex = 54;
            this.tagsExtender1.SetTag2(this.il_Servicios1, null);
            this.tagsExtender1.SetTag3(this.il_Servicios1, null);
            this.tagsExtender1.SetTagFontName(this.il_Servicios1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.il_Servicios1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.il_Servicios1, System.Drawing.FontStyle.Regular);
            this.il_Servicios1.TextoAgregadoPor = "Percy Jackson";
            this.il_Servicios1.TextoFecha = "dd - mm - aaaa";
            this.il_Servicios1.TextoPrincipal = "Mantenimiento Preventivo";
            this.il_Servicios1.Textosecundario = "Mecánica a Domicilio";
            this.il_Servicios1.TextoTercero = "MEC-001";
            // 
            // il_Servicios3
            // 
            this.il_Servicios3.ColorBack = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.il_Servicios3.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.il_Servicios3.ColorPanel = System.Drawing.Color.White;
            this.il_Servicios3.Location = new System.Drawing.Point(35, 228);
            this.il_Servicios3.Margin = new System.Windows.Forms.Padding(4);
            this.il_Servicios3.Name = "il_Servicios3";
            this.il_Servicios3.Size = new System.Drawing.Size(497, 104);
            this.il_Servicios3.TabIndex = 56;
            this.tagsExtender1.SetTag2(this.il_Servicios3, null);
            this.tagsExtender1.SetTag3(this.il_Servicios3, null);
            this.tagsExtender1.SetTagFontName(this.il_Servicios3, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.il_Servicios3, 10F);
            this.tagsExtender1.SetTagFontStyle(this.il_Servicios3, System.Drawing.FontStyle.Regular);
            this.il_Servicios3.TextoAgregadoPor = "Percy Jackson";
            this.il_Servicios3.TextoFecha = "dd - mm - aaaa";
            this.il_Servicios3.TextoPrincipal = "Mecánica a domicilio";
            this.il_Servicios3.Textosecundario = "Mecánica en Taller";
            this.il_Servicios3.TextoTercero = "MEC-002";
            // 
            // itemLista1
            // 
            this.itemLista1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.itemLista1.ColorBack = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.itemLista1.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(209)))));
            this.itemLista1.ColorPanel = System.Drawing.Color.White;
            this.itemLista1.Location = new System.Drawing.Point(35, 340);
            this.itemLista1.Margin = new System.Windows.Forms.Padding(4);
            this.itemLista1.Name = "itemLista1";
            this.itemLista1.Size = new System.Drawing.Size(497, 104);
            this.itemLista1.TabIndex = 57;
            this.tagsExtender1.SetTag2(this.itemLista1, null);
            this.tagsExtender1.SetTag3(this.itemLista1, null);
            this.tagsExtender1.SetTagFontName(this.itemLista1, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.itemLista1, 10F);
            this.tagsExtender1.SetTagFontStyle(this.itemLista1, System.Drawing.FontStyle.Regular);
            this.itemLista1.TextoAgregadoPor = "Percy Jackson";
            this.itemLista1.TextoFecha = "dd - mm - aaaa";
            this.itemLista1.TextoPrincipal = "Mantenimiento Preventivo";
            this.itemLista1.Textosecundario = "Mecánica";
            this.itemLista1.TextoTercero = "MEC-001";
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.ArcRadiusBorde = 5;
            this.roundedPanel4.ArcRadiusPanel = 5;
            this.roundedPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.roundedPanel4.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.roundedPanel4.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.roundedPanel4.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.None;
            this.roundedPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roundedPanel4.Location = new System.Drawing.Point(0, 422);
            this.roundedPanel4.MenosHeightBorde = 1;
            this.roundedPanel4.MenosHeightPanel = 1;
            this.roundedPanel4.MenosWidthBorde = 1;
            this.roundedPanel4.MenosWidthPanel = 1;
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.PorcLuzColorBorde = 0;
            this.roundedPanel4.Size = new System.Drawing.Size(566, 16);
            this.roundedPanel4.TabIndex = 53;
            this.tagsExtender1.SetTag2(this.roundedPanel4, null);
            this.tagsExtender1.SetTag3(this.roundedPanel4, null);
            this.tagsExtender1.SetTagFontName(this.roundedPanel4, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.roundedPanel4, 10F);
            this.tagsExtender1.SetTagFontStyle(this.roundedPanel4, System.Drawing.FontStyle.Regular);
            this.roundedPanel4.XBorde = 0;
            this.roundedPanel4.XPanel = 0;
            this.roundedPanel4.YBorde = 0;
            this.roundedPanel4.YPanel = 0;
            // 
            // rpn_ListaServicios
            // 
            this.rpn_ListaServicios.ArcRadiusBorde = 15;
            this.rpn_ListaServicios.ArcRadiusPanel = 15;
            this.rpn_ListaServicios.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rpn_ListaServicios.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.rpn_ListaServicios.Controls.Add(this.lbl_ListaServicios);
            this.rpn_ListaServicios.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.None;
            this.rpn_ListaServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.rpn_ListaServicios.Location = new System.Drawing.Point(0, 0);
            this.rpn_ListaServicios.MenosHeightBorde = 1;
            this.rpn_ListaServicios.MenosHeightPanel = 1;
            this.rpn_ListaServicios.MenosWidthBorde = 1;
            this.rpn_ListaServicios.MenosWidthPanel = 1;
            this.rpn_ListaServicios.Name = "rpn_ListaServicios";
            this.rpn_ListaServicios.PorcLuzColorBorde = 0;
            this.rpn_ListaServicios.Size = new System.Drawing.Size(566, 27);
            this.rpn_ListaServicios.TabIndex = 51;
            this.tagsExtender1.SetTag2(this.rpn_ListaServicios, null);
            this.tagsExtender1.SetTag3(this.rpn_ListaServicios, null);
            this.tagsExtender1.SetTagFontName(this.rpn_ListaServicios, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rpn_ListaServicios, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rpn_ListaServicios, System.Drawing.FontStyle.Regular);
            this.rpn_ListaServicios.XBorde = 0;
            this.rpn_ListaServicios.XPanel = 0;
            this.rpn_ListaServicios.YBorde = 0;
            this.rpn_ListaServicios.YPanel = 0;
            // 
            // lbl_ListaServicios
            // 
            this.lbl_ListaServicios.AutoSize = true;
            this.lbl_ListaServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.lbl_ListaServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ListaServicios.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListaServicios.ForeColor = System.Drawing.Color.White;
            this.lbl_ListaServicios.Location = new System.Drawing.Point(229, 2);
            this.lbl_ListaServicios.Name = "lbl_ListaServicios";
            this.lbl_ListaServicios.Size = new System.Drawing.Size(84, 22);
            this.lbl_ListaServicios.TabIndex = 0;
            this.tagsExtender1.SetTag2(this.lbl_ListaServicios, null);
            this.tagsExtender1.SetTag3(this.lbl_ListaServicios, null);
            this.tagsExtender1.SetTagFontName(this.lbl_ListaServicios, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.lbl_ListaServicios, 12F);
            this.tagsExtender1.SetTagFontStyle(this.lbl_ListaServicios, System.Drawing.FontStyle.Bold);
            this.lbl_ListaServicios.Text = "Servicios";
            this.lbl_ListaServicios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cTxt_MasFiltros
            // 
            this.cTxt_MasFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cTxt_MasFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cTxt_MasFiltros.Font = new System.Drawing.Font("Montserrat", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTxt_MasFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.cTxt_MasFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cTxt_MasFiltros.Location = new System.Drawing.Point(23, 272);
            this.cTxt_MasFiltros.Name = "cTxt_MasFiltros";
            this.cTxt_MasFiltros.Size = new System.Drawing.Size(97, 21);
            this.cTxt_MasFiltros.TabIndex = 51;
            this.tagsExtender1.SetTag2(this.cTxt_MasFiltros, null);
            this.tagsExtender1.SetTag3(this.cTxt_MasFiltros, null);
            this.tagsExtender1.SetTagFontName(this.cTxt_MasFiltros, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.cTxt_MasFiltros, 11F);
            this.tagsExtender1.SetTagFontStyle(this.cTxt_MasFiltros, System.Drawing.FontStyle.Bold);
            this.cTxt_MasFiltros.Text = "Más Filtros";
            this.cTxt_MasFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbFiltrarTipoServicio
            // 
            this.cmbFiltrarTipoServicio.FormattingEnabled = true;
            this.cmbFiltrarTipoServicio.Location = new System.Drawing.Point(26, 315);
            this.cmbFiltrarTipoServicio.Name = "cmbFiltrarTipoServicio";
            this.cmbFiltrarTipoServicio.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltrarTipoServicio.TabIndex = 52;
            this.tagsExtender1.SetTag2(this.cmbFiltrarTipoServicio, null);
            this.tagsExtender1.SetTag3(this.cmbFiltrarTipoServicio, null);
            this.tagsExtender1.SetTagFontName(this.cmbFiltrarTipoServicio, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.cmbFiltrarTipoServicio, 10F);
            this.tagsExtender1.SetTagFontStyle(this.cmbFiltrarTipoServicio, System.Drawing.FontStyle.Regular);
            // 
            // rndReciente
            // 
            this.rndReciente.ArcRadiusBorde = 8;
            this.rndReciente.ArcRadiusPanel = 8;
            this.rndReciente.BackColor = System.Drawing.Color.Transparent;
            this.rndReciente.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rndReciente.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.rndReciente.Controls.Add(this.btnReciente);
            this.rndReciente.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndReciente.Location = new System.Drawing.Point(26, 227);
            this.rndReciente.MenosHeightBorde = 1;
            this.rndReciente.MenosHeightPanel = 1;
            this.rndReciente.MenosWidthBorde = 1;
            this.rndReciente.MenosWidthPanel = 1;
            this.rndReciente.Name = "rndReciente";
            this.rndReciente.PorcLuzColorBorde = 0;
            this.rndReciente.Size = new System.Drawing.Size(130, 35);
            this.rndReciente.TabIndex = 74;
            this.tagsExtender1.SetTag2(this.rndReciente, null);
            this.tagsExtender1.SetTag3(this.rndReciente, null);
            this.tagsExtender1.SetTagFontName(this.rndReciente, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rndReciente, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rndReciente, System.Drawing.FontStyle.Regular);
            this.rndReciente.XBorde = 0;
            this.rndReciente.XPanel = 0;
            this.rndReciente.YBorde = 0;
            this.rndReciente.YPanel = 0;
            // 
            // btnReciente
            // 
            this.btnReciente.BackColor = System.Drawing.Color.Transparent;
            this.btnReciente.FlatAppearance.BorderSize = 0;
            this.btnReciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReciente.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnReciente.Image = ((System.Drawing.Image)(resources.GetObject("btnReciente.Image")));
            this.btnReciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReciente.Location = new System.Drawing.Point(3, 3);
            this.btnReciente.Name = "btnReciente";
            this.btnReciente.Size = new System.Drawing.Size(124, 29);
            this.btnReciente.TabIndex = 8;
            this.tagsExtender1.SetTag2(this.btnReciente, null);
            this.tagsExtender1.SetTag3(this.btnReciente, null);
            this.tagsExtender1.SetTagFontName(this.btnReciente, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btnReciente, 12F);
            this.tagsExtender1.SetTagFontStyle(this.btnReciente, System.Drawing.FontStyle.Bold);
            this.btnReciente.Text = "Reciente";
            this.btnReciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReciente.UseVisualStyleBackColor = false;
            // 
            // rndAntiguo
            // 
            this.rndAntiguo.ArcRadiusBorde = 8;
            this.rndAntiguo.ArcRadiusPanel = 8;
            this.rndAntiguo.BackColor = System.Drawing.Color.Transparent;
            this.rndAntiguo.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rndAntiguo.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.rndAntiguo.Controls.Add(this.btnAntiguo);
            this.rndAntiguo.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndAntiguo.Location = new System.Drawing.Point(26, 181);
            this.rndAntiguo.MenosHeightBorde = 1;
            this.rndAntiguo.MenosHeightPanel = 1;
            this.rndAntiguo.MenosWidthBorde = 1;
            this.rndAntiguo.MenosWidthPanel = 1;
            this.rndAntiguo.Name = "rndAntiguo";
            this.rndAntiguo.PorcLuzColorBorde = 0;
            this.rndAntiguo.Size = new System.Drawing.Size(130, 35);
            this.rndAntiguo.TabIndex = 73;
            this.tagsExtender1.SetTag2(this.rndAntiguo, null);
            this.tagsExtender1.SetTag3(this.rndAntiguo, null);
            this.tagsExtender1.SetTagFontName(this.rndAntiguo, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rndAntiguo, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rndAntiguo, System.Drawing.FontStyle.Regular);
            this.rndAntiguo.XBorde = 0;
            this.rndAntiguo.XPanel = 0;
            this.rndAntiguo.YBorde = 0;
            this.rndAntiguo.YPanel = 0;
            // 
            // btnAntiguo
            // 
            this.btnAntiguo.BackColor = System.Drawing.Color.Transparent;
            this.btnAntiguo.FlatAppearance.BorderSize = 0;
            this.btnAntiguo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAntiguo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAntiguo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAntiguo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAntiguo.Image = ((System.Drawing.Image)(resources.GetObject("btnAntiguo.Image")));
            this.btnAntiguo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAntiguo.Location = new System.Drawing.Point(3, 3);
            this.btnAntiguo.Name = "btnAntiguo";
            this.btnAntiguo.Size = new System.Drawing.Size(124, 29);
            this.btnAntiguo.TabIndex = 7;
            this.tagsExtender1.SetTag2(this.btnAntiguo, null);
            this.tagsExtender1.SetTag3(this.btnAntiguo, null);
            this.tagsExtender1.SetTagFontName(this.btnAntiguo, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btnAntiguo, 12F);
            this.tagsExtender1.SetTagFontStyle(this.btnAntiguo, System.Drawing.FontStyle.Bold);
            this.btnAntiguo.Text = "Antiguo";
            this.btnAntiguo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAntiguo.UseVisualStyleBackColor = false;
            // 
            // rndZA
            // 
            this.rndZA.ArcRadiusBorde = 8;
            this.rndZA.ArcRadiusPanel = 8;
            this.rndZA.BackColor = System.Drawing.Color.Transparent;
            this.rndZA.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rndZA.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.rndZA.Controls.Add(this.btnZA);
            this.rndZA.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndZA.Location = new System.Drawing.Point(26, 135);
            this.rndZA.MenosHeightBorde = 1;
            this.rndZA.MenosHeightPanel = 1;
            this.rndZA.MenosWidthBorde = 1;
            this.rndZA.MenosWidthPanel = 1;
            this.rndZA.Name = "rndZA";
            this.rndZA.PorcLuzColorBorde = 0;
            this.rndZA.Size = new System.Drawing.Size(130, 35);
            this.rndZA.TabIndex = 72;
            this.tagsExtender1.SetTag2(this.rndZA, null);
            this.tagsExtender1.SetTag3(this.rndZA, null);
            this.tagsExtender1.SetTagFontName(this.rndZA, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rndZA, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rndZA, System.Drawing.FontStyle.Regular);
            this.rndZA.XBorde = 0;
            this.rndZA.XPanel = 0;
            this.rndZA.YBorde = 0;
            this.rndZA.YPanel = 0;
            // 
            // btnZA
            // 
            this.btnZA.BackColor = System.Drawing.Color.Transparent;
            this.btnZA.FlatAppearance.BorderSize = 0;
            this.btnZA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnZA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZA.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnZA.Image = ((System.Drawing.Image)(resources.GetObject("btnZA.Image")));
            this.btnZA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZA.Location = new System.Drawing.Point(3, 3);
            this.btnZA.Name = "btnZA";
            this.btnZA.Size = new System.Drawing.Size(124, 29);
            this.btnZA.TabIndex = 6;
            this.tagsExtender1.SetTag2(this.btnZA, null);
            this.tagsExtender1.SetTag3(this.btnZA, null);
            this.tagsExtender1.SetTagFontName(this.btnZA, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btnZA, 12F);
            this.tagsExtender1.SetTagFontStyle(this.btnZA, System.Drawing.FontStyle.Bold);
            this.btnZA.Text = "Z - A";
            this.btnZA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZA.UseVisualStyleBackColor = false;
            // 
            // rndAZ
            // 
            this.rndAZ.ArcRadiusBorde = 8;
            this.rndAZ.ArcRadiusPanel = 8;
            this.rndAZ.BackColor = System.Drawing.Color.Transparent;
            this.rndAZ.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rndAZ.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.rndAZ.Controls.Add(this.btnAZ);
            this.rndAZ.CornersRound = Plasmoid.Extensions.RectangleEdgeFilter.All;
            this.rndAZ.Location = new System.Drawing.Point(26, 89);
            this.rndAZ.MenosHeightBorde = 1;
            this.rndAZ.MenosHeightPanel = 1;
            this.rndAZ.MenosWidthBorde = 1;
            this.rndAZ.MenosWidthPanel = 1;
            this.rndAZ.Name = "rndAZ";
            this.rndAZ.PorcLuzColorBorde = 0;
            this.rndAZ.Size = new System.Drawing.Size(130, 35);
            this.rndAZ.TabIndex = 71;
            this.tagsExtender1.SetTag2(this.rndAZ, null);
            this.tagsExtender1.SetTag3(this.rndAZ, null);
            this.tagsExtender1.SetTagFontName(this.rndAZ, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this.rndAZ, 10F);
            this.tagsExtender1.SetTagFontStyle(this.rndAZ, System.Drawing.FontStyle.Regular);
            this.rndAZ.XBorde = 0;
            this.rndAZ.XPanel = 0;
            this.rndAZ.YBorde = 0;
            this.rndAZ.YPanel = 0;
            // 
            // btnAZ
            // 
            this.btnAZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.btnAZ.FlatAppearance.BorderSize = 0;
            this.btnAZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAZ.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAZ.Image = ((System.Drawing.Image)(resources.GetObject("btnAZ.Image")));
            this.btnAZ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAZ.Location = new System.Drawing.Point(3, 3);
            this.btnAZ.Name = "btnAZ";
            this.btnAZ.Size = new System.Drawing.Size(124, 29);
            this.btnAZ.TabIndex = 5;
            this.tagsExtender1.SetTag2(this.btnAZ, null);
            this.tagsExtender1.SetTag3(this.btnAZ, null);
            this.tagsExtender1.SetTagFontName(this.btnAZ, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btnAZ, 12F);
            this.tagsExtender1.SetTagFontStyle(this.btnAZ, System.Drawing.FontStyle.Bold);
            this.btnAZ.Text = "A - Z";
            this.btnAZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAZ.UseVisualStyleBackColor = false;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.AutoSize = true;
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Agregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.btn_Agregar.Location = new System.Drawing.Point(27, 46);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(96, 31);
            this.btn_Agregar.TabIndex = 75;
            this.tagsExtender1.SetTag2(this.btn_Agregar, null);
            this.tagsExtender1.SetTag3(this.btn_Agregar, null);
            this.tagsExtender1.SetTagFontName(this.btn_Agregar, fontsD.Montserrat);
            this.tagsExtender1.SetTagFontSize(this.btn_Agregar, 11F);
            this.tagsExtender1.SetTagFontStyle(this.btn_Agregar, System.Drawing.FontStyle.Bold);
            this.btn_Agregar.Text = "+ Agregar";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btnAgregarClick);
            // 
            // pantallaActualizarServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.rndReciente);
            this.Controls.Add(this.rndAntiguo);
            this.Controls.Add(this.rndZA);
            this.Controls.Add(this.rndAZ);
            this.Controls.Add(this.cmbFiltrarTipoServicio);
            this.Controls.Add(this.cTxt_MasFiltros);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "pantallaActualizarServicios";
            this.Size = new System.Drawing.Size(751, 520);
            this.tagsExtender1.SetTag2(this, null);
            this.tagsExtender1.SetTag3(this, null);
            this.tagsExtender1.SetTagFontName(this, fontsD.Ninguno);
            this.tagsExtender1.SetTagFontSize(this, 10F);
            this.tagsExtender1.SetTagFontStyle(this, System.Drawing.FontStyle.Regular);
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.rpn_ListaServicios.ResumeLayout(false);
            this.rpn_ListaServicios.PerformLayout();
            this.rndReciente.ResumeLayout(false);
            this.rndAntiguo.ResumeLayout(false);
            this.rndZA.ResumeLayout(false);
            this.rndAZ.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Buscar;
        private TagsExtender tagsExtender1;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private RoundedPanel roundedPanel4;
        private RoundedPanel rpn_ListaServicios;
        private System.Windows.Forms.Label lbl_ListaServicios;
        private CustomControls.ClickableText cTxt_MasFiltros;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private itemLista il_Servicios1;
        private itemLista il_Servicios3;
        private itemLista il_Servicios2;
        private itemLista itemLista1;
        private System.Windows.Forms.ComboBox cmbFiltrarTipoServicio;
        private RoundedPanel rndReciente;
        private System.Windows.Forms.Button btnReciente;
        private RoundedPanel rndAntiguo;
        private System.Windows.Forms.Button btnAntiguo;
        private RoundedPanel rndZA;
        private System.Windows.Forms.Button btnZA;
        private RoundedPanel rndAZ;
        private System.Windows.Forms.Button btnAZ;
        private System.Windows.Forms.Button btn_Agregar;
    }
}
