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
        <title>Consultar Tipo</title>
    </head>
    <body>

        <%

            Tipo objtipo = new Tipo();
            objtipo = (Tipo) request.getSession().getAttribute("tipo"); //aqui pega o objeto tipo que esta na sessão

        %>

        <form method="Post" action="/padraocommand/ControleTipo?acao=Listar">
          
            <div>
                <label>Descrição : <b><%= objtipo.getDescricao()%></b></lable>
            </div>           
            <input type="submit" value="Voltar a lista" >
        </form>

    </body>
</html>
