#include<stdio.h>
/* Função do programa e receba o ano de nascimento de uma pessoa e o
ano atual, calcule e mostre:
- A idade desta pessoa hoje;
- A idade desta pessoa em 2025
Programador: Leonardo
Data:08/03/18*/
main(){
       	int anoNasc,idadeHoje,idadeFutura,anoAtual;
	printf("Digite o seu ano de nascimento: ");
	scanf("%d",&anoNasc);
	printf("Digite o ano atual: ");
	scanf("%d",&anoAtual);
	idadeHoje=anoAtual-anoNasc;
	idadeFutura=2025-anoNasc;
	printf("A sua idade atual é: %d e a sua idade em 2025 vai ser: %d",idadeHoje,idadeFutura);
       }
