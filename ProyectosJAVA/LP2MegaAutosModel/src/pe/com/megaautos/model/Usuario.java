package pe.com.megaautos.model;

import java.util.ArrayList;
import java.util.Date;

/**
 *
 * @author Jose
 */
public class Usuario {
    private int id;
    private String nombre;
    private String correo;
    private String password;
    private String tipoUsuario;
    private Date fechaCreado;
    private String token;
    private Date fechaValidezToken;
    // Permisos con los que cuenta el usuario
    // Son permisos para modificar clases o crear reportes
    private ArrayList<EPermisos> permisos; 

    /*============================
              Constructores
     ============================*/    
   
    public Usuario(){
        this.permisos = new ArrayList<>();
        this.fechaCreado = new Date();
        this.token="";
        this.fechaValidezToken = new Date();
    }
    
    public Usuario(String nombre, String correo, String password){
        this.permisos = new ArrayList<>();
        this.nombre = nombre;
        this.correo = correo;
        this.password = password;
        // TODO HACER ENUM DE TIPOS DE USUARIO
        this.tipoUsuario = "Usuario";
        this.fechaCreado = new Date();
    }
    
    public Usuario(String nombre, String correo, String password, String tipoUsuario){
        this.permisos = new ArrayList<>();
        this.nombre = nombre;
        this.correo = correo;
        this.password = password;
        // TODO VERIFICAR QUE PERTENECE A ENUM DE TIPOS DE USUARIO
        this.tipoUsuario = tipoUsuario;
        this.fechaCreado = new Date();
    }
    
    /*============================
           Getters y Setters
     ============================*/
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }
    
    public String getNombre() {
        return nombre;
    }

    
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

  
    public String getCorreo() {
        return correo;
    }

  
    public void setCorreo(String correo) {
        this.correo = correo;
    }

    
    public String getPassword() {
        return password;
    }

   
    public void setPassword(String password) {
        this.password = password;
    }

   
    public Date getFechaCreado() {
        return fechaCreado;
    }

    
    public void setFechaCreado(Date fechaCreado) {
        this.fechaCreado = fechaCreado;
    }

    public String getTipoUsuario() {
        return tipoUsuario;
    }

    public void setTipoUsuario(String tipoUsuario) {
        //TODO Verificar
        this.tipoUsuario = tipoUsuario;
    }
    /*============================
             Otros Metodos
    ============================*/
    public void addPermisos(EPermisos permiso) {
        this.permisos.add(permiso);
    }
    
    public boolean removePermiso(EPermisos permiso){
        return this.permisos.remove(permiso);
    }
    
    public ArrayList<EPermisos> getPermisos() {
        return permisos;
    }

    public void setPermisos(ArrayList<EPermisos> permisos) {
        this.permisos = permisos;
    }

    public String getToken() {
        return token;
    }

    public void setToken(String token) {
        this.token = token;
    }

    public Date getFechaValidezToken() {
        return fechaValidezToken;
    }

    public void setFechaValidezToken(Date fechaValidezToken) {
        this.fechaValidezToken = fechaValidezToken;
    }

    
}
