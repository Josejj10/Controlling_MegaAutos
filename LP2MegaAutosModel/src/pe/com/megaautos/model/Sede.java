package pe.com.megaautos.model;

public class Sede implements IConsultable{
    private int id;
    private String distrito;
    
    public Sede(){
    }
    
    public Sede(String distrito){
        this.distrito = distrito;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }
    
    public String getDistrito() {
        return distrito;
    }

    public void setDistrito(String distrito) {
        this.distrito = distrito;
    }
    
    public String consultarDatos(){
        return "";
    }

    @Override
    public void modificar() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}
