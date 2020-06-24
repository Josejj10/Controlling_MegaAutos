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
import pe.com.megaautos.dao.AreaTrabajoDAO;
import pe.com.megaautos.model.AreaTrabajo;

@WebService(serviceName = "AreaTrabajoWS")
public class AreaTrabajoWS {

    private AreaTrabajoDAO daoAreaTrabajo;
    
    public AreaTrabajoWS(){
        daoAreaTrabajo = DBController.controller.getAreaTrabajoDAO();
    }

    @WebMethod(operationName = "listarAreaTrabajo")
    public ArrayList<AreaTrabajo> listarAreaTrabajo(){
        ArrayList<AreaTrabajo> areaTrabajos = new ArrayList<>();
        try{
            areaTrabajos = daoAreaTrabajo.listar();
        }catch(Exception ex){
            System.out.println(ex.getCause());
            System.out.println(ex.getMessage());
        }
        return areaTrabajos;
    }
    
    @WebMethod(operationName = "insertarAreaTrabajo")
    public int insertarAreaTrabajo(@WebParam(name = "objAreaTrabajo") AreaTrabajo areaTrabajo) {
        int resultado = 0;
        try{
            resultado = daoAreaTrabajo.insertar(areaTrabajo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarAreaTrabajo")
    public int actualizarAreaTrabajo(@WebParam(name = "objAreaTrabajo") AreaTrabajo areaTrabajo) {
        int resultado = 0;
        try{
            resultado = daoAreaTrabajo.actualizar(areaTrabajo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarAreaTrabajo")
    public int eliminarAreaTrabajo(@WebParam(name = "idAreaTrabajo") int idAreaTrabajo) {
        int resultado = 0;
        try{
            resultado = daoAreaTrabajo.eliminar(idAreaTrabajo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
