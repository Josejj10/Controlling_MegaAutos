
package pe.com.megaautos.model;

/**
 *
 * @author nicolas
 */
public class Local {
    private Distrito local; 
    
    public Local(Distrito local){
        this.local = local;
    }

    public Distrito getLocal() {
        return local;
    }

    public void setLocal(Distrito local) {
        this.local = local;
    }
}
