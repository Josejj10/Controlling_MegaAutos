/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.model;

/**
 *
 * @author Rodrigo
 */
public class Vehiculo implements IConsultable{
    private int id;
    private String placa;
    private String tipoVehiculo;
    private Cliente propietario;
    public Vehiculo(){
        
    }

    public Vehiculo(String placa, String tipoVehiculo) {
        this.placa = placa;
        this.tipoVehiculo = tipoVehiculo;
    }
    
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }
    
    public String getPlaca() {
        return placa;
    }

    public void setPlaca(String placa) {
        this.placa = placa;
    }

    public String getTipoVehiculo() {
        return tipoVehiculo;
    }

    public void setTipoVehiculo(String tipoVehiculo) {
        this.tipoVehiculo = tipoVehiculo;
    }
      
    @Override
    public String consultarDatos(){
        return "Placa: " + placa + " - Tipo de Vehiculo" + tipoVehiculo;
    }

    @Override
    public void modificar() {
        
    }

    public Cliente getPropietario() {
        return propietario;
    }

    public void setPropietario(Cliente propietario) {
        this.propietario = propietario;
    }


}
