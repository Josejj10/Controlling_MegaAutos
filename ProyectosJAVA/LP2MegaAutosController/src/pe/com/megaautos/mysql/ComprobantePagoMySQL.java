/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.com.megaautos.config.DBManager;
import pe.com.megaautos.dao.ComprobantePagoDAO;
import pe.com.megaautos.dao.OrdenTrabajoDAO;
import pe.com.megaautos.model.ComprobantePago;

/**
 *
 * @author Jose
 */
public class ComprobantePagoMySQL implements ComprobantePagoDAO {
    Connection con;
    @Override
    public int insertar(ComprobantePago comprobantePago) {
        int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_COMPROBANTE(?,?,?,?,?,?)}");
            // Insertar ComprobantePago recibirá el numero comprobante
            // el monto, la id de orden de trabajo el tipo de comprobantePago
            // el tipo de documento, el numDocumento, el correo y telefono
            // En el procedure de MySQL, cambiara el nombre del tipo comprobante
            // Por su id, para poder insertarlo en la tabla 
            cs.registerOutParameter("_ID_COMPROBANTE", java.sql.Types.INTEGER);
            // TODO AL NOMBRE AGREGARLE SACAPALABRAS QUE BORRE LOS DOBLE ESPACIOS
            cs.setString("_NUM_COMPRO", comprobantePago.getNumeroComprobante());
            cs.setDouble("_MONTO", comprobantePago.getMonto());
            cs.setString("_TIPO_COMPROBANTE", comprobantePago.getTipoComprobante().toUpperCase());
            cs.setInt("_ID_ORDEN_TRABAJO", comprobantePago.getOrdenTrabajo().getId());
            java.sql.Date fechaSql = 
                    new java.sql.Date(comprobantePago.getFecha().getTime());
            cs.setDate("_FECHA",fechaSql);
            cs.executeUpdate();
            rpta = cs.getInt("_ID_COMPROBANTE");
            con.close();
            // Actualiza el ID del comprobante insertado para tenerlo en Java
            comprobantePago.setId(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }
         return rpta;
    }

    @Override
    public int actualizar(ComprobantePago comprobantePago) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idComprobantePago) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<ComprobantePago> listar() {
        ArrayList<ComprobantePago> comprobantePagos = new ArrayList<>();
        try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Listar comprobantePago devuelve una lista de comprobantePagos
            // con ID_ComprobantePago, numero comprobante, tipo comprobante
            // monto, id_orden trabajo y fecha
            CallableStatement cs = con.prepareCall(
                    "{call LISTAR_COMPROBANTE()}");
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                ComprobantePago comprobantePago = new ComprobantePago();
                comprobantePago.setId(rs.getInt("ID_COMPROBANTE"));
                comprobantePago.setNumeroComprobante(rs.getString("NUM_COMPRO"));
                comprobantePago.setTipoComprobante(rs.getString("TIPO_COMPROBANTE"));
                comprobantePago.setMonto(rs.getDouble("MONTO"));
                // setOrdenTrabajo lee int y lo busca
                OrdenTrabajoDAO daoOrdenTrabajo =
                        new OrdenTrabajoMySQL();
                comprobantePago.setOrdenTrabajo(daoOrdenTrabajo.buscar(rs.getInt("ID_ORDEN_TRABAJO")));
                comprobantePago.setFecha(rs.getDate("FECHA"));
                comprobantePagos.add(comprobantePago);
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        //Devolviendo los comprobantes
        return comprobantePagos;    
    }
    
}
