
package Cossio;
import java.util.Date;
import Dulanto.Cliente;
/**
 *
 * @author nicolas
 */
public abstract class ComprobantePago {
    private Date fecha_emision;
    private Documento doc;
    private int serie;
    private static int correlativo = 1;
    private int nro_doc;
    private OrdenTrabajo ot;
    private Cliente cliente;
        
    public ComprobantePago(Documento doc, int serie, Date fecha_emision, OrdenTrabajo nro_OT, Cliente cliente) {
        this.nro_doc = correlativo;
        correlativo++;
        this.doc = doc;
        this.serie = serie;
        this.fecha_emision = fecha_emision;
        this.ot = ot;
    }
    
    public ComprobantePago(){
    }

    public Date getFecha_emision() {
        return fecha_emision;
    }

    public Documento getDoc() {
        return doc;
    }

    public int getSerie() {
        return serie;
    }

    public OrdenTrabajo getOt() {
        return ot;
    }

    public Cliente getCliente() {
        return cliente;
    }
    
    public void setFecha_emision(Date fecha_emision) {
        this.fecha_emision = fecha_emision;
    }

    public void setDoc(Documento doc) {
        this.doc = doc;
    }

    public void setSerie(int serie) {
        this.serie = serie;
    }

    public void setOt(OrdenTrabajo ot) {
        this.ot = ot;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }
}
