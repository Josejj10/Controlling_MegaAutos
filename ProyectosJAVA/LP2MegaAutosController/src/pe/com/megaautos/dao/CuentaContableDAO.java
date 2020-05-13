/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.dao;

import java.util.ArrayList;
import pe.com.megaautos.model.CuentaContable;

/**
 *
 * @author Rodrigo
 */
public interface CuentaContableDAO {
    int insertar(CuentaContable cuentaContable);
    int actualizar(CuentaContable cuentaContable);
    int eliminar(int idCuentaContable);
    ArrayList<CuentaContable> listar();
    
}
