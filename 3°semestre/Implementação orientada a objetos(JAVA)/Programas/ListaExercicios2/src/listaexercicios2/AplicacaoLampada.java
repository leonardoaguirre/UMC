/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package listaexercicios2;

/**
 *
 * @author Leonardo
 */
public class AplicacaoLampada {
     public static void main(String[] args) {
         Lampada lamp1 = new Lampada();
         Lampada lamp2 = new Lampada();
         
         lamp1.ligar();
         lamp2.desligar();
         
         lamp1.observar();
         lamp2.observar();
     }
}
