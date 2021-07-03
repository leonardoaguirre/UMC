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
public class StatusProcessando implements StatusPedido{

    @Override
    public void processando(Pedido pedido) {
        pedido.setStatus(new StatusProcessando());
        System.out.println("O pedido esta em processamento...");
    }

    @Override
    public void cancelado(Pedido pedido) {
        pedido.setStatus(new StatusCancelado());
        System.out.println("O pedido foi cancelado com sucesso!");
    }

    @Override
    public void enviado(Pedido pedido) {
        pedido.setStatus(new StatusEnviado());
        System.out.println("O pedido foi enviado com sucesso!");
    }
    
}
