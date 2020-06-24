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
import pe.com.megaautos.dao.EmpresaDAO;
import pe.com.megaautos.model.Empresa;

@WebService(serviceName = "EmpresaWS")
public class EmpresaWS {

    private EmpresaDAO daoEmpresa;
    
    public EmpresaWS(){
        daoEmpresa = DBController.controller.getEmpresaDAO();
    }
    
    @WebMethod(operationName = "listarEmpresa")
    public ArrayList<Empresa> listarDrivers(){
        ArrayList<Empresa> empresas = new ArrayList<>();
        try{
            empresas = daoEmpresa.listar();
        }catch(Exception ex){
            System.out.println(ex.getCause());
            System.out.println(ex.getMessage());
        }
        return empresas;
    }
    
    @WebMethod(operationName = "insertarEmpresa")
    public int insertarEmpresa(@WebParam(name = "objEmrpesa") Empresa empresa) {
        int resultado = 0;
        try{
            resultado = daoEmpresa.insertar(empresa);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarEmpresa")
    public int actualizarEmpresa(@WebParam(name = "objEmpresa") Empresa empresa) {
        int resultado = 0;
        try{
            resultado = daoEmpresa.actualizar(empresa);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarEmpresa")
    public int eliminarEmpresa(@WebParam(name = "idEmpresa") int idEmpresa) {
        int resultado = 0;
        try{
            resultado = daoEmpresa.eliminar(idEmpresa);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
