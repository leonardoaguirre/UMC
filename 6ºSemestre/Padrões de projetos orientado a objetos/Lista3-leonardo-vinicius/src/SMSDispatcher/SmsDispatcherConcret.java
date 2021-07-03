/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package SMSDispatcher;

/**
 *
 * @author Leonardo
 */
public class SmsDispatcherConcret implements ISmsDispatcher{

    @Override
    public void send(String target, String origin, String message) {
        System.out.println("Sending message with stranger class");
        System.out.println("Message: "+message+" |To: "+target+" |Origin: "+origin);
    }
    
}
