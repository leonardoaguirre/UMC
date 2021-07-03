/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package App;

/**
 *
 * @author Leonardo
 */
public class App {
    public static void main(String[] args) {
        Empregado horista = new Horista("Leonardo",50);
        horista.imprimirFolha();
        
        Empregado mensalista = new Mensalista("Carlos","Senior");
        mensalista.imprimirFolha();
    }
}
