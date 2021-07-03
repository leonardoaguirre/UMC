package Polimorfismo;

import java.util.Scanner;


public class AppBanco {
    public static void main(String[] args) {
			
        /*	 Conta c = new ContaCorrente();
	 	 c.setNome("glauco");
	 	 c.setSaldo(50);
			
	 	 if (c.saque(60)) {
			 System.out.println("\nSaque realizado com sucesso!");
	 	 } else {
			 System.out.println("\nNão foi possível realizar saque");
                                     }
                 System.out.println(c.getNome());
	 	 c.imprimirExtrato();

                 Conta c2 = new ContaUniversitario();
	 	 c2.setNome("leo");
	 	 c2.setSaldo(50);
			
	 	 if (c2.saque(60)) {
			 System.out.println("");
	 	 } else {
			 System.out.println("");
	 	 }
                  System.out.println(c2.getNome());
	 c2.imprimirExtrato();*/
        
                 Scanner ler = new Scanner(System.in);
                 Conta c3 = new ContaCorrente();
                 Conta c4 = new ContaUniversitario();
                 
                 System.out.println("Qual é o seu tipo de conta? 1-Corrente 2-Universitario");
                 int tipoConta = ler.nextInt();
                 while(tipoConta!=1 && tipoConta!=2){
                     System.out.println("Opção incorreta digite novamente!\nQual é o seu tipo de conta? 1-Corrente 2-Universitario");
                      tipoConta = ler.nextInt();
                 }
                 if(tipoConta==1){
                 System.out.println("Digite o seu nome: ");
                 c3.setNome(ler.next());
                 ler.nextLine();
                 System.out.println("Digite o seu saldo: ");
                 double s = ler.nextDouble();
                 while(s<=0){
                     System.out.println("Saldo invalido!\nDigite o seu saldo:");
                     s = ler.nextDouble();
                 }
                 c3.setSaldo(s);
                 ler.nextLine();
                 }else{
                     System.out.println("Digite o seu nome: ");
                 c4.setNome(ler.next());
                 ler.nextLine();
                 System.out.println("Digite o seu saldo: ");
                 double s = ler.nextDouble();
                 while(s<=0){
                     System.out.println("Saldo invalido!\nDigite o seu saldo:");
                     s = ler.nextDouble();
                 }
                 c4.setSaldo(s);
                 ler.nextLine();
                 }
                 int op;
                 do{
                 System.out.println("\nMENU\n1-Realizar saques\n2-Imprimir extrato\n3-Sair");
                 op = ler.nextInt();
                 while(op!=1 && op!=2 && op!=3){
                     System.out.println("Operação incorreta!\nMENU\n1-Realizar saques\n2-Imprimir extrato\n3-Sair");
                     op=ler.nextInt();
                 }
                 switch(op){
                 case 1: 
                     System.out.println("Digite o quanto deseja sacar: ");
                     if(tipoConta==1){
                     c3.saque(ler.nextDouble());
                 }else{
                     c4.saque(ler.nextDouble());
                 }
                     break; 
                     
                 case 2: 
                         if (tipoConta==1) {
                             c3.imprimirExtrato();
                         } else {
                             c4.imprimirExtrato();
                         }
                         break;
                         
                     case 3: System.out.println("\nObrigado por usar nosso sistema,até logo! :)");break;
                 }
                 
                 }while(op!=3);
    }
}
