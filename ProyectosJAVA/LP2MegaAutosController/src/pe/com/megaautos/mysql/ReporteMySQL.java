/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.com.megaautos.config.DBDataSource;
import pe.com.megaautos.dao.ReporteDAO;
import pe.com.megaautos.model.Reporte;

/**
 *
 * @author Rodrigo
 */
public class ReporteMySQL implements ReporteDAO{
    Connection con;
    @Override
    public int insertar(Reporte reporte) {
        int rpta = 0;
         try{
    //             private int idExcelEntrada;//"El reporte ya ha sido creado"
            //    private int idExcelSalida;
            //    private Date fechaInicio;
            //    private Date fechaFin;
            //    private int idUsuario;
            //    private String tipoReporte;
            //    private String titulo;
            //    private Double ingresos;
            //    private Double egresos;
            //    private Sede sede;
            con = DBDataSource.getConnection();
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_REPORTE(?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_ID_REPORTE", java.sql.Types.INTEGER);
            cs.setInt("_ID_ARCHIVO_ENTRADA", reporte.getIdExcelEntrada());
            cs.setInt("_ID_ARCHIVO_SALIDA", reporte.getIdExcelSalida());
            java.sql.Date sqlDateCreacion = new java.sql.Date(reporte.getFechaCreacion().getTime());
            cs.setDate("_FECHA_CREACION", sqlDateCreacion);
            java.sql.Date sqlDateInicio = new java.sql.Date(reporte.getFechaInicio().getTime());
            cs.setDate("_FECHA_INICIO", sqlDateInicio);
            java.sql.Date sqlDateFin = new java.sql.Date(reporte.getFechaFin().getTime());
            cs.setDate("_FECHA_FIN", sqlDateFin);
            cs.setString("_TIPO_REPORTE", reporte.getTipoReporte());
            cs.setString("_TITULO", reporte.getTitulo().toUpperCase());
            cs.setDouble("_INGRESOS", reporte.getIngresos());
            cs.setDouble("_EGRESOS", reporte.getEgresos());
            cs.setInt("_ID_SEDE", reporte.getSede().getId());
            cs.setInt("_ID_USUARIO", reporte.getIdUsuario());
            cs.executeUpdate();
            rpta = cs.getInt("_ID_REPORTE");
            reporte.setIdReporte(rpta);
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
    public ArrayList<Reporte> listar() {
        ArrayList<Reporte> reportes = new ArrayList<>();
        try{
            con = DBDataSource.getConnection();
            CallableStatement cs = con.prepareCall(
                    "{call LISTAR_REPORTE()}");
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                Reporte reporte = new Reporte();
                reporte.setIdReporte(rs.getInt("ID_REPORTE"));
                reporte.setEgresos(rs.getDouble("EGRESOS"));
                reporte.setIngresos(rs.getDouble("INGRESOS"));
                reporte.setFechaCreacion(rs.getDate("FECHA_CREACION"));
                reporte.setFechaFin(rs.getDate("FECHA_FIN"));
                reporte.setFechaInicio(rs.getDate("FECHA_INICIO"));
                reporte.setIdExcelEntrada(rs.getInt("ID_ARCHIVO_ENTRADA"));
                reporte.setIdExcelSalida(rs.getInt("ID_ARCHIVO_SALIDA"));
                reporte.setIdUsuario(rs.getInt("ID_USUARIO"));
                reporte.getSede().setId(rs.getInt("ID_SEDE"));
                reporte.setTipoReporte(rs.getString("TIPO_REPORTE"));
                reporte.setTitulo(rs.getString("TITULO"));
                reporte.setNombreUsuario(rs.getString("NOMBRE"));
                reporte.getSede().setDistrito(rs.getString("DISTRITO"));
                reportes.add(reporte);
            }
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
        return reportes;
    

    }

    @Override
    public Reporte buscarPorId(int idReporte) {
        Reporte reporte = new Reporte();
        try{
            con = DBDataSource.getConnection();
            CallableStatement cs = con.prepareCall(
                    "{call BUSCAR_REPORTE_ID(?)}");
            cs.setInt("_ID_REPORTE", idReporte);
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                reporte.setIdReporte(rs.getInt("ID_REPORTE"));
                reporte.setEgresos(rs.getDouble("EGRESOS"));
                reporte.setIngresos(rs.getDouble("INGRESOS"));
                reporte.setFechaCreacion(rs.getDate("FECHA_CREACION"));
                reporte.setFechaFin(rs.getDate("FECHA_FIN"));
                reporte.setFechaInicio(rs.getDate("FECHA_INICIO"));
                reporte.setIdExcelEntrada(rs.getInt("ID_ARCHIVO_ENTRADA"));
                reporte.setIdExcelSalida(rs.getInt("ID_ARCHIVO_SALIDA"));
                reporte.setIdUsuario(rs.getInt("ID_USUARIO"));
                reporte.getSede().setId(rs.getInt("ID_SEDE"));
                reporte.setTipoReporte(rs.getString("TIPO_REPORTE"));
                reporte.setTitulo(rs.getString("TITULO"));
                reporte.setNombreUsuario(rs.getString("NOMBRE"));
                reporte.getSede().setDistrito(rs.getString("DISTRITO"));
            }
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
        return reporte;
    

    }
    
}
