/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package relatorio;

import model.Pedido;
import model.Status;
import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author Leonardo
 */
public class LeitorDeArquivo {

    public List<Pedido> ler() {
        Scanner sc = null;
        List<Pedido> pedidos = new ArrayList<>();
        try {
            //caminho do arquivo
            String path = "arquivo/pedidos.csv";

            //leitura do arquivo
            sc = new Scanner(new File(path));

            //enquanto houver linhas
            while (sc.hasNext()) {
                String linha = sc.nextLine();
                String[] campos = linha.split(";");

                Pedido pd = new Pedido();
                pd.setId(Long.parseLong(campos[0]));
                pd.setDescricao(campos[1]);
                pd.setTotal(Double.parseDouble(campos[2]));
                pd.setStatus(Status.valueOf(campos[3]));

                pedidos.add(pd);
            }
        } catch (FileNotFoundException ex) {
            ex.printStackTrace();
        } finally {
            if (sc != null) {
                sc.close();
            }
        }
        return pedidos;
    }
}
