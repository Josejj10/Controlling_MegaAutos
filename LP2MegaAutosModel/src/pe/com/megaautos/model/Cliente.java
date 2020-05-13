package pe.com.megaautos.model;


public class Cliente implements IConsultable{


    private int id; //DULANTO AGREGUE ESTO 
    private String nombre;
    private String numDocumento;
    private String tipoDocumento;
    private String telefono;
    private String correo;

    public Cliente(){
    }
    public Cliente(String nombre, String numDocumento, String tipoDocumento, String telefono, String correo) {
        this.nombre = nombre;
        this.numDocumento = numDocumento;
        this.tipoDocumento = tipoDocumento;
        this.telefono = telefono;
        this.correo = correo;
    }

    public String getNombre() {
        return nombre;
    }

    public String getNumDocumento() {
        return numDocumento;
    }

    public String getTipoDocumento() {
        return tipoDocumento;
    }

    public String getTelefono() {
        return telefono;
    }

    public String getCorreo() {
        return correo;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setNumDocumento(String numDocumento) {
        this.numDocumento = numDocumento;
    }

    public void setTipoDocumento(String tipoDocumento) {
        this.tipoDocumento = tipoDocumento;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public void setCorreo(String correo) {
        this.correo = correo;
    }    

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }
    
    @Override
    public String consultarDatos() {
        throw new UnsupportedOperationException("Not supported yet.");
    }

    @Override
    public void modificar() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}
