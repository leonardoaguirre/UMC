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
        <title>Loja</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link href="css/estilo.css" rel="stylesheet" type="text/css"/>
        <link href="css/loja.css" rel="stylesheet" type="text/css"/>
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
        <ul class="products__list">
            <li>
                <div class="products__case"> 
                <img src="imgs/cels/mi_8_lite_aurora_blue.png" alt="Mi 8 Lite">
                <div class="product__main">
                    <a href="" title="Smartphone Xiaomi Mi 8 Lite 6.26&quot; 64GB Dual SIM Versão Gl..." class="product__name">Smartphone Xiaomi Mi 8 Lite 6.26" 64GB Dual SIM Versão Global</a>
                    <div class="price-box">
                        <span class="regular-price" id="product-price-74">
                            <span class="label"><span>Por:</span></span>
                            <span class="price">
                                <span>
                                    R$1.311,99 </span>
                            </span>
                        </span>
                    </div>
                    <div class="price-box-avista" id="price-box-avista-74">
                        <span class="label"><span>5% de Desconto à vista</span></span>
                        <span class="price"><span>R$1.246,39</span></span>
                    </div>
                    <div class="price-box-parcelado" id="price-box-parcelado-74">
                        <div class="">
                            <span class="num"><span>12x</span></span>
                            <span class=""><span>de</span></span>
                            <span class="value"><span>R$109,33</span></span>
                            <span class=""><span>sem juros</span></span>
                        </div>
                    </div>
                </div> 
                </div>
            </li>         
            <li>
                <div class="products__case">             
                    <img alt="" src="imgs/cels/mi_max_3.png">
                    <div class="product__main">
                        <a href="" title="Smartphone Xiaomi Mi Max 3 6.9&quot; 64GB Dual SIM Versão Glob..." class="product__name">Smartphone Xiaomi Mi Max 3 6.9" 64GB Dual SIM Versão Global Preto</a>
                        <div class="price-box">
                            <span class="regular-price" id="product-price-78">
                                <span class="label"><span>Por:</span></span>
                                <span class="price">
                                    <span>
                                        R$1.463,99 </span>
                                </span>
                            </span>
                        </div>
                        <div class="price-box-avista" id="price-box-avista-78">
                            <span class="label"><span>5% de Desconto à vista</span></span>
                            <span class="price"><span>R$1.390,79</span></span>
                        </div>
                        <div class="price-box-parcelado" id="price-box-parcelado-78">
                            <div class="">
                                <span class="num"><span>12x</span></span>
                                <span class=""><span>de</span></span>
                                <span class="value"><span>R$122,00</span></span>
                                <span class=""><span>sem juros</span></span>
                            </div>
                        </div>
                    </div> </div>
            </li><li>
                <div class="products__case">
                    <img src="imgs/cels/mi_9t_blue_1.png" alt="">
                    <div class="product__main">
                        <a href="" title="Smartphone Xiaomi Mi 9T 6.39&quot; 6GB/64GB Dual SIM Versão Gl..." class="product__name">Smartphone Xiaomi Mi 9T 6.39" 6GB/64GB Dual SIM Versão Global (Redmi K20)</a>
                        <div class="price-box">
                            <span class="regular-price" id="product-price-179">
                                <span class="label"><span>Por:</span></span>
                                <span class="price">
                                    <span>
                                        R$2.461,99 </span>
                                </span>
                            </span>
                        </div>
                        <div class="price-box-avista" id="price-box-avista-179">
                            <span class="label"><span>5% de Desconto à vista</span></span>
                            <span class="price"><span>R$2.338,89</span></span>
                        </div>
                        <div class="price-box-parcelado" id="price-box-parcelado-179">
                            <div class="">
                                <span class="num"><span>12x</span></span>
                                <span class=""><span>de</span></span>
                                <span class="value"><span>R$205,17</span></span>
                                <span class=""><span>sem juros</span></span>
                            </div>
                        </div>
                    </div> </div>
            </li><li>
                <div class="products__case">
                    <img alt="" src="imgs/cels/mi_9t_black_1.png">
                    <div class="product__main">
                        <a href="" title="Smartphone Xiaomi Mi 9T Pro 6.39&quot; 6GB/128GB Dual SIM Vers..." class="product__name">Smartphone Xiaomi Mi 9T Pro 6.39" 6GB/128GB Dual SIM Versão Global </a>

                        <div class="price-box">
                            <span class="regular-price" id="product-price-202">
                                <span class="label"><span>Por:</span></span>
                                <span class="price">
                                    <span>
                                        R$2.745,99 </span>
                                </span>
                            </span>
                        </div>
                        <div class="price-box-avista" id="price-box-avista-202">
                            <span class="label"><span>5% de Desconto à vista</span></span>
                            <span class="price"><span>R$2.608,69</span></span>
                        </div>
                        <div class="price-box-parcelado" id="price-box-parcelado-202">
                            <div class="">
                                <span class="num"><span>12x</span></span>
                                <span class=""><span>de</span></span>
                                <span class="value"><span>R$228,83</span></span>
                                <span class=""><span>sem juros</span></span>
                            </div>
                        </div>
                    </div> </div>
            </li><li>
                <div class="products__case">
                    <img alt="" src="imgs/cels/mi_8_pro.png">
                    <div class="product__main">
                        <a href="" title="Smartphone Xiaomi Mi 8 Pro 6.21&quot; 128GB Dual SIM Titânio T..." class="product__name">Smartphone Xiaomi Mi 8 Pro 6.21" 128GB Dual SIM Titânio Transparente Versão Global</a>
                        <div class="price-box">
                            <span class="regular-price" id="product-price-86">
                                <span class="label"><span>Por:</span></span>
                                <span class="price">
                                    <span>
                                        R$2.512,99 </span>
                                </span>
                            </span>
                        </div>
                        <div class="price-box-avista" id="price-box-avista-86">
                            <span class="label"><span>5% de Desconto à vista</span></span>
                            <span class="price"><span>R$2.387,34</span></span>
                        </div>
                        <div class="price-box-parcelado" id="price-box-parcelado-86">
                            <div class="">
                                <span class="num"><span>12x</span></span>
                                <span class=""><span>de</span></span>
                                <span class="value"><span>R$209,42</span></span>
                                <span class=""><span>sem juros</span></span>
                            </div>
                        </div>
                    </div> </div>
            </li><li>
                <div class="products__case">
                    <img alt="" src="imgs/cels/mi_play_dream_blue.png">
                    <div class="product__main">
                        <a href="" title="Smartphone Xiaomi Mi Play 5.84&quot; 4GB/64GB Dual SIM Versão ..." class="product__name">Smartphone Xiaomi Mi Play 5.84" 4GB/64GB Dual SIM Versão Global</a>
                        <div class="price-box">
                            <span class="regular-price" id="product-price-148">
                                <span class="label"><span>Por:</span></span>
                                <span class="price">
                                    <span>
                                        R$1.119,99 </span>
                                </span>
                            </span>
                        </div>
                        <div class="price-box-avista" id="price-box-avista-148">
                            <span class="label"><span>5% de Desconto à vista</span></span>
                            <span class="price"><span>R$1.063,99</span></span>
                        </div>
                        <div class="price-box-parcelado" id="price-box-parcelado-148">
                            <div class="">
                                <span class="num"><span>12x</span></span>
                                <span class=""><span>de</span></span>
                                <span class="value"><span>R$93,33</span></span>
                                <span class=""><span>sem juros</span></span>
                            </div>
                        </div>
                    </div> </div>
            </li><li>
                <div class="products__case">
                    <img alt="" src="imgs/cels/mi_a3_white.png">
                    <div class="product__main">
                        <a href="" title="Smartphone Xiaomi Mi A3 6.08&quot; 4GB/64GB Dual SIM Versão Gl..." class="product__name">Smartphone Xiaomi Mi A3 6.08" 4GB/64GB Dual SIM Versão Global</a>
                        <div class="price-box">
                            <span class="regular-price" id="product-price-193">
                                <span class="label"><span>Por:</span></span>
                                <span class="price">
                                    <span>
                                        R$1.611,99 </span>
                                </span>
                            </span>
                        </div>
                        <div class="price-box-avista" id="price-box-avista-193">
                            <span class="label"><span>5% de Desconto à vista</span></span>
                            <span class="price"><span>R$1.531,39</span></span>
                        </div>
                        <div class="price-box-parcelado" id="price-box-parcelado-193">
                            <div class="">
                                <span class="num"><span>12x</span></span>
                                <span class=""><span>de</span></span>
                                <span class="value"><span>R$134,33</span></span>
                                <span class=""><span>sem juros</span></span>
                            </div>
                        </div>
                    </div> </div>
            </li><li>
                <div class="products__case">
                    <img alt="" src="imgs/cels/mi_8_lite_black_1.png">
                    <div class="product__main">
                        <a href="" title="Smartphone Xiaomi Mi 8 Lite 6.26&quot; 128GB Dual SIM Versão G..." class="product__name">Smartphone Xiaomi Mi 8 Lite 6.26" 128GB Dual SIM Versão Global</a>
                        <div class="price-box">
                            <span class="regular-price" id="product-price-77">
                                <span class="label"><span>Por:</span></span>
                                <span class="price">
                                    <span>
                                        R$1.611,99 </span>
                                </span>
                            </span>
                        </div>
                        <div class="price-box-avista" id="price-box-avista-77">
                            <span class="label"><span>5% de Desconto à vista</span></span>
                            <span class="price"><span>R$1.531,39</span></span>
                        </div>
                        <div class="price-box-parcelado" id="price-box-parcelado-77">
                            <div class="">
                                <span class="num"><span>12x</span></span>
                                <span class=""><span>de</span></span>
                                <span class="value"><span>R$134,33</span></span>
                                <span class=""><span>sem juros</span></span>
                            </div>
                        </div>
                    </div> </div>
            </li><li>
                <div class="products__case">
                    <img alt="" src="imgs/cels/mi_9_ocean_blue_2.png">
                    <div class="product__main">
                        <a href="" title="Smartphone Xiaomi Mi 9 6.39&quot; 6GB/64GB Dual SIM Versão Global" class="product__name">Smartphone Xiaomi Mi 9 6.39" 6GB/64GB Dual SIM Versão Global</a>
                        <div class="price-box">
                            <span class="regular-price" id="product-price-152">
                                <span class="label"><span>Por:</span></span>
                                <span class="price">
                                    <span>
                                        R$2.485,99 </span>
                                </span>
                            </span>
                        </div>
                        <div class="price-box-avista" id="price-box-avista-152">
                            <span class="label"><span>5% de Desconto à vista</span></span>
                            <span class="price"><span>R$2.361,69</span></span>
                        </div>
                        <div class="price-box-parcelado" id="price-box-parcelado-152">
                            <div class="">
                                <span class="num"><span>12x</span></span>
                                <span class=""><span>de</span></span>
                                <span class="value"><span>R$207,17</span></span>
                                <span class=""><span>sem juros</span></span>
                            </div>
                        </div>
                    </div> </div>
            </li><li>
                <div class="products__case">
                    <img alt="" src="imgs/cels/mi_a2_black.png">
                    <div class="product__main">
                        <a href="" title="Smartphone Xiaomi Mi A2 5.99&quot; 64GB Dual SIM Versão Global" class="product__name">Smartphone Xiaomi Mi A2 5.99" 64GB Dual SIM Versão Global</a>
                        <div class="price-box">
                            <span class="regular-price" id="product-price-79">
                                <span class="label"><span>Por:</span></span>
                                <span class="price">
                                    <span>
                                        R$1.149,99 </span>
                                </span>
                            </span>
                        </div>
                        <div class="price-box-avista" id="price-box-avista-79">
                            <span class="label"><span>5% de Desconto à vista</span></span>
                            <span class="price"><span>R$1.092,49</span></span>
                        </div>
                        <div class="price-box-parcelado" id="price-box-parcelado-79">
                            <div class="">
                                <span class="num"><span>12x</span></span>
                                <span class=""><span>de</span></span>
                                <span class="value"><span>R$95,83</span></span>
                                <span class=""><span>sem juros</span></span>
                            </div>
                        </div>
                    </div> </div>
            </li><li>
                <div class="products__case">
                    <img alt="" src="imgs/cels/mi9-lite-white.png">
                    <div class="product__main">
                        <a href="" title="Smartphone Xiaomi Mi 9 Lite 6.39&quot; 6GB/128GB Dual SIM Vers..." class="product__name">Smartphone Xiaomi Mi 9 Lite 6.39" 6GB/128GB Dual SIM Versão Global </a>
                        <div class="price-box">
                            <span class="regular-price" id="product-price-207">
                                <span class="label"><span>Por:</span></span>
                                <span class="price">
                                    <span>
                                        R$1.999,99 </span>
                                </span>
                            </span>
                        </div>
                        <div class="price-box-avista" id="price-box-avista-207">
                            <span class="label"><span>5% de Desconto à vista</span></span>
                            <span class="price"><span>R$1.899,99</span></span>
                        </div>
                        <div class="price-box-parcelado" id="price-box-parcelado-207">
                            <div class="">
                                <span class="num"><span>12x</span></span>
                                <span class=""><span>de</span></span>
                                <span class="value"><span>R$166,67</span></span>
                                <span class=""><span>sem juros</span></span>
                            </div>
                        </div>
                    </div> </div>
            </li><li>
                <div class="products__case">
                    <img alt="" src="imgs/cels/mi_9t_red_2.png">
                    <div class="product__main">
                        <a href="" title="Smartphone Xiaomi Mi 9T 6.39&quot; 6GB/128GB Dual SIM Versão G..." class="product__name">Smartphone Xiaomi Mi 9T 6.39" 6GB/128GB Dual SIM Versão Global (Redmi K20)</a>
                        <div class="price-box">
                            <span class="regular-price" id="product-price-180">
                                <span class="label"><span>Por:</span></span>
                                <span class="price">
                                    <span>
                                        R$2.615,99 </span>
                                </span>
                            </span>
                        </div>
                        <div class="price-box-avista" id="price-box-avista-180">
                            <span class="label"><span>5% de Desconto à vista</span></span>
                            <span class="price"><span>R$2.485,19</span></span>
                        </div>
                        <div class="price-box-parcelado" id="price-box-parcelado-180">
                            <div class="">
                                <span class="num"><span>12x</span></span>
                                <span class=""><span>de</span></span>
                                <span class="value"><span>R$218,00</span></span>
                                <span class=""><span>sem juros</span></span>
                            </div>
                        </div>
                    </div> </div>
            </li>
        </ul>
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
