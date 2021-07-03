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
        <title>Quem Somos</title>
        <meta charset="UTF-8">
        <link href="css/estilo.css" rel="stylesheet" type="text/css"/>
        <link href="css/quemSomos.css" rel="stylesheet" type="text/css"/>
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
        <div class="separador">
            <span></span>
            <h2>Quem nós somos?</h2>
            <span></span>
        </div>
        <div class="container">
            <div class="info-img-left">
                <img src="imgs/quemSomos/info-mi.jpg" alt="Info"/>
            </div>
            <div class="info-texto">
                <h3>Nosso Logo</h3>  
                <p>O "Mi" em nosso logotipo significa "Mobile Internet".</p>
            </div>
        </div>
        <div class="container">
        <div class="info-img-right">
            <img src="imgs/quemSomos/historia-mi.jpg" alt="História"/>
        </div>
        <div class="info-historia">
            <h3>Nossa História</h3>  
            <p>A Xiaomi foi fundada em 2010. A Xiaomi e MI são duas empresas diferentes. No entanto, elas produzem a MI e Redmi em colaboração entre si. O logo "MI" da Xiaomi é uma abreviação de "Mobile Internet" (internet móvel) desde que a Xiaomi foi fundada para ser a primeira empresa de tecnologia móvel. A Xiaomi tem um total de 15.222 funcionários em tempo integral. A maioria está baseada em Pequim, na China continental, enquanto os outros estão divididos entre Índia, Taiwan, Indonésia e Hong Kong.</p>
        </div>
        </div>
        <div class="container">
            <div class="img-mercado">
                <img src="imgs/quemSomos/xiaomi-mercado.jpg" alt="Mercado Internacional"/>
            </div>
            <div class="info-texto">
                <h3>Nosso lugar no mercado internacional</h3>  
                <p>Terceira maior distribuidora de smartphones do mundo, a Xiaomi projeta, desenvolve e vende celulares, aplicativos móveis e eletrônicos de consumo. Desde o lançamento de seu primeiro smartphone em agosto de 2011, a empresa ganhou participação de mercado na China continental e expandiu-se ao desenvolvimento de uma ampla gama de produtos eletrônicos de consumo, incluindo um dispositivo de ecossistema para casas inteligentes. O fundador e diretor executivo da empresa é Lei Jun, a 6ª pessoa mais rica da China, segundo a Forbes. A empresa vendeu mais de 60 milhões de telefones celulares em 2014.</p>
            </div>
        </div>
        <div class="container">
        <div class="info-img-right">
            <img src="imgs/quemSomos/estrutura-mi.jpg" alt="Estrutura"/>
        </div>
        <div class="info-historia">
            <h3>Nossa Estrutura</h3>  
            <p>A Xiaomi tem mais de 5 000 funcionários, principalmente na China, Malásia, e Singapura, e está se a expandir mundialmente, como Índia e Indonésia, e nas Filipinas. De acordo com a IDC, a companhia hoje é o terceiro maior fabricante de smartphones do mundo, seguido pela Lenovo e LG em quarto e quinto lugar, respectivamente. A Samsung permanece em primeiro lugar, apesar da diminuição do volume de embarque, seguida pela Apple Inc. em segundo lugar. Xiaomi também se tornou o maior fornecedor de smartphones do mundo em 2014, tendo ultrapassado a Samsung, de acordo com um relatório da IDC.</p>
        </div>
        </div>
        <div class="container">
            <div class="img-mercado">
                <img src="imgs/quemSomos/mi-conquista.jpg" alt="Conquistando o mundo"/>
            </div>
            <div class="info-texto">
                <h3>Nossa maior conquista!</h3>  
                <p>No final de Novembro de 2014, a Xiaomi se tornou a empresa recém-lançada de tecnologia mais valiosa do mundo depois de ter recebido 4.1 bilhões de dólares de financiamento por parte dos investidores, fazendo com que valorizasse para mais de 46 bilhões de dólares. Em 2017, a Xiaomi foi eleita pelo ranking BrandZ como a 5ª marca chinesa com maior presença global, atrás da Lenovo, Huawei, Alibaba e Elex Tech.</p>
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
