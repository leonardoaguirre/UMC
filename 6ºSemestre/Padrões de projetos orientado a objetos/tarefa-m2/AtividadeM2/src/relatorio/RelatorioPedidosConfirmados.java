/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package relatorio;

import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;

/**
 *
 * @author Leonardo
 */
public class RelatorioPedidosConfirmados extends RelatorioTemplate{

        @Override
    public void montaCabecalho() {
        System.out.println(".............Relatorio de pedidos Confirmados............");
    }

    @Override
    public void montaConteudo() {
        System.out.println("________________________________________________________");
    }

    @Override
    public void montaRodape() {
        Calendar c =  Calendar.getInstance();
        System.out.println("Gerado em: "+c.getTime());
    }
    
}
