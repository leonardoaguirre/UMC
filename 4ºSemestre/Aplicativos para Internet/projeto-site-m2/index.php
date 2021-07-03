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
        <title>Home</title>
        <meta charset="UTF-8">
        <link href="css/estilo.css" rel="stylesheet" type="text/css"/>
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
        <div class="banner">
            <div class="img-banner">
                <h1>Bem vindo a Xiaomi Brasil!</h1>
                <img src="imgs/mix-alpha.jpg" alt="Mi Mix Alpha"/>
            </div>
        </div>
        <div class="separador">
            <span class="linha"></span>
            <h2>Videos</h2>
            <span class="linha"></span>
        </div>
        <div class="grid-videos">
            <ul>
                <li>  <iframe src="https://www.youtube.com/embed/2N9d5AjChi0" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe></li>
                <li><iframe src="https://www.youtube.com/embed/OlZpjn0o4AA" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe></li>
                <li><iframe src="https://www.youtube.com/embed/C6jy6N9_aBA" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe></li>
            </ul>
            <ul>
                <li><iframe src="https://www.youtube.com/embed/Zi9kWmgcvv8" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe></li>
                <li><iframe src="https://www.youtube.com/embed/ewrcHeQbmJE" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe></li>
                <li><iframe src="https://www.youtube.com/embed/gbPAPLqJtTA" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe></li>
            </ul>
            <ul>
                <li><iframe src="https://www.youtube.com/embed/n-I4W9oTH2M" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe></li>
                <li><iframe src="https://www.youtube.com/embed/QqrC5uLl2ik" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe></li>
                <li><iframe src="https://www.youtube.com/embed/MRW3zN0Zgww" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe></li>
            </ul>
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
