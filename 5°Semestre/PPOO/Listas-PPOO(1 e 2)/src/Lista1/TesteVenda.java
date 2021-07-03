/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Lista1;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

/**
 *
 * @author Leonardo
 */
public class TesteVenda {
    public static void main(String[] args) throws ParseException {
         Date data1 = new SimpleDateFormat("dd/MM/yyyy").parse("15/03/2020");
                
                PromocaoLimiteData promocao = new PromocaoLimiteData();
                promocao.setNome("promoção de carnaval");
                promocao.setValorDesconto(10);
                promocao.setDataLimite(data1);
                
                
                PromocaoLimiteQuantidade promocao2 = new PromocaoLimiteQuantidade();
                promocao2.setNome("promoção de ano novo");
                promocao2.setValorDesconto(20);
                promocao2.setQuantidadeLimite(5);
                promocao2.setTotalUsos(4);
                
                Venda venda = new Venda();
                venda.setValor(500);
                System.out.println("Total com desconto: "+venda.calcularTotal(promocao)); 
                System.out.println("Total com desconto: "+venda.calcularTotal(promocao2));
    }
}
