<?php
$num1= $_GET["num1"];
$num2=$_GET["num2"];

for($i=0;$i<=$num2;$i++){
    $res=$num1*$i;
    echo"$num1 * $i = $res<br/>";
}
?>