/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.model;

import java.util.ArrayList;

/**
 *
 * @author Rodrigo
 */
public class CuentaContable {
    private int id;
    private String nombre;
    private double montoIngresos;
    private double montoEgresos;
    private ArrayList<OrdenTrabajo> ordenesTrabajo;
    
    public CuentaContable(){
        this.ordenesTrabajo = new ArrayList<>();
    }
    
    public CuentaContable(String nombre) {
        this.ordenesTrabajo = new ArrayList<>();
        this.nombre = nombre;
    }

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

    public double getMontoIngresos() {
        return montoIngresos;
    }

    public void setMontoIngresos(double montoIngresos) {
        this.montoIngresos = montoIngresos;
    }

    public double getMontoEgresos() {
        return montoEgresos;
    }

    public void setMontoEgresos(double montoEgresos) {
        this.montoEgresos = montoEgresos;
    }

    public ArrayList<OrdenTrabajo> getOrdenesTrabajo() {
        return ordenesTrabajo;
    }

    public void setOrdenesTrabajo(ArrayList<OrdenTrabajo> ordenesTrabajo) {
        this.ordenesTrabajo = ordenesTrabajo;
    }
    
    public void agregarOrdenTrabajo(OrdenTrabajo ot){
        this.ordenesTrabajo.add(ot);
    }
    
    public OrdenTrabajo getOrdenTrabajo(int i){
        return this.ordenesTrabajo.get(i);
    }
    
    public int calcularSubtotalIngresos(){
        return 1;
    }
    
    public int calcularSubtotalEgresos(){
        return 1;
    }
}
