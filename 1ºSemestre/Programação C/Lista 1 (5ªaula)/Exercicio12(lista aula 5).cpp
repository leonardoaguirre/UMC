#include<stdio.h>
/* Fun��o do programa receba o peso do saco de ra��o e a quantidade de ra��o
fornecida para cada gato por dia. Calcule e mostre quanto restar� de ra��o no saco
ap�s cindo dias
Programador: Leonardo
Data:08/03/18*/
main(){
       	int pesoSaco,qt1,qt2,restante;
	printf("Digite o peso do saco de racao: ");
	scanf("%d",&pesoSaco);
	printf("Digite a quantidade de racao dada por dia do gato 1: ");
	scanf("%d",&qt1);
	printf("Digite a quantidade de racao dada por dia do gato 2: ");
	scanf("%d",&qt2);
	pesoSaco= pesoSaco*1000;
	restante= pesoSaco-((qt1*5)+(qt2*5));
	printf("A quantidade restante de racao apos 5 dias �: %d ",restante);
       }
