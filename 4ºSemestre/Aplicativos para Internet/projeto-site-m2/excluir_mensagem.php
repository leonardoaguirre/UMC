<?php
include "conex.inc";

$id=$_GET["id_mensagem"];

$sql2="delete from mensagem where id='$id'";
$result= pg_query($sql2);

if(pg_affected_rows($result)==1){
    echo "<script>alert('Mensagem de id:$id excluida com sucesso!');location.href=\"lista_mensagem.php\";</script>";
}else {
    echo "Falha na operação de exclusão!";
}
pg_close($conexao);
?>