/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package PadraoState;

import java.text.DateFormat;

/**
 *
 * @author Leonardo
 */
public class App {

    public static void main(String[] args) {
        Pedido pedido = new Pedido(DateFormat.getDateInstance().getCalendar(), 0);
//        pedido.addItem(new ItemPedido("jogo", 200, 3));
//        pedido.addItem(new ItemPedido("console", 4000, 1));
        System.out.println("" + pedido.toString());
        // pedido.calcularTotal();
        pedido.enviar();
        System.out.println(pedido);
        pedido.cancelar();

    }
}
