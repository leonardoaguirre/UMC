#include<stdio.h>
main(){
	char letra;
	printf("Programa de ajuste salarial\n");
	printf("Digite uma letra qualquer: ");
	scanf("%c", &letra);
	
	switch(letra){
		case 'a': 
		case 'A': 
		case 'e': 
		case 'E': 
		case 'i': 
		case 'I': 
		case 'o': 
		case 'O': 
		case 'u': 
		case 'U': printf("Letra vogal"); break;
		default: printf("Letra consoante"); break;
		/* ou 
		case 'a': printf("Letra vogal"); break;
		case 'A': printf("Letra vogal"); break;
		case 'e': printf("Letra vogal"); break;
		case 'E': printf("Letra vogal"); break;
		case 'i': printf("Letra vogal"); break;
		case 'I': printf("Letra vogal"); break;
		case 'o': printf("Letra vogal"); break;
		case 'O': printf("Letra vogal"); break;
		case 'u': printf("Letra vogal"); break;
		case 'U': printf("Letra vogal"); break;
		default: printf("Letra consoante"); break;*/
	}
}
