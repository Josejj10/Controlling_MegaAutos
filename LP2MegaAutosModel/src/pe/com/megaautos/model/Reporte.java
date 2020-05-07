/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.model;
import java.util.ArrayList;
/**
 *
 * @author Rodrigo
 */
public class Reporte {
    private int id;
    private static int correlativo = 1;
    private Usuario usuario;
    private ArrayList<AreaTrabajo> areasTrabajo;
    private Local local;

    public Reporte(){
        this.id = correlativo;
        this.areasTrabajo = new ArrayList<>();
        correlativo++;
    }
    public Reporte(Usuario usuario) {
        this.usuario = usuario;
        this.id = correlativo;
        this.areasTrabajo = new ArrayList<>();
        correlativo++;
    }

    public Usuario getUsuario() {
        return usuario;
    }

    public void setUsuario(Usuario usuario) {
        this.usuario = usuario;
    }

    public ArrayList<AreaTrabajo> getAreasTrabajo() {
        return areasTrabajo;
    }

    public void setAreasTrabajo(ArrayList<AreaTrabajo> areasTrabajo) {
        this.areasTrabajo = areasTrabajo;
    }

    public Local getLocal() {
        return local;
    }

    public void setLocal(Local local) {
        this.local = local;
    }
    
    public String generarReporte(ArrayList<AreaTrabajo> areasTrabajo, Local local, Usuario usuario, int id){
        //
        return "Reporte";
    }
}
