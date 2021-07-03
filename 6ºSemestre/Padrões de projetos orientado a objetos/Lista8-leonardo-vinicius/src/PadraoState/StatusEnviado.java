/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package PadraoState;

/**
 *
 * @author Leonardo
 */
public class StatusEnviado implements StatusPedido{

    @Override
    public void processando(Pedido pedido) {
        throw new IllegalStateException("O pedido não pode ser processado depois de enviado");
    }

    @Override
    public void cancelado(Pedido pedido) {
        throw new IllegalStateException("O pedido não pode ser cancelado depois de enviado");
    }

    @Override
    public void enviado(Pedido pedido) {
        throw new IllegalStateException("O pedido ja foi enviado");
    }
    
}
