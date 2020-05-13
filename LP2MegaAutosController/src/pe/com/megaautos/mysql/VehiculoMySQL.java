package pe.edu.pucp.lp2soft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.com.megaautos.config.DBManager;
import pe.com.megaautos.dao.VehiculoDAO;
import pe.com.megaautos.model.Vehiculo;

public class VehiculoMySQL implements VehiculoDAO{

    Connection con;
    
    @Override
    public int insertar(Vehiculo vehiculo) {
        int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);
            
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_VEHICULO(?,?,?)}");
            // Insertar Vehiculo recibirá la placa, el nombre del tipo vehiculo
            // Y el id del propietario
            // En el procedure de MySQL, cambiara el nombre del tipo vehiculo
            // Por su id, para poder insertarlo en la tabla 
            cs.registerOutParameter("_ID_VEHICULO", java.sql.Types.INTEGER);
            cs.setString(3, vehiculo.getPlaca());
            cs.setString(4, vehiculo.getTipoVehiculo());
            cs.setInt(2, vehiculo.getPropietario().getId());
            cs.executeUpdate();
            rpta = cs.getInt("_ID_VEHICULO");
            con.close();
            // Actualiza el ID del vehiculo insertado para tenerlo en Java
            vehiculo.setId(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }
         return rpta;
    }

    @Override
    public int actualizar(Vehiculo vehiculo) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idVehiculo) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Vehiculo> listar() {
        ArrayList<Vehiculo> vehiculos = new ArrayList<>();
        try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
          getConnection("jdbc:mysql://"+
         "inf28220201.cx9ws7aw0g5e.us-east-1.rds.amazonaws.com"+
                  ":3306/lp2", "admin", "abcd1234");
            //Ejecutar una sentencia
            String sentencia = "SELECT * FROM EMPLEADO INNER JOIN "
                    + "PERSONA ON PERSONA.ID_PERSONA = EMPLEADO.ID_EMPLEADO";
            Statement st = con.createStatement();
            //executeQuery -> SELECT
            //executeUpdate -> INSERT, UPDATE, DELETE
            ResultSet rs = st.executeQuery(sentencia);
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            /*while(rs.next()){
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.setIdPersona(rs.getInt("ID_EMPLEADO"));
                vehiculo.setNombreCompleto(rs.getString("NOMBRE_COMPLETO"));
                vehiculo.setDNI(rs.getString("DNI"));
                vehiculo.setCargo(rs.getString("CARGO"));
                vehiculo.setSueldo(rs.getFloat("SUELDO"));
                vehiculo.setActivo(rs.getBoolean("ACTIVO"));
                vehiculos.add(vehiculo);
            }*/
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        //Devolviendo los vehiculos
        return vehiculos;
    }

}
