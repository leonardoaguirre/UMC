/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAO;

import Modelo.Candidato;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Leonardo
 */
public class DAOcandidatos {
    public List<Candidato> buscarCandidatos(){
        List<Candidato> candidatos = new ArrayList<Candidato>();
        candidatos.add(new Candidato(1,"123","123", 20,"leo@gmail.com","senha123","Leonardo"));
        candidatos.add(new Candidato(2,"321","321", 35,"andressa@gmail.com","senha321","Andressa"));
        candidatos.add(new Candidato(3,"456","456", 24,"pedro@gmail.com","senha456","Pedro"));
        candidatos.add(new Candidato(4,"654","654", 29,"lucas@gmail.com","senha654","Lucas"));
        
        return candidatos;
    }
}
