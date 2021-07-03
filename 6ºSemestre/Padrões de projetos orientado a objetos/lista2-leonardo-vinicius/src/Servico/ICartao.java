/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servico;

import Model.ContaBancaria;

/**
 *
 * @author Leonardo
 */
public interface ICartao {
    public ICartao usar(ContaBancaria conta,double valor);
}
