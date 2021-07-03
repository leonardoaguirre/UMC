
package Aparelho;

public class DvdPlayer extends AparelhoEletronico {
     @Override
     public void ligar(){
        System.out.println("DVDPlayer ligado!");
    }
     @Override
    public void desligar(){
        System.out.println("DVDPlayer desligado!");
    }
}
