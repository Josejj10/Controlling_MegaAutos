/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package PruebaMySQL;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.com.megaautos.dao.PruebaDAO;
import pe.com.megaautos.model.AreaTrabajo;
/**
 *
 * @author Jose
 */
public class PruebaMySQL implements PruebaDAO {
    @Override
    public ArrayList<AreaTrabajo> listar(){
        ArrayList<AreaTrabajo> areasTrabajo = new ArrayList<>();
        try{
            // Registrar el JAR de Conexion
            Class.forName("com.mysql.cj.jdbc.Driver");
            // Establecer una conexion
            Connection con = DriverManager.
                    getConnection("url", "user", "password");
            // Ejecutar una sentencia
            String sentencia = "SELECT * FROM EMPLEADOS";
            Statement st = con.createStatement();
            // EXECUTE QUERY SOLO PARA SENTENCIAS DE TIPO SELECT
            ResultSet rs = st.executeQuery(sentencia);
            while (rs.next()){
                AreaTrabajo at = new AreaTrabajo();
                rs.getInt("NOMBRE_COLUMNA");
                
            }
            
        }
        catch (Exception ex){
            System.out.println(ex.getMessage());
        }
        return areasTrabajo;
    }

    @Override
    public int insertar() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int actualizar() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idEmpleado) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}
