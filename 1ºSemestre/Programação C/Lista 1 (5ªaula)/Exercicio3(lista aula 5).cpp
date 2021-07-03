#include<stdio.h>
/* Função do programa Calcular o tempo necessario para calcular o download do arquivo
Programador: Leonardo
Data:02/03/18*/
main(){
		int tamanho,btps,Result;
	printf("Calcular o tempo necessario para calcular o download do arquivo\n");
	printf("Digite o tamanho do arquivo(em bits): ");
	scanf("%d",&tamanho);
	printf("Digite a velocidade de conexao(em bits por segundo): ");
	scanf("%d",&btps);
	Result=tamanho/btps;
	printf("Vai demorar %d",Result);
	printf(" segundos para baixar o arquivo desejado");
}
