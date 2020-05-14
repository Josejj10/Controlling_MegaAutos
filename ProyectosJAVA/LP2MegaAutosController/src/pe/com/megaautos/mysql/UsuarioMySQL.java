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
import pe.com.megaautos.dao.UsuarioDAO;
import pe.com.megaautos.model.Usuario;

/**
 *
 * @author Jose
 */
public class UsuarioMySQL implements UsuarioDAO {
    Connection con;
    @Override
    public int insertar(Usuario usuario) {
        int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_USUARIO(?,?,?,?,?,?)}");
            // Insertar Usuario recibirá el nombre, el tipo de usuario
            // la fecha creacion, el correo y password
            cs.registerOutParameter("_ID_USUARIO", java.sql.Types.INTEGER);
            // TODO AL NOMBRE AGREGARLE SACAPALABRAS QUE BORRE LOS DOBLE ESPACIOS
            cs.setString("_NOMBRE", usuario.getNombre().toUpperCase());
            cs.setString("_TIPO_USUARIO", usuario.getTipoUsuario().toUpperCase());
            cs.setString("_CORREO", usuario.getCorreo());
            cs.setString("_PASSWORD", usuario.getPassword());
            java.sql.Date sqlDate = new java.sql.Date(usuario.getFechaCreado().getTime());
            cs.setDate("_FECHA_CREACION", sqlDate);
            
            /*
            //  INSERTAR PERMISOS
            for permiso in permisos{
               cs.prepareCall("{call INSERTAR_PERMISO(?,?}");
               cs.setString("_PERMISO", permiso);
               cs.setId("_ID_USUARIO", usuario.getId());
               cs.executeUpdate(); 
                EL SQL Seria algo como:
                - PROCEDURE INSERTAR PERMISO( 
                - IN _PERMISO VARCHAR(20)
                - IN _ID_USUARIO INT)
               BEGIN
                -- BUSCAR SI _PERMISO EXISTE EN TABLA PERMISOS Y RETORNAR ID
                -- ELSE CREAR PERMISO EN TABLA PERMISOS Y ALMACENAR ID LOCALMENTE EN SQL
                -- INSERTAR EL ID DE PERMISO Y EL ID USUARIO EN LA TABLA PERMISOXUSUARIO
                -- NO DEVOLVER NADA
              
            }
            */
            
            cs.executeUpdate();
            rpta = cs.getInt("_ID_USUARIO");
            con.close();
            // Actualiza el ID del usuario insertado para tenerlo en Java
            usuario.setId(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }
         return rpta;
    }

    @Override
    public int actualizar(Usuario usuario) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idUsuario) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Usuario> listar() {
        ArrayList<Usuario> usuarios = new ArrayList<>();
        try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Listar usuarios devuelve una lista de usuarios
            // con ID_Usuario, nombre, tipo_usuario, correo, passwrd y fecha
            CallableStatement cs = con.prepareCall(
                    "{call LISTAR_USUARIO()}");
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                Usuario usuario = new Usuario();
                usuario.setId(rs.getInt("ID_USUARIO"));
                usuario.setNombre(rs.getString("NOMBRE"));
                usuario.setTipoUsuario(rs.getString("TIPO_USUARIO"));
                usuario.setCorreo(rs.getString("CORREO"));
                usuario.setPassword(rs.getString("PASSWRD"));
                //usuario.setFechaCreado(rs.getDate("FECHA_CREACION"));
                usuarios.add(usuario);
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        //Devolviendo los usuarios
        return usuarios;    
    }
    
}
