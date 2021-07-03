package aplicacaovenda;

import aplicacaovenda.Model.Cliente;
import aplicacaovenda.Model.Compra;
import aplicacaovenda.Model.Produto;
import aplicacaovenda.Util.FormataData;

public class AplicacaoLoja {

    public static void main(String[] args) {
        Cliente novoCliente;
        novoCliente = new Cliente();
        novoCliente.setNome("Ari");

        Produto prod = new Produto(1, "Camiseta", 99.9);
        Produto prod2 = new Produto(2, "Bermuda", 50.0);
        
        Compra novaCompra = new Compra();
        novaCompra.setData(FormataData.formata(01, 10, 2020));
        novaCompra.setCliente(novoCliente);
        novaCompra.setQuantidadeProdutos(2);
        novaCompra.addProduto(prod);
        novaCompra.addProduto(prod2);

        if (novaCompra.finalizar()) {
            System.out.println("Compra realizada com sucesso!");
            
        } else {
            System.out.println("Erro ao finalizar compra");
        }
    }

}
