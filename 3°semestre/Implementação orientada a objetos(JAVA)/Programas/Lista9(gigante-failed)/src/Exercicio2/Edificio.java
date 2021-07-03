/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Exercicio2;

/**
 *
 * @author Leonardo
 */
public class Edificio {
    private String nome;
    private int areaComum;
    private Endereco[] endereco;
    private Apartamento[] apartamento;

    public Endereco[] getEndereco() {
        return endereco;
    }

    public void setEndereco(Endereco[] endereco) {
        this.endereco = endereco;
    }

    public Apartamento[] getApartamento() {
        return apartamento;
    }

    public void setApartamento(Apartamento[] apartamento) {
        this.apartamento = apartamento;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public int getAreaComum() {
        return areaComum;
    }

    public void setAreaComum(int areaComum) {
        this.areaComum = areaComum;
    }
}
