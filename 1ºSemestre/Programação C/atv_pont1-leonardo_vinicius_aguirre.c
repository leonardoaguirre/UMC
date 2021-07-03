#include<stdio.h>
/*Programador: leonardo Vinicius Aguiire  RGM:11181502271
Data: 06/04/2018
Atividade pontuada 1*/
main(){
float larg,comp,area,iptu,desc,iptufinal,asp;

printf("Por favor escreva a largura do seu terreno: ");
scanf("%f", &larg);
printf("Por favor escreva o comprimento do seu terreno: ");
scanf("%f", &comp);

	if(larg>0 && comp>0){
		area=larg*comp;
		iptu=area*17;
		asp=20/area;
		asp=asp*100;
		
			if(asp>=5 && asp<=10){
				desc=iptu*0.05;
			}
			else if(asp>=11 && asp<=20){
				desc=iptu*0.10;
			}
			else if(asp>=21 && asp<=30){
				desc=iptu*0.15;
			}
			else if(asp>=31 && asp<=40){
				desc=iptu*0.20;
			}
			
			iptufinal=iptu-desc;
			
			
			printf("A area total do seu terreno e: %.0fm²\nO seu IPTU total e: R$%.2f\nA porcentagem de ASP do terreno e: %.0f\nO IPTU com desconto e: R$%.2f",area,iptu,asp,iptufinal);
	}else{
		printf("Dados invalidos!");
	}
}
