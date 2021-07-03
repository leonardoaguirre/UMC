
package Aparelho;

public class BlueRayPlayer extends AparelhoEletronico {
     @Override
     public void ligar(){
        System.out.println("BlueRayPlayer ligado!");
    }
     @Override
    public void desligar(){
        System.out.println("BlueRayPlayer desligado!");
    }
}
