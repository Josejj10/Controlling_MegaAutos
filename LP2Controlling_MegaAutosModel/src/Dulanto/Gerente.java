/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Dulanto;

/**
 *
 * @author Rodrigo
 */
public class Gerente extends Usuario implements IConsultable{
    
    public Gerente(){
        
    }
    public Gerente(String nombre, String email){
        super(nombre, email);
    }
    @Override
    public void modificarDrivers(){
        //Modificar drivers
    }
}
