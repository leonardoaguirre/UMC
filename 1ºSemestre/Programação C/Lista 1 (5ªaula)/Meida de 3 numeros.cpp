#include<stdio.h>
/* Função do programa mediar 3 notas
Programador: Leonardo
Data:02/03/18*/
main(){
	float N1,N2,N3,Media;
	printf("Programa de meida de 3 numeros\n");
	printf("Digite o primeiro numero:");
	scanf("%f",&N1);
	printf("Digite o segundo numero:");
	scanf("%f",&N2);
	printf("Digite o terceiro numero:");
	scanf("%f",&N3);
	Media=(N1+N2+N3)/3;
	printf("A media e de: %f",Media);
}
