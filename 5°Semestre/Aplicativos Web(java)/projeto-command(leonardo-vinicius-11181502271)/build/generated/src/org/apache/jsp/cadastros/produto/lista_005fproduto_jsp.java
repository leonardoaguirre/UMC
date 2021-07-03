package org.apache.jsp.cadastros.produto;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;
import java.util.ArrayList;
import modelo.Produto;

public final class lista_005fproduto_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent {

  private static final JspFactory _jspxFactory = JspFactory.getDefaultFactory();

  private static java.util.List<String> _jspx_dependants;

  private org.glassfish.jsp.api.ResourceInjector _jspx_resourceInjector;

  public java.util.List<String> getDependants() {
    return _jspx_dependants;
  }

  public void _jspService(HttpServletRequest request, HttpServletResponse response)
        throws java.io.IOException, ServletException {

    PageContext pageContext = null;
    HttpSession session = null;
    ServletContext application = null;
    ServletConfig config = null;
    JspWriter out = null;
    Object page = this;
    JspWriter _jspx_out = null;
    PageContext _jspx_page_context = null;

    try {
      response.setContentType("text/html;charset=UTF-8");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;
      _jspx_resourceInjector = (org.glassfish.jsp.api.ResourceInjector) application.getAttribute("com.sun.appserv.jsp.resource.injector");

      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("<!DOCTYPE html>\n");
      out.write("<html>\n");
      out.write("    <head>\n");
      out.write("        <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\"> \n");
      out.write("        <link href=\"css/estilo-listar.css\" rel=\"stylesheet\" type=\"text/css\"/>\n");
      out.write("        <link href=\"https://fonts.googleapis.com/icon?family=Material+Icons\" rel=\"stylesheet\">\n");
      out.write("        <title>Lista de Produtos</title>\n");
      out.write("    </head>\n");
      out.write("    <body>\n");
      out.write("         <div class='limiter'>\n");
      out.write("            <div class='container-table100'>\n");
      out.write("                <div class='wrap-table100'>\n");
      out.write("                    <div class='table100'>\n");
      out.write("        <a href=\"ControleProduto?acao=Cadastrar\"><button id=\"btnConsultar\"><i class=\"material-icons\">add</i>Novo</button></a>\n");
      out.write("        <table border=\"1\">\n");
      out.write("            <thead>\n");
      out.write("                <tr>\n");
      out.write("                    <td colspan=\"4\">Produtos Cadastrados</td>\n");
      out.write("                </tr>\n");
      out.write("                <tr>\n");
      out.write("                    <th>id</th>\n");
      out.write("                    <th>Descrição</th>\n");
      out.write("                    <th>Quantidade</th>                   \n");
      out.write("                    <th>Operações</th>\n");
      out.write("                </tr>\n");
      out.write("            </thead>\n");
      out.write("            <tbody>\n");
      out.write("            ");

                ArrayList<Produto> arrproduto = new ArrayList<Produto>();
                arrproduto = (ArrayList<Produto>) request.getSession().getAttribute("arrproduto");
                for (Produto obj : arrproduto) {
            
      out.write("\n");
      out.write("             <tr>\n");
      out.write("                    <td> ");
      out.print( obj.getId());
      out.write("</td>\n");
      out.write("                    <td> ");
      out.print( obj.getDescricao());
      out.write("</td>\n");
      out.write("                    <td> ");
      out.print( obj.getQuantidade());
      out.write("</td>\n");
      out.write("                    <td>\n");
      out.write("                        <a href=\"ControleProduto?acao=Buscar&id=");
      out.print( obj.getId());
      out.write("\"><button id=\"btnAlterar\"><i class=\"material-icons\">create</i>Alterar</button></a>\n");
      out.write("                        <a href=\"ControleProduto?acao=Consultar&id=");
      out.print( obj.getId());
      out.write("\"><button id=\"btnConsultar\"><i class=\"material-icons\">find_in_page</i>Consultar</button></a>\n");
      out.write("                        <a href=\"ControleProduto?acao=Excluir&id=");
      out.print( obj.getId());
      out.write("\"><button id=\"btnExlcuir\"><i class=\"material-icons\">close</i>Excluir</button></a>\n");
      out.write("                    </td>\n");
      out.write("                </tr>\n");
      out.write("           \n");
      out.write("            \n");
      out.write("                ");

                }
            
      out.write("\n");
      out.write("            </tbody>\n");
      out.write("        </table>\n");
      out.write("                    </div>\n");
      out.write("                </div>\n");
      out.write("            </div>\n");
      out.write("         </div>\n");
      out.write("    </body>\n");
      out.write("</html>\n");
    } catch (Throwable t) {
      if (!(t instanceof SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          out.clearBuffer();
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }
}
