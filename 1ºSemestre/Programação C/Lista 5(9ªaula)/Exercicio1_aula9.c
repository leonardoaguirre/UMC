#include<stdio.h>
main(){
	int paisA=98000000,paisB=200000000,anos=0;
	
	printf("Algoritmo que calcula iterativamente, quantos anos serao necess�rios para que a popula��o do pais A, ultrapasse ou iguale a popula��o do pais B, mantidas as taxas de crescimento.");
	while(paisA<paisB){
		paisA=paisA*1.035;
		paisB=paisB*1.015;
		anos=anos+1;
	}
	printf("\nA quantidade de anos necessarios para se igualar as populacoes sera: %d anos",anos);
}
