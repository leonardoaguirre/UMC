/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modificadores;

/**
 *
 * @author alunocmc
 */
public class Aluno {
    private int rgm;
    private String nome;
    private double nota1;
    private double nota2;
    private double notaFinal;

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public double getNota1() {
        return nota1;
    }

    public void setNota1(double nota1) {
        this.nota1 = nota1;
    }

    public double getNota2() {
        return nota2;
    }

    public void setNota2(double nota2) {
        this.nota2 = nota2;
    }

    public double getNotaFinal() {
        return notaFinal;
    }
    
    public void  setRgm(int rgm){
        this.rgm=rgm;
    }
    public int getRgm(){
        return rgm;
    }
    public void calcularMedia(){
        notaFinal = (nota1 + 2*nota2)/3;
    }
    
}
