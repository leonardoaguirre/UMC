/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package command;

import dao.TipoDao;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import modelo.Tipo;

/**
 *
 * @author alunocmc
 */
public class ExcluirTipoAction implements ICommand {

    @Override
    public String executar(HttpServletRequest request, HttpServletResponse response) throws Exception {
 
        Tipo tipo = new Tipo();
        
        TipoDao tipodao = new TipoDao();
        
        tipo.setId(Integer.parseInt(request.getParameter("id")));
        
        tipodao.excluir(tipo);
        
        return "/ControleTipo?acao=Listar";
    }
    
}
