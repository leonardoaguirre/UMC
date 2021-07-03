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
public class Lampada {
    private boolean ligada;
    
    public void ligar(){
    ligada=true;
    }
    public void desligar(){
    ligada=false;
    }
    public void observar(){
    if(ligada == true){
        System.out.println("A lampada está ligada!");
    }else{
        System.out.println("A lampada está desligada!");
    }
    }
}
