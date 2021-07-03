/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Services;

import DAO.DAOProcessosSeletivos;
import Modelo.Candidatura;
import Modelo.ProcessoSeletivo;
import Modelo.Vaga;
import java.util.List;

/**
 *
 * @author Leonardo
 */
public class AgenciaServices {

    public void cadastrarVaga(Vaga vaga, String nomeProcesso) {
        ProcessoSeletivo processoSeletivo = new ProcessoSeletivo(null, vaga, nomeProcesso);
        System.out.println("Processo seletivo aberto para a vaga de" + vaga.getCargo() + " com salario de R$" + vaga.getSalario());
    }

    public void consultarCandidatos() {
        DAOProcessosSeletivos daoProcessosSeletivos = new DAOProcessosSeletivos();
        List<ProcessoSeletivo> processoSeletivo = daoProcessosSeletivos.buscarProcessos();

        for (ProcessoSeletivo ps : processoSeletivo) {
            System.out.println("-----------------------------------------------------------------");
            System.out.println("" + ps.getCodinome() + " " + ps.getVaga());
            List<Candidatura> candidaturas = ps.getCandidatos();
            System.out.println("Candidatos;");
            for (Candidatura cand : candidaturas) {
                System.out.println("" + cand.getCandidato().toString());
            }
        }
    }

    public void gerenciarProcessoSeletivo() {
        consultarCandidatos();
        DAOProcessosSeletivos daoProcessosSeletivos = new DAOProcessosSeletivos();
        List<ProcessoSeletivo> processoSeletivo = daoProcessosSeletivos.buscarProcessos();
        processoSeletivo.clear();
        System.out.println("-----------------------------------------------------------------");
        System.out.println("Todos os processos seletivos listados acima foram encerrados!");
        
    }
}
