/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servico;

import Modelo.Cliente;

/**
 *
 * @author Leonardo
 */
public interface IManter {
    public void cadastrar(Cliente cliente);
    public void atualizar(Cliente cliente);
    public void consultar(Cliente cliente);
    public void excluir(Cliente cliente);
}
