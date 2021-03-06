/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.dao;

import java.util.ArrayList;
import pe.com.megaautos.model.AreaTrabajoCuentaContable;

/**
 *
 * @author Rodrigo
 */
public interface AreaTrabajoCuentaContableDAO {
    void insertar(AreaTrabajoCuentaContable atCc);
    int actualizar(AreaTrabajoCuentaContable atCc);
    int eliminar(int idAtCc, int idCuentaContable);
    ArrayList<AreaTrabajoCuentaContable> listar(int id);
}
