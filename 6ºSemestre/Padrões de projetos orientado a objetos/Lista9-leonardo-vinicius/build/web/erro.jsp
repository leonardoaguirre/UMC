<%-- 
    Document   : erro
    Created on : 16/11/2020, 15:31:29
    Author     : Leonardo
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Erro</title>
    </head>
    <body>
        <h1>Erro!</h1>
        <% String erro = (String)request.getAttribute("erroMsg"); %>
        ${erro}
    </body>
</html>
