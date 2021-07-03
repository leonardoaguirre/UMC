import java.net.*;
import java.rmi.*;
import java.rmi.registry.*;
import java.rmi.server.*;

public class Cliente{
    public static void main(final String[] args) {
        try {
            final IHello obj = (IHello)Naming.lookup("hello");
            String message = obj.sayHello();
            System.out.println("Mensagem do servidor: "+message);
            obj.mostrarMensagem();
        } catch (final Exception e) {
            System.out.println("Erro: "+e.getMessage());
        }        
        System.exit(0);
    }  
}
