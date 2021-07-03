#include<stdio.h>
/* Função do programa mediar 4 cotacoes
Programador: Leonardo
Data:02/03/18*/
main(){
	float C1,C2,C3,C4,Media;
	printf("Programa de media de 4 cotacoes de carros\n");
	printf("Digite a primeira cotacao de carro:");
	scanf("%f",&C1);
	printf("Digite a segunda cotacao de carro");
	scanf("%f",&C2);
	printf("Digite a terceira cotacao de carro:");
	scanf("%f",&C3);
	printf("Digite a quarta cotacao de carro:");
	scanf("%f",&C4);
	Media=(C1+C2+C3+C4)/4;
	printf("A media de cotacao e de: %.2f",Media);
}
