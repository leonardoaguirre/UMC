import java.rmi.Naming;
import java.rmi.registry.LocateRegistry;

public class Servidor {
    public static void main(String[] args) {
        try {
            //Criar o objeto que implementa o Hello
            Aluno obj = new Aluno();
            obj.setMed1(6);
            obj.setMed2(8);
            obj.setNome("Leonardo");
            obj.setRgm(111);
            //Cadastrando o objeto hello no registry
            Naming.rebind("//localhost/aluno", obj);
            System.out.println("Cadastrando o objeto no registry");
        } catch (Exception e) {
            System.out.println("erro: "+e.getMessage());
        }
    }
    
}
