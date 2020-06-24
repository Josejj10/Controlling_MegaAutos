
package pe.com.megaautos.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.com.megaautos.config.DBController;
import pe.com.megaautos.dao.AreaTrabajoCuentaContableDAO;
import pe.com.megaautos.model.AreaTrabajoCuentaContable;

@WebService(serviceName = "AreaTrabajoCuentaContableWS")
public class AreaTrabajoCuentaContableWS {

    private AreaTrabajoCuentaContableDAO daoAreaTrabajoCuentaContable;
    
    public AreaTrabajoCuentaContableWS(){
        daoAreaTrabajoCuentaContable = DBController.controller.getAreaTrabajoCuentaContableDAO();
    }
    
    @WebMethod(operationName = "listarAreaTrabajoCuentaContable")
    public ArrayList<AreaTrabajoCuentaContable> listarAreaTrabajoCuentaContable(@WebParam(name = "idAreaT") int id){
        ArrayList<AreaTrabajoCuentaContable> atcc = new ArrayList<>();
        try{
            atcc = daoAreaTrabajoCuentaContable.listar(id);
        }catch(Exception ex){
            System.out.println(ex.getCause());
            System.out.println(ex.getMessage());
        }
        return atcc;
    }
    
    @WebMethod(operationName = "insertarAreaTrabajoCuentaContable")
    public void insertarAreaTrabajoCuentaContable(@WebParam(name = "objAtcc") AreaTrabajoCuentaContable atcc) {
        int resultado = 0;
        try{
            daoAreaTrabajoCuentaContable.insertar(atcc);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
    
    @WebMethod(operationName = "actualizarAreaTrabajoCuentaContable")
    public int actualizarAreaTrabajoCuentaContable(@WebParam(name = "objAtcc") AreaTrabajoCuentaContable atcc) {
        int resultado = 0;
        try{
            resultado = daoAreaTrabajoCuentaContable.actualizar(atcc);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarAreaTrabajoCuentaContable")
    public int eliminarAreaTrabajoCuentaContable(@WebParam(name = "idAreaTrabajo") int idAreaTrabajo, @WebParam(name = "idCuentaContable") int idCuentaContable) {
        int resultado = 0;
        try{
            resultado = daoAreaTrabajoCuentaContable.eliminar(idAreaTrabajo,idCuentaContable);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
