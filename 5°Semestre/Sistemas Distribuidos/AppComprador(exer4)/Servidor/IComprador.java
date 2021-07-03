
import java.rmi.Remote;
import java.rmi.RemoteException;

public interface IComprador extends Remote {
    public void setId(int id) throws RemoteException;
    public void setNome(String nome) throws RemoteException;
    public void setEmail(String email) throws RemoteException;
    public void setTotalCompra(double totalCompra) throws RemoteException;
    public int getId() throws RemoteException;
    public String getNome() throws RemoteException;
    public String getEmail() throws RemoteException;
    public double getTotalCompra() throws RemoteException;
    public double getPorcentagemDesconto() throws RemoteException;
    public double getTotalPagar() throws RemoteException;
    public void calcularPorcentagemDesconto() throws RemoteException;
    public void calcularTotalPagar() throws RemoteException;
}