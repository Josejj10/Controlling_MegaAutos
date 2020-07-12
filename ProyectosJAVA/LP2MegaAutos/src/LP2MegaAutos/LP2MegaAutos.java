/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LP2MegaAutos;
import static LP2MegaAutos.JoineryExtension.guardarBatch;
import static LP2MegaAutos.JoineryExtension.writeXlsx;
import static LP2MegaAutos.JoineryExtension.enviarCorreo;
import java.io.ByteArrayInputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.ArrayList;
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
import pe.com.megaautos.model.EPermisos;
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
        
        /*
        UsuarioDAO daoUsuario = DBController.controller.getUsuarioDAO();
        Usuario u = new Usuario();
        u = daoUsuario.buscarPorCorreo("t@");
        System.out.println(u.getId() + " " + u.getNombre() + " " + 
               u.getCorreo() + " " + u.getTipoUsuario());
        
        for (EPermisos e : u.getPermisos()){
            System.out.println(e);
        }
        
        u.addPermisos(EPermisos.Servicios);
        
        int a = daoUsuario.actualizar(u);
        Usuario u2 = new Usuario();
        u2 = daoUsuario.buscarPorCorreo("t@");
        System.out.println(u2.getId() + " " + u2.getNombre() + " " + 
                u2.getCorreo() + " " + u2.getTipoUsuario());
        
        for (EPermisos e : u2.getPermisos()){
            System.out.println(e);
        }
        
        u2.addPermisos(EPermisos.Sedes);
        u2.addPermisos(EPermisos.Clientes);
        u2.removePermiso(EPermisos.Servicios);
        int b=daoUsuario.actualizar(u2);
        Usuario u3 = new Usuario();
        u3 = daoUsuario.buscarPorCorreo("t@");
        System.out.println(u3.getId() + " " + u3.getNombre() + " " + 
                u3.getCorreo() + " " + u3.getTipoUsuario());
        
        for (EPermisos e : u3.getPermisos()){
            System.out.println(e);
        }*/
//        
        String ruta = "C:\\Users\\Nicolas\\Desktop\\PUCP\\Clases\\20-1\\TA\\Cuadro.xlsx";
        File initialFile = new File(ruta);
        InputStream targetStream1 = new FileInputStream(initialFile);
        InputStream targetStream2 = new FileInputStream(initialFile);
        InputStream targetStream3 = new FileInputStream(initialFile);
        InputStream targetStream4 = new FileInputStream(initialFile);
        InputStream targetStream5 = new FileInputStream(initialFile);

        //Obtenemos el dfFact del documento en excel
        DataFrame dfFact = JoineryExtension.readXlsx(targetStream1,5, 2);
        DataFrame dfAsig = JoineryExtension.readXlsx(targetStream2,1, 3);
        DataFrame dfSalxAlm = JoineryExtension.readXlsx(targetStream3, 3, 3);
        DataFrame dfCompras = JoineryExtension.readXlsx(targetStream4, 2, 2);
        DataFrame dfCostos = JoineryExtension.readXlsx(targetStream5, 13, 2);

        //Transformation
        int lastRow = dfFact.length() - 1;
        int lastColGris = 23; //Numero de la columna del data frame (empieza en 1)
        DataFrame dfGris = dfFact.slice(0, lastRow, 0, lastColGris);

        //Calculamos la columna Sin_IGV para todo el dataframe
        List<Double> sin_igv = new ArrayList<>();
        List<String> mes = new ArrayList<>();
        List<String> dia = new ArrayList<>();
        List<String> anio = new ArrayList<>();
        DateFormat dateFormat = new SimpleDateFormat("yyyyMMdd");
        List<Integer> prior = new ArrayList<>();

        //SI QUEREMOS UN REPORTE MENSUAL LA FUNCION RECIBE MES Y ANIO
        for (int i = 0; i < lastRow; i++){
            if (dfGris.get(i, 1).toString().equals("ABO")) prior.add(3);
            else if (dfGris.get(i, 1).toString().equals("BOL")) prior.add(1);
            else if (dfGris.get(i, 1).toString().equals("FAC")) prior.add(2);
            else if (dfGris.get(i, 1).toString().equals("CAR")) prior.add(3);
            String strDate = dateFormat.format(dfGris.get(i,0));
            anio.add(strDate.substring(0, 4));
            mes.add(strDate.substring(4, 6));
            dia.add(strDate.substring(6, 8));

            String tipoMoneda = dfGris.get(i, 16).toString(); 
            if (tipoMoneda.contentEquals("$")) {
                Double tCambio = (Double)dfGris.get(i, 17);
                sin_igv.add(tCambio*(Double)dfGris.get(i, 20));
            }
            else sin_igv.add((Double)dfGris.get(i,20));
        }

        dfGris.add(sin_igv);
        dfGris.rename(lastRow, "Sin_IGV");
        dfGris.add(prior);
        dfGris.rename(lastRow, "PRIOR");
        dfGris.add(anio);
        dfGris.rename(lastRow, "ANIO");
        dfGris.add(mes);
        dfGris.rename(lastRow, "MES");
        dfGris.add(dia);
        dfGris.rename(lastRow, "DIA");    
        //System.out.println(dfGris);

        //Para el reporte Orden de Trabajo
        dfGris = dfGris.sortBy(4).resetIndex();
        dfGris = dfGris.sortBy(24).resetIndex();
        int first3 = dfGris.col(24).indexOf(3);
        dfGris = dfGris.slice(0, first3);
        dfGris = dfGris.sortBy(4).resetIndex();

        DataFrame dfOT = dfGris.retain("ANIO", "MES", "No OT", "Sin_IGV").groupBy("No OT", "ANIO", "MES").sum();
        dfOT = dfOT.resetIndex();
        int lastRowOT = dfOT.length();    

        String strAnio = "2020", strMes = "02", strDia;        
        List<Integer> filtFecha = new ArrayList<>();
        //Filtramos el DF en base a la fecha solicitada:
        for(int i = 0; i<lastRowOT; i++){
            if(dfOT.get(i, 1).toString().equals(strAnio) && dfOT.get(i, 2).toString().equals(strMes))
                filtFecha.add(1);
            else    filtFecha.add(-1);
        }
        dfOT.add(filtFecha);
        dfOT.rename(lastRowOT, "FiltFecha");
        dfOT = dfOT.sortBy("FiltFecha").resetIndex();
        int firstDate = dfOT.col("FiltFecha").indexOf(1);
        dfOT = dfOT.slice(firstDate, lastRowOT);
        dfOT = dfOT.sortBy("No OT").resetIndex();
        lastRowOT = dfOT.length(); 
        //System.out.println(dfOT);  

        //Calculamos el detalle de los GASTOS
        dfSalxAlm = dfSalxAlm.retain("Total S/.", "OT").groupBy("OT").sum();
        dfCompras = dfCompras.retain("OT", "CLAS_SERV", "MONTO").groupBy("OT", "CLAS_SERV").sum();
        dfCompras = dfCompras.sortBy("CLAS_SERV");
        int firstST = dfCompras.col(1).indexOf("ST");
        int lastRowComp = dfCompras.length();
        DataFrame dfRP = dfCompras.slice(0, firstST - 1);
        DataFrame dfST = dfCompras.slice(firstST, lastRowComp);
        DataFrame dfMO = dfAsig.retain("ORDEN DE TRABAJO", "HORA AJUSTADA", "TERCEROS / PLANCHADOR" ,"PAÑOS AJUSTADOS", "TERCEROS/PINTOR ($)","HORAS MECÁNICA")
                               .groupBy("ORDEN DE TRABAJO")
                               .sum();

        List<Double> salidas_alm = new ArrayList<>();
        List<Double> compras_rpto = new ArrayList<>();
        List<Double> serv_terceros = new ArrayList<>();
        List<Double> mo_mecanica = new ArrayList<>();
        List<Double> mo_planchado = new ArrayList<>();
        List<Double> mo_pintura = new ArrayList<>();
        List<Double> serv_ter = new ArrayList<>();
        List<Double> total_gastos = new ArrayList<>();
        List<Double> margen = new ArrayList<>();
        List<Double> porc = new ArrayList<>();
        List<String> clientes = new ArrayList<>();
        List<String> placas = new ArrayList<>();
        List<String> tipo_cli = new ArrayList<>();
        List<String> tipo_sin = new ArrayList<>();
        List<String> marca = new ArrayList<>();
        List<String> modelo = new ArrayList<>();
        double celda;
        int elem;
        String OT;

        for (int i = 0; i < lastRowOT; i++){
            OT = dfOT.get(i, 0).toString();
            //Calculamos salidas x almacen
            elem = dfSalxAlm.col(0).indexOf(OT);
            if (elem != -1) {
                celda = (Double)dfSalxAlm.get(elem ,1);
                salidas_alm.add(celda);                    
            }
            else    salidas_alm.add(0.0);

            //Calculamos las compras rpto y serv_terceros
            elem = dfRP.col(0).indexOf(OT);
            if (elem != -1){
                    celda = (Double)dfRP.get(elem ,2);
                    compras_rpto.add(celda);
            }
            else    compras_rpto.add(0.0);

            elem = dfST.col(0).indexOf(OT);
            if (elem != -1){
                    celda = (Double)dfST.get(elem ,2);
                    serv_terceros.add(celda);
            }
            else    serv_terceros.add(0.0); 

            //Calculamos las MO
            elem = dfMO.col(0).indexOf(OT);
            if (elem != -1){
                double hora_planchado = (Double)dfMO.get(elem, 1);
                double terc_plan = (Double)dfMO.get(elem, 2);
                double panio_pint = (Double)dfMO.get(elem, 3);
                double terc_pint = (Double)dfMO.get(elem, 4);
                double hora_mec = (Double)dfMO.get(elem, 5);
                double tipoCambio = (Double)dfCostos.get(3, 1);
                mo_mecanica.add(hora_mec*(Double)dfCostos.get(2, 1)*tipoCambio);
                mo_planchado.add(hora_planchado*(Double)dfCostos.get(0, 1)*tipoCambio);
                mo_pintura.add(panio_pint*(Double)dfCostos.get(1, 1)*tipoCambio);
                serv_ter.add(terc_plan*tipoCambio + terc_pint*tipoCambio);
            }
            else{
                mo_mecanica.add(0.0);
                mo_pintura.add(0.0);
                mo_planchado.add(0.0);
                serv_ter.add(0.0);
            }

            //Calculamos el total de los gastos.
            double suma = salidas_alm.get(i) + compras_rpto.get(i) + serv_terceros.get(i) + 
                          mo_mecanica.get(i) + mo_planchado.get(i) + mo_pintura.get(i) +
                          serv_ter.get(i);
            total_gastos.add(suma);
            double dato = (Double)dfOT.col("Sin_IGV").get(i);
            double montoMargen = dato-suma;
            margen.add(montoMargen);
            if(dato==0) porc.add(0.0);
            else    porc.add(montoMargen/dato*100);

            //Hallamos las columnas faltantes
            elem = dfGris.col("No OT").indexOf(OT);
            clientes.add(dfGris.get(elem, 8).toString());
            placas.add(dfGris.get(elem, 5).toString().substring(0, 3) 
                        + "-" 
                        + dfGris.get(elem, 5).toString().substring(3));
            elem = dfAsig.col("ORDEN DE TRABAJO").indexOf(OT);
            if (elem != -1){
                tipo_cli.add(dfAsig.get(elem, 6).toString());
                tipo_sin.add(dfAsig.get(elem, 18).toString());
                marca.add(dfAsig.get(elem, 4).toString());
                modelo.add(dfAsig.get(elem, 5).toString());
            }
            else{
                tipo_cli.add("S/TIPO");
                tipo_sin.add("S/TIPO");
                marca.add("S/MARCA");
                modelo.add("S/MODELO");
            }
        }

        dfOT = dfOT.drop("FiltFecha");
        dfOT.rename("Sin_IGV", "TOTAL INGRESOS");
        dfOT.add(salidas_alm); //CHECK
        dfOT.rename(lastRowOT, "Salidas_Almacen");
        dfOT.add(compras_rpto); //CHECK
        dfOT.rename(lastRowOT, "Compras_Rpto");
        dfOT.add(serv_terceros); //CHECK
        dfOT.rename(lastRowOT, "Serv_Terceros");        
        dfOT.add(mo_mecanica); //CHECK
        dfOT.rename(lastRowOT, "MO_Mecanica");
        dfOT.add(mo_planchado); //CHECK
        dfOT.rename(lastRowOT, "MO_Planchado");        
        dfOT.add(mo_pintura); //CHECK
        dfOT.rename(lastRowOT, "MO_Pintura");
        dfOT.add(serv_ter); //CHECK
        dfOT.rename(lastRowOT, "Ser_Ter_Taller");
        dfOT.add(total_gastos); //CHECK
        dfOT.rename(lastRowOT, "TOTAL GASTOS");
        dfOT.add(margen);            
        dfOT.rename(lastRowOT, "Margen Bruto");
        dfOT.add(porc);
        dfOT.rename(lastRowOT, "PORCENTAJE UTILIDAD");
        dfOT.add(tipo_sin);
        dfOT.rename(lastRowOT, "Tipo de Siniestro");         
        dfOT.add(placas);
        dfOT.rename(lastRowOT, "Placa");
        dfOT.add(marca);
        dfOT.rename(lastRowOT, "Marca");   
        dfOT.add(modelo);
        dfOT.rename(lastRowOT, "Modelo");           
        dfOT.add(clientes);
        dfOT.rename(lastRowOT, "Cliente"); 
        dfOT.add(tipo_cli);
        dfOT.rename(lastRowOT, "Tipo de Cliente");           
        System.out.println(dfOT);  

        //Reporte por tipo_cliente:
        DataFrame repTipoCli = dfOT.retain("Tipo de Cliente", "TOTAL INGRESOS", "TOTAL GASTOS", "Margen Bruto").groupBy("Tipo de Cliente").sum().resetIndex();
        int lastRowTipoCli = repTipoCli.length();
        List<Double> margenTipCli = new ArrayList<>();
        double totalFac = 0, totalCosto = 0, totalMargen = 0, totalPorc;
        for (int i = 0; i<lastRowTipoCli; i++){
            Double totalI = (Double)repTipoCli.get(i, 1);
            if(totalI == 0)   margenTipCli.add(0.0);
            else margenTipCli.add((Double)repTipoCli.get(i, 3)/totalI*100);
            totalFac += totalI;
            totalCosto += (Double)repTipoCli.get(i, 2);
            totalMargen += (Double)repTipoCli.get(i,3);
        }
        if (totalFac == 0)  totalPorc = 0.0;
        else totalPorc = totalMargen/totalFac*100;

        repTipoCli.rename("TOTAL INGRESOS", "Facturación");
        repTipoCli.rename("TOTAL GASTOS", "Costo");        
        repTipoCli.add(margenTipCli);
        repTipoCli.rename(lastRowTipoCli, "%");
        List<Object> totalGeneral = new ArrayList<>();
        totalGeneral.add("Total General");
        totalGeneral.add(totalFac);
        totalGeneral.add(totalCosto);
        totalGeneral.add(totalMargen);
        totalGeneral.add(totalPorc);
        repTipoCli = repTipoCli.append(totalGeneral);
        System.out.println(repTipoCli);  

        //Reporte por tipo_siniestro:
        DataFrame repTipoSin = dfOT.retain("Tipo de Siniestro", "TOTAL INGRESOS", "TOTAL GASTOS", "Margen Bruto").groupBy("Tipo de Siniestro").sum().resetIndex();
        int lastRowTipoSin = repTipoSin.length();
        List<Double> margenTipSin = new ArrayList<>();
        totalFac = totalCosto = totalMargen = 0; 

        for (int i = 0; i<lastRowTipoSin; i++){
            Double totalI = (Double)repTipoSin.get(i, 1);
            if(totalI == 0)   margenTipSin.add(0.0);
            else margenTipSin.add((Double)repTipoSin.get(i, 3)/totalI*100);
            totalFac += totalI;
            totalCosto += (Double)repTipoSin.get(i, 2);
            totalMargen += (Double)repTipoSin.get(i,3);
        }
        if (totalFac == 0)  totalPorc = 0.0;
        else totalPorc = totalMargen/totalFac*100;

        repTipoSin.rename("TOTAL INGRESOS", "Facturación");
        repTipoSin.rename("TOTAL GASTOS", "Costo");        
        repTipoSin.add(margenTipSin);
        repTipoSin.rename(lastRowTipoSin, "%");
        totalGeneral = new ArrayList<>();
        totalGeneral.add("Total General");
        totalGeneral.add(totalFac);
        totalGeneral.add(totalCosto);
        totalGeneral.add(totalMargen);
        totalGeneral.add(totalPorc);
        repTipoSin = repTipoSin.append(totalGeneral);
        System.out.println(repTipoSin);

        //Para la tabla cliente:
        DataFrame dfCliente = dfGris.retain("No OT", "R.U.C.", "Nombre / Razón Social");
        dfCliente = dfCliente.unique("No OT").joinOn(dfAsig.retain("ORDEN DE TRABAJO", "TIPO DE CLIENTE", "TIPO SINIESTRO").unique("ORDEN DE TRABAJO"), DataFrame.JoinType.LEFT, "No OT");
        int lastRowCli = dfCliente.length();
        //Generamos la columna con el tipo de documento
        List<String> tipoDoc = new ArrayList<>();
        List<String> a = new ArrayList<>();
        for (int i = 0; i < lastRowCli; i++){
            int numDig = dfCliente.get(i, 1).toString().length();
            if (numDig == 11)  tipoDoc.add("RUC");
            else if (numDig == 8)  tipoDoc.add("DNI");
            else tipoDoc.add("S/TIPO");
            a.add("-");
        }

        DataFrame tablaCliente = new DataFrame();
        tablaCliente.add(dfCliente.col("Nombre / Razón Social"));
        tablaCliente.rename(0, "NOMBRE CLIENTE");
        tablaCliente.add(dfCliente.col("TIPO DE CLIENTE"));        
        tablaCliente.rename(lastRowCli, "TIPO DE CLIENTE");
        tablaCliente.add(tipoDoc);
        tablaCliente.rename(lastRowCli, "TIPO DE DOCUMENTO");
        tablaCliente.add(dfCliente.col("R.U.C."));
        tablaCliente.rename(lastRowCli, "NUMERO DOCUMENTO");
        tablaCliente.add(a);
        tablaCliente.rename(lastRowCli, "TELEFONO");
        tablaCliente.add(a);
        tablaCliente.rename(lastRowCli, "CORREO");        
        tablaCliente = tablaCliente.unique("NOMBRE CLIENTE");
        //System.out.println(tablaCliente);
        //ClienteDAO daoCliente = DBController.controller.getClienteDAO();
        //daoCliente.guardarBatch(tablaCliente);

        //Para la tabla Vehiculo
        DataFrame dfVehiculo = dfGris.retain("No OT", "Placa", "Nombre / Razón Social");
        dfVehiculo = dfVehiculo.unique("No OT").joinOn(dfAsig.retain("ORDEN DE TRABAJO", "MARCA", "MODELO").unique("ORDEN DE TRABAJO"), DataFrame.JoinType.INNER, "No OT");
        int lastRowVeh = dfVehiculo.length();
        //Generamos la columna con el tipo de documento
        List<String> tipoVeh = new ArrayList<>();
        String tipo;
        for (int i = 0; i < lastRowVeh; i++){
            tipo = dfVehiculo.get(i,4).toString() + " " + dfVehiculo.get(i,5).toString();
            tipoVeh.add(tipo);
        }        
        DataFrame tablaVehiculo = new DataFrame();
        tablaVehiculo.add(dfVehiculo.col("Placa"));
        tablaVehiculo.rename(0, "PLACA");
        tablaVehiculo.add(tipoVeh);
        tablaVehiculo.rename(lastRowVeh, "TIPO VEHICULO");
        tablaVehiculo.add(dfVehiculo.col("Nombre / Razón Social"));
        tablaVehiculo.rename(lastRowVeh, "CLIENTE");
        tablaVehiculo = tablaVehiculo.unique("PLACA");
        //System.out.println(tablaVehiculo);
        //System.out.println(tablaVehiculo);
        //VehiculoDAO daoVehiculo = DBController.controller.getVehiculoDAO();
        //daoVehiculo.guardarBatch(tablaVehiculo);

        //Para la tabla Area de Trabajo
        DataFrame tablaAreaTrabajo = dfGris.retain("División");
        tablaAreaTrabajo = tablaAreaTrabajo.unique("División");
        int cant = tablaAreaTrabajo.length();
        List<Double> b = new ArrayList<>();
        for (int i=0; i<cant;i++){
            b.add(0.0);
        }
        tablaAreaTrabajo.rename("División", "Area de Trabajo"); 
        tablaAreaTrabajo.add(b);
        tablaAreaTrabajo.rename(cant, "Total Ingresos"); 
        tablaAreaTrabajo.add(b);      
        tablaAreaTrabajo.rename(cant, "Total Egresos"); 
        //System.out.println(tablaAreaTrabajo);
        //AreaTrabajoDAO daoAreaTrabajo = DBController.controller.getAreaTrabajoDAO();
        //daoAreaTrabajo.guardarBatch(tablaAreaTrabajo);

//        String ruta2 = "C:\\Users\\Nicolas\\Desktop\\PUCP\\Clases\\20-1\\TA\\ClientesRIGHT.xlsx";
//        File initialFile2 = new File(ruta2);
//        OutputStream targetStreamA = new FileOutputStream(initialFile2);
//        writeXlsx(dfOT, targetStreamA);

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
