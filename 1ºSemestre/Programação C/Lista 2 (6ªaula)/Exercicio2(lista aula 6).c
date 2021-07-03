#include <stdio.h>
/* Função do programa receba o código correspondente ao cargo de um
funcionário e mostre o cargo.
Código Cargo
1 Escriturário
2 Secretária
3 Caixa
4 Gerente
5 Diretor
Programador: Leonardo
Data:08/03/18*/
main ()
{
	int cod;
	printf ("Digite o codigo do funcionario: ");
	scanf ("%d", &cod);
	if(cod >=1 && cod<=5){
	
		if(cod == 1){
				printf("Escrituario");
		}
		if(cod ==2){
			printf("Secretaria");
		}
		if(cod == 3){
				printf("Caixa");
		}
		if(cod == 4){
				printf("Gerente");
		}
		if(cod == 5){
				printf("Diretor");
		}	
	}
	else{
		printf("Codigo invalido");
	}

}
