#include<stdio.h>
main(){
	int i,aprovado=0,reprovado=0,exame=0;
	float r,n1,n2;
	printf("Programa que receba duas notas de 60 alunos e calcule a média aritmetica para cada alunos. Exiba quantos alunos estao aprovados, quantos estao reprovados e quantos estao de exame\n");
	
	for(i=1;i<=60;i++){
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
		
		printf("\nA media do aluno %d e: %.1f\n",i,r);
		
		if(r>=5){
			printf("\nAprovado\n");
			aprovado=aprovado+1;
		}else if(r<3){
			printf("\nReprovado\n");
			reprovado=reprovado+1;
		}else{
			printf("\nExame\n");
			exame=exame+1;
		}
		}
		printf("\nAlunos aprovados: %d\nAlunos reprovados: %d\nAlunos de exame: %d",aprovado,reprovado,exame);
}
