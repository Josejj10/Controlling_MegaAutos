/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LP2MegaAutos;
import static LP2MegaAutos.JoineryExtension.guardarBatch;
import static LP2MegaAutos.JoineryExtension.writeXlsx;
import static LP2MegaAutos.JoineryExtension.enviarCorreo;
import static LP2MegaAutos.JoineryExtension.insertarArchivoEntrada;
import static LP2MegaAutos.JoineryExtension.generarReporte;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.ArrayList;
import java.util.Collections;
import static java.util.Collections.sort;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.ListIterator;
import java.util.Map;
import java.util.Set;
import joinery.DataFrame;
import pe.com.megaautos.config.DAOFactory;
import pe.com.megaautos.config.DBController;
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
import pe.com.megaautos.dao.ExcelDAO;
import pe.com.megaautos.model.EPermisos;
import pe.com.megaautos.model.Excel;
import pe.com.megaautos.model.Reporte;
/**
 *
 * @author Jose
 */
public class LP2MegaAutos {

    public static void main(String[] args) throws ParseException, IOException{
        
        //Prueba correo
//        int i = enviarCorreo("rodrigo.dulanto@pucp.edu.pe");
        
//        UsuarioDAO daoUsuario = DBController.controller.getUsuarioDAO();
//        daoUsuario.actualizarPasswrd("rodrigo.dulanto@pucp.edu.pe", "Z7fMUX83IAcqBrIl", "1234");
        //Z7fMUX83IAcqBrIl
        
//        String sDate1="31/12/1998";  
//        Date date1=new SimpleDateFormat("dd/MM/yyyy").parse(sDate1);  
//        System.out.println(sDate1+"\t"+date1);  

        ExcelDAO daoExcel = DBController.controller.getExcelDAO();
        Excel excel = daoExcel.buscarPorId(69);
//        Excel excel2 = new Excel();
//        excel2.setArchivo(excel.getArchivo());
        int res = 0;
//        res = insertarArchivoEntrada(excel, 2); //69
        res = generarReporte("01-02-2020", "28-02-2020","tipoSiniestro",2,36,0);
        if(res==0)        System.out.println("No se encontro archivo");
        else System.out.println("Correcto");
        
        
                
        
//        
//        UsuarioDAO daoUsuario = DBController.controller.getUsuarioDAO();
//        Usuario u = new Usuario();
//        u = daoUsuario.buscarPorCorreo("t3@");
//        System.out.println(u.getId() + " " + u.getNombre() + " " + 
//               u.getCorreo() + " " + u.getTipoUsuario());
//        
//        for (EPermisos e : u.getPermisos()){
//            System.out.println(e);
//        }
//        
//        u.addPermisos(EPermisos.Servicios);
//        
//        int a = daoUsuario.actualizar(u);
//        Usuario u2 = new Usuario();
//        u2 = daoUsuario.buscarPorCorreo("t3@");
//        System.out.println(u2.getId() + " " + u2.getNombre() + " " + 
//                u2.getCorreo() + " " + u2.getTipoUsuario());
//        
//        for (EPermisos e : u2.getPermisos()){
//            System.out.println(e);
//        }
//        
//        u2.addPermisos(EPermisos.Sedes);
//        u2.addPermisos(EPermisos.Clientes);
//        u2.removePermiso(EPermisos.Servicios);
//        int b=daoUsuario.actualizar(u2);
//        Usuario u3 = new Usuario();
//        u3 = daoUsuario.buscarPorCorreo("t3@");
//        System.out.println(u3.getId() + " " + u3.getNombre() + " " + 
//                u3.getCorreo() + " " + u3.getTipoUsuario());
//        
//        for (EPermisos e : u3.getPermisos()){
//            System.out.println(e);
//        }
//        
////        Extraction
//        String ruta = "D:\\Documentos\\PUCP\\2020-1\\LP2\\Proyecto\\Archivos\\Cuadro.xlsx";
//        File initialFile = new File(ruta);
//        InputStream targetStream1 = new FileInputStream(initialFile);
////        InputStream targetStream2 = new FileInputStream(initialFile);
////        InputStream targetStream3 = new FileInputStream(initialFile);
////        InputStream targetStream4 = new FileInputStream(initialFile);
////        InputStream targetStream5 = new FileInputStream(initialFile);
////        
////        //Obtenemos el dfFact del documento en excel
//        DataFrame dfFact = JoineryExtension.readXlsx(targetStream1,5, 2);
//        int lastRow = dfFact.length()-1;
//        Date fechaIni = (Date)dfFact.slice(0, lastRow).sortBy(0).resetIndex().col(0).get(0);
//        Date fechaFin = (Date)dfFact.slice(0, lastRow).sortBy(0).resetIndex().col(0).get(lastRow-1);
//        System.out.println(dfFact);
//        
//        DataFrame dfAsig = JoineryExtension.readXlsx(targetStream2,1, 3);
//        DataFrame dfSalxAlm = JoineryExtension.readXlsx(targetStream3, 3, 3);
//        DataFrame dfCompras = JoineryExtension.readXlsx(targetStream4, 2, 2);
//        DataFrame dfCostos = JoineryExtension.readXlsx(targetStream5, 13, 2);
//
//        //Transformation
//        int lastRow = dfFact.length() - 1;
//        int lastCol = dfFact.size();
//        int lastColGris = 24; //Numero de la columna del data frame (empieza en 1)
//        DataFrame dfGris = dfFact.slice(0, lastRow, 0, lastColGris);
//        
//        //Para la tabla cliente:
//        DataFrame dfCliente = dfGris.retain("No OT", "R.U.C.", "Nombre / Razón Social");
//        dfCliente = dfCliente.unique("No OT").joinOn(dfAsig.retain("ORDEN DE TRABAJO", "TIPO DE CLIENTE").unique("ORDEN DE TRABAJO"), DataFrame.JoinType.INNER, "No OT");
//        int lastRowCli = dfCliente.length();
//        //Generamos la columna con el tipo de documento
//        List<String> tipoDoc = new ArrayList<>();
//        for (int i = 0; i < lastRowCli; i++){
//            int numDig = dfCliente.get(i, 1).toString().length();
//            if (numDig == 11)  tipoDoc.add("RUC");
//            else if (numDig == 8)  tipoDoc.add("DNI");
//            else tipoDoc.add("S/TIPO");
//        }
//        
//        int cantidad = tipoDoc.size();
//        List <String> a = new ArrayList<>();
//        for (int i=0; i<cantidad;i++){
//            a.add("-");
//        }
//        DataFrame tablaCliente = new DataFrame();
//        tablaCliente.add(dfCliente.col("Nombre / Razón Social"));
//        tablaCliente.add(dfCliente.col("TIPO DE CLIENTE"));
//        //System.out.println(tablaCliente);
//        tablaCliente.rename(0, "NOMBRE CLIENTE");
//        tablaCliente.rename(cantidad, "TIPO DE CLIENTE");
//        tablaCliente.add(tipoDoc);
//        tablaCliente.rename(cantidad, "TIPO DE DOCUMENTO");
//        tablaCliente.add(dfCliente.col("R.U.C."));
//        tablaCliente.rename(cantidad, "NUMERO DOCUMENTO");
//        tablaCliente.add(a);
//        tablaCliente.rename(cantidad, "TELEFONO");
//        tablaCliente.add(a);
//        tablaCliente.rename(cantidad, "CORREO");
//        tablaCliente = tablaCliente.unique("NOMBRE CLIENTE");
//        System.out.println(tablaCliente);
//        ClienteDAO daoCliente = DBController.controller.getClienteDAO();
//        //daoCliente.guardarBatch(tablaCliente);
//        
//        //Para la tabla Vehiculo
//        DataFrame dfVehiculo = dfGris.retain("No OT", "Placa", "Nombre / Razón Social");
//        dfVehiculo = dfVehiculo.unique("No OT").joinOn(dfAsig.retain("ORDEN DE TRABAJO", "MARCA", "MODELO").unique("ORDEN DE TRABAJO"), DataFrame.JoinType.INNER, "No OT");
//        int lastRowVeh = dfVehiculo.length();
//        //Generamos la columna con el tipo de documento
//        List<String> tipoVeh = new ArrayList<>();
//        String tipo;
//        for (int i = 0; i < lastRowVeh; i++){
//            tipo = dfVehiculo.get(i,4).toString() + " " + dfVehiculo.get(i,5).toString();
//            tipoVeh.add(tipo);
//        }        
//        DataFrame tablaVehiculo = new DataFrame();
//        tablaVehiculo.add(dfVehiculo.col("Placa"));
//        tablaVehiculo.rename(0, "PLACA");
//        tablaVehiculo.add(tipoVeh);
//        tablaVehiculo.rename(lastRowVeh, "TIPO VEHICULO");
//        tablaVehiculo.add(dfVehiculo.col("Nombre / Razón Social"));
//        tablaVehiculo.rename(lastRowVeh, "CLIENTE");
//        tablaVehiculo = tablaVehiculo.unique("PLACA");
//        System.out.println(tablaVehiculo);
//        VehiculoDAO daoVehiculo = DBController.controller.getVehiculoDAO();
//        //daoVehiculo.guardarBatch(tablaVehiculo);
//        
//        //Para la tabla Area de Trabajo
//        DataFrame tablaAreaTrabajo = dfGris.retain("División");
//        tablaAreaTrabajo = tablaAreaTrabajo.unique("División");
//        int cant = tablaAreaTrabajo.length();
//        List <Double>b = new ArrayList<>();
//        for (int i=0; i<cant;i++){
//            b.add(0.0);
//        }
//        tablaAreaTrabajo.rename("División", "Area de Trabajo"); 
//        tablaAreaTrabajo.add(b);
//        tablaAreaTrabajo.rename(cant, "MONTO"); 
//        tablaAreaTrabajo.add(b);        
//        System.out.println(tablaAreaTrabajo);
//        AreaTrabajoDAO daoAreaTrabajo = DBController.controller.getAreaTrabajoDAO();
//        //daoAreaTrabajo.guardarBatch(tablaAreaTrabajo);
//        
//        //Para la tabla Orden de Trabajo
//        DataFrame dfOT = dfGris.retain("No OT", "Sin_IGV").groupBy("No OT").sum(); //REVISAR
//        int lastRowOT = dfOT.length();
//        
//        //Calculamos Salidas_Almacen
//        dfSalxAlm = dfSalxAlm.retain("Total S/.", "OT").groupBy("OT").sum();
//        List<Double> salidas_alm = new ArrayList<>();
//        double celda;
//        int elem;
//        for (int i = 0; i < lastRowOT; i++){
//            String OT = dfOT.get(i, 0).toString();
//            elem = dfSalxAlm.col(0).indexOf(OT);
//            if (elem != -1) {
//                celda = (Double)dfSalxAlm.get(elem ,1);
//                salidas_alm.add(celda);                    
//            }
//            else    salidas_alm.add(0.0);
//        }
////        dfOT.add(salidas_alm); //CHECK
////        dfOT.rename(lastRowOT, "Salidas_Almacen");
//        
//        //Calculamos Compras_Rpto y Serv_Terceros
//        dfCompras = dfCompras.retain("OT", "CLAS_SERV", "MONTO").groupBy("OT", "CLAS_SERV").sum();
//        List<Double> compras_rpto = new ArrayList<>();
//        for (int i = 0; i < lastRowOT; i++){
//            String OT = dfOT.get(i, 0).toString();
//            elem = dfCompras.col(0).indexOf(OT);
//            if (elem != -1){
//                String tipoServ = dfCompras.get(elem, 1).toString();
//                if (tipoServ.contentEquals("RP")){
//                    celda = (Double)dfCompras.get(elem ,2);
//                    compras_rpto.add(celda);
//                }
//                else    compras_rpto.add(0.0);
//            }
//            else    compras_rpto.add(0.0);
//        }        
////        dfOT.add(compras_rpto); //CHECK
////        dfOT.rename(lastRowOT, "Compras_Rpto");
//
//        List<Double> serv_terceros = new ArrayList<>();
//        for (int i = 0; i < lastRowOT; i++){
//            String OT = dfOT.get(i, 0).toString();
//            elem = dfCompras.col(0).indexOf(OT);
//            if (elem != -1){
//                String tipoServ = dfCompras.get(elem, 1).toString();
//                if (tipoServ.contentEquals("ST")){
//                    celda = (Double)dfCompras.get(elem ,2);
//                    serv_terceros.add(celda);
//                }
//                else    serv_terceros.add(0.0);
//            }
//            else    serv_terceros.add(0.0);
//        } 
////        dfOT.add(serv_terceros); //CHECK
////        dfOT.rename(lastRowOT, "Serv_Terceros");
//
//        DataFrame dfMO = dfAsig.retain("ORDEN DE TRABAJO", "HORA AJUSTADA", "TERCEROS / PLANCHADOR" ,"PAÑOS AJUSTADOS", "TERCEROS/PINTOR ($)","HORAS MECÁNICA")
//                               .groupBy("ORDEN DE TRABAJO")
//                               .sum();
//        //System.out.println(dfMO);
//        //System.out.println(dfCostos);
//        List<Double> mo_mecanica = new ArrayList<>();
//        List<Double> mo_planchado = new ArrayList<>();
//        List<Double> mo_pintura = new ArrayList<>();
//        List<Double> serv_ter = new ArrayList<>();
//        for (int i = 0; i < lastRowOT; i++){
//            String OT = dfOT.get(i, 0).toString();
//            elem = dfMO.col(0).indexOf(OT);
//            if (elem != -1){
//                double hora_planchado = (Double)dfMO.get(elem, 1);
//                double terc_plan = (Double)dfMO.get(elem, 2);
//                double panio_pint = (Double)dfMO.get(elem, 3);
//                double terc_pint = (Double)dfMO.get(elem, 4);
//                double hora_mec = (Double)dfMO.get(elem, 5);
//                double tipoCambio = (Double)dfCostos.get(3, 1);
//                mo_mecanica.add(hora_mec*(Double)dfCostos.get(2, 1)*tipoCambio);
//                mo_planchado.add(hora_planchado*(Double)dfCostos.get(0, 1)*tipoCambio);
//                mo_pintura.add(panio_pint*(Double)dfCostos.get(1, 1)*tipoCambio);
//                serv_ter.add(terc_plan*tipoCambio + terc_pint*tipoCambio);
//            }
//            else{
//                mo_mecanica.add(0.0);
//                mo_pintura.add(0.0);
//                mo_planchado.add(0.0);
//                serv_ter.add(0.0);
//            }
//        }
////        dfOT.add(mo_mecanica); //CHECK
////        dfOT.rename(lastRowOT, "MO_Mecanica");
////        dfOT.add(mo_planchado); //CHECK
////        dfOT.rename(lastRowOT, "MO_Planchado");        
////        dfOT.add(mo_pintura); //CHECK
////        dfOT.rename(lastRowOT, "MO_Pintura");
////        dfOT.add(serv_ter); //CHECK
////        dfOT.rename(lastRowOT, "Ser_Ter_Taller");
//
//        List<Double> total_gastos = new ArrayList<>();
//        //Unimos todas las columnas para obtener el total gastos
//        for (int i = 0; i < lastRowOT; i++){
//            double suma = salidas_alm.get(i) + compras_rpto.get(i) + serv_terceros.get(i) + 
//                          mo_mecanica.get(i) + mo_planchado.get(i) + mo_pintura.get(i) +
//                          serv_ter.get(i);
//            total_gastos.add(suma);
//        }
//        dfOT.add(total_gastos); //CHECK
//        dfOT.rename(lastRowOT, "TOTAL GASTOS");  
//        dfOT = dfOT.joinOn(dfGris.retain("No OT", "Placa", "Nombre / Razón Social").unique("No OT"), DataFrame.JoinType.INNER, "No OT");
//        dfOT = dfOT.resetIndex().drop("No OT_right");
//        dfOT.rename("No OT_left", "ORDEN DE TRABAJO");
//        dfOT.rename("Sin_IGV", "TOTAL INGRESOS");
//        dfOT.rename("Placa", "PLACA");
//        dfOT.rename("Nombre / Razón Social", "CLIENTE");
//        System.out.println(dfOT);
//        String ruta2 = "D:\\Documentos\\PUCP\\2020-1\\LP2\\Proyecto\\Archivos\\CuadroSalida.xlsx";
//        File initialFile2 = new File(ruta2);
//        OutputStream targetStreamA = new FileOutputStream(initialFile2);
//        writeXlsx(dfOT, targetStreamA);
//        //Crear un archivo y guardarlo en una ruta del servidor
//        //Enviar ese archivo a la bd
//        
//BUSCAR UN ELEMENTO EN UN DATAFRAME WARD!!!!
//        int elem = dfCliente.col(0).indexOf("005-00000058");
//        System.out.println(dfCliente.get(elem, 4).toString());

        //Load
        
        
//        for (ListIterator<Object> iter = dfFact.iterator(); iter.hasNext(); ) {
//            Object e = iter.next();
//            System.out.println(e);
//        }
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
//
//        
        //PRUEBAS SQL
        //Prueba Driver
//        Driver dr = new Driver(1/10);
//        Driver dr2 = new Driver(2/5);
//        DriverDAO daoDriver = DBController.controller.getDriverDAO();
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
//        //ArrayList<Driver> drivers = new ArrayList<>();
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
//
//        //Prueba Cliente/TipoCliente/Documento/TipoDocumento
//        Cliente cl1 = new Cliente("LUIS PEREZ", "465445", "DNI", "45644564", "a2020@pucp.edu.pe", "Personal");
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
        /*ClienteDAO daoCliente = DBController.controller.getClienteDAO();
        Cliente c2 = new Cliente();
        c2 = daoCliente.buscar(18);
        c2.setNombre("Diego Tuestin");
        daoCliente.actualizar(c2);*/
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

//        // Prueba Orden Trabajo
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
    }
}
