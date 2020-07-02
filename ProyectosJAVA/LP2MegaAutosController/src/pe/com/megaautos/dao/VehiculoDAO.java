/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.dao;
import java.util.ArrayList;
import joinery.DataFrame;
import pe.com.megaautos.model.Vehiculo;
/**
 *
 * @author Jose
 */
public interface VehiculoDAO {
    int insertar(Vehiculo vehiculo);
    //void guardarBatch(DataFrame df);
    int actualizar(Vehiculo vehiculo);
    int eliminar(int idVehiculo);
    ArrayList<Vehiculo> listar();
    Vehiculo buscar(int idVehiculo);
}
