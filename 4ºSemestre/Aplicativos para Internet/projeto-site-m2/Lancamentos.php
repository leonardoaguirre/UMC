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
        <title>Produtos</title>
        <meta charset="UTF-8">
        <link href="css/estilo.css" rel="stylesheet" type="text/css"/>
        <link href="css/lancamentos.css" rel="stylesheet" type="text/css"/>
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
            <span class="linha"></span>
            <h2>Xiaomi Mi 9</h2>
            <span class="linha"></span>
        </div>
        <div class="div-fotos">
            <div class="container-fotos">
                <ul class="content clearfix">
                    <li class="phone" id="J_colorPreview">
                        <img data-src="https://i01.appmifile.com/webfile/globalimg/products/pc/mi9/phone-1-global.png" src="https://i01.appmifile.com/webfile/globalimg/products/pc/mi9/phone-1-global.png">
                        <img data-src="https://i01.appmifile.com/webfile/globalimg/products/pc/mi9/phone-2-global.png" src="https://i01.appmifile.com/webfile/globalimg/products/pc/mi9/phone-2-global.png">
                        <img data-src="https://i01.appmifile.com/webfile/globalimg/products/pc/mi9/phone-3-global.png" src="https://i01.appmifile.com/webfile/globalimg/products/pc/mi9/phone-3-global.png">
                    </li>
                </ul>
            </div>
        </div>
        <div class="div-info">
            <div class="container">
                <div class="linha">
                    <div class="span5">
                        <h2 class="texto-spec">Processador<br></h2>
                    </div>
                    <div class="span15">
                        <div class="contexto">
                            <h3 class="texto-spec">Processador Qualcomm® Snapdragon™ 855<br></h3>
                            <p>Nome da CPU: Snapdragon™ 855, Processador topo de linha do ano da Qualcomm<br>Arquitetura da CPU: Nova arquitetura Kryo 485 com processo de 7nm<br>Frequência da CPU: Processador Octa-core, até 2.84 GHz<br>Primeiro design trifecta da Qualcomm: 1 núcleo super grande de 2.84GHz + 3 núcleos grandes de 2.42GHz e 1 núcleo pequeno de 1.80GHz<br>Melhoria no desempenho da CPU: 45% de melhoria<br>Melhoria de eficácia: 40%<br>Nome da GPU: Adreno™ 640<br>Melhoria no desempenho da GPU: 20%<br>Melhoria de eficácia: 25%+<br>A primeira GPU de smartphones a suportar o driver gráfico Vulkan 1.1 e pós-processamento de nível cinematográfico<br>Aumento na compressão da largura de banda, processamento de sombras, exibição e renderização real de HDR<br>Edição de desempenho do AIE: A sétima geração do processador AIE com uma IA 3x mais poderosa<br></p>

                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="div-info">
            <div class="container">
                <div class="linha">
                    <div class="span5">
                        <h2 class="texto-spec">Memória<br></h2>
                    </div>
                    <div class="span15">
                        <div class="contexto ">
                            <h3 class="texto-spec">6GB + 128GB<br>                            <span>A maior disponível para o Mi 9</span></h3>
                            <p>RAM: 6GB LPDDR4x 2133MHz dual-channel<br>ROM: Armazenamento flash 64GB/128GB UFS2.1<br></p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="div-info">
            <div class="container">
                <div class="linha">
                    <div class="span5">
                        <h2 class="texto-spec">Tela<br></h2>
                    </div>
                    <div class="span15">
                        <div class="contexto">
                            <h3 class="texto-spec">Tela Infinita* AMOLED Samsung de 6.39"<br></h3>
                            <p>Resolução: 2340 x 1080 FHD+ 403 PPI<br>Brilho: 600nit (HBM) / 430nit (typ)<br>Alto Contraste: 60000:1 (min) | Gama de cores: NTSC 103.8% (typ)<br>Modo padrão | Sunlight display 2.0 | Modo noturno | Ajuste de temperatura de cor | Modo de leitura ajustável com 256 níveis<br>Corning® Gorilla® Glass 6<br>Revestimento protetor anti-oleosidade e anti-impressão digital<br>Suporta HDR display<br></p>
                        </div>
                    </div>
                </div>

            </div>
        </div>
        <div class="div-info">
            <div class="container">
                <div class="linha">
                    <div class="span5">
                        <h2 class="texto-spec">Câmera traseira<br></h2>
                    </div>
                    <div class="span15">
                        <div class="contexto">
                            <h3 class="texto-spec">Câmera tripla ultra grande angular IA Sony de 48MP<br>                            <span>A maior pontuação em fotografia do DxO</span></h3>
                            <p>Câmera priméria de 48MP com sensor Sony IMX586 0.8μm e abertura ƒ/1.75<br>Suporta vídeo HD<br>Câmera de 12MP teleobjetiva com 1.0μm e abertura ƒ/2.2<br>Suporta fotografias em macro<br>Câmera com lente ultra grande angular de 16MP com 1.0μm e abertura de ƒ/2.2<br>Suporta fotografias em grande angular<br>Zoom: Zoom de câmera tripla com zoom ótico de 2x e zoom digital de 10x<br>Foco: Foco a laser | PDAF | Foco por detecção de contraste<br>Resolução de foto: até 8000x6000 pixels*<br>Resolução de vídeo: até 3840x2160 pixels*<br></p>
                            <h4 class="texto-spec">Recursos de fotografia da câmera traseira<br></h4>
                            <p>48MP HD | Modo Ultra grande angular inteligente | Modo ultra cena noturna | Modo Retrato com desfoque de fundo | Modo Panorama | Modo Pro | Timer de foto | Nivelamento de foto | Captura sequencial | Reconhecimento facial | HDR | Flash duplo | Fotos dinâmicas | Beautiful com IA |<br>Correção de distorção para lente ultra grande angular | Correção facial em fotos de grupos | Marca d'água personalizada | Modo Retrato de corpo inteiro | Ajuste de desfoque de fundo no Modo Retrato<br>Detecção de cena por IA na câmera traseira (30 tags reconhecíveis) | Bokeh dinâmico por IA | Iluminação de Estúdio por IA | Fotos de alta resolução por IA | Modo para Lua*<br></p>
                            <h4 class="texto-spec">Recursos de vídeo da câmera traseira<br></h4>
                            <p>Vídeo em camera lenta de 960 fps | Pareamento inteligente de áudio a 960fps | Vídeos curtos (ajuste de velocidade, filtros de beleza e músicas populares)<br>Beautiful na câmera traseira | Estabilização de vídeo | Movimentos rápidos | Rastreador de movimentos*<br></p>
                            <table>
                                <tbody><tr>
                                        <td>Gravação 4K</td>
                                        <td>60fps / 30fps</td>
                                    </tr>
                                    <tr>
                                        <td>Gravação 1080p</td>
                                        <td>60fps / 30fps</td>
                                    </tr>
                                    <tr>
                                        <td>Gravação 720p</td>
                                        <td> 30fps</td>
                                    </tr>
                                    <tr>
                                        <td>Gravação 1080p em câmera lenta</td>
                                        <td> 120fps / 240fps / 960fps</td>
                                    </tr>
                                    <tr>
                                        <td>Gravação 720p em câmera lenta</td>
                                        <td> 120fps / 240fps / 960fps</td>
                                    </tr>
                                </tbody></table>
                        </div>
                    </div>
                </div>

            </div>
        </div>
        <div class="div-info">
            <div class="container">
                <div class="linha">
                    <div class="span5">
                        <h2 class="texto-spec">Câmera frontal<br></h2>
                    </div>
                    <div class="span15">
                        <div class="contexto">
                            <h3 class="texto-spec">Câmera frontal de 20MP<br>                            <span>Câmera frontal de 20MP com 0.9μm e abertura de ƒ/2.0</span></h3>
                            <h4 class="texto-spec">Recursos de fotografia da câmera frontal<br></h4>
                            <p>HRD na câmera frontal | Correção de brilho para a câmera frontal | Timer de selfies | Reconhecimento facial | Espelho mágico | Reconhecimento de idade<br>Brilho ocular | Beutiful com IA | Ajuste de feições por IA | Maquiagem por IA | Detecção de cena por IA | Iluminação de Estúdio por IA | Bokeh dinâmico por IA<br></p>
                            <h4 class="texto-spec">Recursos de vídeo da câmera frontal<br></h4>
                            <p>Vídeos curtos (ajuste de velocidade, filtros de beleza e músicas populares) | Beautiful na câmera de vídeo frontal<br></p>
                            <table>
                                <tbody><tr>
                                        <td>Gravação 1080p</td>
                                        <td>30fps</td>
                                    </tr>
                                    <tr>
                                        <td>Gravação 720p</td>
                                        <td>30fps</td>
                                    </tr>

                                </tbody></table>                    
                        </div>
                    </div>
                </div>

            </div>
        </div>
        <div class="div-info">
            <div class="container">
                <div class="linha">
                    <div class="span5">
                        <h2 class="texto-spec">Carregamento e bateria<br></h2>   
                    </div>
                    <div class="span15">
                        <div class="contexto">
                            <h4 class="texto-spec">3300mAh (typ) / 3200mAh (min)<br></h4>
                            <p>Bateria interna recarregável<br>Porta USB Tipo C com conector reversível<br>Sistema de carregamento rápido certificado pela TÜV Rhineland<br>O primeiro com carregamento sem fios de 20W do mundo<br>Certificação EPP para o padrão de carregamento sem fios de média gama Qi da WPC<br>Suporta carregamento rápido com cabo de 27W<br>Suporta o protocolo de carregamento rápido QC4.0<br>Inclui carregador padrão de 18W<br></p>
                        </div>
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
