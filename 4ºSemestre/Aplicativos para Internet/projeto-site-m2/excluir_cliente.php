<?php
include "conex.inc";

$id=$_GET["id_cliente"];
$id_usu=$_GET["id_usuario_fk"];

$sql2="delete from pessoa where id='$id'";
$result2= pg_query($sql2);

$sql="delete from usuario where id='$id_usu'";
$result= pg_query($sql);

if(pg_affected_rows($result)==1 && pg_affected_rows($result2)==1){
    echo "<script>alert('Cliente de id:$id excluido com sucesso!');location.href=\"lista_cliente.php\";</script>";
}else {
    echo "Falha na operação de exclusão!";
}
pg_close($conexao);
?>