
package Polimorfismo;

public class ContaUniversitario extends Conta{
    private double credito=200;

    @Override
   public void imprimirExtrato(){
        System.out.println("Saldo: "+saldo);
        System.out.println("Credito: "+credito);
    }
    @Override
   public boolean saque(double valorSaque){
       if(valorSaque <= this.saldo){
            this.saldo=saldo-valorSaque;
            return true;
        }else{ 
            if(valorSaque<credito){               
                    credito-=(valorSaque-saldo);
                    saldo=0;
                    return true;
                        }else{
                            System.out.println("Saque invalido!");
                            return false;
        }
            
    }
   }
}
