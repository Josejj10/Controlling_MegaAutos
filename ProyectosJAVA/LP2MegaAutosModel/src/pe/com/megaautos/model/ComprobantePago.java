package pe.com.megaautos.model;
import java.util.Date;

public class ComprobantePago {
    private int id;
    private String numeroComprobante;
    private String tipoComprobante;
    private Date fecha;
    private OrdenTrabajo ordenTrabajo;    
    private double monto;
    
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

    public void setOrdenTrabajo(OrdenTrabajo ordenTrabajo) {
        this.ordenTrabajo = ordenTrabajo;
    }

    public void setOrdenTrabajo(int idOrdenTrabajo) {
        // TODO implementar buscar id orden trabajo
        this.ordenTrabajo = new OrdenTrabajo();
    }

    public double getMonto() {
        return monto;
    }

    public void setMonto(double monto) {
        this.monto = monto;
    }
}
