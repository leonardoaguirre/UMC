import java.rmi.Naming;
import java.rmi.registry.LocateRegistry;

public class Servidor {
    public static void main(String[] args) {
        try {
            LocateRegistry.createRegistry(1099);
            
            Comprador comprador1 = new Comprador();
            Naming.rebind("//localhost/comprador1", comprador1);
            System.out.println("Cadastrando o objetos no registry");


        } catch (Exception e) {
            System.out.println("erro: "+e.getMessage());
        }
    }
}