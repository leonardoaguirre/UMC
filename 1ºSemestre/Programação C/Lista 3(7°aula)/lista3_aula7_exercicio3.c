#include<stdio.h>
main(){
	int cod;
	float n1,n2,r;
	printf("Programa que mostra um menu de opçoes com operacoes matematicas\n");
	printf("1-Somar dois numeros\n2-Multiplicar dois numeros\n3-Subtrair dois numeros\n4-Dividir dois numeros\n");
	printf("Digite o codigo do menu desejado: ");
	scanf("%d", &cod);
	switch(cod){
		case 1: printf("Somar\n");
			printf("Digite o primeiro numero: ");
			scanf("%f", &n1);
			printf("Digite o segundo numero: ");
			scanf("%f", &n2);
			r=n1+n2;
			printf("O resultado e: %.2f",r);
			break;
		case 2: printf("Multiplicar\n");
			printf("Digite o primeiro numero: ");
			scanf("%f", &n1);
			printf("Digite o segundo numero: ");
			scanf("%f", &n2);
			r=n1*n2;
			printf("O resultado e: %.2f",r);
			break;
		case 3:printf("Subtrair\n");
			printf("Digite o primeiro numero: ");
			scanf("%f", &n1);
			printf("Digite o segundo numero: ");
			scanf("%f", &n2);
			r=n1-n2;
			printf("O resultado e: %.2f",r);
			break;
		case 4: printf("Dividir\n");
			printf("Digite o primeiro numero: ");
			scanf("%f", &n1);
			printf("Digite o segundo numero: ");
			scanf("%f", &n2);
			if(n2==0){
				printf("Impossivel dividir por zero");
			}else{
			r=n1/n2;
			printf("O resultado e: %.2f",r);
			break;	
		}
	}
}
