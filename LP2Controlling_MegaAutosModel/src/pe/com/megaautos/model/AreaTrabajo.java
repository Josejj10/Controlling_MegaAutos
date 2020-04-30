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
public abstract class AreaTrabajo {
    private double total;
    private ArrayList<CuentaContable> cuentasContables;
    
    public AreaTrabajo(){
        this.cuentasContables = new ArrayList<>();
    }

    public ArrayList<CuentaContable> getCuentasContables() {
        return cuentasContables;
    }

    public void setCuentasContables(ArrayList<CuentaContable> cuentasContables) {
        this.cuentasContables = cuentasContables;
    }

    public double getTotal() {
        return total;
    }

    public void setTotal(double total) {
        this.total = total;
    }
    
    
    
    public abstract void calcularTotal(ArrayList<CuentaContable> cuentasContables);
    
    
}
