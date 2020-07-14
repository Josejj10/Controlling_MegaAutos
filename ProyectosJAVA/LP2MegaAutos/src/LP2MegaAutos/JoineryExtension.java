/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LP2MegaAutos;
import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.Iterator;
import java.util.List;
import java.util.Properties;
import javax.mail.Message;
import javax.mail.MessagingException;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.AddressException;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeMessage;
import javax.swing.JOptionPane;
import java.util.logging.Level;
import java.util.logging.Logger;
import joinery.DataFrame;
import joinery.impl.Serialization;
import org.apache.poi.ss.usermodel.*;
import org.apache.poi.xssf.usermodel.DefaultIndexedColorMap;
import org.apache.poi.xssf.usermodel.XSSFCellStyle;
import org.apache.poi.xssf.usermodel.XSSFColor;
import org.apache.poi.xssf.usermodel.XSSFDataFormat;
import org.apache.poi.xssf.usermodel.XSSFFont;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;
import pe.com.megaautos.config.DBController;
import pe.com.megaautos.config.DBDataSource;
import pe.com.megaautos.dao.AreaTrabajoDAO;
import pe.com.megaautos.dao.ClienteDAO;
import pe.com.megaautos.dao.ExcelDAO;
import pe.com.megaautos.dao.ReporteDAO;
import pe.com.megaautos.dao.UsuarioDAO;
import pe.com.megaautos.dao.VehiculoDAO;
import pe.com.megaautos.model.Excel;
import pe.com.megaautos.model.OrdenTrabajo;
import pe.com.megaautos.model.Reporte;
import pe.com.megaautos.model.Usuario;

public class JoineryExtension extends Serialization{
    
    private static final Object readCell(final Cell cell) {
        switch (cell.getCellType()) {
            case FORMULA:
                try{
                    return cell.getNumericCellValue();
                }
                catch(Exception e){
                    return cell.getStringCellValue();
                }
            case NUMERIC:
                if (DateUtil.isCellDateFormatted(cell)) {
                    return DateUtil.getJavaDate(cell.getNumericCellValue());
                }
                return cell.getNumericCellValue();
            case BOOLEAN:
                return cell.getBooleanCellValue();
            default:
                return cell.getStringCellValue();
        }
    }
    private static final void writeCell(final Cell cell, final Object value) {
        if (value instanceof Number) {
            cell.setCellType(CellType.NUMERIC);
            cell.setCellValue(Number.class.cast(value).doubleValue());
        } else if (value instanceof Date) {
            final CellStyle style = cell.getSheet().getWorkbook().createCellStyle();
//            style.setDataFormat(XSSFDataFormat.getFormat("m/d/yy h:mm"));
            cell.setCellStyle(style);
            cell.setCellType(CellType.NUMERIC);
            cell.setCellValue(Date.class.cast(value));
        } else if (value instanceof Boolean) {
            cell.setCellType(CellType.BOOLEAN);
        } else {
            cell.setCellType(CellType.STRING);
            cell.setCellValue(value != null ? String.valueOf(value) : "");
        }
    }
    //TODO: AGREGAR EL PARAMETRO DE LA CABECERA A LA FUNCION 
    public static DataFrame<Object> readXlsx(final InputStream input, int nHoja, int rowIni)
    throws IOException {
        final Workbook wb = new XSSFWorkbook(input);
        final Sheet sheet = wb.getSheetAt(nHoja);
        final List<Object> columns = new ArrayList<>();
        final List<List<Object>> data = new ArrayList<>();

        for (final Row row : sheet) {
            if (row.getRowNum() == rowIni) {
                // read header
                for (final Cell cell : row) {
                    columns.add(readCell(cell));
                }
            } else if (row.getRowNum() > rowIni) {
                // read data values
                final List<Object> values = new ArrayList<>();
                for (final Cell cell : row) {
                    values.add(readCell(cell));
                }
                data.add(values);
            }
        }
        // create data frame
        final DataFrame<Object> df = new DataFrame<>(columns);
        for (final List<Object> row : data) {
            df.append(row);
        }
        return df;
    }
    
    public static void guardarBatch(DataFrame df){
        try{
            Connection con = DBDataSource.getConnection();
            PreparedStatement st = con.prepareStatement("{CALL INSERTAR_CLIENTE_DF(?,?,?,?,?,?)}");
            for (int r = 0; r < df.length(); r++) {
                for (int c = 1; c <= df.size(); c++) {
                    st.setObject(c, df.get(r, c - 1));
                }
                st.addBatch();
            }
            st.executeBatch();
            con.close();
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
    
    public static void writeXlsx(final DataFrame df, final OutputStream output)
    throws IOException {
        final Workbook wb = new XSSFWorkbook();
        final Sheet sheet = wb.createSheet();

        // add header
        Row row = sheet.createRow(0);
        final Iterator<Object> it = df.columns().iterator();
        for (int c = 0; c < df.size(); c++) {
            final Cell cell = row.createCell(c);
            writeCell(cell, it.hasNext() ? it.next() : c);
        }

        // add data values
        for (int r = 0; r < df.length(); r++) {
            row = sheet.createRow(r + 1);
            for (int c = 0; c < df.size(); c++) {
                final Cell cell = row.createCell(c);
                writeCell(cell, df.get(r, c));
            }
        }

        //  write to stream
        wb.write(output);
        output.close();
    }
    private static String VALID_CHARACTERS = "@abcdefghijklmnopqrstuvwxyz"
            + "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    public static String randomAlphaNumeric(int count) {    
        StringBuilder builder = new StringBuilder();
        while (count-- != 0) {
            int character = (int)(Math.random()*VALID_CHARACTERS.length());
            builder.append(VALID_CHARACTERS.charAt(character));
        }        
        return builder.toString();
    }

    public static int enviarCorreo(String correoDestinatario){
        Usuario usuario = new Usuario();
        UsuarioDAO daoUsuario = DBController.controller.getUsuarioDAO();
        usuario = daoUsuario.buscarPorCorreo(correoDestinatario);
        if(usuario==null){
            return 0;
        }
        Properties propiedad = new Properties();
        propiedad.setProperty("mail.smtp.host", "smtp.gmail.com");
        propiedad.setProperty("mail.smtp.starttls.enable", "true");
        propiedad.setProperty("mail.smtp.port", "587");
        propiedad.setProperty("mail.smtp.auth", "true"); 
        
        Session sesion = Session.getDefaultInstance(propiedad);
        sesion.setDebug(false);
        
        String correoEmpresa = "pruebasistemalp2@gmail.com";//TODO CREAR CORREO SOPORTE soporte.megaautos@gmail.com
        String contrasena = "C9AA28BA93";
        String asunto = "Recuperación de Contraseña - Sistema MegaAutos";
       
        String token = "";
        token = randomAlphaNumeric(16);
        
        daoUsuario.actualizarToken(usuario, token);
        
        String mensaje = "Estimado usuario,\nEl token para recuperar su "
                + "contraseña es:\n"+token+"\nPor favor, utilícelo para actualizar su contraseña. "
                + "Se le recuerda que el token tiene una validez máxima de 10 minutos.\n"
                + "\nSaludos cordiales,\n"
                + "Soporte MegaAutos";
        
        daoUsuario.actualizarToken(usuario, token);
        
        MimeMessage mail = new MimeMessage(sesion);
        
        try { 
            mail.setFrom(new InternetAddress(correoEmpresa));
            mail.addRecipient(Message.RecipientType.TO, new InternetAddress(correoDestinatario));
            mail.setSubject(asunto);
            mail.setText(mensaje);
            
            Transport transportar = sesion.getTransport("smtp");
            transportar.connect(correoEmpresa,contrasena);
            transportar.sendMessage(mail, mail.getRecipients(Message.RecipientType.TO));          
            transportar.close();
            
            //JOptionPane.showMessageDialog(null, "Listo, correo enviado");
        } catch (AddressException ex) {
            //Logger.getLogger(PasswordWS.class.getName()).log(Level.SEVERE, null, ex);
            System.out.println(ex);
        } catch (MessagingException ex) {
//            Logger.getLogger(PasswordWS.class.getName()).log(Level.SEVERE, null, ex);
            System.out.println(ex);
        }
        return 1;
    }
    
    public static int generarReporte(String fechaInicio,
                              String fechaFin,
                              String tipo,
                              int idSede,
                              int idUsuario) {
        int resultado = 0;
        ExcelDAO daoExcel = DBController.controller.getExcelDAO();
        try{  
            Date fecha1=new SimpleDateFormat("dd-MM-yyyy").parse(fechaInicio);
            Date fecha2=new SimpleDateFormat("dd-MM-yyyy").parse(fechaFin);
            Excel excel = daoExcel.buscar(fecha1, fecha2, idSede);
            Reporte reporte = procesar(excel, fechaInicio, fechaFin,
                    tipo, idSede, fecha1, fecha2,
                    excel.getId(), idUsuario);
            ReporteDAO daoReporte = DBController.controller.getReporteDAO();
            resultado = daoReporte.insertar(reporte);
            //Reporte reporte = procesar(excel, tipo,fechaInicio, fechaFin,idSede);
            //fecha1(dd-MM-aaaa)|fecha2|"s|at|tc"|idSede|idUsuario
            //Buscas el excel que corresponde
            //De la lista de excel que tienes
            //Con ese excel llamaas a procesar(s, at, tc)
            //en procesar guardas el excel de salida (que contiene las ots y el tipo de reporte)
            //y lo subes a la bd
            //procesar debe devolver la clase reporte
            //Subir reporte a BD
            //Retornar reporte
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        //TODO actualizarFechas-> genera df y actualiza fecha inicio y fin
        //Generar reporte
        //Buscar el más reciente dentrod el rango de fechas
        //
//        Excel excel2 = procesar(excel);
//        
        return resultado;
    }
    
    public static Reporte procesar(Excel excel, String fechaIni, String fechaFin,
                    String tipoReporte, int idSede, Date fecha1, Date fecha2,
                    int idEntrada, int idUsuario){//tipo
        Excel salida = new Excel();
        Reporte reporte = new Reporte();
        try{
            //tipo=at
            //Reporte reporte = 
            
            
            //String ruta = "D:\\Documentos\\PUCP\\2020-1\\LP2\\Proyecto\\Archivos\\Cuadro.xlsx";
            //excel.getArchivo = byte[];
            InputStream targetStream1 = new ByteArrayInputStream(excel.getArchivo());
            InputStream targetStream2 = new ByteArrayInputStream(excel.getArchivo());
            InputStream targetStream3 = new ByteArrayInputStream(excel.getArchivo());
            InputStream targetStream4 = new ByteArrayInputStream(excel.getArchivo());
            InputStream targetStream5 = new ByteArrayInputStream(excel.getArchivo());            
            InputStream targetStream6 = new ByteArrayInputStream(excel.getArchivo());

            //Obtenemos el dfFact del documento en excel
            DataFrame dfFact = JoineryExtension.readXlsx(targetStream1,5, 2);      
            DataFrame dfAsig = JoineryExtension.readXlsx(targetStream2,1, 3);
            DataFrame dfSalxAlm = JoineryExtension.readXlsx(targetStream3, 3, 3);
            DataFrame dfCompras = JoineryExtension.readXlsx(targetStream4, 2, 2);
            DataFrame dfCostos = JoineryExtension.readXlsx(targetStream5, 13, 2);
            DataFrame dfGastAdmin = JoineryExtension.readXlsx(targetStream6, 14, 1);

            //Transformation
            int lastRow = dfFact.length() - 1;
            int lastColGris = 23; //Numero de la columna del data frame (empieza en 1)
            DataFrame dfGris = dfFact.slice(0, lastRow, 0, lastColGris);
            
            //Calculamos la columna Sin_IGV para todo el dataframe
            List<Double> sin_igv = new ArrayList<>();
            List<String> mes = new ArrayList<>();
            List<String> dia = new ArrayList<>();
            List<String> anio = new ArrayList<>();//2020-20-01 20202002
            DateFormat dateFormat = new SimpleDateFormat("yyyyMMdd");
            List<Integer> prior = new ArrayList<>();
            List<String> priorDiv = new ArrayList<>();
            
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

                String division = dfGris.get(i, 15).toString();
                if (division.contentEquals("PLANCHADO"))    priorDiv.add("Planchado");
                else if (division.contentEquals("PINTURA")) priorDiv.add("Pintura");
                else priorDiv.add("Mecanica");

            }
            dfGris.add("Sin_IGV", sin_igv);
            dfGris.add("PRIOR", prior);
            dfGris.add("ANIO", anio);
            dfGris.add("MES", mes);
            dfGris.add("DIA", dia);
            dfGris.add("PRIOR_DIV", priorDiv);
            System.out.println(dfGris);

            //Para el reporte Orden de Trabajo
            dfGris = dfGris.sortBy(4).resetIndex();
            dfGris = dfGris.sortBy(24).resetIndex();
            int first3 = dfGris.col(24).indexOf(3);
            dfGris = dfGris.slice(0, first3);
            dfGris = dfGris.sortBy(4).resetIndex();

            DataFrame dfOT = dfGris.retain("ANIO", "MES", "No OT", "Sin_IGV").groupBy("No OT", "ANIO", "MES").sum();
            List<String> colDias = dfGris.retain("ANIO", "MES", "No OT", "DIA").unique("No OT", "ANIO", "MES").col("DIA");
            dfOT.add("DIA", colDias);
            dfOT.add("RUC", dfGris.retain("ANIO", "MES", "No OT", "R.U.C.").unique("No OT", "ANIO", "MES").col("R.U.C."));
            int lastRowOT = dfOT.length();
            dfOT = dfOT.resetIndex();
            //System.out.println(dfOT);   

            //ESTE ES EL FILTRO PARA LA FECHA
            //YA SEA SOLO MES Y ANIO O SOLO ANIO O ANIO MES Y DIA O RANGO DE FECHAS
            String anio1, mes1, dia1, anio2, mes2, dia2, dfAnio, dfMes, dfDia;
            anio1 = fechaIni.substring(6, 10);    
            mes1 = fechaIni.substring(3, 5);    
            dia1 = fechaIni.substring(0, 2);    
            anio2 = fechaFin.substring(6, 10);    
            mes2 = fechaFin.substring(3, 5);    
            dia2 = fechaFin.substring(0, 2);         
            List<Integer> filtFecha = new ArrayList<>();
            //Filtramos el DF en base a la fecha solicitada:
            for(int i = 0; i<lastRowOT; i++){
                dfAnio = dfOT.get(i, 1).toString();
                dfMes = dfOT.get(i,2).toString();
                dfDia = dfOT.get(i, 4).toString();
                if(anio1.compareTo(dfAnio) <= 0 && anio2.compareTo(dfAnio) >= 0  &&
                   mes1.compareTo(dfMes) <= 0 && mes2.compareTo(dfMes) >=  0 &&
                   dia1.compareTo(dfDia) <= 0 && dia2.compareTo(dfDia) >=  0)
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
            dfOT.add("Salidas_Almacen", salidas_alm); //CHECK
            dfOT.add("Compras_Rpto", compras_rpto); //CHECK
            dfOT.add("Serv_Terceros", serv_terceros); //CHECK
            dfOT.add("MO_Mecanica", mo_mecanica); //CHECK
            dfOT.add("MO_Planchado", mo_planchado); //CHECK
            dfOT.add("MO_Pintura", mo_pintura); //CHECK
            dfOT.add("Ser_Ter_Taller", serv_ter); //CHECK
            dfOT.add("TOTAL GASTOS", total_gastos); //CHECK
            dfOT.add("Margen Bruto", margen);            
            dfOT.add("PORCENTAJE UTILIDAD", porc);
            dfOT.add("Tipo de Siniestro", tipo_sin);
            dfOT.add("Placa", placas);
            dfOT.add("Marca", marca);
            dfOT.add("Modelo", modelo);
            dfOT.add("Cliente", clientes);
            dfOT.add("Tipo de Cliente", tipo_cli);
            System.out.println(dfOT);  

            String rutaSalida = "D:\\Documentos\\PUCP\\2020-1\\LP2\\Proyecto\\Archivos\\SalidaPrueba.xlsx";
            File fileSalida = new File(rutaSalida);
            OutputStream targetStream = new FileOutputStream(fileSalida);
            List<String> nombres = new ArrayList<>();
            List<DataFrame> dfs = new ArrayList<>();
            nombres.add("Rep. por Orden de Trabajo");
            dfs.add(dfOT);

            DataFrame<Object> repTipoCli = new DataFrame<>();
            
            DataFrame<Object> repTipoSin = new DataFrame<>();
            
            DataFrame<Object> repAreaTrabajo = new DataFrame<>();
            double difDias = fecha2.getTime() - fecha1.getTime();
            difDias = difDias/8.64e7 + 1;        
            String titulo = "";
            Double ingresos = 0.0;
            Double egresos = 0.0;
            
            switch(tipoReporte){
                case "tipoCliente":
                    //Reporte por tipo_cliente:"
                    repTipoCli = dfOT.retain("Tipo de Cliente", "TOTAL INGRESOS", "TOTAL GASTOS", "Margen Bruto").groupBy("Tipo de Cliente").sum().resetIndex();
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
                    titulo = "Rep. por Tipo de Cliente";
                    ingresos = totalFac;
                    egresos = totalCosto;
                    nombres.add(titulo);
                    dfs.add(repTipoCli);
                    break;
                case "tipoSiniestro":
                    //Reporte por tipo_siniestro:
                    repTipoSin = dfOT.retain("Tipo de Siniestro", "TOTAL INGRESOS", "TOTAL GASTOS", "Margen Bruto").groupBy("Tipo de Siniestro").sum().resetIndex();
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
                    titulo = "Rep. por Tipo de Siniestro";
                    ingresos = totalFac;
                    egresos = totalCosto;
                    nombres.add(titulo);
                    dfs.add(repTipoSin);
                    break;
                case "areaTrabajo":
                    Double totalPlanchado, totalPintura, totalMecanica;
                    totalPlanchado = totalPintura = totalMecanica = 0.0;
                    for (int i = 0;i<lastRowOT; i++){
                        totalPlanchado += (Double)dfOT.get(i, 10);
                        totalPintura += (Double)dfOT.get(i, 11);
                        totalMecanica += (Double)dfOT.get(i, 9) 
                                       + (Double)dfOT.get(i, 8)
                                       + (Double)dfOT.get(i, 7)
                                       + (Double)dfOT.get(i, 6);
                    }
                    repAreaTrabajo = dfGris.retain("PRIOR_DIV", "Sin_IGV").groupBy("PRIOR_DIV").sum();
                    List<Object> rowAdmin = new ArrayList<>();
                    rowAdmin.add("Administracion");
                    rowAdmin.add(0.0);
                    Double totalAdmin = (Double)dfGastAdmin.get(18, 2)*difDias/30;
                    rowAdmin.add(totalAdmin);
                    totalGeneral = new ArrayList<>();
                    totalGeneral.add(totalPintura);
                    totalGeneral.add(totalPlanchado);
                    totalGeneral.add(totalMecanica);
                    repAreaTrabajo.rename("PRIOR_DIV", "Area de Trabajo");
                    repAreaTrabajo.rename("Sin_IGV", "Total Ingresos");
                    repAreaTrabajo.add("Total Egresos", totalGeneral);
                    repAreaTrabajo = repAreaTrabajo.append(rowAdmin);
                    repAreaTrabajo = repAreaTrabajo.resetIndex();
                    System.out.println(repAreaTrabajo);
                    break;
            }
            
            //Para la tabla cliente:
            DataFrame dfCliente = dfOT.retain("No OT", "RUC", "Cliente", "Tipo de Cliente");
            //Generamos la columna con el tipo de documento
            List<String> tipoDoc = new ArrayList<>();
            List<String> a = new ArrayList<>();
            for (int i = 0; i < lastRowOT; i++){
                int numDig = dfCliente.get(i, 1).toString().length();
                if (numDig == 11)  tipoDoc.add("RUC");
                else if (numDig == 8)  tipoDoc.add("DNI");
                else if (numDig == 9) tipoDoc.add("CARNET EXTRANJERIA");
                a.add("-");
            }
            DataFrame tablaCliente = new DataFrame();
            tablaCliente.add("NOMBRE CLIENTE", dfCliente.col("Cliente"));
            tablaCliente.add("TIPO DE CLIENTE", dfCliente.col("Tipo de Cliente"));        
            tablaCliente.add("TIPO DE DOCUMENTO", tipoDoc);
            tablaCliente.add("NUMERO DOCUMENTO", dfCliente.col("RUC"));
            tablaCliente.add("TELEFONO", a);
            tablaCliente.add("CORREO", a);
            tablaCliente = tablaCliente.unique("NOMBRE CLIENTE");
            //System.out.println(tablaCliente);
            //ClienteDAO daoCliente = DBController.controller.getClienteDAO();
            //daoCliente.guardarBatch(tablaCliente);
    //
            //Para la tabla Vehiculo
            DataFrame dfVehiculo = dfOT.retain("No OT", "Placa", "Marca", "Modelo", "Cliente");
            //Generamos la columna con el tipo de documento
            List<String> tipoVeh = new ArrayList<>();
            String tipo;
            for (int i = 0; i < lastRowOT; i++){
                tipo = dfVehiculo.get(i,2).toString() + " " + dfVehiculo.get(i,3).toString();
                tipoVeh.add(tipo);
            }        
            DataFrame tablaVehiculo = new DataFrame();
            tablaVehiculo.add("PLACA", dfVehiculo.col("Placa"));
            tablaVehiculo.add("TIPO VEHICULO", tipoVeh);
            tablaVehiculo.add("CLIENTE", dfVehiculo.col("Cliente"));
            tablaVehiculo = tablaVehiculo.unique("PLACA");
            //System.out.println(tablaVehiculo);
            //VehiculoDAO daoVehiculo = DBController.controller.getVehiculoDAO();
            //daoVehiculo.guardarBatch(tablaVehiculo);

            if(!tipoReporte.equals("areaTrabajo")){
                Double totalPlanchado, totalPintura, totalMecanica;
                    totalPlanchado = totalPintura = totalMecanica = 0.0;
                    for (int i = 0;i<lastRowOT; i++){
                        totalPlanchado += (Double)dfOT.get(i, 10);
                        totalPintura += (Double)dfOT.get(i, 11);
                        totalMecanica += (Double)dfOT.get(i, 9) 
                                       + (Double)dfOT.get(i, 8)
                                       + (Double)dfOT.get(i, 7)
                                       + (Double)dfOT.get(i, 6);
                    }
                    repAreaTrabajo = dfGris.retain("PRIOR_DIV", "Sin_IGV").groupBy("PRIOR_DIV").sum();
                    List<Object> rowAdmin = new ArrayList<>();
                    rowAdmin.add("Administracion");
                    rowAdmin.add(0.0);
                    Double totalAdmin = (Double)dfGastAdmin.get(18, 2)*difDias/30;
                    rowAdmin.add(totalAdmin);
                    List<Object> totalGeneral = new ArrayList<>();
                    totalGeneral.add(totalPintura);
                    totalGeneral.add(totalPlanchado);
                    totalGeneral.add(totalMecanica);
                    repAreaTrabajo.rename("PRIOR_DIV", "Area de Trabajo");
                    repAreaTrabajo.rename("Sin_IGV", "Total Ingresos");
                    repAreaTrabajo.add("Total Egresos", totalGeneral);
                    repAreaTrabajo = repAreaTrabajo.append(rowAdmin);
                    repAreaTrabajo = repAreaTrabajo.resetIndex();
                    System.out.println(repAreaTrabajo);
            }
            //AreaTrabajoDAO daoAreaTrabajo = DBController.controller.getAreaTrabajoDAO();
            //daoAreaTrabajo.guardarBatch(repAreaTrabajo);
            
            //IMPRIMIR TABLAS Y REPORTES
            
            salida.setArchivo(writeListXlsx(dfs, nombres, targetStream));
            salida.setFechaIni(fecha1);
            salida.setFechaFin(fecha2);
            salida.getSede().setId(idSede);
            int idExcelSalida = insertarArchivoSalida(salida);
            reporte.setFechaInicio(fecha1);
            reporte.setFechaFin(fecha2);
            reporte.setFechaCreacion(new Date());
            reporte.getSede().setId(idSede);
            reporte.setIdExcelSalida(idExcelSalida);
            reporte.setIdExcelEntrada(idEntrada);
            reporte.setIdUsuario(idUsuario);
            reporte.setTipoReporte(tipoReporte);
            reporte.setTitulo(titulo);
            reporte.setIngresos(ingresos);
            reporte.setEgresos(egresos);
        }
        catch(Exception ex){
            System.out.println(ex);
        }
        return reporte;
    }
    
    public static int insertarArchivoSalida(Excel excel) {
        int resultado = 0;
        ExcelDAO daoExcel = DBController.controller.getExcelDAO();
        try{
            resultado = daoExcel.insertarArchivoSalida(excel);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    public static byte[] writeListXlsx(final List<DataFrame> dfs, List<String> nombres, final OutputStream output)
    throws IOException {
        final XSSFWorkbook  wb = new XSSFWorkbook();
        
        XSSFFont encabezadoFont = wb.createFont();
        encabezadoFont.setBold(true);
        
        XSSFCellStyle encabezadoStyle = wb.createCellStyle();
        encabezadoStyle.setFillForegroundColor(new XSSFColor(new java.awt.Color(191, 191, 191), new DefaultIndexedColorMap()));
        encabezadoStyle.setFillPattern(FillPatternType.SOLID_FOREGROUND);
        encabezadoStyle.setBorderBottom(BorderStyle.THIN);
        encabezadoStyle.setBorderTop(BorderStyle.THIN);
        encabezadoStyle.setBorderLeft(BorderStyle.THIN);
        encabezadoStyle.setBorderRight(BorderStyle.THIN);
        encabezadoStyle.setFont(encabezadoFont);
        encabezadoStyle.setDataFormat(wb.createDataFormat().getFormat("#,##0.00"));
        
        XSSFCellStyle contenidoStyle = wb.createCellStyle();
        contenidoStyle.setDataFormat(wb.createDataFormat().getFormat("#,##0.00"));
        
        XSSFCellStyle pieStyle = wb.createCellStyle();
        pieStyle.setFillForegroundColor(new XSSFColor(new java.awt.Color(194, 224, 180), new DefaultIndexedColorMap()));
        pieStyle.setBorderBottom(BorderStyle.THIN);
        pieStyle.setBorderTop(BorderStyle.THIN);
        pieStyle.setBorderLeft(BorderStyle.THIN);
        pieStyle.setBorderRight(BorderStyle.THIN);
        pieStyle.setFont(encabezadoFont);        
        pieStyle.setDataFormat(wb.createDataFormat().getFormat("#,##0.00"));
        
//        final Sheet sheet = wb.createSheet();
        int i=0;
        for(DataFrame df : dfs){  
            Sheet sheet = wb.createSheet(nombres.get(i));
            sheet.setDefaultColumnWidth(15);
            i+=1;//En el primero, i=1
            // add header
            Row row = sheet.createRow(0);
            final Iterator<Object> it = df.columns().iterator();
            for (int c = 0; c < df.size(); c++) {
                final Cell cell = row.createCell(c);
                cell.setCellStyle(encabezadoStyle);
                writeCell(cell, it.hasNext() ? it.next() : c);
            }
            int lastRow=df.length();
            // add data values
            //Lastrow=10
            //r=9
            for (int r = 0; r < lastRow; r++) {
                row = sheet.createRow(r + 1);//fila 10
                for (int c = 0; c < df.size(); c++) {
                    final Cell cell = row.createCell(c);
                    //Ojo al tejo
                    if(i==1 || r != lastRow)
                        cell.setCellStyle(contenidoStyle);
                    else if(i>1 && r==(lastRow-1))
                        cell.setCellStyle(pieStyle);
                    writeCell(cell, df.get(r, c));
                }
            }
        }

        //  write to stream
        wb.write(output);
        output.close();
        ByteArrayOutputStream output2 = new ByteArrayOutputStream();
        wb.write(output2);
        output2.close();
        return output2.toByteArray();
    }
    
    public static int insertarArchivoEntrada(Excel excel, int idSede) {
        int resultado = 0;
        ExcelDAO daoExcel = DBController.controller.getExcelDAO();
        try{
            InputStream targetStream1 = new ByteArrayInputStream(excel.getArchivo());
            DataFrame dfFact = readXlsx(targetStream1,5, 2);
            
            int lastRow = dfFact.length()-1;
            Date fechaIni = (Date)dfFact.slice(0, lastRow).sortBy(0).resetIndex().col(0).get(0);
            Date fechaFin = (Date)dfFact.slice(0, lastRow).sortBy(0).resetIndex().col(0).get(lastRow-1);
            
            excel.setFechaIni(fechaIni);
            excel.setFechaFin(fechaFin);
            excel.getSede().setId(idSede);
            resultado = daoExcel.insertarArchivoEntrada(excel);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        //TODO actualizarFechas-> genera df y actualiza fecha inicio y fin
        //Generar reporte
        //Buscar el más reciente dentrod el rango de fechas
        //
        return resultado;
    }
}
