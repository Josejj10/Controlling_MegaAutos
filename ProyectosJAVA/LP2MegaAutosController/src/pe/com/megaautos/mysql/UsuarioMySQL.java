package pe.com.megaautos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.com.megaautos.config.DBController;
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
            con = DBDataSource.getConnection();/*
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
                    CallableStatement cs2 = con.prepareCall(
                         "{call INSERTAR_PERMISO_USUARIO(?,?,?)}");
                    cs2.registerOutParameter("_ID_PERMISO", java.sql.Types.INTEGER);
                    cs2.setString("_NOMBRE",e.toString().toUpperCase());
                    cs2.setInt("_ID_USUARIO", rpta);
                    cs2.executeUpdate();
                }
            }
            // Actualiza el ID del usuario insertado para tenerlo en Java
            usuario.setId(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
         return rpta;
    }

    @Override
    public int actualizar(Usuario usuario) {
        int rpta = 0;
        try{
            con = DBDataSource.getConnection();/*
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);*/
            CallableStatement cs = con.prepareCall(
                    "{call ACTUALIZAR_USUARIO(?,?,?,?,?)}");
            cs.setInt("_ID_USUARIO", usuario.getId());
            cs.setString("_NOMBRE", usuario.getNombre().toUpperCase());
            cs.setString("_TIPO_USUARIO", usuario.getTipoUsuario().toUpperCase());
            cs.setString("_CORREO", usuario.getCorreo());
            java.sql.Date sqlDate = new java.sql.Date(usuario.getFechaCreado().getTime());
            cs.setDate("_FECHA_CREACION", sqlDate);
            cs.executeUpdate();
            Connection con2 = DBDataSource.getConnection();
            Connection con3 = DBDataSource.getConnection();
            
            if (usuario.getPermisos() != null) {
                Usuario u2 = buscarPorCorreo(usuario.getCorreo());
                //Se recorre para eliminar los permisos
                for (EPermisos e : u2.getPermisos()){
                    if (usuario.getPermisos().contains(e))
                        continue;
                    CallableStatement cs2 = con2.prepareCall("{call ELIMINAR_PERMISO_USUARIO(?,?)}");
                    cs2.setString("_NOMBRE",e.toString().toUpperCase());
                    cs2.setInt("_ID_USUARIO", usuario.getId());
                    cs2.executeUpdate();
                }
                con2.close();
                //Se recorre para agregar los permisos
                for (EPermisos e : usuario.getPermisos()){
                    if (u2.getPermisos().contains(e))
                            continue;
                    CallableStatement cs3 = con3.prepareCall(
                         "{call INSERTAR_PERMISO_USUARIO(?,?,?)}");
                    cs3.registerOutParameter("_ID_PERMISO", java.sql.Types.INTEGER);
                    cs3.setString("_NOMBRE",e.toString().toUpperCase());
                    cs3.setInt("_ID_USUARIO", usuario.getId());
                    cs3.executeUpdate();
                }
                con3.close();
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            rpta = 1;
        }finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return rpta;
    }

    @Override
    public int actualizarConPassword(Usuario usuario) {
        int rpta = 0;
        try{
            con = DBDataSource.getConnection();/*
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);*/
            CallableStatement cs = con.prepareCall(
                    "{call ACTUALIZAR_USUARIO_CONTRASEÑA(?,?,?,?,?,?)}");
            cs.setInt("_ID_USUARIO", usuario.getId());
            cs.setString("_NOMBRE", usuario.getNombre().toUpperCase());
            cs.setString("_TIPO_USUARIO", usuario.getTipoUsuario().toUpperCase());
            cs.setString("_CORREO", usuario.getCorreo());
            cs.setString("_PASSWRD", usuario.getPassword());
            java.sql.Date sqlDate = new java.sql.Date(usuario.getFechaCreado().getTime());
            cs.setDate("_FECHA_CREACION", sqlDate);
            cs.executeUpdate();
            Connection con2 = DBDataSource.getConnection();
            Connection con3 = DBDataSource.getConnection();
            if (usuario.getPermisos() != null) {
                Usuario u2 = buscarPorCorreo(usuario.getCorreo());
                //Se recorre para eliminar los permisos
                for (EPermisos e : u2.getPermisos()){
                    if (usuario.getPermisos().contains(e))
                        continue;
                    CallableStatement cs2 = con2.prepareCall("{call ELIMINAR_PERMISO_USUARIO(?,?)");
                    cs2.setString("_NOMBRE",e.toString().toUpperCase());
                    cs2.setInt("_ID_USUARIO", rpta);
                    cs2.executeUpdate();
                }
                con2.close();
                //Se recorre para agregar los permisos
                for (EPermisos e : usuario.getPermisos()){
                    if (u2.getPermisos().contains(e))
                            continue;
                    CallableStatement cs3 = con3.prepareCall(
                         "{call INSERTAR_PERMISO_USUARIO(?,?,?)}");
                    cs3.registerOutParameter("_ID_PERMISO", java.sql.Types.INTEGER);
                    cs3.setString("_NOMBRE",e.toString().toUpperCase());
                    cs3.setInt("_ID_USUARIO", rpta);
                    cs3.executeUpdate();
                }
                con3.close();
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            rpta = 1;
        }finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return rpta;
    }
    
    @Override
    public int eliminar(int idUsuario) {
        int rpta = 0;
        try{
            con = DBDataSource.getConnection();/*
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);*/
            CallableStatement cs = con.prepareCall(
                    "{call ELIMINAR_USUARIO(?)}");
            cs.setInt("_ID_USUARIO", idUsuario);
            cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            rpta = 1;
        }finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return rpta;
    }

    @Override
    public ArrayList<Usuario> listar() {
        ArrayList<Usuario> usuarios = new ArrayList<>();
        try{
            con = DBDataSource.getConnection();/*
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
            CallableStatement cs2 = con.prepareCall("{call LISTAR_PERMISOS_X_USUARIO(?)}");
            cs2.setInt(1, usuario.getId());
            ResultSet rs2 = cs2.executeQuery();
            int permiso;
            while(rs2.next()){
                permiso = rs2.getInt("ID_PERMISO");
                switch(permiso){
                    case 1:
                        usuario.addPermisos(EPermisos.AreasTrabajo);
                        break;
                    case 2:
                        usuario.addPermisos(EPermisos.Clientes);
                        break;
                    case 3:
                        usuario.addPermisos(EPermisos.Vehiculos);
                        break;
                    case 4:
                        usuario.addPermisos(EPermisos.Drivers);
                        break;
                    case 5:
                        usuario.addPermisos(EPermisos.Usuarios);
                        break;
                    case 6:
                        usuario.addPermisos(EPermisos.Servicios);
                        break;
                    case 7:
                        usuario.addPermisos(EPermisos.Sedes);
                        break;
                    case 8:
                        usuario.addPermisos(EPermisos.Empresa);
                        break;
                    case 9:
                        usuario.addPermisos(EPermisos.ActualizarBD);
                        break;
                    case 10:
                        usuario.addPermisos(EPermisos.All);
                        break;
                }
            }
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        //Devolviendo los usuarios
        return usuarios;    
    }
    @Override
    public Usuario buscarPorCorreo(String correo){        
        Usuario usuario = new Usuario();
        try{
            con = DBDataSource.getConnection();
            CallableStatement cs = con.prepareCall("{call BUSCAR_POR_CORREO(?)}");
            cs.setString(1,correo);
            ResultSet rs = cs.executeQuery();
            if(!rs.next())
                return null;
            // Si no, actualizar usuario y retornarlo
            usuario.setId(rs.getInt("ID_USUARIO"));
            usuario.setNombre(rs.getString("NOMBRE"));
            usuario.setTipoUsuario(rs.getString("TIPO_USUARIO"));
            usuario.setCorreo(rs.getString("CORREO"));
            
            CallableStatement cs2 = con.prepareCall("{call LISTAR_PERMISOS_X_USUARIO(?)}");
            cs2.setInt(1, usuario.getId());
            ResultSet rs2 = cs2.executeQuery();
            int permiso;
            while(rs2.next()){
                permiso = rs2.getInt("ID_PERMISO");
                switch(permiso){
                    case 1:
                        usuario.addPermisos(EPermisos.AreasTrabajo);
                        break;
                    case 2:
                        usuario.addPermisos(EPermisos.Clientes);
                        break;
                    case 3:
                        usuario.addPermisos(EPermisos.Vehiculos);
                        break;
                    case 4:
                        usuario.addPermisos(EPermisos.Drivers);
                        break;
                    case 5:
                        usuario.addPermisos(EPermisos.Usuarios);
                        break;
                    case 6:
                        usuario.addPermisos(EPermisos.Servicios);
                        break;
                    case 7:
                        usuario.addPermisos(EPermisos.Sedes);
                        break;
                    case 8:
                        usuario.addPermisos(EPermisos.Empresa);
                        break;
                    case 9:
                        usuario.addPermisos(EPermisos.ActualizarBD);
                        break;
                    case 10:
                        usuario.addPermisos(EPermisos.All);
                        break;
                }
            }
            
            
            // usuario.setPermisos Ahi hagan su magia con SQL y java
            // usuario.setFechaCreado(rs.getDate("FECHA_CREACION"))         

            
        }catch(Exception e){
            System.out.println(e);
        }finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return usuario;
    }
    @Override
    public Usuario verificarPassword(String correo, String password) {
        
        Usuario usuario = new Usuario();
        try{
            con = DBDataSource.getConnection();
            CallableStatement cs = con.prepareCall("{call VERIFICAR_PASSWORD(?,?)}");
            // Seria algo asi
            // "SELECT * FROM Usuarios where correo=CORREO and password=PASSWRD";
            cs.setString(1,correo);
            cs.setString(2,password);
            ResultSet rs = cs.executeQuery();
            if(!rs.next())
                return null;
            // Si no, actualizar usuario y retornarlo
            usuario.setId(rs.getInt("ID_USUARIO"));
            usuario.setNombre(rs.getString("NOMBRE"));
            usuario.setTipoUsuario(rs.getString("TIPO_USUARIO"));
            usuario.setCorreo(rs.getString("CORREO"));
            usuario.setPassword(rs.getString("PASSWRD"));
            
            CallableStatement cs2 = con.prepareCall("{call LISTAR_PERMISOS_X_USUARIO(?)}");
            cs2.setInt(1, usuario.getId());
            ResultSet rs2 = cs2.executeQuery();
            int permiso;
            while(rs2.next()){
                permiso = rs2.getInt("ID_PERMISO");
                switch(permiso){
                    case 1:
                        usuario.addPermisos(EPermisos.AreasTrabajo);
                        break;
                    case 2:
                        usuario.addPermisos(EPermisos.Clientes);
                        break;
                    case 3:
                        usuario.addPermisos(EPermisos.Vehiculos);
                        break;
                    case 4:
                        usuario.addPermisos(EPermisos.Drivers);
                        break;
                    case 5:
                        usuario.addPermisos(EPermisos.Usuarios);
                        break;
                    case 6:
                        usuario.addPermisos(EPermisos.Servicios);
                        break;
                    case 7:
                        usuario.addPermisos(EPermisos.Sedes);
                        break;
                    case 8:
                        usuario.addPermisos(EPermisos.Empresa);
                        break;
                    case 9:
                        usuario.addPermisos(EPermisos.ActualizarBD);
                        break;
                    case 10:
                        usuario.addPermisos(EPermisos.All);
                        break;
                }
            }
            
            
            // usuario.setPermisos Ahi hagan su magia con SQL y java
            // usuario.setFechaCreado(rs.getDate("FECHA_CREACION")
            
        }catch(Exception e){
            System.out.println(e);
        }finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return usuario;
    }

    @Override
    public int actualizarToken(Usuario usuario, String token) {
        int rpta = 0;
        try{
            con = DBDataSource.getConnection();
            CallableStatement cs = con.prepareCall(
                    "{call ACTUALIZAR_USUARIO_TOKEN(?,?)}");
            cs.setInt("_ID_USUARIO", usuario.getId());
            cs.setString("_TOKEN",token);
            cs.executeUpdate();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            rpta = 1;
        }finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return rpta;
    }

    @Override
    public int actualizarPasswrd(String correo, String token, String passwrd) {
        int rpta = 0;
        try{
            con = DBDataSource.getConnection();
            CallableStatement cs = con.prepareCall(
                    "{call ACTUALIZAR_PASSWRD(?,?,?)}");
            cs.setString("_CORREO",correo);
            cs.setString("_TOKEN",token);            
            cs.setString("_NUEVA_PASSWRD",passwrd);
            cs.executeUpdate();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            rpta = 1;
        }finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return rpta;
    }

    @Override
    public boolean verificarToken(String correo, String token) {
        boolean rpta = false;
        try{
            con = DBDataSource.getConnection();
            CallableStatement cs = con.prepareCall(
                    "{call VERIFICAR_TOKEN(?,?,?)}");
            cs.registerOutParameter("_RESULTADO", java.sql.Types.INTEGER);
            cs.setString("_CORREO",correo);
            cs.setString("_TOKEN",token);
            cs.executeQuery();
            rpta=cs.getBoolean("_RESULTADO");
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            rpta=false;
        }finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return rpta;
    }

    @Override
    public int invalidarToken(String correo, String token) {
        int rpta = 0;
        try{
            con = DBDataSource.getConnection();
            CallableStatement cs = con.prepareCall(
                    "{call INVALIDAR_TOKEN(?,?)}");
            cs.setString("_CORREO",correo);
            cs.setString("_TOKEN",token);           
            cs.executeUpdate();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            rpta = 1;
        }finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return rpta;
    }
    
    @Override
    public ArrayList<Usuario> listarInactivos() {
        ArrayList<Usuario> usuarios = new ArrayList<>();
        try{
            con = DBDataSource.getConnection();/*
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);*/
            // Listar usuarios devuelve una lista de usuarios
            // con ID_Usuario, nombre, tipo_usuario, correo, passwrd y fecha
            CallableStatement cs = con.prepareCall(
                    "{call LISTAR_USUARIOS_INACTIVOS()}");
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
            CallableStatement cs2 = con.prepareCall("{call LISTAR_PERMISOS_X_USUARIO(?)}");
            cs2.setInt(1, usuario.getId());
            ResultSet rs2 = cs2.executeQuery();
            int permiso;
            while(rs2.next()){
                permiso = rs2.getInt("ID_PERMISO");
                switch(permiso){
                    case 1:
                        usuario.addPermisos(EPermisos.AreasTrabajo);
                        break;
                    case 2:
                        usuario.addPermisos(EPermisos.Clientes);
                        break;
                    case 3:
                        usuario.addPermisos(EPermisos.Vehiculos);
                        break;
                    case 4:
                        usuario.addPermisos(EPermisos.Drivers);
                        break;
                    case 5:
                        usuario.addPermisos(EPermisos.Usuarios);
                        break;
                    case 6:
                        usuario.addPermisos(EPermisos.Servicios);
                        break;
                    case 7:
                        usuario.addPermisos(EPermisos.Sedes);
                        break;
                    case 8:
                        usuario.addPermisos(EPermisos.Empresa);
                        break;
                    case 9:
                        usuario.addPermisos(EPermisos.ActualizarBD);
                        break;
                    case 10:
                        usuario.addPermisos(EPermisos.All);
                        break;
                }
            }
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        //Devolviendo los usuarios
        return usuarios;    
    }
}