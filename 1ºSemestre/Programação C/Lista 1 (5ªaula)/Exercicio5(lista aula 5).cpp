#include<stdio.h>
/* Função do programa Calcular o saldo de uma aplicação e imprimir o novosaldo
Programador: Leonardo
Data:02/03/18*/
main(){
		
		float val,Result;
	printf("Ler o saldo de uma aplicacao e imprimir o novo saldo com 15 por cento de rendimento\n");
	printf("Digite o valor total da aplicacao: ");
	scanf("%f",&val);
	Result=val*1.15;
	printf("O valor atual de sua aplicacao e de : %.2f",Result);
}
