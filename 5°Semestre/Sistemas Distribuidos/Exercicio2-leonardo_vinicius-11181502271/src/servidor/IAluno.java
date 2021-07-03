import java.rmi.Remote;
import java.rmi.RemoteException;


public interface IAluno extends Remote{
    public double calcularMedia() throws RemoteException;
    public String aprovado() throws RemoteException;
}
