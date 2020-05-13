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
import pe.com.megaautos.dao.SubtipoServicioDAO;
import pe.com.megaautos.model.SubtipoServicio;

/**
 *
 * @author Jose
 */
public class SubtipoServicioMySQL implements SubtipoServicioDAO{
    Connection con;
    @Override
    public int insertar(SubtipoServicio subServ) {
        int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_CLIENTE(?,?,?)}");
            // Insertar Suptipo Servicio recibira nombre e ID SERVICIO
            // Y devolvera ID Subtipo Servicio
            cs.registerOutParameter("_ID_SUBTIPO_SERVICIO", java.sql.Types.INTEGER);
            // TODO AL NOMBRE AGREGARLE SACAPALABRAS QUE BORRE LOS DOBLE ESPACIOS
            cs.setString("_NOMBRE", subServ.getNombre().toUpperCase());
            cs.setInt("ID_SERVICIO",subServ.getIdServicio());
            cs.executeUpdate();
            rpta = cs.getInt("_ID_SUBTIPO_SERVICIO");
            con.close();
            // Actualiza el ID del subtipo de servicio para tenerlo en Java
            subServ.setId(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }
         return rpta;
    }

    @Override
    public int actualizar(SubtipoServicio subServ) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idSubServ) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<SubtipoServicio> listar() {
        ArrayList<SubtipoServicio> subServs = new ArrayList<>();
        try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Listar subServ devuelve una lista de subServs
            // con ID_SubtipoServicio, nombre, tipo_subServ, tipo_doc
            // numero_doc, correo y telefono
            CallableStatement cs = con.prepareCall(
                    "{call LISTAR_SUBTIPO_SERVICIO()}");
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                SubtipoServicio subServ = new SubtipoServicio();
                subServ.setId(rs.getInt("ID_CLIENTE"));
                subServ.setNombre(rs.getString("NOMBRE"));
                subServ.setIdServicio(rs.getInt("ID_SERVICIO"));
                subServs.add(subServ);
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        //Devolviendo los vehiculos
        return subServs;    
    }
    
}
