<?php
session_start();
if (isset($_SESSION['usuario'])) {
    require_once('conex.inc');
    $usuario = $_SESSION['usuario'];
    require_once('pessoa.php');
    $pessoa = $_SESSION['pessoa'];
}
$result = pg_query("select * from mensagem;");
?>
<!DOCTYPE html>
<html>

<head>
    <title>Mensagens</title>
    <meta charset="UTF-8">
    <link href="css/lista_cliente.css" rel="stylesheet" type="text/css" />
    <link href="css/estilo.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="imgs/favicon.ico" rel="shortcut icon" type="image/x-icon">
</head>

<body>
    <nav id="menu">
        <header id="logo">
            <a href="index.php"><img src="imgs/Xiaomi_logo.png" alt="Logo Xiaomi Brasil" /></a>
            <div class="autent">
                <img src="imgs/usuario.png" alt="Login" class="img-user">
            </div>
            <?php if (isset($_SESSION['usuario'])) {
                echo "<p>Olá, $pessoa[nome] , seja bem-vindo!<BR><a href='atualiza_cliente.php?id_cliente=$pessoa[id]'><button class='btn-conta'>Minha Conta</button></a><a href='sair.php'><button class='btn-sair'>Sair</button></a>" . (($usuario['perfil'] == 1) ? "<a href='lista_cliente.php'><button class='btn-conta'>Gerenciar</button></a></p>" : "</p>");
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
    <div class='limiter'>
        <div class='container-table100'>
            <div class='wrap-table100'>
            <a href="Lista_cliente.php" style="text-decoration:none; color:white;"><button id="btnCalc">Lista de Clientes</button></a>
                <div class='table100'>
                
                    <table border="1">
                        <thead>
                            <tr>
                                <td colspan=7>
                                    <h1>Mensagens Recebidas</h1>
                                </td>
                            </tr>
                            <tr>
                                <td>Excluir</td>
                                <td>Id</td>
                                <td>Nome</td>
                                <td>Email</td>
                                <td>Telefone</td>
                                <td>Mensagem</td>
                                <td>Data</td>
                            </tr>
                        </thead>
                        <tbody>
                            <?php
                            while ($mensagem = pg_fetch_assoc($result)) {

                                echo "<tr>";
                                echo "<td><a href='excluir_mensagem.php?id_mensagem=$mensagem[id]' style='text-decoration:none; color:white;'><button id='btnCalc'>Excluir</button></a></td>";
                                echo "<td>" . $mensagem['id'] . "</td>";
                                echo "<td>" . $mensagem['nome'] . " " . $mensagem['sobrenome'] . "</td>";
                                echo "<td>" . $mensagem['email'] . "</td>";
                                echo "<td>" . $mensagem['telefone'] . "</td>";
                                echo "<td>" . $mensagem['mensagem'] . "</td>";
                                echo "<td>" . $mensagem['data'] . "</td>";
                                echo "</tr>";
                            }
                            pg_close($conexao);
                            ?>
                        </tbody>
                    </table>
                        
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