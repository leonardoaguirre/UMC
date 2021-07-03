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
public class Mensalista extends Empregado{
    private String cargo;

    public Mensalista(String nome,String cargo) {
        super(nome);
        this.cargo = cargo;
    }

    @Override
    public double calcularSalarioBruto() {
        if(this.cargo.equals("Junior")){
            return 2500;
        }else if(this.cargo.equals("Pleno")){
            return 3500;
        }else if(this.cargo.equals("Senior")){
            return 5500;
        }else{
            return 0;
        }
    }

    @Override
    public double calcularBonus() {
        if(this.cargo.equals("Junior")){
            return 50;
        }else if(this.cargo.equals("Pleno")){
            return 100;
        }else if(this.cargo.equals("Senior")){
            return 150;
        }else{
            return 0;
        }
    }
    
    
}
