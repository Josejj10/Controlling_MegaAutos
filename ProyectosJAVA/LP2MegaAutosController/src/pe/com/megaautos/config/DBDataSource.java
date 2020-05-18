/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.config;
import com.mchange.v2.c3p0.*;
import java.sql.Connection;
import java.sql.SQLException;

/**
 *
 * @author Jose
 */
public class DBDataSource {
	private static final String DB_USERNAME="db.username";
	private static final String DB_PASSWORD="db.password";
	private static final String DB_URL ="db.url";
	private static final String DB_DRIVER_CLASS="driver.class.name";
        
        private static ComboPooledDataSource ds;
	static{
		try {
			ds = new ComboPooledDataSource();
			ds.setDriverClass("com.mysql.cj.jdbc.Driver");
			ds.setJdbcUrl(DBManager.url);
			ds.setUser(DBManager.user);
			ds.setPassword(DBManager.password);
                        ds.setInitialPoolSize(5);
			ds.setMinPoolSize(5);
                        // Establecer max statements para PreparedStatement pooling
                        ds.setMaxStatements(200);
			ds.setAcquireIncrement(5);
			
		} catch (Exception ex) {
			System.out.println(ex.getMessage());
		}
	}
	
	public static Connection getConnection() throws SQLException{
		return ds.getConnection();
	}
}