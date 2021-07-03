#include<stdio.h>
main(){
	
	int N,f;
	float n1,n2,m;
	printf("Calculo da media de N alunos\n");
	printf("Digite a quantidade de alunos:");
	scanf("%d",&N);
	
	for(f=1;f<=N;f++){
		printf("%d aluno\n",f);
		printf("Digite N1:");
		scanf("%f",&n1);
		printf("Digite N2:");
		scanf("%f",&n2);
		m=(n1+n2)/2;
		printf("Sua media e de %.2f\n",m);
	}
}
