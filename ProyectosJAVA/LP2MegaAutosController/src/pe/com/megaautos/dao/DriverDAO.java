/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.dao;

import java.util.ArrayList;
import pe.com.megaautos.model.Driver;

/**
 *
 * @author Rodrigo
 */
public interface DriverDAO {
    int insertar(Driver driver);
    int actualizar(Driver driver);
    int eliminar(int idDriver);
    ArrayList<Driver> listar();
    Driver buscar(int idDriver);
}
