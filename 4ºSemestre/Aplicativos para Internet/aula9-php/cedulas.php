<?php
$num=$_GET["num"];
echo "Valor total R$$num <br>";

$notas100 = floor($num/100);
$num=$num-($notas100*100);
echo "$notas100 nota(s) de R$100<br>";

$notas50 = floor($num/50);
$num=$num-($notas50*50);
echo "$notas50 nota(s) de R$50<br>";

$notas20 = floor($num/20);
$num=$num-($notas20*20);
echo "$notas20 nota(s) de R$20<br>";

$notas10 = floor($num/10);
$num=$num-($notas10*10);
echo "$notas10 nota(s) de R$10<br>";

$notas5 = floor($num/5);
$num=$num-($notas5*5);
echo "$notas5 nota(s) de R$5<br>";

$notas2 = floor($num/2);
$num=$num-($notas2*2);
echo "$notas2 nota(s) de R$2<br>";

$notas1 = floor($num/1);
$num=$num-($notas1*1);
echo "$notas1 nota(s) de R$1<br>";
?>