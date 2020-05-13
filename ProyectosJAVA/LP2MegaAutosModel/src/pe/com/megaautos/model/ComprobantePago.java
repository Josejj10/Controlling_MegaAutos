package pe.com.megaautos.model;
import java.util.Date;

public class ComprobantePago {
    private int id;
    private String numeroComprobante;
    private String tipoComprobante;
    private Date fecha;
    private OrdenTrabajo ordenTrabajo;    
            
    public ComprobantePago(){
    }
    public ComprobantePago(String numeroComprobante, String tipoComprobante, Date fecha){
        this.numeroComprobante = numeroComprobante;
        this.tipoComprobante = tipoComprobante;
        this.fecha = fecha;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }
    
    public String getNumeroComprobante() {
        return numeroComprobante;
    }

    public String getTipoComprobante() {
        return tipoComprobante;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setNumeroComprobante(String numeroComprobante) {
        this.numeroComprobante = numeroComprobante;
    }

    public void setTipoComprobante(String tipoComprobante) {
        this.tipoComprobante = tipoComprobante;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    /**
     * @return the ordenTrabajo
     */
    public OrdenTrabajo getOrdenTrabajo() {
        return ordenTrabajo;
    }

    /**
     * @param ordenTrabajo the ordenTrabajo to set
     */
    public void setOrdenTrabajo(OrdenTrabajo ordenTrabajo) {
        this.ordenTrabajo = ordenTrabajo;
    }
}
