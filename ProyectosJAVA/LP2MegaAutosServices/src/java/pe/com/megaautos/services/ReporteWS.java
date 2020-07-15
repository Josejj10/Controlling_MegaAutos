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
import pe.com.megaautos.dao.ReporteDAO;
import pe.com.megaautos.model.Reporte;

/**
 *
 * @author Rodrigo
 */
@WebService(serviceName = "ReporteWS")
public class ReporteWS {

    private ReporteDAO daoReporte;
    
    public ReporteWS(){
        daoReporte = DBController.controller.getReporteDAO();
    }
    
    @WebMethod(operationName = "listarReportes")
    public ArrayList<Reporte> listarReportes(){
        ArrayList<Reporte> reportes = new ArrayList<>();
        try{
            reportes = daoReporte.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return reportes;
    }
    
    @WebMethod(operationName = "insertarReporte")
    public int insertarReporte(@WebParam(name = "reporte") Reporte reporte) {
        int resultado = 0;
        try{
            resultado = daoReporte.insertar(reporte);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "buscarReportePorId")
    public Reporte buscarReportePorId(@WebParam(name="idReporte") int idReporte){
        Reporte cliente = new Reporte();
        try{
            cliente = daoReporte.buscarPorId(idReporte);
        }catch(Exception ex){
            System.out.println(ex.getCause());
            System.out.println(ex.getMessage());
        }
        return cliente;
    } 
    
}
