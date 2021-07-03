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
public class CartaoCredito implements ICartao {

    private int numero;
    private int cvv;
    private int validade;

    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    public int getCvv() {
        return cvv;
    }

    public void setCvv(int cvv) {
        this.cvv = cvv;
    }

    public int getValidade() {
        return validade;
    }

    public void setValidade(int validade) {
        this.validade = validade;
    }

    public CartaoCredito(int numero, int cvv, int validade) {
        this.numero = numero;
        this.cvv = cvv;
        this.validade = validade;
    }

    @Override
    public ICartao usar(ContaBancaria conta, double valor) {
        System.out.println("Usando cartão de crédito!");
        System.out.println(conta.getTitular().toString());
        
        System.out.println("Sua fatura de crédito atual é de: R$" + valor);
        return this;
    }
}
