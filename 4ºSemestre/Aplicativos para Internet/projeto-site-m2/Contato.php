<?php
session_start();
if (isset($_SESSION['usuario'])) { 
$usuario=$_SESSION['usuario'];
require_once('conex.inc');
require_once('pessoa.php');
$pessoa=$_SESSION['pessoa'];
}
?>
<!DOCTYPE html>
<html>
    <head>
        <title>Contato</title>
        <meta charset="UTF-8">
        <link href="css/estilo.css" rel="stylesheet" type="text/css"/>
        <link href="css/contato.css" rel="stylesheet" type="text/css"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
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
        <div class="form-contato">
            <div class="borda-form">
                <form method="post" action="enviar_msg.php">
                    <span class="letra">
                        Contate-nos
                    </span>
                    <div class="label-div"><label class="label-input" for="first-name">Seu Nome</label></div>
                    <div class="container-input">
                        <input id="first-name" class="input" type="text" name="txtNome" placeholder="Primeiro Nome" value="<?php if(isset($_SESSION['usuario'])){ print($pessoa['nome']);} ?>" readonly="<?php if(isset($_SESSION['usuario'])){ print('true');}else{print('false');} ?>">
                    </div>
                    <div class="container-input">
                        <input class="input" type="text" name="txtSobrenome" placeholder="Sobrenome" value="<?php if(isset($_SESSION['usuario'])){ print($pessoa['sobrenome']);} ?>" readonly="<?php if(isset($_SESSION['usuario'])){ print('true');}else{print('false');} ?>">
                    </div>
                    <div class="label-div"><label class="label-input" for="email">Email</label></div>
                    <div class="container-input">
                        <input id="email" class="input" type="text" name="txtEmail" placeholder="exemplo@email.com" value="<?php if(isset($_SESSION['usuario'])){ print($usuario['login']);} ?>" readonly="<?php if(isset($_SESSION['usuario'])){ print('true');}else{print('false');} ?>">
                    </div>
                        <div class="label-div"><label class="label-input" for="phone">Numero de telefone</label></div>
                    <div class="container-input">
                        <input id="phone" class="input" type="text" name="txtTelefone" placeholder="Ex:(11)91234-5789" value="<?php if(isset($_SESSION['usuario'])){ print($pessoa['telefone']);} ?>" readonly="<?php if(isset($_SESSION['usuario'])){ print('true');}else{print('false');} ?>">
                    </div>
                    <label class="label-input" for="message">Messagem</label>
                    <div class="container-input">
                        <textarea id="message" class="input" name="txtMensagem"  placeholder="Escreva aqui a sua mensagem"></textarea>
                    </div>
                    <div class="container-form-btn">
                        <button class="form-btn">
                            <span>
                                Enviar
                            </span>
                        </button>
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
