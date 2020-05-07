/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.model;

/**
 *
 * @author Rodrigo
 */
public class Gerente extends Usuario implements IModificar{
    
    public Gerente(){
        
    }
    public Gerente(String nombre, String email){
        super(nombre, email);
    }
    
    @Override
    public void modificarDriver(Driver driver){
        //Modificar drivers
    }
    
    @Override
    public void asignarRolUsuario(Usuario usuario){
        //Asignar rol a un usuario creado
    }
}
