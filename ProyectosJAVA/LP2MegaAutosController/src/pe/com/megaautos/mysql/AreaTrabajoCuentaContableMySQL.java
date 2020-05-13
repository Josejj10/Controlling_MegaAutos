/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.com.megaautos.config.DBManager;
import pe.com.megaautos.dao.AreaTrabajoCuentaContableDAO;
import pe.com.megaautos.dao.AreaTrabajoDAO;
import pe.com.megaautos.dao.CuentaContableDAO;
import pe.com.megaautos.dao.DriverDAO;
import pe.com.megaautos.model.AreaTrabajo;
import pe.com.megaautos.model.AreaTrabajoCuentaContable;
import pe.com.megaautos.model.CuentaContable;
import pe.com.megaautos.model.Driver;

/**
 *
 * @author Jose
 */
public class AreaTrabajoCuentaContableMySQL implements AreaTrabajoCuentaContableDAO {
    Connection con;
    @Override
    public void insertar(AreaTrabajoCuentaContable atCc) {
        int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_AREA_TRABAJO_X_CUENTA_CONTABLE(?,?,?)}");
            // Insertar AreaTrabajoCuentaContable recibirá 
            // Id area trabajo, Id cuentacontable e IdDriver  
            // Y no devolvera nada 
            cs.setInt("_ID_AREA_TRABAJO", atCc.getAreaTrabajo().getId());
            cs.setInt("_ID_CUENTA_CONTABLE", atCc.getCuentaContable().getId());
            cs.setInt("_ID_DRIVER", atCc.getDriver().getId());
            cs.setDouble("_DISTRIBUCION_INGRESOS", atCc.getDistribucionIngresos());
            cs.setDouble("_DISTRIBUCION_EGRESOS", atCc.getDistribucionEgresos());
            cs.executeUpdate();
            con.close();
         
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }
    }


    @Override
    public int actualizar(AreaTrabajoCuentaContable atCc) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idAtCc) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<AreaTrabajoCuentaContable> listar() {
        ArrayList<AreaTrabajoCuentaContable> atCcs = new ArrayList<>();
        try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Listar atCc devuelve una lista de atCcs
            // con ID_AreaTrabajoCuentaContable, nombre, tipo_atCc, tipo_doc
            // numero_doc, correo y telefono
            CallableStatement cs = con.prepareCall(
                    "{call LISTAR_AREA_TRABAJO_X_CUENTA_CONTABLE()}");
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                AreaTrabajoCuentaContable atCc = new AreaTrabajoCuentaContable();
                atCc.setId(rs.getInt("ID_AREA_TRABAJO_X_CUENTA_CONTABLE"));
                atCc.setDistribucionEgresos(rs.getInt("DISTRIBUCION_EGRESOS"));
                atCc.setDistribucionIngresos(rs.getInt("DISTRIBUCION_INGRESOS"));
                // Insertar AreaTrabajo
                AreaTrabajoDAO daoAT = new AreaTrabajoMySQL();
                AreaTrabajo at = daoAT.buscar(rs.getInt("ID_AREA_TRABAJO"));
                atCc.setAreaTrabajo(at);
                // Insertar CuentaContable
                CuentaContableDAO daoCC = new CuentaContableMySQL();
                CuentaContable cC = daoCC.buscar(rs.getInt("ID_CUENTA_CONTABLE"));
                atCc.setCuentaContable(cC);
                // Insertar Driver
                DriverDAO daoDriver = new DriverMySQL();
                Driver driver = daoDriver.buscar(rs.getInt("ID_DRIVER"));
                atCc.setDriver(driver);
                atCcs.add(atCc);
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        //Devolviendo los vehiculos
        return atCcs;    
    }
    
}
