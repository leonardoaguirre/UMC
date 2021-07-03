
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
public class CalculadorDeImpostos {
    
       public double calcularIPI(Pedido pedido){
        return pedido.getTotal() * 0.3;
    }
    
      public double calcularICMS(Pedido pedido){
        return pedido.getTotal() * 0.18;
    }
    
}
