/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.services;

import java.io.ByteArrayInputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.InputStream;
import java.io.OutputStream;
import java.util.ArrayList;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import joinery.DataFrame;
import pe.com.megaautos.config.DBController;
import pe.com.megaautos.dao.AreaTrabajoDAO;
import pe.com.megaautos.dao.ClienteDAO;
import pe.com.megaautos.dao.ExcelDAO;
import pe.com.megaautos.dao.VehiculoDAO;
import pe.com.megaautos.model.Excel;
import static pe.com.megaautos.services.JoineryExtension.writeXlsx;

/**
 *
 * @author Rodrigo
 */
@WebService(serviceName = "ExcelWS")
public class ExcelWS {
private ExcelDAO daoExcel;
    public ExcelWS(){
        daoExcel = DBController.controller.getExcelDAO();
    }
    @WebMethod(operationName = "insertarArchivoEntrada")
    public int insertarArchivoEntrada(@WebParam(name = "archivo") Excel excel) {
        int resultado = 0;
        try{
            resultado = daoExcel.insertarArchivoEntrada(excel);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        Excel excel2 = procesar(excel);
        insertarArchivoSalida(excel2);
        return resultado;
    }
    @WebMethod(operationName = "insertarArchivoSalida")
    public int insertarArchivoSalida(@WebParam(name = "archivo") Excel excel) {
        int resultado = 0;
        try{
            resultado = daoExcel.insertarArchivoSalida(excel);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "leerArchivoSalida")
    public Excel leerArchivoSalida(){
        Excel excel = new Excel();
        try{
            excel = daoExcel.leerArchivoSalida();
        }catch(Exception ex){
            System.out.println(ex.getCause());
            System.out.println(ex.getMessage());
        }
        return excel;
    }
    
    
    
    @WebMethod(operationName = "leerArchivoEntrada")
    public Excel leerArchivoEntrada(){
        Excel excel = new Excel();
        try{
            excel = daoExcel.leerArchivoEntrada();
        }catch(Exception ex){
            System.out.println(ex.getCause());
            System.out.println(ex.getMessage());
        }
        return excel;
    }
    
    public Excel procesar(Excel excel){
        Excel salida = new Excel();
        try{
            //String ruta = "D:\\Documentos\\PUCP\\2020-1\\LP2\\Proyecto\\Archivos\\Cuadro.xlsx";
            //excel.getArchivo = byte[];
            InputStream targetStream1 = new ByteArrayInputStream(excel.getArchivo());
            InputStream targetStream2 = new ByteArrayInputStream(excel.getArchivo());
            InputStream targetStream3 = new ByteArrayInputStream(excel.getArchivo());
            InputStream targetStream4 = new ByteArrayInputStream(excel.getArchivo());
            InputStream targetStream5 = new ByteArrayInputStream(excel.getArchivo());

            //Obtenemos el dfFact del documento en excel
            DataFrame dfFact = JoineryExtension.readXlsx(targetStream1,5, 2);
            DataFrame dfAsig = JoineryExtension.readXlsx(targetStream2,1, 3);
            DataFrame dfSalxAlm = JoineryExtension.readXlsx(targetStream3, 3, 3);
            DataFrame dfCompras = JoineryExtension.readXlsx(targetStream4, 2, 2);
            DataFrame dfCostos = JoineryExtension.readXlsx(targetStream5, 13, 2);

            //Transformation
            int lastRow = dfFact.length() - 1;
            int lastCol = dfFact.size();
            int lastColGris = 23; //Numero de la columna del data frame (empieza en 1)
            DataFrame dfGris = dfFact.slice(0, lastRow, 0, lastColGris);
            //Calculamos la columna Sin_IGV para todo el dataframe
            List<Double> sin_igv = new ArrayList<>();
            for (int i = 0; i < lastRow; i++){
                String tipoMoneda = dfGris.get(i, 16).toString(); 
                if (tipoMoneda.contentEquals("$")) {
                    Double tCambio = (Double)dfGris.get(i, 17);
                    sin_igv.add(tCambio*(Double)dfGris.get(i, 20));
                }
                else sin_igv.add((Double)dfGris.get(i,20));
            }
            dfGris.add(sin_igv);
            dfGris.rename(lastRow, "Sin_IGV");    
            //System.out.println(dfGris);

            //Para la tabla cliente:
            DataFrame dfCliente = dfGris.retain("No OT", "R.U.C.", "Nombre / Razón Social");
            dfCliente = dfCliente.unique("No OT").joinOn(dfAsig.retain("ORDEN DE TRABAJO", "TIPO DE CLIENTE").unique("ORDEN DE TRABAJO"), DataFrame.JoinType.INNER, "No OT");
            int lastRowCli = dfCliente.length();
            //Generamos la columna con el tipo de documento
            List<String> tipoDoc = new ArrayList<>();
            for (int i = 0; i < lastRowCli; i++){
                int numDig = dfCliente.get(i, 1).toString().length();
                if (numDig == 11)  tipoDoc.add("RUC");
                else if (numDig == 8)  tipoDoc.add("DNI");
                else tipoDoc.add("S/TIPO");
            }
            
            //TODO Se agregan espacios en blanco en correo y telefono (Eliminar campos)
            int cantidad = tipoDoc.size();
            List <String> a = new ArrayList<>();
            for (int i=0; i<cantidad;i++){
                a.add("-");
            }
            DataFrame tablaCliente = new DataFrame();
            tablaCliente.add(dfCliente.col("Nombre / Razón Social"));
            tablaCliente.add(dfCliente.col("TIPO DE CLIENTE"));
            //System.out.println(tablaCliente);
            tablaCliente.rename(0, "NOMBRE CLIENTE");
            tablaCliente.rename(cantidad, "TIPO DE CLIENTE");
            tablaCliente.add(tipoDoc);
            tablaCliente.rename(cantidad, "TIPO DE DOCUMENTO");
            tablaCliente.add(dfCliente.col("R.U.C."));
            tablaCliente.rename(cantidad, "NUMERO DOCUMENTO");
            tablaCliente.add(a);
            tablaCliente.rename(cantidad, "TELEFONO");
            tablaCliente.add(a);
            tablaCliente.rename(cantidad, "CORREO");
            tablaCliente = tablaCliente.unique("NOMBRE CLIENTE");
            //System.out.println(tablaCliente);
            ClienteDAO daoCliente = DBController.controller.getClienteDAO();
            daoCliente.guardarBatch(tablaCliente);

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
            VehiculoDAO daoVehiculo = DBController.controller.getVehiculoDAO();
            daoVehiculo.guardarBatch(tablaVehiculo);

            //Para la tabla Area de Trabajo
            DataFrame tablaAreaTrabajo = dfGris.retain("División");
            tablaAreaTrabajo = tablaAreaTrabajo.unique("División");
            int cant = tablaAreaTrabajo.length();
            List <Double>b = new ArrayList<>();
            for (int i=0; i<cant;i++){
                b.add(0.0);
            }
            tablaAreaTrabajo.rename("División", "Area de Trabajo"); 
            tablaAreaTrabajo.add(b);
            tablaAreaTrabajo.rename(cant, "MONTO"); 
            tablaAreaTrabajo.add(b);        
            //System.out.println(tablaAreaTrabajo);
            AreaTrabajoDAO daoAreaTrabajo = DBController.controller.getAreaTrabajoDAO();
            daoAreaTrabajo.guardarBatch(tablaAreaTrabajo);

            //Para la tabla Orden de Trabajo
            dfGris = dfGris.sortBy("No OT");
            int lastFact1 = dfGris.col("Doc.").indexOf("ABO");
            int lastFact2 = dfGris.col("Doc.").indexOf("CAR");
            if (lastFact1 != -1){
                dfGris = dfGris.slice(0, lastFact1 - 1);
            }
            else if (lastFact2 != -1){
                dfGris = dfGris.slice(0, lastFact2 - 1);            
            }

            DataFrame dfOT = dfGris.retain("No OT", "Sin_IGV").groupBy("No OT").sum(); //REVISAR
            int lastRowOT = dfOT.length();    
            //Filtramos para obtener solo los documentos Factura y Boleta

            //Calculamos Salidas_Almacen
            dfSalxAlm = dfSalxAlm.retain("Total S/.", "OT").groupBy("OT").sum();
            List<Double> salidas_alm = new ArrayList<>();
            double celda;
            int elem;
            for (int i = 0; i < lastRowOT; i++){
                String OT = dfOT.get(i, 0).toString();
                elem = dfSalxAlm.col(0).indexOf(OT);
                if (elem != -1) {
                    celda = (Double)dfSalxAlm.get(elem ,1);
                    salidas_alm.add(celda);                    
                }
                else    salidas_alm.add(0.0);
            }
    //        dfOT.add(salidas_alm); //CHECK
    //        dfOT.rename(lastRowOT, "Salidas_Almacen");

            //Calculamos Compras_Rpto y Serv_Terceros
            dfCompras = dfCompras.retain("OT", "CLAS_SERV", "MONTO").groupBy("OT", "CLAS_SERV").sum();
            List<Double> compras_rpto = new ArrayList<>();
            for (int i = 0; i < lastRowOT; i++){
                String OT = dfOT.get(i, 0).toString();
                elem = dfCompras.col(0).indexOf(OT);
                if (elem != -1){
                    String tipoServ = dfCompras.get(elem, 1).toString();
                    if (tipoServ.contentEquals("RP")){
                        celda = (Double)dfCompras.get(elem ,2);
                        compras_rpto.add(celda);
                    }
                    else    compras_rpto.add(0.0);
                }
                else    compras_rpto.add(0.0);
            }        
    //        dfOT.add(compras_rpto); //CHECK
    //        dfOT.rename(lastRowOT, "Compras_Rpto");

            List<Double> serv_terceros = new ArrayList<>();
            for (int i = 0; i < lastRowOT; i++){
                String OT = dfOT.get(i, 0).toString();
                elem = dfCompras.col(0).indexOf(OT);
                if (elem != -1){
                    String tipoServ = dfCompras.get(elem, 1).toString();
                    if (tipoServ.contentEquals("ST")){
                        celda = (Double)dfCompras.get(elem ,2);
                        serv_terceros.add(celda);
                    }
                    else    serv_terceros.add(0.0);
                }
                else    serv_terceros.add(0.0);
            } 
    //        dfOT.add(serv_terceros); //CHECK
    //        dfOT.rename(lastRowOT, "Serv_Terceros");

            DataFrame dfMO = dfAsig.retain("ORDEN DE TRABAJO", "HORA AJUSTADA", "TERCEROS / PLANCHADOR" ,"PAÑOS AJUSTADOS", "TERCEROS/PINTOR ($)","HORAS MECÁNICA")
                                   .groupBy("ORDEN DE TRABAJO")
                                   .sum();
            //System.out.println(dfMO);
            //System.out.println(dfCostos);
            List<Double> mo_mecanica = new ArrayList<>();
            List<Double> mo_planchado = new ArrayList<>();
            List<Double> mo_pintura = new ArrayList<>();
            List<Double> serv_ter = new ArrayList<>();
            for (int i = 0; i < lastRowOT; i++){
                String OT = dfOT.get(i, 0).toString();
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
            }
    //        dfOT.add(mo_mecanica); //CHECK
    //        dfOT.rename(lastRowOT, "MO_Mecanica");
    //        dfOT.add(mo_planchado); //CHECK
    //        dfOT.rename(lastRowOT, "MO_Planchado");        
    //        dfOT.add(mo_pintura); //CHECK
    //        dfOT.rename(lastRowOT, "MO_Pintura");
    //        dfOT.add(serv_ter); //CHECK
    //        dfOT.rename(lastRowOT, "Ser_Ter_Taller");

            List<Double> total_gastos = new ArrayList<>();
            List<Double> margen = new ArrayList<>();
            List<Double> porc = new ArrayList<>();
            //Unimos todas las columnas para obtener el total gastos
            for (int i = 0; i < lastRowOT; i++){
                    double suma = salidas_alm.get(i) + compras_rpto.get(i) + serv_terceros.get(i) + 
                                  mo_mecanica.get(i) + mo_planchado.get(i) + mo_pintura.get(i) +
                                  serv_ter.get(i);
                    total_gastos.add(suma);
                    double dato = (Double)dfOT.col("Sin_IGV").get(i);
                    double montoMargen = dato-suma;
                    margen.add(montoMargen);
                    if(dato==0)
                        porc.add(0.0);
                    else
                        porc.add(montoMargen/dato*100);
            }
            dfOT.add(total_gastos); //CHECK
            dfOT.rename(lastRowOT, "TOTAL GASTOS");  
            dfOT = dfOT.joinOn(dfGris.retain("No OT", "Placa", "Nombre / Razón Social", "Mon.", "T/C.").unique("No OT"), DataFrame.JoinType.INNER, "No OT");
            dfOT = dfOT.resetIndex().drop("No OT_right");
            dfOT.rename("No OT_left", "ORDEN DE TRABAJO");
            dfOT.rename("Sin_IGV", "TOTAL INGRESOS");
            dfOT.rename("Placa", "PLACA");
            dfOT.rename("Nombre / Razón Social", "CLIENTE");
            dfOT.rename("Mon.", "MONEDA");
            dfOT.add(margen);            
            dfOT.rename(lastRowOT, "MARGEN BRUTO");
            dfOT.add(porc);
            dfOT.rename(lastRowOT, "PORCENTAJE UTILIDAD");
            //System.out.println(dfOT);
            
            String rutaSalida = "/Salida.xlsx";
            File fileSalida = new File(rutaSalida);
            OutputStream targetStream = new FileOutputStream(fileSalida);
            salida.setArchivo(writeXlsx(dfOT, targetStream));
            
            
        }
        catch(Exception ex){
            System.out.println(ex);
        }
        return salida;
    }
}
