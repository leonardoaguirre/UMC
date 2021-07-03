/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controle;

import Modelo.TipoSanguineo;
import Modelo.Usuario;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import Modelo.Sexo;

/**
 *
 * @author Leonardo
 */
@WebServlet(name = "controleAcesso", urlPatterns = {"/controleAcesso"})
public class controleAcesso extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        try (PrintWriter out = response.getWriter()) {

            String log = request.getParameter("txtLogin");
            String senha = request.getParameter("txtSenha");

            Usuario usu = new Usuario(log, senha);
            HttpSession httpsession = request.getSession();

            if (usu.logar()) {
                ArrayList<Sexo> arr = new ArrayList<>();
                Sexo sexo = new Sexo();
                arr = sexo.listarTodos();
                
                ArrayList<TipoSanguineo> arr2 = new ArrayList<>();
                TipoSanguineo tipoSanguineo = new TipoSanguineo();
                arr2= tipoSanguineo.listarTodos();
                
                httpsession.setAttribute("usu", usu);
                httpsession.setAttribute("arrSexo", arr);
                httpsession.setAttribute("arrTipoSanguineo", arr2);
                
                response.sendRedirect("logado.jsp");

            } else {
                usu.login = usu.login + " não foi reconhecido como usuario, tente novamente!";
                httpsession.setAttribute("msg", usu);
                response.sendRedirect("index.jsp");
            }
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
