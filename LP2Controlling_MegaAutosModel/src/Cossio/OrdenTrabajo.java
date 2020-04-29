
package Cossio;
import java.util.ArrayList;
    
/**
 *
 * @author nicolas
 */
public class OrdenTrabajo {
    private ArrayList<Servicio> servicios;
    private Local local;
    private ComprobantePago comprobante;
    
    public OrdenTrabajo(Local local, ComprobantePago comprobante){
        this.local = local;
        this.servicios = new ArrayList<Servicio>();
        this.comprobante = comprobante;
    }
}
