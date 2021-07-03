/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Exceptions;

/**
 *
 * @author Leonardo
 */
public class PagamentoInvalidoException extends Exception{
    public PagamentoInvalidoException(String message) {
        super(message);
    }
}
