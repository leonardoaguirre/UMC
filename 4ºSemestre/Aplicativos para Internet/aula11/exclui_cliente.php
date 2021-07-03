<?php
include "conex.inc";

$id=$_GET["id_cliente"];

$sql="delete from cliente where id='$id'";

$result= pg_query($sql);

$linhas=pg_affected_rows($result);

if($linhas ==1){
    header("Location: lista_cadastro.php");
}else {
    echo "Falha na operação de exclusão";
}
pg_close($conexao);
?>