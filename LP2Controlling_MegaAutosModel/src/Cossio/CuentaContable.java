
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
}
