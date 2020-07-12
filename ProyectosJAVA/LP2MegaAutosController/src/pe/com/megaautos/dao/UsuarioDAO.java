/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.dao;

import java.util.ArrayList;
import pe.com.megaautos.model.Usuario;


/**
 *
 * @author Rodrigo
 */
public interface UsuarioDAO {
    int insertar(Usuario usuario);
    int actualizar(Usuario usuario);
    int actualizarConPassword(Usuario usuario);
    int eliminar(int idUsuario);
    Usuario buscarPorCorreo(String correo);
    ArrayList<Usuario> listar();    
    ArrayList<Usuario> listarInactivos();
    Usuario verificarPassword(String correo, String Password);
    int actualizarToken(Usuario usuario, String token);
    int actualizarPasswrd(String correo, String token, String passwrd);
    boolean verificarToken(String correo, String token);
    int invalidarToken(String correo, String token);
}
