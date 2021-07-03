package Exer3;

import java.util.Random;
import javax.swing.JOptionPane;

public class ControleViagem {

    Viagem viagem = new Viagem();
    Random r = new Random();
    public void cadViagem(String origem, String destino, double peso, String descricao) {
        viagem.setOrigem(origem);
        viagem.setDestino(destino);
        viagem.setDescricao(descricao);
        viagem.setPeso(peso);
        
        JOptionPane.showMessageDialog(null,"Viagem solicitada com sucesso!");
    }

    public double calcViagem() {
        return r.nextInt(1000);
    }
    public int calcTempo(){
        return r.nextInt(10);
    }
}
