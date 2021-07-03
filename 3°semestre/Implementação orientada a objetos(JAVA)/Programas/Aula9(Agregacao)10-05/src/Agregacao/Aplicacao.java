
package Agregacao;

import java.util.Date;


public class Aplicacao {
    public static void main(String[] args) {
        Endereco end = new Endereco();
        end.setRua("Rua das flores");
        end.setNumero(50);
        
        ItemPedido objItem1 = new ItemPedido();
        objItem1.setCodigo(7);
        objItem1.setValor(19.0);
        objItem1.setQuantidade(1);
        
        ItemPedido objItem2 = new ItemPedido();
        objItem2.setCodigo(10);
        objItem1.setValor(33.5);
        objItem1.setQuantidade(5);
        
        ItemPedido[] itens = new ItemPedido[2];
        itens[0] = objItem1;
        itens[1] = objItem2;

       //Cria o objeto Pedido
       Pedido novoPedido = new Pedido();
       Date dataAtual = new Date();
       novoPedido.setData(dataAtual);
                //Agrega o endereco
		novoPedido.setEndereco(end);
		//Agrega os itens  
                novoPedido.setItens(itens);    

                Aplicacao.imprimePedido(novoPedido);

      }

public static void imprimePedido(Pedido pedido) {
        //Imprime o pedido
	System.out.println("Pedido feito em: " + pedido.getData());

	//Imprime o endereco
	Endereco enderecoPedido = pedido.getEndereco();
        System.out.println("Sera entregue em: "+enderecoPedido.getRua()+","+enderecoPedido.getNumero());

    //Imprime todos os itens
        ItemPedido[] todosOsItens = pedido.getItens();
        for (int i=0; i<todosOsItens.length; i++) {
            ItemPedido item = todosOsItens[i];
            System.out.println("\nCodigo: " + item.getCodigo());
            System.out.println("Valor: " + item.getValor());
            System.out.println("Quantidade: " + item.getQuantidade());
        }
    }  
}
