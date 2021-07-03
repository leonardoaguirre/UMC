/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package res_lista3;

/**
 *
 * @author alunocmc
 */
public class PgCC implements PagamentoPrazo{

    @Override
    public double pagar(Venda venda) {
        return venda.getTotalvendido()+(venda.getTotalvendido()*0.08);
    }
    
}
