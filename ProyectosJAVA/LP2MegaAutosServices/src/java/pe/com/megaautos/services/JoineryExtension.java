/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.services;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.util.ArrayList;
import java.util.Date;
import java.util.Iterator;
import java.util.List;
import joinery.DataFrame;
import joinery.impl.Serialization;
import org.apache.poi.ss.usermodel.*;
import org.apache.poi.xssf.usermodel.DefaultIndexedColorMap;
import org.apache.poi.xssf.usermodel.XSSFCellStyle;
import org.apache.poi.xssf.usermodel.XSSFColor;
import org.apache.poi.xssf.usermodel.XSSFDataFormat;
import org.apache.poi.xssf.usermodel.XSSFFont;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;
import org.apache.poi.xssf.usermodel.extensions.XSSFCellBorder;
import pe.com.megaautos.config.DBDataSource;
import pe.com.megaautos.model.OrdenTrabajo;

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
    
    public static byte[] writeXlsx(final DataFrame df, final OutputStream output)
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
        ByteArrayOutputStream output2 = new ByteArrayOutputStream();
        wb.write(output2);
        output2.close();
        return output2.toByteArray();
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
}

