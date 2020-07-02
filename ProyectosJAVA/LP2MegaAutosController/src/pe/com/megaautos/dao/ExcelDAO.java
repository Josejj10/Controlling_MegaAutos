/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.dao;

import pe.com.megaautos.model.Excel;

/**
 *
 * @author Rodrigo
 */
public interface ExcelDAO {
    Excel leerArchivo();
    int insertarArchivo(Excel excel);
}
