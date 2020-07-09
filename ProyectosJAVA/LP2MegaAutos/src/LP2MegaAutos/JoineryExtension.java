/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LP2MegaAutos;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.sql.Connection;
import java.sql.PreparedStatement;
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
import org.apache.poi.xssf.usermodel.XSSFDataFormat;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;
import pe.com.megaautos.config.DBController;
import pe.com.megaautos.config.DBDataSource;
import pe.com.megaautos.dao.UsuarioDAO;
import pe.com.megaautos.model.OrdenTrabajo;
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
    
}
