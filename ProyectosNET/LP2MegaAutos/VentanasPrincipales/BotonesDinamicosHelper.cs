using LP2MegaAutos.Framework.UserControls;
using LP2MegaAutos.Informacion.Vehiculos;
using LP2MegaAutos.Properties;
using LP2MegaAutos.ServicioUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2MegaAutos.VentanasPrincipales
{
    public class BotonesDinamicosHelper
    {
        // Devolvera el contenedor de flags menu que señala qué botones crear
        // Y también el numero de items de cada menu
        public static void recibirParametros(List<ePermisos?> permisos, ref int menu, ref int nItemsInfo, ref int nItemsConfig)
        {

            foreach (ePermisos permiso in permisos)
            {
                switch (permiso)
                {
                    case ePermisos.All:
                        nItemsInfo = 4;
                        nItemsConfig = 4;
                        menu |= 7;
                        break;
                    case ePermisos.Empresa:
                        menu |= 1;
                        break;
                    case ePermisos.ActualizarBD:
                        menu |= 2;
                        nItemsConfig++;
                        break;
                    case ePermisos.AreasTrabajo:
                        menu |= 4;
                        nItemsInfo++;
                        break;
                    case ePermisos.Clientes:
                        menu |= 4;
                        nItemsInfo++;
                        break;
                    case ePermisos.Drivers:
                        menu |= 4;
                        nItemsInfo++;
                        break;
                    case ePermisos.Sedes:
                        menu |= 2;
                        nItemsConfig++;
                        break;
                    case ePermisos.Servicios:
                        menu |= 2;
                        nItemsConfig++;
                        break;
                    case ePermisos.Usuarios:
                        menu |= 2;
                        nItemsConfig++;
                        break;
                    case ePermisos.Vehiculos:
                        menu |= 4;
                        nItemsInfo++;
                        break;
                }
                // Si ya tiene todos los permisos (config, info, bd), entonces salir
                if (nItemsConfig == 4 && nItemsInfo == 4 && (menu & 1) == 1) return;
            }
        }

        // Devolvera el metodo generico con la clase de la pantalla que se creara segun el permiso que se le 
        public static Action<object, EventArgs> asignarBoton(ePermisos? per, Button btn, Image img,
            Panel panelMenu, ContenedorPantalla cont)
        {
            switch (per)
            {
                case ePermisos.AreasTrabajo:
                    return (sender, e) => { pmsBtn_Click<pantallaAreaTrabajo>(sender, e, btn, img, panelMenu, cont); };
                case ePermisos.Clientes:
                    return (sender, e) => { pmsBtn_Click<pantallaActualizarClientes>(sender, e, btn, img, panelMenu, cont); };
                case ePermisos.Drivers:
                    return (sender, e) => { pmsBtn_Click<pantallaActualizarDrivers>(sender, e, btn, img, panelMenu, cont); };
                case ePermisos.ActualizarBD: 
                    return (sender, e) => { pmsBtn_Click<pantallaActualizarBD>(sender, e, btn, img, panelMenu, cont); };
                case ePermisos.Sedes:
                    return (sender, e) => { pmsBtn_Click<pantallaActualizarSedes>(sender, e, btn, img, panelMenu, cont); };
                case ePermisos.Servicios:
                    return (sender, e) => { pmsBtn_Click<pantallaActualizarServicios>(sender, e, btn, img, panelMenu, cont); };
                case ePermisos.Usuarios:
                    return (sender, e) => { pmsBtn_Click<pantallaActualizarUsuarios>(sender, e, btn, img, panelMenu, cont); };
                case ePermisos.Vehiculos:
                    return (sender, e) => { pmsBtn_Click<pantallaActualizarVehiculos>(sender, e, btn, img, panelMenu, cont); };
                default:
                    return (sender, e) => { pmsBtn_Click<pantallaActualizarBD>(sender, e, btn, img, panelMenu, cont); };
            }
        }

        // Metodo genérico para el click de los botones creados dinámicamente que cambiará de pantalla según la clase T enviada
        public static void pmsBtn_Click<T>(object sender, EventArgs e, Button btnMenu, Image img, Panel panelMenu, ContenedorPantalla cont)
        {
            cambiarColoresBotonesMenu((RoundedPanel)btnMenu.Parent, panelMenu);
            cont.PantallaActual = (Pantalla)Activator.CreateInstance(typeof(T));

            // Cambiar el icono del boton para que sea el enviado
            btnMenu.BackgroundImage = img;
            if (sender.GetType() == typeof(PanelMenuStrip))
            {
                PanelMenuStrip pms = (PanelMenuStrip)sender;
                pms.Visible = false;
            }
        }

        // Cambia los colores del PanelMenu excepto del seleccionado
        public static void cambiarColoresBotonesMenu(RoundedPanel rp, Panel panelMenu)
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
            rp.ColorPanel = Colores.BackBackground;
        }

        // Cambia el color de un RoundPanel del Menu Lateral, y devuelve la imagen de los botones no seleccionados
        // a su imagen regular
        public static void cambiarRPMenu(RoundedPanel rp)
        {
            rp.ColorPanel = Color.Transparent;
            foreach (Control btn in rp.Controls)
            {
                // Solo hay un boton, el que contiene la imagen
                btn.BackColor = Color.Transparent;

                // Devolver la imagen normal a los otros botones
                switch (btn.Name)
                {
                    case "btnMenuInformacion":
                        btn.BackgroundImage = (Image)new Bitmap(Resources.Informacion, new Size(36, 36));
                        break;
                    case "btnMenuConfiguracion":
                        btn.BackgroundImage = (Image)new Bitmap(Resources.Configuracion, new Size(36, 36));
                        break;
                }
            }
        }
        public static void personalizarItemLista(itemLista il, int height = 81)
        {
            il.Anchor = AnchorStyles.Top;
            il.BackColor = Color.Transparent;
            il.ColorBack = Color.Transparent;
            il.ColorBorde = Colores.PrincipalAzulMetalico;
            il.ColorPanel = Colores.BackBackground;
            il.Margin = new Padding(4);
            il.SizeItem = new Size(497, height);
        }

        public static void personalizarItemListaCuadrado(itemListaCuadrado il, Image img)
        {
            il.imgFondo = Resources.AreaTrabajo;
            il.Location = new System.Drawing.Point(3, 3);
            il.Size = new System.Drawing.Size(106, 85);
        }
        public static void agregarImgFondo(ePermisos? e, itemListaCuadrado il)
        {
            switch (e)
            {
                case ePermisos.All:
                    il.imgFondo = Resources.Estadisticas;
                    return;
                case ePermisos.ActualizarBD:
                    il.imgFondo = Resources.BaseDatos;
                    return;
                case ePermisos.AreasTrabajo:
                    il.imgFondo = Resources.AreaTrabajo;
                    return;
                case ePermisos.Clientes:
                    il.imgFondo = Resources.Clientes;
                    return;
                case ePermisos.Drivers:
                    il.imgFondo = Resources.Driver;
                    return;
                case ePermisos.Empresa:
                    il.imgFondo = Resources.Empresa;
                    return;
                case ePermisos.Sedes:
                    il.imgFondo = Resources.Sede;
                    return;
                case ePermisos.Servicios:
                    il.imgFondo = Resources.Servicio;
                    return;
                case ePermisos.Usuarios:
                    il.imgFondo = Resources.Usuarios;
                    return;
                case ePermisos.Vehiculos:
                    il.imgFondo = Resources.Vehiculo;
                    return;
            }
        }
    }
}
