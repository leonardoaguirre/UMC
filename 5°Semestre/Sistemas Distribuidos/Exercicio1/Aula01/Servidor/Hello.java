import java.rmi.*;
import java.net.*;
import java.rmi.registry.*;
import java.rmi.server.*;

public class Hello extends UnicastRemoteObject implements IHello{
    public Hello() throws RemoteException{}
    public String sayHello(){
        return "Alo mundo";
    }
    public void mostrarMensagem(){
        System.out.println("O mundo gira...");
    }
}