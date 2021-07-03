<?php
require_once("conex.inc");
require_once("validacoes.inc");

$nome=$_POST['txtNome'];
$sobrenome=$_POST['txtSobrenome'];
$email = $_POST['txtEmail'];
$tel=$_POST['txtTelefone'];
$msg=$_POST['txtMensagem'];
$flag=false;
$erros="";

if(empty($nome)){
    $erros .= "Nome, ";
    $flag = true;
}
if(empty($sobrenome)){
    $erros .= "Sobrenome, ";
    $flag = true;
}
if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
    $erros .= "Email, ";
    $flag = true;
}
if (!validaTelefone($tel)) {
    $erros .= "Telefone, ";
    $flag = true;
}
if(empty($msg)){
    $erros .= "Mensagem ";
    $flag = true;
}
if ($flag == true) {
    echo "<script>alert('O(s) seguinte(s) campo(s) não foi(ram) preenchido(s) corretamente: $erros !');location.href=\"contato.php\"</script>";
} else {
    $sql2 = "insert into mensagem (nome,sobrenome,email,telefone,mensagem,data) values ('$nome','$sobrenome','$email','$tel','$msg', current_timestamp);";
    $res = pg_query($sql2);

    if (pg_affected_rows($res) == 1) {
        echo "<script>alert('Mensagem enviada com sucesso, entraremos em contato o mais rapido o possivel!');location.href=\"index.php\";</script>";
    } else {
        echo "<script>alert('Erro ao enviar mensagem!');</script>";
    }
}
pg_close($conexao);
?>