#include<stdio.h>
#include <math.h>
/* Fun��o do programa dados dois lados de um tri�ngulo ret�ngulo calcule
e exiba a respectiva hipotenusa
Programador: Leonardo
Data:08/03/18*/
main(){
       	float ladoa,ladob,hipotenusa;
	printf("Digite o tamanho do lado A: ");
	scanf("%f",&ladoa);
	printf("Digite o tamanho do lado B: ");
	scanf("%f",&ladob);
	hipotenusa=(ladob*ladob)+(ladoa*ladoa);
	hipotenusa=sqrt(hipotenusa);
	printf("A hipotenusa �: %f ",hipotenusa);
       }
