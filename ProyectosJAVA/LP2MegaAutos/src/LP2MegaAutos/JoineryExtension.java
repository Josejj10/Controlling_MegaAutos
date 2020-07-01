/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LP2MegaAutos;
import java.io.IOException;
import java.io.InputStream;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.util.ArrayList;
import java.util.List;
import joinery.DataFrame;
import joinery.impl.Serialization;
import org.apache.poi.ss.usermodel.*;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;
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
    
    public static DataFrame<Object> readXlsx(final InputStream input, int nHoja)
    throws IOException {
        final Workbook wb = new XSSFWorkbook(input);
        final Sheet sheet = wb.getSheetAt(nHoja);
        final List<Object> columns = new ArrayList<>();
        final List<List<Object>> data = new ArrayList<>();

        for (final Row row : sheet) {
            if (row.getRowNum() == 2) {
                // read header
                for (final Cell cell : row) {
                    columns.add(readCell(cell));
                }
            } else if (row.getRowNum() > 2) {
                // read data values
                final List<Object> values = new ArrayList<>();
                for (final Cell cell : row) {
                    values.add(readCell(cell));
                }
                data.add(values);
            }
        }
        // create data frame
        final DataFrame<Object> dfFact = new DataFrame<>(columns);
        for (final List<Object> row : data) {
            dfFact.append(row);
        }
        return dfFact;
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
//    public void guardarBatch(List<OrdenTrabajo> ordenesTrabajo){
//        try{
//            Connection con = DBDataSource.getConnection();
//            PreparedStatement st = con.prepareStatement("");
//            int i = 0;
//            //for(OrdenTrabajo ordenTrabajo : ordenesTrabajo){
//            // st.setString(indexParametro, ordenTrabajo.getAlgo);
//            //st.addBatch();
//            //i++
//            // if(i%1000 ==0 || i == ordenesTrabajo.size()){
//            // st.executeBatch();
//            
//        }catch(Exception e){
//            System.out.println(e);
//        }
//    }
    
}
