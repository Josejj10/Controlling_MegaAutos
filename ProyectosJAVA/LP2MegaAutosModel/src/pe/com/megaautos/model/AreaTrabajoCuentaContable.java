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
public class AreaTrabajoCuentaContable {
    private double distribucionIngresos;
    private double distribucionEgresos;
    private CuentaContable cuentaContable;
    private AreaTrabajo areaTrabajo;
    private Driver driver;

    public AreaTrabajoCuentaContable() {
    }
    
    public double getDistribucionIngresos() {
        return distribucionIngresos;
    }

    public void setDistribucionIngresos(double distribucionIngresos) {
        this.distribucionIngresos = distribucionIngresos;
    }

    public double getDistribucionEgresos() {
        return distribucionEgresos;
    }

    public void setDistribucionEgresos(double distribucionEgresos) {
        this.distribucionEgresos = distribucionEgresos;
    }

    public CuentaContable getCuentaContable() {
        return cuentaContable;
    }

    public void setCuentaContable(CuentaContable cuentaContable) {
        this.cuentaContable = cuentaContable;
    }

    public AreaTrabajo getAreaTrabajo() {
        return areaTrabajo;
    }

    public void setAreaTrabajo(AreaTrabajo areaTrabajo) {
        this.areaTrabajo = areaTrabajo;
    }

    public Driver getDriver() {
        return driver;
    }

    public void setDriver(Driver driver) {
        this.driver = driver;
    }
}
