/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

/**
 *
 * @author Leonardo
 */
public class Candidato extends Usuario{
    private int id;
    private String rg;
    private String cpf;
    private int idade;

    public Candidato() {
    }

    public Candidato(int id, String rg, String cpf, int idade, String login, String senha,String nome) {
        super(login,senha,nome);
        this.id = id;
        this.rg = rg;
        this.cpf = cpf;
        this.idade = idade;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getRg() {
        return rg;
    }

    public void setRg(String rg) {
        this.rg = rg;
    }

    public String getCpf() {
        return cpf;
    }

    public void setCpf(String cpf) {
        this.cpf = cpf;
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }

    @Override
    public String toString() {
        return "Candidato{" + "id=" + id + " nome="+ super.getNome()+", rg=" + rg + ", cpf=" + cpf + ", idade=" + idade + '}';
    }
    
}
