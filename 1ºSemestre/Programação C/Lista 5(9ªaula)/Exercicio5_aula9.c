#include<stdio.h>
#include<string.h>
main(){
	float preco,pais,imposto,valorImposto,valorTrans,seguro;
	char transporte,carga,resp;
		printf("Programa que recebe os dados de 5 produtos: preço unitario, pais de origem (1–EUA,2–Mexico e 3–outros), meio de transporte (T–Terrestre,F-Fluvial e A–Aereo), carga perigosa (S–Sim, N-Não). Calcule e mostre: O valor do imposto calculado, O valor de transporte e O valor do seguro");
	resp='s';
	while(resp=='s' || resp=='S'){
		
	printf("\nQual e o preco do seu produto?");
	scanf("%f",&preco);
	
	do{
	printf("\nQual e o pais de origem? (1–EUA,2–Mexico e 3–outros) ");
	scanf("%f",&pais);
	}while(pais!=1 && pais!=2 && pais!=3);
	
	do{
	printf("\nQual e o meio de transporte? (T–Terrestre,F-Fluvial e A–Aereo) ");
	scanf("%c",&transporte);
	}while(transporte!='t' && transporte!='T' && transporte!='f' && transporte!='F' && transporte!='A' && transporte!='a');
	
	do{
	printf("\nE carga perigosa? (S/N) ");
	scanf("%c",&carga);
	}while(carga!='s' && carga!='S' && carga!='n' && carga!='N');
	
	if(preco<100){
		imposto=0.05;
	}else{
		imposto=0.1;
	}
	if(pais==1 && carga=='s' || carga=='S'){
		valorTrans=50;
	}
	else if(pais==2 && carga=='s' || carga=='S'){
		valorTrans=35;
	}
	else if(pais==3 && carga=='s' || carga=='S'){
		valorTrans=24;
	}
	else if(pais==1 && carga=='n' || carga=='N'){
		valorTrans=12;
	}
	else if(pais==2 && carga=='n' || carga=='N'){
		valorTrans=35;
	}
	else if(pais==3 && carga=='n' || carga=='N'){
		valorTrans=60;
	}
	if(pais==2 && transporte=='a' || transporte=='A'){
		seguro=preco/2;
	}
	valorImposto=preco*imposto;
	printf("O valor de imposto a se pagar e: R$%.2f \nO valor de transporte a se pagar e: R$%.2f\nO valor de seguro a se pagar e: R$%.2f",valorImposto,valorTrans,seguro);
	do{
	printf("\nDeseja realizar o calculo novamente? ");
	scanf("%c",resp);
	}while(resp!='s' && resp!='S' && resp!='n' && resp!='N');
		
}
}
