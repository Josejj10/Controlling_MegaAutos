using LP2MegaAutos.VentanasPrincipales;
using System.Collections;
using System.ComponentModel;

namespace LP2MegaAutos
{
    public class Usuario
    {
        private string _correo;
        private BindingList<EPermisos> _permisos;

        public Usuario()
        {
          //  this.Permisos = new BindingList<EPermisos>();
        }

        public string Correo { get => _correo; set => _correo = value; }
        //public BindingList<EPermisos> Permisos { get => _permisos; set => _permisos = value; }

        public void agregarPermiso(EPermisos permiso)
        {
            //Permisos.Add(permiso);   
            // TODO Agregar permiso a la BD
        }

        public int quitarPermiso(EPermisos permiso)
        {
            //if (Permisos.Contains(permiso))
              //  Permisos.Remove(permiso);
            //else
                return 0;
            
            // TODO Quitar permiso de la BD

            //return 1;
        }

    }
}