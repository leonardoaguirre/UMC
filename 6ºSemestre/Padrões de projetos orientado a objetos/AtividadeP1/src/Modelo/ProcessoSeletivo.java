/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

import java.util.List;


/**
 *
 * @author Leonardo
 */
public class ProcessoSeletivo {
    private List<Candidatura> candidatos;
    private Vaga vaga;
    private String codinome;

    public ProcessoSeletivo() {
    }

    public ProcessoSeletivo(List<Candidatura> candidatos, Vaga vaga, String codinome) {
        this.candidatos = candidatos;
        this.vaga = vaga;
        this.codinome = codinome;
    }

    public List<Candidatura> getCandidatos() {
        return candidatos;
    }

    public void setCandidatos(List<Candidatura> candidatos) {
        this.candidatos = candidatos;
    }

    public Vaga getVaga() {
        return vaga;
    }

    public void setVaga(Vaga vaga) {
        this.vaga = vaga;
    }

    public String getCodinome() {
        return codinome;
    }

    public void setCodinome(String codinome) {
        this.codinome = codinome;
    }
     public void adicionaCandidato(Candidatura candidatura){
         this.candidatos.add(candidatura);
     }
}
