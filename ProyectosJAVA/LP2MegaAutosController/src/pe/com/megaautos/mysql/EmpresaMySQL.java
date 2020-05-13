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
import pe.com.megaautos.dao.EmpresaDAO;
import pe.com.megaautos.model.Empresa;

/**
 *
 * @author Jose
 */
public class EmpresaMySQL implements EmpresaDAO{
    Connection con;
    @Override
    public int insertar(Empresa empresa) {
        int rpta = 0;
         try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer la conexion
            con = DriverManager.getConnection(DBManager.url, 
                    DBManager.user, DBManager.password);
            CallableStatement cs = con.prepareCall(
                    "{call INSERTAR_EMPRESA(?,?)}");
            // Insertar Empresa recibirá el nombre de la empresa
            cs.registerOutParameter("_ID_EMPRESA", java.sql.Types.INTEGER);
            // TODO AL NOMBRE AGREGARLE SACAPALABRAS QUE BORRE LOS DOBLE ESPACIOS
            cs.setString("_NOMBRE", empresa.getNombre().toUpperCase());
            cs.executeUpdate();
            rpta = cs.getInt("_ID_EMPRESA");
            con.close();
            // Actualiza el ID de la empresa insertada para tenerlo en Java
            empresa.setId(rpta);
        }catch(Exception ex){
             System.out.println(ex.getMessage());
        }
         return rpta;
    }

    @Override
    public int actualizar(Empresa empresa) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idEmpresa) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Empresa> listar() {
        ArrayList<Empresa> empresas = new ArrayList<>();
        try{
            //Registrar el JAR de conexión
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Establecer una conexión a la BD
            Connection con = DriverManager.
            getConnection(DBManager.url,DBManager.user, DBManager.password);
            // Listar empresa devuelve una lista de empresas
            // con ID_Empresa, nombre, tipo_empresa, tipo_doc
            // numero_doc, correo y telefono
            CallableStatement cs = con.prepareCall(
                    "{call LISTAR_EMPRESA()}");
            ResultSet rs = cs.executeQuery();
            //Recorrer todas las filas que devuelve la ejecucion sentencia
            while(rs.next()){
                Empresa empresa = new Empresa();
                empresa.setId(rs.getInt("ID_EMPRESA"));
                empresa.setNombre(rs.getString("NOMBRE"));
                empresas.add(empresa);
            }
            //cerrar conexion
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        //Devolviendo los vehiculos
        return empresas;    
    }
    
}