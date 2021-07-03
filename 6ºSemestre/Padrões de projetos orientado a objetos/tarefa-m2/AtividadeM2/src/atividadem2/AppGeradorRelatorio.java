/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package atividadem2;

import model.Status;
import relatorio.GeradorDeRelatorio;
import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

/**
 *
 * @author Leonardo
 */
public class AppGeradorRelatorio {

    public static void main(String[] args) {
        GeradorDeRelatorio gr = new GeradorDeRelatorio();
        gr.gerar(Status.PENDENTE);
    }
}
