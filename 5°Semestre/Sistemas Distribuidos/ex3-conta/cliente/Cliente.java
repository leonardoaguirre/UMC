import java.net.*;
import java.rmi.*;
import java.rmi.registry.*;
import java.rmi.server.*;

import servidor.IConta;

public class Cliente {
    public static void main(String[] args) {
         try {
            final IConta obj = (IConta)Naming.lookup("conta");
            System.out.println("Ola "+obj.getNometitular()+" ,O seu deposito foi: "+
            (obj.deposito(1000)? "Aprovado" : "Reprovado")+
            "\nSeu saldo atual e de: R$"+obj.getSaldo());
            //testando valor negativo no deposito
            System.out.println("Ola "+obj.getNometitular()+" ,O seu deposito foi: "+
            (obj.deposito(-50)? "Aprovado" : "Reprovado")+
            "\nSeu saldo atual e de: R$"+obj.getSaldo());
            
            System.out.println("Olas "+obj.getNometitular()+" ,O seu saque foi: "+
            (obj.saque(500)? "Aprovado" : "Reprovado")+
            "\nSeu saldo atual e de: R$"+obj.getSaldo());
            //testando saque com valor maior que o saldo
            System.out.println("Ola "+obj.getNometitular()+" ,O seu saque foi: "+
            (obj.saque(1500)? "Aprovado" : "Reprovado")+
            "\nSeu saldo atual e de: R$"+obj.getSaldo());

        } catch (final Exception e) {
            System.out.println("Erro: "+e.getMessage());
        }        
        System.exit(0);
    }
}