/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.dao;
import java.util.ArrayList;
import pe.com.megaautos.model.Vehiculo;
/**
 *
 * @author Jose
 */
public interface VehiculoDAO {
    int insertar();
    int actualizar();
    int eliminar(int idEmpleado);
//    ArrayList<Vehiculo> listar();
}
