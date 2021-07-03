#include<stdio.h>
main(){
	int i,total=0,n,r;
	
		printf("Programa que exibe a somatória dos números cujos quadrados sejam menores do que 225");
			for(i=1;i<=3;i++){
				printf("\nDigite o %d numero: ",i);
				scanf("%d",&n);
				r=n*n;
				if(r<225){
					total++;
				}
			}
		printf("\nO total de numero(s) que cujo seu(s) quadrado e menor que 225 e: %d",total);
		}

