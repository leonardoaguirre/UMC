#include<stdio.h>
/* Função do programa que receba o custo de um espetáculo teatral e o
preço do convite deste espetáculo. Esse algoritmo deve calcular e mostrar a
quantidade de convites que devem ser vendidos para que pelo menos o custo do
espetáculo seja alcançado
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
