/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Leonardo
 */
public class Pasta extends Arquivo{
    private List<Arquivo> arquivos = new ArrayList<Arquivo>();
    
    public Pasta(String nome) {
        super(nome);
    }
    public void addArquivos(Arquivo arquivo){
        this.arquivos.add(arquivo);
    }
    public void imprime(){
        System.out.println("Pasta: "+this.getNome());
        System.out.println("Arquivo(s);");
        for(Arquivo arquivo : arquivos){
            System.out.println(""+arquivo.getNome());
        }
        System.out.println("_______________________________________");
    }
}
