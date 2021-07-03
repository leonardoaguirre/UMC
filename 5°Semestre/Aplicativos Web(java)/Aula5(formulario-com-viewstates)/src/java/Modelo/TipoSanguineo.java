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
public class TipoSanguineo {
    private int id;
    private String tipo;

    public TipoSanguineo(int id, String tipo) {
        this.id = id;
        this.tipo = tipo;
    }

    public TipoSanguineo() {
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public ArrayList<TipoSanguineo> listarTodos() {
        ArrayList<TipoSanguineo> arr = new ArrayList<>();
        arr.add(new TipoSanguineo(1,"O+"));
        arr.add(new TipoSanguineo(2,"O-"));
        arr.add(new TipoSanguineo(3,"A+"));
        arr.add(new TipoSanguineo(4,"A-"));
        arr.add(new TipoSanguineo(5,"B+"));
        arr.add(new TipoSanguineo(6,"B-"));
        arr.add(new TipoSanguineo(7,"AB+"));
        arr.add(new TipoSanguineo(8,"AB-"));
        
        return arr;
    }
    public String procuraTipo(int x){
        TipoSanguineo tipoSanguineo = new TipoSanguineo();
        ArrayList<TipoSanguineo> tipos = tipoSanguineo.listarTodos();
        return tipos.get(x-1).tipo;
    }
    
}
