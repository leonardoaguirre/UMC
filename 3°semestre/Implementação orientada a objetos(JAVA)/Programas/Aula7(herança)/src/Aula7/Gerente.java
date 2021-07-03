/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Aula7;

/**
 *
 * @author alunocmc
 */
public class Gerente extends Funcionario {
    private String setor;
    
    public Gerente(String nome, double salario,String setor){
        super(nome,salario);//executa o construtor da superclasse
        this.setor=setor;
    }
    

    public String getSetor() {
        return setor;
    }

    public void setSetor(String setor) {
        this.setor = setor;
    }
   @Override
    public double calcularBonificacao(){
        return salario*0.2;
    }
}
