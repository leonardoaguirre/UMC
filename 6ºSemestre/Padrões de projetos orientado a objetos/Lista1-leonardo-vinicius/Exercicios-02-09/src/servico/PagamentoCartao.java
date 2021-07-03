/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servico;

import Modelo.Compra;

/**
 *
 * @author Leonardo
 */
public class PagamentoCartao implements IPagamento{
    private long numeroCartao;
    private int codigo;
    @Override
    public void pagar(double Valor) {
        System.out.println("Pagando com cartão de crédito");
    }
    
}
