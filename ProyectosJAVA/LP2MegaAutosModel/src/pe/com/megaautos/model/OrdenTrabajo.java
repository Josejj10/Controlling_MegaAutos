package pe.com.megaautos.model;
import java.util.ArrayList;
import java.util.Date;

public class OrdenTrabajo {
    //Atributos
    private int id;
    private String numeroOrden;
    private Date fecha;
    private double totalIngresos;
    private double totalEgresos;
    private Sede sede;
    private ArrayList<Servicio> servicios;
    private Cliente cliente;
    private Vehiculo vehiculo;
    private ComprobantePago comprobantePago;
    
    //Constructores
    public OrdenTrabajo(){
        this.servicios = new ArrayList<>();
    }
    public OrdenTrabajo(String numeroOrden, Date fecha, double totalIngresos, double totalEgresos, Sede sede) {
        this.servicios = new ArrayList<>();
        this.numeroOrden = numeroOrden;
        this.fecha = fecha;
        this.totalIngresos = totalIngresos;
        this.totalEgresos = totalEgresos;
        this.sede = sede;
    }
    
    //Gets y Sets
    
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }
    
    public String getNumeroOrden() {
        return numeroOrden;
    }

    public Date getFecha() {
        return fecha;
    }

    public double getTotalIngresos() {
        return totalIngresos;
    }

    public double getTotalEgresos() {
        return totalEgresos;
    }

    public void setNumeroOrden(String numeroOrden) {
        this.numeroOrden = numeroOrden;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public void setTotalIngresos(double totalIngresos) {
        this.totalIngresos = totalIngresos;
    }

    public void setTotalEgresos(double totalEgresos) {
        this.totalEgresos = totalEgresos;
    }

    public Sede getSede() {
        return sede;
    }

    public void setSede(Sede sede) {
        this.sede = sede;
    }

    public Cliente getCliente() {
        return cliente;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }

    public Vehiculo getVehiculo() {
        return vehiculo;
    }

    public void setVehiculo(Vehiculo vehiculo) {
        this.vehiculo = vehiculo;
    }

    public ComprobantePago getComprobantePago() {
        return comprobantePago;
    }

    public void setComprobantePago(ComprobantePago comprobantePago) {
        this.comprobantePago = comprobantePago;
    }
    
    //Métodos
    public int calcularTotal(){
        return 1;
    }
    
    
}
