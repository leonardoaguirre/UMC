/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servico;

import Exceptions.StatusVendaInvalidaException;
import modelo.Venda;

/**
 *
 * @author Leonardo
 */
public class ProcessaVendaFactory {
    public static ProcessaVenda create(Venda venda) throws StatusVendaInvalidaException{
         switch (venda.getStatus()) {
                case CONFIRMADO: return new ProcessaVendaConfirmada();
                case PENDENTE: return new ProcessaVendaPendente();
                case CANCELADA: return new ProcessaVendaCancelada();
                default: throw new StatusVendaInvalidaException("Status de venda invalido!");
            }
    }
}
