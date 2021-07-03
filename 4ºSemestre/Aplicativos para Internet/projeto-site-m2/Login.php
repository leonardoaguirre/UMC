<!DOCTYPE html>
<html>

<head>
    <title>Autenticação de Usuario</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="css/estilo.css" rel="stylesheet" type="text/css" />
    <link href="css/cliente_cadastro.css" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/css?family=Roboto+Condensed&display=swap" rel="stylesheet">
    <link href="imgs/favicon.ico" rel="shortcut icon" type="image/x-icon">
    <link rel="stylesheet" type="text/css" href="css/login.css">
</head>

<body>
    <nav id="menu">
        <header id="logo">
            <a href="index.html"><img src="imgs/Xiaomi_logo.png" alt="Logo Xiaomi Brasil" /></a>
        </header>
        <ul>
            <li><a href="index.html">Home</a></li>
            <li><a href="Lancamentos.html">Lançamentos</a></li>
            <li><a href="QuemSomos.html">Quem Somos</a></li>
            <li><a href="Loja.html">Loja</a></li>
            <li><a href="Contato.html">Contato</a></li>
        </ul>
    </nav>
    <div class="limiter">
        <div class="container-login100">
            <div class="wrap-login100 p-t-50 p-b-90">
                <form class="login100-form validate-form flex-sb flex-w" method="post" action="logar.php">
                    <span class="login100-form-title p-b-51">
                        Login
                    </span>
                    <div class="wrap-input100 validate-input m-b-16">
                        <input class="input100" type="text" name="txtLogin" placeholder="Email">
                        <span class="focus-input100"></span>
                    </div>
                    <div class="wrap-input100 validate-input m-b-16">
                        <input class="input100" type="password" name="txtSenha" placeholder="Senha">
                        <span class="focus-input100"></span>
                    </div>
                    <div class="container-login100-form-btn m-t-17">
                        <button class="login100-form-btn">
                            Login
                        </button>
                    </div>
                    <?php
                    session_start();
                    if (isset($_SESSION['mensagem'])){
                        $msg =$_SESSION['mensagem'];
                        echo "<p style='color:red; text-align:center;'>$msg</p>";
                        unset($_SESSION['mensagem']);
                    }
                        ?>
                        </form>
                    <div class="container-cadastrar100-form-btn m-t-17">
                            <button class="cadastrar100-form-btn" onclick="window.location.href ='cadastro_cliente.html'">
                                Cadastrar-se
                        </button>
                    </div>          
            </div>
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