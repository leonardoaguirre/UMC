import java.net.*;
import java.rmi.*;

public interface IHello extends Remote{
    public String sayHello() throws RemoteException;
    public void mostrarMensagem() throws RemoteException;
}