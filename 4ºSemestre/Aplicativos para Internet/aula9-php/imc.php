<?php

    $alt = $_GET["txtAltura"];
    $peso = $_GET["txtPeso"];

    $result = $peso / ($alt * $alt);
    echo '<link href="estilo.css" rel="stylesheet" type="text/css"/>
    <link href="https://fonts.googleapis.com/css?family=Roboto+Condensed&display=swap" rel="stylesheet">';
    
    if ($result < 18.5) {
        echo '<div class="panel-principal">
        <div class="resultado">
                <h3><label>Resultado</label></h3>
                <h1><label id="txtResultado">'+number_format($result,1)+'</label></h1>
                <h2><label id="numResultado">Abaixo do peso</label></h2>
            </div>
            </div>';
    } 
    else if ($result >= 18.5 && $result <= 24.9) {
        echo '<div class="panel-principal">
        <div class="resultado">
                <h3><label>Resultado</label></h3>
                <h1><label id="txtResultado">'+number_format($result,1)+'</label></h1>
                <h2><label id="numResultado">Peso normal</label></h2>
            </div>
            </div>';
    } 
    else if ($result >= 25 && $result <= 29.9) {
        echo '<div class="panel-principal">
        <div class="resultado">
                <h3><label>Resultado</label></h3>
                <h1><label id="txtResultado">'+number_format($result,1)+'</label></h1>
                <h2><label id="numResultado">Sobrepeso</label></h2>
            </div>
            </div>';
    } 
    else if ($result >= 30 && $result <= 34.9) {
        echo '<div class="panel-principal">
        <div class="resultado">
                <h3><label>Resultado</label></h3>
                <h1><label id="txtResultado">'+number_format($result,1)+'</label></h1>
                <h2><label id="numResultado">Obesidade grau 1</label></h2>
            </div>
            </div>';
    } 
    else if ($result >= 35 && $result <= 39.9) {
        echo '<div class="panel-principal">
        <div class="resultado">
                <h3><label>Resultado</label></h3>
                <h1><label id="txtResultado">'+number_format($result,1)+'</label></h1>
                <h2><label id="numResultado">Obesidade grau 2</label></h2>
            </div>
            </div>';
    } 
    else if ($result >= 40) {
        echo '<div class="panel-principal">
        <div class="resultado">
                <h3><label>Resultado</label></h3>
                <h1><label id="txtResultado">'+number_format($result,1)+'</label></h1>
                <h2><label id="numResultado">Obesidade grau 3</label></h2>
            </div>
            </div>';
    }
?>