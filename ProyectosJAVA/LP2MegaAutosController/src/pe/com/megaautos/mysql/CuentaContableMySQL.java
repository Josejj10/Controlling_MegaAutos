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
import java.util.HashSet;
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
            // Insertar CuentaContable recibirá el nombre, el tipo de cuentaContable
            // el tipo de documento, el numDocumento, el correo y telefono
            // En el procedure de MySQL, cambiara el nombre del tipo vehiculo
            // Por su id, para poder insertarlo en la tabla 
            cs.registerOutParameter("_ID_CUENTA_CONTABLE", java.sql.Types.INTEGER);
            // TODO AL NOMBRE AGREGARLE SACAPALABRAS QUE BORRE LOS DOBLE ESPACIOS
            cs.setString("_NOMBRE", cuentaContable.getNombre().toUpperCase());
            cs.setDouble("MONTO_INGRESOS",cuentaContable.getMontoIngresos());
            cs.setDouble("MONTO_EGRESOS",cuentaContable.getMontoEgresos());
            cs.executeUpdate();
            rpta = cs.getInt("_ID_CUENTA_CONTABLE");
            con.close();
            // Actualiza el ID del vehiculo insertado para tenerlo en Java
            cuentaContable.setId(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }
         return rpta;
    }

    @Override
    public int actualizar(CuentaContable cuentaContable) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idCuentaContable) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
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
            // con ID_CuentaContable, nombre, tipo_cuentaContable, tipo_doc
            // numero_doc, correo y telefono
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
        //Devolviendo los vehiculos
        return cuentaContables;    
    }
    
}
    