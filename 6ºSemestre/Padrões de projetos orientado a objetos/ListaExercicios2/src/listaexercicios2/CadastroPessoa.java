/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package listaexercicios2;

/**
 *
 * @author Leonardo
 */
public class CadastroPessoa {
    public static void main(String[] args) {
        Pessoa p = new Pessoa();
        p.setNome("Maria");
        p.setSobrenome("Silva");
        
        System.out.println(p.lerNomeCompleto());
    }
}
