#include <stdio.h>
/* Fun��o do programaque leia a vari�vel P (peso de peixes) e verifique
se h� excesso. Se houver, gravar na vari�vel E (Excesso) e na vari�vel M o valor
da multa que Jo�o dever� pagar. Caso contr�rio mostrar tais vari�veis com o
conte�do ZERO.
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
