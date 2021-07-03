#include <stdio.h>
/* Função do programa  que leia a idade de uma pessoa e informar a sua classe
eleitoral:
a. Não-eleitor (abaixo de 16 anos)
b. Eleitor obrigatório (entre 18 e 65 anos)
c. Eleitor facultativo (entre 16 e 18 e maior de 65 anos)
Programador: Leonardo
Data:08/03/18*/
main ()
{
	int idade;
	printf ("Digite a sua idade: ");
	scanf ("%d", &idade);
	if(idade >=1 && idade<=120){
	
		if(idade < 16){
				printf("Nao eleitor");
		}
		if(idade >=18 && idade <=65){
			printf("Eleitor obrigatorio");
		}
		if((idade >=16 && idade <=17)||(idade >65)){
				printf("Eleitor facultativo");
		}
	
	}
	else{
		printf("Idade incorreta");
	}

}
