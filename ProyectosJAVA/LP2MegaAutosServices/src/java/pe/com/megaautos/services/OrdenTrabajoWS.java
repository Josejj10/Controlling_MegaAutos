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
import pe.com.megaautos.dao.OrdenTrabajoDAO;
import pe.com.megaautos.model.OrdenTrabajo;


@WebService(serviceName = "OrdenTrabajoWS")
public class OrdenTrabajoWS {

    private OrdenTrabajoDAO daoOrdenTrabajo;
    
    public OrdenTrabajoWS(){
        daoOrdenTrabajo = DBController.controller.getOrdenTrabajoDAO();
    }
    
    @WebMethod(operationName = "listarOrdenTrabajo")
    public ArrayList<OrdenTrabajo> listarOrdenTrabajo(){
        ArrayList<OrdenTrabajo> ots = new ArrayList<>();
        try{
            ots = daoOrdenTrabajo.listar();
        }catch(Exception ex){
            System.out.println(ex.getCause());
            System.out.println(ex.getMessage());
        }
        return ots;
    }
    
    @WebMethod(operationName = "insertarOrdenTrabajo")
    public int insertarOrdenTrabajo(@WebParam(name = "objOT") OrdenTrabajo ot) {
        int resultado = 0;
        try{
            resultado = daoOrdenTrabajo.insertar(ot);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarOrdenTrabajo")
    public int actualizarOrdenTrabajo(@WebParam(name = "objOT") OrdenTrabajo ot) {
        int resultado = 0;
        try{
            resultado = daoOrdenTrabajo.actualizar(ot);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarOrdenTrabajo")
    public int eliminarOrdenTrabajo(@WebParam(name = "idOT") int idOT) {
        int resultado = 0;
        try{
            resultado = daoOrdenTrabajo.eliminar(idOT);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
