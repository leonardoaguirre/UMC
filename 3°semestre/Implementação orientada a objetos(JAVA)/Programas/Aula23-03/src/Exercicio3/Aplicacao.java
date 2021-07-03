/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Exercicio3;

/**
 *
 * @author alunocmc
 */
public class Aplicacao {
    public static void main(String[] args) {
        
        Carro meuCarro;
        meuCarro=new Carro("ABC=123");
        
        System.out.println("A placa do carro é "+meuCarro.getPlaca());
    }
}
