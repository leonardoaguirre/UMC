/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lista4_pooo;

import java.util.Arrays;
import java.util.Calendar;
import java.util.List;

/**
 *
 * @author Leonardo
 */
public class TesteNotaFiscal {
    public static void main(String[] args) {
        List<ItemDaNota> itens = Arrays.asList(new ItemDaNota("item 1",200), new ItemDaNota("Item 2",400));
        double total=0;
        for(ItemDaNota item : itens){
            total+=item.getValor();
        }
        double impostos = total*0.5;
    
    NotaFiscal nf = new NotaFiscal("razao social", "cnpf", Calendar.getInstance(),total,impostos,itens,"obs qualquer");
    }
    
}
