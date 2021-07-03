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
public class Funcionario extends Usuario{
    private String codIdentifacao;
    private String cargo;
    
    public Funcionario() {
    }

    public Funcionario(String codIdentifacao, String cargo, String login, String senha, String nome) {
        super(login, senha, nome);
        this.codIdentifacao = codIdentifacao;
        this.cargo = cargo;
    }

    public String getCodIdentifacao() {
        return codIdentifacao;
    }

    public void setCodIdentifacao(String codIdentifacao) {
        this.codIdentifacao = codIdentifacao;
    }

    public String getCargo() {
        return cargo;
    }

    public void setCargo(String cargo) {
        this.cargo = cargo;
    }
    
}
