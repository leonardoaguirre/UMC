#include<stdio.h>
main(){
	int i;
	float r,num;
	printf("Exbicao da metade de 20 numeros\n");

	for(i=1;i<=20;i++){
		
		printf("Digite o %d numero:",i);
		scanf("%f",&num);
		r=num/2;
		printf("A metade desse numero e: %.2f\n",r);
	}
}
