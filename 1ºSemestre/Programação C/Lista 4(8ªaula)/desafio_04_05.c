#include<stdio.h>
main(){
	int i=1,idade,peso,pessoaIdade=0,nIdade=0,somaIdades=0,nAzul=0,nRuivos=0;
	char corOlhos,corCabelo;
	float altura,mediaIdade,porAzul;
	printf("Programa que recebe a idade, o peso, a altura e a cor dos olhos e a cor dos cabelos de 20 pessoas\n");
	printf("A quantidade de pessoas com idade superior a 50 anos e peso inferior a 60 quilos\n");
	printf("A média das idades das pessoas com altura inferior a 1,5\n");
	printf("A percentagem de pessoas com olhos azuis entre todas as analisadas\n");
	printf("A quantidade de pessoas ruivas e que não possuem olhos azuis\n");
		
	do{
		printf("\nPessoa numero %d\n",i);
		printf("\nQual a sua idade? ",idade);
		scanf("%d",&idade);
		printf("\nQual o seu peso? ",peso);
		scanf("%d",&peso);
		printf("\nQual a sua altura? ",altura);
		scanf("%f",&altura);
		printf("\nQual a cor dos seus olhos? (A-azul, P-Preto, V-Verde ou C-Castanho) ",corOlhos);
		scanf(" %c",&corOlhos);
		printf("\nQual a cor do seu cabelo? (P-Preto, C-Castanho, L-Louro ou R-Ruivo) ",corCabelo);
		scanf(" %c",&corCabelo);
		
		if((idade>50) && (peso<60)){
			pessoaIdade=pessoaIdade+1;
		}
		if(altura<1,5){
			nIdade=nIdade+1;
			somaIdades=somaIdades+idade;
		}
		if(corOlhos='A'){
			nAzul=nAzul+1;
		}
		if((corCabelo='R') && (corOlhos!='A')){
			nRuivos=nRuivos+1;
		}
		i++; 
	}while(i<=2);
	mediaIdade=somaIdades/nIdade;
	porAzul=(nAzul/20)*100;
	
	printf("\nA quantidade de pessoas com idade superior a 50 anos e peso inferior a 60 quilos e: %d",pessoaIdade);
	printf("\nA media das idades das pessoas com altura inferior a 1,5 e: %.2f",mediaIdade);
	printf("\nA percentagem de pessoas com olhos azuis entre todas as analisadas e: %.2f",porAzul);
	printf("\nA quantidade de pessoas ruivas e que nao possuem olhos azuis e: %d",nRuivos);
	
}
