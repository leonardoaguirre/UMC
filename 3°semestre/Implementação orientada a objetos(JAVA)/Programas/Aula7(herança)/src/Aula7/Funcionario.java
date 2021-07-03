package Aula7;


public class Funcionario {
    private String nome;
    protected double salario;

    public Funcionario(String nome, double salario){
        this.nome=nome;
        this.salario=salario;
    }
    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public double getSalario() {
        return salario;
    }

    public void setSalario(double salario) {
        this.salario = salario;
    }
    public double calcularBonificacao(){
        return salario*0.1;
    }
}
