#include<stdio.h>
main(){
	int i=1;
	float r,num;
	printf("Exbicao da metade de 20 numeros\n");

	while(i<=20){
		
		printf("Digite o %d numero:",i);
		scanf("%f",&num);
		r=num/2;
		printf("A metade desse numero e: %.2f\n",r);
		i++;
	}
}
