/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.services;

import java.util.Properties;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.mail.Message;
import javax.mail.MessagingException;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.AddressException;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeMessage;
import javax.swing.JOptionPane;
import pe.com.megaautos.config.DBController;
import pe.com.megaautos.dao.UsuarioDAO;
import pe.com.megaautos.model.Usuario;

/**
 *
 * @author Rodrigo
 */
@WebService(serviceName = "PasswordWS")
public class PasswordWS {
    private static String VALID_CHARACTERS = "abcdefghijklmnopqrstuvwxyz"
            + "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    
    public static String randomAlphaNumeric(int count) {    
        StringBuilder builder = new StringBuilder();
        while (count-- != 0) {
            int character = (int)(Math.random()*VALID_CHARACTERS.length());
            builder.append(VALID_CHARACTERS.charAt(character));
        }        
        return builder.toString();
    }

    public int enviarCorreo(String correoDestinatario){
        Usuario usuario = new Usuario();
        UsuarioDAO daoUsuario = DBController.controller.getUsuarioDAO();
        usuario = daoUsuario.buscarPorCorreo(correoDestinatario);
        if(usuario==null){
            return 0;
        }        
        String token = "";
        token = randomAlphaNumeric(16);
        
        int res = daoUsuario.actualizarToken(usuario, token);
        
        Properties propiedad = new Properties();
        propiedad.setProperty("mail.smtp.host", "smtp.gmail.com");
        propiedad.setProperty("mail.smtp.starttls.enable", "true");
        propiedad.setProperty("mail.smtp.port", "587");
        propiedad.setProperty("mail.smtp.auth", "true"); 
        propiedad.setProperty("mail.smtp.ssl.trust", "smtp.gmail.com");
        
        Session sesion = Session.getDefaultInstance(propiedad);
        sesion.setDebug(true);
        
        String correoEmpresa = "pruebasistemalp2@gmail.com";//TODO CREAR CORREO SOPORTE
        String contrasena = "C9AA28BA93";
        String asunto = "Recuperación de Contraseña - Sistema MegaAutos";
        
        
        String mensaje = "Estimado usuario,\n\nEl token para recuperar su "
                + "contraseña es:\n\n"+token+"\n\nPor favor, utilícelo para actualizar su contraseña. "
                + "Se le recuerda que el token tiene una validez máxima de 2 horas, luego de ese periodo,"
                + " tendrá que generar un nuevo correo electrónico.\n"
                + "\nSaludos cordiales,\n"
                + "Soporte MegaAutos";
        
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
            Logger.getLogger(PasswordWS.class.getName()).log(Level.SEVERE, null, ex);
            //System.out.println(ex);
        } catch (MessagingException ex) {
            Logger.getLogger(PasswordWS.class.getName()).log(Level.SEVERE, null, ex);
            //System.out.println(ex);
        } catch (Exception ex){
            System.out.println(ex);
        }
        return usuario.getId();
    }
    

    @WebMethod(operationName = "sendMail")
    public int sendMail(@WebParam(name = "correo") String correo) {
        int a=0;
        try{            
            a = enviarCorreo(correo);
        }
        catch(Exception ex){
            System.out.println(ex);
        }
        return a;
    }
    
    @WebMethod(operationName = "recuperarPasswrd")
    public int recuperarPasswrd(@WebParam(name = "correo") String correo, 
            @WebParam(name = "token") String token, 
            @WebParam(name = "passwrd") String passwrd){
        //Actualizar contraseña
        int rpta =0;
        UsuarioDAO daoUsuario = DBController.controller.getUsuarioDAO();
        rpta = daoUsuario.actualizarPasswrd(correo, token, passwrd);
        return rpta;
    }
    
    @WebMethod(operationName = "verificarToken")
    public boolean verificarToken(@WebParam(name="correo") String correo,
            @WebParam(name = "token") String token)
    {
        boolean rpta=false;
        UsuarioDAO daoUsuario = DBController.controller.getUsuarioDAO();
        try{
            rpta = daoUsuario.verificarToken(correo, token);
        }
        catch(Exception ex){
            System.out.println(ex);
        }
        return rpta;
    }
    
    @WebMethod(operationName = "invalidarToken")
    public int invalidarToken(@WebParam(name = "correo") String correo, 
            @WebParam(name = "token") String token){
        //Actualizar contraseña
        int rpta =0;
        UsuarioDAO daoUsuario = DBController.controller.getUsuarioDAO();
        try{            
            rpta = daoUsuario.invalidarToken(correo, token);
        }
        catch(Exception ex){
            System.out.println(ex);
        }
        return rpta;
    }
}
