/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package processar;

import model.Status;

/**
 *
 * @author Leonardo
 */
public class PedidoFactory {

    public PedidoCommand create(Status status){
        PedidoCommand classeFinal = null;

        try {
            String s = status.name();//recupera o nome do status
            String[] vet = s.split("");//armazena o nome em um vetor de string
            
            for (int i = 0; i < vet.length; i++) {
                if (i == 0) s = vet[i].toUpperCase();else s += vet[i].toLowerCase();
            }//loop para deixar a primeira letra maiscula e o resto minuscula do nome da classe
            
            String nome = "processar.Pedido" + s;
            Class classe = Class.forName(nome);
            classeFinal =  (PedidoCommand)classe.newInstance();
            
            return classeFinal;
        } catch (Exception ex) {
            System.out.println("Erro: " + ex);
        }
        return classeFinal;
    }
}
