<?php
header("Content-type: text/html; charset:utf-8");
include "conex.inc";

$id=$_POST["id_cliente"];
$nome=$_POST["txtNome"];
$cpf=$_POST["txtCpf"];
$telefone=$_POST["txtTel"];
$endereco=$_POST["txtEnd"];

$sql="Update cliente set cpf='$cpf', nome='$nome', telefone='$telefone', endereco='$endereco' where id=$id;";

$result = pg_query($sql);
$linhas=pg_affected_rows($result);
echo "<link href='estilo.css' rel='stylesheet' type='text/css'/>";
if($linhas==1){  
    echo "Cliente atualizado com sucesso!</br>";
    echo "<a href='lista_cadastro.php' style='text-decoration:none; color:white;'><button id='btnCalc'>Voltar a lista</button></a>";
}else {
    echo "Falha na operação alterar!";
}
pg_close($conexao);
?>