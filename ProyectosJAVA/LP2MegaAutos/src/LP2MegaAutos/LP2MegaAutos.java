/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LP2MegaAutos;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.ArrayList;
import java.util.HashSet;
import pe.com.megaautos.dao.AreaTrabajoDAO;
import pe.com.megaautos.dao.VehiculoDAO;
import pe.com.megaautos.model.Vehiculo;
import pe.com.megaautos.mysql.VehiculoMySQL;
import pe.com.megaautos.mysql.ClienteMySQL;
import pe.com.megaautos.dao.ClienteDAO;
import pe.com.megaautos.dao.ComprobantePagoDAO;
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
import pe.com.megaautos.model.ComprobantePago;
import pe.com.megaautos.model.CuentaContable;
import pe.com.megaautos.model.OrdenTrabajo;
import pe.com.megaautos.model.Usuario;
import pe.com.megaautos.mysql.AreaTrabajoMySQL;
import pe.com.megaautos.mysql.ComprobantePagoMySQL;
import pe.com.megaautos.mysql.CuentaContableMySQL;
import pe.com.megaautos.mysql.EmpresaMySQL;
import pe.com.megaautos.mysql.OrdenTrabajoMySQL;
import pe.com.megaautos.mysql.UsuarioMySQL;
import pe.com.megaautos.config.DBDataSource;
/**
 *
 * @author Jose
 */
public class LP2MegaAutos {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws ParseException{
//        
//        try{
//            Connection con = DBDataSource.getConnection();
//            Statement st = con.createStatement();
//            String sql = "SELECT * FROM USUARIO";
//            ResultSet rs = st.executeQuery(sql);
//            while(rs.next()){
//                int id = rs.getInt("ID_USUARIO");
//                String nom = rs.getString("NOMBRE")+"\t";
//                String correo = rs.getString("CORREO")+"\t";
//                String pwd = rs.getString("PASSWRD");
//                System.out.println(id+"\t" + nom  + correo + pwd);
//            }                   
//        }
//        catch(Exception ex){
//            System.out.println(ex.getMessage());
//        }
//        
//        Usuario us1 = new Usuario("Diego Villegas", "a2040@pucp.edu.pe", "abc123", "Limpieza");
//        UsuarioDAO daoUsuario = new UsuarioMySQL();
//        daoUsuario.insertar(us1);
//        System.out.println(us1.getFechaCreado().getTime());
//        ArrayList<Usuario> usuarios = new ArrayList<>();
//        usuarios = daoUsuario.listar();
//        for(Usuario u : usuarios)
//            System.out.println(u.getId() + " " + u.getNombre() + " " + u.getCorreo() + " " + u.getTipoUsuario());

        ClienteDAO daoCliente = new ClienteMySQL();
        Cliente cl1 = new Cliente();
        cl1 = daoCliente.buscar(13);
        SedeDAO daoSede = new SedeMySQL();
        Sede s1 = new Sede();
        s1 = daoSede.buscar(2);
        VehiculoDAO daoVehiculo = new VehiculoMySQL();
        Vehiculo veh1 = new Vehiculo();
        veh1 = daoVehiculo.buscar(1);
        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        Date date = formato.parse("24-12-2020");
        OrdenTrabajo ot1 = new OrdenTrabajo("007-005", date, 4550.25, 3000.0, s1);
        OrdenTrabajoDAO daoOrdenTrabajo = new OrdenTrabajoMySQL();
        ot1.setCliente(cl1);
        ot1.setVehiculo(veh1);
        daoOrdenTrabajo.insertar(ot1);
        ArrayList<OrdenTrabajo> ots = new ArrayList<>();
        ots = daoOrdenTrabajo.listar();
        for(OrdenTrabajo ot : ots)
            System.out.println(ot.getNumeroOrden() + " " + ot.getCliente().getNombre() + " " + ot.getSede().getDistrito() + " " + ot.getVehiculo().getPlaca());

        
        /* PRUEBAS SQL
        //Prueba Driver
//        Driver dr = new Driver(1/10);
//        Driver dr2 = new Driver(2/5);
 //       DriverDAO daoDriver = new DriverMySQL();
//        daoDriver.insertar(dr);
//        daoDriver.insertar(dr2);
//        ArrayList<Driver> drivers = new ArrayList<>();
//        drivers = daoDriver.listar();
//        for(Driver d : drivers){
//            System.out.println(d.getFormula());
//        }
//        Driver dr3 = new Driver();
//        dr3 = daoDriver.buscar(3);
//        dr3.setFormula(0.65);
//        daoDriver.actualizar(dr3);
//        daoDriver.eliminar(6);
//        ArrayList<Driver> drivers = new ArrayList<>();
//        drivers = daoDriver.listar();
//        for(Driver d : drivers){
//            System.out.println(d.getFormula());
//        }

        // Prueba Sede
        //Sede s1 = new Sede("Pueblo Libre");
//        Sede s2 = new Sede("Miraflores");
//        SedeDAO daoSede = new SedeMySQL();
//        daoSede.insertar(s1);
//        daoSede.insertar(s2);

//        Sede s3 = new Sede();
//        s3 = daoSede.buscar(13);
//        s3.setDistrito("La Molina");
//        daoSede.actualizar(s3);
//        daoSede.eliminar(5);
//        ArrayList<Sede> sedes = new ArrayList<>();
//        sedes = daoSede.listar();
//        for(Sede d : sedes)
//            System.out.println(d.getDistrito());

        // Prueba Cliente/TipoCliente/Documento/TipoDocumento
        //Cliente cl1 = new Cliente("LUIS PEREZ", "465445", "DNI", "45644564", "a2020@pucp.edu.pe", "Personal");
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

//        Cliente c2 = new Cliente();
//        c2 = daoCliente.buscar(14);
//        c2.setTipoCliente("Empresa");
//        c2.setTelefono("4421210");
//        daoCliente.actualizar(c2);
//        daoCliente.eliminar(7);
//        ArrayList<Cliente> clientes = new ArrayList<>();
//        clientes = daoCliente.listar();
//        for(Cliente c : clientes){
//            System.out.println(c.getId() + " " + c.getNombre() + " " + c.getTipoDocumento());
//        }


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
        //Vehiculo veh1 = new Vehiculo("BBB-444", "Camion", cl1);
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
//        ClienteDAO daoCliente = new ClienteMySQL();
//        Cliente cl1 = new Cliente();
//        cl1 = daoCliente.buscar(13);
//        SedeDAO daoSede = new SedeMySQL();
//        Sede s1 = new Sede();
//        s1 = daoSede.buscar(2);
//        VehiculoDAO daoVehiculo = new VehiculoMySQL();
//        Vehiculo veh1 = new Vehiculo();
//        veh1 = daoVehiculo.buscar(1);
//        SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
//        Date date = formato.parse("24-12-2020");
//        OrdenTrabajo ot1 = new OrdenTrabajo("007-005", date, 4550.25, 3000.0, s1);
//        OrdenTrabajoDAO daoOrdenTrabajo = new OrdenTrabajoMySQL();
//        ot1.setCliente(cl1);
//        ot1.setVehiculo(veh1);
//        daoOrdenTrabajo.insertar(ot1);
//        ArrayList<OrdenTrabajo> ots = new ArrayList<>();
//        ots = daoOrdenTrabajo.listar();
//        for(OrdenTrabajo ot : ots)
//            System.out.println(ot.getNumeroOrden() + " " + ot.getCliente().getNombre() + " " + ot.getSede().getDistrito() + " " + ot.getVehiculo().getPlaca());

        // Prueba CuentaContable
//        CuentaContable ct1 = new CuentaContable("Planilla");
//        CuentaContableDAO daoCuentaContable = new CuentaContableMySQL();
//        daoCuentaContable.insertar(ct1);
//        ArrayList<CuentaContable> cts = new ArrayList<>();
//        cts = daoCuentaContable.listar();
//        for(CuentaContable ct : cts)
//            System.out.println(ct.getNombre());

        // Prueba Comprobante Pago
//        OrdenTrabajo ot1 = new OrdenTrabajo();
//        OrdenTrabajoDAO daoOrdenTrabajo = new OrdenTrabajoMySQL();
//        ot1 = daoOrdenTrabajo.buscar(1);
//
//        ComprobantePagoDAO daoComprobantePago = new ComprobantePagoMySQL();
//
//        ArrayList<ComprobantePago> cps = new ArrayList<>();
//        cps = daoComprobantePago.listar();
//        for(ComprobantePago cp : cps)
//            System.out.println(cp.getNumeroComprobante() + " " + cp.getTipoComprobante() + " " + cp.getOrdenTrabajo().getNumeroOrden());        
*/
    }
}
