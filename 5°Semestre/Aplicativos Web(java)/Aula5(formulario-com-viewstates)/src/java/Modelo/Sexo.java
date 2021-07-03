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
public class Sexo {

    private int id;
    private String descricao;
    private String abreviacao;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public String getAbreviacao() {
        return abreviacao;
    }

    public void setAbreviacao(String abreviacao) {
        this.abreviacao = abreviacao;
    }

    public Sexo() {
    }

    public Sexo(int id, String descricao, String abreviacao) {
        this.id = id;
        this.descricao = descricao;
        this.abreviacao = abreviacao;
    }

    public ArrayList<Sexo> listarTodos() {
        ArrayList<Sexo> arr = new ArrayList<>();
        arr.add(new Sexo(1, "Feminino", "FEM"));
        arr.add(new Sexo(2, "Masculino", "MASC"));
        return arr;
    }
    public String procurarSexo(int x){
        Sexo sexo = new Sexo();
        ArrayList<Sexo> sexos = sexo.listarTodos();
        return sexos.get(x-1).descricao;
    }
}
