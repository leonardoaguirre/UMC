<?php
session_start();
unset($_SESSION['usuario']);
unset($_SESSION['pessoa']);
echo "<script>alert('Você saiu com sucesso da sua conta, volte sempre!');location.href=\"index.php\";</script>";
?>