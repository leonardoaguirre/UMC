
package Polimorfismo;

public class ContaCorrente extends Conta{
    private final double taxaExtrato=0.50;
           
            @Override
    public void imprimirExtrato(){
        saldo-=taxaExtrato;
                System.out.println("Cliente: "+nome);
                System.out.println("Saldo: "+saldo);
    }
}
