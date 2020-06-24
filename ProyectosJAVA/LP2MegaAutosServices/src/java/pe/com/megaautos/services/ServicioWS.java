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
import pe.com.megaautos.dao.ServicioDAO;
import pe.com.megaautos.model.Servicio;

/**
 *
 * @author Rodrigo
 */
@WebService(serviceName = "ServicioWS")
public class ServicioWS {

    private ServicioDAO daoServicio;
    
    public ServicioWS(){
        daoServicio = DBController.controller.getServicioDAO();
    }
    
    @WebMethod(operationName = "listarServicios")
    public ArrayList<Servicio> listarServicios(){
        ArrayList<Servicio> servicios = new ArrayList<>();
        try{
            servicios = daoServicio.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return servicios;
    }
    
    @WebMethod(operationName = "insertarServicio")
    public int insertarServicio(@WebParam(name = "objServicio") Servicio servicio) {
        int resultado = 0;
        try{
            resultado = daoServicio.insertar(servicio);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarServicio")
    public int actualizarServicio(@WebParam(name = "objServicio") Servicio servicio) {
        int resultado = 0;
        try{
            resultado = daoServicio.actualizar(servicio);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarServicio")
    public int eliminarCliente(@WebParam(name = "idServicio") int idServicio) {
        int resultado = 0;
        try{
            resultado = daoServicio.eliminar(idServicio);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
