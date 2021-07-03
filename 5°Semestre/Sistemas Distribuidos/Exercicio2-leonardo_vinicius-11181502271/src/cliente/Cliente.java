import java.net.*;
import java.rmi.*;
import java.rmi.registry.*;
import java.rmi.server.*;

public class Cliente {
    public static void main(String[] args) {
         try {
            final IAluno obj = (IAluno)Naming.lookup("aluno");
            System.out.println("A Media Final do aluno(a) foi: "+obj.calcularMedia());
            System.out.println("O(a) aluno(a) foi: "+obj.aprovado());
        } catch (final Exception e) {
            System.out.println("Erro: "+e.getMessage());
        }        
        System.exit(0);
    }
}
