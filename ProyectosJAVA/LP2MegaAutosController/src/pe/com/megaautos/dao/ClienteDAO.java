/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.dao;

import java.util.ArrayList;
import pe.com.megaautos.model.Cliente;

/**
 *
 * @author Rodrigo
 */
public interface ClienteDAO {
    Cliente buscar(int id);
    int insertar(Cliente cliente);
    int actualizar(Cliente cliente);
    int eliminar(int idCliente);
    ArrayList<Cliente> listar();
}
