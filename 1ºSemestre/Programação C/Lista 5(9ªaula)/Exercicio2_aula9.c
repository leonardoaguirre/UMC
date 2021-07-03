#include<stdio.h>
main(){
	int N1,N2,tent=0;
	do{
		printf("Jogador 1 Digite um numero entre 1 e 10!");
		scanf("%d",&N1);
		if(N1<1 || N1>10){
			printf("\nNumero incorreto, por favor digite um numero entre 1 e 10");
		}
	}while(N1<1 || N1>10);
	
	do{
		printf("\nJogador 2, por favor tente acertar o numero que o jogador 1 digitou: (numero entre 1 e 10) ");
		scanf("%d",&N2);
		tent++;
		if(N1!=N2){
			printf("\nVoce errou, tente novamente!");
		}
	}while(N1!=N2);
	printf("\nVoce acertou! A quantidade tentativas foi: %d ",tent);
}
