/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package res_lista3;

/**
 *
 * @author PTOLEDO
 */
public class Venda {
    private double totalvendido;
    private RegraDePagamento pagamento;

    public double getTotalvendido() {
        return totalvendido;
    }

    public void setTotalvendido(double totalvendido) {
        this.totalvendido = totalvendido;
    }

    public RegraDePagamento getPagameto() {
        return pagamento;
    }

    public void setPagamento(RegraDePagamento pagamento) {
        this.pagamento = pagamento;
    }
    
    public double calcularTotal(){
       
        return pagamento.pagar(this);
    }
}
