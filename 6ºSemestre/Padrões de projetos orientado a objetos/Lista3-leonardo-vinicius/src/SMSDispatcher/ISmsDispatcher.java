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
public interface ISmsDispatcher {
    public void send(String target,String origin, String message);
}
