/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Exercicio;

/**
 *
 * @author alunocmc
 */
public class Aplicacao {
    public static void main(String[]args){
        ClasseExemplo objTeste = new ClasseExemplo();
        
        double valor = objTeste.metodoA();
        
        int numero= objTeste.metodoB();
        
        System.out.println("O resto da divisão por 2 é "+objTeste.metodoC(numero));
        
        if(objTeste.metodoD(numero)){
            System.out.println("O numero é par");
        }else{
            System.out.println("O numero é impar");
        }
    }
}
