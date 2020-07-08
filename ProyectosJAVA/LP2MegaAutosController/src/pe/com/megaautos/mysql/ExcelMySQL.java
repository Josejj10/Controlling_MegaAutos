/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import pe.com.megaautos.config.DBDataSource;
import pe.com.megaautos.dao.ExcelDAO;
import pe.com.megaautos.model.Excel;

/**
 *
 * @author Rodrigo
 */
public class ExcelMySQL implements ExcelDAO {

    Connection con;
    @Override
    public Excel leerArchivoEntrada() {
        Excel excel = new Excel();
        try{
            con = DBDataSource.getConnection();
            CallableStatement cs = con.prepareCall(
                    "{call LEER_ARCHIVO(?)}");            
            cs.setInt("_TIPO", 1);
            ResultSet rs = cs.executeQuery(); 
            while(rs.next()){                
                excel.setArchivo(rs.getBytes("ARCHIVO"));
            }
            con.close();
        }
        catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        } 

        return excel;        
    }
    @Override
    public Excel leerArchivoSalida() {
        Excel excel = new Excel();
        try{
            con = DBDataSource.getConnection();
            CallableStatement cs = con.prepareCall(
                    "{call LEER_ARCHIVO(?)}");            
            cs.setInt("_TIPO", 2);
            ResultSet rs = cs.executeQuery(); 
            while(rs.next()){                
                excel.setArchivo(rs.getBytes("ARCHIVO"));
            }
            con.close();
        }
        catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }         

        return excel;        
    }
    @Override
    public int insertarArchivoEntrada(Excel excel) {
        int rpta = 0;
         try{
            con = DBDataSource.getConnection();            
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_ARCHIVO(?,?,?)}");
            cs.registerOutParameter("_ID_ARCHIVO", java.sql.Types.INTEGER);
            cs.setBytes("_ARCHIVO", excel.getArchivo());            
            cs.setInt("_TIPO", 1);
            cs.executeUpdate();
            rpta = cs.getInt("_ID_ARCHIVO");
            // Actualiza el ID del cliente insertado para tenerlo en Java
            excel.setId(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        } 
         return rpta;
    }
    
    @Override
    public int insertarArchivoSalida(Excel excel) {
        int rpta = 0;
         try{
            con = DBDataSource.getConnection();            
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_ARCHIVO(?,?,?)}");
            cs.registerOutParameter("_ID_ARCHIVO", java.sql.Types.INTEGER);
            cs.setBytes("_ARCHIVO", excel.getArchivo());
            cs.setInt("_TIPO", 2);
            cs.executeUpdate();
            rpta = cs.getInt("_ID_ARCHIVO");
            // Actualiza el ID del cliente insertado para tenerlo en Java
            excel.setId(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }
            catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        } 
         return rpta;
    }
    
    
    
}
