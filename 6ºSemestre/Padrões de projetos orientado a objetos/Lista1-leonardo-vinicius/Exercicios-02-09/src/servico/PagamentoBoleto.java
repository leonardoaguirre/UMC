/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servico;

import Modelo.Compra;
import java.util.Date;

/**
 *
 * @author Leonardo
 */
public class PagamentoBoleto implements IPagamento{
    private double desconto;
    private Date validade;
    @Override
    public void pagar(double valor) {
        System.out.println("Pagando por boleto");
    }
    
}
