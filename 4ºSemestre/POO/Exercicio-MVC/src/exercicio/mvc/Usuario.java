/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exercicio.mvc;

/**
 *
 * @author alunocmc
 */
public class Usuario {
    private String login;
    private String senha;

    public String getLogin() {
        return login;
    }

    public void setLogin(String login) {
        this.login = login;
    }

    public String getSenha() {
        return senha;
    }

    public void setSenha(String senha) {
        this.senha = senha;
    }
    public boolean valida(){
        if(this.getLogin().equals("a") && this.getSenha().equals("a")){
           return true;
        }
        else{
                return false;
         }
    }
}
