/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package processar;

import java.util.List;
import model.Pedido;
import model.Status;
import relatorio.LeitorDeArquivo;

/**
 *
 * @author Leonardo
 */
public class ProcessadorPedido {
    public void processar(){
        PedidoFactory pf = new PedidoFactory();
        PedidoCommand pc = pf.create(Status.PENDENTE);
        
        LeitorDeArquivo la = new LeitorDeArquivo();

        for (Pedido pedido : la.ler()) {
            pc.executar(pedido);
        }
    }
}
