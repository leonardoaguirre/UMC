<%-- 
    Document   : alterar_situacao
    Created on : 16/04/2019, 19:11:05
    Author     : alunocmc
--%>

<%@page import="modelo.Situacao"%>
<%@page import="java.util.ArrayList"%>
<%@page import="modelo.Produto"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link href="css/estilo-cad-alt.css" rel="stylesheet" type="text/css"/>
        <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
        <title>Cadastrar produto</title>
    </head>
    <body>


        <form action="/padraocommand/ControleProduto" method="POST">

            <input type="hidden" name="acao" id="acao" value="Cadastrar"/>
            <fieldset>
            <legend><span class="number">1</span>Cadastro de produto</legend>
            <div>
                <label>Descrição</label>
                <input type="text" name="txtdescricao" id="txtdescricao" value=""/>
            </div>
            <div>
                <label>Quantidade</label>
                <input type="text" name="txtquantidade" id="txtquantidade" value=""/>
            </div>
            <!--perceb aque o campo abaixo devera ser uma combo, onde o array list foi disponibilizado na session-->
            <div>
                <label>Situação</label>
                <select name='cmbsituacao'>
                    <%
                        ArrayList<Situacao> arrsituacao = new ArrayList<Situacao>();
                        arrsituacao = (ArrayList<Situacao>) request.getSession().getAttribute("arrsituacao");
                        for (Situacao obj : arrsituacao) {
                    %>
                    <option value="<%= obj.getId()%>"><%= obj.getDescricao()%></option>
                    <%
                        }
                    %>
                </select>
            </div>
            </fieldset>
            <div>
                <input type="submit" name="btncadastrar" id="btncadastrar" value="Cadastrar"/>   
            </div>

        </form>

    </body>
</html>
