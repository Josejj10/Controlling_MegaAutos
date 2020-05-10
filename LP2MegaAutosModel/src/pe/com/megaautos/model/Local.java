package pe.com.megaautos.model;

public class Local implements IConsultable{
    private String distrito;
    
    public Local(){
    }
    
    public Local(String distrito){
        this.distrito = distrito;
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
