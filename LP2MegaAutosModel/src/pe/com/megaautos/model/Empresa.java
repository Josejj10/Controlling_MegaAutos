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
public abstract class Empresa extends Cliente {
    private String razonSocial;
    private String ruc;

    public Empresa() {
    }

    public Empresa(String razonSocial, String ruc) {
        this.razonSocial = razonSocial;
        this.ruc = ruc;
    }
    
    public String getRuc() {
        return ruc;
    }

    public void setRuc(String ruc) {
        this.ruc = ruc;
    }

    public String getRazonSocial() {
        return razonSocial;
    }

    public void setRazonSocial(String razonSocial) {
        this.razonSocial = razonSocial;
    }

  
    
}
