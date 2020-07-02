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
}
