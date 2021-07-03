/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

import java.util.ArrayList;

/**
 *
 * @author alunocmc
 */
public class Cidade {
    private int id;
    private String nome;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public Cidade() {
    }

    public Cidade(int id, String nome) {
        this.id = id;
        this.nome = nome;
    }

    public ArrayList<Cidade> listarCidades(Estado estado) {
       ArrayList<Cidade> cidades = new ArrayList<>();
       switch(estado.getId()){ 
           case 1: 
           cidades.add(new Cidade(1, "Belo Horizonte"));
           cidades.add(new Cidade(2, "Contagem"));
           cidades.add(new Cidade(3, "Brumadinho"));
           break;
           case 2: 
           cidades.add(new Cidade(1, "Ipanema"));
           cidades.add(new Cidade(2, "São Gonçalo"));
           cidades.add(new Cidade(3, "Botafogo"));
           break;
           case 3: 
           cidades.add(new Cidade(1, "Poá"));
           cidades.add(new Cidade(2, "Mogi das Cruzes"));
           cidades.add(new Cidade(3, "Suzano"));
           break;
           //default: 
           //cidades.add(new Cidade(1, "Selecione um estado"));
          // break;
       }
       
       //demais estados
       
       return cidades; 
    }
}
