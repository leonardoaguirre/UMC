#include<stdio.h>
#include<string.h>
main(){
	int i;
	float altura,alto,baixo;
	char nome[20],nomeMaior[20],nomeMenor[20];
	printf("Programa que recebe o nome e a altura de 5 pessoas e informe qual o nome da pessoa mais alta e da pessoa mais baixa.\n");
	for(i=1;i<=5;i++){
		printf("%d pessoa\n",i);
		printf("Digite o seu nome:");
		scanf("%s",&nome);
		printf("Digite a sua altura: ");
		scanf(" %f",&altura);
		
		if(i==1){
			baixo=altura;
			strcpy(nomeMenor,nome);
			alto=altura;
			strcpy(nomeMaior,nome);
		}
		if(altura<baixo){
			baixo=altura;
			strcpy(nomeMenor,nome);
		}
		if(altura>alto){
			alto=altura;
			strcpy(nomeMaior,nome); 
		}
		
	}
	printf("A pessoa mais alta e: %s com %.2f de altura \n E a pessoa mais baixa e: %s com %.2f de altura",nomeMaior,alto,nomeMenor,baixo);
}
