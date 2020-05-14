package pe.com.megaautos.model;

import java.util.ArrayList;

public class Servicio implements IConsultable{
    //private int id;
    private int codigoServicio;
    private String descripcion;
    private String tipoServicio;

    public Servicio(){

    }
    
    public Servicio(String descripcion, String tipoServicio){
        //this.codigoServicio = codigoServicio;
        this.descripcion = descripcion;
        this.tipoServicio = tipoServicio;
    }
    
    public int getCodigoServicio() {
        return codigoServicio;
    }

    public void setCodigoServicio(int codigoServicio) {
        this.codigoServicio = codigoServicio;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public String getTipoServicio() {
        return tipoServicio;
    }

    public void setTipoServicio(String tipoServicio) {
        this.tipoServicio = tipoServicio;
    }

    @Override
    public String consultarDatos() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void modificar() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}
