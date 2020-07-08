/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import joinery.DataFrame;
import pe.com.megaautos.config.DBDataSource;
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
           con = DBDataSource.getConnection();/*
           Class.forName("com.mysql.cj.jdbc.Driver");
           //Establecer la conexion
           con = DriverManager.getConnection(DBManager.url, 
                   DBManager.user, DBManager.password);*/
           CallableStatement cs = con.prepareCall(
                   "{call INSERTAR_AREA_TRABAJO(?,?,?,?)}");
           // Insertar AreaTrabajo recibirá el nombre, el total de ingresos 
           // y de egresos. Devolvera el id
           cs.registerOutParameter("_ID_AREA_TRABAJO", java.sql.Types.INTEGER);
           // TODO AL NOMBRE AGREGARLE SACAPALABRAS QUE BORRE LOS DOBLE ESPACIOS
           cs.setString("_NOMBRE", areaTrabajo.getNombre().toUpperCase());
           cs.setDouble("_TOTAL_INGRESOS", areaTrabajo.getTotalIngresos());
           cs.setDouble("_TOTAL_EGRESOS", areaTrabajo.getTotalEgresos());
           cs.executeUpdate();
           rpta = cs.getInt("_ID_AREA_TRABAJO");
           // Actualiza el ID del area de trabajo insertada para tenerlo en Java
           areaTrabajo.setId(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }
        finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
         return rpta;
    }

    @Override
    public int actualizar(AreaTrabajo areaTrabajo) {
        int rpta = 0;
        try{
            //Registrar el JAR de conexión
            con = DBDataSource.getConnection();/*
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);*/
            CallableStatement cs = con.prepareCall(
                    "{call ACTUALIZAR_AREA_TRABAJO(?,?)}");
            cs.setInt("_ID_AREA_TRABAJO", areaTrabajo.getId());
            cs.setString("_NOMBRE", areaTrabajo.getNombre().toUpperCase());
            cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            rpta = 1;
        }
        finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
         return rpta;
    }

    @Override
    public int eliminar(int idAreaTrabajo) {
        int rpta = 0;
        try{
            //Registrar el JAR de conexión
            con = DBDataSource.getConnection();/*
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);*/
            CallableStatement cs = con.prepareCall(
                    "{call ELIMINAR_AREA_TRABAJO(?)}");
            cs.setInt("_ID_AREA_TRABAJO", idAreaTrabajo);
            cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            rpta = 1;
        }
        finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
         return rpta;
    }

    @Override
    public ArrayList<AreaTrabajo> listar() {
        ArrayList<AreaTrabajo> areaTrabajos = new ArrayList<>();
        try{
            //Registrar el JAR de conexión
            con = DBDataSource.getConnection();/*
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Listar areaTrabajo devuelve una lista de areaTrabajos
            // con ID_AreaTrabajo, nombre, total ingresos y egresos*/
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
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        //Devolviendo las areas de trabajo
        return areaTrabajos;    
    }
    
    @Override 
    public AreaTrabajo buscar(int idAreaTrabajo){
        AreaTrabajo areaTrabajo = new AreaTrabajo();
        try{
            //Registrar el JAR de conexión
            con = DBDataSource.getConnection();/*
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);*/
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
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return areaTrabajo;
    }
    
    @Override
    public void guardarBatch(DataFrame df){
        try{
            con = DBDataSource.getConnection();
            PreparedStatement st = con.prepareStatement("{CALL INSERTAR_AREA_TRABAJO_DF(?,?,?)}");
            for (int r = 0; r < df.length(); r++) {
                for (int c = 1; c <= df.size(); c++) {
                    st.setObject(c, df.get(r, c - 1));
                }
                st.addBatch();
            }
            st.executeBatch();
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
    }
}

