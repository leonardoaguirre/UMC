/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package processar;

import model.Pedido;

/**
 *
 * @author Leonardo
 */
public class PedidoConfirmado implements PedidoCommand{

    @Override
    public void executar(Pedido pedido) {
        System.out.println(pedido);
    }
    
}
