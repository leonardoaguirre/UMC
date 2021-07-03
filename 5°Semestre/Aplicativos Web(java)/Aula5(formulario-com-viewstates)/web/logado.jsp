<%-- 
    Document   : logado
    Created on : 18/02/2020, 21:51:15
    Author     : Leonardo
--%>

<%@page import="Modelo.Sexo"%>
<%@page import="Modelo.TipoSanguineo"%>
<%@page import="java.util.ArrayList"%>
<%@page import="Modelo.Usuario"%>

<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
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
            <h1>Olá Seja bem vindo, <%= obj.login%>. Complete já o seu cadastro!!</h1>
            <%/*
            ArrayList<Sexo> arr = new ArrayList<Sexo>();
            arr = (ArrayList<Sexo>) session.getAttribute("arrSexo");
            ArrayList<TipoSanguineo> arr2 = new ArrayList<TipoSanguineo>();
            arr2 = (ArrayList<TipoSanguineo>) session.getAttribute("arrTipoSanguineo");
            */
            %>
        <form action="<%= application.getContextPath()%>/controleAcesso">
            <div>
                <label>Nome:</label><input type="text" name="txtnome" id="txtnome" value="${nomeviewstate}"/>
            </div>
               <div>
                <label>Sexo:</label>
                <select name="cmbsexo" id="cmbsexo" >
                     <c:if test="${sexoviewstate == null}">
                        <option value="0" selected="selected">Selecione um sexo</option>
                    </c:if>
                        <c:if test="${sexoviewstate != null}">
                            <option value="${valuesexoviewstate}" selected="selected">${sexoviewstate}</option>
                        </c:if>
                    <c:forEach var="sexo" items="${arrSexo}">
            <option value="${sexo.id}">${sexo.descricao}</option>
            </c:forEach>
                    <%
                       //for (Sexo objsexo : arr){
                            %>
<!--                            <option value="<%//= objsexo.getId() %>"><%//= objsexo.getDescricao() %></option>-->
                          <%
                        //}
                        %>
                </select>
            </div>
                <div>
                    <label>Tipo sanguineo:</label>
                <select name="cmbTipoSanguineo" id="cmbTipoSanguineo">
                    <c:if test="${tiposanguineoviewstate == null}">
                        <option value="0" selected="selected">Selecione um Tipo Sanguineo</option>
                    </c:if>
                        <c:if test="${tiposanguineoviewstate != null}">
                            <option value="${valuetiposanguineoviewstate}" selected="selected">${tiposanguineoviewstate}</option>
                        </c:if>
                    <c:forEach var="tipoSanguineo" items="${arrTipoSanguineo}">
            <option value="${tipoSanguineo.id}">${tipoSanguineo.tipo}</option>
            </c:forEach>
                    <%
                        //for (TipoSanguineo objtipo : arr2){
                            %>
<!--                            <option value="<%//= objtipo.getId() %>"><%//= objtipo.getTipo() %></option>-->
                            <%
                        //}
                        %>
                </select>
                </div>
                <div>
                <label>Estado:</label>
                <select name="cmbestado" id="cmbestado" onchange="this.form.submit();">
                    <c:if test="${estadoviewstate == null}">
                        <option value="0" selected="selected">Selecione um estado</option>
                    </c:if>
                        <c:if test="${estadoviewstate != null}">
                            <option value="${valueestadoviewstate}" selected="selected">${estadoviewstate}</option>
                        </c:if>
                    <c:forEach var="estado" items="${arrEstado}">
                        <option value="${estado.id}">${estado.nome}</option>                      
                    </c:forEach>
                </select>
            </div>
            <div>
                <label>Cidade:</label>
                <select name="cmbcidade" id="cmbcidade">
                    <c:forEach var="cidade" items="${arrCidade}">
                        <option value="${cidade.id}">${cidade.nome}</option>                      
                    </c:forEach>
                </select>
            </div>
                <div>
                    <input type="submit" name="btngravar" id="btngravar" value="Gravar"/>
                </div>
        </form>
    </body>
</html>
