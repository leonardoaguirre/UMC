<%-- 
    Document   : alterar_produto
    Created on : 16/04/2019, 19:11:05
    Author     : alunocmc
--%>

<%@page import="modelo.Produto"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link href="css/estilo-cad-alt.css" rel="stylesheet" type="text/css"/>
        <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
        <title>Consultar Produto</title>
    </head>
    <body>

        <%

            Produto objproduto = new Produto();
            objproduto = (Produto) request.getSession().getAttribute("produto"); //aqui pega o objeto produto que esta na sessão

        %>

        <form method="Post" action="/padraocommand/ControleProduto?acao=Listar">
          
            <div>
                <label>Descrição : <b><%= objproduto.getDescricao()%></b></lable>
            </div>    
            
             <div>
                <label>Quantidade : <b><%= objproduto.getQuantidade()%></b></lable>
            </div>    
            
            <div>
                <label>Situacao : <b><%= objproduto.getSituacao().getDescricao() %></b></lable>
            </div>    
            <input type="submit" value="Voltar a lista" >
        </form>

    </body>
</html>
