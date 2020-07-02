package pe.com.megaautos.config;

import pe.com.megaautos.dao.AreaTrabajoCuentaContableDAO;
import pe.com.megaautos.dao.AreaTrabajoDAO;
import pe.com.megaautos.dao.ClienteDAO;
import pe.com.megaautos.dao.ComprobantePagoDAO;
import pe.com.megaautos.dao.CuentaContableDAO;
import pe.com.megaautos.dao.DriverDAO;
import pe.com.megaautos.dao.EmpresaDAO;
import pe.com.megaautos.dao.ExcelDAO;
import pe.com.megaautos.dao.OrdenTrabajoDAO;
import pe.com.megaautos.dao.SedeDAO;
import pe.com.megaautos.dao.ServicioDAO;
import pe.com.megaautos.dao.UsuarioDAO;
import pe.com.megaautos.dao.VehiculoDAO;

public abstract class DAOFactory {

    public static DAOFactory getDAOFactory(){
        if(DBManager.url.contains("mysql")){
            return new MySQLDAOFactory();
        }
        else if(DBManager.url.contains("sqlserver")){
            return new MSSQLFactory();
        }
        return null;
    }
    
    public abstract AreaTrabajoCuentaContableDAO getAreaTrabajoCuentaContableDAO();
    public abstract AreaTrabajoDAO getAreaTrabajoDAO();
    public abstract ClienteDAO getClienteDAO();
    public abstract ComprobantePagoDAO getComprobantePagoDAO();
    public abstract CuentaContableDAO getCuentaContableDAO();
    public abstract DriverDAO getDriverDAO();
    public abstract EmpresaDAO getEmpresaDAO();
    public abstract OrdenTrabajoDAO getOrdenTrabajoDAO();
    public abstract SedeDAO getSedeDAO();
    public abstract ServicioDAO getServicioDAO();
    public abstract UsuarioDAO getUsuarioDAO();
    public abstract VehiculoDAO getVehiculoDAO();
    public abstract ExcelDAO getExcelDAO();
}
