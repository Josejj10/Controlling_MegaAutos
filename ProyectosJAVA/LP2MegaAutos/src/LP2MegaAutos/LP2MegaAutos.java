/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LP2MegaAutos;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.ArrayList;
import pe.com.megaautos.dao.AreaTrabajoDAO;
import pe.com.megaautos.dao.VehiculoDAO;
import pe.com.megaautos.model.Vehiculo;
import pe.com.megaautos.mysql.VehiculoMySQL;
import pe.com.megaautos.mysql.ClienteMySQL;
import pe.com.megaautos.dao.ClienteDAO;
import pe.com.megaautos.dao.CuentaContableDAO;
import pe.com.megaautos.model.Cliente;
import pe.com.megaautos.dao.DriverDAO;
import pe.com.megaautos.dao.EmpresaDAO;
import pe.com.megaautos.dao.OrdenTrabajoDAO;
import pe.com.megaautos.model.Driver;
import pe.com.megaautos.model.Empresa;
import pe.com.megaautos.mysql.DriverMySQL;
import pe.com.megaautos.model.Sede;
import pe.com.megaautos.mysql.SedeMySQL;
import pe.com.megaautos.dao.SedeDAO;
import pe.com.megaautos.dao.ServicioDAO;
import pe.com.megaautos.model.Servicio;
import pe.com.megaautos.mysql.ServicioMySQL;
import pe.com.megaautos.dao.UsuarioDAO;
import pe.com.megaautos.model.AreaTrabajo;
import pe.com.megaautos.model.CuentaContable;
import pe.com.megaautos.model.OrdenTrabajo;
import pe.com.megaautos.model.Usuario;
import pe.com.megaautos.mysql.AreaTrabajoMySQL;
import pe.com.megaautos.mysql.CuentaContableMySQL;
import pe.com.megaautos.mysql.EmpresaMySQL;
import pe.com.megaautos.mysql.OrdenTrabajoMySQL;
import pe.com.megaautos.mysql.UsuarioMySQL;
/**
 *
 * @author Jose
 */
public class LP2MegaAutos {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws ParseException {
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
        Sede s1 = new Sede("Pueblo Libre");
//        Sede s2 = new Sede("Miraflores");
        SedeDAO daoSede = new SedeMySQL();
        daoSede.insertar(s1);
//        daoSede.insertar(s2);
//        ArrayList<Sede> sedes = new ArrayList<>();
//        sedes = daoSede.listar();
//        for(Sede d : sedes)
//            System.out.println(d.getDistrito());

        // Prueba Cliente/TipoCliente/Documento/TipoDocumento
        Cliente cl1 = new Cliente("LUIS PEREZ", "465445", "DNI", "45644564", "a2020@pucp.edu.pe", "Personal");
//        ClienteDAO daoCliente = new ClienteMySQL();
//        Cliente cl1 = new Cliente();
//        cl1 = daoCliente.buscar(13);
//        //daoCliente.insertar(cl1);
//        ArrayList<Cliente> clientes = new ArrayList<>();
//        clientes = daoCliente.listar();
//        for(Cliente c : clientes){
//            System.out.println(c.getId() + " " + c.getNombre() + " " + c.getTipoDocumento());
//        }
//        System.out.println(cl1.getNombre());


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
//        VehiculoDAO daoVehiculo = new VehiculoMySQL();
//        daoVehiculo.insertar(veh1);
//        ArrayList<Vehiculo> vehiculos = new ArrayList<>();
//        vehiculos = daoVehiculo.listar();
//        for(Vehiculo v : vehiculos)
//            System.out.println(v.getId() + " " + v.getPlaca() + " " + v.getTipoVehiculo() + " " + v.getPropietario().getNombre());
    
        // Prueba Usuario/TipoUsuario
//        Usuario us1 = new Usuario("Diego Berrospi", "a2040@pucp.edu.pe", "abc123", "Limpieza");
//        UsuarioDAO daoUsuario = new UsuarioMySQL();
//        daoUsuario.insertar(us1);
//        System.out.println(us1.getFechaCreado().getTime());
//        ArrayList<Usuario> usuarios = new ArrayList<>();
//        usuarios = daoUsuario.listar();
//        for(Usuario u : usuarios)
//            System.out.println(u.getId() + " " + u.getNombre() + " " + u.getCorreo() + " " + u.getTipoUsuario());

        // Prueba Empresa
//        Empresa emp1 = new Empresa("MegaAutos");
//        EmpresaDAO daoEmpresa = new EmpresaMySQL();
//        daoEmpresa.insertar(emp1);
//        ArrayList<Empresa> empresas = new ArrayList<>();
//        empresas = daoEmpresa.listar();
//        for(Empresa e : empresas)
//            System.out.println(e.getNombre());
        
        // Area Trabajo
//        AreaTrabajo at1 = new AreaTrabajo("Planchado");
//        AreaTrabajoDAO daoAreaTrabajo = new AreaTrabajoMySQL();
//        daoAreaTrabajo.insertar(at1);
//        ArrayList<AreaTrabajo> ats = new ArrayList<>();
//        ats = daoAreaTrabajo.listar();
//        for(AreaTrabajo at : ats)
//            System.out.println(at.getNombre());

        // Prueba Orden Trabajo
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        Date date = formato.parse("24-12-2020");
        OrdenTrabajo ot1 = new OrdenTrabajo("007-005", date, 4550.25, 3000.0, s1);
        OrdenTrabajoDAO daoOrdenTrabajo = new OrdenTrabajoMySQL();
        daoOrdenTrabajo.insertar(ot1);
        ot1.setCliente(cl1);
        ot1.setVehiculo(veh1);
        ArrayList<OrdenTrabajo> ots = new ArrayList<>();
        ots = daoOrdenTrabajo.listar();
        for(OrdenTrabajo ot : ots)
            System.out.println(ot.getNumeroOrden() + " " + ot.getCliente().getNombre() + " " + ot.getSede().getDistrito() + " " + ot.getVehiculo().getPlaca()); 

        // Prueba CuentaContable
//        CuentaContable ct1 = new CuentaContable("Planilla");
//        CuentaContableDAO daoCuentaContable = new CuentaContableMySQL();
//        daoCuentaContable.insertar(ct1);
//        ArrayList<CuentaContable> cts = new ArrayList<>();
//        cts = daoCuentaContable.listar();
//        for(CuentaContable ct : cts)
//            System.out.println(ct.getNombre());        
    }
}
