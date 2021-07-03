/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package relatorio;

import java.util.List;
import model.Pedido;

/**
 *
 * @author Leonardo
 */
public abstract class RelatorioTemplate {
    private List<Pedido> pedidos;

    public List<Pedido> getPedidos() {
        return pedidos;
    }

    public void setPedidos(List<Pedido> pedidos) {
        this.pedidos = pedidos;
    }
    
    
    public void gerar(){
        montaCabecalho();
        montaConteudo();
        for(Pedido pedido : pedidos){
            System.out.println(pedido);
        }
        montaConteudo();
        montaRodape();
    }
    public abstract void montaCabecalho();
    public abstract void montaConteudo();
    public abstract void montaRodape();
}