package pe.com.megaautos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;      
import java.util.ArrayList;
import joinery.DataFrame;
import pe.com.megaautos.config.DBDataSource;
import pe.com.megaautos.config.DBManager;
import pe.com.megaautos.dao.VehiculoDAO;
import pe.com.megaautos.dao.ClienteDAO;
import pe.com.megaautos.model.Cliente;
import pe.com.megaautos.model.Vehiculo;

public class VehiculoMySQL implements VehiculoDAO{

        Connection con;
    
    @Override
    public int insertar(Vehiculo vehiculo) {
        int rpta = 0;
         try{
            Connection con = DBDataSource.getConnection();/*
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);
            */
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_VEHICULO(?,?,?,?)}");
            // Insertar Vehiculo recibirá la placa, el nombre del tipo vehiculo
            // Y el id del propietario
            // En el procedure de MySQL, cambiara el nombre del tipo vehiculo
            // Por su id, para poder insertarlo en la tabla 
            cs.registerOutParameter("_ID_VEHICULO", java.sql.Types.INTEGER);
            cs.setString("_PLACA", vehiculo.getPlaca().toUpperCase());
            cs.setString("_TIPO_VEHICULO", vehiculo.getTipoVehiculo().toUpperCase());
            cs.setInt("_ID_PROPIETARIO", vehiculo.getPropietario().getId());
            cs.executeUpdate();
            rpta = cs.getInt("_ID_VEHICULO");
            con.close();
            // Actualiza el ID del vehiculo insertado para tenerlo en Java
            vehiculo.setId(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }
         return rpta;
    }
    
//    @Override
//    public void guardarBatch (DataFrame df) {
//        int rpta = 0;
//         try{
//            Connection con = DBDataSource.getConnection();/*
//            //Registrar el JAR de conexión
//            Class.forName("com.mysql.cj.jdbc.Driver");
//            //Establecer la conexion
//            con = DriverManager.getConnection(DBManager.url, 
//                    DBManager.user, DBManager.password);
//            */
//            CallableStatement cs = con.prepareCall(
//                    "{call INSERTAR_VEHICULO(?,?,?,?)}");
//            // Insertar Vehiculo recibirá la placa, el nombre del tipo vehiculo
//            // Y el id del propietario
//            // En el procedure de MySQL, cambiara el nombre del tipo vehiculo
//            // Por su id, para poder insertarlo en la tabla 
//            cs.registerOutParameter("_ID_VEHICULO", java.sql.Types.INTEGER);
//            cs.setString("_PLACA", vehiculo.getPlaca().toUpperCase());
//            cs.setString("_TIPO_VEHICULO", vehiculo.getTipoVehiculo().toUpperCase());
//            cs.setInt("_ID_PROPIETARIO", vehiculo.getPropietario().getId());
//            cs.executeUpdate();
//            rpta = cs.getInt("_ID_VEHICULO");
//            con.close();
//            // Actualiza el ID del vehiculo insertado para tenerlo en Java
//            vehiculo.setId(rpta);
//        }catch(Exception ex){
//             System.out.println(ex.getMessage());
//        }
//         return rpta;
//    }
    
    @Override
    public int actualizar(Vehiculo vehiculo) {
         int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Connection con = DBDataSource.getConnection();/*
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);
            */
            CallableStatement cs = con.prepareCall(
                    "{call ACTUALIZAR_VEHICULO(?,?,?,?)}");
            cs.setInt("_ID_VEHICULO", vehiculo.getId());
            cs.setString("_PLACA", vehiculo.getPlaca().toUpperCase());
            cs.setString("_TIPO_VEHICULO", vehiculo.getTipoVehiculo().toUpperCase());
            cs.setInt("_ID_PROPIETARIO", vehiculo.getPropietario().getId());
            cs.executeUpdate();
            con.close();
        }catch(Exception ex){
             System.out.println(ex.getMessage());
             rpta = 1;
        }
         return rpta;
    }

    @Override
    public int eliminar(int idVehiculo) {
         int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Connection con = DBDataSource.getConnection();/*
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);
            */
            CallableStatement cs = con.prepareCall(
                    "{call ELIMINAR_VEHICULO(?)}");
            cs.setInt("_ID_VEHICULO", idVehiculo);
            cs.executeUpdate();
            con.close();
        }catch(Exception ex){
             System.out.println(ex.getMessage());
             rpta = 1;
        }
         return rpta;
    }

    @Override
    public ArrayList<Vehiculo> listar() {
        ArrayList<Vehiculo> vehiculos = new ArrayList<>();
        try{
            //Registrar el JAR de conexión
            Connection con = DBDataSource.getConnection();/*
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Listar vehiculo devuelve una lista de vehiculo 
            // con Placa, ID_tipo_vehiculo  y ID_propietario*/
            CallableStatement cs = con.prepareCall(
                    "{call LISTAR_VEHICULO()}");
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.setId(rs.getInt("ID_VEHICULO"));
                vehiculo.setPlaca(rs.getString("PLACA"));
                vehiculo.setTipoVehiculo(rs.getString("TIPO_VEHICULO"));
                // Para agregar el cliente a vehículo
                // Se asume que el Cliente YA ESTA en la BD
                ClienteDAO daoCliente = new ClienteMySQL();
                Cliente prop = daoCliente.buscar(rs.getInt("ID_PROPIETARIO"));
                vehiculo.setPropietario(prop);
                vehiculos.add(vehiculo);
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        //Devolviendo los vehiculos
        return vehiculos;
    }

    @Override
    public Vehiculo buscar(int idVehiculo) {
        Vehiculo vehiculo = new Vehiculo();
        try{
            //Registrar el JAR de conexión
            Connection con = DBDataSource.getConnection();/*
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Llama a un select * from vehiculo where ID_VEHICULO = id*/
            CallableStatement cs = con.prepareCall(
                    "{call BUSCAR_VEHICULO(?)}");
            cs.setInt("_ID_VEHICULO", idVehiculo);
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                vehiculo.setId(rs.getInt("ID_VEHICULO"));
                vehiculo.setPlaca(rs.getString("PLACA"));
                vehiculo.setTipoVehiculo(rs.getString("TIPO_VEHICULO"));
                // Para agregar el cliente a vehículo
                // Se asume que el Cliente YA ESTA en la BD
                ClienteDAO daoCliente = new ClienteMySQL();
                Cliente prop = daoCliente.buscar(rs.getInt("ID_PROPIETARIO"));
                vehiculo.setPropietario(prop);
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return vehiculo;
    }

}
