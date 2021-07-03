<%-- 
    Document   : logado
    Created on : 18/02/2020, 21:51:15
    Author     : Leonardo
--%>

<%@page import="Modelo.Usuario"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link href="estilo.css" rel="stylesheet" type="text/css"/>
        <%
            Usuario obj = new Usuario();
            obj = (Usuario) session.getAttribute("usu");
        %>
        <title>Logado com Sucesso!</title>
    </head>
    <body>
            <h1>Olá Seja bem vindo, <%= obj.login%> !</h1>
    </body>
</html>
