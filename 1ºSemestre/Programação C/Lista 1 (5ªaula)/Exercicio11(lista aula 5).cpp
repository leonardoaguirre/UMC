#include<stdio.h>
#include<math.h>
/* Função do programa  receba um número positivo
e maior que zero, calcule e mostre:
a) o número digitado ao quadrado;
b) a raiz quadrada do número digitado; 
Programador: Leonardo
Data:08/03/18*/
main(){
       	float num,numQuadrado,numRaiz;
	printf("Digite o numero desejado: ");
	scanf("%f",&num);
	numRaiz=sqrt(num);
	numQuadrado=pow(num,2);
	printf("O numero ao quadrado é: %1.f e a raiz quadrada é: %1.f",numQuadrado,numRaiz);
       }
