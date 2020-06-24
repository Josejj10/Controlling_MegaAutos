
package pe.com.megaautos.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.com.megaautos.config.DBController;
import pe.com.megaautos.dao.SedeDAO;
import pe.com.megaautos.model.Sede;

/**
 *
 * @author Rodrigo
 */
@WebService(serviceName = "SedeWS")
public class SedeWS {

    private SedeDAO daoSede;
    
    public SedeWS(){
        daoSede = DBController.controller.getSedeDAO();
    }
    
    @WebMethod(operationName = "listarSedes")
    public ArrayList<Sede> listarSedes(){
        ArrayList<Sede> sedes = new ArrayList<>();
        try{
            sedes = daoSede.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return sedes;
    }
    
    @WebMethod(operationName = "insertarSede")
    public int insertarSede(@WebParam(name = "objSede") Sede sede) {
        int resultado = 0;
        try{
            resultado = daoSede.insertar(sede);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarSede")
    public int actualizarSede(@WebParam(name = "objSede") Sede sede) {
        int resultado = 0;
        try{
            resultado = daoSede.actualizar(sede);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarSede")
    public int eliminarSede(@WebParam(name = "idSede") int idSede) {
        int resultado = 0;
        try{
            resultado = daoSede.eliminar(idSede);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
