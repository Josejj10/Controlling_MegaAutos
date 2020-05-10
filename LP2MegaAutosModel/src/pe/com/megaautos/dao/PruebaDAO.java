/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.dao;

import java.util.ArrayList;
import pe.com.megaautos.model.AreaTrabajo;
/**
 *
 * @author Jose
 */
public interface PruebaDAO {
    int insertar();
    int actualizar();
    int eliminar(int idEmpleado);
    ArrayList<AreaTrabajo> listar();
}
