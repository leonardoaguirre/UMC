<?php
$st_conexao= "host=localhost port=5432 dbname=db_xiaomi user=postgres password=postgres";

$conexao= pg_connect($st_conexao);
if($conexao==false){
    echo "A conexão com o banco de dados falhou";
}
?>