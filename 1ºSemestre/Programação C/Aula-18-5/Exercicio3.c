#include<stdio.h>

main(){
	
	int i,fat,x;
	printf("Entre com um numero inteiro e positivo: ");
	scanf("%d",&x);
	if(x>0){
		fat=1;
		for(i=1;i<=x;i++){
			fat=fat*i;
		}
		printf("O fatorial de %d e igual a: %d",x,fat);
	}else{
		printf("O numero deve ser maior que zero");
	}
}

