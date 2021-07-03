/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.comprebem.processaPedido;

/**
 *
 * @author Leonardo
 */
public class Main {
    public static void main(String[] args) {
        Services services = new Services();
        Pedido pedido = new Pedido(500);
        
        services.calculaImposto(pedido);
        services.consultaDisponibilidade(pedido);
        services.emiteNota(pedido);
        services.enviarEmail(pedido);
    }
}
