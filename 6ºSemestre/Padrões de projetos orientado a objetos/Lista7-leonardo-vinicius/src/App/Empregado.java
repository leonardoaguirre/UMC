/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package App;

/**
 *
 * @author Leonardo
 */
public abstract class Empregado {

    private String nome;

    public Empregado(String nome) {
        this.nome = nome;
    }

    public abstract double calcularSalarioBruto();

    public abstract double calcularBonus();

    public double calcularSalarioLiquido() {
        return calcularSalarioBruto() + calcularBonus() - calcularINSS();
    }

    public double calcularINSS() {
        return (calcularSalarioBruto() * 11) / 100;
    }

    public void imprimirFolha() {
        if (calcularSalarioBruto() <= 0) {
            System.out.println("--------------------------------------------");
            System.out.println("Horas invalidas ou cargo inexistente");
        } else {
            System.out.println("--------------------------------------------");
            System.out.println("Empregado: "+this.nome);
            System.out.println("Salario Bruto: " + calcularSalarioBruto());
            System.out.println("Salario Liquido: " + calcularSalarioLiquido());
            System.out.println("INSS: " + calcularINSS());
            System.out.println("Bonus: " + calcularBonus());
        }

    }
}
