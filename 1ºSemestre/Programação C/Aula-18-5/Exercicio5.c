#include<stdio.h>
#include<math.h>
 	int n;
	float raiz;
	char resp;
main(){
	
	
	
	printf("\nPrograma que calcula raiz quadrada");
	do{
	if(n>=0){
		printf("\nEntre com o numero: ");
		scanf("%d",&n);
		raiz=sqrt(n);
		printf("\nRaiz quadrada de %d = %f",n,raiz);

	}else{
		printf("\nNão calculo a raiz quadrada de numeros negativos");
	}
	printf("\nOutro numero? (s/n)");
	scanf(" %c",&resp);
	
	}while(resp=='s');
}

