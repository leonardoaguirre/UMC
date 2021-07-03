#include<stdio.h>
main(){
	int n,fat=1,i=1;
	
		printf("Programa que calcula e exibe o fatorial de um número");
			do{
				printf("\nDigite o numero: ");
				scanf("%d",&n);
				if(n<0){
					printf("\nNumero invalido!");
				}
			}while(n<0);
			while(i<=n){
				fat=fat*i;
				i++;
			}
		printf("\nO fatorial do numero %d e %d",n,fat);
		}

