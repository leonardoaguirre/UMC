#include<stdio.h>
#include<math.h>
/* Fun��o do programa  receba um n�mero positivo
e maior que zero, calcule e mostre:
a) o n�mero digitado ao quadrado;
b) a raiz quadrada do n�mero digitado; 
Programador: Leonardo
Data:08/03/18*/
main(){
       	float num,numQuadrado,numRaiz;
	printf("Digite o numero desejado: ");
	scanf("%f",&num);
	numRaiz=sqrt(num);
	numQuadrado=pow(num,2);
	printf("O numero ao quadrado �: %1.f e a raiz quadrada �: %1.f",numQuadrado,numRaiz);
       }
