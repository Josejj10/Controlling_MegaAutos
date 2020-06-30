package pe.com.megaautos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.com.megaautos.config.DBDataSource;
import pe.com.megaautos.config.DBManager;
import pe.com.megaautos.dao.UsuarioDAO;
import pe.com.megaautos.model.EPermisos;
import pe.com.megaautos.model.Usuario;

/*
 * @author Jose
 */
public class UsuarioMySQL implements UsuarioDAO {
    Connection con;
    @Override
    public int insertar(Usuario usuario) {
        int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Connection con = DBDataSource.getConnection();/*
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);*/
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
                     
            cs.executeUpdate();
            rpta = cs.getInt("_ID_USUARIO");
            if (usuario.getPermisos() != null) {
                for (EPermisos e : usuario.getPermisos()){
                    con = DBDataSource.getConnection();
                    CallableStatement cs2 = con.prepareCall(
                         "{call INSERTAR_PERMISO_USUARIO(?,?,?)}");
                    cs2.registerOutParameter("_ID_PERMISO", java.sql.Types.INTEGER);
                    cs2.setString("_NOMBRE",e.toString().toUpperCase());
                    cs2.setInt("_ID_USUARIO", rpta);
                    cs2.executeUpdate();
                }
            }
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
        int rpta = 0;
        try{
            Connection con = DBDataSource.getConnection();/*
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);*/
            CallableStatement cs = con.prepareCall(
                    "{call ACTUALIZAR_USUARIO(?,?,?,?,?,?)}");
            cs.setInt("_ID_USUARIO", usuario.getId());
            cs.setString("_NOMBRE", usuario.getNombre().toUpperCase());
            cs.setString("_TIPO_USUARIO", usuario.getTipoUsuario().toUpperCase());
            cs.setString("_CORREO", usuario.getCorreo());
            cs.setString("_PASSWRD", usuario.getPassword());
            java.sql.Date sqlDate = new java.sql.Date(usuario.getFechaCreado().getTime());
            cs.setDate("_FECHA_CREACION", sqlDate);
            cs.executeUpdate();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            rpta = 1;
        }
        return rpta;
    }

    @Override
    public int eliminar(int idUsuario) {
        int rpta = 0;
        try{
            Connection con = DBDataSource.getConnection();/*
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);*/
            CallableStatement cs = con.prepareCall(
                    "{call ELIMINAR_USUARIO(?)}");
            cs.setInt("_ID_USUARIO", idUsuario);
            cs.executeUpdate();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            rpta = 1;
        }
        return rpta;
    }

    @Override
    public ArrayList<Usuario> listar() {
        ArrayList<Usuario> usuarios = new ArrayList<>();
        try{
            Connection con = DBDataSource.getConnection();/*
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);*/
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

    @Override
    public Usuario verificarPassword(String correo, String password) {
        try{
            Connection con = DBDataSource.getConnection();
            CallableStatement cs = con.prepareCall("{call VERIFICAR_PASSWORD(?,?)}");
            // Seria algo asi
            // "SELECT * FROM Usuarios where correo=CORREO and password=PASSWRD";
            cs.setString(1,correo);
            cs.setString(2,password);
            ResultSet rs = cs.executeQuery();
            if(!rs.next())
                return null;
            // Si no, actualizar usuario y retornarlo
            Usuario usuario = new Usuario();
            usuario.setId(rs.getInt("ID_USUARIO"));
            usuario.setNombre(rs.getString("NOMBRE"));
            usuario.setTipoUsuario(rs.getString("TIPO_USUARIO"));
            usuario.setCorreo(rs.getString("CORREO"));
            usuario.setPassword(rs.getString("PASSWRD"));
            // usuario.setPermisos Ahi hagan su magia con SQL y java 
            // creo que seria un borrar permisos(?)
            // usuario.setFechaCreado(rs.getDate("FECHA_CREACION"))         
            return usuario;
            
        }catch(Exception e){
            System.out.println(e);
            return null;
        }
    }
}