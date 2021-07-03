/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package PadraoState;

import java.util.ArrayList;
import java.util.Calendar;

/**
 *
 * @author Leonardo
 */
public class Pedido {

    private Calendar data;
    private double total;
    private StatusPedido status;
    private ArrayList<ItemPedido> itens;

    public void addItem(ItemPedido novoItem) {
        this.itens.add(novoItem);
    }

    public void remover(ItemPedido item) {
        this.itens.remove(item);
    }

    public Pedido(Calendar data, double total) {
        this.data = data;
        this.total = total;
        this.status = new StatusProcessando();
    }


    public void calcularTotal() {
        itens.forEach((item) -> {
            this.setTotal((item.getPreco()*item.getQuantidade())+this.getTotal());
        });
        System.out.println("Total da compra: "+total);
    }

    public void cancelar() {
        this.status.cancelado(this);
    }

    public void enviar() {
        this.status.enviado(this);
    }

    public Calendar getData() {
        return data;
    }

    public void setData(Calendar data) {
        this.data = data;
    }

    public double getTotal() {
        return total;
    }

    public void setTotal(double total) {
        this.total = total;
    }

    public StatusPedido getStatus() {
        return status;
    }

    public void setStatus(StatusPedido status) {
        this.status = status;
    }

    @Override
    public String toString() {
        return "Pedido{" +", total=" + total + ", status=" + status + ", itens=" + itens + '}';
    }
    
}
