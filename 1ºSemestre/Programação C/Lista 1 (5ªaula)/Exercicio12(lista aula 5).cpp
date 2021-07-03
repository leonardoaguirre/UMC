#include<stdio.h>
/* Função do programa receba o peso do saco de ração e a quantidade de ração
fornecida para cada gato por dia. Calcule e mostre quanto restará de ração no saco
após cindo dias
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
	printf("A quantidade restante de racao apos 5 dias é: %d ",restante);
       }
