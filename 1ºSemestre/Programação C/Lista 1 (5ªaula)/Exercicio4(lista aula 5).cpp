#include<stdio.h>
/* Função do programa Calcular o tempo necessario para calcular o download do arquivo
Programador: Leonardo
Data:02/03/18*/
main(){
		int dis,comb;
		float Result;
	printf("Calcular consumo medio de um automovel em km/l\n");
	printf("Digite a distancia percorrida pelo automovel(em quilometros): ");
	scanf("%d",&dis);
	printf("Digite a quantidade de combustivel gasto pelo automovel(em litros): ");
	scanf("%d",&comb);
	Result=dis/comb;
	printf("O consumo medio atual e de: %.1f",Result);
	printf(" quilometros por litro");
}
