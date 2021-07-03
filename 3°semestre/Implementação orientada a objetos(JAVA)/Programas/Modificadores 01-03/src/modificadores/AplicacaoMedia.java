/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modificadores;
import java.util.Scanner;
/**
 *
 * @author alunocmc
 */
public class AplicacaoMedia {
    public static void main(String[] args){
        Scanner teclado = new Scanner(System.in);    
        Aluno al = new Aluno();
//        al.setNome("Leo");
//        al.setRgm(123);
//        al.setNota1(8);
//        al.setNota2(7);


        System.out.println("Digite o nome: ");
        al.setNome(teclado.next());
        System.out.println("Digite o rgm: ");
        al.setRgm(teclado.nextInt());
        System.out.println("Digite a nota 1: ");
        al.setNota1(teclado.nextDouble());
        System.out.println("Digite a nota 2: ");
        al.setNota2(teclado.nextDouble());
        al.calcularMedia();
        String Notaf;
        Notaf = String.format("%.2f", al.getNotaFinal());
        System.out.println("Media final do aluno(a) "+al.getNome()+" foi: "+ Notaf);
        
    }
}
