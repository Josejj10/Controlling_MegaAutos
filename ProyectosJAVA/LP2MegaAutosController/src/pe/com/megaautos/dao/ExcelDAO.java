/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.dao;

import java.util.Date;
import pe.com.megaautos.model.Excel;

/**
 *
 * @author Rodrigo
 */
public interface ExcelDAO {
    Excel leerArchivoEntrada();
    Excel leerArchivoSalida();
    Excel buscar(Date fechaIni, Date fechaFin, int idSede);
    int insertarArchivoEntrada(Excel excel);
    int insertarArchivoSalida(Excel excel);
    Excel buscarPorId(int idExcel);
}
