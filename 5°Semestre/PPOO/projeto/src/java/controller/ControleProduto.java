/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller;

import dao.produto.ProdutoDao;
import dao.situacao.SituacaoDao;
import java.io.IOException;
import java.util.ArrayList;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import modelo.Produto;
import modelo.Situacao;

/**
 *
 * @author profe
 */
@WebServlet(name = "ControleProduto", urlPatterns = {"/ControleProduto"})
public class ControleProduto extends HttpServlet {

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
        try {
            Produto produto = new Produto();
            ProdutoDao produtoDao = new ProdutoDao();
            String acao = request.getParameter("acao");

            if (acao.equals("CadastrarNovo")) {
                
                Situacao situacao = new Situacao();
                SituacaoDao situacaodao = new SituacaoDao();
                ArrayList<Situacao> arrsituacao = new ArrayList<>();
                situacao.setDescricao(""); //desta forma virão todos os registros
                arrsituacao = situacaodao.listar(situacao);
                HttpSession session = request.getSession();
                session.setAttribute("arrsituacao", arrsituacao);
                
                RequestDispatcher rd = request.getRequestDispatcher("/cadastros/produto/cadastrar_produto.jsp");
                rd.forward(request, response);

            } else if (acao.equals("Cadastrar")) {
                try {
                    produto.setDescricao(request.getParameter("txtdescricao"));
                    produto.setQuantidade(Integer.parseInt(request.getParameter("txtquantidade")));

                    Situacao situacao = new Situacao();
                    situacao.setId(Integer.parseInt(request.getParameter("cmbsituacao")));
                    produto.setSituacao(situacao); //aqui acontece a agregação

                    ProdutoDao produtodao = new ProdutoDao();

                    produtodao.cadastrar(produto);

                } catch (Exception ex) {

                }
                RequestDispatcher rd = request.getRequestDispatcher("ControleProduto?acao=Listar");
                rd.forward(request, response);
            } else if (acao.equals("Listar")) {
                ArrayList<Produto> arr = new ArrayList<Produto>();

                produto.setDescricao("");

                arr = produtoDao.listar(produto);

                HttpSession session = request.getSession();

                session.setAttribute("arrproduto", arr);
                RequestDispatcher rd = request.getRequestDispatcher("/cadastros/produto/lista_produto.jsp");
                rd.forward(request, response);

            } else if (acao.equals("Excluir")) {
                produto.setId(Integer.parseInt(request.getParameter("id")));

                produtoDao.excluir(produto);

                produtoDao.buscar(produto);


                RequestDispatcher rd = request.getRequestDispatcher("ControleProduto?acao=Listar");

                rd.forward(request, response);

            } else if (acao.equals("Consultar")) {
                produto.setId(Integer.parseInt(request.getParameter("id")));

                produtoDao.buscar(produto);

                HttpSession session = request.getSession();

                session.setAttribute("produto", produto);
                RequestDispatcher rd = request.getRequestDispatcher("/cadastros/produto/consultar_produto.jsp");

                rd.forward(request, response);

            } else if (acao.equals("Alterar")) {
                produto.setDescricao(request.getParameter("txtdescricao"));
                produto.setQuantidade(Integer.parseInt(request.getParameter("txtquantidade")));

                produto.setId(Integer.parseInt(request.getParameter("id")));

                Situacao situacao = new Situacao();
                situacao.setId(Integer.parseInt(request.getParameter("cmbsituacao")));
                produto.setSituacao(situacao); //aqui acontece a agregação

                ProdutoDao produtodao = new ProdutoDao();

                produtodao.alterar(produto);
                response.sendRedirect("ControleProduto?acao=Listar");

            } else if (acao.equals("Buscar")) {
                try {
                    Situacao situacao = new Situacao();
                    SituacaoDao situacaodao = new SituacaoDao();
                    ArrayList<Situacao> arrsituacao = new ArrayList<>();
                    situacao.setDescricao(""); //desta forma virão todos os registros
                    arrsituacao = situacaodao.listar(situacao);
                    HttpSession session = request.getSession();
                    session.setAttribute("arrsituacao", arrsituacao);
                } catch (Exception ex) {
                    //nada a fazer
                }

                ProdutoDao produtodao = new ProdutoDao();

                produto.setId(Integer.parseInt(request.getParameter("id")));

                produtodao.buscar(produto);

                HttpSession session = request.getSession();

                session.setAttribute("produto", produto);

                //response.sendRedirect("cadastros/produto/alterar_produto.jsp");
                RequestDispatcher rd = request.getRequestDispatcher("/cadastros/produto/alterar_produto.jsp");

                rd.forward(request, response);
            }

        } catch (Exception ex) {

            RequestDispatcher rd = request.getRequestDispatcher("erro.jsp");

            rd.forward(request, response);
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
