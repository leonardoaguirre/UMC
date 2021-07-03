/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package br.com.comprebem.processaPedido;


/**
 *
 * @author wolleyws
 */
public class GeradorDeNotaFiscal {
    
    public void emitir(Pedido pedido){
        System.out.println("Nota gerada. Total da nota = " +pedido.getTotal() );
    }
            
    
}
