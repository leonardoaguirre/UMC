import java.net.*;
import java.rmi.*;
import java.rmi.registry.*;
import java.rmi.server.*;

public class Servidor{
    public static void main(String[] args) {
        try {
            //Criar o objeto que implementa o Hello
            Hello obj = new Hello();
            //Cadastrando o objeto hello no registry
            Naming.rebind("//localhost/hello", obj);
            System.out.println("Cadastrando o objeto no registry");
        } catch (Exception e) {
            System.out.println("erro: "+e.getMessage());
        }
    }
}