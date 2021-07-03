#include<stdio.h>
main(){
	int n1,n2,i,r;
	
	printf("Programa que executa a tabuada que voce deseja\n");
	printf("Qual numero deseja multiplicar? ");
	scanf("%d",&n1);
	printf("Ate qual numero deseja multiplicar? ");
	scanf("%d",&n2);
	
	for(i=1;i<=n2;i++){
		r=n1*i;
		printf("%d X %d = %d\n",n1,i,r);
	}
}
