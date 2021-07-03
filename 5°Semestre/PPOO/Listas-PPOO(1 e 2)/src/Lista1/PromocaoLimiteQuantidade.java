/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Lista1;

public class PromocaoLimiteQuantidade extends Promocao{
    private int quantidadeLimite;
    private int totalUsos;

    public int getQuantidadeLimite() {
        return quantidadeLimite;
    }

    public void setQuantidadeLimite(int quantidadeLimite) {
        this.quantidadeLimite = quantidadeLimite;
    }

    public int getTotalUsos() {
        return totalUsos;
    }

    public void setTotalUsos(int totalUsos) {
        this.totalUsos = totalUsos;
    }
    @Override
    public boolean estaAtiva(){
        return this.totalUsos < this.quantidadeLimite;
    }
    @Override
    public double getValorDesconto() {
        return valorDesconto;
    }
}
