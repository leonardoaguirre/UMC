#include<stdio.h>

main(){
	
	int i,fat,x;
	printf("Entre com um numero inteiro e positivo: ");
	scanf("%d",&x);
	if(x>0){
		fat=1;
		i=1;
		while(i<=x){
			fat=fat*i;
			i++;
		}
		printf("O fatorial de %d e igual a: %d",x,fat);
	}else{
		printf("O numero deve ser maior que zero");
	}
}

