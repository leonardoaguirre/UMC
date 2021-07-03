/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAO;

import Modelo.Empresa;
import Modelo.Vaga;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Leonardo
 */
public class DAOVagas {
    public List<Vaga> buscarVagas(){
        List<Vaga> vagas = new ArrayList<Vaga>();
        vagas.add(new Vaga("Auxiliar", 2000, new Empresa("465","Rua quatro")));
        vagas.add(new Vaga("Administrador", 3000, new Empresa("789","Rua sao caetano")));
        vagas.add(new Vaga("Programador", 5000, new Empresa("321","Rua jardins")));
        
        return vagas;
    }
}
