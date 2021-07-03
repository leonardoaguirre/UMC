import java.rmi.*;
import java.net.*;
import java.rmi.registry.*;
import java.rmi.server.*;

public class Conta extends UnicastRemoteObject implements IConta{

    private int numeroconta;
    private String nometitular;
    private double saldo;

    public int getNumeroconta() {
        return numeroconta;
    }

    public void setNumeroconta(int numeroconta) {
        this.numeroconta = numeroconta;
    }

    public String getNometitular() throws RemoteException {
        return nometitular;
    }

    public void setNometitular(String nometitular) {
        this.nometitular = nometitular;
    }

    public double getSaldo() throws RemoteException{
        return saldo;
    }

    public Conta() throws RemoteException{}

    @Override
    public boolean deposito(double vd) throws RemoteException{
        if (vd>0) {
            this.saldo=this.saldo+vd;
            return true;
        }else{
            return false;
        }
    }

    @Override
    public boolean saque(double vs) throws RemoteException{
        if (this.saldo-vs>=0) {
            this.saldo=this.saldo-vs;
            return true;
        } else {
            return false;
        }
    }
    
}