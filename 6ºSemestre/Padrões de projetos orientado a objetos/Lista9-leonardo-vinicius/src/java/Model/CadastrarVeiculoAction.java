/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Model;

import java.util.ArrayList;
import java.util.List;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 *
 * @author Leonardo
 */
public class CadastrarVeiculoAction implements ICommand {

    @Override
    public String executar(HttpServletRequest request, HttpServletResponse response) throws Exception {
        try {
            HttpSession sessao = request.getSession();
        List<Veiculo> listaDeVeiculos = new ArrayList<>();
        if(!sessao.isNew()){
            listaDeVeiculos = (List<Veiculo>) sessao.getAttribute("listaDeVeiculos");
        }

        String marca = request.getParameter("txtMarca");
        String modelo = request.getParameter("txtModelo");
        String anoFabricacao = request.getParameter("txtAnoFabricacao");
        String descricao = request.getParameter("txtDescricao");

        Veiculo veiculo = new Veiculo();
        veiculo.setMarca(marca);
        veiculo.setModelo(modelo);
        veiculo.setAnoFabricacao(anoFabricacao);
        veiculo.setDescricao(descricao);

        listaDeVeiculos.add(veiculo);
        sessao.setAttribute("listaDeVeiculos", listaDeVeiculos);
        
        } catch (Exception e) {
            request.setAttribute("", e);
            return "erro.jsp";
        }
        return "Sucesso-cadastro.jsp";
    }

}
