#include<stdio.h>
//programa que calcula o aumento de salario de alguns funcionarios de uma certa empresa de acordo com o seu codigo
// programador leonardo vinicius
//Data 20/04/2018
main(){
	int COD;
	float A,salario,novosal;
	
	//programa que calcula o aumento de salario de alguns funcionarios de uma certa empresa de acordo com o seu codigo
	// programador leonardo vinicius
	//Data 20/04/2018
	
	printf("Digite o seu codigo: ");
	scanf("%d", &COD);
	
	if(COD==1){
		A=0.05;	
	}else if(COD==2){
		A=0.1;
	}else if(COD==3){
		A=0.12;
	}else{
		A=0;
	}
	
		if(A==0){
			printf("Voce digitou um codigo invalido");
		}else{
			printf("Digite o seu salario: ");
			scanf("%f",&salario);
			
			novosal=salario*A+salario;
			
			printf("O seu novo salario e: R$%.2f",novosal);
		}
}
