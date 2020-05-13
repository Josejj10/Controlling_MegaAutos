/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
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
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
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
            cs.setString("_NOMBRE", cliente.getNombre().toUpperCase());
            cs.setString("_TIPO_CLIENTE", vehiculo.getTipoVehiculo().toUpperCase());
            cs.setInt(2, vehiculo.getPropietario().getId());
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
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}
