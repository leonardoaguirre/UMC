#include<stdio.h>
main(){
	int n,i,soma;
	
		printf("Programa que que exibe a somatória dos números de 1 a N\n");
		printf("\nAte que numero deseja fazer a somatoria para exibir? ");
		scanf("%d",&n);
		
	for(i=1;i<=n;i++){
		soma=i+soma;
		
		}
		printf("A soma total de 1 ate N e: %d",soma);
}
