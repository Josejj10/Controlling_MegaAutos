/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.config;
import com.mchange.v2.c3p0.*;
import java.sql.Connection;
import java.sql.SQLException;
import java.util.Properties;

/**
 *
 * @author Jose
 */
public class DBDataSource {
        
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
                        ds.setAcquireIncrement(5);     
                        ds.setAcquireRetryAttempts(2);
                        // Establecer max statements para PreparedStatement pooling
                        ds.setMaxStatements(200);
                        ds.setMaxStatementsPerConnection(40);
                        
		} catch (Exception ex) {
			System.out.println(ex.getMessage());    
		}
	}
	
	public static Connection getConnection() throws SQLException{
		return ds.getConnection();
	}
}