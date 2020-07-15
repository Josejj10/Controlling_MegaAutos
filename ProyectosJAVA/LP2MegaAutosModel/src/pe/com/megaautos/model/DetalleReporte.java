/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.model;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Rodrigo
 */
public class DetalleReporte {
    private String cuenta;
    private List<OrdenTrabajo> ordenes;
    private List<Double> montos;
    private List<DetalleAT> ordenesAT;

    public DetalleReporte() {
        ordenes = new ArrayList<>();
        montos = new ArrayList<>();
        ordenesAT = new ArrayList<>();
    }

    public List<DetalleAT> getOrdenesAT() {
        return ordenesAT;
    }

    public void setOrdenesAT(List<DetalleAT> ordenesAT) {
        this.ordenesAT = ordenesAT;
    }

    
    
    public String getCuenta() {
        return cuenta;
    }

    public void setCuenta(String cuenta) {
        this.cuenta = cuenta;
    }

    public List<OrdenTrabajo> getOrdenes() {
        return ordenes;
    }

    public void setOrdenes(List<OrdenTrabajo> ordenes) {
        this.ordenes = ordenes;
    }

    public List<Double> getMontos() {
        return montos;
    }

    public void setMontos(List<Double> montos) {
        this.montos = montos;
    }
    
    
}
