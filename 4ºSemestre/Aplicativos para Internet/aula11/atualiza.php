<?php
include "conex.inc";
$id_cliente=$_GET["id_cliente"];
$sql="select * from cliente where id=$id_cliente";
$result= pg_query($sql);
$cliente= pg_fetch_assoc($result);

pg_close($conexao);
?>
<!DOCTYPE html>
<html>
    <head>
        <title>Atualizar</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link href="estilo.css" rel="stylesheet" type="text/css"/>
        <link href="https://fonts.googleapis.com/css?family=Roboto+Condensed&display=swap" rel="stylesheet">
    </head>
    <body>
        <div class="panel-principal">
            <div class="titulo">
                <h1>Atualizar</h1>
            </div>
            <div class="linha"></div>
            <form action="atualiza_cliente.php" method="POST">
                <div class="inputs">     
                <div class="entr">
                        <input type="hidden" name="id_cliente" value="<?php print($cliente['id'])?>">
                    </div>           
                    <div class="entr">
                        <p>Nome:<input type="text" name="txtNome" value="<?php print($cliente['nome'])?>"></p>
                    </div>
                    <div class="entr">
                        <p>CPF:<input type="text" name="txtCpf" value="<?php print($cliente['cpf'])?>"></p>
                    </div>
                    <div class="entr">
                        <p>Telefone:<input type="text" name="txtTel" value="<?php print($cliente['telefone'])?>"></p>
                    </div>
                    <div class="entr">
                        <p>Endereço:<input type="text" name="txtEnd" value="<?php print($cliente['endereco'])?>"></p>
                    </div>
                    <div>
                        <input type="submit" value="Cadastrar" id="btnCalc">
                    </div>
                </div>
            </form>
            </div>
        </div>
    </body>
</html>