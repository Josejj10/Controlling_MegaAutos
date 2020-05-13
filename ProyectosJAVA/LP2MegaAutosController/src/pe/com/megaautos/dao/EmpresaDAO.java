/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.dao;

import java.util.ArrayList;
import pe.com.megaautos.model.Empresa;

/**
 *
 * @author Rodrigo
 */
public interface EmpresaDAO {
    int insertar(Empresa empresa);
    int actualizar(Empresa empresa);
    int eliminar(int idEmpresa);
    ArrayList<Empresa> listar();
}
