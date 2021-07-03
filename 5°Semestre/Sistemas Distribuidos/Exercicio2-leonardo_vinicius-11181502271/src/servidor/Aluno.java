import java.rmi.*;
import java.net.*;
import java.rmi.registry.*;
import java.rmi.server.*;


public class Aluno extends UnicastRemoteObject implements IAluno{
    
    private int rgm;
    private String nome;
    private double med1;
    private double med2;
    private double medf;

    public int getRgm() {
        return rgm;
    }

    public void setRgm(final int rgm) {
        this.rgm = rgm;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(final String nome) {
        this.nome = nome;
    }

    public double getMed1() {
        return med1;
    }

    public void setMed1(final double med1) {
        this.med1 = med1;
    }

    public double getMed2() {
        return med2;
    }

    public void setMed2(final double med2) {
        this.med2 = med2;
    }

    public double getMedf() {
        return medf;
    }

    public void setMedf(final double medf) {
        this.medf = medf;
    }
    public Aluno() throws RemoteException{
    }

    public double calcularMedia() throws RemoteException {
        return this.medf = (this.med1+this.med2)/2;
    }


    public String aprovado() throws RemoteException {
        if (calcularMedia()>5) {
            return "Aprovado(a)";
        } else {
            return "Reprovado(a)";
        }
    }
}
