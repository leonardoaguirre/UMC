
package Exercicio2;
import java.util.Scanner;

public class Aplicacao {
    public static void main(String[] args) {
      Scanner ler = new Scanner(System.in);
      
      int nEdi=0, nAp=0;
      
      while(nEdi<1){
        System.out.println("Com quantos edificios você trabalha? ");
        nEdi =ler.nextInt();
      }
      
      Edificio[] edi = new Edificio[nEdi];
      Endereco[] end = new Endereco[nEdi];
      
        for (int i = 0; i < nEdi; i++) {
            String s; int n2;
             System.out.println("Qual é o nome do "+(i+1)+"º edificio?");
             s=ler.next();
             edi[1].setNome(s);
             System.out.println("Quanto o "+(i+1)+"º edificio possui de area comum?");
             edi[i].setAreaComum(ler.nextInt());
             
             System.out.println("Qual é a rua de endereço do "+(i+1)+"º edificio?");
             end[i].setRua(ler.next());
             System.out.println("Qual é o numero do endereço do "+(i+1)+"º edificio?");
             end[i].setNumero(ler.nextInt());
             System.out.println("Qual é o bairro de endereço do "+(i+1)+"º edificio?");
             end[i].setBairro(ler.next());
             System.out.println("Qual é a cidade de endereço do "+(i+1)+"º edificio?");
             end[i].setCidade(ler.next());
             
             edi[i].setEndereco(end);
             
             while(nAp<1){
             System.out.println("Quantos apartamentos possui o "+(i+1)+"º edificio?");
             nAp =ler.nextInt();
             }
              Apartamento[] ap = new Apartamento[nAp];
              
             for (int j = 0; j < nAp; j++) {
                 System.out.println("Qual é o numero do "+(j+1)+"º apartamento?");
                 ap[j].setNumero(ler.nextInt());
                 System.out.println("Qual é a area construida do "+(j+1)+"º apartamento?");
                 ap[j].setAreaConstruida(ler.nextInt());
                 System.out.println("Quantos quartos possui o "+(j+1)+"º apartamento?");
                 ap[j].setQuartos(ler.nextInt());
                 
                 int n=0;
                 while(n!=1 && n!=2){
                     
                 System.out.println("O apartamento numero "+ap[j].getNumero()+" esta a venda? 1-Sim 2-Nao");
                 n = ler.nextInt();
                 if(n==1){ ap[j].setVenda(true);}else{ ap[j].setVenda(false);}
                 }
            edi[i].setApartamento(ap);

            }
        }
         Aplicacao.imprime(edi);
    }
    public static void imprime(Edificio[] edi){
        for (int i = 0; i < edi.length; i++) {
            
            System.out.println("Edificio: "+edi[i].getNome()+", com área comum de: "+edi[i].getAreaComum());
        System.out.println("Localizado em: "+edi[i].getEndereco()[i].getRua()+","+edi[i].getEndereco()[i].getNumero()+","+edi[i].getEndereco()[i].getBairro()+","+edi[i].getEndereco()[i].getCidade());
        
        Apartamento[] ap = edi[i].getApartamento();
        
            for (int j = 0; j < ap.length; j++) {
                
                System.out.println("Apartamento nº"+ap[j].getNumero()+",com "+ap[j].getQuartos()+" quartos e "+(ap[j].isVenda()?"está a venda":"não está a venda"));
            }
        }
    }
}
