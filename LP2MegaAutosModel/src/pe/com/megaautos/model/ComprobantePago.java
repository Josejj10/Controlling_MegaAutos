
package pe.com.megaautos.model;
import java.util.Date;
/**
 *
 * @author nicolas
 */
public abstract class ComprobantePago {
    private Date fecha_emision;
    private Documento doc;
    private int numSerie;
    private static int correlativo = 1;
    private int nro_doc;
    private OrdenTrabajo ot;
    private Cliente cliente;
        
    public ComprobantePago(Documento doc, int serie, Date fecha_emision, OrdenTrabajo nro_OT, Cliente cliente) {
        this.nro_doc = correlativo;
        correlativo++;
        this.doc = doc;
        this.numSerie = serie;
        this.fecha_emision = fecha_emision;
        this.ot = nro_OT;
    }
    
    public ComprobantePago(){
    }

    public Date getFecha_emision() {
        return fecha_emision;
    }

    public Documento getDoc() {
        return doc;
    }

    public int getNumSerie() {
        return numSerie;
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

    public void setNumSerie(int numSerie) {
        this.numSerie = numSerie;
    }

    public void setOt(OrdenTrabajo ot) {
        this.ot = ot;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }
}
