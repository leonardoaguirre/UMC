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
public class StatusCancelado implements StatusPedido{

    @Override
    public void processando(Pedido pedido) {
        throw new IllegalStateException("O pedido foi cancelado e não pode ser processado"); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void cancelado(Pedido pedido) {
        //pedido.setStatus(new StatusCancelado());
        throw new IllegalStateException("O pedido ja foi cancelado ");
    }

    @Override
    public void enviado(Pedido pedido) {
        throw new IllegalStateException("O pedido não pode ser enviado pois foi cancelado"); //To change body of generated methods, choose Tools | Templates.
    }
    
}
