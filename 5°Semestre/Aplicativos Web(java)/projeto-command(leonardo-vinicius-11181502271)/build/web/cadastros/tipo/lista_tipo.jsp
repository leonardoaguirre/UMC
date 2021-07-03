<%-- 
    Document   : lista_tipo
    Created on : 15/04/2019, 19:56:06
    Author     : alunocmc
--%>

<%@page import="java.util.ArrayList"%>
<%@page import="modelo.Tipo"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link href="css/estilo-listar.css" rel="stylesheet" type="text/css"/>
        <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
        <title>Listar Tipos</title>
    </head>
    <body margin="0">
         <div class='limiter'>
            <div class='container-table100'>
                <div class='wrap-table100'>
                    <div class='table100'>
        <a href="ControleTipo?acao=Cadastrar"><button id="btnConsultar"><i class="material-icons">add</i>Novo</button></a>
        <table border="1">
            <thead>
                <tr>
                    <td colspan="4">Tipos Cadastrados</td>
                </tr>
                <tr>
                    <th>Id</th>
                    <th>Descrição</th>
                    <th>Operações</th>
                </tr>
            </thead>
            <tbody>
            <%
                ArrayList<Tipo> arrtipo = new ArrayList<Tipo>();
                arrtipo = (ArrayList<Tipo>) request.getSession().getAttribute("arrtipo");
                for (Tipo obj : arrtipo) {
            %>
             <tr>
                    <td> <%= obj.getId()%></td>
                    <td> <%= obj.getDescricao()%></td>
                    <td>
                        <a href="ControleTipo?acao=Buscar&id=<%= obj.getId()%>"><button id="btnAlterar"><i class="material-icons">create</i>Alterar</button></a>
                        <a href="ControleTipo?acao=Consultar&id=<%= obj.getId()%>"><button id="btnConsultar"><i class="material-icons">find_in_page</i>Consultar</button></a>
                        <a href="ControleTipo?acao=Excluir&id=<%= obj.getId()%>"><button id="btnExlcuir"><i class="material-icons">close</i>Excluir</button></a>
                    </td>
                </tr>
           
            
                <%
                }
            %>
            </tbody>
        </table>
    </body>
</html>
