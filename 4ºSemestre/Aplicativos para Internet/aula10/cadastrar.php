<?php
include "conex.inc";

$nome = $_POST["txtNome"];
$cpf=$_POST["txtCpf"];
$tel=$_POST["txtTel"];
$end=$_POST["txtEnd"];

$sql="insert into cliente(cpf,nome,telefone,endereco) values ('$cpf','$nome','$tel','$end');";

pg_query($sql);
pg_close($conexao);

echo "Cliente cadastro com sucesso!";
//header("Location: lista_cadastro.php");
?>