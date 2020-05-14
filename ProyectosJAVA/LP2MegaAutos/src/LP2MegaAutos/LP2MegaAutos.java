/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LP2MegaAutos;

import java.util.ArrayList;
import pe.com.megaautos.dao.VehiculoDAO;
import pe.com.megaautos.model.Vehiculo;
import pe.com.megaautos.mysql.VehiculoMySQL;
import pe.com.megaautos.mysql.ClienteMySQL;
import pe.com.megaautos.dao.ClienteDAO;
import pe.com.megaautos.model.Cliente;
import pe.com.megaautos.dao.DriverDAO;
import pe.com.megaautos.model.Driver;
import pe.com.megaautos.mysql.DriverMySQL;
/**
 *
 * @author Jose
 */
public class LP2MegaAutos {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        //Vehiculo vehiculo= new Vehiculo("");
        /*ArrayList<Vehiculo> vehiculos =
                new ArrayList<>();
        
        VehiculoDAO daoVehiculo = 
                new VehiculoMySQL();
        
        daoVehiculo.insertar(vehiculo);
        vehiculos = daoVehiculo.listar();
        
        */
        
        // hola
        Driver dr = new Driver(1/10);
        Driver dr2 = new Driver(2/5);
        DriverDAO daoDriver = new DriverMySQL();
        daoDriver.insertar(dr);
        daoDriver.insertar(dr2);
        ArrayList<Driver> drivers = new ArrayList<>();
        drivers = daoDriver.listar();
        for(Driver d : drivers){
            System.out.println(d.getFormula());
        }
    }

}
