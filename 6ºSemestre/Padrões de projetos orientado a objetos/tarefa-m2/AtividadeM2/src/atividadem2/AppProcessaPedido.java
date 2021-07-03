/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package atividadem2;

import processar.ProcessadorPedido;

/**
 *
 * @author Leonardo
 */
public class AppProcessaPedido {
    public static void main(String[] args) throws InstantiationException, IllegalAccessException {
        ProcessadorPedido pp = new ProcessadorPedido();
        pp.processar();
    }
}
