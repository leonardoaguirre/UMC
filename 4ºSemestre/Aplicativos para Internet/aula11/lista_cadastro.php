<?php
include "conex.inc";
$result = pg_query("select * from cliente;");
?>
<!DOCTYPE html>
<html>
<head>
<title>Gestão De Clientes</title>
<meta charset="UTF-8">
<link href="estilo.css" rel="stylesheet" type="text/css"/>
</head>
<body>
        <h1>Clientes cadastrados</h1>
        <div class='limiter'>
            <div class='container-table100'>
                <div class='wrap-table100'>
                    <div class='table100'>
        <table border="1">
            <thead>
            <tr>
                <td>Atualizar</td>
                <td>Excluir</td>
                <td>Nome</td>
                <td>Telefone</td>
                <td>Endereco</td>
            </tr>
                </thead>
                <tbody>
                    <tr>
                <?php

                while($cliente = pg_fetch_assoc($result)){
                  
                    echo "<tr>";
                    echo "<td><a href='atualiza.php?id_cliente=$cliente[id]' style='text-decoration:none; color:white;'><button id='btnCalc'>Atualizar</button></a></td>";
                    echo "<td><a href='exclui_cliente.php?id_cliente=$cliente[id]' style='text-decoration:none; color:white;'><button id='btnCalc'>Excluir</button></a></td>";
                    
                    echo "<td>".$cliente['nome']."</td>";
                    echo "<td>".$cliente['telefone']."</td>";
                    echo "<td>".$cliente['endereco']."</td>";
                    echo "";
                }
                pg_close($conexao);
                ?>
                 </tr>
                </tbody>
           
        </table>
        </div>
    </div>
</div>
</div>
        <table>
        <a href="cadastro.html" style="text-decoration:none; color:white;"><button id="btnCalc">Cadastrar novo cliente</button></a>
        </table>
</body>
</html>