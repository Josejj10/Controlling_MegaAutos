/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.services;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.com.megaautos.model.Excel;

/**
 *
 * @author Rodrigo
 */
@WebService(serviceName = "ExcelWS")
public class ExcelWS {

    public ExcelWS(){
        
    }
    @WebMethod(operationName = "leerExcel1")
    public Excel leerExcel(@WebParam(name = "excel1") byte[] excel1, @WebParam(name = "excel2") byte[] excel2) {
        Excel excel = new Excel();
        excel.setExcel1(excel1);
        excel.setExcel2(excel2);        
        return excel;
    }
    
    @WebMethod(operationName = "enviarExcel")
    public Excel enviarExcel(@WebParam(name="excel") Excel excel){
        return excel;
    }
}
