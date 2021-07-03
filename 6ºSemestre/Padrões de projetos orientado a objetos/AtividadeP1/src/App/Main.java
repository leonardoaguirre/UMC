/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package App;

import Modelo.Candidato;
import Modelo.Candidatura;
import Modelo.Empresa;
import Modelo.Entrevista;
import Modelo.ProcessoSeletivo;
import Modelo.StatusCandidatura;
import Modelo.Vaga;
import Services.AgenciaServices;
import Services.CandidatoServices;
import java.util.ArrayList;


/**
 *
 * @author Leonardo
 */
public class Main {

    public static void main(String[] args) {

        //testes de servicos de candidatos
        //teste de consulta de vagas
        CandidatoServices candidatoServices = new CandidatoServices();
        candidatoServices.consultarVagas();
        //teste de candidatar a vaga
        Candidato usuCandidato = new Candidato(1, "123", "321", 25, "Leonardo@gmail.com", "senha465", "Leonardo");
        ProcessoSeletivo processo = new ProcessoSeletivo(new ArrayList<Candidatura>(),new Vaga("analista",2000,
                new Empresa("123","rua dois")),"Processo 1");
        candidatoServices.candidatarVaga(processo, usuCandidato);
        //teste de acompanhamento de processo seletivo
        candidatoServices.acompanharProcessoSeletivo(new Candidatura(usuCandidato,StatusCandidatura.EMPROCESSOSELETIVO),
                new Entrevista("10/10/2020","Rua tres","12:00",usuCandidato), processo);

        //testes de servicos da agencia
        //teste de consultar os candidatos em cada processo seletivo
        AgenciaServices agenciaServices = new AgenciaServices();
        agenciaServices.consultarCandidatos();
        //teste de cadasatrar uma vaga
        agenciaServices.cadastrarVaga(new Vaga("designer",5000,new Empresa("123","rua dois")), "Processo final");
        //teste de gerenciamento dos processos seletivos
        agenciaServices.gerenciarProcessoSeletivo();
    }

}
