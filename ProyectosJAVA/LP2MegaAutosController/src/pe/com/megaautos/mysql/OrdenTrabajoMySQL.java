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
import java.util.List;
import pe.com.megaautos.config.DBDataSource;
import pe.com.megaautos.config.DBManager;
import pe.com.megaautos.dao.ClienteDAO;
import pe.com.megaautos.dao.OrdenTrabajoDAO;
import pe.com.megaautos.dao.SedeDAO;
import pe.com.megaautos.dao.VehiculoDAO;
import pe.com.megaautos.model.OrdenTrabajo;

/**
 *
 * @author Jose
 */
public class OrdenTrabajoMySQL implements OrdenTrabajoDAO{
    Connection con;
    
    // Seria ideal recibir una lista de ordenes Trabajo sacada del DF 
    // pero si no pueden transformarlo, cambiar los parametros para recibir un
    // DF o como prefieran, pero para eficiencia es mejor solo recibir una lista
    // Replicar para las demas wbds que quieran guardar
    @Override
    public void guardarBatch(List<OrdenTrabajo> ordenesTrabajo){
        try{
            Connection con = DBDataSource.getConnection();
            PreparedStatement st = con.prepareStatement("");
            int i = 0;
            //for(OrdenTrabajo ordenTrabajo : ordenesTrabajo){
            // st.setString(indexParametro, ordenTrabajo.getAlgo);
            //st.addBatch();
            //i++
            // if(i%1000 ==0 || i == ordenesTrabajo.size()){
            // st.executeBatch();
            
        }catch(Exception e){
            System.out.println(e);
        }
    }
    
    @Override
    public int insertar(OrdenTrabajo ordenTrabajo) {
        int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Connection con = DBDataSource.getConnection();/*
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);*/
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_ORDEN_TRABAJO(?,?,?,?,?,?,?,?)}");
            // Insertar OrdenTrabajo recibirá el numeroOT, la fecha,
            // el total de ingresos y de egresos, y los id de sede, cliente y 
            // vehiculo
            cs.registerOutParameter("_ID_ORDEN_TRABAJO", java.sql.Types.INTEGER);
            // TODO AL NOMBRE AGREGARLE SACAPALABRAS QUE BORRE LOS DOBLE ESPACIOS
            cs.setString("_NUMERO_OT", ordenTrabajo.getNumeroOrden().toUpperCase());
            java.sql.Date fechaSql = 
                    new java.sql.Date(ordenTrabajo.getFecha().getTime());
            cs.setDate("_FECHA",fechaSql);
            cs.setDouble("_TOTAL_INGRESOS",ordenTrabajo.getTotalIngresos());
            cs.setDouble("_TOTAL_EGRESOS",ordenTrabajo.getTotalEgresos());
            cs.setInt("_ID_SEDE",ordenTrabajo.getSede().getId());
            cs.setInt("_ID_CLIENTE",ordenTrabajo.getCliente().getId());
            cs.setInt("_ID_VEHICULO",ordenTrabajo.getVehiculo().getId());
            cs.executeUpdate();
            rpta = cs.getInt("_ID_ORDEN_TRABAJO");
            con.close();
            // Actualiza el ID de la OT insertado para tenerlo en Java
            ordenTrabajo.setId(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }
         return rpta;
    }

    @Override
    public int actualizar(OrdenTrabajo ordenTrabajo) {
        int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Connection con = DBDataSource.getConnection();/*
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);*/
            CallableStatement cs = con.prepareCall(
                    "{call ACTUALIZAR_ORDEN_TRABAJO(?,?,?,?,?,?,?,?)}");
            cs.setInt("_ID_ORDEN_TRABAJO", ordenTrabajo.getId());
            cs.setString("_NUMERO_OT", ordenTrabajo.getNumeroOrden().toUpperCase());
            java.sql.Date fechaSql = 
                    new java.sql.Date(ordenTrabajo.getFecha().getTime());
            cs.setDate("_FECHA",fechaSql);
            cs.setDouble("_TOTAL_INGRESOS",ordenTrabajo.getTotalIngresos());
            cs.setDouble("_TOTAL_EGRESOS",ordenTrabajo.getTotalEgresos());
            cs.setInt("_ID_SEDE",ordenTrabajo.getSede().getId());
            cs.setInt("_ID_CLIENTE",ordenTrabajo.getCliente().getId());
            cs.setInt("_ID_VEHICULO",ordenTrabajo.getVehiculo().getId());
            cs.executeUpdate();
            con.close();            
        }catch(Exception ex){
             System.out.println(ex.getMessage());
             rpta = 1;
        }
         return rpta;
    }

    @Override
    public int eliminar(int idOrdenTrabajo) {
        int rpta = 0;
         try{             
            Connection con = DBDataSource.getConnection();/*
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);*/
            CallableStatement cs = con.prepareCall(
                    "{call ACTUALIZAR_ORDEN_TRABAJO(?)}");
            cs.setInt("_ID_ORDEN_TRABAJO", idOrdenTrabajo);
            cs.executeUpdate();
            con.close();            
        }catch(Exception ex){
             System.out.println(ex.getMessage());
             rpta = 1;
        }
         return rpta;
    }

    @Override
    public ArrayList<OrdenTrabajo> listar() {
        ArrayList<OrdenTrabajo> ordenTrabajos = new ArrayList<>();
        try{            
            Connection con = DBDataSource.getConnection();/*
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);*/
            // Listar ordenTrabajo devuelve una lista de ordenTrabajos
            // con id, fecha, total de ingresos y egresos,
            // y busca la Sede, Cliente y Vehiculo en la BD
            CallableStatement cs = con.prepareCall(
                    "{call LISTAR_ORDEN_TRABAJO()}");
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                OrdenTrabajo ordenTrabajo = new OrdenTrabajo();
                ordenTrabajo.setId(rs.getInt("ID_ORDEN_TRABAJO"));
                ordenTrabajo.setFecha(rs.getDate("FECHA"));
                ordenTrabajo.setNumeroOrden(rs.getString("NUMERO_OT"));
                ordenTrabajo.setTotalIngresos(rs.getDouble("TOTAL_INGRESOS"));
                ordenTrabajo.setTotalEgresos(rs.getDouble("TOTAL_EGRESOS"));
                ClienteDAO daoCliente =
                        new ClienteMySQL();
                SedeDAO daoSede =
                        new SedeMySQL();
                VehiculoDAO daoVehiculo =
                        new VehiculoMySQL();
                ordenTrabajo.setSede(daoSede.buscar(rs.getInt("ID_SEDE")));
                ordenTrabajo.setCliente(daoCliente.buscar(rs.getInt("ID_CLIENTE")));
                ordenTrabajo.setVehiculo(daoVehiculo.buscar(rs.getInt("ID_VEHICULO")));
                ordenTrabajos.add(ordenTrabajo);
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        //Devolviendo las Ordenes de Trabajo
        return ordenTrabajos;    
    }

    @Override
    public OrdenTrabajo buscar(int idOrdenTrabajo) {
        OrdenTrabajo ordenTrabajo = new OrdenTrabajo();
        try{
            //Registrar el JAR de conexión
            Connection con = DBDataSource.getConnection();/*
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Llama a un select * from ordenTrabajo where ID_ORDEN_TRABAJO = id*/
            CallableStatement cs = con.prepareCall(
                    "{call BUSCAR_ORDEN_TRABAJO(?)}");
            cs.setInt("_ID_ORDEN_TRABAJO", idOrdenTrabajo);
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                ordenTrabajo.setId(rs.getInt("ID_ORDEN_TRABAJO"));
                ordenTrabajo.setFecha(rs.getDate("FECHA"));
                ordenTrabajo.setNumeroOrden(rs.getString("NUMERO_OT"));
                ordenTrabajo.setTotalIngresos(rs.getDouble("TOTAL_INGRESOS"));
                ordenTrabajo.setTotalEgresos(rs.getDouble("TOTAL_EGRESOS"));
                ClienteDAO daoCliente =
                        new ClienteMySQL();
                SedeDAO daoSede =
                        new SedeMySQL();
                VehiculoDAO daoVehiculo =
                        new VehiculoMySQL();
                ordenTrabajo.setSede(daoSede.buscar(rs.getInt("ID_SEDE")));
                ordenTrabajo.setCliente(daoCliente.buscar(rs.getInt("ID_CLIENTE")));
                ordenTrabajo.setVehiculo(daoVehiculo.buscar(rs.getInt("ID_VEHICULO")));
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return ordenTrabajo;
    }
    
}
