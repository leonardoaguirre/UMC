/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package App;

import Adapter.SmsAdapter;
import Modelo.Mensagem;
import SMSDispatcher.SmsDispatcherConcret;
import servicoSMS.EnviadorSMS;
import servicoSMS.ISMS;

/**
 *
 * @author Leonardo
 */
public class Main {
    public static void main(String[] args) {
        
        SmsAdapter sms = new SmsAdapter();
        ISMS smsnormal= new EnviadorSMS();
        Mensagem mensagem = new Mensagem();
        
        mensagem.setDestino("Destinatario");
        mensagem.setOrigem("Rementente");
        mensagem.setTexto("Ola mundo!");
        sms.setSmsDispatcher(new SmsDispatcherConcret());
        
        smsnormal.enviar(mensagem);
        System.out.println("------------------------------------------------");
        sms.enviar(mensagem);
        
    }
}
