
package pe.com.megaautos.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.com.megaautos.config.DBController;
import pe.com.megaautos.dao.UsuarioDAO;
import pe.com.megaautos.model.Usuario;

/**
 *
 * @author JOSE
 */
@WebService(serviceName = "UsuarioWS")
public class UsuarioWS {

    private UsuarioDAO daoUsuario;
    
    public UsuarioWS(){
        daoUsuario = DBController.controller.getUsuarioDAO();
    }
    
    @WebMethod(operationName = "verificarPassword")
    public Usuario verificarPassword(@WebParam(name = "correo") String correo,
            @WebParam(name = "password") String password){
        // retorna null al cliente si no hay usuario, y 
        // el usuario si si hay
        return daoUsuario.verificarPassword(correo,password);
    }
    
    @WebMethod(operationName = "listarUsuarios")
    public ArrayList<Usuario> listarUsuarios(){
        ArrayList<Usuario> usuarios = new ArrayList<>();
        try{
            usuarios = daoUsuario.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return usuarios;
    }
    
    @WebMethod(operationName = "insertarUsuario")
    public int insertarUsuario(@WebParam(name = "objUsuario") Usuario usuario) {
        int resultado = 0;
        try{
            resultado = daoUsuario.insertar(usuario);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarUsuario")
    public int actualizarUsuario(@WebParam(name = "objUsuario") Usuario usuario) {
        int resultado = 0;
        try{
            resultado = daoUsuario.actualizar(usuario);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarUsuario")
    public int eliminarUsuario(@WebParam(name = "idUsuario") int idUsuario) {
        int resultado = 0;
        try{
            resultado = daoUsuario.eliminar(idUsuario);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
