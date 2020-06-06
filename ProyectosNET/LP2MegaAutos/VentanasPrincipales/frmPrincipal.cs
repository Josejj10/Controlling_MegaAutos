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
using MetroFramework;
using Plasmoid.Extensions;

namespace LP2MegaAutos
{
    public partial class frmPrincipal : Form
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
            //_usuario.Permisos.Add(EPermisos.All);
            _usuario.Permisos.Add(EPermisos.ActualizarBD);
            //_usuario.Permisos.Add(EPermisos.Empresa);
            //_usuario.Permisos.Add(EPermisos.AreasTrabajo);
            Tipografias.crearFonts(this, tags); // Inicializa los fonts de este form
            cambiarColoresBotonesMenu(rpBtnMenuHome);
            suscribirEventos();
            crearBotonesInicio();
        }

        private void suscribirEventos()
        {
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

        #region creacionBotones
        private void crearBotonesInicio()
        {
            // Trabajar con flags el menu
            // Inicializarlo en 000
            // Flag 001 es BD
            // Flag 010 es Config
            // Flag 100 es info
            int menu = 0; 

            foreach (EPermisos permiso in _usuario.Permisos)
            {
                switch (permiso)
                {
                    case EPermisos.All:
                        menu |= 7;
                        break;
                    case EPermisos.ActualizarBD:
                        menu |= 1;
                        break;
                    case EPermisos.AreasTrabajo:
                        menu |= 4;
                        break;
                    case EPermisos.Clientes:
                        menu |= 4;
                        break;
                    case EPermisos.Drivers:
                        menu |= 4;
                        break;
                    case EPermisos.Empresa:
                        menu |= 2;
                        break;
                    case EPermisos.Sedes:
                        menu |= 2;
                        break;
                    case EPermisos.Servicios:
                        menu |= 2;
                        break;
                    case EPermisos.Usuarios:
                        menu |= 2;
                        break;
                    case EPermisos.Vehiculos:
                        menu |= 4;
                        break;
                }
            }

            // Crear los botones segun los flags de menu

            bool estaBtnInformacion = false;
            bool estaBtnConfiguracion= false;

            if((menu & 4) == 4)
            {
                // Crear boton de Información
                crearBotonInformacion();
                estaBtnInformacion = true;
            }

            if((menu & 2) == 2)
            {
                // Crear boton de Configuración
                crearBotonAjustes(estaBtnInformacion);
                estaBtnConfiguracion = true;
            }
            if((menu & 1) == 1)
            {
                // Crear boton de BD
                crearBotonBD(estaBtnInformacion, estaBtnConfiguracion);
            }

        }

        private void crearRPMenu(RoundedPanel rpBtn, string nombre, int yLocation)
        {
            panelMenu.Controls.Add(rpBtn); //...
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

        private void crearBotonInformacion()
        {
            RoundedPanel rpBtnMenuInformacion = new LP2MegaAutos.RoundedPanel();
            Button btnMenuInformacion = new System.Windows.Forms.Button();
            crearRPMenu(rpBtnMenuInformacion, "rpBtnMenuInformacion", 115);
            crearBtnMenu(rpBtnMenuInformacion, btnMenuInformacion, "rpBtnMenuInformacion", global::LP2MegaAutos.Properties.Resources.Informacion);
            btnMenuInformacion.Click += btnMenuInformacion_Click;
        }

        private void btnMenuInformacion_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            cambiarColoresBotonesMenu((RoundedPanel)btn.Parent);
            // TODO Abrir Strip Menu Informacion
        }

        private void crearBotonAjustes(bool estaBtnInfo)
        {
            RoundedPanel rpBtnMenuAjustes = new LP2MegaAutos.RoundedPanel();
            Button btnMenuAjustes = new System.Windows.Forms.Button();
            if(!estaBtnInfo)
                crearRPMenu(rpBtnMenuAjustes, "rpBtnMenuAjustes", 115);
            else
            crearRPMenu(rpBtnMenuAjustes, "rpBtnMenuAjustes", 170);
            crearBtnMenu(rpBtnMenuAjustes, btnMenuAjustes, "rpBtnMenuAjustes", global::LP2MegaAutos.Properties.Resources.Ajustes);
            btnMenuAjustes.Click +=btnMenuAjustes_Click;
        }

        private void btnMenuAjustes_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            cambiarColoresBotonesMenu((RoundedPanel)btn.Parent);
            // TODO Abrir Strip Menu Ajustes
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

        private void btnMenuActualizarBD_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            cambiarColoresBotonesMenu((RoundedPanel)btn.Parent);
            if(MetroMessageBox.Show(this, "¿Desea Actualizar la BD?", "Actualizar Base de Datos", MessageBoxButtons.YesNo)==
                DialogResult.Yes)
            {
                // TODO LA FUNCION ACTUALIZAR DATOS DEVOLVERA UN STRING CON LO ACTUALIZADO
                string str = "Se han actualizado 911 registros";
                MetroMessageBox.Show(this, str, "Base de Datos Actualizada");
            }

        }

        #endregion creacionBotones
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
        //private void btnServicios_Click(object sender, EventArgs e)
        //{
        //    if (!rpMain.Controls.Contains(pantallaActualizarServicios.Instancia))
        //    {
        //        rpMain.Controls.Add(pantallaActualizarServicios.Instancia);
        //        pantallaActualizarServicios.Instancia.Dock = DockStyle.Fill;
        //        pantallaActualizarServicios.Instancia.BringToFront();
        //        if (DarkMode.is_dark_mode_active())
        //            DarkMode.iniciarSinTimer(pantallaActualizarServicios.Instancia.Parent);
        //    }
        //    else
        //        pantallaActualizarServicios.Instancia.BringToFront();

        //    // Cambiar los botones y rPanel excepto el enviado
        //    cambiarColoresBotonesMenu(rpBtnMenuServicios);
        //}


        //private void btnGenerarReporte_Click(object sender, EventArgs e)
        //{
        //    if (!rpMain.Controls.Contains(pantallaGenerarReporte.Instancia))
        //    {
        //        rpMain.Controls.Add(pantallaGenerarReporte.Instancia);
        //        pantallaGenerarReporte.Instancia.Dock = DockStyle.Fill;
        //        if (DarkMode.is_dark_mode_active())
        //            DarkMode.iniciarSinTimer(pantallaGenerarReporte.Instancia.Parent);
        //    }
        //    pantallaGenerarReporte.Instancia.BringToFront();

        //    // Cambiar los botones y rPanel excepto el enviado
        //    cambiarColoresBotonesMenu(rpBtnMenuGenerarReporte);
        //}
        //private void btnAreasTrabajo_Click(object sender, EventArgs e)
        //{
        //    if (!rpMain.Controls.Contains(pantallaAreaTrabajo.Instancia))
        //    {
        //        rpMain.Controls.Add(pantallaAreaTrabajo.Instancia);
        //        pantallaAreaTrabajo.Instancia.Dock = DockStyle.Fill;
        //        if (DarkMode.is_dark_mode_active())
        //            DarkMode.iniciarSinTimer(pantallaAreaTrabajo.Instancia.Parent);
        //    }
        //    pantallaAreaTrabajo.Instancia.BringToFront();

        //    // Cambiar los botones y rPanel excepto el enviado
        //    cambiarColoresBotonesMenu(rpBtnMenuAreasTrabajo);
        //}
        //private void btnDrivers_Click(object sender, EventArgs e)
        //{
        //    if (!rpMain.Controls.Contains(pantallaActualizarDrivers.Instancia))
        //    {
        //        rpMain.Controls.Add(pantallaActualizarDrivers.Instancia);
        //        pantallaActualizarDrivers.Instancia.Dock = DockStyle.Fill;
        //        if (DarkMode.is_dark_mode_active())
        //            DarkMode.iniciarSinTimer(pantallaActualizarDrivers.Instancia.Parent);
        //    }
        //    pantallaActualizarDrivers.Instancia.BringToFront();

        //    // Cambiar los botones y rPanel excepto el enviado
        //    cambiarColoresBotonesMenu(rpBtnMenuDrivers);
        //}
        //private void btnMenuEmpresa_Click(object sender, EventArgs e)
        //{
        //    if (!rpMain.Controls.Contains(pantallaInformacionEmpresaGerente.Instancia))
        //    {
        //        rpMain.Controls.Add(pantallaInformacionEmpresaGerente.Instancia);
        //        pantallaInformacionEmpresaGerente.Instancia.Dock = DockStyle.Fill;
        //        if (DarkMode.is_dark_mode_active())
        //            DarkMode.iniciarSinTimer(pantallaInformacionEmpresaGerente.Instancia.Parent);
        //    }
        //    pantallaInformacionEmpresaGerente.Instancia.BringToFront();

        //    // Cambiar los botones y rPanel excepto el enviado
        //    cambiarColoresBotonesMenu(rpBtnMenuEmpresa);
        //}
        //private void btnClientes_Click(object sender, EventArgs e)
        //{
        //    if (!rpMain.Controls.Contains(pantallaActualizarClientes.Instancia))
        //    {
        //        rpMain.Controls.Add(pantallaActualizarClientes.Instancia);
        //        pantallaActualizarClientes.Instancia.Dock = DockStyle.Fill;
        //        if (DarkMode.is_dark_mode_active())
        //            DarkMode.iniciarSinTimer(pantallaActualizarClientes.Instancia.Parent);
        //    }
        //    pantallaActualizarClientes.Instancia.BringToFront();

        //    // Cambiar los botones y rPanel excepto el enviado
        //    cambiarColoresBotonesMenu(rpBtnMenuClientes);
        //}
        //private void btnMenuUsuarios_Click(object sender, EventArgs e)
        //{
        //    if (!rpMain.Controls.Contains(pantallaActualizarUsuarios.Instancia))
        //    {
        //        rpMain.Controls.Add(pantallaActualizarUsuarios.Instancia);
        //        pantallaActualizarUsuarios.Instancia.Dock = DockStyle.Fill;
        //        if (DarkMode.is_dark_mode_active())
        //            DarkMode.iniciarSinTimer(pantallaActualizarUsuarios.Instancia.Parent);
        //    }
        //    pantallaActualizarUsuarios.Instancia.BringToFront();

        //    // Cambiar los botones y rPanel excepto el enviado
        //    cambiarColoresBotonesMenu(rpBtnMenuUsuarios);
        //}

        //private void btnMenuSedes_Click(object sender, EventArgs e)
        //{
        //    if (!rpMain.Controls.Contains(pantallaActualizarSedes.Instancia))
        //    {
        //        rpMain.Controls.Add(pantallaActualizarSedes.Instancia);
        //        pantallaActualizarSedes.Instancia.Dock = DockStyle.Fill;
        //        if (DarkMode.is_dark_mode_active())
        //            DarkMode.iniciarSinTimer(pantallaActualizarSedes.Instancia.Parent);
        //    }
        //    pantallaActualizarSedes.Instancia.BringToFront();

        //    // Cambiar los botones y rPanel excepto el enviado
        //    cambiarColoresBotonesMenu(rpBtnMenuSedes);
        //}
        //private void btnMenuAjustes_Click(object sender, EventArgs e)
        //{
        //    if (!rpMain.Controls.Contains(pantallaAjustesUsuarioGerente.Instancia))
        //    {
        //        rpMain.Controls.Add(pantallaAjustesUsuarioGerente.Instancia);
        //        pantallaAjustesUsuarioGerente.Instancia.Dock = DockStyle.Fill;
        //        if (DarkMode.is_dark_mode_active())
        //            DarkMode.iniciarSinTimer(pantallaAjustesUsuarioGerente.Instancia.Parent);
        //    }
        //    pantallaAjustesUsuarioGerente.Instancia.BringToFront();

        //    // Cambiar los botones y rPanel excepto el enviado
        //    cambiarColoresBotonesMenu(rpBtnMenuAjustes);
        //}

        private void btnMenuReportes_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(pantallaListaReportes.Instancia))
            {
                this.Controls.Add(pantallaListaReportes.Instancia);
                pantallaListaReportes.Instancia.Dock = DockStyle.Fill;
                if (DarkMode.is_dark_mode_active())
                    DarkMode.iniciarSinTimer(pantallaListaReportes.Instancia.Parent);
            }
            pantallaListaReportes.Instancia.BringToFront();

            // Cambiar los botones y rPanel excepto el enviado
            cambiarColoresBotonesMenu(rpBtnMenuReportes);
        }

        private void actualizarBD(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,"La base de datos de Virus ha sido actualizada.", "Actualizar Base de Datos");
        }

        private void btnMenuCerrarSesion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        #endregion botonesClick

        #endregion panelMenu

    }
}
