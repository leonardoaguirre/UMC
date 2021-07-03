#include <stdio.h>
/* Função do programa calcular o valor do imposto (Renda Líquida * Alíquota) a ser
pago por um contribuinte. 
Programador: Leonardo
Data:08/03/18*/
main ()
{
	char nome[20],cpf[11];
	float renda, rendaliquida,imposto;
	int dependentes;
	printf ("Digite o seu nome: ");
	scanf ("%s", &nome);
	printf ("Digite o seu cpf: ");
	scanf ("%s", &cpf);
	printf ("Digite a sua renda: ");
	scanf ("%f", &renda);
	printf ("Digite quantos dependentes voce tem: ");
	scanf ("%d", &dependentes);
	
	rendaliquida= renda-(dependentes*110);
	
	if(rendaliquida>800){
		
		if(rendaliquida>=800 && rendaliquida<=4000){
			imposto = rendaliquida*0.025;
		}
		if(rendaliquida>=4001 && rendaliquida<=9000){
			imposto = rendaliquida*0.05;
		}
		if (rendaliquida>9000){
			imposto = rendaliquida*0.1;
		}
		
	printf("ola, %s portador do cpf: %s",nome,cpf);
	printf("O imposto a ser pago e: R$%.2f , sob a renda liquida de: R$%.2f",imposto,rendaliquida);
	
	}else{
	printf("Isento de imposto");	
	}
}

