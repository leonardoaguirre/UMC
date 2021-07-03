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
public class TitularPrincipal implements ITitular{
    private String nome;
    private String cpf;
    private ICartao cartao;
    public final double limite = 1000.0;

    public TitularPrincipal(ICartao cartao,String nome, String cpf) {
        this.cartao = cartao;
        this.nome=nome;
        this.cpf=cpf;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getCpf() {
        return cpf;
    }

    public void setCpf(String cpf) {
        this.cpf = cpf;
    }

    public ICartao getCartao() {
        return cartao;
    }

    public void setCartao(ICartao cartao) {
        this.cartao = cartao;
    }
    @Override
    public String toString() {
        return "Olá "+ nome + ", portador do cpf=" + cpf + '}';
    }
    @Override
    public void sacar(ContaBancaria conta,double valor) {
        System.out.println("Saque de titular principal....");
        if (valor > conta.getSaldo()) {
            System.out.println("O valor a ser sacado é maior que o saldo atual.");
        } else {
            if(valor>this.limite){
                System.out.println("O valor a ser sacado é maior que o limite permitido.");
            }else{
                this.cartao.usar(conta,valor);
            }
        }
    }
}
