/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.dao;

import java.util.ArrayList;
import pe.com.megaautos.model.Servicio;
/**
 *
 * @author Rodrigo
 */
public interface ServicioDAO {
    int insertar(Servicio servicio);
    int actualizar(Servicio servicio);
    int eliminar(int idServicio);
    ArrayList<Servicio> listar();
}
