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
import pe.com.megaautos.dao.CuentaContableDAO;
import pe.com.megaautos.model.CuentaContable;

/**
 *
 * @author Jose
 */
public class CuentaContableMySQL implements CuentaContableDAO{
    Connection con;
    @Override
    public int insertar(CuentaContable cuentaContable) {
         int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_CUENTA_CONTABLE(?,?,?,?)}");
            // Insertar CuentaContable recibirá el nombre y los montos ingresos
            // y egresos, devolvera id
            cs.registerOutParameter("_ID_CUENTA_CONTABLE", java.sql.Types.INTEGER);
            // TODO AL NOMBRE AGREGARLE SACAPALABRAS QUE BORRE LOS DOBLE ESPACIOS
            cs.setString("_NOMBRE", cuentaContable.getNombre().toUpperCase());
            cs.setDouble("_MONTO_INGRESOS",cuentaContable.getMontoIngresos());
            cs.setDouble("_MONTO_EGRESOS",cuentaContable.getMontoEgresos());
            cs.executeUpdate();
            rpta = cs.getInt("_ID_CUENTA_CONTABLE");
            con.close();
            // Actualiza el ID de la cuentaContable insertada para tenerla en Java
            cuentaContable.setId(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }
         return rpta;
    }

    @Override
    public int actualizar(CuentaContable cuentaContable) {
         int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);
            CallableStatement cs = con.prepareCall(
                    "{call ACTUALIZAR_CUENTA_CONTABLE(?,?,?,?)}");
            cs.setInt("_ID_CUENTA_CONTABLE", cuentaContable.getId());
            cs.setString("_NOMBRE", cuentaContable.getNombre().toUpperCase());
            cs.setDouble("_MONTO_INGRESOS",cuentaContable.getMontoIngresos());
            cs.setDouble("_MONTO_EGRESOS",cuentaContable.getMontoEgresos());
            cs.executeUpdate();
            con.close();
        }catch(Exception ex){
             System.out.println(ex.getMessage());
             rpta = 1;
        }
         return rpta;
    }

    @Override
    public int eliminar(int idCuentaContable) {
         int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);
            CallableStatement cs = con.prepareCall(
                    "{call ELIMINAR_CUENTA_CONTABLE(?)}");
            cs.setInt("_ID_CUENTA_CONTABLE", idCuentaContable);
            cs.executeUpdate();
            con.close();
        }catch(Exception ex){
             System.out.println(ex.getMessage());
             rpta = 1;
        }
         return rpta;
    }

    @Override
    public ArrayList<CuentaContable> listar() {
        ArrayList<CuentaContable> cuentaContables = new ArrayList<>();
        try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Listar cuentaContable devuelve una lista de cuentaContables
            // con ID_CuentaContable, nombre y monto ingresos y egresos
            CallableStatement cs = con.prepareCall(
                    "{call LISTAR_CUENTA_CONTABLE()}");
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                CuentaContable cuentaContable = new CuentaContable();
                cuentaContable.setId(rs.getInt("ID_CUENTA_CONTABLE"));
                cuentaContable.setNombre(rs.getString("NOMBRE"));
                cuentaContable.setMontoIngresos(rs.getDouble("MONTO_INGRESOS"));
                cuentaContable.setMontoEgresos(rs.getDouble("MONTO_EGRESOS"));
                cuentaContables.add(cuentaContable);
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        //Devolviendo las cuentas 
        return cuentaContables;    
    }

    @Override
    public CuentaContable buscar(int idCuentaContable) {
       CuentaContable cuentaContable = new CuentaContable();
        try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            CallableStatement cs = con.prepareCall(
                    "{call BUSCAR_CUENTA_CONTABLE(?)}");
            cs.setInt("_ID_CUENTA_CONTABLE", idCuentaContable);
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                cuentaContable.setId(idCuentaContable);
                cuentaContable.setMontoEgresos(rs.getDouble("MONTO_EGRESOS"));
                cuentaContable.setMontoIngresos(rs.getDouble("MONTO_INGRESOS"));
                cuentaContable.setNombre(rs.getString("NOMBRE"));
                // TODO cuentaContable.setOrdenesTrabajo(ordenesTrabajo);
                // Al parecer sería bucar en OTxCC igual a idOT, idCC
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return cuentaContable;
    }
    
}
    