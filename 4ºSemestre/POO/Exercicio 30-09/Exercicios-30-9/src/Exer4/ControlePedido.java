
package Exer4;

import java.util.Random;
import javax.swing.JOptionPane;

public class ControlePedido {
    public void calcTotalPed(double total1,double total2){
        JOptionPane.showMessageDialog(null,"O valor total de seu pedido é de R$"+(total1+total2));
    }
    public int calcTempoPed(){
        Random r = new Random();
        int n=r.nextInt(60);
        return n;
    }
    public void pedFinalizar(String sabor, String tipo,int qt1, double valor1,String nome, String tipo2, int qt2, double valor2,Cliente cli){
        Pizza pizza = new Pizza();
        pizza.setSabor(sabor);
        pizza.setTipo(tipo);
        pizza.setValor(valor1);
        pizza.setQuantidade(qt1);
        
        Bebida bebida = new Bebida();
        bebida.setNome(nome);
        bebida.setQuantidade(qt2);
        bebida.setTipo(tipo2);
        bebida.setValor(valor2);
        
        Pedido pedido = new Pedido();
        pedido.setPizzas(pizza);
        pedido.setBebidas(bebida);
        pedido.setCliente(cli);
        
        JOptionPane.showMessageDialog(null, "Pedido finalizado com sucesso! Obrigado pela preferência");
        System.exit(0);
    }
}
