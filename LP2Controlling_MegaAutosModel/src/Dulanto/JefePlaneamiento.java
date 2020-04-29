/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Dulanto;
import Cossio.Driver;
/**
 *
 * @author Rodrigo
 */
public class JefePlaneamiento extends Usuario implements IModificar{
    public JefePlaneamiento(){
        
    }
    public JefePlaneamiento(String nombre, String email){
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
