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
public interface StatusPedido {
    public void processando(Pedido pedido);
    public void cancelado(Pedido pedido);
    public void enviado(Pedido pedido);
}
