#include <stdio.h>
#include <locale.h>
/* Função do programa  construa um
algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:
Para homens: (72.7*h) - 58
Para mulheres: (62.1*h) - 44.7 (h = altura)
Programador: Leonardo
Data:08/03/18*/
int main ()
{
	setlocale(LC_ALL,"");
	char sexo;
	float altura,peso;
	printf ("Escreva o a letra correspondente ao seu genero(m/f): ");
	scanf ("%c", &sexo);
	printf ("Digite a sua altura: ");
	scanf ("%f", &altura);
//	printf ("Escreva o a letra correspondente ao seu genero(m/f): ");
//	scanf ("%c", &sexo);
	
	if(altura <2.50 && sexo=='m' || sexo=='M' || sexo=='f' || sexo=='F'){
	
	if (sexo=='m' || sexo=='M')
	{
		peso=(72.7*altura)-58;
		printf("O seu peso ideal é: %3.f quilos",peso);
	}
	if (sexo=='f' || sexo=='F')
	{
		peso=(62.1*altura)-44.7;
		printf("O seu peso ideal é: %3.f quilos",peso);
	}
}
		else{
			printf("Dados invalidos");
		}
}

