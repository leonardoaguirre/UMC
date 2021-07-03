/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servico;

import Exceptions.ConexaoInvalidaException;
import Modelo.Conexao;
import Modelo.ConexaoOracle;
import Modelo.ConexaoSqlServer;

/**
 *
 * @author Leonardo
 */
public class CriaConexaoFactory {

    public static IConexao create(Conexao conexao) throws ConexaoInvalidaException {
        switch (conexao.getTipoConexao()) {
            case SQLSERVER:
                return new ConexaoSqlServer();
            case ORACLE:
                return new ConexaoOracle();
            default:
                throw new ConexaoInvalidaException("Tipo de conexao invalida!");
        }
    }
}
