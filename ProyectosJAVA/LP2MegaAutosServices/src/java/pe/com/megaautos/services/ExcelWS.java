/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.services;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.com.megaautos.config.DBController;
import pe.com.megaautos.dao.ExcelDAO;
import pe.com.megaautos.model.Excel;

/**
 *
 * @author Rodrigo
 */
@WebService(serviceName = "ExcelWS")
public class ExcelWS {
private ExcelDAO daoExcel;
    public ExcelWS(){
        daoExcel = DBController.controller.getExcelDAO();
    }
    @WebMethod(operationName = "insertarArchivoEntrada")
    public int insertarArchivoEntrada(@WebParam(name = "archivo") Excel excel) {
        int resultado = 0;
        try{
            resultado = daoExcel.insertarArchivoEntrada(excel);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "insertarArchivoSalida")
    public int insertarArchivoSalida(@WebParam(name = "archivo") Excel excel) {
        int resultado = 0;
        try{
            resultado = daoExcel.insertarArchivoSalida(excel);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "leerArchivoSalida")
    public Excel leerArchivoSalida(){
        Excel excel = new Excel();
        try{
            excel = daoExcel.leerArchivoSalida();
        }catch(Exception ex){
            System.out.println(ex.getCause());
            System.out.println(ex.getMessage());
        }
        return excel;
    }
    
    @WebMethod(operationName = "leerArchivoEntrada")
    public Excel leerArchivoEntrada(){
        Excel excel = new Excel();
        try{
            excel = daoExcel.leerArchivoEntrada();
        }catch(Exception ex){
            System.out.println(ex.getCause());
            System.out.println(ex.getMessage());
        }
        return excel;
    }
}
