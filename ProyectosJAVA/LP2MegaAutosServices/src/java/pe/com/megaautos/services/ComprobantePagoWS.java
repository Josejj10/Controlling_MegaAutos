
package pe.com.megaautos.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.com.megaautos.config.DBController;
import pe.com.megaautos.dao.ComprobantePagoDAO;
import pe.com.megaautos.model.ComprobantePago;

/**
 *
 * @author JOSE
 */
@WebService(serviceName = "ComprobantePagoWS")
public class ComprobantePagoWS {

    private ComprobantePagoDAO daoComprobantePago;
    
    public ComprobantePagoWS(){
        daoComprobantePago = DBController.controller.getComprobantePagoDAO();
    }
    
    @WebMethod(operationName = "listarComprobantePago")
    public ArrayList<ComprobantePago> listarComprobantePago(){
        ArrayList<ComprobantePago> comprobantePagos = new ArrayList<>();
        try{
            comprobantePagos = daoComprobantePago.listar();
        }catch(Exception ex){
            System.out.println(ex.getCause());
            System.out.println(ex.getMessage());
        }
        return comprobantePagos;
    }
    
    @WebMethod(operationName = "insertarComprobantePago")
    public int insertarComprobantePago(@WebParam(name = "objComprobantePago") ComprobantePago cp) {
        int resultado = 0;
        try{
            resultado = daoComprobantePago.insertar(cp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarComprobantePago")
    public int actualizarComprobantePago(@WebParam(name = "objComprobantePago") ComprobantePago cp) {
        int resultado = 0;
        try{
            resultado = daoComprobantePago.actualizar(cp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarComprobantePago")
    public int eliminarComprobantePago(@WebParam(name = "idCp") int idCp) {
        int resultado = 0;
        try{
            resultado = daoComprobantePago.eliminar(idCp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
