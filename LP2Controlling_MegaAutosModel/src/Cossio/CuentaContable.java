
package Cossio;
import java.util.ArrayList;
/**
 *
 * @author nicolas
 */
public class CuentaContable {
    private ArrayList<OrdenTrabajo> ordenes;
    private Driver driver;
    
    public CuentaContable(){
        this.ordenes = new ArrayList<OrdenTrabajo>();
    }
    public CuentaContable(Driver driver){
        this.ordenes = new ArrayList<OrdenTrabajo>();
        this.driver = driver;
    }

    public ArrayList<OrdenTrabajo> getOrdenes() {
        return ordenes;
    }

    public Driver getDriver() {
        return driver;
    }

    public void setOrdenes(ArrayList<OrdenTrabajo> ordenes) {
        this.ordenes = ordenes;
    }

    public void setDriver(Driver driver) {
        this.driver = driver;
    }
    
}
