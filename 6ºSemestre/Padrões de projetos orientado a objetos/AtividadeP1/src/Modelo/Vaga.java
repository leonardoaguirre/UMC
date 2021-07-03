/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

/**
 *
 * @author Leonardo
 */
public class Vaga {
    private String cargo;
    private double salario;
    private Empresa empresa;

    public Vaga() {
    }

    public Vaga(String cargo, double salario, Empresa empresa) {
        this.cargo = cargo;
        this.salario = salario;
        this.empresa = empresa;
    }

    public String getCargo() {
        return cargo;
    }

    public void setCargo(String cargo) {
        this.cargo = cargo;
    }

    public double getSalario() {
        return salario;
    }

    public void setSalario(double salario) {
        this.salario = salario;
    }

    public Empresa getEmpresa() {
        return empresa;
    }

    public void setEmpresa(Empresa empresa) {
        this.empresa = empresa;
    }

    @Override
    public String toString() {
        return "Vaga{" + "cargo=" + cargo + ", salario=" + salario + ", CNPJ empresa=" + empresa.getCnpj()+ '}';
    }
    
}
