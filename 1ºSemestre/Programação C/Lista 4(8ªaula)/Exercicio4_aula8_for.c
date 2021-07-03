#include<stdio.h>
main(){
	int i,n,num,r;
	printf("Exbição do quadrado de n numeros\n");
	printf("Digite a quantidade de numeros que ira digitar ");
	scanf("%d",&n);
	for(i=1;i<=n;i++){
		
		printf("Digite o %d numero:",i);
		scanf("%d",&num);
		r=num*num;
		printf("O quadrado desse numero e: %d\n",r);
	}
}
