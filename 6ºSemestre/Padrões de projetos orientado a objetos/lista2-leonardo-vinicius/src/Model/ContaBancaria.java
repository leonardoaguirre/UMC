/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Model;

import Servico.ITitular;

/**
 *
 * @author Leonardo
 */
public class ContaBancaria {

    private int numero;
    private int agencia;
    private double saldo;
    private ITitular titular;

    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    public int getAgencia() {
        return agencia;
    }

    public void setAgencia(int agencia) {
        this.agencia = agencia;
    }

    public double getSaldo() {
        return saldo;
    }

    public void setSaldo(double saldo) {
        this.saldo = saldo;
    }

    public ITitular getTitular() {
        return titular;
    }

    public void setTitular(ITitular titular) {
        this.titular = titular;
    }

    public void sacar(double valor) {
        this.titular.sacar(this, valor);

    }
}
