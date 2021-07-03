<?php
require_once('conex.inc');
$usuario=$_SESSION['usuario'];
$result=pg_query("select * from pessoa where id_usuario_fk=$usuario[id]");
$dados=pg_fetch_assoc($result);

$pessoa = array("id"=>$dados['id'],"nome"=>$dados['nome'],"sobrenome"=>$dados['sobrenome'],"telefone"=>$dados['telefone']);
$_SESSION['pessoa']=$pessoa;
?>