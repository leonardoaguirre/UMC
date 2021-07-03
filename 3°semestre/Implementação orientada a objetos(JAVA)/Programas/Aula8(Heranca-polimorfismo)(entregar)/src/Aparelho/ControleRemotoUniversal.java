
package Aparelho;


public class ControleRemotoUniversal extends AparelhoEletronico{
    public static void main(String[] args) {
        AparelhoEletronico[] ap = new AparelhoEletronico[3];

        AparelhoEletronico ap1= new Televisao();
        AparelhoEletronico ap2= new DvdPlayer();
        AparelhoEletronico ap3= new BlueRayPlayer();
        
        ap[0]=ap1;
        ap[1]=ap2;
        ap[2]=ap3;
        for (int i = 0; i <3; i++) {
            ligar(ap[i]);
        }
    }
     public static void ligar(AparelhoEletronico ae){
        System.out.println(ae+" ligado!");
    }
    public static void desligar(AparelhoEletronico ae){
        System.out.println(ae+" desligado!");
    }
}
