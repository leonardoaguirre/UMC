/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servicoSMS;

import Modelo.Mensagem;

/**
 *
 * @author Leonardo
 */
public class EnviadorSMS implements ISMS{

    @Override
    public boolean enviar(Mensagem mensagem) {
        System.out.println("Enviando mensagens com biblioteca propria(interna)");
        System.out.println("Mensagem: "+mensagem.getTexto()+" De: "+mensagem.getOrigem()+" Para: "+mensagem.getDestino());
        return true;
    }
    
}
