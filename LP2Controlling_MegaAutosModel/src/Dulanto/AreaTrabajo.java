/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Dulanto;
import java.util.ArrayList;
import Cossio.CuentaContable;
/**
 *
 * @author Rodrigo
 */
public abstract class AreaTrabajo {
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
    
    
}
