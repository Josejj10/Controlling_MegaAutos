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
import pe.com.megaautos.config.DBDataSource;
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
            Connection con = DBDataSource.getConnection();/*
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);*/
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
            // Actualiza el ID de la sede insertada para tenerlo en Java
            sede.setId(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }
         return rpta;
    }

    @Override
    public int actualizar(Sede sede) {
        int rpta = 0;
        try{
        //Registrar el JAR de conexión
            Connection con = DBDataSource.getConnection();/*
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);*/
            CallableStatement cs = con.prepareCall(
                    "{call ACTUALIZAR_SEDE(?,?)}");   
            cs.setInt("_ID_SEDE", sede.getId());
            cs.setString("_NOMBRE", sede.getDistrito());
            cs.executeUpdate();
            con.close();
        }catch(Exception ex){
             System.out.println(ex.getMessage());
             rpta = 1;
        }
        return rpta;
    }

    @Override
    public int eliminar(int idSede) {
        int rpta = 0;
        try{
        //Registrar el JAR de conexión
            Connection con = DBDataSource.getConnection();/*
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);*/
            CallableStatement cs = con.prepareCall(
                    "{call ELIMINAR_SEDE(?)}");   
            cs.setInt("_ID_SEDE", idSede);
            cs.executeUpdate();
            con.close();
        }catch(Exception ex){
             System.out.println(ex.getMessage());
             rpta = 1;
        }
        return rpta;
    }

    @Override
    public ArrayList<Sede> listar() {
        ArrayList<Sede> sedes = new ArrayList<>();
        try{
            //Registrar el JAR de conexión
            Connection con = DBDataSource.getConnection();/*
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Listar sede devuelve una lista de sedes
            // con id y nombre*/
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
        //Devolviendo las sedes
        return sedes;    
    }

    @Override
    public Sede buscar(int idSede) {
        Sede sede = new Sede();
        try{
            //Registrar el JAR de conexión
            Connection con = DBDataSource.getConnection();/*
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);*/
            CallableStatement cs = con.prepareCall(
                    "{call BUSCAR_SEDE(?)}");
            cs.setInt("_ID_SEDE", idSede);
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                sede.setId(rs.getInt("ID_SEDE"));
                sede.setDistrito(rs.getString("NOMBRE"));
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return sede;
    }
    
}
