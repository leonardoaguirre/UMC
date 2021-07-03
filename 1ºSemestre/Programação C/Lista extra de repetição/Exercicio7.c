#include<stdio.h>
main(){
	float s1=0,s2=0,s3=0,i,idade,si=0,rm,per;

		printf("Programa que recebe a idade, o peso e a altura de 25 pessoas.Calcula e mostra:\na. A media da idade das pessoas;\nb. A quantidade de pessoas com peso acima de 90 quilos e altura inferior a 1.60;\nc. O percentual de pessoas com idade entre 21 e 30 anos entre as pessoas que medem mais de 1.9;");			
		printf("\nDigite o numero de funcionarios: ");
			scanf("%f",&nfun);
			for(i=1;i<=25;i++){
				printf("\nDigite a idade da %d pessoa: ",i);
				scanf("%f",&idade);
				printf("\nDigite o peso da %d pessoa: ",i);
				scanf("%f",&peso);
				printf("\nDigite a altura da %d pessoa: ",i);
				scanf("%f",&altura);
				si=si+idade;
				if(peso>90 && altura<1.60){
					s2++;
				}
				if(idade>=21 && idade<=30 && altura>1.9){
					s3++;
				}
			}
			rm=si/25;
			per=s3/25*100;
		printf("\nA media da idade das pessoas e de: %.2f\nA quantidade de pessoas com peso acima de 90 quilos e altura inferior a 1.60 e de: %.0f\nO percentual de pessoas com idade entre 21 e 30 anos entre as pessoas e de: R$%.2f",rm,s2,per);
		}

