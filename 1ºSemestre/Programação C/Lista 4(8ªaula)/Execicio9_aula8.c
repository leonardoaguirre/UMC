#include<stdio.h>
main(){
	int i;
	float r,media,mediaGeral,n1,n2;
	
		printf("Programa que receba duas notas de 10 alunos e calcule a média para cada um deles e exiba a média individual dos alunos e a média total.\n");
		
	for(i=1;i<=10;i++){
		
		printf("\nAluno %d ",i);
		
		do{
			printf("\nDigite a nota 1:");
			scanf("%f",&n1);
				if(n1>10 || n1<0){
				printf("Nota invalida, notas aceitas somente entre 1 e 10!");
			}
		}while(n1>10 || n1<0);
		
		do{
			printf("\nDigite a nota 2:");
			scanf("%f",&n2);
				if(n2>10 || n2<0){
				printf("Nota invalida, notas aceitas somente entre 1 e 10!");
			}
		}while(n2>10 || n2<0);
	
		r=(n1+n2)/2;
		media=r+media;
		printf("\nA media do aluno %d e: %.1f\n",i,r);
		
		}
		mediaGeral=media/10;
		printf("\nA media total e: %.1f",mediaGeral);
}
