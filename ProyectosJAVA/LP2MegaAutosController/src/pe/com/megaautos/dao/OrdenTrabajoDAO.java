/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.dao;

import java.util.ArrayList;
import pe.com.megaautos.model.OrdenTrabajo;

/**
 *
 * @author Rodrigo
 */
public interface OrdenTrabajoDAO {
    int insertar(OrdenTrabajo ordenTrabajo);
    int actualizar(OrdenTrabajo ordenTrabajo);
    int eliminar(int idOrdenTrabajo);
    ArrayList<OrdenTrabajo> listar();
    OrdenTrabajo buscar(int idOrdenTrabajo);
    
}
