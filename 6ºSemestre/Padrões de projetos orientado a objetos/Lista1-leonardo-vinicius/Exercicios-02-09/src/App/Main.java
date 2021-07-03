/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package App;

import Exceptions.PagamentoInvalidoException;
import Modelo.Compra;
import servico.PagamentoBoleto;
import servico.PagamentoCartao;

/**
 *
 * @author Leonardo
 */
public class Main {

    public static void main(String[] args) throws PagamentoInvalidoException {

        Compra compra = new Compra(new PagamentoBoleto());
        compra.setData(01012020);
        compra.setValor(200);
        compra.setTipoPagamento(new PagamentoBoleto());
        compra.realizarPagamento();

        compra = new Compra(new PagamentoCartao());
        compra.setData(02022020);
        compra.setValor(1000);
        compra.setTipoPagamento(new PagamentoCartao());
        compra.realizarPagamento();

    }
}
