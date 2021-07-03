<%-- 
    Document   : lista_produto
    Created on : 15/04/2019, 19:56:06
    Author     : alunocmc
--%>

<%@page import="java.util.ArrayList"%>
<%@page import="modelo.Produto"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"> 
        <link href="css/estilo-listar.css" rel="stylesheet" type="text/css"/>
        <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
        <title>Lista de Produtos</title>
    </head>
    <body margin="0">
         <div class='limiter'>
            <div class='container-table100'>
                <div class='wrap-table100'>
                    <div class='table100'>
        <a href="ControleProduto?acao=Cadastrar"><button id="btnConsultar"><i class="material-icons">add</i>Novo</button></a>
        <table border="1">
            <thead>
                <tr>
                    <td colspan="4">Produtos Cadastrados</td>
                </tr>
                <tr>
                    <th>Id</th>
                    <th>Descrição</th>
                    <th>Quantidade</th>                   
                    <th>Operações</th>
                </tr>
            </thead>
            <tbody>
            <%
                ArrayList<Produto> arrproduto = new ArrayList<Produto>();
                arrproduto = (ArrayList<Produto>) request.getSession().getAttribute("arrproduto");
                for (Produto obj : arrproduto) {
            %>
             <tr>
                    <td> <%= obj.getId()%></td>
                    <td> <%= obj.getDescricao()%></td>
                    <td> <%= obj.getQuantidade()%></td>
                    <td>
                        <a href="ControleProduto?acao=Buscar&id=<%= obj.getId()%>"><button id="btnAlterar"><i class="material-icons">create</i>Alterar</button></a>
                        <a href="ControleProduto?acao=Consultar&id=<%= obj.getId()%>"><button id="btnConsultar"><i class="material-icons">find_in_page</i>Consultar</button></a>
                        <a href="ControleProduto?acao=Excluir&id=<%= obj.getId()%>"><button id="btnExlcuir"><i class="material-icons">close</i>Excluir</button></a>
                    </td>
                </tr>
           
            
                <%
                }
            %>
            </tbody>
        </table>
                    </div>
                </div>
            </div>
         </div>
    </body>
</html>
