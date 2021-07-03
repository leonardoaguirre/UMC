#include <stdio.h>
/* Função do programa calcular a conta final de um hóspede de um hotel fictício,
contendo: o nome do hóspede, o tipo do apartamento, o número de diárias
utilizadas, o valor unitário da diária, o valor total das diárias, o valor do consumo
interno, o subtotal, o valor da taxa de serviço e o total geral
Programador: Leonardo
Data:08/03/18*/
int main()
{
	float valorconsumo,subtotal,totalgeral,valorunidiaria,taxaserv,numdiaria,retorno,totaldiaria;
	char nome[20],tipoapt;
	
	printf ("Digite o seu nome: ");
	gets(nome);
	printf("TIPO DO APTO. /  preco em reais\n       A      /   150,00  \n       B      /   100,00  \n       C      /   75,00  \n       D      /   50,00\nDigite o tipo de apartamento desejado:");
	scanf("%c",&tipoapt);
	printf ("Digite o numero de diarias utilizadas: ");
	scanf ("%f",&numdiaria);
	printf ("Digite o valor de consumo: ");
	scanf ("%f",&valorconsumo);

	if (tipoapt=='a' || tipoapt=='A' || tipoapt=='b' || tipoapt=='B' || tipoapt=='c' || tipoapt=='C' || tipoapt=='d' || tipoapt=='D')
	{
	 			if (tipoapt=='a' || tipoapt=='A'){
				totaldiaria = numdiaria*150;
				}	
				if(tipoapt=='b' || tipoapt=='B'){
				totaldiaria = numdiaria*100;	
				}
				if(tipoapt=='c' || tipoapt=='C'){
				totaldiaria = numdiaria*75;
				}
				if(tipoapt=='d' || tipoapt=='B'){
				totaldiaria = numdiaria*50;
				}
			subtotal = totaldiaria+valorconsumo;
			taxaserv = subtotal*0.10;
			valorunidiaria = totaldiaria/numdiaria;
			totalgeral = subtotal+taxaserv;
			printf("\nNome: %s\nTipo apartamento: %c\nNumero de diarias: %.0f\nValor unitario da diaria: R$%.2f\nValor total da diaria: R$%.2f\nValor total de consumo: R$%.2f\nSubtotal: R$%.2f\nTaxa de servico: R$%.2f\nValor total geral: R$%.2f",nome,tipoapt,numdiaria,valorunidiaria,totaldiaria,valorconsumo,subtotal,taxaserv,totalgeral);
	}
	else{
			printf("Tipo de apartamento invalido");
	}
}
