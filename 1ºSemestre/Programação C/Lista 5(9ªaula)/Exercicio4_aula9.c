#include<stdio.h>
#include<string.h>
main(){
	int i,cod;
	float valor,qtd,total;
	char resp;
		printf("Algoritmo que vai lendo o codigo do item pedido, a quantidade e va calculando o valor total a ser pago pelo pedido.");
		resp='s';
		printf("\nCodigo   Especificacao    Preco(R$)\n100      Cachorro quente   2,50\n101      Bauru simples     2,00\n102      Bauru c/ovo       3,50\n103      Hamburger         5,10\n104      Cheeseburger      3,30\n105      Refrigerante      2,00 ");

		while(resp=='s' || resp=='S'){
			do{
			printf("\nQual o produto que deseja comprar? Digite o codigo:");
			scanf("%d",&cod);
			if((cod<100 || cod>105)){
				printf("Codigo invalido! Pro favor digite um valido");
			}
		 }while(cod<100 || cod>105);
		switch(cod){
				case 100:
				valor=2.50;break;
				case 101:
				valor=2.00;break;
				case 102:
				valor=3.50;break;
				case 103:
				valor=5.10;break;
				case 104:
				valor=3.30;break;
				case 105:
				valor=2.00;break;
		}
		printf("\nQual a quantidade que deseja comprar? ");
		scanf("%f",&qtd);
		total = total+(valor*qtd);
		printf("\nO valor da conta final e: R$%.2f",total);
		do{
		printf("\nDeseja comprar mais? (S/N)");
		scanf("%s",&resp);
		}while(resp!='S' && resp!='s' && resp!='N' && resp!='n');	
}
}
