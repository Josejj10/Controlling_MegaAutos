
package pe.com.megaautos.services;

import java.util.ArrayList;
import java.util.Arrays;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.com.megaautos.config.DBController;
import pe.com.megaautos.dao.DriverDAO;
import pe.com.megaautos.model.Driver;

/**
 *
 * @author JOSE
 */
@WebService(serviceName = "DriverWS")
public class DriverWS {

    private DriverDAO daoDriver;
    
    public DriverWS(){
        daoDriver = DBController.controller.getDriverDAO();
    }
    
    @WebMethod(operationName = "listarDrivers")
    public ArrayList<Driver> listarDrivers(){
        ArrayList<Driver> drivers = new ArrayList<>();
        try{
            drivers = daoDriver.listar();
        }catch(Exception ex){
            System.out.println(ex.getCause());
            System.out.println(ex.getMessage());
        }
        if(drivers == null) return new ArrayList<Driver>(Arrays.asList(new Driver()));
        return drivers;
    }
    
    @WebMethod(operationName = "listarDrivers2")
    public ArrayList<Driver> listarDrivers2(){
        ArrayList<Driver> drivers = new ArrayList<>();
//        try{
//            drivers = daoDriver.listar();
//        }catch(Exception ex){
//            System.out.println(ex.getCause());
//            System.out.println(ex.getMessage());
//        }
        Driver driver = new Driver();
        drivers.add(driver);
        return drivers;
    }
    
    @WebMethod(operationName = "insertarDriver2")
    public int insertarDriver(@WebParam(name = "objDriver") Driver driver) {
        int resultado = 0;
        try{
            resultado = daoDriver.insertar(driver);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarDriver")
    public int actualizarDriver(@WebParam(name = "objDriver") Driver driver) {
        int resultado = 0;
        try{
            resultado = daoDriver.actualizar(driver);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarDriver")
    public int eliminarDriver(@WebParam(name = "idDriver") int idDriver) {
        int resultado = 0;
        try{
            resultado = daoDriver.eliminar(idDriver);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

}
