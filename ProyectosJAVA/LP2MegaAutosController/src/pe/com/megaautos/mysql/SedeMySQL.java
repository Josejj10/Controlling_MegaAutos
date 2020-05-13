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
import pe.com.megaautos.dao.SedeDAO;
import pe.com.megaautos.model.Sede;

/**
 *
 * @author Jose
 */
public class SedeMySQL implements SedeDAO {
    Connection con;
    @Override
    public int insertar(Sede sede) {
        int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_SEDE(?,?)}");
            // Insertar Sede recibirá el distrito de la sede y lo inserta
            // a MySQL como Nombre
            cs.registerOutParameter("_ID_SEDE", java.sql.Types.INTEGER);
            // TODO AL NOMBRE AGREGARLE SACAPALABRAS QUE BORRE LOS DOBLE ESPACIOS
            cs.setString("_NOMBRE", sede.getDistrito().toUpperCase());
            cs.executeUpdate();
            rpta = cs.getInt("_ID_SEDE");
            con.close();
            // Actualiza el ID del vehiculo insertado para tenerlo en Java
            sede.setId(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }
         return rpta;
    }

    @Override
    public int actualizar(Sede sede) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idSede) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Sede> listar() {
        ArrayList<Sede> sedes = new ArrayList<>();
        try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Listar sede devuelve una lista de sedes
            // con ID_Sede, nombre, tipo_sede, tipo_doc
            // numero_doc, correo y telefono
            CallableStatement cs = con.prepareCall(
                    "{call LISTAR_SEDE()}");
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                Sede sede = new Sede();
                sede.setId(rs.getInt("ID_SEDE"));
                sede.setDistrito(rs.getString("NOMBRE"));
                sedes.add(sede);
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        //Devolviendo los vehiculos
        return sedes;    
    }
    
}