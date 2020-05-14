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
import pe.com.megaautos.dao.ServicioDAO;
import pe.com.megaautos.model.Servicio;

/**
 *
 * @author Jose
 */
public class ServicioMySQL implements ServicioDAO{
    Connection con;
    @Override
    public int insertar(Servicio servicio) {
        int rpta = 0;
        try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_SERVICIO(?,?,?)}");
            // Insertar Servicio devuelve idServicio, 
            // Y recibirá la descripcion y el Tipo Servicio
            // En el procedure de MySQL, cambiara el nombre del tipo servicio
            // Por su id, para poder insertarlo en la tabla
            cs.registerOutParameter("_ID_SERVICIO", java.sql.Types.INTEGER);
            // TODO A DESCRIPCION AGREGARLE SACAPALABRAS QUE BORRE LOS DOBLE ESPACIOS
            cs.setString("_DESCRIPCION", servicio.getDescripcion().toUpperCase());
            cs.setString("_TIPO_SERVICIO", servicio.getTipoServicio().toUpperCase());
            cs.executeUpdate();
            rpta = cs.getInt("_ID_SERVICIO");
            con.close();
            // Actualiza el ID del Servicio insertado para tenerlo en Java
            servicio.setCodigoServicio(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }
         return rpta;
    }

    @Override
    public int actualizar(Servicio servicio) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idServicio) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Servicio> listar() {
         ArrayList<Servicio> servicios = new ArrayList<>();
        try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Listar servicio devuelve una lista de servicios
            // con ID_Servicio, descripcion y tipo_servicio
            CallableStatement cs = con.prepareCall(
                    "{call LISTAR_SERVICIO()}");
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                Servicio servicio = new Servicio();
                servicio.setCodigoServicio(rs.getInt("ID_SERVICIO"));
                servicio.setDescripcion(rs.getString("DESCRIPCION"));
                servicio.setTipoServicio(rs.getString("TIPO_SERVICIO"));
                servicios.add(servicio);
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        //Devolviendo los servicios
        return servicios;
    }
    
}
