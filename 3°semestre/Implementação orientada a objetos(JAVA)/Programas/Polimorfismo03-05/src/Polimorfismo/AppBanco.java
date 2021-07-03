
package Polimorfismo;


public class AppBanco {
    public static void main(String[] args) {
			
	 	 /*Conta c = new ContaCorrente();
	 	 c.setNome("glauco");
	 	 c.setSaldo(50);
	 	 c.imprimirExtrato();
			
	 	 if (c.saque(60)) {
			 System.out.println("Saque realizado com sucesso!");
	 	 } else {
			 System.out.println("Não foi possível realizar saque");
                 }
                 System.out.println(c.getNome());
	 	 c.imprimirExtrato();*/
                 
                 Conta c2 = new ContaUniversitario();
	 	 c2.setNome("leo");
	 	 c2.setSaldo(50);
	 	 //c2.imprimirExtrato();
			
	 	 if (c2.saque(60)) {
			 System.out.println("Saque realizado com sucesso!");
	 	 } else {
			 System.out.println("Não foi possível realizar saque");
	 	 }
	
                 System.out.println(c2.getNome());
	 	 c2.imprimirExtrato();
                 
    }
}
