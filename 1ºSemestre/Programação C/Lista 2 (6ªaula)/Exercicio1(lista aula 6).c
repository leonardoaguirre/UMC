#include <stdio.h>
/* Fun��o do programa receba a m�dia de um aluno e mostre a situa��o do aluno:
a. Aprovado ? m�dia maior ou igual a 5;
b. Exame ? m�dia entre 3 e 5;
c. Reprovado ? m�dia menor do que 3;
Programador: Leonardo
Data:08/03/18*/
main ()
{
	float media;
	printf ("Digite a sua media: ");
	scanf ("%f", &media);
	if(media>=0 && media<=10){
	
		if(media >= 5){
				printf("Aprovado");
		}
		if((media >=3)&&(media<=5)){
			printf("Exame");
		}
		else{
			printf("Reprovado");
		}
}else{
	printf("Media incorreta");
}
}
