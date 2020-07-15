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
    private double margenBruto;
    private double porcentaje;
    private Sede sede;
    private ArrayList<Servicio> servicios;
    private Cliente cliente;
    private Vehiculo vehiculo;
    private String tipoSiniestro;
    private ComprobantePago comprobantePago;
    private double salidasAlmacen;
    private double comprasRpto;
    private double servTerceros;
    private double mObraMecanica;
    private double mObraPlanchado;
    private double mObraPintura;
    private double serTerTaller;
    
    //Constructores
    public OrdenTrabajo(){
        this.servicios = new ArrayList<>();
        this.sede = new Sede();
        this.cliente = new Cliente();
        this.vehiculo = new Vehiculo();
    }
    public OrdenTrabajo(String numeroOrden, Date fecha, double totalIngresos, double totalEgresos, Sede sede) {
        this.servicios = new ArrayList<>();
        this.numeroOrden = numeroOrden;
        this.fecha = fecha;
        this.totalIngresos = totalIngresos;
        this.totalEgresos = totalEgresos;
        this.sede = sede;
    }

    public double getSalidasAlmacen() {
        return salidasAlmacen;
    }

    public void setSalidasAlmacen(double salidasAlmacen) {
        this.salidasAlmacen = salidasAlmacen;
    }

    public double getComprasRpto() {
        return comprasRpto;
    }

    public void setComprasRpto(double comprasRpto) {
        this.comprasRpto = comprasRpto;
    }

    public double getServTerceros() {
        return servTerceros;
    }

    public void setServTerceros(double servTerceros) {
        this.servTerceros = servTerceros;
    }

    public double getmObraMecanica() {
        return mObraMecanica;
    }

    public void setmObraMecanica(double mObraMecanica) {
        this.mObraMecanica = mObraMecanica;
    }

    public double getmObraPlanchado() {
        return mObraPlanchado;
    }

    public void setmObraPlanchado(double mObraPlanchado) {
        this.mObraPlanchado = mObraPlanchado;
    }

    public double getmObraPintura() {
        return mObraPintura;
    }

    public void setmObraPintura(double mObraPintura) {
        this.mObraPintura = mObraPintura;
    }

    public double getSerTerTaller() {
        return serTerTaller;
    }

    public void setSerTerTaller(double serTerTaller) {
        this.serTerTaller = serTerTaller;
    }

    public ArrayList<Servicio> getServicios() {
        return servicios;
    }

    public void setServicios(ArrayList<Servicio> servicios) {
        this.servicios = servicios;
    }

    public String getTipoSiniestro() {
        return tipoSiniestro;
    }

    public void setTipoSiniestro(String tipoSiniestro) {
        this.tipoSiniestro = tipoSiniestro;
    }

    public double getMargenBruto() {
        return margenBruto;
    }

    public void setMargenBruto(double margenBruto) {
        this.margenBruto = margenBruto;
    }

    public double getPorcentaje() {
        return porcentaje;
    }

    public void setPorcentaje(double porcentaje) {
        this.porcentaje = porcentaje;
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
