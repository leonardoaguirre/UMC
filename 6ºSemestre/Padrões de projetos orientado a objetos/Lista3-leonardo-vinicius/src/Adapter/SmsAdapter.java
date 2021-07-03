/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Adapter;

import Modelo.Mensagem;
import SMSDispatcher.ISmsDispatcher;
import servicoSMS.ISMS;

/**
 *
 * @author Leonardo
 */
public class SmsAdapter implements ISMS{

    private ISmsDispatcher smsDispatcher;

    public ISmsDispatcher getSmsDispatcher() {
        return smsDispatcher;
    }

    public void setSmsDispatcher(ISmsDispatcher smsDispatcher) {
        this.smsDispatcher = smsDispatcher;
    }


    @Override
    public boolean enviar(Mensagem mensagem) {
        smsDispatcher.send(mensagem.getDestino(), mensagem.getOrigem(), mensagem.getTexto());
        System.out.println("Enviando mensagem com biblioteca de terceiros(externa)");
        return true;
    }
    
}
