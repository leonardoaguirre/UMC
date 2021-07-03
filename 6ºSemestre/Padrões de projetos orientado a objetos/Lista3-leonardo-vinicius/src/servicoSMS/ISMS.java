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
public interface ISMS {
    public boolean enviar(Mensagem mensagem);
}
