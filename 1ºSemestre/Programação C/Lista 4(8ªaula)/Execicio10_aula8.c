#include<stdio.h>
main(){
	int n,i,num,par=0;
	
		printf("Programa que recebe N n�meros e contar quantos destes n�meros s�o pares.\n");
		printf("Quantos numeros voce ira digitar? ");
		scanf("%d",&n);
		
	for(i=1;i<=n;i++){
		printf("Digite o %d numero: ",i);
		scanf("%d",&num);
		
		if(num%2==0){
			par=par+1;
			}
		
		}
		printf("\nO numero total de numeros pares digitados e: %d",par);
}
