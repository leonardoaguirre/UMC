<?php
require_once("conex.inc");
session_start();

$login=$_POST['txtLogin'];
$senha=$_POST['txtSenha'];

if(empty($login)){
    $_SESSION['mensagem']="Preencha o campo Login";
    header("location: login.php");
}elseif (empty($senha)) {
    $_SESSION['mensagem']="Preencha o campo Senha";
    header("location: login.php");
}else {
    $sql="select * from usuario where login='$login' and senha='$senha';";
    $result=pg_query($sql);
    $dados=pg_fetch_assoc($result);

    if ($dados['login']==$login && $dados['senha']==$senha) {
        $usuario = array("login"=>$dados['login'], "senha"=>$dados['senha'], "perfil"=>$dados['perfil'],"id"=>$dados['id']);
        $_SESSION['usuario']=$usuario;

        if ($dados['perfil']==1) {
           header("location: lista_cliente.php");
        }else {
            echo "<script>alert('Olá seja bem vindo novamente!');location.href=\"index.php\";</script>";
        }
        
    }else{
        $_SESSION['mensagem']="Login ou senha invalidos!";
        header("location: login.php");
    }
}
?>