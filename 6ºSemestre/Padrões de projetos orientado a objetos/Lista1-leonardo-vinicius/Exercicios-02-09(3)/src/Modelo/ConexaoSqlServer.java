/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

import Servico.IConexao;

/**
 *
 * @author Leonardo
 */
public class ConexaoSqlServer implements IConexao {
    @Override
    public void conectar() {
        System.out.println("Conectando com SGBD SQL Server");
    }
    
}
