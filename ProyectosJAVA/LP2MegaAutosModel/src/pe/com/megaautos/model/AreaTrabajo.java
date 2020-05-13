/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.model;

import java.util.ArrayList;
/**
 *
 * @author Jose
 */
public class AreaTrabajo {
    private int id;
    private String nombre;
    private Double totalIngresos;
    private Double totalEgresos;
    private ArrayList<AreaTrabajoCuentaContable> listaAreasCuentas;
    /*============================
              Constructores
     ============================*/
    public AreaTrabajo(){
        listaAreasCuentas = new ArrayList<>();
    }
    
    public AreaTrabajo(String nombre){
        listaAreasCuentas = new ArrayList<>();
        this.nombre = nombre;
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
    
    public void agregarAreaCuenta(AreaTrabajoCuentaContable atcc){
        listaAreasCuentas.add(atcc);
    }
    
    public ArrayList<AreaTrabajoCuentaContable> getListaAreasCuentas(){
        return listaAreasCuentas;
    }
    
    public Double getTotalIngresos() {
        return totalIngresos;
    }

    public void setTotalIngresos(Double totalIngresos) {
        this.totalIngresos = totalIngresos;
    }

    public Double getTotalEgresos() {
        return totalEgresos;
    }

    public void setTotalEgresos(Double totalEgresos) {
        this.totalEgresos = totalEgresos;
    }
    
    /*============================
             Otros Metodos
     ============================*/
    
    // Calcular el total de Ingresos en esta Area de Trabajo
    // Suma de los valores de las distribucionesEgresos y distribucionesIngresos
    //de la clase AreaTrabajo-CuentaContable recorriendo la lista
    public int calcularTotales(){
        return 1;
    }
    
}
