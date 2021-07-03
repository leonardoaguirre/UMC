import java.rmi.Naming;
import java.rmi.registry.LocateRegistry;

public class Servidor {
    public static void main(String[] args) {
        try {
            LocateRegistry.createRegistry(1099);
            Conta obj = new Conta();
            obj.setNometitular("Leonardo");
            obj.setNumeroconta(123);

            Naming.rebind("//localhost/conta", obj);
            System.out.println("Cadastrando o objeto no registry");
        } catch (Exception e) {
            System.out.println("erro: "+e.getMessage());
        }
    }
}