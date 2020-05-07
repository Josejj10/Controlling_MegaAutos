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
public abstract class Usuario {
    private static int correlativo = 1;
    private int id;
    private String nombre;
    private String email;
    private String contraseña;
    
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

    public String getContraseña() {
        return contraseña;
    }

    public void setContraseña(String contraseña) {
        this.contraseña = contraseña;
    }
    
    public void encriptarContraseña(String contraseña){
        //Método para encriptar la contraseña del usuario
    }
    
}
