<?php
require_once("conex.inc");
require_once("validacoes.inc");

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
if (empty($nome)) {
    $erros .= "Nome, ";
    $flag = true;
}
if (empty($sobrenome)) {
    $erros .= "Sobrenome, ";
    $flag = true;
}
if (empty($rua)) {
    $erros .= "Rua, ";
    $flag = true;
}
if (empty($num)) {
    $erros .= "Numero, ";
    $flag = true;
}
if (!filter_var($login, FILTER_VALIDATE_EMAIL)) {
    $erros .= "Email(login), ";
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
    echo "<script>alert('O(s) seguinte(s) campo(s) não foi(ram) preenchido(s) corretamente: $erros !');location.href=\"cadastro_cliente.html\"</script>";
} else {
    $sql2 = "insert into usuario (login,senha,perfil) values ('$login','$senha',2) returning id;";
    $res = pg_query($sql2);
    $usu = pg_fetch_assoc($res);

    $sql = "insert into pessoa(nome,sobrenome,rg,cpf,telefone,cep,rua,numero,id_usuario_fk) values ('$nome','$sobrenome','$rg','$cpf','$tel','$cep','$rua','$num',$usu[id]);";
    $linha = pg_query($sql);
    pg_close($conexao);
    if (pg_affected_rows($linha) == 1 && pg_affected_rows($res) == 1) {
        echo "<script>alert('Cliente cadastrado com sucesso. Olá $nome, seja bem vindo a Xiaomi Brasil!!');location.href=\"index.php\";</script>";
    } else {
        echo "<script>alert('Erro ao cadastrar cliente!');</script>";
    }
}
