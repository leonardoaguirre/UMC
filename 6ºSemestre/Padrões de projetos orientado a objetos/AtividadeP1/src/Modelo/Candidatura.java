/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

/**
 *
 * @author Leonardo
 */
public class Candidatura {
    private Candidato candidato;
    private StatusCandidatura status;

    public Candidatura() {
    }

    public Candidatura(Candidato candidato, StatusCandidatura status) {
        this.candidato = candidato;
        this.status = status;
    }

    public Candidato getCandidato() {
        return candidato;
    }

    public void setCandidato(Candidato candidato) {
        this.candidato = candidato;
    }

    public StatusCandidatura getStatus() {
        return status;
    }

    public void setStatus(StatusCandidatura status) {
        this.status = status;
    }
    
    
}
