/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.model;

import java.util.List;

/**
 *
 * @author Rodrigo
 */
public class DetalleAT {
    private List<DetalleReporte> detalle;
    private String numOT;
    private Double ingreso;
    private Double egreso;
    private Double margen;

    public String getNumOT() {
        return numOT;
    }

    public void setNumOT(String numOT) {
        this.numOT = numOT;
    }

    public Double getIngreso() {
        return ingreso;
    }

    public void setIngreso(Double ingreso) {
        this.ingreso = ingreso;
    }

    public Double getEgreso() {
        return egreso;
    }

    public void setEgreso(Double egreso) {
        this.egreso = egreso;
    }

    public Double getMargen() {
        return margen;
    }

    public void setMargen(Double margen) {
        this.margen = margen;
    }
    
    
}
