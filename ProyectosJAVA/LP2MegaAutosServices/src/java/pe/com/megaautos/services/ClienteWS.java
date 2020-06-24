
package pe.com.megaautos.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.com.megaautos.config.DBController;
import pe.com.megaautos.dao.ClienteDAO;
import pe.com.megaautos.model.Cliente;

/**
 *
 * @author JOSE
 */
@WebService(serviceName = "ClienteWS")
public class ClienteWS {

    private ClienteDAO daoCliente;
    
    public ClienteWS(){
        daoCliente = DBController.controller.getClienteDAO();
    }
    
    @WebMethod(operationName = "listarClientes")
    public ArrayList<Cliente> listarDrivers(){
        ArrayList<Cliente> clientes = new ArrayList<>();
        try{
            clientes = daoCliente.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return clientes;
    }
    
    @WebMethod(operationName = "insertarCliente")
    public int insertarCliente(@WebParam(name = "objCliente") Cliente cliente) {
        int resultado = 0;
        try{
            resultado = daoCliente.insertar(cliente);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarCliente")
    public int actualizarCliente(@WebParam(name = "objCliente") Cliente cliente) {
        int resultado = 0;
        try{
            resultado = daoCliente.actualizar(cliente);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarCliente")
    public int eliminarCliente(@WebParam(name = "idCliente") int idCliente) {
        int resultado = 0;
        try{
            resultado = daoCliente.eliminar(idCliente);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
