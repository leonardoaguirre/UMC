/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

import servico.IPagamento;

/**
 *
 * @author Leonardo
 */
public class Compra {
    private int data;
    private int valor;
    private IPagamento tipoPagamento;

    public Compra(IPagamento tipoPagamento) {
        this.tipoPagamento = tipoPagamento;
    }

    public IPagamento getTipoPagamento() {
        return tipoPagamento;
    }

    public void setTipoPagamento(IPagamento tipoPagamento) {
        this.tipoPagamento = tipoPagamento;
    }

    public void setData(int data) {
        this.data = data;
    }

    public void setValor(int valor) {
        this.valor = valor;
    }

    public int getData() {
        return data;
    }

    public int getValor() {
        return valor;
    }
    @Override
    public String toString() {
        return "Compra{" + "data=" + data + ", valor=" + valor + ", tipoPagamento=" + tipoPagamento + '}';
    }
    
    public void realizarPagamento(){
        this.tipoPagamento.pagar(this.valor);
    }
}
