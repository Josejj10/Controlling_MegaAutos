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
import java.text.DateFormat;
import java.text.SimpleDateFormat;
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
import static pe.com.megaautos.services.JoineryExtension.writeListXlsx;
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
            List <String> a = new ArrayList<>();
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
            System.out.println(tablaCliente);
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
            System.out.println(tablaVehiculo);
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
            tablaAreaTrabajo.rename(cant, "Total Ingresos"); 
            tablaAreaTrabajo.add(b);      
            tablaAreaTrabajo.rename(cant, "Total Egresos"); 
            //System.out.println(tablaAreaTrabajo);
            AreaTrabajoDAO daoAreaTrabajo = DBController.controller.getAreaTrabajoDAO();
            daoAreaTrabajo.guardarBatch(tablaAreaTrabajo);

            String rutaSalida = "/Salida.xlsx";
            File fileSalida = new File(rutaSalida);
            OutputStream targetStream = new FileOutputStream(fileSalida);
            List<String> nombres = new ArrayList<>();
            List<DataFrame> dfs = new ArrayList<>();
            nombres.add("Rep. por Orden de Trabajo");
            dfs.add(dfOT);
            nombres.add("Rep. por Tipo de Siniestro");
            dfs.add(repTipoSin);
            nombres.add("Rep. por Tipo de Cliente");
            dfs.add(repTipoCli);
            salida.setArchivo(writeListXlsx(dfs, nombres, targetStream));
            
        }
        catch(Exception ex){
            System.out.println(ex);
        }
        return salida;
    }
}
