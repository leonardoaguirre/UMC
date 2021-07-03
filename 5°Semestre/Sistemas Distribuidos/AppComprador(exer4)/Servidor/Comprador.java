
import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;

public class Comprador extends UnicastRemoteObject implements IComprador {

    private int id;
    private String nome;
    private String email;
    private double totalCompra;
    private double porcentagemDesconto;
    private double totalPagar;

    protected Comprador() throws RemoteException {
        super();
    }

    @Override
    public void setId(int id) throws RemoteException {
        this.id=id;
    }

    @Override
    public void setNome(String nome) throws RemoteException {
        this.nome=nome;
    }

    @Override
    public void setEmail(String email) throws RemoteException {
        this.email=email;
    }

    @Override
    public void setTotalCompra(double totalCompra) throws RemoteException {
        this.totalCompra=totalCompra;
    }

    @Override
    public int getId() throws RemoteException {
        return this.id;
    }

    @Override
    public String getNome() throws RemoteException {
        return this.nome;
    }

    @Override
    public String getEmail() throws RemoteException {
        return this.email;
    }

    @Override
    public double getTotalCompra() throws RemoteException {
        return this.totalCompra;
    }

    @Override
    public double getPorcentagemDesconto() throws RemoteException {
        return this.porcentagemDesconto;
    }

    @Override
    public double getTotalPagar() throws RemoteException {
        return this.totalPagar;
    }

    @Override
    public void calcularPorcentagemDesconto() throws RemoteException {
        if(this.totalCompra>0 && this.totalCompra<1000){
            this.porcentagemDesconto = 10;
        }else if(this.totalCompra<5000){
            this.porcentagemDesconto=15;
        }else{
            this.porcentagemDesconto=20;
        }
    }

    @Override
    public void calcularTotalPagar() throws RemoteException {
        this.totalPagar = this.totalCompra*((100-this.porcentagemDesconto)/100);
    }

}