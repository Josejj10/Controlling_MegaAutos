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
import pe.com.megaautos.model.Empresa;
import pe.com.megaautos.mysql.DriverMySQL;
import pe.com.megaautos.model.Sede;
import pe.com.megaautos.mysql.SedeMySQL;
import pe.com.megaautos.dao.SedeDAO;
import pe.com.megaautos.dao.ServicioDAO;
import pe.com.megaautos.model.Servicio;
import pe.com.megaautos.mysql.ServicioMySQL;
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
        
        //Prueba Driver
//        Driver dr = new Driver(1/10);
//        Driver dr2 = new Driver(2/5);
//        DriverDAO daoDriver = new DriverMySQL();
//        daoDriver.insertar(dr);
//        daoDriver.insertar(dr2);
//        ArrayList<Driver> drivers = new ArrayList<>();
//        drivers = daoDriver.listar();
//        for(Driver d : drivers){
//            System.out.println(d.getFormula());
//        }

        // Prueba Sede
//        Sede s1 = new Sede("Pueblo Libre");
//        Sede s2 = new Sede("Miraflores");
//        SedeDAO daoSede = new SedeMySQL();
//        daoSede.insertar(s1);
//        daoSede.insertar(s2);
//        ArrayList<Sede> sedes = new ArrayList<>();
//        sedes = daoSede.listar();
//        for(Sede d : sedes)
//            System.out.println(d.getDistrito());

        // Prueba Cliente/TipoCliente/Documento/TipoDocumento
        Cliente cl1 = new Cliente("LUIS PEREZ", "465445", "DNI", "45644564", "a2020@pucp.edu.pe", "Personal");
        ClienteDAO daoCliente = new ClienteMySQL();
        daoCliente.insertar(cl1);
        ArrayList<Cliente> clientes = new ArrayList<>();
        clientes = daoCliente.listar();
        for(Cliente c : clientes){
            System.out.println(c.getId() + " " + c.getNombre() + " " + c.getTipoDocumento());
        }


        // Prueba Servicio/TipoServicio
//        Servicio serv1 = new Servicio("Cambio de aceite", "Mecanica");
//        Servicio serv2 = new Servicio("Pintura en spray","Pintura");
//        ServicioDAO daoServicio = new ServicioMySQL();
//        daoServicio.insertar(serv1);
//        daoServicio.insertar(serv2);
//        ArrayList<Servicio> servicios = new ArrayList<>();
//        servicios = daoServicio.listar();
//        for(Servicio s : servicios){
//            System.out.println(s.getCodigoServicio() + " " + s.getDescripcion() + " " + s.getTipoServicio());
//        }

        // Prueba Vehiculo
        Vehiculo veh1 = new Vehiculo("BBB-444", "Camion", cl1);
        VehiculoDAO daoVehiculo = new VehiculoMySQL();
        daoVehiculo.insertar(veh1);
        ArrayList<Vehiculo> vehiculos = new ArrayList<>();
        vehiculos = daoVehiculo.listar();
        for(Vehiculo v : vehiculos)
            System.out.println(v.getId() + " " + v.getPlaca() + " " + v.getTipoVehiculo() + " " + v.getPropietario().getNombre());
    }

}
