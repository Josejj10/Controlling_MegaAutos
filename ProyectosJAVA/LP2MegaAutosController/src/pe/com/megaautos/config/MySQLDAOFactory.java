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
import pe.com.megaautos.mysql.AreaTrabajoCuentaContableMySQL;
import pe.com.megaautos.mysql.AreaTrabajoMySQL;
import pe.com.megaautos.mysql.ClienteMySQL;
import pe.com.megaautos.mysql.ComprobantePagoMySQL;
import pe.com.megaautos.mysql.CuentaContableMySQL;
import pe.com.megaautos.mysql.DriverMySQL;
import pe.com.megaautos.mysql.EmpresaMySQL;
import pe.com.megaautos.mysql.ExcelMySQL;
import pe.com.megaautos.mysql.OrdenTrabajoMySQL;
import pe.com.megaautos.mysql.SedeMySQL;
import pe.com.megaautos.mysql.ServicioMySQL;
import pe.com.megaautos.mysql.UsuarioMySQL;
import pe.com.megaautos.mysql.VehiculoMySQL;


public class MySQLDAOFactory extends DAOFactory{

    @Override
    public AreaTrabajoCuentaContableDAO getAreaTrabajoCuentaContableDAO() {
        return new AreaTrabajoCuentaContableMySQL();
    }

    @Override
    public AreaTrabajoDAO getAreaTrabajoDAO() {
        return new AreaTrabajoMySQL();
    }

    @Override
    public ClienteDAO getClienteDAO() {
        return new ClienteMySQL();
    }

    @Override
    public ComprobantePagoDAO getComprobantePagoDAO() {
        return new ComprobantePagoMySQL();
    }

    @Override
    public CuentaContableDAO getCuentaContableDAO() {
        return new CuentaContableMySQL();
    }

    @Override
    public DriverDAO getDriverDAO() {
        return new DriverMySQL();
    }

    @Override
    public EmpresaDAO getEmpresaDAO() {
        return new EmpresaMySQL();
    }

    @Override
    public OrdenTrabajoDAO getOrdenTrabajoDAO() {
        return new OrdenTrabajoMySQL();
    }

    @Override
    public SedeDAO getSedeDAO() {
        return new SedeMySQL();
    }

    @Override
    public ServicioDAO getServicioDAO() {
        return new ServicioMySQL();
    }

    @Override
    public UsuarioDAO getUsuarioDAO() {
        return new UsuarioMySQL();
    }

    @Override
    public VehiculoDAO getVehiculoDAO() {
        return new VehiculoMySQL();
    }
    
    @Override
    public ExcelDAO getExcelDAO(){
        return new ExcelMySQL();
    }
}