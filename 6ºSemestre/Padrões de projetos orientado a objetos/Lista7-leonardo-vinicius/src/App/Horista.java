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
public class Horista extends Empregado{
    private final int horas;

    public Horista(String nome,int horas) {
        super(nome);
        this.horas = horas;
    }

    @Override
    public double calcularSalarioBruto() {
        return this.horas*50;
    }

    @Override
    public double calcularBonus() {
        if(this.horas>30){
            return 100;
        }else{
            return 50;
        }
    }
    
    
}
