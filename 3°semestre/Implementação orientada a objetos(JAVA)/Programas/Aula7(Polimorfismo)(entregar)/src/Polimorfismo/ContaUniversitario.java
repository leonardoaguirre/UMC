
package Polimorfismo;

public class ContaUniversitario extends Conta{
    private double credito=200;

    @Override
   public void imprimirExtrato(){
        System.out.println("Cliente: "+nome);
        System.out.println("Saldo: "+saldo);
        System.out.println("Credito: "+credito);
    }
    @Override
   public boolean saque(double valorSaque){
       if(valorSaque <= this.saldo){
            this.saldo-=valorSaque;
            System.out.println("\nSaque realizado com sucesso!");
            return true;
        }else{ 
            if(valorSaque<=credito+saldo){               
                    credito-=(valorSaque-saldo);
                    saldo=0;
                    System.out.println("\nSaque realizado com sucesso!");
                    return true;
                        }else{
                            System.out.println("Saque invalido!");
                            return false;
        }
            
    }
   }
}
