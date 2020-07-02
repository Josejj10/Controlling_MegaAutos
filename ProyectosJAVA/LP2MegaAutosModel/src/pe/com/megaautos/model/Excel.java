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
public class Excel {
    private byte[] excel1;
    private byte[] excel2;

    public Excel(){
        
    }
    
    public Excel(byte[] excel1, byte[] excel2) {
        this.excel1 = excel1;
        this.excel2 = excel2;
    }

    public byte[] getExcel1() {
        return excel1;
    }

    public void setExcel1(byte[] excel1) {
        this.excel1 = excel1;
    }

    public byte[] getExcel2() {
        return excel2;
    }

    public void setExcel2(byte[] excel2) {
        this.excel2 = excel2;
    }
    
    
}
