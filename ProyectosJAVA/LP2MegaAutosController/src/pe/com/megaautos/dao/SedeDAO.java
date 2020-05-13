/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.dao;

import java.util.ArrayList;
import pe.com.megaautos.model.Sede;

/**
 *
 * @author Rodrigo
 */
public interface SedeDAO {
    int insertar(Sede sede);
    int actualizar(Sede sede);
    int eliminar(int idSede);
    ArrayList<Sede> listar();
}
