#include<stdio.h>
/* Função do programa receba o número de horas trabalhadas e o valor do salário mínimo. Calcule e mostre o
salário a receber 
Programador: Leonardo
Data:08/03/18*/
main(){
       	float SB,HT,SM,VHT,SR,IMP;
	printf("Digite o valor do salario minimo: ");
	scanf("%f",&SM);
	VHT=SM/2;
	printf("Digite o valor de horas trabalhadas: ");
	scanf("%f",&HT);
	SB=HT*VHT;
	IMP=SB*3/100;
	SR=SB-IMP;
	printf("O salario recebido menos o imposto de 3 por cento e de  %2.f reais o imposto vale %2.f reais",SR,IMP);
       }
