#include<stdio.h>
main(){
	int cod;
	
	printf("Programa que mostra o cargo do funcionario\n");
	printf("Digite o codigo entre 1 e 5: ");
	scanf("%d", &cod);
	switch(cod){
		case 1: printf("Escrituario"); break;
		case 2: printf("Secretaria"); break;
		case 3: printf("Caixa"); break;
		case 4: printf("Gerente"); break;
		case 5: printf("Diretor"); break;
		default: printf("Codigo invalido");
	}
}
