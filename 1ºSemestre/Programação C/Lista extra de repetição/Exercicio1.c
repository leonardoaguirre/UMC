#include<stdio.h>
main(){
	float VI,VF,F;
	
		printf("Programa que exibe uma tabela de conversão de temperatura de graus Celsius para Fahrenheit conforme intervalo estabelecido pelo usuario");
		
			printf("\nDigite o valor inicial de temperatura em celsius: ");
			scanf("%f",&VI);
			do{
				printf("\nDigite o valor final de temperatura em celsius: ");
				scanf("%f",&VF);
				if(VF<=VI){
					printf("\nValor incorreto, o valor final e menor ou igual ao valor inicial!");
				}
			}while(VF<=VI);
		while(VI<VF){
		F=1.8*VI+32;
		printf("\nValor em celsius: %.1f  Valor em fahrenheit: %.1f",VI,F);
		VI=VI+0.5;
		}
}
