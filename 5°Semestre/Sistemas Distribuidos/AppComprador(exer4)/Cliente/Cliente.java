import java.net.*;
import java.rmi.*;
import java.rmi.registry.*;
import java.rmi.server.*;


public class Cliente {
    public static void main(String[] args) {
         try {
            final IComprador comprador1 = (IComprador)Naming.lookup("comprador1");

            comprador1.setId(2020);
            comprador1.setNome("Maria");
            comprador1.setEmail("m1@teste.br");
            comprador1.setTotalCompra(800);
            comprador1.calcularPorcentagemDesconto();
            comprador1.calcularTotalPagar();
            System.out.println("\nComprador 1...............................................................");
            System.out.println("\nId: "+comprador1.getId());
            System.out.println("\nNome: "+comprador1.getNome());
            System.out.println("\nEmail: "+comprador1.getEmail());
            System.out.println("\nTotal da compra: "+comprador1.getTotalCompra());
            System.out.println("\nPorcentagem de desconto: "+comprador1.getPorcentagemDesconto());
            System.out.println("\nTotal a pagar: "+comprador1.getTotalPagar());

            comprador1.setId(1003);
            comprador1.setNome("Mara");
            comprador1.setEmail("m2@teste.br");
            comprador1.setTotalCompra(2000);
            comprador1.calcularPorcentagemDesconto();
            comprador1.calcularTotalPagar();
            System.out.println("\nComprador 2...............................................................");
            System.out.println("\nId: "+comprador1.getId());
            System.out.println("\nNome: "+comprador1.getNome());
            System.out.println("\nEmail: "+comprador1.getEmail());
            System.out.println("\nTotal da compra: "+comprador1.getTotalCompra());
            System.out.println("\nPorcentagem de desconto: "+comprador1.getPorcentagemDesconto());
            System.out.println("\nTotal a pagar: "+comprador1.getTotalPagar());
            
            comprador1.setId(3465);
            comprador1.setNome("Maria");
            comprador1.setEmail("m3@teste.br");
            comprador1.setTotalCompra(7000);
            comprador1.calcularPorcentagemDesconto();
            comprador1.calcularTotalPagar();
           System.out.println("\nComprador 3...............................................................");
            System.out.println("\nId: "+comprador1.getId());
            System.out.println("\nNome: "+comprador1.getNome());
            System.out.println("\nEmail: "+comprador1.getEmail());
            System.out.println("\nTotal da compra: "+comprador1.getTotalCompra());
            System.out.println("\nPorcentagem de desconto: "+comprador1.getPorcentagemDesconto());
            System.out.println("\nTotal a pagar: "+comprador1.getTotalPagar());

        } catch (final Exception e) {
            System.out.println("Erro: "+e.getMessage());
        }        
        System.exit(0);
    }
}