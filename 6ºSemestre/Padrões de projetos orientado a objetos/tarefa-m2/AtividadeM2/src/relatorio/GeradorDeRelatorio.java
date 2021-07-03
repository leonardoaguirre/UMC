/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package relatorio;

import java.util.ArrayList;
import java.util.List;
import model.Pedido;
import model.Status;

/**
 *
 * @author Leonardo
 */
public class GeradorDeRelatorio {
    public void gerar(Status status){
        LeitorDeArquivo leitorDeArquivo = new LeitorDeArquivo();
        RelatorioFactory relatorioFactory = new RelatorioFactory();
        List<Pedido> pedidosRelatorio = new ArrayList<>();
        
        RelatorioTemplate rt = relatorioFactory.create(status);//verifica qual tipo de relatorio requerido
        
        for(Pedido pedido : leitorDeArquivo.ler()){
            if(pedido.getStatus().equals(status)){//percorre o list e adiciona se o status do pedido igual ao status requerido
                pedidosRelatorio.add(pedido);
            }
        }
        rt.setPedidos(pedidosRelatorio);//seta o list filtrado ao atributo list do relatorio template
        rt.gerar();//imprime o relatorio requerido
        
    }
}
