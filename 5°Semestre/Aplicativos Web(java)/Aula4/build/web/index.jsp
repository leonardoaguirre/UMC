<%-- 
    Document   : index
    Created on : 13/02/2020, 09:43:21
    Author     : alunocmc
--%>

<%@page import="Modelo.Usuario"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Login</title>
        <link href="estilo.css" rel="stylesheet" type="text/css"/>
        <link href="https://fonts.googleapis.com/css?family=Roboto&display=swap" rel="stylesheet">
    </head>
    <body>
        <!-- Scriptlet -->
        <%
            String aviso = "";
            if (session.getAttribute("msg") != null) {
                try {
                    Usuario obj = new Usuario();
                    obj = (Usuario) session.getAttribute("msg");
                    aviso = obj.login;
                } catch (Exception ex) {
                    //
                }
            }

        %>

        <form action="<%= application.getContextPath()%>/controleAcesso" method="POST">
            <h1>
                Entrar
            </h1>
            <div class="label">
                <label>Login:</label>
            </div>
            <div class="input">
                <input type="text" name="txtLogin" id="txtLogin" placeholder="Digite seu username aqui"/>
            </div>
            <div class="label">
                <label>Senha:</label>
            </div>
            <div class="input">
                <input type="password" name="txtSenha" id="txtSenha" placeholder="Digite sua senha aqui"/>
            </div>
            <div class="aviso">
                <span><%= aviso%></span>
            </div>
            <div>
                <input type="submit" name="btnEnviar" id="btnEnviar" value="Enviar" class="botao"/>
            </div>
        </form>
    </body>
</html>
