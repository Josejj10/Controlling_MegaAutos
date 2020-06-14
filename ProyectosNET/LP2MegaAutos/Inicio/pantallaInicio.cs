using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2MegaAutos.VentanasPrincipales;
using LP2MegaAutos.Framework.UserControls.Items;
using LP2MegaAutos.Properties;

namespace LP2MegaAutos
{
    public partial class pantallaInicioGerente : Pantalla
    {
        private Usuario _usuario;

        public pantallaInicioGerente()
        {
            InitializeComponent();
        }
        public pantallaInicioGerente(Usuario u)
        {
            InitializeComponent();
            _usuario = u;
        }

        #region Dynamic
        public void crearBotonesSegunPermisos()
        {
            // Ver los permisos que tiene el usuario
            // Trabajandolo con flags
            // Flag 001 = Actualizar BD
            // Flag 010 = Configuracion
            // Flag 100 = Informacion
            int botones = 0;
            int nItemsInfo = 0;
            int nItemsConfig = 0;
            BotonesDinamicosHelper.recibirParametros(_usuario.Permisos, ref botones, ref nItemsInfo, ref nItemsConfig);
            // TODO
            if ((botones & 4) == 4)
            {
                // Hacer Visible el panel de informacion
                this.pnlInformacion.Visible = this.pnlAbajoInformacion.Visible = true;

                // Crear itemMenuStrips de Informacion
                crearBotonesInformacion();
            }
            if ((botones & 2) == 2)
            {
                // Hacer Visible el panel de Configuracion
                this.pnlConfiguracion.Visible = this.pnlAbajoConfiguracion.Visible = true;

                // Crear itemMenuStrips de Configuracion
                crearBotonesConfiguracion();
            }

            if ((botones & 1) == 1)
            {
                // Hacer Visible el Label de Actualizar BD
                this.lblActualizarBD.Visible = true;
            }

        }

        private itemMenuStrip crearItemMenuStrip(int xLoc, int yLoc, string nombre, Image img, string texto)
        {
            // Crear el ims y agregarlo a 
            itemMenuStrip ims = new itemMenuStrip();
            Controls.Add(ims);
            ims.Name = nombre;
            ims.BackgroundLayout = ImageLayout.Center;
            ims.Imagen = (Image) new Bitmap(img, new Size(54,54));
            ims.Size = new Size(80, 80);
            ims.Texto = texto;
            //ims.FontSize = 12.25f;
            ims.Location = new Point(xLoc, yLoc);

            return ims;
        }

        private void crearBotones(int xLoc, BindingList<string> nombres, BindingList<EPermisos> per, 
            BindingList<Image> imgs, Button btnMenu, BindingList<string> txts)
        {
            ContenedorPantalla cnt = ((frmPrincipal)this.Parent.Parent.Parent).ContenedorPantallas;
            Panel panelMenu = ((frmPrincipal)this.Parent.Parent.Parent).PanelMenu;
            // Crear segun permisos 
            // Si tiene el permiso todos
            if (_usuario.Permisos.Contains(EPermisos.All))
            {
                // Crear todos
                itemMenuStrip ims1 = crearItemMenuStrip(xLoc, 176, nombres[0], imgs[0],txts[0]);
                itemMenuStrip ims2 = crearItemMenuStrip(xLoc, 255, nombres[1], imgs[1], txts[1]);
                itemMenuStrip ims3 = crearItemMenuStrip(xLoc, 334, nombres[2], imgs[2], txts[2]);
                itemMenuStrip ims4 = crearItemMenuStrip(xLoc, 413, nombres[3], imgs[3], txts[3]);

                // Suscribir todos
                ims1.click += new itemMenuStrip.ButtonClickEventHandler(
                    BotonesDinamicosHelper.asignarBoton(per[0],btnMenu, imgs[1],
                    panelMenu, cnt));
                ims2.click += new itemMenuStrip.ButtonClickEventHandler(
                    BotonesDinamicosHelper.asignarBoton(per[1],btnMenu, imgs[2],
                    panelMenu, cnt));
                ims3.click += new itemMenuStrip.ButtonClickEventHandler(
                    BotonesDinamicosHelper.asignarBoton(per[2],btnMenu, imgs[2],
                    panelMenu, cnt));
                ims4.click += new itemMenuStrip.ButtonClickEventHandler(
                    BotonesDinamicosHelper.asignarBoton(per[3],btnMenu, imgs[3],
                    panelMenu, cnt));
                return;
            }

            // Si no tiene permiso todos, entonces hacer switch de cuales tienen permiso
            // Usando flags, se hara
            // Item 1 = 1000 = 8
            // Item 2 = 0100 = 4
            // Item 3 = 0010 = 2
            // Item 4 = 0001 = 1

            int menu = 0;
            int yLoc;

            // Primero Area de Trabajo
            if (_usuario.Permisos.Contains(per[0]))
            {
                yLoc = 176;

                // Crear el itemMenuStrip correspondiente con xLoc, yLoc, nombre e Imagen
                itemMenuStrip ims = crearItemMenuStrip(xLoc, yLoc, nombres[0], imgs[0], txts[0]);

                // TODO Suscribir el itemMenuStrip al click delegandolo al frmPrincipal
                // ims.click += itemStrip_Click;
                ims.click += new itemMenuStrip.ButtonClickEventHandler(
                    BotonesDinamicosHelper.asignarBoton(per[0], btnMenu, imgs[0],
                    panelMenu, cnt));

                // Ya se esta utilizado el item 1
                menu |= 8;
            }

            if (_usuario.Permisos.Contains(per[1]))
            {

                // Si se esta utilizando el item 1
                yLoc = (menu & 8) == 8 ? 255 : 176;

                // Crear el itemMenuStrip correspondiente con xLoc, yLoc, nombre e Imagen
                itemMenuStrip ims = crearItemMenuStrip(xLoc, yLoc, nombres[1], imgs[1], txts[1]);

                // Suscribir el itemMenuStrip al click
                ims.click += new itemMenuStrip.ButtonClickEventHandler(
                    BotonesDinamicosHelper.asignarBoton(per[1], btnMenu, imgs[1],
                    panelMenu, cnt));

                // Ya se esta utilizando este item
                menu |= yLoc == 176 ? 8 : 4;
            }

            if (_usuario.Permisos.Contains(per[2]))
            {
                // yLoc depende de que items ya hayan sido creados
                yLoc = (menu & 8) == 8 ? (menu & 4) == 4 ? 334 : 255 : 176;

                // Crear el itemMenuStrip correspondiente con xLoc, yLoc, nombre e Imagen
                itemMenuStrip ims = crearItemMenuStrip(xLoc, yLoc, nombres[2], imgs[2], txts[2]);

                // Suscribir el itemMenuStrip al click
                ims.click += new itemMenuStrip.ButtonClickEventHandler(
                    BotonesDinamicosHelper.asignarBoton(per[2], btnMenu, imgs[2],
                    panelMenu, cnt));

                // Ya se esta usando este item 
                menu |= yLoc == 176 ? 8 : yLoc == 255 ? 4 : 2;  
            }

            if (_usuario.Permisos.Contains(per[3]))
            {
                // yLoc dependera de que items ya han sido creados
                yLoc = (menu & 8) == 8 ? (menu & 4) == 4 ? (menu & 2) == 2 ?
                    413 : 334 : 255 : 176;

                // Crear el itemMenuStrip correspondiente con xLoc, yLoc, nombre e Imagen
                itemMenuStrip ims = crearItemMenuStrip(xLoc, yLoc, nombres[3], imgs[3], txts[3]);

                // Suscribir el itemMenuStrip al click
                ims.click += new itemMenuStrip.ButtonClickEventHandler(
                    BotonesDinamicosHelper.asignarBoton(per[3], btnMenu, imgs[3],
                    panelMenu, cnt));
                // No se llena menu porque ya no se usara mas 
            }

        }

        private void crearBotonesInformacion()
        {
            // Crear listas necesarias
            BindingList<string> nombres = new BindingList<string>();
            BindingList<string> textos = new BindingList<string>();
            BindingList<EPermisos> per = new BindingList<EPermisos>();
            BindingList<Image> imgs = new BindingList<Image>();

            nombres.Add("btnAreaTrabajo");
            nombres.Add("btnClientes");
            nombres.Add("btnDrivers");
            nombres.Add("btnVehiculos");

            textos.Add("Areas de" + Environment.NewLine+ "Trabajo");
            textos.Add("Clientes");
            textos.Add("Drivers");
            textos.Add("Carros");

            per.Add(EPermisos.AreasTrabajo);
            per.Add(EPermisos.Clientes);
            per.Add(EPermisos.Drivers);
            per.Add(EPermisos.Vehiculos);

            imgs.Add(Resources.AreaTrabajo);            
            imgs.Add(Resources.Clientes);            
            imgs.Add(Resources.Driver);            
            imgs.Add(Resources.car);

            Button btnInfo = ((frmPrincipal)this.Parent.Parent.Parent).getBotonPanelMenuString("btnMenuInformacion");

            crearBotones(540, nombres, per, imgs, btnInfo, textos);
        }

        private void crearBotonesConfiguracion()
        {
            // Crear listas necesarias
            BindingList<string> nombres = new BindingList<string>();
            BindingList<string> textos = new BindingList<string>();
            BindingList<EPermisos> per = new BindingList<EPermisos>();
            BindingList<Image> imgs = new BindingList<Image>();

            nombres.Add("btnUsuarios");
            nombres.Add("btnServicios");
            nombres.Add("btnSedes");
            nombres.Add("btnEmpresa");

            textos.Add("Usuarios");
            textos.Add("Servicios");
            textos.Add("Sedes");
            textos.Add("Empresa");

            per.Add(EPermisos.Usuarios);
            per.Add(EPermisos.Servicios);
            per.Add(EPermisos.Sedes);
            per.Add(EPermisos.Empresa);

            imgs.Add(Resources.Usuarios);
            imgs.Add(Resources.Servicio);
            imgs.Add(Resources.Sede);
            imgs.Add(Resources.Empresa);

            Button btnConfig = ((frmPrincipal)this.Parent.Parent.Parent).
                getBotonPanelMenuString("btnMenuConfiguracion");
            
            crearBotones(626, nombres, per, imgs,btnConfig,textos);


        }
        #endregion Dynamic

        #region Event Handlers
        // Crear Event Handlers para que la pantalla Principal 
        // Abra del Menu
        public delegate void ButtonClickEventHandler(object sender, EventArgs e);
        public event ButtonClickEventHandler perfilUsuarioClick;
        public event ButtonClickEventHandler ListaReportesClick;
        public event ButtonClickEventHandler ReporteAreaTrabajoClick;
        public event ButtonClickEventHandler ReporteClienteClick;
        public event ButtonClickEventHandler ReporteVehiculoClick;
        public event ButtonClickEventHandler CreditosClick;
        public event ButtonClickEventHandler ActualizarBDClick;
        public event ButtonClickEventHandler VerUltimoReporteClick;
        #endregion Event Handlers

        #region BotonesClick
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = perfilUsuarioClick;
            if (h != null) h(this, e);
        }

        private void btnGenerarVehiculo_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = ReporteVehiculoClick;
            if (h != null) h(this, e);
        }

        private void btnGenerarAreaTrabajo_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = ReporteAreaTrabajoClick;
            if (h != null) h(this, e);
        }

        private void btnGenerarCliente_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = ReporteClienteClick;
            if (h != null) h(this, e);
        }

        private void btnListaReportes_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = ListaReportesClick;
            if (h != null) h(this, e);
        }

        private void lblCreditos_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = CreditosClick;
            if (h != null) h(this, e);
        }
        private void lblActualizarBD_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = ActualizarBDClick;
            if (h != null) h(this, e);
        }
        private void ultimoReporteDashboard1_VerReporteClick(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = VerUltimoReporteClick;
            if (h != null) h(this, e);
        }
        #endregion Botones Click
    }
}
