/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package App;

import Exceptions.ConexaoInvalidaException;
import Modelo.Conexao;
import Modelo.TipoConexao;
import Servico.ProcessarConexao;

/**
 *
 * @author Leonardo
 */
public class Main {
    public static void main(String[] args) throws ConexaoInvalidaException {
        ProcessarConexao processarConexao = new ProcessarConexao();
        Conexao conexao = new Conexao();
        
        conexao.setUrl("aaa");
        conexao.setDriver("bbb");
        conexao.setUsuario("admin");
        conexao.setSenha("123");
        
        conexao.setTipoConexao(TipoConexao.ORACLE);
        processarConexao.conectar(conexao);
        
        conexao.setTipoConexao(TipoConexao.SQLSERVER);
        processarConexao.conectar(conexao);
        
    }
}
