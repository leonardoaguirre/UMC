#include<stdio.h>
/* Função do programa  converta segundos em minutos e segundos
Programador: Leonardo
Data:08/03/18*/
main(){
       	int seg,segundos,minutos;
	printf("Digite os segundos: ");
	scanf("%d",&seg);
	minutos=seg/60;
	segundos= seg%60;
	//segundos= segundos*60;
	printf("Minutos: %d segundos: %d",minutos,segundos);
       }
