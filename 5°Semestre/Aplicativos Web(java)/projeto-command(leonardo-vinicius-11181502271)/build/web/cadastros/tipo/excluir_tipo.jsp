<%-- 
    Document   : alterar_tipo
    Created on : 16/04/2019, 19:11:05
    Author     : alunocmc
--%>

<%@page import="modelo.Tipo"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link href="css/estilo-cad-alt.css" rel="stylesheet" type="text/css"/>
        <title>Excluir?</title>
    </head>
    <body>

        <%

            Tipo objtipo = new Tipo();
            objtipo = (Tipo) request.getSession().getAttribute("tipo"); //aqui pega o objeto tipo que esta na sessão

        %>

        <form action="/padraocommand/ControleTipo" method="POST">
            <input type="hidden" name="id" id="id" value="<%= objtipo.getId()%>"/>
            <input type="hidden" name="acao" id="acao" value="Excluir"/>
            <input type="hidden" name="confirmaexclusao" id="confirmaexclusao" value="2"/>
            <h1>Confirma a exclusão definitiva do registro abaixo?</h1>
            <div>
                <label>Descrição</label>
                <label><b><%= objtipo.getDescricao()%></b></label>
            </div>

            <div>
                <input type="submit" name="btnconfirma" id="btnconfirma" value="Confirma"/>   
            </div>

        </form>

    </body>
</html>
