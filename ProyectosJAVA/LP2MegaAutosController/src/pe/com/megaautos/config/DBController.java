package pe.com.megaautos.config;

public abstract class DBController {
    public static final DAOFactory controller = 
            DAOFactory.getDAOFactory();
}
