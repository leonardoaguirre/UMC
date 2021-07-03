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
public class Services {
    public void consultaDisponibilidade(Pedido pedido){
        //consulta disponibilidade
        boolean disp = new Estoque().consutarDisponibilidade(pedido);
    }
    public void calculaImposto(Pedido pedido){
        //calcula impostos
        CalculadorDeImpostos impostos = new CalculadorDeImpostos();
        double icms = impostos.calcularICMS(pedido);
    }
    public void emiteNota(Pedido pedido){
         //emite nota fiscal
        GeradorDeNotaFiscal notaFiscal = new GeradorDeNotaFiscal();
        notaFiscal.emitir(pedido);
    }
    public void enviarEmail(Pedido pedido){
         //enviar email de confirmação
        EmailDeConfirmacao confirmacao = new EmailDeConfirmacao();
        confirmacao.enviar(pedido);
        
        Rastreamento ras = new Rastreamento();
        ras.rastrear(pedido);
    }
}
