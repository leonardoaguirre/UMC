/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Inutils;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

/**
 *
 * @author wolley
 */
public class AtividadeM2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner sc = null;
        try {
            //caminho do arquivo
            String path = "arquivo/pedidos.csv";

            //leitura do arquivo
            sc = new Scanner(new File(path));

            //enquanto houver linhas
            while (sc.hasNext()) {
                String linha = sc.nextLine();
                String[] campos = linha.split(";");
                imprimeCamposDaLinha(campos);
            }

        } catch (FileNotFoundException ex) {
            ex.printStackTrace();
        } finally {
            if (sc != null) {
                sc.close();
            }

        }

    }

    private static void imprimeCamposDaLinha(String[] campos) {
        for (int i = 0; i < campos.length; i++) {
            System.out.println(campos[i]);
        }
    }

}
