<?php
function validaCpf($valor)
{
    $valor = str_replace(array('.', '-', '/'), "", $valor);
    $cpf = str_pad(preg_replace('[^0-9]', '', $valor), 11, '0', STR_PAD_LEFT);

    if (strlen($cpf) != 11 || $cpf == '00000000000' || $cpf == '11111111111' || $cpf == '22222222222' || $cpf == '33333333333' || $cpf == '44444444444' || $cpf == '55555555555' || $cpf == '66666666666' || $cpf == '77777777777' || $cpf == '88888888888' || $cpf == '99999999999') :
        return false;
    else :
        for ($t = 9; $t < 11; $t++) :
            for ($d = 0, $c = 0; $c < $t; $c++) :
                $d += $cpf{
                    $c} * (($t + 1) - $c);
            endfor;
            $d = ((10 * $d) % 11) % 10;
            if ($cpf{
                $c} != $d) :
                return false;
            endif;
        endfor;
        return true;
    endif;
}
function validaTelefone($valor)
{
    if (preg_match('/^\([0-9]{2}\)?\s?[0-9]{4,5}-[0-9]{4}$/', $valor)) :
        return true;
    else :
        return false;
    endif;
}
function validaCep($valor)
{
    if (preg_match('/[0-9]{5,5}([-]?[0-9]{3})?$/', $valor)) :
        return true;
    else :
        return false;
    endif;
}
?>