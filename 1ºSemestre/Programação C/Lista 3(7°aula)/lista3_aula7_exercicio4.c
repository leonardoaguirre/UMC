#include<stdio.h>
main(){
	float valorconsumo,subtotal,totalgeral,valorunidiaria,taxaserv,numdiaria,retorno,totaldiaria;
	char nome[20],tipoapt;
	
	printf("Programa que calcula a conta final de um hospede\n");
	printf ("Digite o seu nome: ");
	gets(nome);
	printf("TIPO DO APTO. /  preco em reais\n       A      /   150,00  \n       B      /   100,00  \n       C      /   75,00  \n       D      /   50,00\nDigite o tipo de apartamento desejado:");
	scanf("%c",&tipoapt);
	printf ("Digite o numero de diarias utilizadas: ");
	scanf ("%f",&numdiaria);
	printf ("Digite o valor de consumo: ");
	scanf ("%f",&valorconsumo);

	switch (tipoapt)
	{
	 			case 'a': 
	 			case 'A':
				totaldiaria = numdiaria*150;
				subtotal = totaldiaria+valorconsumo;
				taxaserv = subtotal*0.10;
				valorunidiaria = totaldiaria/numdiaria;
				totalgeral = subtotal+taxaserv;
				printf("\nNome: %s\nTipo apartamento: %c\nNumero de diarias: %.0f\nValor unitario da diaria: R$%.2f\nValor total da diaria: R$%.2f\nValor total de consumo: R$%.2f\nSubtotal: R$%.2f\nTaxa de servico: R$%.2f\nValor total geral: R$%.2f",nome,tipoapt,numdiaria,valorunidiaria,totaldiaria,valorconsumo,subtotal,taxaserv,totalgeral);
				break;
					
				case 'b':
				case 'B':
				totaldiaria = numdiaria*100;
				subtotal = totaldiaria+valorconsumo;
				taxaserv = subtotal*0.10;
				valorunidiaria = totaldiaria/numdiaria;
				totalgeral = subtotal+taxaserv;
				printf("\nNome: %s\nTipo apartamento: %c\nNumero de diarias: %.0f\nValor unitario da diaria: R$%.2f\nValor total da diaria: R$%.2f\nValor total de consumo: R$%.2f\nSubtotal: R$%.2f\nTaxa de servico: R$%.2f\nValor total geral: R$%.2f",nome,tipoapt,numdiaria,valorunidiaria,totaldiaria,valorconsumo,subtotal,taxaserv,totalgeral);	
				break;
				
				case 'c':
				case 'C':
				totaldiaria = numdiaria*75;
				subtotal = totaldiaria+valorconsumo;
				taxaserv = subtotal*0.10;
				valorunidiaria = totaldiaria/numdiaria;
				totalgeral = subtotal+taxaserv;
				printf("\nNome: %s\nTipo apartamento: %c\nNumero de diarias: %.0f\nValor unitario da diaria: R$%.2f\nValor total da diaria: R$%.2f\nValor total de consumo: R$%.2f\nSubtotal: R$%.2f\nTaxa de servico: R$%.2f\nValor total geral: R$%.2f",nome,tipoapt,numdiaria,valorunidiaria,totaldiaria,valorconsumo,subtotal,taxaserv,totalgeral);
				break;
				
				case 'd':
				case 'D':
				totaldiaria = numdiaria*50;
				subtotal = totaldiaria+valorconsumo;
				taxaserv = subtotal*0.10;
				valorunidiaria = totaldiaria/numdiaria;
				totalgeral = subtotal+taxaserv;
				printf("\nNome: %s\nTipo apartamento: %c\nNumero de diarias: %.0f\nValor unitario da diaria: R$%.2f\nValor total da diaria: R$%.2f\nValor total de consumo: R$%.2f\nSubtotal: R$%.2f\nTaxa de servico: R$%.2f\nValor total geral: R$%.2f",nome,tipoapt,numdiaria,valorunidiaria,totaldiaria,valorconsumo,subtotal,taxaserv,totalgeral);
				break;
				
				default: printf("Tipo de apartamento invalido"); break;
			
			
	}
}
