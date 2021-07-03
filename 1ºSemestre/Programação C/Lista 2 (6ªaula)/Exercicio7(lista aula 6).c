#include <stdio.h>
/* Função do programa  João precisa
Construa um algoritmo que leia 3 valores inteiros e positivos e: encontre o maior
valor; encontre o menor valor e calcule a média dos números lidos.
Programador: Leonardo
Data:08/03/18*/
main ()
{
	int n1,n2,n3,maior,menor;
	float media;
	printf ("Digite o primeiro numero: ");
	scanf ("%d", &n1);
	printf ("Digite o segundo numero: ");
	scanf ("%d", &n2);
	printf ("Digite o terceiro numero: ");
	scanf ("%d", &n3);
	if (n1>0 && n2>0 && n3>0)
	{
		if(n1>n2 && n1>n3){
			maior = n1;
		}
		if(n2>n1 && n2>n3){
			maior = n2;
		}
		if(n3>n2 && n3>n1){
			maior = n3;
		}
		if(n1<n2 && n1<n3){
			menor = n1;
		}
		if(n2<n1 && n2<n3){
			menor = n2;
		}
		if(n3<n2 && n3<n1){
			menor = n3;
		}
		media = (n1+n2+n3)/3;
		printf("A media dos numeros e: %2.f , o maior numero digitado foi: %d e o menor numero digitado foi %d",media,maior,menor);
	}
	
		else{
			printf("Numero invalido encontrado");
		}
}

