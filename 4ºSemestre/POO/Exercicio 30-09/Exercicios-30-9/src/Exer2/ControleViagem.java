package Exer2;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import javax.swing.JOptionPane;

public class ControleViagem {

    Viagem viagem = new Viagem();
    Calendario calendario = new Calendario();

    public void gerarRelatorio(Date dataInicial, Date dataFinal) throws ParseException {
        SimpleDateFormat f = new SimpleDateFormat("dd/MM/yy");

        viagem.setDataInicio(f.parse("11/09/2019"));
        viagem.setDataFim(f.parse("12/09/2019"));
        viagem.setDestino("Poá");
        viagem.setValor(420);
        
        boolean flag = false;
            if (viagem.getDataInicio().after(dataInicial) || viagem.getDataInicio().equals(dataInicial)) {
                JOptionPane.showMessageDialog(null, "Data da viagem:" + f.format(viagem.getDataInicio()) + " Destino:" + viagem.getDestino() + " Valor:" + viagem.getValor());
                flag = true;
            }
            if (flag == false) {
                JOptionPane.showMessageDialog(null, "Nenhuma viagem foi encontrada!");
        }
    }

    public void exibirCalendario() {
        calendario.setDatas("1-2-3-4-5\n6-7-8-9-10\n11-12-13-14");
        JOptionPane.showMessageDialog(null, calendario.getDatas());
    }
}
