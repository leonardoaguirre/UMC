
package Polimorfismo;

public class Conta {
    protected String nome;
    protected double saldo;

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public void setSaldo(double saldo) {
        this.saldo = saldo;
    }
    public void imprimirExtrato(){
        System.out.println("Saldo: "+saldo);
    }
    public boolean saque(double valorSaque){
        if(valorSaque < this.saldo){
            this.saldo=saldo-valorSaque;
            return true;
        }else{
            System.out.println("Saque invalido!");
            return false;
        }
        
    }
}
