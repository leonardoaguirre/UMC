#include <stdio.h>
#include <math.h>
/* Fun��o do programa  que determine o grau de obesidade de uma pessoa, sendo
fornecido o peso e a altura da pessoa. O grau de obesidade � determinado pelo
�ndice da massa corp�rea (Massa = Peso / Altura2 )
Programador: Leonardo
Data:08/03/18*/
main ()
{
	float altura,peso,massa;
	printf ("Digite a sua altura: ");
	scanf ("%f", &altura);
	printf ("Digite o seu peso: ");
	scanf ("%s", &peso);
	
	if(altura<2.50 && peso<300){
	
	massa = peso/(pow(altura,2));
	
		if(massa<26){
			printf("Normal");
		}
		if(massa>=26 && massa<30){
			printf("Obeso");
		}
		if (massa>=30){
			printf("Obeso morbido");
		}
	
	}
		else{
			printf("Dados invalidos");
		}
}

