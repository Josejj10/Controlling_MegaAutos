package pe.com.megaautos.model;

import java.util.ArrayList;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Jose
 */
public class Empresa {
    private int id;
    private String nombre;
    private String ruc;
    // Permisos con los que cuenta el usuario
    // Son permisos para modificar clases o crear reportes
    private ArrayList<Usuario> usuarios;
    private ArrayList<Sede> sedes;
    private ArrayList<AreaTrabajo> areasTrabajo;
    

    /*============================
              Constructores
     ============================*/    
   
    public Empresa(){
        this.usuarios = new ArrayList<>();
        this.sedes = new ArrayList<>();
        this.areasTrabajo = new ArrayList<>();
        this.nombre = "MegaAutos";
        this.ruc = "11111111111111";
    }
    
    public Empresa(String nombre, String ruc){
        this.usuarios = new ArrayList<>();
        this.sedes = new ArrayList<>();
        this.areasTrabajo = new ArrayList<>();
        this.nombre = nombre;
        // Verificar RUC
        this.ruc = ruc;
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

  
    public String getRuc() {
        return ruc;
    }

  
    public void setRuc(String ruc) {
        this.ruc = ruc;
    }

    /*============================
              Metodos de listas
    ============================*/
    public void addUsuario(Usuario usuario) {
        this.usuarios.add(usuario);
    }
    
    public boolean removePermiso(Usuario usuario){
        return this.usuarios.remove(usuario);
    }
    
    public ArrayList<Usuario> getUsuarios() {
        return usuarios;
    }
    
    public void addSede(Sede sede) {
        this.sedes.add(sede);
    }
    
    public boolean removeSede(Sede sede){
        return this.sedes.remove(sede);
    }
    
    public ArrayList<Sede> getSedes() {
        return sedes;
    }
    
    public void addAreaTrabajo(AreaTrabajo area) {
        this.areasTrabajo.add(area);
    }
    
    public boolean removeAreaTrabajo(AreaTrabajo area){
        return this.areasTrabajo.remove(area);
    }
    
    public ArrayList<AreaTrabajo> getAreasTrabajo() {
        return areasTrabajo;
    }

    /*============================
                Reportes
    ============================*/
    
    public String generarReporte(String tipoReporte){
        String reporte = "null";
        return reporte;
    }
}
