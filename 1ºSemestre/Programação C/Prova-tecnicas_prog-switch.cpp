#include<stdio.h>
main(){
	int COD;
	float A,salario,novosal;
	
	//programa que calcula o aumento de salario de alguns funcionarios de uma certa empresa de acordo com o seu codigo
	// programador leonardo vinicius
	//Data 20/04/2018
	printf("Programa de ajuste salarial\n");
	printf("1-Gerente\n2-Engenheiro\n3-Tecnico\n");
	printf("Digite o seu codigo: ");
	scanf("%d", &COD);
	
	switch(COD){
		case 1: A=0.05;	break;
			
		case 2: A=0.1; break;
			
		case 3: A=0.12;	break;
		
		default: A=0; break;
	}
	if(A==0){
		printf("Codigo invalido!");
	}else{
		printf("Digite o seu salario: ");
			scanf("%f",&salario);
			
			novosal=salario*A+salario;
			
			printf("O seu novo salario e: R$%.2f",novosal);
	}
	
}
