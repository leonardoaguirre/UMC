#include<stdio.h>
/* Fun��o do programa que receba o custo de um espet�culo teatral e o
pre�o do convite deste espet�culo. Esse algoritmo deve calcular e mostrar a
quantidade de convites que devem ser vendidos para que pelo menos o custo do
espet�culo seja alcan�ado
Programador: Leonardo
Data:08/03/18*/
main(){
       	float custo,convite;
       	int media;
	printf("Digite o custo do espetaculo: ");
	scanf("%d",&custo);
	printf("Digite o preco do convite: ");
	scanf("%d",&convite);
	media= custo/convite;
	printf("Devem ser vendidos %d convites para que o custo do espetaculo seja alcancado",media);
       }
