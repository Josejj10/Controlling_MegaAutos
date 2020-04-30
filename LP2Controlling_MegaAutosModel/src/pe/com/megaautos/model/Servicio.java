
package pe.com.megaautos.model;

/**
 *
 * @author nicolas
 */
public abstract class Servicio {
    private int cod_serv;
    private String descrip;
    public Servicio() {
    }

    public Servicio(int cod_serv, String descrip) {
        this.cod_serv = cod_serv;
        this.descrip = descrip;
    }

    public int getCod_serv() {
        return cod_serv;
    }

    public String getDescrip() {
        return descrip;
    }

    public void setCod_serv(int cod_serv) {
        this.cod_serv = cod_serv;
    }

    public void setDescrip(String descrip) {
        this.descrip = descrip;
    }
    
    
}
