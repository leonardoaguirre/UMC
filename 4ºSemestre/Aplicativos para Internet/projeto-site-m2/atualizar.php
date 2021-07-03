<?php 
session_start();
require_once("conex.inc");
require_once("validacoes.inc");

$pessoa =$_SESSION['usuario'];

$id_usu = $pessoa['id'];
$id_cli = $_POST["id_cliente"];
$nome = $_POST["txtNome"];
$sobrenome = $_POST["txtSobrenome"];
$rg = $_POST["txtRg"];
$cpf = $_POST["txtCpf"];
$tel = $_POST["txtTel"];
$cep = $_POST["txtCep"];
$rua = $_POST["txtRua"];
$num = $_POST["txtNum"];
$login = $_POST["txtLogin"];
$senha = $_POST['txtSenha'];
$confSenha = $_POST["txtConfSenha"];
$erros = "";
$flag = false;

if ($senha != $confSenha) {
    $erros .= "As senhas estão divergentes, ";
    $flag = true;
}
if (!isset($_POST['ckbTermos'])) {
    $erros .= "Não aceitou os termos, ";
    $flag = true;
}
if (!filter_var($login, FILTER_VALIDATE_EMAIL)) {
    $erros .= "Email(login), ";
    $flag = true;
}
if(empty($nome)){
    $erros .= "Nome, ";
    $flag = true;
}
if(empty($sobrenome)){
    $erros .= "Sobrenome, ";
    $flag = true;
}
if(empty($rua)){
    $erros .= "Rua, ";
    $flag = true;
}
if(empty($num)){
    $erros .= "Numero, ";
    $flag = true;
}
if (!validaCpf($cpf)) {
    $erros .= "CPF, ";
    $flag = true;
}
if (!validaTelefone($tel)) {
    $erros .= "Telefone, ";
    $flag = true;
}
if (!validaCep($cep)) {
    $erros .= "Cep ";
    $flag = true;
}
if ($flag == true) {
    echo "<script>alert('O(s) seguinte(s) campo(s) não foi(ram) preenchido(s) corretamente: $erros !');location.href=\"Atualiza_cliente.php\"</script>";
} else {
    $sql = "Update pessoa set rg='$rg', cpf='$cpf', nome='$nome', sobrenome='$sobrenome', telefone='$tel', cep='$cep', rua='$rua', numero='$num' where id=$id_cli;";
    $sql2 = "Update usuario set login='$login', senha='$senha' where id=$id_usu;";

    $result = pg_query($sql);
    $result2 = pg_query($sql2);

    if (pg_affected_rows($result) == 1 && pg_affected_rows($result2) == 1) {
        echo "<script>alert('Dados atualizados com sucesso!');location.href=\"index.php\";</script>";
    } else {
        echo "Falha na operação alterar!";
    }
}
pg_close($conexao);