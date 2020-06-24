/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.com.megaautos.config.DBController;
import pe.com.megaautos.dao.VehiculoDAO;
import pe.com.megaautos.model.Vehiculo;

/**
 *
 * @author Rodrigo
 */
@WebService(serviceName = "VehiculoWS")
public class VehiculoWS {
    
    private VehiculoDAO daoVehiculo;
    
    public VehiculoWS(){
        daoVehiculo = DBController.controller.getVehiculoDAO();
    }
    
    @WebMethod(operationName = "listarVehiculos")
    public ArrayList<Vehiculo> listarVehiculos(){
        ArrayList<Vehiculo> vehiculos = new ArrayList<>();
        try{
            vehiculos = daoVehiculo.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return vehiculos;
    }
    
    @WebMethod(operationName = "insertarVehiculo")
    public int insertarVehiculo(@WebParam(name = "objVehiculo") Vehiculo vehiculo) {
        int resultado = 0;
        try{
            resultado = daoVehiculo.insertar(vehiculo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarVehiculo")
    public int actualizarVehiculo(@WebParam(name = "objVehiculo") Vehiculo vehiculo) {
        int resultado = 0;
        try{
            resultado = daoVehiculo.actualizar(vehiculo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarVehiculo")
    public int eliminarCliente(@WebParam(name = "idVehiculo") int idVehiculo) {
        int resultado = 0;
        try{
            resultado = daoVehiculo.eliminar(idVehiculo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
