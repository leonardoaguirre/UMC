#include<stdio.h>
main(){
	int n,i,soma=0,num;
	float r;
	
		printf("Programa que que calcula a média aritmética de N valores numericos lidos.\n");
		printf("\nQuantos numeros voce ira digitar? ");
		scanf("%d",&n);
		
	for(i=1;i<=n;i++){
		printf("Digite o %d numero: ",i);
		scanf("%d",&num);
		soma=num+soma;
		
		}
		r=soma/n;
		printf("A media aritmetica e: %.1f",r);
}
