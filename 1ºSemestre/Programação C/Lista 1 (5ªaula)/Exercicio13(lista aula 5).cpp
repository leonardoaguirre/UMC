#include<stdio.h>
/* Função do programa receba o peso do saco de ração e a quantidade de ração
fornecida para cada gato por dia. Calcule e mostre quanto restará de ração no saco
após cindo dias
Programador: Leonardo
Data:08/03/18*/
main(){
       	int nota1,nota2,nota3;
       	float media;
	printf("Digite a nota 1: ");
	scanf("%d",&nota1);
	printf("Digite a nota 2: ");
	scanf("%d",&nota2);
	printf("Digite a nota 3: ");
	scanf("%d",&nota3);
	media= ((nota1*2)+(nota2*3)+(nota3*5))/10;
	printf("A media final é: %1.f ",media);
       }
