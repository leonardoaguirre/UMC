<?php
require_once("conex.inc");
$id_cliente=$_GET["id_cliente"];
$sql="select * from pessoa where id=$id_cliente";
$result= pg_query($sql);
$cliente= pg_fetch_assoc($result);

session_start();
if (isset($_SESSION['usuario'])) { 
$usuario=$_SESSION['usuario'];
require_once('pessoa.php');
$pessoa=$_SESSION['pessoa'];
}
$usu= pg_fetch_assoc(pg_query("select * from usuario where id=$cliente[id_usuario_fk]"));
pg_close($conexao);
?>
<!DOCTYPE html>
<html>
    <head>
        <title>Atualização de cadastro</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link href="css/estilo.css" rel="stylesheet" type="text/css"/>
        <link href="css/cliente_cadastro.css" rel="stylesheet" type="text/css"/>
        <link href="https://fonts.googleapis.com/css?family=Roboto+Condensed&display=swap" rel="stylesheet">
        <link href="imgs/favicon.ico" rel="shortcut icon" type="image/x-icon">
    </head>
    <body>
    <nav id="menu">
    <header id="logo"> 
                <a href="index.php"><img src="imgs/Xiaomi_logo.png" alt="Logo Xiaomi Brasil"/></a>   
                <div class="autent"> 
                        <img src="imgs/usuario.png" alt="Login" class="img-user">
                    </div>
                    <?php if (isset($_SESSION['usuario'])) {
                        echo "<p>Olá, $pessoa[nome] , seja bem-vindo!<BR><a href='atualiza_cliente.php?id_cliente=$pessoa[id]'><button class='btn-conta'>Minha Conta</button></a><a href='sair.php'><button class='btn-sair'>Sair</button></a>".(($usuario['perfil']==1)?"<a href='lista_cliente.php'><button class='btn-conta'>Gerenciar</button></a></p>":"</p>");
                       } else {
                        ?>
                    <div class="btn-entrar">
                            <a href="login.php">
                                    <button class="login100-form-btn">
                                        Entrar
                                    </button>
                                </a>
                    </div>  
                    <?php } ?>      
            </header>
            <ul>
                <li><a href="index.php">Home</a></li>
                <li><a href="Lancamentos.php">Lançamentos</a></li>
                <li><a href="QuemSomos.php">Quem Somos</a></li>
                <li><a href="Loja.php">Loja</a></li>
                <li><a href="Contato.php">Contato</a></li>
            </ul>
        </nav>
                <div class="background">
        <div class="panel-principal">
            <div class="titulo">
                <h1>Atualizar Dados</h1>
            </div>
            <div class="linha"></div>
            <form action="atualizar.php" method="POST">
                <div class="inputs">
                        <div class="sessao"><span>1</span>Como deseja ser chamado?</div>                
                    <div class="entr">
                    <input type="hidden" name="id_cliente" value="<?php print($cliente['id'])?>">
                        <label>Nome:<input type="text" name="txtNome" value="<?php print($cliente['nome']) ?>"></label>
                    </div>
                    <div class="entr">
                            <label>Sobrenome:<input type="text" name="txtSobrenome" value="<?php print($cliente['sobrenome']) ?>"></label>
                        </div>
                </div>
                        <div class="inputs">
                                <div class="sessao"><span>2</span>Dados de documentos</div> 
                    <div class="entr">
                        <label>CPF:<input type="text" name="txtCpf" value="<?php print($cliente['cpf']) ?>"></label>
                    </div>
                    <div class="entr">
                            <label>RG:<input type="text" name="txtRg" value="<?php print($cliente['rg']) ?>"></label>
                        </div>
                    </div>
                    <div class="inputs">
                            <div class="sessao"><span>3</span>Dados para contato</div> 
                    <div class="entr">
                        <label>Telefone:<input type="text" name="txtTel" value="<?php print($cliente['telefone']) ?>"></label>
                    </div>
                </div>
                <div class="inputs">
                        <div class="sessao"><span>4</span>Dados de cobrança</div> 
                    <div class="entr">
                            <label>CEP:<input type="text" name="txtCep" value="<?php print($cliente['cep']) ?>"></label>
                        </div>
                    <div class="entr">
                        <label>Rua:<input type="text" name="txtRua" value="<?php print($cliente['rua']) ?>"></label>
                    </div>
                    <div class="entr">
                            <label>Numero:<input type="text" name="txtNum" value="<?php print($cliente['numero']) ?>"></label>
                        </div>
                    </div>
                    <div class="inputs">
                        <div class="sessao"><span>5</span>Dados de acesso</div> 
                    <div class="entr">
                    <input type="hidden" name="id_usuario" value="<?php print($usu['id'])?>">
                            <label>Login:<input type="text" name="txtLogin" value="<?php print($usu['login']) ?>"></label>
                        </div>
                    <div class="entr">
                        <label>Senha:<input type="password" name="txtSenha" value="<?php print($usu['senha']) ?>"></label>
                    </div>
                    <div class="entr">
                            <label>Confirmar Senha:<input type="password" name="txtConfSenha" value="<?php print($usu['senha']) ?>"></label>
                        </div>
                    </div>
                    <div>
                        <input type="submit" value="Atualizar" id="btnCalc">
                        <span class="privacy-policy">
                                <input type="checkbox" name="ckbTermos">Você concorda com nossos termos e politicas de privacidade. 
                                </span>
                    </div>
                   </form>
                </div>
            </div>
        <footer class="rodape">
                <div class=" rodape">
                    <img id="logo-rodape" src="imgs/Xiaomi_logo.png" alt="Xiaomi">
                    <b>&COPY;2019 Xiaomi Brasil</b>
                    <nav class="redes">
                        <ul>
                            <li><a href="https://www.facebook.com/XiaomiGlobal/"><img src="imgs/facebook.png" alt="Nosso Facebook"></a></li>
                            <li><a href="https://www.youtube.com/user/XiaomiChina"><img src="imgs/youtube.png" alt="Canal no YouTube"></a></li>
                            <li><a href="https://www.instagram.com/xiaomi.brasil/"><img src="imgs/instagram.png" alt="Perfil no Instagram"></a></li>
                            <li><a href="https://twitter.com/xiaomi"><img src="imgs/twitter.png" alt="Perfil no Twitter"></a></li>
                        </ul>
                    </nav>
                </div>
            </footer>
    </body>
</html>