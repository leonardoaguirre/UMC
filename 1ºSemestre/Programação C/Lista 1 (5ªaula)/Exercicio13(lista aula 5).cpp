#include<stdio.h>
/* Fun��o do programa receba o peso do saco de ra��o e a quantidade de ra��o
fornecida para cada gato por dia. Calcule e mostre quanto restar� de ra��o no saco
ap�s cindo dias
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
	printf("A media final �: %1.f ",media);
       }
