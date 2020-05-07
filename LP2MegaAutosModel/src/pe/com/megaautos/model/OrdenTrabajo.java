
package pe.com.megaautos.model;
import java.util.ArrayList;
import java.util.Date;
/**
 *
 * @author nicolas
 */
public class OrdenTrabajo {
    private ArrayList<Servicio> servicios;
    private Local local;
    private ComprobantePago comprobante;
    private String placa;
    private Date fecha_rec;
    
    public OrdenTrabajo(Local local, ComprobantePago comprobante, String placa, Date fecha_rec){
        this.local = local;
        this.servicios = new ArrayList<>();
        this.comprobante = comprobante;
        this.placa = placa;
        this.fecha_rec = fecha_rec;
    }

    public ArrayList<Servicio> getServicios() {
        return servicios;
    }

    public Local getLocal() {
        return local;
    }

    public ComprobantePago getComprobante() {
        return comprobante;
    }

    public String getPlaca() {
        return placa;
    }

    public Date getFecha_rec() {
        return fecha_rec;
    }

    public void setLocal(Local local) {
        this.local = local;
    }

    public void setComprobante(ComprobantePago comprobante) {
        this.comprobante = comprobante;
    }

    public void setPlaca(String placa) {
        this.placa = placa;
    }

    public void setFecha_rec(Date fecha_rec) {
        this.fecha_rec = fecha_rec;
    }
    
    public void agregarServicio(Servicio servicio){
    }
    
}
