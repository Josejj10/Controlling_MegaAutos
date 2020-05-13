/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.dao;

import java.util.ArrayList;
import pe.com.megaautos.model.ComprobantePago;

/**
 *
 * @author Rodrigo
 */
public interface ComprobantePagoDAO {
    int insertar(ComprobantePago comprobantePago);
    int actualizar(ComprobantePago comprobantePago);
    int eliminar(int idComprobantePago);
    ArrayList<ComprobantePago> listar();
}
