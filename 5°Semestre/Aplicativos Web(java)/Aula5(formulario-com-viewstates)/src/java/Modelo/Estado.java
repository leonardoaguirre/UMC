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
public class Estado {

    private int id;
    private String nome;
    private String sigla;
    private ArrayList<Cidade> cidades;

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

    public String getSigla() {
        return sigla;
    }

    public void setSigla(String sigla) {
        this.sigla = sigla;
    }

    public ArrayList<Cidade> getCidades() {
        return cidades;
    }

    public void setCidades(ArrayList<Cidade> cidades) {
        this.cidades = cidades;
    }

    public Estado() {
    }

    public Estado(int id, String nome, String sigla, ArrayList<Cidade> cidades) {
        this.id = id;
        this.nome = nome;
        this.sigla = sigla;
        this.cidades = cidades;
    }

    public Estado(int id, String nome, String sigla) {
        this.id = id;
        this.nome = nome;
        this.sigla = sigla;
    }

    public ArrayList<Estado> listarEstados() {

        ArrayList<Estado> estados = new ArrayList<>();
        estados.add(new Estado(1, "Minas Gerais", "MG"));
        estados.add(new Estado(2, "Rio de Janeiro", "RJ"));
        estados.add(new Estado(3, "São Paulo", "SP"));

        return estados;
    }

    public void listaCidadedoEstado() {
        Cidade cidade = new Cidade();
        this.cidades = cidade.listarCidades(this);
    }
    public String procuraEstado(int x){
        Estado estado = new Estado();
        ArrayList<Estado> estados = estado.listarEstados();
        return estados.get(x-1).nome;
    }
}
