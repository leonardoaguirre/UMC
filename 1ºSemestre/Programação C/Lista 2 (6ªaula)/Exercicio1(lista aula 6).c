#include <stdio.h>
/* Função do programa receba a média de um aluno e mostre a situação do aluno:
a. Aprovado ? média maior ou igual a 5;
b. Exame ? média entre 3 e 5;
c. Reprovado ? média menor do que 3;
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
