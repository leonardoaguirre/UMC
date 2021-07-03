/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servico;

import Exceptions.ConexaoInvalidaException;
import Modelo.Conexao;

/**
 *
 * @author Leonardo
 */
public class ProcessarConexao {
    public void conectar(Conexao conexao) throws ConexaoInvalidaException{
        IConexao iConexao = CriaConexaoFactory.create(conexao);
        iConexao.conectar();
    }
}
