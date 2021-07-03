/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Lista1;

import java.text.SimpleDateFormat;
import java.util.Date;

/**
 *
 * @author Leonardo
 */
public class PromocaoLimiteData extends Promocao {
    private Date dataLimite;

    public Date getDataLimite() {
        return dataLimite;
    }

    public void setDataLimite(Date dataLimite) {
        this.dataLimite = dataLimite;
    }
    @Override
    public boolean estaAtiva(){
        Date dataAgora = new Date(System.currentTimeMillis());
        
        return this.dataLimite.after(dataAgora);
    }
}
