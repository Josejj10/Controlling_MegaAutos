using System;

namespace LP2MegaAutos.VentanasPrincipales
{   
    [Flags]
    public enum EPermisos
    {
        AreasTrabajo = 1,
        Clientes = 2,
        Vehiculos = 4,
        Drivers = 8 ,
        Usuarios = 16,
        Servicios = 32,
        Sedes = 64,
        Empresa = 128,
        ActualizarBD =256,
        All = 511
    }
}
