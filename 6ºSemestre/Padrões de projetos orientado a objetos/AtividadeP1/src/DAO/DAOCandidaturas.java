/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAO;

import Modelo.Candidato;
import Modelo.Candidatura;
import Modelo.StatusCandidatura;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Leonardo
 */
public class DAOCandidaturas {

    public List<Candidatura> buscarCandidaturas() {
        List<Candidatura> candidaturas = new ArrayList<Candidatura>();

        DAOcandidatos daOcandidatos = new DAOcandidatos();
        List<Candidato> candidatos = daOcandidatos.buscarCandidatos();

        candidaturas.add(new Candidatura(candidatos.get(0), StatusCandidatura.EMPROCESSOSELETIVO));
        candidaturas.add(new Candidatura(candidatos.get(1), StatusCandidatura.EMPROCESSOSELETIVO));
        candidaturas.add(new Candidatura(candidatos.get(2), StatusCandidatura.EMPROCESSOSELETIVO));
        
        return candidaturas;
    }
}
