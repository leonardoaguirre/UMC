#include<stdio.h>
/* Função do programa que  receba o peso de uma pessoa em quilos.
Calcule e mostre:
a. O novo peso se a pessoa engordar 15% sobre o peso digitado;
b. O novo peso se a pessoa emagrecer 20% sobre o peso digitado;
Programador: Leonardo
Data:08/03/18*/
main(){
       	float peso,engordar,emagrecer;
	printf("Digite o seu peso: ");
	scanf("%f",&peso);
	engordar= peso*1.15;
	emagrecer=peso-(peso*0.20);
	printf("Seu peso quando engordou: %1.f seu peso quando emagreceu: %1.f",engordar,emagrecer);
       }
