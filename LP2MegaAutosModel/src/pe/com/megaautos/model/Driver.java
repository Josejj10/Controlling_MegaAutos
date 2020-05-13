/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.com.megaautos.model;

/**
 *
 * @author Rodrigo
 */
public class Driver {
    private int id;
    private double formula;
    
    public Driver(){
        
    }

    public Driver(double formula) {
        this.formula = formula;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }
    
    public double getFormula() {
        return formula;
    }

    public void setFormula(double formula) {
        this.formula = formula;
    }
}
