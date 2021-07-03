function somar() {
    var valor1 = document.getElementById('txtValor1').value;
    var valor2 = document.getElementById('txtValor2').value;

    var soma = parseFloat(valor1) + parseFloat(valor2);

    var resultado = document.getElementById('resultado');
    resultado.textContent = soma;
}
function subtrair() {
    var valor1 = document.getElementById('txtValor1').value;
    var valor2 = document.getElementById('txtValor2').value;

    var sub = parseFloat(valor1) - parseFloat(valor2);

    var resultado = document.getElementById('resultado');
    resultado.textContent = sub;
}
function dividir() {
    var valor1 = document.getElementById('txtValor1').value;
    var valor2 = document.getElementById('txtValor2').value;

    if (parseFloat(valor1) === 0 || parseFloat(valor2) === 0) {
        alert('Não é possível realizar divisão por zero!');
    } else {
        var div = parseFloat(valor1) / parseFloat(valor2);
        var resultado = document.getElementById('resultado');
        resultado.textContent = div;
    }
}
function multiplicar() {
    var valor1 = document.getElementById('txtValor1').value;
    var valor2 = document.getElementById('txtValor2').value;

    var mul = parseFloat(valor1) * parseFloat(valor2);

    var resultado = document.getElementById('resultado');
    resultado.textContent = mul;
}