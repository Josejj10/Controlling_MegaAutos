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
import pe.com.megaautos.model.Cliente;

/**
 *
 * @author Jose
 */
public class ClienteMySQL implements ClienteDAO {
    Connection con;

    @Override
    public Cliente buscar(int id) {
        Cliente cliente = new Cliente();
        try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Llama a un select * from cliente where ID_CLIENTE = id
            CallableStatement cs = con.prepareCall(
                    "{call BUSCAR_CLIENTE(?)}");
            cs.setInt("_ID", id);
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                cliente.setId(rs.getInt("ID_CLIENTE"));
                cliente.setNombre(rs.getString("NOMBRE"));
                cliente.setTipoCliente(rs.getString("TIPO_CLIENTE"));
                cliente.setTipoDocumento(rs.getString("TIPO_DOCUMENTO"));
                cliente.setCorreo(rs.getString("CORREO"));
                cliente.setTelefono(rs.getString("TELEFONO"));
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return cliente;
    }
    

    @Override
    public int insertar(Cliente cliente) {
        int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_CLIENTE(?,?,?)}");
            // Insertar Cliente recibirá el nombre, el tipo de cliente
            // el tipo de documento, el numDocumento, el correo y telefono
            // En el procedure de MySQL, cambiara el nombre del tipo vehiculo
            // Por su id, para poder insertarlo en la tabla 
            cs.registerOutParameter("_ID_CLIENTE", java.sql.Types.INTEGER);
            // TODO AL NOMBRE AGREGARLE SACAPALABRAS QUE BORRE LOS DOBLE ESPACIOS
            cs.setString("_NOMBRE", cliente.getNombre().toUpperCase());
            cs.setString("_TIPO_CLIENTE", cliente.getTipoCliente().toUpperCase());
            cs.setString("_TIPO_DOCUMENTO", cliente.getTipoDocumento().toUpperCase());
            cs.setString("_NUMERO_DOCUMENTO", cliente.getNumDocumento());
            cs.setString("_CORREO", cliente.getCorreo());
            cs.setString("_TELEFONO",cliente.getTelefono());
            cs.executeUpdate();
            rpta = cs.getInt("_ID_CLIENTE");
            con.close();
            // Actualiza el ID del vehiculo insertado para tenerlo en Java
            cliente.setId(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }
         return rpta;
    }

    @Override
    public int actualizar(Cliente cliente) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idCliente) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Cliente> listar() {
        ArrayList<Cliente> clientes = new ArrayList<>();
        try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Listar cliente devuelve una lista de clientes
            // con ID_Cliente, nombre, tipo_cliente, tipo_doc
            // numero_doc, correo y telefono
            CallableStatement cs = con.prepareCall(
                    "{call LISTAR_CLIENTE()}");
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                Cliente cliente = new Cliente();
                cliente.setId(rs.getInt("ID_CLIENTE"));
                cliente.setNombre(rs.getString("NOMBRE"));
                cliente.setTipoCliente(rs.getString("TIPO_CLIENTE"));
                cliente.setTipoDocumento(rs.getString("TIPO_DOCUMENTO"));
                cliente.setCorreo(rs.getString("CORREO"));
                cliente.setTelefono(rs.getString("TELEFONO"));
                clientes.add(cliente);
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        //Devolviendo los vehiculos
        return clientes;    
    }
    
}
