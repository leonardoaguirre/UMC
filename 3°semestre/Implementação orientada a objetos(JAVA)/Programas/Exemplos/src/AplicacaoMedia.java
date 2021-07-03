
import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author alunocmc
 */
public class AplicacaoMedia {
    public static void main(String[]args){
        Aluno al = new Aluno();
        Scanner teclado= new Scanner(System.in);
        
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
        if(al.verificarSituacao()==true){
        System.out.println("O Aluno foi aprovado!");
        }else{
            System.out.println("O aluno foi reprovado!");
        }
    }
}
