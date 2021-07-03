/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package App;

import Model.ContaBancaria;
import Servico.CartaoCredito;
import Servico.CartaoDebito;
import Servico.TitularAdicional;
import Servico.TitularPrincipal;

/**
 *
 * @author Leonardo
 */
public class Main {
    public static void main(String[] args) {
        ContaBancaria conta = new ContaBancaria();
        conta.setAgencia(123);
        conta.setNumero(123);
        conta.setSaldo(500);
        conta.setTitular(new TitularPrincipal(
                new CartaoCredito(123,123,010220)
                ,"Leonardo","123"));
        conta.sacar(300);
        
    }
}
