#include<stdio.h>
main(){
	int total=0,s1=0,i,sal,media;
	float per,s2=0,nfun;
	
		printf("Programa que recebe o salario de N funcionários. Calcula e mostra:\na. O valor total pago a todos os funcionarios;\nb. A quantidade de funcionarios que recebem mais de R$ 2500.00;\nc. A media dos salarios;\nd. O percentual de funcionarios que recebem menos de R$ 1300.00;");
			printf("\nDigite o numero de funcionarios: ");
			scanf("%f",&nfun);
			for(i=1;i<=nfun;i++){
				do{
				printf("\nDigite o salario do %d funcionario: ",i);
				scanf("%d",&sal);
				if(sal<0){
					printf("\nSalario incorreto!");
				}
				}while(sal<0);
				total=total+sal;
				if(sal>=2500){
					s1++;
				}
				if(sal<1300){
					s2++;
				}
			}
			media=total/nfun;
			per=s2/nfun*100;
		printf("\nO valor total pago a todos os funcionarios e de: R$%d\nA quantidade de funcionarios que recebem mais de R$ 2500.00 e de: %d\nA media dos salarios e de: R$%d\nO percentual de funcionarios que recebem menos de R$ 1300.00 e de: %.2f",total,s1,media,per);
		}

