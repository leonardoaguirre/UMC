#include <stdio.h>
/* Função do programaque leia a variável P (peso de peixes) e verifique
se há excesso. Se houver, gravar na variável E (Excesso) e na variável M o valor
da multa que João deverá pagar. Caso contrário mostrar tais variáveis com o
conteúdo ZERO.
Programador: Leonardo
Data:08/03/18*/
int main()
{
	float P,E=0,M=0;
	
	printf ("Digite o peso de peixes pescados em quilos: ");
	scanf("%f",&P);

	if (P>50)
	{
		E=P-50;
		M=E*4;
		printf("Peso pescado: %0.f\nExcesso de peso: %.0f\nValor de multa a se pagar: R$%.2f",P,E,M);
	}
	
	else{
			printf("Peso pescado: %0.f\nExcesso de peso: %.0f\nValor de multa a se pagar: R$%.2f",P,E,M);
	}
}
