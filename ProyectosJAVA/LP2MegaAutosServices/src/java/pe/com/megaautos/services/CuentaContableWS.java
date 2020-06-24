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
import pe.com.megaautos.dao.CuentaContableDAO;
import pe.com.megaautos.model.CuentaContable;


@WebService(serviceName = "CuentaContableWS")
public class CuentaContableWS {

    private CuentaContableDAO daoCuentaContable;
    
    public CuentaContableWS(){
        daoCuentaContable = DBController.controller.getCuentaContableDAO();
    }
    
    @WebMethod(operationName = "listarCuentaContable")
    public ArrayList<CuentaContable> listarCuentaContable(){
        ArrayList<CuentaContable> ccs = new ArrayList<>();
        try{
            ccs = daoCuentaContable.listar();
        }catch(Exception ex){
            System.out.println(ex.getCause());
            System.out.println(ex.getMessage());
        }
        return ccs;
    }
    
    @WebMethod(operationName = "insertarCuentaContable")
    public int insertarCuentaContable(@WebParam(name = "objCC") CuentaContable cc) {
        int resultado = 0;
        try{
            resultado = daoCuentaContable.insertar(cc);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarCuentaContable")
    public int actualizarCuentaContable(@WebParam(name = "objCC") CuentaContable cc) {
        int resultado = 0;
        try{
            resultado = daoCuentaContable.actualizar(cc);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarCuentaContable")
    public int eliminarCuentaContable(@WebParam(name = "idCC") int idCC) {
        int resultado = 0;
        try{
            resultado = daoCuentaContable.eliminar(idCC);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
