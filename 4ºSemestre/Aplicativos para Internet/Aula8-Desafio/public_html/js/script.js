var para;

function aoCarrregarPagina(){
    para=document.querySelector('p');
    para.addEventListener('click',atualizarNome);
}
function atualizarNome(){
    var num = prompt('Digite o numero de jogadores: ');
    document.writeln('<link href="css/estilo.css" rel="stylesheet" type="text/css"/>');
    
    for(i=1;i<=num;i++){

        document.writeln('<p>Jogador '+i+'</p>');
    }
    
}
