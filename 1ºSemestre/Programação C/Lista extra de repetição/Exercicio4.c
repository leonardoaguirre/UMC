#include<stdio.h>
main(){
	int n,soma=0,i=1;
	
		printf("Programa  que recebe numeros enquanto forem positivos e exiba quantos desses números foram digitados");
			do{
				printf("\nDigite o numero: ");
				scanf("%d",&n);
				if(n>=0){
					soma++;
				}
			}while(n>=0);
		printf("\nForam digitados %d numero(s)",soma);
		}

