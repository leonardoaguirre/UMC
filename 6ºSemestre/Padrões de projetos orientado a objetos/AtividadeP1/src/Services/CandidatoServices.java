/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Services;

import DAO.DAOVagas;
import Modelo.Candidato;
import Modelo.Candidatura;
import Modelo.Entrevista;
import Modelo.ProcessoSeletivo;
import Modelo.StatusCandidatura;
import Modelo.Vaga;
import java.util.List;

/**
 *
 * @author Leonardo
 */
public class CandidatoServices {

    public void consultarVagas() {
        DAOVagas daoVagas = new DAOVagas();
        List<Vaga> vagas = daoVagas.buscarVagas();
        System.out.println("Vagas disponiveis; ");
        for (Vaga vaga : vagas) {
            System.out.println("" + vaga.toString());
        }
    }

    public void candidatarVaga(ProcessoSeletivo processo, Candidato candidato) {
        Candidatura candidatura = new Candidatura(candidato, StatusCandidatura.EMPROCESSOSELETIVO);
        processo.adicionaCandidato(candidatura);
        System.out.println("Cadastrado no processo seletivo com sucesso!");
    }

    public void acompanharProcessoSeletivo(Candidatura candidatura, Entrevista entrevista, ProcessoSeletivo processso) {
        System.out.println("O status da sua candidatura no processo seletivo é: " + candidatura.getStatus());
        if (null == candidatura.getStatus()) {
            System.out.println("Você deve ir ao endereço: " + entrevista.getLocal() + " as " + entrevista.getHora() + " do dia " + entrevista.getData());
        } else {
            switch (candidatura.getStatus()) {
                case REPROVADO:
                    System.out.println("Você foi reprovado, mas não fique triste olhe as vagas que temos disponiveis;");
                    consultarVagas();
                    break;
                case APROVADO:
                    System.out.println("Parabéns você foi aprovado! Não se esqueça de nos trazer seu rg, carteira de trabalho e comprovante de residencia para a contratação.");
                    break;
                default:
                    System.out.println("Você deve ir ao endereço: " + entrevista.getLocal() + " as " + entrevista.getHora() + " do dia " + entrevista.getData());
                    break;
            }
        }
    }
}
