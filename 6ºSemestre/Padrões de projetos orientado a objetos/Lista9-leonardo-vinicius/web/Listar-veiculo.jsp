<%-- 
    Document   : Listar-veiculo
    Created on : 16/11/2020, 15:32:09
    Author     : Leonardo
--%>

<%@page import="java.util.ArrayList"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%@page isELIgnored ="false" %> 
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Listar veiculo</title>
    </head>
    <body>
        <h1>Listando veiculos!</h1>
        <table border="1">
            <thead>
                <tr>
                    <td>Marca</td>
                    <td>Modelo</td>
                    <td>Ano de Fabricação</td>
                    <td>Descrição</td>
                </tr>

            </thead>
            <tbody>
            <c:forEach var="veiculo" items="${listaDeVeiculos}">
                <tr>
                    <td><c:out value="${veiculo.marca}"></c:out></td>
                    <td><c:out value="${veiculo.modelo}"></c:out></td>
                    <td><c:out value="${veiculo.anoFabricacao}"></c:out></td>
                    <td><c:out value="${veiculo.descricao}"></c:out></td>
                </tr>
            </c:forEach>
        </tbody>
    </table>
        <a href="index.html"><button>Cadastrar um novo</button></a>
</body>
</html>
