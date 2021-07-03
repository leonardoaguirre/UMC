#include<stdio.h>
/* Função do programa calcule e mostre o valor do aumento e o novo salário.
Programador: Leonardo
Data:02/03/18*/
main(){
		float sal,Result,salFinal,per;
	printf("Calcule e mostre o valor do aumento e o novo salário.\n");
	printf("Digite o valor total do seu salario: ");
	scanf("%f",&sal);
	printf("Digite o valor do percentual de aumento: ");
	scanf("%f",&per);
	Result=sal*(per/100);
	salFinal=Result+sal;
	printf("O valor do seu aumento e: %.2f e o valor total atual do seu salario e: %.2f",Result,salFinal);
}
