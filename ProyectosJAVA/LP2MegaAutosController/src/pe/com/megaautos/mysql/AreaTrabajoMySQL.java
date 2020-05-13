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
import pe.com.megaautos.dao.AreaTrabajoDAO;
import pe.com.megaautos.model.AreaTrabajo;

/**
 *
 * @author Jose
 */
public class AreaTrabajoMySQL implements AreaTrabajoDAO {
    Connection con;
    @Override
    public int insertar(AreaTrabajo areaTrabajo) {
        int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_AREA_TRABAJO(?,?,?,?)}");
            // Insertar AreaTrabajo recibirá el nombre, el tipo de areaTrabajo
            // el tipo de documento, el numDocumento, el correo y telefono
            // En el procedure de MySQL, cambiara el nombre del tipo vehiculo
            // Por su id, para poder insertarlo en la tabla 
            cs.registerOutParameter("_ID_AREA_TRABAJO", java.sql.Types.INTEGER);
            // TODO AL NOMBRE AGREGARLE SACAPALABRAS QUE BORRE LOS DOBLE ESPACIOS
            cs.setString("_NOMBRE", areaTrabajo.getNombre().toUpperCase());
            cs.setDouble("_TOTAL_INGRESOS", areaTrabajo.getTotalIngresos());
            cs.setDouble("_TOTAL_EGRESOS", areaTrabajo.getTotalEgresos());
            cs.executeUpdate();
            rpta = cs.getInt("_ID_AREA_TRABAJO");
            con.close();
            // Actualiza el ID del vehiculo insertado para tenerlo en Java
            areaTrabajo.setId(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }
         return rpta;
    }

    @Override
    public int actualizar(AreaTrabajo areaTrabajo) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idAreaTrabajo) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<AreaTrabajo> listar() {
        ArrayList<AreaTrabajo> areaTrabajos = new ArrayList<>();
        try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Listar areaTrabajo devuelve una lista de areaTrabajos
            // con ID_AreaTrabajo, nombre, tipo_areaTrabajo, tipo_doc
            // numero_doc, correo y telefono
            CallableStatement cs = con.prepareCall(
                    "{call LISTAR_AREA_TRABAJO()}");
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                AreaTrabajo areaTrabajo = new AreaTrabajo();
                areaTrabajo.setId(rs.getInt("ID_AREA_TRABAJO"));
                areaTrabajo.setNombre(rs.getString("NOMBRE"));
                areaTrabajo.setTotalIngresos(rs.getDouble("TOTAL_INGRESOS"));
                areaTrabajo.setTotalEgresos(rs.getDouble("TOTAL_EGRESOS"));
                areaTrabajos.add(areaTrabajo);
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        //Devolviendo los vehiculos
        return areaTrabajos;    
    }
    
    @Override 
    public AreaTrabajo buscar(int idAreaTrabajo){
        AreaTrabajo areaTrabajo = new AreaTrabajo();
        try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Llama a un select * from cliente where ID_CLIENTE = id
            CallableStatement cs = con.prepareCall(
                    "{call BUSCAR_AREA_TRABAJO(?)}");
            cs.setInt("_ID_AREA_TRABAJO", idAreaTrabajo);
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                areaTrabajo.setId(idAreaTrabajo);
                areaTrabajo.setTotalEgresos(rs.getDouble("TOTAL_EGRESOS"));
                areaTrabajo.setTotalIngresos(rs.getDouble("TOTAL_INGRESOS"));
                areaTrabajo.setNombre(rs.getString("NOMBRE"));
                // TODO, ver como hacer con AreaTrabajoxCuentaContable
                // Probablemente tambien habria que buscar, pero quiza tenga 
                // DeadLock porque ATxCC busca una AT y esta busca sus ATxCC
                // Pero buscar ATxCC va a buscar su AT
                // Idea, podria ser solo con ID pero igual necesita sus ATxCC
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return areaTrabajo;
    }
}

