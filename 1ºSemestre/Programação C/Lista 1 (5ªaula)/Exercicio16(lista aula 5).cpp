#include <stdio.h>
/* Função do programa que calcule e mostre quanto restará do salário do
João
Programador: Leonardo
Data:08/03/18*/
main ()
{
	float Sal, Con1, Con2, ConF, SalF, Juros;
	printf ("Programa que calcula o salario final\n");
	printf ("Digite o valor do salario: ");
	scanf ("%f", &Sal);
	printf ("Digite o valor da primeira conta: ");
	scanf ("%f", &Con1);
	printf ("Digite o valor da segunda conta: ");
	scanf ("%f", &Con2);
	ConF = Con1+Con2;
	Juros = ConF*1.02;
	SalF = Sal-Juros;
	printf ("O valor restante do salario e de: %.2f", SalF);
}
