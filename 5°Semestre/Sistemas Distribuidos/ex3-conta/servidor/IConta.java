import java.rmi.Remote;
import java.rmi.RemoteException;

public interface IConta extends Remote{
    public boolean deposito(double vd) throws RemoteException;
    public boolean saque(double vs) throws RemoteException;
    public double getSaldo() throws RemoteException;
    public String getNometitular() throws RemoteException;
}