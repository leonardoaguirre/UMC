/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

import java.util.Date;
import Servico.IManter;

/**
 *
 * @author Leonardo
 */
public class Cliente implements IManter{
    private String nome;
    private String cpf;
    private String rg;
    private Date dataNascimento;

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

    public String getRg() {
        return rg;
    }

    public void setRg(String rg) {
        this.rg = rg;
    }

    public Date getDataNascimento() {
        return dataNascimento;
    }

    public void setDataNascimento(Date dataNascimento) {
        this.dataNascimento = dataNascimento;
    }

    @Override
    public void cadastrar(Cliente cliente) {
        
    }

    @Override
    public void atualizar(Cliente cliente) {
        
    }

    @Override
    public void consultar(Cliente cliente) {
        
    }

    @Override
    public void excluir(Cliente cliente) {
        
    }
    public boolean validarCpf(){
        return true;
    }
    public int calcularIdade(){
        return 0;
    }
    public boolean enviarEmail(){
        return true;
    }
}
