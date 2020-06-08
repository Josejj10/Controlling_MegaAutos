﻿using System;
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

namespace LP2MegaAutos
{
    public partial class frmPrincipal : MetroForm
    {

        private Usuario _usuario;
        public Usuario Usuario { get => _usuario; set => _usuario = value; }

        #region inicializacion
        public frmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            if (DarkMode.is_dark_mode_active())
            {
                DarkMode.iniciarDarkMode(panel_toggle_nocturno, boton_toggle_nocturno, reloj_dark, this);
            }
            _usuario = usuario;
            _usuario.Permisos.Add(EPermisos.All);
            //_usuario.Permisos.Add(EPermisos.ActualizarBD);
            //_usuario.Permisos.Add(EPermisos.Empresa);
            _usuario.Permisos.Add(EPermisos.Drivers);
            _usuario.Permisos.Add(EPermisos.Clientes);
            Tipografias.crearFonts(this, tags); // Inicializa los fonts de este form
            cambiarColoresBotonesMenu(rpBtnMenuHome);
            suscribirEventos();
            crearBotonesInicio();
        }

        private void suscribirEventos()
        {
            // Eventos de los paneles estaticos del Menu
            rpBtnMenuReportes.MouseEnter += (sender, e) => { rpBtnMenu_MouseEnter(sender, e, pmsReportes); };
            btnMenuReportes.MouseEnter += (sender, e) => { rpBtnMenu_MouseEnter(sender, e, pmsReportes); };
            rpBtnMenuReportes.MouseLeave += (sender, e) => { rpBtnMenu_MouseLeave(sender, e, pmsReportes); };

            // Suscribir a eventos de la pantalla de inicio
            //public event ButtonClickEventHandler DriversGerente;
            //public event ButtonClickEventHandler EmpresaGerente;
            //public event ButtonClickEventHandler ClientesGerente;
            //public event ButtonClickEventHandler UsuariosGerente;
            //public event ButtonClickEventHandler SedesGerente;
            //public event ButtonClickEventHandler ActualizarBDGerente;
            //public event ButtonClickEventHandler AjustesGerente;
            //public event ButtonClickEventHandler CerrarSesionGerente;

            //pntIniGen.BienvenidoClickGerente += btnMenuAjustes_Click;
            //pntIniGen.GenerarReporte += btnGenerarReporte_Click;
            //pntIniGen.AreaTrabajoGerente += btnAreasTrabajo_Click;
            //pntIniGen.ReportesGerente += btnMenuReportes_Click;
            //pntIniGen.ServiciosGerente += btnServicios_Click;
            //pntIniGen.DriversGerente += btnDrivers_Click;
            //pntIniGen.EmpresaGerente += btnMenuEmpresa_Click;
            //pntIniGen.ClientesGerente += btnClientes_Click;
            //pntIniGen.UsuariosGerente += btnMenuUsuarios_Click;
            //pntIniGen.SedesGerente += btnMenuSedes_Click;
            //pntIniGen.ActualizarBDGerente += actualizarBD;
            //pntIniGen.AjustesGerente += btnMenuAjustes_Click;
            //pntIniGen.CerrarSesionGerente += btnMenuCerrarSesion_Click;
        }

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

            foreach (EPermisos permiso in _usuario.Permisos)
            {
                switch (permiso)
                {
                    case EPermisos.All:
                        nItemsInfo = 4;
                        nItemsConfig = 4;
                        menu |= 7;
                        break;
                    case EPermisos.ActualizarBD:
                        menu |= 1;
                        break;
                    case EPermisos.AreasTrabajo:
                        menu |= 4;
                        nItemsInfo++;
                        break;
                    case EPermisos.Clientes:
                        menu |= 4;
                        nItemsInfo++;
                        break;
                    case EPermisos.Drivers:
                        menu |= 4;
                        nItemsInfo++;
                        break;
                    case EPermisos.Empresa:
                        menu |= 2;
                        nItemsConfig++;
                        break;
                    case EPermisos.Sedes:
                        menu |= 2;
                        nItemsConfig++;
                        break;
                    case EPermisos.Servicios:
                        menu |= 2;
                        nItemsConfig++;
                        break;
                    case EPermisos.Usuarios:
                        menu |= 2;
                        nItemsConfig++;
                        break;
                    case EPermisos.Vehiculos:
                        menu |= 4;
                        nItemsInfo++;
                        break;
                }
                // Si ya tiene todos los permisos (config, info, bd), entonces salir
                if (nItemsConfig == 4 && nItemsInfo == 4 && (menu & 1) == 1) break;
            }

            // Crear los botones segun los flags de menu

            bool estaBtnInformacion = false;
            bool estaBtnConfiguracion= false;

            if((menu & 4) == 4)
            {
                // Crear boton de Información
                crearBotonInformacion(nItemsInfo);
                estaBtnInformacion = true;
            }

            if((menu & 2) == 2)
            {
                // Crear boton de Configuración
                crearBotonConfiguracion(estaBtnInformacion, nItemsConfig);
                estaBtnConfiguracion = true;
            }
            if((menu & 1) == 1)
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
            rpBtn.Location = new Point(5,yLocation);

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
            crearBtnMenu(rpBtnMenuInformacion, btnMenuInformacion, "rpBtnMenuInformacion", global::LP2MegaAutos.Properties.Resources.Informacion);

            // Crear el strip de Informacion
            PanelMenuStrip pms = crearStripInformacion(115, nItems,btnMenuInformacion);
            // Suscribir eventos para abrir el strip de informacion
            rpBtnMenuInformacion.MouseEnter += (sender, e) => { rpBtnMenu_MouseEnter(sender,e,pms); };
            btnMenuInformacion.MouseEnter += (sender, e) => { rpBtnMenu_MouseEnter(sender,e,pms); };
            rpBtnMenuInformacion.MouseLeave += (sender, e) => { rpBtnMenu_MouseLeave(sender, e, pms); };

        }
        private void crearBotonConfiguracion(bool estaBtnInfo, int nItems)
        {
            RoundedPanel rpBtnMenuConfiguracion = new LP2MegaAutos.RoundedPanel();
            Button btnMenuConfiguracion = new System.Windows.Forms.Button();
            int yLoc = estaBtnInfo ? 170 : 115;
            crearRPMenu(rpBtnMenuConfiguracion, "rpBtnMenuConfiguracion", yLoc);
            crearBtnMenu(rpBtnMenuConfiguracion, btnMenuConfiguracion, "rpBtnMenuConfiguracion", global::LP2MegaAutos.Properties.Resources.Configuracion);

            //Crear el strip de Configuracion
            PanelMenuStrip pms = crearStripConfiguracion(yLoc, nItems,btnMenuConfiguracion);
            // Suscribir MouseEnter para abrir el strip de Configuracion
            rpBtnMenuConfiguracion.MouseEnter += (sender, e) => { rpBtnMenu_MouseEnter(sender, e,  pms); };
            btnMenuConfiguracion.MouseEnter += (sender, e) => { rpBtnMenu_MouseEnter(sender, e, pms); };
            rpBtnMenuConfiguracion.MouseLeave += (sender, e) => { rpBtnMenu_MouseLeave(sender, e, pms); };
        }
        private void crearBotonBD(bool estaBtnInfo, bool estaBtnConfig)
        {
            int yLoc = estaBtnConfig ? estaBtnInfo ? 229 : 170 : 115;
            RoundedPanel rpBtnMenuActualizarBD = new LP2MegaAutos.RoundedPanel();
            Button btnMenuActualizarBD = new System.Windows.Forms.Button();
            crearRPMenu(rpBtnMenuActualizarBD, "rpBtnMenuActualizarBD", yLoc);
            crearBtnMenu(rpBtnMenuActualizarBD, btnMenuActualizarBD, "rpBtnMenuActualizarBD", global::LP2MegaAutos.Properties.Resources.BaseDatos);
            btnMenuActualizarBD.Click += btnMenuActualizarBD_Click;
        }
        #endregion Creacion Botones

        #region Creacion Strips
        
        // Devolvera el metodo generico con la clase de la pantalla que se creara segun el permiso que se le mande
        private Action<object, EventArgs> asignarBoton(PanelMenuStrip pms, EPermisos per, Button btn, Image img)
        {
            // asignar el boton segun el permiso elegido
            Action<object, EventArgs> a;
            switch (per)
            {
                case EPermisos.AreasTrabajo:
                    a = (sender, e) => { pmsBtn_Click<pantallaAreaTrabajo>(sender, e, btn, img); };
                    break;
                case EPermisos.Clientes:
                    a = (sender, e) => { pmsBtn_Click<pantallaActualizarClientes>(sender, e, btn, img); };
                    break;
                case EPermisos.Drivers:
                    a = (sender, e) => { pmsBtn_Click<pantallaActualizarDrivers>(sender, e, btn, img); };
                    break;
                case EPermisos.Empresa:
                    a = (sender, e) => { pmsBtn_Click<pantallaInformacionEmpresaGerente>(sender, e, btn, img); };
                    break;
                case EPermisos.Sedes:
                    a = (sender, e) => { pmsBtn_Click<pantallaActualizarSedes>(sender, e, btn, img); };
                    break;
                case EPermisos.Servicios:
                    a = (sender, e) => { pmsBtn_Click<pantallaActualizarServicios>(sender, e, btn, img); };
                    break;
                case EPermisos.Usuarios:
                    a = (sender, e) => { pmsBtn_Click<pantallaActualizarUsuarios>(sender, e, btn, img); };
                    break;
                case EPermisos.Vehiculos:
                    // TODO ACTUALIZAR CUANDO SE CREE VEHICULO
                    a = (sender, e) => { pmsBtn_Click<pantallaActualizarDrivers>(sender, e, btn, img); };
                    break;
                default:
                    a = (sender, e) => { pmsBtn_Click<pantallaInformacionEmpresa>(sender, e, btn, img); };
                    break;
            }
            return a;
        }

        // Crear Strip dinamicamente
        private void crearStrip(PanelMenuStrip pms, int nItems, BindingList<Image> ims,
                                BindingList<EPermisos> per, Button btnMenu)
        {
            // Asignar imagenes segun los permisos del usuario
            // En orden, son: Areas de Trabajo, Clientes, Vehiculos, Drivers
            // Si no tiene el primero, entonces el segundo
            if (_usuario.Permisos.Contains(EPermisos.All))
            {
                pms.Imagen1 = ims[0];
                pms.Imagen2 = ims[1];
                pms.Imagen3 = ims[2];
                pms.Imagen4 = ims[3];
                pms.item1Click += new PanelMenuStrip.ButtonClickEventHandler(asignarBoton(pms, per[0], btnMenu, ims[0]));
                pms.item2Click += new PanelMenuStrip.ButtonClickEventHandler(asignarBoton(pms, per[1], btnMenu, ims[1]));
                pms.item3Click += new PanelMenuStrip.ButtonClickEventHandler(asignarBoton(pms, per[2], btnMenu, ims[2]));
                pms.item4Click += new PanelMenuStrip.ButtonClickEventHandler(asignarBoton(pms, per[3], btnMenu, ims[3]));
            }
            else
            {
                // Si tiene 4 items, pone la imagen al 4to item. Si no,
                // Pone el del 3ero, y así
                bool puesto4 = false;
                bool puesto3 = false;
                bool puesto2 = false;
                int iUtilizado;
                if (nItems > 3)
                {
                    iUtilizado = _usuario.Permisos.Contains(per[3]) ?
                             3 : -1;
                    if (iUtilizado != -1)
                    {
                        pms.Imagen4 = ims[iUtilizado];
                        puesto4 = true;
                        pms.item4Click += new PanelMenuStrip.ButtonClickEventHandler(asignarBoton(pms, per[iUtilizado], btnMenu, ims[iUtilizado]));
                    }
                    else pms.Imagen4 = Resources.Reloj;
                }
                if (nItems > 2)
                {
                    iUtilizado = _usuario.Permisos.Contains(per[3]) && !puesto4 ?
                              3 :
                              _usuario.Permisos.Contains(per[2]) ?
                              2 : -1;
                    if (iUtilizado != -1)
                    {
                        pms.Imagen3 = ims[iUtilizado];
                        if (puesto4) puesto3 = true;
                        else puesto4 = true;

                        pms.item3Click += new PanelMenuStrip.ButtonClickEventHandler(asignarBoton(pms, per[iUtilizado], btnMenu, ims[iUtilizado]));
                    }
                    else pms.Imagen3 = Resources.Reloj;
                }
                if (nItems > 1)
                {
                    iUtilizado = _usuario.Permisos.Contains(per[3]) && !puesto4 ?
                              3 :
                              _usuario.Permisos.Contains(per[2]) && !puesto3 ?
                              2 :
                              _usuario.Permisos.Contains(per[1]) ?
                              1 : -1;
                    if (iUtilizado != -1)
                    {
                        pms.Imagen2 = ims[iUtilizado];
                        if (puesto4)
                            if (puesto3)
                                puesto2 = true;
                            else puesto3 = true;
                        else puesto4 = true;
                        pms.item2Click += new PanelMenuStrip.ButtonClickEventHandler(asignarBoton(pms, per[iUtilizado], btnMenu, ims[iUtilizado]));
                    }
                    else pms.Imagen2 = Resources.Reloj;
                }
                if (nItems > 0)
                {
                    iUtilizado = _usuario.Permisos.Contains(per[3]) && !puesto4 ?
                                  3 :
                                  _usuario.Permisos.Contains(per[2]) && !puesto3 ?
                                  2 :
                                  _usuario.Permisos.Contains(per[1]) && !puesto2 ?
                                  1 :
                                  _usuario.Permisos.Contains(per[0]) ?
                                  0 : -1;
                    if (iUtilizado != -1)
                    {
                        pms.Imagen1 = ims[iUtilizado];
                        pms.item1Click += new PanelMenuStrip.ButtonClickEventHandler(asignarBoton(pms, per[iUtilizado], btnMenu, ims[iUtilizado]));
                    }
                    else pms.Imagen1 = Resources.Reloj;
                }
            }
        }
        private void validarItems(int nItems)
        {
            if (nItems > 4)
                throw new System.ArgumentException("Informacion no puede tener mas de 4 items");
            else if (nItems <= 0)
                throw new System.ArgumentException("Informacion no puede tener 0 items");
        }
        
        // Crear Strip Menu Informacion Dinamicamente
        private PanelMenuStrip crearStripInformacion(int yLoc, int nItems, Button btnMenu)
        {
            // Validar que numero de Items esta entre 1 y 4
            validarItems(nItems);

            // Crear el objeto y agregarlo al panel Actual con yLoc
            PanelMenuStrip pms = new PanelMenuStrip(nItems);
            pnlBackBackground.Controls.Add(pms);
            pms.Location = new Point(0,yLoc);

            BindingList<EPermisos> per = new BindingList<EPermisos>();
            per.Add(EPermisos.AreasTrabajo);
            per.Add(EPermisos.Clientes);
            per.Add(EPermisos.Vehiculos);
            per.Add(EPermisos.Drivers);

            BindingList<Image> ims = new BindingList<Image>();
            ims.Add(Resources.AreaTrabajo);
            ims.Add(Resources.Clientes);
            ims.Add(Resources.car);
            ims.Add(Resources.Driver);

            crearStrip(pms, nItems, ims, per,btnMenu);

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

            BindingList<EPermisos> per = new BindingList<EPermisos>();
            per.Add(EPermisos.Usuarios);
            per.Add(EPermisos.Servicios);
            per.Add(EPermisos.Sedes);
            per.Add(EPermisos.Empresa);

            BindingList<Image> ims = new BindingList<Image>();
            ims.Add(Resources.Usuarios);
            ims.Add(Resources.Servicio);
            ims.Add(Resources.Sede);
            ims.Add(Resources.Empresa);

            crearStrip(pms, nItems, ims, per,btnMenu);

            // Hacerlo No Visible
            pms.Visible = false;
            return pms;
        }

        
        private void btnMenuActualizarBD_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Actualizar BD", "Actualizar Base de Datos", MessageBoxButtons.YesNo) ==
                DialogResult.OK)
            {
                // Logica de actualizar bd
                // TODO devolver un string que diga lo que ha actualizado
                MessageBox.Show(this, "Se han actualizado 256 entradas");
            }

        }

        #endregion Creacion Strips

        #endregion inicializacion

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

        #region panelMenu
        private void cambiarRPMenu(RoundedPanel rp)
        {
            rp.ColorPanel = Color.Transparent;
            foreach(Control btn in rp.Controls)
                btn.BackColor = Color.Transparent;
        }
        private void cambiarColoresBotonesMenu(RoundedPanel rp)
        {
            // Itera por todos los botones del panel del Menu y cambia los colores
            // A menos que sea el rp y btn enviados
            // Cambiar color rounded panels de atras

            foreach (Control c in panelMenu.Controls)
            {
                // Todos los controles que tiene son RoundedPanels, cambiar su color
                if (c == rp) continue;
                if (c is RoundedPanel) cambiarRPMenu((RoundedPanel)c);                
            }
            if (DarkMode.is_dark_mode_active())
                rp.ColorPanel = Dark_Mode.BackBackground;
            else
                rp.ColorPanel = White_Mode.BackBackground;

        }

        #region botonesClick
        private void btnHome_Click(object sender, EventArgs e)
        {
            //pntIniGen.BringToFront();
            // Cambiar los botones y rPanel
            cambiarColoresBotonesMenu(rpBtnMenuHome);
        }
        private void btnMenuReportes_Click(object sender, EventArgs e)
        {
            pmsReportes_ListaReportesClick(sender, e);
        }

        private void btnMenuCerrarSesion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void rpStripBtn_Click(object sender, EventArgs e)
        {

            this.contenedorPantalla1.PantallaActual = new pantallaActualizarServicios();

            // Cambiar los botones y rPanel excepto el enviado
            cambiarColoresBotonesMenu((RoundedPanel)button1.Parent);
        }
        
        private void pmsReportes_ListaReportesClick(object sender, EventArgs e)
        {
                      
            this.contenedorPantalla1.PantallaActual = new pantallaListaReportes();
            // Cambiar los botones y rPanel excepto el enviado
            cambiarColoresBotonesMenu((RoundedPanel)btnMenuReportes.Parent);
            pmsReportes.Visible = false;
        }

        private void pmsReportes_ReporteClienteClick(object sender, EventArgs e)
        {
            pmsReportes_ListaReportesClick(sender, e);
            // TODO En la vista de lista reportes hacer en enum de los botones seleccionados y 
            // desde esta funcion mandar el valor para que lo haga
            //pantallaListaReportes.Instancia.BotonSeleccionado = Cliente;
        }

        private void pmsReportes_ReporteVehiculoClick(object sender, EventArgs e)
        {
            pmsReportes_ListaReportesClick(sender, e);
            // TODO Hacer en enum de los botones seleccionados y poner esto
            //pantallaListaReportes.Instancia.BotonSeleccionado = Cliente;
        }

        // Metodo Generico que cambiara las pantallas segun las clases
        private void pmsBtn_Click<T>(object sender, EventArgs e, Button btnMenu, Image img)
        {
            cambiarColoresBotonesMenu((RoundedPanel)btnMenu.Parent);
            this.contenedorPantalla1.PantallaActual = (Pantalla)Activator.CreateInstance(typeof(T));
            if (DarkMode.is_dark_mode_active())
                DarkMode.iniciarSinTimer(contenedorPantalla1);

            // Cambiar el icono del boton para que sea el enviado
            btnMenu.BackgroundImage = img;
            PanelMenuStrip pms = (PanelMenuStrip) sender;
            pms.Visible = false;
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
    }
}
