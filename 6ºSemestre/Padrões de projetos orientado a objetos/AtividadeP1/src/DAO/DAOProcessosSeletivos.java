/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAO;

import Modelo.Candidato;
import Modelo.Candidatura;
import Modelo.ProcessoSeletivo;
import Modelo.Vaga;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Leonardo
 */
public class DAOProcessosSeletivos {

    public List<ProcessoSeletivo> buscarProcessos() {
        List<ProcessoSeletivo> processos = new ArrayList<ProcessoSeletivo>();
        DAOVagas daoVagas = new DAOVagas();
        List<Vaga> vagas = daoVagas.buscarVagas();

        DAOCandidaturas daoCandidaturas = new DAOCandidaturas();
        List<Candidatura> candidaturas = daoCandidaturas.buscarCandidaturas();
        
        processos.add(new ProcessoSeletivo(candidaturas, vagas.get(0), "Processo 1"));
        processos.add(new ProcessoSeletivo(candidaturas, vagas.get(1), "Processo 2"));
        processos.add(new ProcessoSeletivo(candidaturas, vagas.get(2), "Processo 3"));

        return processos;
    }
}
