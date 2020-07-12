using LP2MegaAutos.Properties;
using LP2MegaAutos.ServicioUsuario;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace LP2MegaAutos.Framework.UserControls.Items
{
    public static class itemListaHelper
    {
        public static void rpItem_MouseEnter(RoundedPanel rpItem, bool colorFront = true)
        {
            cambiarColores(rpItem, colorFront? Colores.FrontBackground: Colores.LowContrast);
            rpItem.ColorPanel = colorFront? Colores.FrontBackground : Colores.LowContrast;
        }

        public static void rpItem_MouseLeave(RoundedPanel rpItem)
        {
            cambiarColores(rpItem, Colores.BackBackground);
            rpItem.ColorPanel = Colores.BackBackground;
        }

        private static void cambiarColores(Control parent, Color color)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Controls != null) cambiarColores(c, color);
                c.BackColor = color;
            }
        }

        public static string recibirDescripcionPermisos(ePermisos? e)
        {
            string titulo = "";
            string des = "";
            switch (e)
            {
                case ePermisos.ActualizarBD:
                    titulo = "Actualizar Base de Datos";
                    des = "Permite subir Excel con los datos del sistema de Transaccional y Contable.";
                    break;
                case ePermisos.AreasTrabajo:
                    titulo = "Areas de Trabajo";
                    des = "Permite ver, editar, eliminar y agregar Áreas de Trabajo.";
                    break;
                case ePermisos.Clientes:
                    titulo = "Clientes";
                    des = "Permite ver, editar, eliminar y agregar Clientes.";
                    break;
                case ePermisos.Drivers:
                    titulo = "Drivers";
                    des = "Permite ver, editar, eliminar y agregar Drivers.";
                    break;
                case ePermisos.Empresa:
                    titulo = "Empresa";
                    des = "Permite editar el nombre de la Empresa.";
                    break;
                case ePermisos.Sedes:
                    titulo = "Sedes";
                    des = "Permite ver, editar, eliminar y agregar Sedes a la Empresa.";
                    break;
                case ePermisos.Servicios:
                    titulo = "Servicios";
                    des = "Permite ver, editar, eliminar y agregar Servicios que brinda la Empresa.";
                    break;
                case ePermisos.Usuarios:
                    titulo = "Usuarios";
                    des = "Permite ver, editar, eliminar y agregar Usuarios al sistema.";
                    break;
                case ePermisos.Vehiculos:
                    titulo = "Vehiculos";
                    des = "Permite ver, editar, eliminar y agregar Vehículos asociados con un cliente.";
                    break;
            }
            return  titulo + "|"+des;
        }

        public static Image imagenPermisos(ePermisos? e)
        {
            switch (e)
            {
                case ePermisos.ActualizarBD:
                    return Resources.BaseDatos;
                case ePermisos.AreasTrabajo:
                    return Resources.AreaTrabajo;
                case ePermisos.Clientes:
                    return Resources.Clientes;
                case ePermisos.Drivers:
                    return Resources.Driver;
                case ePermisos.Empresa:
                    return Resources.Empresa;
                case ePermisos.Sedes:
                    return Resources.Sede;
                case ePermisos.Servicios:
                    return Resources.Servicio;
                case ePermisos.Usuarios:
                    return Resources.Usuario;
                case ePermisos.Vehiculos:
                    return Resources.Vehiculo;
            }
            return Resources.editar;
        }

    }
}
