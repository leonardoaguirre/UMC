<?php
$larg = number_format($_GET["larg"],1);
$alt = number_format($_GET["comp"],1);
$pre = number_format($_GET["val"],2);

$area= $larg*$alt;
$preco = number_format($pre*$area,2);

echo "Área: $area m2<br>Preço: R$$preco";
?>