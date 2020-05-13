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
 * @author Rodrigo
 */
public interface AreaTrabajoDAO {
    int insertar(AreaTrabajo areaTrabajo);
    int actualizar(AreaTrabajo areaTrabajo);
    int eliminar(int idAreaTrabajo);
    ArrayList<AreaTrabajo> listar();
    
}
