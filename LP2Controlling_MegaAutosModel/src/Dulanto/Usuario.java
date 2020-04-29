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
public class Usuario {
    private static int correlativo = 1;
    private int id;
    private String nombre;
    private String email;
    
    public Usuario(){
    }
    
    public Usuario(String nombre, String email){
        this.nombre = nombre;
        this.email = email;
        this.id = correlativo;
        correlativo++;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }
    
    
}
