#include<stdio.h>
main(){
	int n,soma=0;
	
		printf("Programa que recebe varios numeros e exibe quantos numeros entre 20 e 100 foram digitados.Quando o usuário digitar 0 o programa encerra a contagem.");
			do{
				printf("\nDigite o numero: ");
				scanf("%d",&n);
				if(n>=20 && n<=100){
					soma++;
				}
			}while(n!=0);
		printf("\nForam digitados %d numero(s) entre 20 e 100",soma);
		}

