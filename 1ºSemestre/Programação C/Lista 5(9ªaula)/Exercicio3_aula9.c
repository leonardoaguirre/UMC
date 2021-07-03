#include<stdio.h>
#include<string.h>
main(){
	int i,r1,r2,reprov=0,aprov=0,peca;
	char estado[10];
		printf("Algoritmo que cadastra o controle de qualidade, imprimir os numeros das pecas reprovadas, e o total de pecas aprovadas e reprovadas no final do dia.");
	for(i=1;i<400;i++){
		peca=i;
		
		do{
		printf("\nQual e o estado da peca? (aprovado/reprovado) ");
		scanf("%s",&estado);
		
		r1=strcmp(estado,"aprovado");
		r2=strcmp(estado,"reprovado");
		
		if(r1!=0 && r2!=0){
			printf("\nEstado invalido, por favor digite um estado valido!");
		}
		}while(r1!=0 && r2!=0);

		if(r2==0){
			printf("\nEssa peca foi reprovada e o seu numero e : %d",i);
			reprov++;
		}else{
			printf("\nA peca foi aprovada!");
			aprov++;
		}
	}
	printf("\nA quantidade de pecas aprovadas foi: %d e a de reprovadas foi: %d",aprov,reprov);
}
