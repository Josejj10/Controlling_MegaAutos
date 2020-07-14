using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2MegaAutos.VentanasPrincipales;
using MetroFramework.Forms;
using MetroFramework;
using Plasmoid.Extensions;
using System.Threading;
using LP2MegaAutos.Framework.UserControls;
using System.IO;
using LP2MegaAutos.Properties;
using LP2MegaAutos.ServicioUsuario;
using LP2MegaAutos.Configuracion.Empresa;
using LP2MegaAutos.ServicioEmpresa;

namespace LP2MegaAutos
{
    public partial class frmPrincipal : MetroForm
    {

        private static usuario _usuario;
        ServicioEmpresa.EmpresaWSClient daoEmpresa;
        empresa _empresa;

        #region Getters y Setters
        public static usuario Usuario { get => _usuario; set => _usuario = value; }

        private Button getBotonPanel(string nom, Control cont)
        {
            foreach (Control c in cont.Controls)
            {
                if (c.Controls != null)
                    if (getBotonPanel(nom, c) != null)
                        return getBotonPanel(nom, c);
                if (c.Name == nom)
                {
                    return (Button)c;
                }
            }
            return null;
        }

        public Button getBotonPanelMenuString(string nom)
        {
            return getBotonPanel(nom, panelMenu);
        }
        public ContenedorPantalla ContenedorPantallas
        {
            get { return contenedorPantalla1; }
        }

        public Panel PanelMenu
        {
            get { return panelMenu; }
        }
        #endregion Getters y Setters

        #region title_bar

        #region botones
        private void boton_cerrar_MouseClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void boton_minimizar_MouseClick(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Minimized;
        }
        #endregion botones

        #region movement
        // Llama a la clase estatica TitleBar
        private void title_bar_MouseUp(object sender, MouseEventArgs e)
        {
            TitleBar.mouse_Up();
        }

        private void title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            TitleBar.mouse_Down(MousePosition, Bounds);
        }

        private void title_bar_MouseMove(object sender, MouseEventArgs e)
        {
            TitleBar.mouse_Move(MousePosition, this);
        }


        #endregion movement

        #endregion title_bar

        #region Dark Mode
        // Usa la clase DarkMode para cambiar los colores iterando
        // Y mover el toggle mediante ticks del timer reloj_dark
        private void boton_toggle_nocturno_Click(object sender, EventArgs e)
        {
            DarkMode.cambiarDarkMode(panel_toggle_nocturno, boton_toggle_nocturno, reloj_dark, this);
        }

        private void reloj_dark_Tick(object sender, EventArgs e)
        {
            DarkMode.reloj_dark_Tick(reloj_dark, boton_toggle_nocturno);
        }




        #endregion Dark Mode

        #region inicializacion
        #region constructor
        public frmPrincipal(usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            inicializarUsuario();

            Tipografias.crearFonts(this, tags); // Inicializa los fonts de este form

            inicializarPms();
            if (DarkMode.is_dark_mode_active())
                DarkMode.iniciarDarkMode(panel_toggle_nocturno, boton_toggle_nocturno, reloj_dark, this);
            contenedorPantalla1.PInicial = new pantallaInicio(_usuario);
            suscribirEventos();
        }


        private void inicializarUsuario()
        {
            List<ePermisos?> uPer;
            if (_usuario.permisos == null)
            {
                uPer = new List<ePermisos?>();
                _usuario.permisos = uPer.ToArray();
                //return;
            }
            uPer= _usuario.permisos.ToList();
            uPer.Add(ePermisos.All);
            uPer.Add(ePermisos.Sedes);
            _usuario.permisos = uPer.ToArray();

            foreach (ePermisos p in _usuario.permisos)
            {
                Console.WriteLine(p.ToString());
            }   
        }

        private void inicializarPms()
        {
            crearBotonesInicio();
            pmsReportes.Imagen1 = (Image)new Bitmap(Resources.Reporte, 36, 36);
            pmsReportes.Imagen2 = (Image)new Bitmap(Resources.AreaTrabajo, 36, 36);
            pmsReportes.Imagen3 = (Image)new Bitmap(Resources.Clientes, 36, 36);
            pmsReportes.Imagen4 = (Image)new Bitmap(Resources.Vehiculo, 36, 36);

            pmsReportes.Texto1 = "Todos";
            pmsReportes.Texto2 = "Por" + Environment.NewLine +"Area" ;
            pmsReportes.Texto3 = "Por" + Environment.NewLine +"Cliente";
            pmsReportes.Texto4 = "Por"+Environment.NewLine+ "Siniestro";

            pmsUltimoReporte.NumItems = 3;
            pmsUltimoReporte.Imagen1 = (Image)new Bitmap(Resources.Estadisticas, 36, 36);
            pmsUltimoReporte.Imagen2 = (Image)new Bitmap(Resources.ReporteDetalle, 36, 36);
            pmsUltimoReporte.Imagen3 = (Image)new Bitmap(Resources.ReporteResumen, 36, 36);

            pmsUltimoReporte.Texto1 = "Resum.";
            pmsUltimoReporte.Texto2 = "Detalle";
            pmsUltimoReporte.Texto3 = "Estad.";


            pmsReportes.LayoutImagenes = pmsUltimoReporte.LayoutImagenes = ImageLayout.Center;

            btnMenuUltimoReporte.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            BotonesDinamicosHelper.cambiarColoresBotonesMenu(rpBtnMenuHome, panelMenu);
        }

        private void suscribirEventos()
        {
            // Eventos de los paneles estaticos (no dinamicos) del Menu
            rpBtnMenuReportes.MouseEnter += (sender, e) => { rpBtnMenu_MouseEnter(sender, e, pmsReportes); };
            btnMenuReportes.MouseEnter += (sender, e) => { rpBtnMenu_MouseEnter(sender, e, pmsReportes); };
            rpBtnMenuReportes.MouseLeave += (sender, e) => { rpBtnMenu_MouseLeave(sender, e, pmsReportes); };
            rpBtnMenuUltimoReporte.MouseEnter += (sender, e) => { rpBtnMenu_MouseEnter(sender, e, pmsUltimoReporte); };
            btnMenuUltimoReporte.MouseEnter += (sender, e) => { rpBtnMenu_MouseEnter(sender, e, pmsUltimoReporte); };
            rpBtnMenuUltimoReporte.MouseLeave += (sender, e) => { rpBtnMenu_MouseLeave(sender, e, pmsUltimoReporte); };
            ((pantallaInicio)contenedorPantalla1.PInicial).CreditosClick += verCreditos;
            ((pantallaInicio)contenedorPantalla1.PInicial).ActualizarEmpresaClick += btnMenuActualizarEmpresa_Click;
            ((pantallaInicio)contenedorPantalla1.PInicial).VerUltimoReporteClick+= btnMenuUltimoReporte_Click;
            ((pantallaInicio)contenedorPantalla1.PInicial).perfilUsuarioClick += btnMenuUsuario_Click;
            // TODO Cambios
            ((pantallaInicio)contenedorPantalla1.PInicial).ListaReportesClick += (sender, e) => pmsReportes_ListaReportesClick(sender, e);
            ((pantallaInicio)contenedorPantalla1.PInicial).ReporteAreaTrabajoClick += (sender, e) => pmsReportes_ListaReportesClick(sender, e,"AT");
            ((pantallaInicio)contenedorPantalla1.PInicial).ReporteClienteClick += (sender, e) => pmsReportes_ListaReportesClick(sender, e,"Cliente");
            ((pantallaInicio)contenedorPantalla1.PInicial).ReporteSiniestroClick += (sender, e) => pmsReportes_ListaReportesClick(sender, e,"Siniestro");
        }
        #endregion constructor
        #region Creacion Botones


        private void crearBotonesInicio()
        {
            // Trabajar con flags el menu
            // Inicializarlo en 000
            // Flag 001 es BD
            // Flag 010 es Config
            // Flag 100 es info
            int menu = 0;
            int nItemsInfo = 0;
            int nItemsConfig = 0;
            
            // Recibir los parametros del usuario enviando variables por referencia
            BotonesDinamicosHelper.recibirParametros(_usuario.permisos.ToList<ePermisos?>(), ref menu, ref nItemsInfo, ref nItemsConfig);

            // Crear los botones segun los flags de menu
            bool estaBtnInformacion = false;
            bool estaBtnConfiguracion = false;

            if ((menu & 4) == 4)
            {
                // Crear boton de Información
                crearBotonInformacion(nItemsInfo);
                estaBtnInformacion = true;
            }

            if ((menu & 2) == 2)
            {
                // Crear boton de Configuración
                crearBotonConfiguracion(estaBtnInformacion, nItemsConfig);
                estaBtnConfiguracion = true;
            }
            if ((menu & 1) == 1)
            {
                // Crear boton de BD
                crearBotonBD(estaBtnInformacion, estaBtnConfiguracion);
            }

        }

        // Crear el boton del menu (info, config, BD)
        private void crearRPMenu(RoundedPanel rpBtn, string nombre, int yLocation)
        {
            panelMenu.Controls.Add(rpBtn);
            rpBtn.ArcRadiusBorde = 15;
            rpBtn.ArcRadiusPanel = 15;
            rpBtn.ColorBorde = White_Mode.HighContrast;
            rpBtn.ColorPanel = White_Mode.HighContrast;
            rpBtn.CornersRound = RectangleEdgeFilter.Left;
            rpBtn.Margin = new Padding(2);
            rpBtn.MenosHeightBorde = 1;
            rpBtn.MenosHeightPanel = 1;
            rpBtn.MenosWidthBorde = 1;
            rpBtn.MenosWidthPanel = 1;
            rpBtn.PorcLuzColorBorde = 0;
            rpBtn.Size = new System.Drawing.Size(77, 52);
            rpBtn.Name = nombre;
            rpBtn.Location = new Point(5, yLocation);

        }
        private void crearBtnMenu(RoundedPanel rpBtnMenu, Button btnMenu, string nombre, Image imagen)
        {
            rpBtnMenu.Controls.Add(btnMenu);
            btnMenu.BackColor = Color.Transparent;
            btnMenu.BackgroundImage = imagen;
            btnMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMenu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMenu.FlatStyle = FlatStyle.Flat;
            //btnMenu.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            btnMenu.ForeColor = White_Mode.BackBackground;
            btnMenu.Location = new System.Drawing.Point(20, 8);
            btnMenu.Name = nombre;
            btnMenu.Size = new Size(36, 36);
        }

        private void crearBotonInformacion(int nItems)
        {
            RoundedPanel rpBtnMenuInformacion = new LP2MegaAutos.RoundedPanel();
            Button btnMenuInformacion = new System.Windows.Forms.Button();
            crearRPMenu(rpBtnMenuInformacion, "rpBtnMenuInformacion", 115);
            crearBtnMenu(rpBtnMenuInformacion, btnMenuInformacion, "btnMenuInformacion", global::LP2MegaAutos.Properties.Resources.Informacion);

            // Crear el strip de Informacion
            PanelMenuStrip pms = crearStripInformacion(115, nItems, btnMenuInformacion);
            // Suscribir eventos para abrir el strip de informacion
            rpBtnMenuInformacion.MouseEnter += (sender, e) => { rpBtnMenu_MouseEnter(sender, e, pms); };
            btnMenuInformacion.MouseEnter += (sender, e) => { rpBtnMenu_MouseEnter(sender, e, pms); };
            rpBtnMenuInformacion.MouseLeave += (sender, e) => { rpBtnMenu_MouseLeave(sender, e, pms); };

        }
        private void crearBotonConfiguracion(bool estaBtnInfo, int nItems)
        {
            RoundedPanel rpBtnMenuConfiguracion = new LP2MegaAutos.RoundedPanel();
            Button btnMenuConfiguracion = new System.Windows.Forms.Button();
            int yLoc = estaBtnInfo ? 170 : 115;
            crearRPMenu(rpBtnMenuConfiguracion, "rpBtnMenuConfiguracion", yLoc);
            crearBtnMenu(rpBtnMenuConfiguracion, btnMenuConfiguracion, "btnMenuConfiguracion", global::LP2MegaAutos.Properties.Resources.Configuracion);

            //Crear el strip de Configuracion
            PanelMenuStrip pms = crearStripConfiguracion(yLoc, nItems, btnMenuConfiguracion);
            // Suscribir MouseEnter para abrir el strip de Configuracion
            rpBtnMenuConfiguracion.MouseEnter += (sender, e) => { rpBtnMenu_MouseEnter(sender, e, pms); };
            btnMenuConfiguracion.MouseEnter += (sender, e) => { rpBtnMenu_MouseEnter(sender, e, pms); };
            rpBtnMenuConfiguracion.MouseLeave += (sender, e) => { rpBtnMenu_MouseLeave(sender, e, pms); };
        }
        private void crearBotonBD(bool estaBtnInfo, bool estaBtnConfig)
        {
            int yLoc = estaBtnConfig ? estaBtnInfo ? 229 : 170 : 115;
            RoundedPanel rpBtnMenuActualizarEmpresa = new LP2MegaAutos.RoundedPanel();
            Button btnMenuActualizarBD = new System.Windows.Forms.Button();
            crearRPMenu(rpBtnMenuActualizarEmpresa, "rpBtnMenuActualizarEmpresa", yLoc);
            crearBtnMenu(rpBtnMenuActualizarEmpresa, btnMenuActualizarBD, "rpBtnMenuActualizarEmpresa", global::LP2MegaAutos.Properties.Resources.Empresa);
            btnMenuActualizarBD.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnMenuActualizarBD.Cursor = Cursors.Hand;
            btnMenuActualizarBD.MouseEnter+= btnMenu_MouseEnter;
            btnMenuActualizarBD.MouseLeave+= btnMenu_MouseLeave;
            btnMenuActualizarBD.Click += btnMenuActualizarEmpresa_Click;
        }
        #endregion Creacion Botones

        #region Creacion Strips
        private void validarItems(int nItems)
        {
            if (nItems > 4)
                throw new System.ArgumentException("Informacion no puede tener mas de 4 items");
            else if (nItems <= 0)
                throw new System.ArgumentException("Informacion no puede tener 0 items");
        }

        // Crear Strip dinamicamente
        private void crearStrip(PanelMenuStrip pms, int nItems, BindingList<Image> ims,
                                BindingList<ePermisos?> per, Button btnMenu, BindingList<string>txts)
        {
            // Asignar imagenes segun los permisos del usuario
            // En orden, son: Areas de Trabajo, Clientes, Vehiculos, Drivers
            // Si no tiene el primero, entonces el segundo
            if (_usuario.permisos.ToList<ePermisos?>().Contains(ePermisos.All))
            {
                pms.Imagen1 = ims[0];
                pms.Imagen2 = ims[1];
                pms.Imagen3 = ims[2];
                pms.Imagen4 = ims[3];
                pms.Texto1 = txts[0];
                pms.Texto2 = txts[1];
                pms.Texto3 = txts[2];
                pms.Texto4 = txts[3];
                pms.item1Click +=
                    new PanelMenuStrip.ButtonClickEventHandler
                    (BotonesDinamicosHelper.asignarBoton(per[0], btnMenu, ims[0], panelMenu, contenedorPantalla1));
                pms.item2Click +=
                    new PanelMenuStrip.ButtonClickEventHandler
                    (BotonesDinamicosHelper.asignarBoton(per[1], btnMenu, ims[1], panelMenu, contenedorPantalla1));
                pms.item3Click +=
                    new PanelMenuStrip.ButtonClickEventHandler
                    (BotonesDinamicosHelper.asignarBoton(per[2], btnMenu, ims[2], panelMenu, contenedorPantalla1));
                pms.item4Click +=
                    new PanelMenuStrip.ButtonClickEventHandler
                    (BotonesDinamicosHelper.asignarBoton(per[3], btnMenu, ims[3], panelMenu, contenedorPantalla1));

            }
            else
            {
                // Si tiene 4 items, pone la imagen al 4to item. Si no,
                // Pone el del 3ero, y así
                bool[] insertados = { false, false, false, false };
                int iUtilizado;
                if (nItems > 3)
                {
                    iUtilizado = _usuario.permisos.ToList<ePermisos?>().Contains(per[3]) ?
                             3 : -1;
                    if (iUtilizado != -1)
                    {
                        pms.Imagen4 = ims[iUtilizado];
                        pms.Texto4 = txts[iUtilizado];
                        insertados[iUtilizado] = true;
                        pms.item4Click +=
                            new PanelMenuStrip.ButtonClickEventHandler
                            (BotonesDinamicosHelper.asignarBoton(per[iUtilizado], btnMenu, ims[iUtilizado], panelMenu, contenedorPantalla1));
                    }
                    else pms.Imagen4 = Resources.Reloj;
                }
                if (nItems > 2)
                {
                    iUtilizado = _usuario.permisos.ToList<ePermisos?>().Contains(per[3]) && !insertados[3] ?
                              3 :
                              _usuario.permisos.ToList<ePermisos?>().Contains(per[2]) ?
                              2 : -1;
                    if (iUtilizado != -1)
                    {
                        pms.Imagen3 = ims[iUtilizado];
                        pms.Texto3 = txts[iUtilizado];
                        insertados[iUtilizado] = true;                      
                        pms.item3Click +=
                            new PanelMenuStrip.ButtonClickEventHandler
                            (BotonesDinamicosHelper.asignarBoton(per[iUtilizado], btnMenu, ims[iUtilizado], panelMenu, contenedorPantalla1));
                    }
                    else pms.Imagen3 = Resources.Reloj;
                }
                if (nItems > 1)
                {
                    iUtilizado = _usuario.permisos.ToList<ePermisos?>().Contains(per[3]) && !insertados[3] ?
                              3 :
                              _usuario.permisos.ToList<ePermisos?>().Contains(per[2]) && !insertados[2] ?
                              2 :
                              _usuario.permisos.ToList<ePermisos?>().Contains(per[1]) ?
                              1 : -1;
                    if (iUtilizado != -1)
                    {
                        pms.Imagen2 = ims[iUtilizado];
                        pms.Texto2 = txts[iUtilizado];
                        insertados[iUtilizado] = true;
                        pms.item2Click +=
                            new PanelMenuStrip.ButtonClickEventHandler
                            (BotonesDinamicosHelper.asignarBoton(per[iUtilizado], btnMenu, ims[iUtilizado], panelMenu, contenedorPantalla1));
                    }
                    else pms.Imagen2 = Resources.Reloj;
                }
                if (nItems > 0)
                {
                    iUtilizado = _usuario.permisos.ToList<ePermisos?>().Contains(per[3]) && !insertados[3] ?
                                  3 :
                                  _usuario.permisos.ToList<ePermisos?>().Contains(per[2]) && !insertados[2] ?
                                  2 :
                                  _usuario.permisos.ToList<ePermisos?>().Contains(per[1]) && !insertados[1] ?
                                  1 :
                                  _usuario.permisos.ToList<ePermisos?>().Contains(per[0]) ?
                                  0 : -1;
                    if (iUtilizado != -1)
                    {
                        pms.Imagen1 = ims[iUtilizado];
                        pms.Texto1 = txts[iUtilizado];
                        pms.item1Click +=
                            new PanelMenuStrip.ButtonClickEventHandler
                            (BotonesDinamicosHelper.asignarBoton(per[iUtilizado], btnMenu, ims[iUtilizado], panelMenu, contenedorPantalla1));
                    }
                    else pms.Imagen1 = Resources.Reloj;
                }
            }
        }

        // Crear Strip Menu Informacion Dinamicamente
        private PanelMenuStrip crearStripInformacion(int yLoc, int nItems, Button btnMenu)
        {
            // Validar que numero de Items esta entre 1 y 4
            validarItems(nItems);

            // Crear el objeto y agregarlo al panel Actual con yLoc
            PanelMenuStrip pms = new PanelMenuStrip(nItems);
            pnlBackBackground.Controls.Add(pms);
            pms.Location = new Point(0, yLoc);
            pms.LayoutImagenes = ImageLayout.Center;

            BindingList<ePermisos?> per = new BindingList<ePermisos?>();
            per.Add(ePermisos.AreasTrabajo);
            per.Add(ePermisos.Clientes);
            per.Add(ePermisos.Vehiculos);
            per.Add(ePermisos.Drivers);

            BindingList<string> txts= new BindingList<string>();
            txts.Add("Areas");
            txts.Add("Clientes");
            txts.Add("Vehiculos");
            txts.Add("Drivers");

            BindingList<Image> ims = new BindingList<Image>();
            ims.Add((Image)new Bitmap(Resources.AreaTrabajo, new Size(36, 36)));
            ims.Add((Image)new Bitmap(Resources.Clientes, new Size(36, 36)));
            ims.Add((Image)new Bitmap(Resources.Vehiculo, new Size(36, 36)));
            ims.Add((Image)new Bitmap(Resources.Driver, new Size(36, 36)));

            crearStrip(pms, nItems, ims, per, btnMenu,txts);

            // Hacerlo No Visible
            pms.Visible = false;
            return pms;
        }
        // Crear Strip Menu Configuracion Dinamicamente
        private PanelMenuStrip crearStripConfiguracion(int yLoc, int nItems, Button btnMenu)
        {
            // Validar que numero de Items esta entre 1 y 4
            validarItems(nItems);

            // Crear el objeto y agregarlo al panel Actual con yLoc
            PanelMenuStrip pms = new PanelMenuStrip(nItems);
            pnlBackBackground.Controls.Add(pms);
            pms.Location = new Point(0, yLoc);
            pms.LayoutImagenes = ImageLayout.Center;

            BindingList<ePermisos?> per = new BindingList<ePermisos?>();
            per.Add(ePermisos.Usuarios);
            per.Add(ePermisos.Servicios);
            per.Add(ePermisos.Sedes);
            per.Add(ePermisos.ActualizarBD);

            BindingList<string> txts = new BindingList<string>();
            txts.Add("Usuarios");
            txts.Add("Servicios");
            txts.Add("Sedes");
            txts.Add("Actualizar BD");

            BindingList<Image> ims = new BindingList<Image>();
            ims.Add((Image)new Bitmap(Resources.Usuarios, new Size(36, 36)));
            ims.Add((Image)new Bitmap(Resources.Servicio, new Size(36, 36)));
            ims.Add((Image)new Bitmap(Resources.Sede, new Size(36, 36)));
            ims.Add((Image)new Bitmap(Resources.BaseDatos, new Size(36, 36)));

            crearStrip(pms, nItems, ims, per, btnMenu,txts);

            // Hacerlo No Visible
            pms.Visible = false;
            return pms;
        }


        private void btnMenuActualizarEmpresa_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Control))
                ((Control)sender).Parent.Focus();
            daoEmpresa = new ServicioEmpresa.EmpresaWSClient();
            List<empresa> empresas = daoEmpresa.listarEmpresa().ToList();
            if (empresas == null) return;
            _empresa = empresas[0];
            frmEditarNombEmpresa pas = new frmEditarNombEmpresa(_empresa);
            if (pas.ShowDialog() == DialogResult.OK)
            {
                frmMessageBox frm = new frmMessageBox("Se actualizo el nombre de la empresa a." +
                    MessageBoxButtons.OK);
                frm.ShowDialog();
            }
        }

        #endregion Creacion Strips

        #endregion inicializacion

        #region panelMenu

        #region botonesClick
        private void btnHome_Click(object sender, EventArgs e)
        {
            // Cambiar los botones y rPanel
            BotonesDinamicosHelper.cambiarColoresBotonesMenu(rpBtnMenuHome, panelMenu);
            contenedorPantalla1.irInicio();
        }
        private void btnMenuReportes_Click(object sender, EventArgs e)
        {
            pmsReportes_ListaReportesClick(sender, e);
        }
        private void btnMenuCerrarSesion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            // TODO Cambiar valor dark mode pq login no sale bien

        }
        private void btnMenuUsuario_Click(object sender, EventArgs e)
        {
            pantallaEditarUsuario pas = new pantallaEditarUsuario(_usuario, true);
            pas.ShowDialog();
        }
        private void pmsReportes_ListaReportesClick(object sender, EventArgs e, string generando= "")
        {
            contenedorPantalla1.PantallaActual = new pantallaListaReportes(generando);

            // Cambiar los botones y rPanel excepto el enviado
            BotonesDinamicosHelper.cambiarColoresBotonesMenu((RoundedPanel)btnMenuReportes.Parent, panelMenu);
            pmsReportes.Visible = false;
        } 
        private void pmsReportes_ListaReportesClick(object sender, EventArgs e)
        {
            contenedorPantalla1.PantallaActual = new pantallaListaReportes();

            // Cambiar los botones y rPanel excepto el enviado
            BotonesDinamicosHelper.cambiarColoresBotonesMenu((RoundedPanel)btnMenuReportes.Parent, panelMenu);
            pmsReportes.Visible = false;
        }
        private void pmsReportes_ReporteAreaTrabajoClick(object sender, EventArgs e)
        {
            pmsReportes_ListaReportesClick(sender, e,"AT");
        }
        private void pmsReportes_ReporteClienteClick(object sender, EventArgs e)
        {
            pmsReportes_ListaReportesClick(sender, e,"Cliente");
        }
        private void pmsReportes_ReporteSiniestroClick(object sender, EventArgs e)
        {
            pmsReportes_ListaReportesClick(sender, e,"Siniestro");
            // TODO Hacer en enum de los botones seleccionados y poner esto
        }
        private void pmsUltimoReporte_EstadisticasClick(object sender, EventArgs e)
        {
            // TODO cambiar logica 
            if (true)
                MessageBox.Show("Aun no hay un ultimo Reporte.");
            pmsUltimoReporte.Visible = false;
        }
        private void pmsUltimoReporte_DetalleClick(object sender, EventArgs e)
        {
            // TODO cambiar logica 
            if (true)
                MessageBox.Show("Aun no hay un ultimo Reporte.");
            pmsUltimoReporte.Visible = false;
        }
        private void pmsUltimoReporte_ResumenClick(object sender, EventArgs e)
        {
            // TODO cambiar logica 
            if (true)
                MessageBox.Show("Aun no hay un ultimo Reporte.");
            pmsUltimoReporte.Visible = false;
        }
        private void btnMenuUltimoReporte_Click(object sender, EventArgs e)
        {
            pmsUltimoReporte_ResumenClick(sender, e);
        }
        private void verCreditos(object sender, EventArgs e)
        {
            frmCreditos frm = new frmCreditos();
            frm.ShowDialog();
        }

        #endregion botonesClick

        #region menuStrip

        private void rpBtnMenu_MouseEnter(object sender, EventArgs e, PanelMenuStrip pms)
        {
            pms.Visible = true;
            this.Controls[0].Controls.Add(pms);
            pms.BringToFront();
        }

        private void rpBtnMenu_MouseLeave(object sender, EventArgs e, PanelMenuStrip pms)
        {
            if (pms.ClientRectangle.Contains
                  (pms.PointToClient(Cursor.Position)))
                return;
            pms.Visible = false;
        }

        #endregion menuStrip

        #endregion panelMenu

        #region AdelanteAtras
        private void btnAtras_Click(object sender, EventArgs e)
        {
            contenedorPantalla1.volverUltimaPantalla();
            // TODO volver al estado del boton anterior
            // Idea llamar al evento 
        }
        private void btnAdelante_Click(object sender, EventArgs e)
        {
            contenedorPantalla1.adelantarPantalla();
            // TODO volver al estado del boton siguiente
            // Idea llamar al evento 
        }

        private void btnAdelante_MouseDown(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Colores.AmarilloInteractivoMas2;
        }

        private void btnAdelante_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Colores.AmarilloInteractivo;
        }
        #endregion AdelanteAtras

        #region MouseEnterMenu
        Color colorAnterior;
        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            RoundedPanel rp;
            if (sender.GetType() == typeof(RoundedPanel))
                rp = (RoundedPanel)sender;
            else
                rp = ((RoundedPanel)((Control)sender).Parent);
            if ((colorAnterior = rp.ColorPanel) == Colores.BackBackground)
                return;
            rp.ColorPanel = Colores.AmarilloHover;
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            RoundedPanel rp;
            if (sender.GetType() == typeof(RoundedPanel))
                rp = (RoundedPanel)sender;
            else
                rp = ((RoundedPanel)((Control)sender).Parent);
            if (rp.ColorPanel == Colores.BackBackground) 
                return;
            rp.ColorPanel = colorAnterior;
        }
        #endregion MouseEnterMenu
    }
}
