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
    @Override
    public int insertar(OrdenTrabajo ordenTrabajo) {
        int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_ORDEN_TRABAJO(?,?,?,?,?,?,?,?)}");
            // Insertar OrdenTrabajo recibirá el nombre, el tipo de ordenTrabajo
            // el tipo de documento, el numDocumento, el correo y telefono
            // En el procedure de MySQL, cambiara el nombre del tipo vehiculo
            // Por su id, para poder insertarlo en la tabla 
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
            // Actualiza el ID del vehiculo insertado para tenerlo en Java
            ordenTrabajo.setId(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }
         return rpta;
    }

    @Override
    public int actualizar(OrdenTrabajo ordenTrabajo) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idOrdenTrabajo) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<OrdenTrabajo> listar() {
        ArrayList<OrdenTrabajo> ordenTrabajos = new ArrayList<>();
        try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Listar ordenTrabajo devuelve una lista de ordenTrabajos
            // con ID_OrdenTrabajo, nombre, tipo_ordenTrabajo, tipo_doc
            // numero_doc, correo y telefono
            CallableStatement cs = con.prepareCall(
                    "{call LISTAR_ORDEN_TRABAJO()}");
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                OrdenTrabajo ordenTrabajo = new OrdenTrabajo();
                ordenTrabajo.setId(rs.getInt("ID_ORDEN_TRABAJO"));
                ordenTrabajo.setFecha(rs.getDate("FECHA"));
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
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Llama a un select * from ordenTrabajo where ID_ORDEN_TRABAJO = id
            CallableStatement cs = con.prepareCall(
                    "{call BUSCAR_ORDEN_TRABAJO(?)}");
            cs.setInt("_ID", idOrdenTrabajo);
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                ordenTrabajo.setId(rs.getInt("ID_ORDEN_TRABAJO"));
                ordenTrabajo.setFecha(rs.getDate("FECHA"));
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
