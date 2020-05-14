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
import pe.com.megaautos.dao.DriverDAO;
import pe.com.megaautos.model.Driver;

/**
 *
 * @author Jose
 */
public class DriverMySQL implements DriverDAO {
    Connection con;
    @Override
    public int insertar(Driver driver) {
        int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_DRIVER(?,?)}");
            // Insertar Driver recibirá la formula del driver
            cs.registerOutParameter("_ID_DRIVER", java.sql.Types.INTEGER);
            cs.setDouble("_DRIVER", driver.getFormula());
            cs.executeUpdate();
            rpta = cs.getInt("_ID_DRIVER");
            con.close();
            // Actualiza el ID del driver insertado para tenerlo en Java
            driver.setId(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }
         return rpta;
    }

    @Override
    public int actualizar(Driver driver) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idDriver) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Driver> listar() {
        ArrayList<Driver> drivers = new ArrayList<>();
        try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Listar driver devuelve una lista de drivers
            // con ID_Driver y el valor, que es la formula
            CallableStatement cs = con.prepareCall(
                    "{call LISTAR_DRIVER()}");
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                Driver driver = new Driver();
                driver.setId(rs.getInt("ID_DRIVER"));
                driver.setFormula(rs.getDouble("VALOR"));
                drivers.add(driver);
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        //Devolviendo los drivers
        return drivers;
    }

    @Override
    public Driver buscar(int idDriver) {
        Driver driver = new Driver();
        try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            CallableStatement cs = con.prepareCall(
                    "{call BUSCAR_DRIVER(?)}");
            cs.setInt("_ID_DRIVER", idDriver);
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                driver.setId(idDriver);
                driver.setFormula(rs.getDouble("VALOR"));
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return driver;
    }
    
}
