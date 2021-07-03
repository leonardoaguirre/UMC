#include<stdio.h>
main(){
	int i,idade;
	for(i=1;i<=1000;i++){
		printf("Programa que le a idade e mostra o tipo de eleitor\n");
		printf("\nQual a idade da %d pessoa? ",i);
		scanf("%d",&idade); 
		
		if(idade<=16){
			printf("Nao eleitor");
		}else if(idade<=65){
			printf("Eleitor obrigatorio");
		}else{
			printf("Eleitor facultativo");
		}
	}
}
