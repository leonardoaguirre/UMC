var alt, peso, result;

function calcularIMC() {
    alt = document.getElementById('txtAltura').value;
    peso = document.getElementById('txtPeso').value;

    result = parseFloat(peso) / (parseFloat(alt) * parseFloat(alt));


    var txtres = document.getElementById('txtResultado');
    var numres = document.getElementById('numResultado');
    
    if (result < 18.5) {
        numres.textContent= result;
        txtres.textContent='Abaixo do peso';
    } 
    else if (result >= 18.5 && result <= 24.9) {
        numres.textContent= result;
        txtres.textContent='Peso normal';
    } 
    else if (result >= 25 && result <= 29.9) {
        numres.textContent= result;
        txtres.textContent='Sobrepeso';
    } 
    else if (result >= 30 && result <= 34.9) {
        numres.textContent= result;
        txtres.textContent='Obesidade grau 1';
    } 
    else if (result >= 35 && result <= 39.9) {
        numres.textContent= result;
        txtres.textContent='Obesidade grau 2';
    } 
    else if (result >= 40) {
        numres.textContent= result;
        txtres.textContent='Obesidade grau 3';
    }
}

